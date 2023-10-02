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
    public partial class menu : Form
    {
         user User = new user();
        static List<GroupBox> ListGroupPermissions = new List<GroupBox> { };
        public menu(user user)
        {
            this.User = user;
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connect.connect_db();
            IEnumerable<GroupBox> groupBox = groupMENU.Controls.OfType<GroupBox>();
            groupBox.ToList().ForEach
                (
                   nhomquyen =>
                   {
                       User.nhom_quyen.ForEach
                       (
                           quyenUser =>
                           {
                               if (quyenUser == nhomquyen.Name)
                               {
                                   nhomquyen.Visible = true;
                               }
                           }
                   );
                   }

                );
            groupMENU.Visible = true;
        }

        private void nhacungcap_Click(object sender, EventArgs e)
        {
            this.Hide();
            nha_cung_cap ncc = new nha_cung_cap(User);
            ncc.ShowDialog();
            this.Show();
        }

        private void khachhang_Click(object sender, EventArgs e)
        {
            this.Hide();
            khach_hang kh = new khach_hang(User);
            kh.ShowDialog();
            //kh = null;
            this.Show();
        }

        private void Formsanpham_Click(object sender, EventArgs e)
        {
            this.Hide();
            san_pham sanpham = new san_pham(User);
            sanpham.ShowDialog();
            this.Show();
        }

        private void menuhoadon_Click(object sender, EventArgs e)
        {
            this.Hide();
            hoa_don hoadon = new hoa_don(User);
            hoadon.ShowDialog();
            this.Show();
        }

        private void Formchitiet_Click(object sender, EventArgs e)
        {
            this.Hide();
            chi_tiet chitiet = new chi_tiet(User);
            chitiet.ShowDialog();
            this.Show();
        }

        private void FormPhieunhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            phieu_nhap phieunhap = new phieu_nhap(User);
            phieunhap.ShowDialog();
            this.Show();
        }

       

        private void chitiethd_Click(object sender, EventArgs e)
        {
            this.Hide();
            chi_tiet_hoa_don_full Hoa_Don_Full = new chi_tiet_hoa_don_full(User);
            Hoa_Don_Full.ShowDialog();
            this.Show();
        }

        private void formPhieuxuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            phieu_xuat phieu_Xuat = new phieu_xuat(User);
            phieu_Xuat.ShowDialog();
            this.Show();
        }


        private void Formchitietphieuxuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            chi_tiet_phieu_xuat_full ctpxf = new chi_tiet_phieu_xuat_full(User);
            ctpxf.ShowDialog();
            this.Show();
        }

        private void chiTiếtPhiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            chi_tiet_phieu_nhap_full ctpnf = new chi_tiet_phieu_nhap_full(User);
            ctpnf.ShowDialog();
            this.Show();
        }

        private void nguoidung_Click(object sender, EventArgs e)
        {
            this.Hide();
            nguoi_dung NGUOIDUNG = new nguoi_dung(User);
            NGUOIDUNG.ShowDialog();
            this.Show();
        }

        private void vai_tro_Click(object sender, EventArgs e)
        {
            this.Hide();
            vai_tro vaitro = new vai_tro(User);
            vaitro.ShowDialog();
            this.Show();
        }

        private void lichsuchinhsua_Click(object sender, EventArgs e)
        {

            this.Hide();
            lich_su lich_Su = new lich_su();
            lich_Su.ShowDialog();
            this.Show();
        }

        private void thongke_Click(object sender, EventArgs e)
        {
           
            thong_ke thong_Ke = new thong_ke();
            thong_Ke.ShowDialog();
            thong_Ke = null;
            this.Show();
        }

       
        private void menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            User.nhom_quyen.Clear();
            User.chuc_nang.Clear();
            IEnumerable<GroupBox> groupBox = groupMENU.Controls.OfType<GroupBox>();
            groupBox.ToList().ForEach
                (a => { a.Visible = false; });
           
        }
    }
}
