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
    public partial class chi_tiet_phieu_xuat_full : Form
    {
        user User = new user();
        DataTable table = new DataTable();
        SqlConnection Connection = connect.connect_db();
        string mapx = "";
        public chi_tiet_phieu_xuat_full(user user)
        {
            this.User = user;
            InitializeComponent();
        }

        private void chi_tiet_phieu_xuat_full_Load(object sender, EventArgs e)
        {
            Connection.Open();
            string query = "select * from CHI_TIET_PHIEU_XUAT";
            table = handleDatagridview.DataSetDatabase(query, Connection);
            dataGridViewCHITIETPXfull.DataSource = table;
        }

        private void textTimkiem_TextChanged(object sender, EventArgs e)
        {
            string search = $"select* from Func_SearchCTPhieuXuat('{textTimkiem.Text.Trim()}')";
            dataGridViewCHITIETPXfull.DataSource = handleDatagridview.DataSetDatabase(search, Connection);
        }

        private void dataGridViewCHITIETPXfull_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnXemPX.Visible = true;
            if (e.RowIndex >= 0)
            {
                int rowIdex = e.RowIndex;
                mapx = dataGridViewCHITIETPXfull.Rows[rowIdex].Cells[0].Value.ToString();

            }
        }

        private void btnCloseGrtimkiem_Click(object sender, EventArgs e)
        {
            dataGridViewCHITIETPXfull.DataSource = table;
        }

        private void btnXemPX_Click(object sender, EventArgs e)
        {
            string query_HD = $"select * from PHIEU_XUAT where MA_PHIEU_XUAT='{mapx}'";
            using (SqlCommand command = new SqlCommand(query_HD, Connection))
            {
                using (phieuxuat phieuxuat = new phieuxuat())
                {
                    using (SqlDataReader result = command.ExecuteReader())
                    {
                        while (result.Read())
                        {

                            phieuxuat.MA_PHIEU_XUAT = result["MA_PHIEU_XUAT"].ToString();
                            phieuxuat.NGAY_XUAT = result["NGAY_XUAT"].ToString();
                            phieuxuat.MA_NHAN_VIEN_KHO = result["MA_NHAN_VIEN_KHO"].ToString();
                            phieuxuat.MA_NHAN_VIEN_KINH_DOANH = result["MA_NHAN_VIEN_KINH_DOANH"].ToString();
                        }
                        using (chi_tiet_phieu_xuat ctpx = new chi_tiet_phieu_xuat(User, phieuxuat))
                        {
                            ctpx.ShowDialog();
                        }
                    }
                }
            }
        }
    
    }
}
