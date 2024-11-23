using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace WindowsFormsApp1
{
    class Database
    {
        private string connectionString;
        private SqlConnection connect;
        public Database(string connectionString)
        {
            this.connectionString = connectionString;
            connect = new SqlConnection(connectionString);
        }
        public void openConect()
        {
            if (connect.State == System.Data.ConnectionState.Closed)
            {
                connect.Open();
            }
        }
        public int ExecuteNonQuery(string ProcName, SqlParameter Parameter)
        {
            int rowChange;
            openConect();
            using (SqlCommand command= new SqlCommand(ProcName,connect))
            {
                command.CommandType = CommandType.StoredProcedure;
               rowChange=  command.ExecuteNonQuery();
            }
            return rowChange;
        }
        public DataTable DataSetDatabase(string query)
        {
            DataTable table = new DataTable();
            using (SqlDataAdapter adapter= new SqlDataAdapter(query, connect))
            {
                using(DataSet set= new DataSet())
                {
                    adapter.Fill(table);
                }
            }
            return table;
        }

    }
    class handleDatagridview
    {
        static public DataTable DataSetDatabase(string query, SqlConnection connection)
        {
            DataTable table = new DataTable();
            using (SqlDataAdapter adapter = new SqlDataAdapter(query,connection))
            {
                using (DataSet set = new DataSet())
                {
                    adapter.Fill(table);
                }
            }
            return table;
        }
        static public void load_dataGridView_ToDatabase(ref DataGridView dataGridView,DataTable table)
        {
                dataGridView.DataSource = table;
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;     
        }
        static public string TongTien(DataTable table, string columnName)
        {
            int tong = 0;
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    int a = Convert.ToInt32(row[columnName]);
                    tong = tong + a;
                }
                
            }
            else
            {
               //comment code mới....
            }
            return tong.ToString();

        }
    }
}
