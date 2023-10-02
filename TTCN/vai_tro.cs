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
    public partial class vai_tro : Form
    {
        user User = new user();
        string MAVTC = "";
        SqlConnection Conn = connect.connect_db();
        DataTable table = new DataTable();
        List<TextBox> groupTextBox = new List<TextBox> { };
        public vai_tro(user user)
        {
            this.User = user;
            InitializeComponent();
        }

        private void vai_tro_Load(object sender, EventArgs e)
        {
            Conn.Open();
            string query_full = $" select * from VAI_TRO";
            table = handleDatagridview.DataSetDatabase(query_full, Conn);
            dataGridViewvaitro.DataSource = table;
            dataGridViewvaitro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            var gr = groupBoxVT.Controls.OfType<TextBox>().OrderBy(t => t.TabIndex);
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
                command.CommandText = "IDU_VAI_TRO";
                command.Parameters.AddWithValue("@action", action);
                command.Parameters.AddWithValue("@MAVTC", MAVTC);
                command.Parameters.AddWithValue("@MAVTM", MAVTM.Text.Trim());
                command.Parameters.AddWithValue("@TENVT", TENVT.Text.Trim());
                command.Parameters.AddWithValue("@MANV", User.UserName);

                try
                {
                    if (command.ExecuteNonQuery() > 1)
                    {
                        MessageBox.Show("cập nhập thành công");
                        if (action == "INSERT")
                        {
                            DataRow row = table.Rows.Add();
                            row["MA_VAI_TRO"] = MAVTM.Text.Trim();
                            row["TEN_VAI_TRO"] = TENVT.Text.Trim();
                        }
                        else if (action == "DELETE")
                        {
                            dataGridViewvaitro.Rows.Remove(dataGridViewvaitro.CurrentRow);
                        }
                        else if (action == "UPDATE")
                        {
                            dataGridViewvaitro.CurrentRow.Cells[0].Value = MAVTM.Text.Trim();
                            dataGridViewvaitro.CurrentRow.Cells[1].Value = TENVT.Text.Trim();
                        }
                        function.clearText(groupTextBox);
                        btnthem.Enabled = true;
                        btnsua.Enabled = false;
                        btnxoa.Enabled = false;
                        chucnang.Enabled = false;
                        MAVTC = "";
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

        private void btnthem_Click(object sender, EventArgs e)
        {
            IDU("INSERT");
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            IDU("DELETE");
        }

        private void dataGridViewvaitro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int rowIdex = e.RowIndex;
                MAVTC = dataGridViewvaitro.Rows[rowIdex].Cells[0].Value.ToString();
                MAVTM.Text = dataGridViewvaitro.Rows[rowIdex].Cells[0].Value.ToString();
                TENVT.Text = dataGridViewvaitro.Rows[rowIdex].Cells[1].Value.ToString();
            }
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnthem.Enabled = false;
            chucnang.Enabled = true;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            IDU("UPDATE");
        }

        private void chucnang_Click(object sender, EventArgs e)
        {
            using (vaitro vaitro = new vaitro())
            {
                vaitro.MA_VAI_TRO = MAVTM.Text.Trim();
                vaitro.TEN_VAI_TRO= TENVT.Text.Trim();
                vai_tro_chuc_nang VTCN = new vai_tro_chuc_nang(vaitro,User);
                VTCN.ShowDialog();
            }
        }

        private void btnCloseAction_Click(object sender, EventArgs e)
        {
            function.clearText(groupTextBox);
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnthem.Enabled = true;
            chucnang.Enabled = false;
        }
    }
}
