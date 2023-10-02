using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class chi_tiet_san_pham : Form
    {
        SqlDataAdapter adapter = new SqlDataAdapter();
        user User = new user();
        sanpham sanpham;
        SqlConnection Connect = connect.connect_db();
        SqlCommand command = new SqlCommand();
        DataTable table = new DataTable();
        string MACTC;
        public chi_tiet_san_pham(sanpham sanpham, user User)
        {
            InitializeComponent();
            this.sanpham = sanpham;
            this.User = User;
        }
        private void loadGridfullchitietsp(DataGridView dataGridView)
        {
            string sql_gridview = $"select ct.MA_CHI_TIET,ct.TEN_CHI_TIET,ctsp.CHI_TIET_VALUES from CHI_TIET_SAN_PHAM as ctsp join CHI_TIET as ct on ct.MA_CHI_TIET = ctsp.MA_CHI_TIET where MA_SAN_PHAM = '{sanpham.MA_SAN_PHAM}'";
            function.load_gridview(ref dataGridView, sql_gridview, adapter, Connect);
        }
        private void chi_tiet_san_pham_Load(object sender, EventArgs e)
        {
            Connect.Open();
            textboxMasp.Text = sanpham.MA_SAN_PHAM;
            textBoxTensp.Text = sanpham.TEN_SAN_PHAM;
            textBoxmancc.Text = sanpham.MA_NHA_CUNG_CAP;
            loadGridfullchitietsp(dataGridViewchitietsp);
            function.SelectGroupBox(this.groupBoxMenu, User);

            command = new SqlCommand("select * from CHI_TIET", Connect);
            var result = command.ExecuteReader();
            table.Load(result);
            chitiet.DataSource = table;
            chitiet.DisplayMember = "TEN_CHI_TIET";
            chitiet.ValueMember = "MA_CHI_TIET";

            btnsua.Enabled = false;
            btnxoa.Enabled = false;
        }

        private void dataGridViewchitietsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex< dataGridViewchitietsp.Rows.Count-1)
            {
                int index = e.RowIndex;
               
                MACTC = dataGridViewchitietsp.Rows[index].Cells[0].Value.ToString();
                chitiet.SelectedValue = dataGridViewchitietsp.Rows[index].Cells[0].Value.ToString();
                Chitietvalue.Text= dataGridViewchitietsp.Rows[index].Cells[2].Value.ToString();
                btnthem.Enabled = false;
                btnxoa.Enabled = true;
                btnsua.Enabled = true;
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (Chitietvalue.Text.Length == 0)
            {
                MessageBox.Show("chưa nhập giá trị");
            }
            else
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MASPM", textboxMasp.Text);
                command.Parameters.AddWithValue("@MACTM", chitiet.SelectedValue);
                command.Parameters.AddWithValue("@VALUE", Chitietvalue.Text);
                command.Parameters.AddWithValue("@MANV", User.UserName);
                if (function.RowChange(command, "INSERT_CTSP", Connect) > 0)
                {
                    MessageBox.Show("thêm thành công");
                    loadGridfullchitietsp(dataGridViewchitietsp);
                    command.Parameters.Clear();
                    Chitietvalue.Clear();
                }
                else
                {
                    MessageBox.Show("thêm ko thành công");

                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@MASPC", textboxMasp.Text);
            command.Parameters.AddWithValue("@MACTC", MACTC);
            command.Parameters.AddWithValue("@MANV", User.UserName);
            if (function.RowChange(command, "Delelte_CTSP", Connect) > 0)
            {
                MessageBox.Show("xóa thành công");
                loadGridfullchitietsp(dataGridViewchitietsp);
                command.Parameters.Clear();
                Chitietvalue.Clear();
                btnsua.Enabled = false;
                btnxoa.Enabled = false;
                btnthem.Enabled = true;
            }
            else
            {
                MessageBox.Show("xóa ko thành công");

            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@MASP", textboxMasp.Text);
            command.Parameters.AddWithValue("@MACTC", MACTC);
            command.Parameters.AddWithValue("@MACTM", chitiet.SelectedValue);
            command.Parameters.AddWithValue("@VALUE", Chitietvalue.Text);
            command.Parameters.AddWithValue("@MANV", User.UserName);
            if (function.RowChange(command, "UPDATE_CTSP", Connect) > 0)
            {
                MessageBox.Show("sửa thành công");
                loadGridfullchitietsp(dataGridViewchitietsp);
                command.Parameters.Clear();
                Chitietvalue.Clear();
                btnsua.Enabled = false;
                btnxoa.Enabled = false;
                btnthem.Enabled = true;
            }
            else
            {
                MessageBox.Show("sửa ko thành công");

            }
        }

        private void timkiem_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> comboSource = new Dictionary<string, string>();
            foreach (DataGridViewColumn colum in dataGridViewchitietsp.Columns)
            {
                comboSource.Add(colum.Name, colum.Name);
            }
            comboBoxSelectSeach.DataSource = new BindingSource(comboSource, null);
            comboBoxSelectSeach.DisplayMember = "Value";
            comboBoxSelectSeach.ValueMember = "Key";
            groupBoxTimKiem.Visible = true;
        }

        private void btnCloseGrSeach_Click(object sender, EventArgs e)
        {
            groupBoxTimKiem.Visible = false;
        }

        private void btnseach_Click(object sender, EventArgs e)
        {
            string Seach = comboBoxSelectSeach.SelectedValue.ToString();
            string query = $"SELECT * FROM CHI_TIET_SAN_PHAM WHERE {Seach} like '%{textBoxSeach.Text}%' and MA_SAN_PHAM='{sanpham.MA_SAN_PHAM}' ";
            function.load_gridview(ref dataGridViewchitietsp, query, adapter, Connect);
            groupBoxTimKiem.Visible = false;
            btnloadgrid.Visible = true;
            textBoxSeach.Clear();
        }

        private void btnloadgrid_Click(object sender, EventArgs e)
        {
            loadGridfullchitietsp(dataGridViewchitietsp);
            btnloadgrid.Visible = false;
        }

        private void btnCloseAction_Click(object sender, EventArgs e)
        {
            Chitietvalue.Clear();
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnthem.Enabled = true;
        }
    }
}
