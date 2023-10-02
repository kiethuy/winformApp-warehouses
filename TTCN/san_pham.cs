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

   

public partial class san_pham : Form
    {
        
        private user User = new user();
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlConnection Connect = connect.connect_db();
        List<TextBox> groupTextBox = new List<TextBox> { };
        string MASPC = "";

        static SqlCommand command = new SqlCommand();
        public san_pham(user user)
        {
            InitializeComponent();
            this.User = user;
            
        }
        private void loadGridfullSanPham(DataGridView dataGridView)
        {
            string query = "select * from SAN_PHAM";
            function.load_gridview(ref dataGridView, query, this.adapter, Connect);        
        }

        private void san_pham_Load(object sender, EventArgs e)     
        {
            function.SelectGroupBox(this.groupBoxMenu, User);
            Connect.Open();
            loadGridfullSanPham(dataGridViewSanPham);
            this.btnSua.Enabled = false;
            this.btnxoa.Enabled = false;
            this.btnCloseAction.Enabled = false;
           
            var gr = groupBoxSanPham.Controls.OfType<TextBox>().OrderBy(t => t.TabIndex);
            gr.ToList().ForEach(grtextb => groupTextBox.Add(grtextb));
        }

        private void them_Click(object sender, EventArgs e)
        {
            if (function.CheckText(groupTextBox) == false)
            {
                MessageBox.Show("có dữ liệu chưa được nhập");
            }
            else
            {
                if (function.TextNumber(this.SL) && function.TextNumber(this.GIANY) && function.TextNumber(this.GIANHAP) == true)
                {
                    if (exec.execProc(command, Connect, groupTextBox, User, "INSERT_SP") == true)
                    {
                        MessageBox.Show("đã thêm dữ liệu");
                        loadGridfullSanPham(dataGridViewSanPham);
                        
                    }
                    else { MessageBox.Show("them dl thất bại"); }
                    
                }
                else
                {
                    MessageBox.Show("vui lòng nhập số và ô giá nhập và giá niêm yết");
                }

            }
            command.Parameters.Clear();
        }

        private void dataGridViewSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) {
                int rowIdex = e.RowIndex;
                MASPC = dataGridViewSanPham.Rows[rowIdex].Cells[0].Value.ToString();

                for (int i = 0; i < dataGridViewSanPham.Rows[rowIdex].Cells.Count; i++)
                {
                    groupTextBox.ToList()[i].Text = dataGridViewSanPham.Rows[rowIdex].Cells[i].Value.ToString();

                }

                btnxoa.Enabled = true;
                them.Enabled = false;
                this.btnCloseAction.Enabled = true;
                btnSua.Enabled = true;
                btnChitietsp.Enabled = true;
            }
            
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {         
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@MASP", MASPC);
            command.Parameters.AddWithValue("@MANV", User.UserName);
           if(function.RowChange(command,"DELETE_SP",Connect) > 1)
            {
                MessageBox.Show("xóa sản phẩm thành công");               
                loadGridfullSanPham(dataGridViewSanPham);
                function.clearText(groupTextBox);
                btnSua.Enabled = false;
                btnxoa.Enabled = false;
                them.Enabled = true;
            }
            else
            {
                MessageBox.Show("xóa thất bại");
                command.Parameters.Clear();
            }
            MASPC = "";
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (function.CheckText(groupTextBox) == false)
            {
                MessageBox.Show("có dữ liệu chưa được nhập");
            }
            else
            {
                if (function.TextNumber(this.SL) && function.TextNumber(this.GIANY) && function.TextNumber(this.GIANHAP) &&function.TextNumber(SL)==true)
                {
                    
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MASPC", MASPC);
                    foreach (var texbox in groupTextBox)
                    {
                        command.Parameters.AddWithValue($"@{texbox.Name}", texbox.Text);
                    }
                    command.Parameters.AddWithValue("@MANV", User.UserName);
                    if (function.RowChange(command, "UPDATE_SP", Connect)>0)
                    {
                        MessageBox.Show("cập nhập thành công");
                        loadGridfullSanPham(dataGridViewSanPham);
                        
                        function.clearText(groupTextBox);
                        btnSua.Enabled = false;
                        btnxoa.Enabled = false;

                        them.Enabled = true;
                        MASPC = "";
                    }
                    else
                    {
                        MessageBox.Show("cập nhập thất bại");
                    }

                }
                else
                {
                    MessageBox.Show("vui lòng nhập số và ô giá nhập và giá niêm yết");
                }

            }
            command.Parameters.Clear();

        }

        private void btnCloseAction_Click(object sender, EventArgs e)
        {
            function.clearText(groupTextBox);
            btnSua.Enabled = false;
            btnxoa.Enabled = false;
            
            them.Enabled = true;
            btnCloseAction.Enabled = false;
            groupTextBox.ForEach(a => { a.Enabled = true; });
        }

        private void btnEditdata_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = true;
            this.btnCloseAction.Enabled = true;
            groupTextBox.ForEach(a => { a.Enabled = true; });
        }

        private void btnChitietsp_Click(object sender, EventArgs e)
        {
            groupBoxchitiet.Visible = true;
            string chi_tiet = $"select TEN_CHI_TIET,CHI_TIET_VALUES from CHI_TIET_SAN_PHAM ctsp join CHI_TIET ct on ctsp.MA_CHI_TIET=ct.MA_CHI_TIET where MA_SAN_PHAM='{MASPC}'";
            function.load_gridview(ref dataGridViewchitiet, chi_tiet, adapter, Connect);
        }

        private void btnCloseChitiet_Click(object sender, EventArgs e)
        {
            groupBoxchitiet.Visible = false;
            btnChitietsp.Enabled = true;
        }

        private void timkiem_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> comboSource = new Dictionary<string, string>();
            foreach (DataGridViewColumn colum in dataGridViewSanPham.Columns)
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
            string query = $"SELECT * FROM SAN_PHAM WHERE {Seach} like '%{textBoxSeach.Text}%' ";
            function.load_gridview(ref dataGridViewSanPham,query, adapter, Connect);
            groupBoxTimKiem.Visible = false;
            btnloadgrid.Visible = true;
            textBoxSeach.Clear();

        }
        private void btnloadgrid_Click(object sender, EventArgs e)
        {
            string query = "select * from SAN_PHAM";
            function.load_gridview(ref dataGridViewSanPham, query, this.adapter, Connect);
            btnloadgrid.Visible = false;
        }

        private void btnthemchitiet_Click(object sender, EventArgs e)
        {
            sanpham sp = new sanpham();
            sp.MA_SAN_PHAM = MASPC;
            sp.TEN_SAN_PHAM = TENSP.Text;
            sp.MA_NHA_CUNG_CAP = MANCC.Text;

           
            this.Hide();
            chi_tiet_san_pham ctsp = new chi_tiet_san_pham(sp,User);
            ctsp.ShowDialog();
            this.Show();
        }
    }
}
