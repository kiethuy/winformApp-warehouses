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

namespace WindowsFormsApp1
{

    public partial class khach_hang : Form
    {
        private user User = new user();
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlConnection Connect = connect.connect_db();
        List<TextBox> groupTextBox = new List<TextBox> { };
        string MAKHC;
        static SqlCommand command = new SqlCommand();
        public khach_hang(user user)
        {
            this.User = user;
            InitializeComponent();
        }
        private void loadGridfullkh(DataGridView dataGridView)
        {
            string query = "select * from KHACH_HANG";
            function.load_gridview(ref dataGridView, query, this.adapter, Connect);
        }
        private void khach_hang_Load(object sender, EventArgs e)
        {
            function.SelectGroupBox(this.groupBoxMenu, User);
            loadGridfullkh(dataGridViewKh);
            Connect.Open();
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            var gr = groupBoxChitiet.Controls.OfType<TextBox>().OrderBy(t => t.TabIndex);
            gr.ToList().ForEach(grtextb => groupTextBox.Add(grtextb));

            dataGridViewKh.Columns["DIA_CHI"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (function.CheckText(groupTextBox) == false)
            {
                MessageBox.Show("có dữ liệu chưa được nhập");
            }
            else
            {
                if (function.TextNumber(SDT) == true)
                {
                    if (exec.execProc(command, Connect, groupTextBox, User, "INSERT_KHACH_HANG") == true)
                    {
                        MessageBox.Show("đã thêm dữ liệu");
                        loadGridfullkh(dataGridViewKh);
                        
                    }
                    else
                    {
                        MessageBox.Show("them dl thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("vui lòng nhập số điện thoại là số");
                }
              
            }
            command.Parameters.Clear();
        }

        private void dataGridViewKh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int rowIdex = e.RowIndex;
                MAKHC = dataGridViewKh.Rows[rowIdex].Cells[0].Value.ToString();

                for (int i = 0; i < dataGridViewKh.Rows[rowIdex].Cells.Count; i++)
                {
                    groupTextBox.ToList()[i].Text = dataGridViewKh.Rows[rowIdex].Cells[i].Value.ToString();

                }
                btnsua.Enabled = true;
                btnxoa.Enabled = true;
                btnthem.Enabled = false;
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@MAKHC", MAKHC);
            command.Parameters.AddWithValue("@MANV", User.UserName);
            if (function.RowChange(command, "DELETE_KHACH_HANG", Connect) > 0)
            {
                MessageBox.Show("xóa thành công");
                
                loadGridfullkh(dataGridViewKh);
                function.clearText(groupTextBox);
                btnsua.Enabled = false;
                btnxoa.Enabled = false;
                btnthem.Enabled = true;
            }
            else
            {
                MessageBox.Show("xóa không thành công");
            }
            command.Parameters.Clear();
        }
        private void btnsua_Click(object sender, EventArgs e)
        {
            if (function.CheckText(groupTextBox) == false)
            {
                MessageBox.Show("có dữ liệu chưa được nhập");
            }
           
            else
            {
                if (function.TextNumber(SDT))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MAKHC", MAKHC);
                    foreach (var texbox in groupTextBox)
                    {
                        command.Parameters.AddWithValue($"@{texbox.Name}", texbox.Text);
                    }
                    command.Parameters.AddWithValue("@MANV", User.UserName);
                    if (function.RowChange(command, "UPDATE_KHACH_HANG", Connect) > 0)
                    {
                        MessageBox.Show("cập nhập thành công");
                        loadGridfullkh(dataGridViewKh);
                      
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
                else { MessageBox.Show("vui lòng sdt đúng định dạng"); }
               
            }
            command.Parameters.Clear();
        }

        private void btnCloseAction_Click(object sender, EventArgs e)
        {
            function.clearText(groupTextBox);
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnthem.Enabled = true;
        }

        private void timkiem_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> comboSource = new Dictionary<string, string>();
            foreach (DataGridViewColumn colum in dataGridViewKh.Columns)
            {
                comboSource.Add(colum.Name, colum.Name);
            }
            comboBoxSelectSeach.DataSource = new BindingSource(comboSource, null);
            comboBoxSelectSeach.DisplayMember = "Value";
            comboBoxSelectSeach.ValueMember = "Key";
            groupBoxTimKiem.Visible = true;
            timkiem.Enabled = false;
        }

        private void btnseach_Click(object sender, EventArgs e)
        {
            string Seach = comboBoxSelectSeach.SelectedValue.ToString();
            string query = $"SELECT * FROM KHACH_HANG WHERE {Seach} like N'%{textBoxSeach.Text.Trim()}%' ";
            function.load_gridview(ref dataGridViewKh, query, adapter, Connect);
            
            btnloadgrid.Visible = true;
            
            textBoxSeach.Clear();
        }

        private void btnCloseGrSeach_Click(object sender, EventArgs e)
        {
            groupBoxTimKiem.Visible = false;
            timkiem.Enabled = true;
        }

        private void btnloadgrid_Click(object sender, EventArgs e)
        {
            loadGridfullkh(dataGridViewKh);
            btnloadgrid.Visible = false;
        }
    }
}
