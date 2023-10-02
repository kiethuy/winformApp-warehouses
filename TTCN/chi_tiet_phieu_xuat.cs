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
using Microsoft.Reporting.WinForms;
namespace WindowsFormsApp1
{
    public partial class chi_tiet_phieu_xuat : Form
    {
        user User = new user();
        phieuxuat phieuxuat = new phieuxuat();
        SqlConnection connection = connect.connect_db();
        DataTable table = new DataTable();
        List<TextBox> groupTextBox = new List<TextBox> { };
        string MASPC = "";
        public chi_tiet_phieu_xuat(user user, phieuxuat phieuxuat)
        {
            this.phieuxuat = phieuxuat;
            this.User = user;
            InitializeComponent();
            
        }
        

        private void chi_tiet_phieu_xuat_Load(object sender, EventArgs e)
        {
            connection.Open();
            function.mapValueTextbox(groupBoxPX, phieuxuat);
            string query_full =$" SELECT MA_SAN_PHAM,SO_LUONG FROM CHI_TIET_PHIEU_XUAT where MA_PHIEU_XUAT='{phieuxuat.MA_PHIEU_XUAT}'";
            table = handleDatagridview.DataSetDatabase(query_full, connection);
            dataGridViewCTPHIEUXUAT.DataSource = table;
            function.SelectGroupBox(this.groupBoxMenu, User);        
            dataGridViewCTPHIEUXUAT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            
            var gr = groupBoxchitietPN.Controls.OfType<TextBox>().OrderBy(t => t.TabIndex);
            gr.ToList().ForEach(grtextb => groupTextBox.Add(grtextb));
            connection.Close();
            this.reportViewer.RefreshReport();
            this.reportViewer.RefreshReport();
            this.reportViewer.RefreshReport();
        }
        private void IDU(string action)
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "IDU_CHI_TIET_PHIEU_XUAT";
                command.Parameters.AddWithValue("@action", action);
                command.Parameters.AddWithValue("@MAPX", phieuxuat.MA_PHIEU_XUAT);
                command.Parameters.AddWithValue("@MASPC", MASPC);
                command.Parameters.AddWithValue("@MASPM", MASPM.Text);
                command.Parameters.AddWithValue("@SL", SL.Text.Trim());
                command.Parameters.AddWithValue("@MANV", User.UserName);

                //try
                //{
                    if (command.ExecuteNonQuery() > 1)
                    {
                        if (action == "INSERT")
                        {
                            DataRow row = table.Rows.Add();
                            row["MA_SAN_PHAM"] = MASPM.Text.Trim();
                            row["SO_LUONG"] = SL.Text.Trim();
                        }

                        else if (action == "UPDATE")
                        {
                            dataGridViewCTPHIEUXUAT.CurrentRow.Cells[0].Value = MASPM.Text;
                            dataGridViewCTPHIEUXUAT.CurrentRow.Cells[1].Value = SL.Text.Trim();
                        }
                        else
                        {

                            dataGridViewCTPHIEUXUAT.Rows.Remove(dataGridViewCTPHIEUXUAT.CurrentRow);
                        }
                    MessageBox.Show("cập nhập thành công");
                        function.clearText(groupTextBox);
                        them.Enabled = true;
                        btnSua.Enabled = false;
                        btnxoa.Enabled = false;

                    }


                //}
                }
            connection.Close();
        }

         private void them_Click(object sender, EventArgs e)
        {
            connection.Open();
           
            if (function.CheckText(groupTextBox))
            {
                if (function.TextNumber(SL))
                {
                    using (SqlCommand command = new SqlCommand($"select MA_SAN_PHAM,SO_LUONG FROM SAN_PHAM where MA_SAN_PHAM='{MASPM.Text}'AND SO_LUONG >='{SL.Text}'", connection))
                    {
                        if (command.ExecuteReader().HasRows)
                        {
                            connection.Close();
                            IDU("INSERT");
                        }
                        else
                        {
                            MessageBox.Show("số lượng đã lớn hơn số sản phẩm hiện có");
                            connection.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("nhập lại số lượng");
                }
            }
            else
            {
                MessageBox.Show("còn dữ liệu chưa được nhập");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            IDU("DELETE");
        }

        private void dataGridViewCTPHIEUXUAT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int rowIdex = e.RowIndex;
                MASPC = dataGridViewCTPHIEUXUAT.Rows[rowIdex].Cells[0].Value.ToString();


                for (int i = 0; i < dataGridViewCTPHIEUXUAT.Rows[rowIdex].Cells.Count; i++)
                {
                    groupTextBox.ToList()[i].Text = dataGridViewCTPHIEUXUAT.Rows[rowIdex].Cells[i].Value.ToString();
                }
                btnSua.Enabled = true;
                btnxoa.Enabled = true;
                them.Enabled = false;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            IDU("UPDATE");
        }

        private void btnCloseAction_Click(object sender, EventArgs e)
        {
            function.clearText(groupTextBox);
            them.Enabled = true;
            btnSua.Enabled = false;
            btnxoa.Enabled = false;
        }


        private void timkiem_Click(object sender, EventArgs e)
        {

        }

        private void btnInPhieu_Click(object sender, EventArgs e)
        {
            reportViewer.Visible = true;
            btnclose.Visible = true;
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "PRINT_PHIEU_XUAT";
                command.Parameters.AddWithValue("@MAPX", phieuxuat.MA_PHIEU_XUAT);
                command.Parameters.AddWithValue("@MANVK",phieuxuat.MA_NHAN_VIEN_KHO );
                command.Parameters.AddWithValue("@MANVKD",phieuxuat.MA_NHAN_VIEN_KINH_DOANH );
                using (DataSet dataSet = new DataSet())
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataSet);
                        reportViewer.ProcessingMode = ProcessingMode.Local;
                        reportViewer.LocalReport.ReportPath = "ReportPX.rdlc";
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
            btnclose.Visible = false;
        }
    }
}
