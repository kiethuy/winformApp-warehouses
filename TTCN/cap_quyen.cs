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
    public partial class cap_quyen : Form
    {
        user User = new user();
        user User1 = new user();
        SqlConnection Conn = connect.connect_db();
        DataTable table = new DataTable();
        List<TextBox> groupTextBox = new List<TextBox> { };
        string MAVTC = "";
        public cap_quyen(user user, user user1)
        {
            this.User1 = user1;
            this.User = user;
            InitializeComponent();
        }

        private void cap_quyen_Load(object sender, EventArgs e)
        {
            Conn.Open();
            MANDM.Text = User1.UserName;
            HOTEN.Text = User1.HO_TEN;
            string query_full = $"select vt.MA_VAI_TRO,vt.TEN_VAI_TRO from VAI_TRO_NGUOI_DUNG as vtnd join VAI_TRO as vt on vtnd.MA_VAI_TRO= vt.MA_VAI_TRO where MA_NGUOI_DUNG='{User1.UserName}'";
            table = handleDatagridview.DataSetDatabase(query_full, Conn);
            dataGridViewCapquyen.DataSource = table;
            using (SqlCommand command = new SqlCommand($"exec SELEC_VAI_TRO '{User.UserName}'", Conn))
            {
                SqlDataReader result = command.ExecuteReader();
                DataTable table1 = new DataTable();
                table1.Load(result);
                VAITRO.DataSource = table1;
                VAITRO.DisplayMember = "TEN_VAI_TRO";
                VAITRO.ValueMember = "MA_VAI_TRO";
            }
            dataGridViewCapquyen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
                command.CommandText = "IDU_VAI_TRO_NGUOI_DUNG";
                command.Parameters.AddWithValue("@action", action);
                command.Parameters.AddWithValue("@MAND", User1.UserName);
                command.Parameters.AddWithValue("@MAVTC", MAVTC);
                command.Parameters.AddWithValue("@MAVTM", VAITRO.SelectedValue.ToString());
                command.Parameters.AddWithValue("@MANV", User.UserName);

                try
                {
                    if (command.ExecuteNonQuery() > 1)
                    {
                        MessageBox.Show("cập nhập thành công");
                        if (action == "INSERT")
                        {
                            DataRow row = table.Rows.Add();
                            row["MA_VAI_TRO"] = VAITRO.SelectedValue;
                            row["TEN_VAI_TRO"] = VAITRO.Text;
                        }
                        else if (action == "DELETE")
                        {
                            dataGridViewCapquyen.Rows.Remove(dataGridViewCapquyen.CurrentRow);
                        }
                        else if (action == "UPDATE")
                        {
                            dataGridViewCapquyen.CurrentRow.Cells[0].Value = VAITRO.SelectedValue;
                            dataGridViewCapquyen.CurrentRow.Cells[1].Value = VAITRO.Text;
                        }
                        function.clearText(groupTextBox);
                        btnthem.Enabled = true;
                        btnsua.Enabled = false;
                        btnxoa.Enabled = false;
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

        private void dataGridViewCapquyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                int rowIdex = e.RowIndex;
                MAVTC = dataGridViewCapquyen.Rows[rowIdex].Cells[0].Value.ToString();
                VAITRO.SelectedValue = dataGridViewCapquyen.Rows[rowIdex].Cells[0].Value.ToString();
                VAITRO.Text = dataGridViewCapquyen.Rows[rowIdex].Cells[1].Value.ToString();
            }
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnthem.Enabled = false;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            IDU("UPDATE");
        }
    }
}
