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
using System.Text.RegularExpressions;
namespace WindowsFormsApp1
{
    public partial class chi_tiet_phieu_nhap : Form
    {
        user User = new user();
        phieunhap phieunhap = new phieunhap();
        SqlConnection connection = connect.connect_db();
        DataTable table = new DataTable();
        List<TextBox> groupTextBox = new List<TextBox> { };
        string MACTPNC = "";
        public chi_tiet_phieu_nhap(user user, phieunhap phieunhap)
        {
            this.phieunhap = phieunhap;
            InitializeComponent();
            this.User = user;
        }

        private void chi_tiet_phieu_nhap_Load(object sender, EventArgs e)
        {
            connection.Open();
            string query_full = $"select MA_CHI_TIET_PHIEU_NHAP, MA_SAN_PHAM, SO_LUONG, DON_GIA_NHAP  from CHI_TIET_PHIEU_NHAP where MA_PHIEU_NHAP='{phieunhap.MA_PHIEU_NHAP}'";
            table = handleDatagridview.DataSetDatabase(query_full, connection);
            dataGridViewchitietPN.DataSource = table;
            dataGridViewchitietPN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            function.SelectGroupBox(this.groupBoxMenu, User);
            function.mapValueTextbox(groupBoxPN, phieunhap);
            var gr = groupBoxchitietPN.Controls.OfType<TextBox>().OrderBy(t => t.TabIndex);
            gr.ToList().ForEach(grtextb => groupTextBox.Add(grtextb));
            connection.Close();
            this.reportViewer.RefreshReport();
        }
        private void URI(string action)
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand())
            {
                string MACTPN = "CT" + phieunhap.MA_PHIEU_NHAP + "_" + MCTPNM.Text.Trim();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "IUD_CTPN";
                command.Parameters.AddWithValue("@action", action);
                command.Parameters.AddWithValue("@MACTPNC", MACTPNC);
                if(action == "INSERT") { command.Parameters.AddWithValue("@MACTPNM", MACTPN); }
                else { command.Parameters.AddWithValue("@MACTPNM", MCTPNM.Text.Trim()); }
                command.Parameters.AddWithValue("@MAPN", phieunhap.MA_PHIEU_NHAP);
                command.Parameters.AddWithValue("@MASP", MASP.Text.Trim());
                command.Parameters.AddWithValue("@SL", SL.Text.Trim());
                command.Parameters.AddWithValue("@DONGIA", DONGIA.Text.Trim());
                command.Parameters.AddWithValue("@MANV", User.UserName);
                
                if (command.ExecuteNonQuery() > 1)
                {
                    MessageBox.Show("cập nhập thành công");
                    if (action == "INSERT")
                    {
                        DataRow row = table.Rows.Add();
                        row["MA_CHI_TIET_PHIEU_NHAP"] = MACTPN;
                        row["MA_SAN_PHAM"] = MASP.Text.Trim();
                        row["SO_LUONG"] = SL.Text.Trim();
                        row["DON_GIA_NHAP"] = DONGIA.Text.Trim();                       
                    }
                    else if (action == "DELETE")
                    {
                        dataGridViewchitietPN.Rows.Remove(dataGridViewchitietPN.CurrentRow);
                    }
                    else if(action == "UPDATE")
                    {
                        dataGridViewchitietPN.CurrentRow.Cells[0].Value = MCTPNM.Text.Trim();
                        dataGridViewchitietPN.CurrentRow.Cells[1].Value = MASP.Text.Trim();
                        dataGridViewchitietPN.CurrentRow.Cells[2].Value = SL.Text;
                        dataGridViewchitietPN.CurrentRow.Cells[3].Value = DONGIA.Text.Trim();
                    }
                    MACTPN = "";
                    function.clearText(groupTextBox);
                }
            }
            connection.Close();
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            if (function.CheckText(groupTextBox) == true)
            {
                if (function.TextNumber(MCTPNM) && function.TextNumber(SL) && function.TextNumber(DONGIA) == true)
                {
                    URI("INSERT");
                }
            }
            else
            {
                MessageBox.Show("Còn dữ liệu chưa được nhập");
            }
        }

        private void btnCloseAction_Click(object sender, EventArgs e)
        {
            function.clearText(groupTextBox);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex($@"^CT+{phieunhap.MA_PHIEU_NHAP}_[0-9]+$");
            if (!regex.IsMatch(MCTPNM.Text))
            {
                MessageBox.Show("vui lòng nhập đúng định dạng mã phiếu nhập");
            }
            else
            {
                URI("UPDATE");
                btnsua.Enabled = false;
                btnxoa.Enabled = false;
                btnthem.Enabled = true;

            }
        }

        private void dataGridViewchitietPN_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                int rowIdex = e.RowIndex;
                MACTPNC = dataGridViewchitietPN.Rows[rowIdex].Cells[0].Value.ToString();

                for (int i = 0; i < dataGridViewchitietPN.Rows[rowIdex].Cells.Count; i++)
                {
                    groupTextBox.ToList()[i].Text = dataGridViewchitietPN.Rows[rowIdex].Cells[i].Value.ToString();
                }
                btnsua.Enabled = true;
                btnxoa.Enabled = true;
                btnthem.Enabled = false;
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            URI("DELETE");
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnthem.Enabled = true;
        }

        private void timkiem_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> comboSource = new Dictionary<string, string>();
            foreach (DataGridViewColumn colum in dataGridViewchitietPN.Columns)
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
            connection.Open();
            string Seach = comboBoxSelectSeach.SelectedValue.ToString();
            string query = $"SELECT * FROM CHI_TIET_PHIEU_NHAP WHERE {Seach} like '%{textBoxSeach.Text.Trim()}%' ";
            dataGridViewchitietPN.DataSource = handleDatagridview.DataSetDatabase(query,connection);
            connection.Close();
        }

        private void btnCloseGrSeach_Click(object sender, EventArgs e)
        {
            groupBoxTimKiem.Visible = false;
            dataGridViewchitietPN.DataSource = table;
        }

        private void btnInPhieu_Click(object sender, EventArgs e)
        {
            reportViewer.Visible = true;
            button2.Visible = true;
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "PRIN_PHIEU_NHAP";
                command.Parameters.AddWithValue("@mapn", phieunhap.MA_PHIEU_NHAP);
                command.Parameters.AddWithValue("@manvk", phieunhap.MA_NHAN_VIEN_KHO);
                using (DataSet dataSet = new DataSet())
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataSet);
                        reportViewer.ProcessingMode = ProcessingMode.Local;
                        reportViewer.LocalReport.ReportPath = "ReportPN.rdlc";
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

