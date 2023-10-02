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
    public partial class chi_tiet_hoa_don_full : Form
    {
        user User = new user();
        DataTable table = new DataTable();
        SqlConnection Connection = connect.connect_db();
        string mahd = "";
        public chi_tiet_hoa_don_full(user user)
        {
            this.User = user;
            InitializeComponent();
        }

        private void chi_tiet_hoa_don_full_Load(object sender, EventArgs e)
        {
            Connection.Open();
            string query = "select * from CHI_TIET_HOA_DON";
            table = handleDatagridview.DataSetDatabase(query, Connection);
            dataGridViewCHITIETHDfull.DataSource = table;
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string search = $"select* from Func_SearchCTHoaDon('{textTimkiem.Text.Trim()}')";
            dataGridViewCHITIETHDfull.DataSource = handleDatagridview.DataSetDatabase(search, Connection);

        }

        private void dataGridViewCHITIETHDfull_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnXemh.Visible = true;
            if (e.RowIndex >= 0)
            {
                int rowIdex = e.RowIndex;
                mahd = dataGridViewCHITIETHDfull.Rows[rowIdex].Cells[0].Value.ToString();

            }
        }

        private void btnCloseGrtimkiem_Click(object sender, EventArgs e)
        {
            dataGridViewCHITIETHDfull.DataSource = table;
        }

        private void btnXemhd_Click(object sender, EventArgs e)
        {
            string query_HD = $"select * from HOA_DON where MA_HOA_DON='{mahd}'";
            using(SqlCommand command= new SqlCommand(query_HD, Connection))
            {
                using (hoadon hoadon = new hoadon())
                {
                    using (SqlDataReader result = command.ExecuteReader())
                    {
                        while (result.Read())
                        {
                            hoadon.MA_HOA_DON = result["MA_HOA_DON"].ToString();
                            hoadon.NGAY_LAP = result["NGAY_LAP"].ToString();
                            hoadon.MA_KHACH_HANG = result["MA_KHACH_HANG"].ToString();
                            hoadon.MA_NHAN_VIEN_KINH_DOANH = result["MA_NHAN_VIEN_KINH_DOANH"].ToString();
                            hoadon.MA_NHAN_VIEN_KE_TOAN = result["MA_NHAN_VIEN_KE_TOAN"].ToString();
                        }
                        using (chi_tiet_hoa_don chi_Tiet_Hoa_Don = new chi_tiet_hoa_don(hoadon, User))
                        {
                            chi_Tiet_Hoa_Don.ShowDialog();
                        }
                    }     
                }          
            }
        }

        private void textTimkiem_TextChanged(object sender, EventArgs e)
        {
            string search = $"select* from Func_SearchCTHoaDon('{textTimkiem.Text.Trim()}')";
            dataGridViewCHITIETHDfull.DataSource = handleDatagridview.DataSetDatabase(search, Connection);
        }
    }
}
