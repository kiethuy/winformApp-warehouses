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
using Microsoft.Reporting.WinForms;
namespace WindowsFormsApp1
{
    public partial class chi_tiet_hoa_don : Form
    {
        hoadon hoadon = new hoadon();
        user User = new user();
        SqlConnection connection = connect.connect_db();
        DataTable table = new DataTable();
        List<TextBox> groupTextBox = new List<TextBox> { };
        string MASPC = "";
        public chi_tiet_hoa_don( hoadon hoadon, user user)
        {
            this.User = user;
            this.hoadon = hoadon;
            InitializeComponent();
        }

        private void chi_tiet_hoa_don_Load(object sender, EventArgs e)
        {
            function.mapValueTextbox(groupBoxHD, hoadon);
            function.SelectGroupBox(this.groupBoxMenu, User);
            connection.Open();
            string query = $"select MA_SAN_PHAM,SO_LUONG,GIA_BAN,SO_LUONG*GIA_BAN as N'TONG' from CHI_TIET_HOA_DON where MA_HOA_DON='{hoadon.MA_HOA_DON}'";
            table=handleDatagridview.DataSetDatabase(query, connection);           
            dataGridViewchitietHD.DataSource = table;
            TONGTIEN.Text = handleDatagridview.TongTien(table, "TONG");
            var gr = groupBoxCTHD.Controls.OfType<TextBox>().OrderBy(t => t.TabIndex);
            gr.ToList().ForEach(grtextb => groupTextBox.Add(grtextb));

            connection.Close();
            this.reportViewer.RefreshReport();
        }
        private void dataGridViewchitietHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
               int rowIdex = e.RowIndex;
                MASPC = dataGridViewchitietHD.Rows[rowIdex].Cells[0].Value.ToString();

                for (int i = 0; i < dataGridViewchitietHD.Rows[rowIdex].Cells.Count; i++)
                {
                    groupTextBox.ToList()[i].Text = dataGridViewchitietHD.Rows[rowIdex].Cells[i].Value.ToString();
                }
                btnsua.Enabled = true;
                btninHD.Enabled = true;
                btnxoa.Enabled = true;
                btnthem.Enabled = false;
            }
        }
        private void IDU(string action)
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "IDU_CHI_TIET_HOA_DON";
                command.Parameters.AddWithValue("@action", action);
                command.Parameters.AddWithValue("@MAHD", hoadon.MA_HOA_DON);
                command.Parameters.AddWithValue("@MASPC", MASPC);
                command.Parameters.AddWithValue("@MASPM", MASPM.Text);
                command.Parameters.AddWithValue("@SL", SL.Text.Trim());
                command.Parameters.AddWithValue("@GIABAN", DONGIA.Text.Trim());
                command.Parameters.AddWithValue("@MANV", User.UserName);

                try
                {
                    if (command.ExecuteNonQuery() > 1)
                    {
                        if (action == "INSERT")
                        {
                            DataRow row = table.Rows.Add();
                            row["MA_SAN_PHAM"] = MASPM.Text;
                            row["SO_LUONG"] = SL.Text.Trim();
                            row["GIA_BAN"] = DONGIA.Text.Trim();
                            row["TONG"] = TONG.Text;
                            TONGTIEN.Text = handleDatagridview.TongTien(table, "TONG");
                        }

                        else if (action == "UPDATE")
                        {
                            dataGridViewchitietHD.CurrentRow.Cells[0].Value = MASPM.Text;
                            dataGridViewchitietHD.CurrentRow.Cells[1].Value = SL.Text.Trim();
                            dataGridViewchitietHD.CurrentRow.Cells[2].Value = DONGIA.Text.Trim();
                            dataGridViewchitietHD.CurrentRow.Cells[3].Value = TONG.Text;
                            TONGTIEN.Text = handleDatagridview.TongTien(table, "TONG");
                        }
                        else
                        {

                            dataGridViewchitietHD.Rows.Remove(dataGridViewchitietHD.CurrentRow);
                            TONGTIEN.Text = (Convert.ToInt32(TONGTIEN.Text) - Convert.ToInt32(TONG.Text)).ToString();
                        }

                        btnthem.Enabled = true;
                        btnsua.Enabled = false;
                        btnxoa.Enabled = false;


                        function.clearText(groupTextBox);
                        using (SqlCommand command1 = new SqlCommand())
                        {
                            command1.Connection = connection;
                            command1.CommandText = $"update HOA_DON set TONG_TIEN={TONGTIEN.Text} where MA_HOA_DON='{hoadon.MA_HOA_DON}' ";
                            if (command1.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("cập nhập thành công");
                            }
                        }
                    }
                
            }
                catch
            {
                MessageBox.Show("lỗi trùng mã sản phẩm hoặc mã khách hàng, mã nhân viên không hợp lệ");
                btnsua.Enabled = true;
                btnxoa.Enabled = true;
            }
        }
            
            connection.Close();
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            IDU("INSERT");
            
            
        }


        private void DONGIA_TextChanged(object sender, EventArgs e)
        {
            if(function.TextNumber(SL) && function.TextNumber(DONGIA))
            {
                TONG.Text = (Convert.ToInt32(SL.Text.Trim()) * Convert.ToInt32(DONGIA.Text.Trim())).ToString();
            }         
        }
        private void btnCloseAction_Click(object sender, EventArgs e)
        {
            function.clearText(groupTextBox);
            btnthem.Enabled = true;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            
            IDU("DELETE");          
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            IDU("UPDATE");
        }

        private void SL_TextChanged(object sender, EventArgs e)
        {
            if (function.TextNumber(SL) && function.TextNumber(DONGIA))
            {
                TONG.Text = (Convert.ToInt32(SL.Text.Trim()) * Convert.ToInt32(DONGIA.Text.Trim())).ToString();
            }
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            reportViewer.Visible = true;
            button2.Visible = true;
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "select_HD";
                command.Parameters.AddWithValue("@mahd", hoadon.MA_HOA_DON);
                command.Parameters.AddWithValue("@manv", hoadon.MA_NHAN_VIEN_KINH_DOANH);
                using (DataSet dataSet= new DataSet())
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataSet);
                        reportViewer.ProcessingMode = ProcessingMode.Local;
                        reportViewer.LocalReport.ReportPath = "ReportHD.rdlc";
                        ReportDataSource source = new ReportDataSource("DataSet1", dataSet.Tables[0]);
                        reportViewer.LocalReport.DataSources.Clear();
                        reportViewer.LocalReport.DataSources.Add(source);
                        reportViewer.RefreshReport();

                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reportViewer.Visible = false;
            reportViewer.LocalReport.DataSources.Clear();
            button2.Visible = false;
        }

    }
}
