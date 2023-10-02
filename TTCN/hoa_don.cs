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
    public partial class hoa_don : Form
    {
        user User = new user();
        string MAHDC = "";
        SqlConnection Conn = connect.connect_db();
        DataTable table = new DataTable();
        List<TextBox> groupTextBox = new List<TextBox> { };
        public hoa_don(user User)
        {
            InitializeComponent();
            this.User = User;
        }
        private void hoa_don_Load(object sender, EventArgs e)
        {
            Conn.Open();
            string query_full = " select MA_HOA_DON, cast(NGAY_LAP as varchar) as'NGAY_LAP', MA_KHACH_HANG,MA_NHAN_VIEN_KINH_DOANH,MA_NHAN_VIEN_KE_TOAN from HOA_DON";
            table = handleDatagridview.DataSetDatabase(query_full, Conn);
            dataGridViewHOADON.DataSource = table;
            dataGridViewHOADON.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
                string MAHD = "HD" + MAHDM.Text.Trim();
                command.Connection = Conn;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "IDU_HOA_DON";
                command.Parameters.AddWithValue("@action", action);
                command.Parameters.AddWithValue("@MAHDC", MAHDC);
                if (action == "INSERT") { command.Parameters.AddWithValue("@MAHDM", MAHD); }
                else { command.Parameters.AddWithValue("@MAHDM", MAHDM.Text.Trim()); }
                command.Parameters.AddWithValue("@TIME", TIME.Value);
                command.Parameters.AddWithValue("@MAKH", MAKH.Text.Trim());
                command.Parameters.AddWithValue("@MANVKD", MANVKD.Text.Trim());
                command.Parameters.AddWithValue("@MANVKT", User.UserName);
                command.Parameters.AddWithValue("@MANV", User.UserName);

                try
                {
                    if (command.ExecuteNonQuery() > 1)
                    {
                        MessageBox.Show("cập nhập thành công");
                        if (action == "INSERT")
                        {
                            DataRow row = table.Rows.Add();
                            row["MA_HOA_DON"] = MAHD;
                            row["NGAY_LAP"] = TIME.Value;
                            row["MA_KHACH_HANG"] = MAKH.Text.Trim();
                            row["MA_NHAN_VIEN_KINH_DOANH"] = MANVKD.Text.Trim();
                            row["MA_NHAN_VIEN_KE_TOAN"] = User.UserName;
                        }
                        else if (action == "DELETE")
                        {
                            dataGridViewHOADON.Rows.Remove(dataGridViewHOADON.CurrentRow);
                            label2.Visible = false;
                            MANVKT.Visible = false;
                        }
                        else if (action == "UPDATE")
                        {
                            dataGridViewHOADON.CurrentRow.Cells[0].Value = MAHDM.Text.Trim();
                            dataGridViewHOADON.CurrentRow.Cells[1].Value = TIME.Value;
                            dataGridViewHOADON.CurrentRow.Cells[2].Value = MAKH.Text.Trim();
                            dataGridViewHOADON.CurrentRow.Cells[3].Value = MANVKD.Text.Trim();
                            dataGridViewHOADON.CurrentRow.Cells[4].Value = MANVKT.Text.Trim();
                            label2.Visible = false;
                            MANVKT.Visible = false;
                        }
                        MAHD = "";
                        function.clearText(groupTextBox);
                        them.Enabled = true;
                        btnSua.Enabled = false;
                        btnxoa.Enabled = false;
                    }
                }
                catch
                {
                    MessageBox.Show("lỗi trùng mã hóa đơn hoặc mã khách hàng, mã nhân viên không hợp lệ");
                    btnSua.Enabled = true;
                    btnxoa.Enabled = true;
                }
            }
            btnxemChitietHD.Enabled = false;

            
            Conn.Close();
        }
        private void them_Click(object sender, EventArgs e)
        {
            MANVKT.Text = User.UserName;
            if (function.CheckText(groupTextBox) == true)
            {
                if (function.TextNumber(MAHDM))
                {
                    IDU("INSERT");
                }
                else
                {
                    MessageBox.Show("nhập mã hóa đơn là số");
                }
            }
            else
            {
                MessageBox.Show("còn dữ liệu chưa nhập");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {

            IDU("DELETE");


        }

        private void dataGridViewHOADON_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int rowIdex = e.RowIndex;
                MAHDC = dataGridViewHOADON.Rows[rowIdex].Cells[0].Value.ToString();
                MAHDM.Text = dataGridViewHOADON.Rows[rowIdex].Cells[0].Value.ToString();
                TIME.Value = DateTime.Parse(dataGridViewHOADON.Rows[rowIdex].Cells[1].Value.ToString());
                MAKH.Text = dataGridViewHOADON.Rows[rowIdex].Cells[2].Value.ToString();
                MANVKD.Text = dataGridViewHOADON.Rows[rowIdex].Cells[3].Value.ToString();
                MANVKT.Text = dataGridViewHOADON.Rows[rowIdex].Cells[4].Value.ToString();
            }
            btnSua.Enabled = true;
            btnxoa.Enabled = true;
            them.Enabled = false;
            btnxemChitietHD.Enabled = true;
            label2.Visible = true;
            MANVKT.Visible = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            IDU("UPDATE");
        }

        private void timkiem_Click(object sender, EventArgs e)
        {
            groupBoxTimKiem.Visible = true;
        }

        private void btnseach_Click(object sender, EventArgs e)
        {
            Conn.Open();
              string query = $"select * from dbo.Func_SearchHoaDon ('{textBoxSearch.Text.Trim()}')";
              dataGridViewHOADON.DataSource= handleDatagridview.DataSetDatabase(query, Conn);
            Conn.Close();                     
        } 
        private void btnCloseGrSeach_Click(object sender, EventArgs e)
        {
            groupBoxTimKiem.Visible = false;
            dataGridViewHOADON.DataSource = table;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            
            string query = $"select * from dbo.Func_SearchHoaDon ('{textBoxSearch.Text.Trim()}')";
            dataGridViewHOADON.DataSource = handleDatagridview.DataSetDatabase(query, Conn);
        }

        private void btnxemChitietHD_Click(object sender, EventArgs e)
        {
                hoadon hoadon = new hoadon();
                hoadon.MA_HOA_DON = MAHDM.Text.Trim();
                hoadon.NGAY_LAP = TIME.Value.ToString();
                hoadon.MA_KHACH_HANG = MAKH.Text.Trim();
                hoadon.MA_NHAN_VIEN_KINH_DOANH = MANVKD.Text.Trim();
                hoadon.MA_NHAN_VIEN_KE_TOAN = MANVKT.Text.Trim();
                chi_tiet_hoa_don chi_Tiet_Hoa_Don = new chi_tiet_hoa_don(hoadon, User);
            chi_Tiet_Hoa_Don.ShowDialog();
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
