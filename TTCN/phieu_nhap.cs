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
using System.Text.RegularExpressions;


namespace WindowsFormsApp1
{
    public partial class phieu_nhap : Form
    {

       static string Stringconenct = "Data Source=LAPTOPK;Initial Catalog=TTCN;Integrated Security=True";
        Database database = new Database(Stringconenct);
        user User = new user();
        string MAPNC = "";
        SqlConnection Conn = connect.connect_db();
        DataTable table = new DataTable();

        public phieu_nhap( user user)
        {
            this.User = user;
            InitializeComponent();
        }
       private void URI(string action)
        {
            Conn.Open();
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = Conn;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "UPDATE_PHIEU_NHAP";
                command.Parameters.AddWithValue("@action", action);
                command.Parameters.AddWithValue("@MAPNC", MAPNC);
                command.Parameters.AddWithValue("@MAPNM", MAPNM.Text.Trim());
                command.Parameters.AddWithValue("@TIME", TIME.Value);
                command.Parameters.AddWithValue("@MANCC", MANCC.Text.Trim());
                command.Parameters.AddWithValue("@MANVK", User.UserName);
                command.Parameters.AddWithValue("@MANV", User.UserName);
                try
                {
                    if (command.ExecuteNonQuery() > 1)
                    {
                        MessageBox.Show("cập nhập thành công");
                    }
                }
                catch
                {
                    MessageBox.Show("lỗi trùng mã hoặc sai thông tin sản phẩm hoặc nhà cung cấp");
                }
                  
            }
            Conn.Close();
        }
        private void load_full_phieu_nhap()
        {
            string queryFullPhieuNhap = "select * from Phieu_nhap";
            this.table = database.DataSetDatabase(queryFullPhieuNhap);

        }
        private void phieu_nhap_Load(object sender, EventArgs e)
        {
            Conn.Open();
            function.SelectGroupBox(this.groupBoxMenu, User);
            load_full_phieu_nhap();
            dataGridViewPhieuNhap.DataSource = this.table;
            dataGridViewPhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            btnSua.Enabled = false;
            btnxoa.Enabled = false;
            btnxemChitietPN.Enabled = false;
            Conn.Close();
        }

        private void them_Click(object sender, EventArgs e)
        {
                if (MAPNM.Text.Trim() != "" && MANCC.Text.Trim() != "")
                {
                    if (function.TextNumber(MAPNM) == true)
                    {
                    MAPNM.Text = "PN" + MAPNM.Text;
                    URI("INSERT");
                        DataRow row = table.Rows.Add();
                        row["MA_PHIEU_NHAP"] = MAPNM.Text.Trim();
                        row["NGAY_NHAP"] = TIME.Value;
                        row["MA_NHA_CUNG_CAP"] = MANCC.Text.Trim();
                        row["MA_NHAN_VIEN_KHO"] = User.UserName;                   
                    }
                    else
                    {
                        MessageBox.Show("nhập mã phiếu nhập là số");
                    }
                }                         
        }

        private void dataGridViewPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int rowIdex = e.RowIndex;
                MAPNC = dataGridViewPhieuNhap.Rows[rowIdex].Cells[0].Value.ToString();
                MAPNM.Text = dataGridViewPhieuNhap.Rows[rowIdex].Cells[0].Value.ToString();
                TIME.Value = DateTime.Parse(dataGridViewPhieuNhap.Rows[rowIdex].Cells[1].Value.ToString());
                MANCC.Text= dataGridViewPhieuNhap.Rows[rowIdex].Cells[2].Value.ToString();
            }
            btnSua.Enabled = true;
            btnxoa.Enabled = true;
            them.Enabled = false;
            btnxemChitietPN.Enabled = true;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            URI("DELETE");
            dataGridViewPhieuNhap.Rows.Remove(dataGridViewPhieuNhap.CurrentRow);
            btnSua.Enabled = true;
            btnxoa.Enabled = true;
            them.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^PN[0-9]+$");
            if(!regex.IsMatch(MAPNM.Text))
            {
                MessageBox.Show("vui lòng nhập đúng định dạng mã phiếu nhập");
            }
            else
            {
                URI("UPDATE");
                dataGridViewPhieuNhap.CurrentRow.Cells[0].Value = MAPNM.Text;
                dataGridViewPhieuNhap.CurrentRow.Cells[1].Value = TIME.Value;
                dataGridViewPhieuNhap.CurrentRow.Cells[2].Value = MANCC.Text;
                btnSua.Enabled = true;
                btnxoa.Enabled = true;
                them.Enabled = false;
            }         
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MAPNM.Clear();
            MANCC.Clear();
            them.Enabled = true;
            btnSua.Enabled = false;
            btnxoa.Enabled = false;
        }
        private void btnxemChitietPN_Click(object sender, EventArgs e)
        {
            phieunhap phieunhap = new phieunhap(MAPNM.Text, TIME.Value.ToString(), MANCC.Text, User.UserName);
            chi_tiet_phieu_nhap chi_Tiet_Phieu_Nhap = new chi_tiet_phieu_nhap(User,phieunhap);
            chi_Tiet_Phieu_Nhap.ShowDialog();
            string query = $"select MA_SAN_PHAM,SO_LUONG,DON_GIA_NHAP from CHI_TIET_PHIEU_NHAP where MA_PHIEU_NHAP={MAPNM.Text} ";       
        }
        private void timkiem_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> comboSource = new Dictionary<string, string>();
            foreach (DataGridViewColumn colum in dataGridViewPhieuNhap.Columns)
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
            dataGridViewPhieuNhap.DataSource = table;
        }

        private void btnseach_Click(object sender, EventArgs e)
        {        
                string Seach = comboBoxSelectSeach.SelectedValue.ToString();
                string query = $"SELECT * FROM PHIEU_NHAP WHERE {Seach} like '%{textBoxSeach.Text.Trim()}%' ";
                dataGridViewPhieuNhap.DataSource= database.DataSetDatabase(query);
        }
    }
}
