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
    public partial class vai_tro_chuc_nang : Form
    {
        vaitro vaitro = new vaitro();
        user User = new user();
        string MACNC = "";
        SqlConnection Conn = connect.connect_db();
        DataTable table = new DataTable();
        List<TextBox> groupTextBox = new List<TextBox> { };
        public vai_tro_chuc_nang( vaitro vaitro , user user)
        {
            this.vaitro = vaitro;
            this.User = user;
            InitializeComponent();
        }

        private void vai_tro_chuc_nang_Load(object sender, EventArgs e)
        {
            Conn.Open();
            string query_full = $"select cn.MA_CHUC_NANG,cn.TEN_CHUC_NANG from CHUC_NANG_VAI_TRO as cnvt join CHUC_NANG as cn on cnvt.MA_CHUC_NANG= cn.MA_CHUC_NANG where MA_VAI_TRO= '{vaitro.MA_VAI_TRO}'";
            this.MAVT.Text = vaitro.MA_VAI_TRO;
            this.TENVAITRO.Text = vaitro.TEN_VAI_TRO;
            table = handleDatagridview.DataSetDatabase(query_full, Conn);
            dataGridViewVTCN.DataSource = table;
            using (SqlCommand command = new SqlCommand($"select MA_CHUC_NANG,TEN_CHUC_NANG from CHUC_NANG", Conn))
            {
                SqlDataReader result = command.ExecuteReader();
                DataTable table1 = new DataTable();
                table1.Load(result);
                CHUCNANG.DataSource = table1;
                CHUCNANG.DisplayMember = "TEN_CHUC_NANG";
                CHUCNANG.ValueMember = "MA_CHUC_NANG";
            }
            dataGridViewVTCN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            var gr = groupBoxMenu.Controls.OfType<TextBox>().OrderBy(t => t.TabIndex);
            gr.ToList().ForEach(grtextb => groupTextBox.Add(grtextb));
            Conn.Close();
        }
        private void IDU(string action)
        {
            Conn.Open();
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = Conn;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "IDU_VAI_TRO_CHUC_NANG";
                command.Parameters.AddWithValue("@action", action);
                command.Parameters.AddWithValue("@MAVT", vaitro.MA_VAI_TRO);
                command.Parameters.AddWithValue("@MACNM", CHUCNANG.SelectedValue.ToString());
                command.Parameters.AddWithValue("@MACNC", MACNC);
                command.Parameters.AddWithValue("@MANV", User.UserName);

                try
                {
                    if (command.ExecuteNonQuery() > 1)
                    {
                        MessageBox.Show("cập nhập thành công");
                        if (action == "INSERT")
                        {
                            DataRow row = table.Rows.Add();
                            row["MA_CHUC_NANG"] = CHUCNANG.SelectedValue;
                            row["TEN_CHUC_NANG"] = CHUCNANG.Text;
                        }
                        else if (action == "DELETE")
                        {
                            dataGridViewVTCN.Rows.Remove(dataGridViewVTCN.CurrentRow);
                        }
                        else if (action == "UPDATE")
                        {
                            dataGridViewVTCN.CurrentRow.Cells[0].Value = CHUCNANG.SelectedValue;
                            dataGridViewVTCN.CurrentRow.Cells[1].Value = CHUCNANG.Text;
                        }
                        function.clearText(groupTextBox);
                        btnthem.Enabled = true;
                        btnsua.Enabled = false;
                        btnxoa.Enabled = false;
                        MACNC = "";
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                    btnsua.Enabled = true;
                    btnxoa.Enabled = true;
                }
                Conn.Close();
            }

        }

        private void dataGridViewVTCN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int rowIdex = e.RowIndex;
                MACNC = dataGridViewVTCN.Rows[rowIdex].Cells[0].Value.ToString();
                CHUCNANG.SelectedValue = dataGridViewVTCN.Rows[rowIdex].Cells[0].Value.ToString();
                CHUCNANG.Text = dataGridViewVTCN.Rows[rowIdex].Cells[1].Value.ToString();
            }
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnthem.Enabled = false;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            IDU("INSERT");
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            IDU("DELETE");
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            IDU("UPDATE");
        }

        private void btnCloseAction_Click(object sender, EventArgs e)
        {
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnthem.Enabled = true;
        }

    }
}
