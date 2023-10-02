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
    public partial class lich_su : Form
    {
        SqlConnection Conn = connect.connect_db();
        DataTable table = new DataTable();
        public lich_su()
        {
            InitializeComponent();
        }

        private void lich_su_Load(object sender, EventArgs e)
        {
            Conn.Open();
            string query_full = $"select * from CHANGE order by MA_THAY_DOI desc";
            table = handleDatagridview.DataSetDatabase(query_full, Conn);
            dataGridViewLichsu.DataSource = table;
            dataGridViewLichsu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            Dictionary<string, string> comboSource = new Dictionary<string, string>();
            foreach (DataGridViewColumn colum in dataGridViewLichsu.Columns)
            {
                comboSource.Add(colum.Name, colum.Name);
            }
            comboBoxLS.DataSource = new BindingSource(comboSource, null);
            comboBoxLS.DisplayMember = "Value";
            comboBoxLS.ValueMember = "Key";
            Conn.Close();
        }

        private void textBoxlichsu_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Seach = comboBoxLS.SelectedValue.ToString();
            string query = $"SELECT * FROM CHANGE WHERE {Seach} like N'%{textBoxlichsu.Text}%' ";
            dataGridViewLichsu.DataSource = handleDatagridview.DataSetDatabase(query, Conn);
            textBoxlichsu.Clear();
        }

        private void btnCloseAction_Click(object sender, EventArgs e)
        {
            dataGridViewLichsu.DataSource = table;
        }
    }
}
