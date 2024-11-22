using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class user : IDisposable
    {
        private string MA_NGUOI_DUNG;
        public string UserName { get { return this.MA_NGUOI_DUNG; } set { MA_NGUOI_DUNG = value; } }
        private string MAT_KHAU;
        public string Password { get { return this.MAT_KHAU; } set { this.MAT_KHAU = value ; } }
        public string HO_TEN;
        public List<string> nhom_quyen = new List<string> { };
        public List<string> chuc_nang = new List<string> { };
        public void Dispose()
        {
            GC.Collect();
        }
    }
    public class sanpham
    {     
        public string MA_SAN_PHAM { set; get; }
        public string TEN_SAN_PHAM { get; set; }
        public int  GIA_NHAP { get; set; }
        public int GIA_NIEM_YET { get; set; }
        public int SO_LUONG { get; set; }
        public string MA_NHA_CUNG_CAP { set; get; }
       

    }
     public  class phieunhap : IDisposable
    {
        public string MA_PHIEU_NHAP { set; get; }
        public string NGAY_NHAP { set; get; }
        public string MA_NHA_CUNG_CAP { set; get; }
        public string MA_NHAN_VIEN_KHO { set; get; }
        public phieunhap(string mapn, string ngn, string mancc, string mnvk)
        {
            this.MA_PHIEU_NHAP = mapn;
            this.NGAY_NHAP = ngn;
            this.MA_NHA_CUNG_CAP = mancc;
            this.MA_NHAN_VIEN_KHO = mnvk;
        }
        public void Dispose()
        {
            GC.Collect();
        }
        public phieunhap()
        {
                //commit
        }
    }
    public class hoadon:IDisposable
    {
        public string MA_HOA_DON { set; get; }
        public string NGAY_LAP { set; get; }
        public string MA_KHACH_HANG { set; get; }
        public string MA_NHAN_VIEN_KINH_DOANH { set; get; }
        public string MA_NHAN_VIEN_KE_TOAN { set; get; }
        public hoadon(string mahd, string ngl,string makh, string manvkd, string mnvkt)
        {
            this.MA_HOA_DON = mahd;
            this.NGAY_LAP = ngl;
            this.MA_KHACH_HANG = makh;
            this.MA_NHAN_VIEN_KINH_DOANH = manvkd;
            this.MA_NHAN_VIEN_KE_TOAN = mnvkt;
        }
        public hoadon()
        {

        }
        public void Dispose()
        {
            GC.Collect();
        }
         ~hoadon()
        {
            ///conflict
        }
    }
   public partial class phieuxuat:IDisposable  {
        public string MA_PHIEU_XUAT { set; get; }
       public string NGAY_XUAT{ set; get; }
       public string MA_NHAN_VIEN_KHO { set; get; }
    public string MA_NHAN_VIEN_KINH_DOANH { set; get; }

        public phieuxuat()
        {

        }
        public void Dispose()
        {
            GC.Collect();
        }


    }
    public partial class vaitro : IDisposable
    {
        public string MA_VAI_TRO;
        public string TEN_VAI_TRO;
        public vaitro()
        {

        }
        public void Dispose()
        {
            GC.Collect();
        }
    }
    
}
