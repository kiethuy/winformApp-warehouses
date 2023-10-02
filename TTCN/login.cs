using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class login : Form
    {
        static user User = new user();
        public login()
        {
            InitializeComponent();
        }
        private bool Login(user user)
        {
            string check_user = $"select * from NGUOI_DUNG where MA_NGUOI_DUNG='{user_name.Text.Trim()}' and MAT_KHAU='{password.Text.Trim()}'";
            DataTable result = connect.query(check_user);

            if (result.Rows.Count > 0)
            {
                User.UserName = user_name.Text.Trim();
                User.Password = this.password.Text.Trim();
                string check_func = $"select MA_NHOM_QUYEN, MA_CHUC_NANG from CHUC_NANG where MA_CHUC_NANG in(select b.MA_CHUC_NANG from VAI_TRO_NGUOI_DUNG a join CHUC_NANG_VAI_TRO b on a.MA_VAI_TRO = b.MA_VAI_TRO where a.MA_NGUOI_DUNG = '{User.UserName}') group by MA_NHOM_QUYEN,MA_CHUC_NANG";
                DataTable table = connect.query(check_func);
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        foreach (DataColumn column in table.Columns)
                        {
                            if (column.ColumnName == "MA_NHOM_QUYEN")
                            {
                                User.nhom_quyen.Add(row[column].ToString());
                            }
                            else
                            {
                                User.chuc_nang.Add(row[column].ToString());
                            }
                        }
                    }
                    User.nhom_quyen.Distinct();

                    return true;
                }
                return false;
            }
            return false;
        }
        private void login_Load(object sender, EventArgs e)
        {
            user_name.Text = "user_DIR_001";
            password.Text = "a";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Login(User) == true)
            {
                this.Hide();
                menu menu = new menu(User);
                menu.ShowDialog();
                User.Dispose();
                this.Show();
            }
        }
    }
}
