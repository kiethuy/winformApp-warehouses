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
    public partial class thong_ke : Form
    {
        SqlConnection Conn = connect.connect_db();
        List<string> MASP = new List<string>() { };
        List<int> SPN = new List<int>() { };
        List<int> SPT = new List<int>() { };
        List<int> SPX = new List<int>() { };
        List<int> SPB = new List<int>() { };
        public thong_ke()
        {
            InitializeComponent();
        }

        private void thong_ke_Load(object sender, EventArgs e)
        {
            Conn.Open();
            DataTable table = new DataTable();
            table.Columns.Add("MÃ SẢN PHẨM", typeof(string));
            table.Columns.Add("SỐ LƯỢNG NHẬP", typeof(int));
            table.Columns.Add("SỐ LƯỢNG TỒN", typeof(int));
            table.Columns.Add("SỐ LƯỢNG XUẤT", typeof(int));
            table.Columns.Add("SO SÁNH", typeof(string));
            using (SqlCommand command = new SqlCommand("select MA_SAN_PHAM FROM CHI_TIET_PHIEU_NHAP group by MA_SAN_PHAM order by MA_SAN_PHAM asc", Conn))
            {
                using (SqlDataReader result = command.ExecuteReader())
                {
                    while (result.Read())
                    {
                        var msp = (string)result["MA_SAN_PHAM"];
                        MASP.Add(msp);
                    }
                }
            }
            using (SqlCommand command = new SqlCommand("select sum(SO_LUONG) as 'SLN' from  CHI_TIET_PHIEU_NHAP  group by MA_SAN_PHAM order by MA_SAN_PHAM asc", Conn))
            {
                using (SqlDataReader result = command.ExecuteReader())
                {
                    while (result.Read())
                    {
                        SPN.Add(Convert.ToInt32(result["SLN"]));
                    }
                }
            }
            using (SqlCommand command = new SqlCommand("SELECT SO_LUONG as 'SLT' FROM SAN_PHAM order by MA_SAN_PHAM asc", Conn))
            {
                using (SqlDataReader result = command.ExecuteReader())
                {
                    while (result.Read())
                    {
                        SPT.Add(Convert.ToInt32(result["SLT"]));
                    }
                }
            }
            using (SqlCommand command = new SqlCommand("select sp.MA_SAN_PHAM,sum(ctpx.SO_LUONG)  AS 'SLX' from  SAN_PHAM as sp  join CHI_TIET_PHIEU_XUAT ctpx on ctpx.MA_SAN_PHAM=sp.MA_SAN_PHAM group by ctpx.MA_SAN_PHAM, sp.MA_SAN_PHAM order by sp.MA_SAN_PHAM asc", Conn))
            {
                using (SqlDataReader result = command.ExecuteReader())
                {
                    while (result.Read())
                    {
                        SPX.Add(Convert.ToInt32(result["SLX"]));
                    }
                   
                }
            }
            for (int i = 0; i < SPX.Count; i++)
            {
                DataRow row = table.NewRow();
                row["MÃ SẢN PHẨM"] = MASP[i];
                row["SỐ LƯỢNG NHẬP"] = SPN[i];
                row["SỐ LƯỢNG TỒN"] = SPT[i];
                row["SỐ LƯỢNG XUẤT"] = SPX[i];
                if (SPN[i]== SPT[i]+ SPX[i])
                {
                    row["SO SÁNH"] = "khớp";
                }
                else
                {                                  
                    
                    row["SO SÁNH"] = "không khớp";
                    
                }
                table.Rows.Add(row);

            }
            dataGridViewTK.DataSource = table;

            DataTable table1 = new DataTable();
            table1.Columns.Add("MÃ SẢN PHẨM", typeof(string));
            table1.Columns.Add("SỐ LƯỢNG xuất", typeof(int));
            table1.Columns.Add("SỐ LƯỢNG BÁN", typeof(int));
            table1.Columns.Add("SO SÁNH", typeof(string));

            using (SqlCommand command = new SqlCommand("select sp.MA_SAN_PHAM,sum(cthd.SO_LUONG)  AS 'SLB' from   SAN_PHAM as sp  join CHI_TIET_HOA_DON cthd on cthd.MA_SAN_PHAM=sp.MA_SAN_PHAM group by cthd.MA_SAN_PHAM, sp.MA_SAN_PHAM order by sp.MA_SAN_PHAM asc", Conn))
            {
                using (SqlDataReader result = command.ExecuteReader())
                {
                    while (result.Read())
                    {
                        SPB.Add(Convert.ToInt32(result["SLB"]));
                    }

                }
            }
            for (int i = 0; i < SPB.Count; i++)
            {
                DataRow row = table1.NewRow();
                row["MÃ SẢN PHẨM"] = MASP[i];
                row["SỐ LƯỢNG XUẤT"] = SPX[i];
                row["SỐ LƯỢNG BÁN"] = SPB[i];
                if (SPX[i]==SPB[i])
                {
                    row["SO SÁNH"] = "khớp";
                }
                else
                {    
                    row["SO SÁNH"] = "không khớp";
                }
                table1.Rows.Add(row);
            }
            dataGridView1.DataSource = table1;
            Conn.Close();
        }
        
    }
}
