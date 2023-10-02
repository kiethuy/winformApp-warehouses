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
namespace WindowsFormsApp1
{
    public partial class phieu_xuat : Form
    {
        user User = new user();
        SqlConnection Conn = connect.connect_db();
        DataTable table = new DataTable();
        List<TextBox> groupTextBox = new List<TextBox> { };
        string MAPXC = "";
        public phieu_xuat(user user)
        {
            InitializeComponent();
            this.User = user;
        }

        private void phieu_xuat_Load(object sender, EventArgs e)
        {
            Conn.Open();
            string query_full = "SELECT * FROM PHIEU_XUAT";
            table = handleDatagridview.DataSetDatabase(query_full, Conn);
            dataGridViewPHIEUXUAT.DataSource = table;
            dataGridViewPHIEUXUAT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            btnSua.Enabled = false;
            btnxoa.Enabled = false;
            function.SelectGroupBox(this.groupBoxMenu, User);
            var gr = groupBoxhoadon.Controls.OfType<TextBox>().OrderBy(t => t.TabIndex);
            gr.ToList().ForEach(grtextb => groupTextBox.Add(grtextb));
            Conn.Close();
        }
        private void IDU(string action)
        {
            Conn.Open();
            using (SqlCommand command = new SqlCommand())
            {
                string MAPX = "PX" + MAPXM.Text.Trim();
                command.Connection = Conn;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "IDU_PHIEU_XUAT";
                command.Parameters.AddWithValue("@action", action);
                command.Parameters.AddWithValue("@MAPXC", MAPXC);
                if (action == "INSERT") { command.Parameters.AddWithValue("@MAPXM", MAPX); }
                else { command.Parameters.AddWithValue("@MAPXM", MAPXM.Text.Trim()); }
                command.Parameters.AddWithValue("@TIME", TIME.Value);
                command.Parameters.AddWithValue("@MANVK", User.UserName);
                command.Parameters.AddWithValue("@MANVKD", MANVKD.Text.Trim());
                command.Parameters.AddWithValue("@MANV", User.UserName);

                //try
                //{
                    if (command.ExecuteNonQuery() > 1)
                {
                        MessageBox.Show("cập nhập thành công");
                        if (action == "INSERT")
                        {
                            DataRow row = table.Rows.Add();
                            row["MA_PHIEU_XUAT"] = MAPX;
                            row["NGAY_XUAT"] = TIME.Value;
                            row["MA_NHAN_VIEN_KHO"] = User.UserName;
                            row["MA_NHAN_VIEN_KINH_DOANH"] = MANVKD.Text.Trim();

                         }
                        else if (action == "DELETE")
                        {
                            dataGridViewPHIEUXUAT.Rows.Remove(dataGridViewPHIEUXUAT.CurrentRow);
                            label1.Visible = false;
                            MANVK.Visible = false;
                        }
                        else if (action == "UPDATE")
                        {
                            dataGridViewPHIEUXUAT.CurrentRow.Cells[0].Value = MAPXM.Text.Trim();
                            dataGridViewPHIEUXUAT.CurrentRow.Cells[1].Value = TIME.Value;
                            dataGridViewPHIEUXUAT.CurrentRow.Cells[2].Value = MANVK.Text.Trim();
                            dataGridViewPHIEUXUAT.CurrentRow.Cells[3].Value = MANVKD.Text.Trim();

                            label1.Visible = false;
                            MANVK.Visible = false;
                        }
                    MAPX = "";
                        function.clearText(groupTextBox);
                        them.Enabled = true;
                        btnSua.Enabled = false;
                        btnxoa.Enabled = false;
                 }
                //}
                //catch
                //{
                //    MessageBox.Show(" mã nhân viên không hợp lệ");
                //    btnSua.Enabled = true;
                //    btnxoa.Enabled = true;
                //}
            }
            btnxemChitietPX.Enabled = false;
            Conn.Close();
        }

        private void them_Click(object sender, EventArgs e)
        {
            MANVK.Text = User.UserName;
            if (function.CheckText(groupTextBox) == true)
            {
                if (function.TextNumber(MAPXM))
                {
                    IDU("INSERT");
                }
                else
                {
                    MessageBox.Show("nhập mã phiếu xuất là số");
                }
            }
            else
            {
                MessageBox.Show("còn dữ liệu chưa nhập");
            }
        }

        private void dataGridViewPHIEUXUAT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int rowIdex = e.RowIndex;
                MAPXC = dataGridViewPHIEUXUAT.Rows[rowIdex].Cells[0].Value.ToString();
                MAPXM.Text = dataGridViewPHIEUXUAT.Rows[rowIdex].Cells[0].Value.ToString();
                TIME.Value = DateTime.Parse(dataGridViewPHIEUXUAT.Rows[rowIdex].Cells[1].Value.ToString());
                MANVK.Text = dataGridViewPHIEUXUAT.Rows[rowIdex].Cells[2].Value.ToString();
                MANVKD.Text = dataGridViewPHIEUXUAT.Rows[rowIdex].Cells[3].Value.ToString();
                
            }
            btnSua.Enabled = true;
            btnxoa.Enabled = true;
            them.Enabled = false;
            btnxemChitietPX.Enabled = true;
            label2.Visible = true;
            MANVK.Visible = true;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            IDU("DELETE");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^PX[0-9]+$");
            if (!regex.IsMatch(MAPXM.Text))
            {
                MessageBox.Show("vui lòng nhập đúng định dạng mã phiếu xuất");
            }
            else
            {
                IDU("UPDATE");
            }
        }

        private void btnxemChitietPX_Click(object sender, EventArgs e)
        {
            using(phieuxuat phieuxuat= new phieuxuat())
            {
                phieuxuat.MA_PHIEU_XUAT = MAPXM.Text;
                phieuxuat.NGAY_XUAT = TIME.Value.ToString();
                phieuxuat.MA_NHAN_VIEN_KHO = MANVK.Text;
                phieuxuat.MA_NHAN_VIEN_KINH_DOANH = MANVKD.Text;
                chi_tiet_phieu_xuat chi_Tiet_Phieu_Xuat = new chi_tiet_phieu_xuat(User, phieuxuat);
                chi_Tiet_Phieu_Xuat.ShowDialog();
            }
        }

        private void timkiem_Click(object sender, EventArgs e)
        {
            Conn.Open();
            groupBoxTimKiem.Visible = true;
        }

        private void btnseach_Click(object sender, EventArgs e)
        {
            
            string query = $"select * from dbo.Func_SearchPHIEUXUAT ('{textBoxSearch.Text.Trim()}')";
            dataGridViewPHIEUXUAT.DataSource = handleDatagridview.DataSetDatabase(query, Conn);
            
        }

        private void btnCloseGrtimkiem_Click(object sender, EventArgs e)
        {
            groupBoxTimKiem.Visible = false;
            dataGridViewPHIEUXUAT.DataSource = table;
            Conn.Close();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {           
            string query = $"select * from dbo.Func_SearchPHIEUXUAT ('{textBoxSearch.Text.Trim()}')";
            dataGridViewPHIEUXUAT.DataSource = handleDatagridview.DataSetDatabase(query, Conn);
            Conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            function.clearText(groupTextBox);
            them.Enabled = true;
            btnSua.Enabled = false;
            btnxoa.Enabled = false;
        }
    }
}
