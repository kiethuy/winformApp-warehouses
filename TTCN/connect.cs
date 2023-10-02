using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace WindowsFormsApp1
{
    class connect
    {
        public static SqlConnection connect_db()
        {
            string Str_connect = "Data Source=LAPTOPK;Initial Catalog=TTCN;Integrated Security=True";
            SqlConnection connect = new SqlConnection(Str_connect);
            return connect;
        }
        public static DataTable query(string query)
        {
            SqlConnection conn = connect_db();
            Task openConnect = new Task
                (
                () => conn.Open()
                );
            openConnect.Start();
            openConnect.Wait();
                SqlCommand command = new SqlCommand(query, conn);
                DataTable table = new DataTable();
            SqlDataReader result;
            Task reader = new Task(
                () =>
                {
                    result = command.ExecuteReader();
                    table.Load(result);
                });
            reader.Start();
            reader.Wait();
                    
                return table;   
        }
    }
    class function
    {
        static public void SelectGroupBox(GroupBox groupBox, user User)
        {
            var groupBoxes = groupBox.Controls.OfType<GroupBox>();
            groupBoxes.ToList().ForEach
                (
                box =>
                {
                    box.Visible = false;
                }
                );
            groupBoxes.ToList().ForEach
            (
            box =>
            {
                User.chuc_nang.ForEach
                (
                    cn =>
                    {
                        if (cn == box.Name)
                        {
                            box.Visible = true;
                        }
                    }
                    );
            }
            );
        }

        static public bool CheckText(List<TextBox> grtextBox)
        {
            bool EmptyText = true;
            grtextBox.ForEach(
                textbox =>
                {
                    if (textbox.Text.Length == 0)
                    {
                        EmptyText = false;
                    }

                });
            return EmptyText;
        }
        static public bool TextNumber(TextBox textBox)
        {
            Regex regex = new Regex(@"^[0-9]+$");
            if (!regex.IsMatch(textBox.Text))
            {
                return false;
            }
            return true;
        }
        static public void load_gridview(ref DataGridView dataGridView, string query, SqlDataAdapter adapter, SqlConnection connection)
        {
            adapter.SelectCommand = new SqlCommand(query, connection);      
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView.DataSource = table;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        static public int RowChange(SqlCommand command, string query,SqlConnection connection)
        {
            int count = 0;
            command.Connection = connection;
            command.CommandText = query;
            try
            {
                 
                count = command.ExecuteNonQuery();
                return count;
            }
            catch
            {              
                return 0;
            }  
        }
        static public void clearText(List<TextBox> textBoxes)
        {
            textBoxes.ForEach(
                tb => { tb.Clear(); }
                );
        }     
        static public void mapValueTextbox(GroupBox groupBox,object ob)
        {
            var grouptext = groupBox.Controls.OfType<TextBox>().OrderBy(tb => tb.TabIndex).ToList();
            List<TextBox> gr = new List<TextBox>();
            grouptext.ForEach(textbox => gr.Add(textbox));
            var listProperties = ob.GetType().GetProperties();
            for (int i = 0; i < listProperties.Length; i++)
            {
                gr[i].Text = listProperties[i].GetValue(ob).ToString();
            }
        }
    }
    class exec
    {
        static public bool execProc(SqlCommand command,SqlConnection Connect, List<TextBox> groupTextBox,user User,string ProcName)
        {
            command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            foreach (var texbox in groupTextBox)
            {
                command.Parameters.AddWithValue($"@{texbox.Name}", texbox.Text.Trim());
            }
            command.Parameters.AddWithValue("@MANV", User.UserName);
            if (function.RowChange(command, ProcName, Connect) > 0)
            {
                function.clearText(groupTextBox.ToList());
                return true;
            }
            else
            { return false; }
        }
    }
}
