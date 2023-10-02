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
using WindowsFormsApp1.model;

namespace WindowsFormsApp1
{
    public partial class nha_cung_cap : Form
    {
        private user User = new user();
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlConnection Connect = connect.connect_db();
        List<TextBox> groupTextBox = new List<TextBox> { };
        string MANCCC;
        static SqlCommand command = new SqlCommand();
        public nha_cung_cap(user user)
        {
            InitializeComponent();
            this.User = user;
        }

        private void loadGridfullncc(DataGridView dataGridView)
        {
            string query = "select * from NHA_CUNG_CAP";
            function.load_gridview(ref dataGridView, query, this.adapter, Connect);
        }
        private async void nha_cung_cap_Load(object sender, EventArgs e)
        {
            //function.SelectGroupBox(this.groupBoxMenu, User);
            //loadGridfullncc(dataGridViewNCC);
            //Connect.Open();
            //var gr = groupBoxChitiet.Controls.OfType<TextBox>().OrderBy(t => t.TabIndex);
            //gr.ToList().ForEach(grtextb => groupTextBox.Add(grtextb));
            TTCN dbTTCN = new TTCN();
            DataTable table = new DataTable();
           dataGridViewNCC.DataSource= dbTTCN.NHA_CUNG_CAP.ToList();

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (function.CheckText(groupTextBox) == false)
            {
                MessageBox.Show("có dữ liệu chưa được nhập");
            }
            else
            {
                if (exec.execProc(command, Connect, groupTextBox, User, "INSERT_NCC") == true)
                {
                    MessageBox.Show("đã thêm dữ liệu");
                    loadGridfullncc(dataGridViewNCC);
                    command.Parameters.Clear();
                    btnsua.Enabled = false;
                    btnxoa.Enabled = false;
                    btnthem.Enabled = true;
                }
                else
                {
                    MessageBox.Show("them dl thất bại");
                    foreach (SqlParameter a in command.Parameters)
                    {
                        MessageBox.Show(a.ParameterName, a.Value.ToString());
                    }
                }
            }
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@MANCCC", MANCCC);
            command.Parameters.AddWithValue("@MANV", User.UserName);
            if (function.RowChange(command, "DELETE_NHA_CUNG_CAP", Connect) > 0)
            {
                MessageBox.Show("xóa thành công");
                command.Parameters.Clear();
                loadGridfullncc(dataGridViewNCC);
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
        private void dataGridViewNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int rowIdex = e.RowIndex;
                MANCCC = dataGridViewNCC.Rows[rowIdex].Cells[0].Value.ToString();

                for (int i = 0; i < dataGridViewNCC.Rows[rowIdex].Cells.Count; i++)
                {
                    groupTextBox.ToList()[i].Text = dataGridViewNCC.Rows[rowIdex].Cells[i].Value.ToString();

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

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (function.CheckText(groupTextBox) == false)
            {
                MessageBox.Show("có dữ liệu chưa được nhập");
            }
            else
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MANCCC", MANCCC);
                foreach (var texbox in groupTextBox)
                {
                    command.Parameters.AddWithValue($"@{texbox.Name}", texbox.Text);
                }
                command.Parameters.AddWithValue("@MANV", User.UserName);
                if (function.RowChange(command, "UPDATE_NHA_CUNG_CAP", Connect) > 0)
                {
                    MessageBox.Show("cập nhập thành công");
                    loadGridfullncc(dataGridViewNCC);
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
            foreach (DataGridViewColumn colum in dataGridViewNCC.Columns)
            {
                comboSource.Add(colum.Name, colum.Name);
            }
            comboBoxSelectSeach.DataSource = new BindingSource(comboSource, null);
            comboBoxSelectSeach.DisplayMember = "Value";
            comboBoxSelectSeach.ValueMember = "Key";
            groupBoxTimKiem.Visible = true;
        }

        private void btnseach_Click(object sender, EventArgs e)
        {
            string Seach = comboBoxSelectSeach.SelectedValue.ToString();
            string query = $"SELECT * FROM NHA_CUNG_CAP WHERE {Seach} like '%{textBoxSeach.Text.Trim()}%' ";
            function.load_gridview(ref dataGridViewNCC, query, adapter, Connect);
            groupBoxTimKiem.Visible = false;
            btnloadgrid.Visible = true;
            textBoxSeach.Clear();
        }
        private void btnCloseGrSeach_Click(object sender, EventArgs e)
        {
            groupBoxTimKiem.Visible = false;
        }
        private void btnloadgrid_Click(object sender, EventArgs e)
        {
            loadGridfullncc(dataGridViewNCC);
            btnloadgrid.Visible = false;
        }
    }
}
