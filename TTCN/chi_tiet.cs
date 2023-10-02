using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using WindowsFormsApp1.model;
namespace WindowsFormsApp1
{
    public partial class chi_tiet : Form
    {
        private user User = new user();
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlConnection Connect = connect.connect_db();
        List<TextBox> groupTextBox = new List<TextBox> { };
        string MACTC;

        static SqlCommand command = new SqlCommand();
        private void loadGridfullChitiet(DataGridView dataGridView)
        {
            string query = "select * from CHI_TIET";
            function.load_gridview(ref dataGridView, query, this.adapter, Connect);
        }

        public chi_tiet(user user)
        {
            InitializeComponent();
            this.User = user;
        }


        private void chi_tiet_Load(object sender, EventArgs e)
        {
            function.SelectGroupBox(this.groupBoxMenu, User);
            loadGridfullChitiet(dataGridViewchitiet);
            Connect.Open();
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            var gr = groupBoxChitiet.Controls.OfType<TextBox>().OrderBy(t => t.TabIndex);
            gr.ToList().ForEach(grtextb => groupTextBox.Add(grtextb));
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
           if(function.CheckText(groupTextBox) == false)
            {
                MessageBox.Show("có dữ liệu chưa được nhập");
            }
            else
            {
                if (exec.execProc(command, Connect, groupTextBox, User, "Insert_CT") == true)
                {
                    MessageBox.Show("đã thêm dữ liệu");
                    loadGridfullChitiet(dataGridViewchitiet);
                    command.Parameters.Clear();
                }
                else { 
                    MessageBox.Show("them dl thất bại");
                    foreach(SqlParameter  a in command.Parameters)
                    {
                        MessageBox.Show(a.ParameterName, a.Value.ToString());
                    }
                
                        }
            }
        }

        private void dataGridViewchitiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int rowIdex = e.RowIndex;
                MACTC = dataGridViewchitiet.Rows[rowIdex].Cells[0].Value.ToString();

                for (int i = 0; i < dataGridViewchitiet.Rows[rowIdex].Cells.Count; i++)
                {
                    groupTextBox.ToList()[i].Text = dataGridViewchitiet.Rows[rowIdex].Cells[i].Value.ToString();

                }
                btnsua.Enabled = true;
                btnxoa.Enabled = true;
                btnthem.Enabled = false;
            }
        }

        private void btnCloseAction_Click(object sender, EventArgs e)
        {
            function.clearText(groupTextBox);
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnthem.Enabled = true;

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@MACTC", MACTC);
            command.Parameters.AddWithValue("@MANV", User.UserName);
            if (function.RowChange(command, "DELETE_CT", Connect) > 0)
            {
                MessageBox.Show("xóa thành công");
                command.Parameters.Clear();
                loadGridfullChitiet(dataGridViewchitiet);
                function.clearText(groupTextBox);
                btnsua.Enabled = false;
                btnxoa.Enabled = false;
                btnthem.Enabled = true;
            }
            else
            {
                MessageBox.Show("xóa không thành công");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (function.CheckText(groupTextBox) == false)
            {
                MessageBox.Show("có dữ liệu chưa được nhập");
            }
            else
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MACTC", MACTC);
                foreach (var texbox in groupTextBox)
                {
                    command.Parameters.AddWithValue($"@{texbox.Name}", texbox.Text);
                }
                command.Parameters.AddWithValue("@MANV", User.UserName);
                if (function.RowChange(command, "UPDATE_CT", Connect) > 0)
                {
                    MessageBox.Show("cập nhập thành công");
                    loadGridfullChitiet(dataGridViewchitiet);
                    command.Parameters.Clear();
                    function.clearText(groupTextBox);
                    btnsua.Enabled = false;
                    btnxoa.Enabled = false;
                    btnthem.Enabled = true;

                }
                else
                {
                    MessageBox.Show("cập nhập không thành công");
                }
            }
        }

        private void timkiem_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> comboSource = new Dictionary<string, string>();
            foreach (DataGridViewColumn colum in dataGridViewchitiet.Columns)
            {
                comboSource.Add(colum.Name, colum.Name);
            }
            comboBoxSelectSeach.DataSource = new BindingSource(comboSource, null);
            comboBoxSelectSeach.DisplayMember = "Value";
            comboBoxSelectSeach.ValueMember = "Key";
            groupBoxTimKiem.Visible = true;
        }

        private void btnCloseGrSeach_Click(object sender, EventArgs e)
        {
            groupBoxTimKiem.Visible = false;
        }

        private void btnseach_Click(object sender, EventArgs e)
        {
            string Seach = comboBoxSelectSeach.SelectedValue.ToString();
            string query = $"SELECT * FROM CHI_TIET WHERE {Seach} like '%{textBoxSeach.Text}%' ";
            function.load_gridview(ref dataGridViewchitiet, query, adapter, Connect);
            groupBoxTimKiem.Visible = false;
            btnloadgrid.Visible = true;
            textBoxSeach.Clear();
        }

        private void btnloadgrid_Click(object sender, EventArgs e)
        {
            loadGridfullChitiet(dataGridViewchitiet);
            btnloadgrid.Visible = false;
        }
    }
}
