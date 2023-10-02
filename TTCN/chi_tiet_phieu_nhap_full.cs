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
    public partial class chi_tiet_phieu_nhap_full : Form
    {
        user User = new user();
        DataTable table = new DataTable();
        SqlConnection Connection = connect.connect_db();
        string mapn = "";
        public chi_tiet_phieu_nhap_full(user user)
        {
            this.User = user;
            InitializeComponent();
        }

        private void chi_tiet_phieu_nhap_full_Load(object sender, EventArgs e)
        {
            Connection.Open();
            string query = "select * from CHI_TIET_PHIEU_NHAP";
            table = handleDatagridview.DataSetDatabase(query, Connection);
            dataGridViewCHITIETPNfull.DataSource = table;
        }

        private void textTimkiem_TextChanged(object sender, EventArgs e)
        {
            string search = $"select* from Func_SearchCTPhieunhap('{textTimkiem.Text.Trim()}')";
            dataGridViewCHITIETPNfull.DataSource = handleDatagridview.DataSetDatabase(search, Connection);
        }

        private void btnCloseGrtimkiem_Click(object sender, EventArgs e)
        {
            dataGridViewCHITIETPNfull.DataSource = table;
        }

        private void dataGridViewCHITIETPNfull_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnXemPN.Visible = true;
            if (e.RowIndex >= 0)
            {
                int rowIdex = e.RowIndex;
                mapn = dataGridViewCHITIETPNfull.Rows[rowIdex].Cells[1].Value.ToString();
                
            }
        }

        private void btnXemPN_Click(object sender, EventArgs e)
        {
            string query_HD = $"select * from PHIEU_NHAP where MA_PHIEU_NHAP='{mapn}'";
            using (SqlCommand command = new SqlCommand(query_HD, Connection))
            {
                using (phieunhap phieunhap = new phieunhap())
                {
                    using (SqlDataReader result = command.ExecuteReader())
                    {
                        while (result.Read())
                        {
                            
                            phieunhap.MA_PHIEU_NHAP = result["MA_PHIEU_NHAP"].ToString();
                            phieunhap.NGAY_NHAP = result["NGAY_NHAP"].ToString();
                            phieunhap.MA_NHA_CUNG_CAP = result["MA_NHA_CUNG_CAP"].ToString();
                            phieunhap.MA_NHAN_VIEN_KHO = result["MA_NHAN_VIEN_KHO"].ToString();
                        }
                        using (chi_tiet_phieu_nhap ctpn = new chi_tiet_phieu_nhap(User,phieunhap))
                        {
                            ctpn.ShowDialog();
                        }
                    }
                }
            }
        }
    }
}
