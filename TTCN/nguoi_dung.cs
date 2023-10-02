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
    public partial class nguoi_dung : Form
    {
        user User = new user();
        string MANDC = "";
        SqlConnection Conn = connect.connect_db();
        DataTable table = new DataTable();
        List<TextBox> groupTextBox = new List<TextBox> { };
        public nguoi_dung(user user)
        {
            this.User = user;
            InitializeComponent();
        }

        private void nguoi_dung_Load(object sender, EventArgs e)
        {
            Conn.Open();
            string query_full = $" exec SELECT_NGUOI_DUNG'{User.UserName}'";
            table = handleDatagridview.DataSetDatabase(query_full, Conn);
            dataGridViewNGUOIDUNG.DataSource = table;
            dataGridViewNGUOIDUNG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            var gr = groupBoxND.Controls.OfType<TextBox>().OrderBy(t => t.TabIndex);
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
                command.CommandText = "IUD_NGUOI_DUNG";
                command.Parameters.AddWithValue("@action", action);
                command.Parameters.AddWithValue("@MANDC", MANDC);
                command.Parameters.AddWithValue("@MANDM", MANDM.Text.Trim());
                command.Parameters.AddWithValue("@HOTEN", HOTEN.Text.Trim());
                command.Parameters.AddWithValue("@MK", MK.Text.Trim());
                command.Parameters.AddWithValue("@MANV", User.UserName);

                try
                {
                    if (command.ExecuteNonQuery() > 1)
                {
                    MessageBox.Show("cập nhập thành công");
                    if (action == "INSERT")
                    {
                        DataRow row = table.Rows.Add();
                        row["MA_NGUOI_DUNG"] = MANDM.Text.Trim();
                        row["TEN_NGUOI_DUNG"] = HOTEN.Text.Trim();
                        row["MAT_KHAU"] = MK.Text.Trim();
                    }
                    else if (action == "DELETE")
                    {
                        dataGridViewNGUOIDUNG.Rows.Remove(dataGridViewNGUOIDUNG.CurrentRow);
                    }
                    else if (action == "UPDATE")
                    {
                        dataGridViewNGUOIDUNG.CurrentRow.Cells[0].Value = MANDM.Text.Trim();
                        dataGridViewNGUOIDUNG.CurrentRow.Cells[1].Value = HOTEN.Text.Trim();
                        dataGridViewNGUOIDUNG.CurrentRow.Cells[2].Value = MK.Text.Trim();
                    }
                    function.clearText(groupTextBox);
                    btnthem.Enabled = true;
                    btnsua.Enabled = false;
                    btnxoa.Enabled = false;
                        btnvaitro.Enabled = false;
                    }
                }
                catch( Exception e)
                {
                    MessageBox.Show(e.ToString());
                    btnsua.Enabled = true;
                    btnxoa.Enabled = true;
                }
            }



            Conn.Close();
        }

        private void btnthem_Click_1(object sender, EventArgs e)
        {
            IDU("INSERT");
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            IDU("DELETE");
        }

        private void dataGridViewNGUOIDUNG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int rowIdex = e.RowIndex;
                MANDC = dataGridViewNGUOIDUNG.Rows[rowIdex].Cells[0].Value.ToString();
                MANDM.Text = dataGridViewNGUOIDUNG.Rows[rowIdex].Cells[0].Value.ToString();
                HOTEN.Text= dataGridViewNGUOIDUNG.Rows[rowIdex].Cells[1].Value.ToString();
                MK.Text = dataGridViewNGUOIDUNG.Rows[rowIdex].Cells[2].Value.ToString();
            }
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnthem.Enabled = false;
            btnvaitro.Enabled = true;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            IDU("UPDATE");
        }

        private void btnCloseAction_Click(object sender, EventArgs e)
        {
            function.clearText(groupTextBox);
            btnthem.Enabled = true;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnvaitro.Enabled = false;
        }

        private void btnvaitro_Click(object sender, EventArgs e)
        {
            using(user user1= new user())
            {
                user1.UserName = MANDM.Text.Trim();
                user1.HO_TEN = HOTEN.Text.Trim();
                cap_quyen cap_Quyen = new cap_quyen(User, user1);
                cap_Quyen.ShowDialog();
            }
        }

    }
}
