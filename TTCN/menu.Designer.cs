
namespace WindowsFormsApp1
{
    partial class menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.STK = new System.Windows.Forms.GroupBox();
            this.menuSTK = new System.Windows.Forms.MenuStrip();
            this.sanpham = new System.Windows.Forms.ToolStripMenuItem();
            this.Formsanpham = new System.Windows.Forms.ToolStripMenuItem();
            this.Formchitiet = new System.Windows.Forms.ToolStripMenuItem();
            this.phieunhap = new System.Windows.Forms.ToolStripMenuItem();
            this.FormPhieunhap = new System.Windows.Forms.ToolStripMenuItem();
            this.chiTiếtPhiếuNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phieuxuat = new System.Windows.Forms.ToolStripMenuItem();
            this.formPhieuxuat = new System.Windows.Forms.ToolStripMenuItem();
            this.Formchitietphieuxuat = new System.Windows.Forms.ToolStripMenuItem();
            this.HR = new System.Windows.Forms.GroupBox();
            this.menuADM = new System.Windows.Forms.MenuStrip();
            this.nguoidung = new System.Windows.Forms.ToolStripMenuItem();
            this.BUS = new System.Windows.Forms.GroupBox();
            this.menuBUS = new System.Windows.Forms.MenuStrip();
            this.nhacungcap = new System.Windows.Forms.ToolStripMenuItem();
            this.khachhang = new System.Windows.Forms.ToolStripMenuItem();
            this.groupMENU = new System.Windows.Forms.GroupBox();
            this.ADM = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vai_tro = new System.Windows.Forms.ToolStripMenuItem();
            this.thongke = new System.Windows.Forms.ToolStripMenuItem();
            this.lichsuchinhsua = new System.Windows.Forms.ToolStripMenuItem();
            this.ACC = new System.Windows.Forms.GroupBox();
            this.menuACC = new System.Windows.Forms.MenuStrip();
            this.hoadon = new System.Windows.Forms.ToolStripMenuItem();
            this.menuhoadon = new System.Windows.Forms.ToolStripMenuItem();
            this.chitiethd = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.STK.SuspendLayout();
            this.menuSTK.SuspendLayout();
            this.HR.SuspendLayout();
            this.menuADM.SuspendLayout();
            this.BUS.SuspendLayout();
            this.menuBUS.SuspendLayout();
            this.groupMENU.SuspendLayout();
            this.ADM.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.ACC.SuspendLayout();
            this.menuACC.SuspendLayout();
            this.SuspendLayout();
            // 
            // STK
            // 
            this.STK.Controls.Add(this.menuSTK);
            this.STK.Location = new System.Drawing.Point(375, 12);
            this.STK.Name = "STK";
            this.STK.Size = new System.Drawing.Size(497, 64);
            this.STK.TabIndex = 5;
            this.STK.TabStop = false;
            this.STK.Visible = false;
            // 
            // menuSTK
            // 
            this.menuSTK.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuSTK.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sanpham,
            this.phieunhap,
            this.phieuxuat});
            this.menuSTK.Location = new System.Drawing.Point(3, 18);
            this.menuSTK.Name = "menuSTK";
            this.menuSTK.Size = new System.Drawing.Size(491, 28);
            this.menuSTK.TabIndex = 0;
            this.menuSTK.Text = "menuSTK";
            // 
            // sanpham
            // 
            this.sanpham.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Formsanpham,
            this.Formchitiet});
            this.sanpham.Name = "sanpham";
            this.sanpham.Size = new System.Drawing.Size(141, 24);
            this.sanpham.Text = "Quản lý sản phẩm";
            // 
            // Formsanpham
            // 
            this.Formsanpham.Name = "Formsanpham";
            this.Formsanpham.Size = new System.Drawing.Size(224, 26);
            this.Formsanpham.Text = "sản phẩm";
            this.Formsanpham.Click += new System.EventHandler(this.Formsanpham_Click);
            // 
            // Formchitiet
            // 
            this.Formchitiet.Name = "Formchitiet";
            this.Formchitiet.Size = new System.Drawing.Size(224, 26);
            this.Formchitiet.Text = "chi tiết";
            this.Formchitiet.Click += new System.EventHandler(this.Formchitiet_Click);
            // 
            // phieunhap
            // 
            this.phieunhap.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FormPhieunhap,
            this.chiTiếtPhiếuNhậpToolStripMenuItem});
            this.phieunhap.Name = "phieunhap";
            this.phieunhap.Size = new System.Drawing.Size(151, 24);
            this.phieunhap.Text = "Quản lý phiếu nhập";
            // 
            // FormPhieunhap
            // 
            this.FormPhieunhap.Name = "FormPhieunhap";
            this.FormPhieunhap.Size = new System.Drawing.Size(224, 26);
            this.FormPhieunhap.Text = "phiếu nhập";
            this.FormPhieunhap.Click += new System.EventHandler(this.FormPhieunhap_Click);
            // 
            // chiTiếtPhiếuNhậpToolStripMenuItem
            // 
            this.chiTiếtPhiếuNhậpToolStripMenuItem.Name = "chiTiếtPhiếuNhậpToolStripMenuItem";
            this.chiTiếtPhiếuNhậpToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.chiTiếtPhiếuNhậpToolStripMenuItem.Text = "chi tiết phiếu nhập";
            this.chiTiếtPhiếuNhậpToolStripMenuItem.Click += new System.EventHandler(this.chiTiếtPhiếuNhậpToolStripMenuItem_Click);
            // 
            // phieuxuat
            // 
            this.phieuxuat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formPhieuxuat,
            this.Formchitietphieuxuat});
            this.phieuxuat.Name = "phieuxuat";
            this.phieuxuat.Size = new System.Drawing.Size(146, 24);
            this.phieuxuat.Text = "Quản lý phiếu xuất";
            // 
            // formPhieuxuat
            // 
            this.formPhieuxuat.Name = "formPhieuxuat";
            this.formPhieuxuat.Size = new System.Drawing.Size(224, 26);
            this.formPhieuxuat.Text = "phiếu xuất";
            this.formPhieuxuat.Click += new System.EventHandler(this.formPhieuxuat_Click);
            // 
            // Formchitietphieuxuat
            // 
            this.Formchitietphieuxuat.Name = "Formchitietphieuxuat";
            this.Formchitietphieuxuat.Size = new System.Drawing.Size(224, 26);
            this.Formchitietphieuxuat.Text = "chi tiết phiếu xuất";
            this.Formchitietphieuxuat.Click += new System.EventHandler(this.Formchitietphieuxuat_Click);
            // 
            // HR
            // 
            this.HR.Controls.Add(this.menuADM);
            this.HR.Location = new System.Drawing.Point(1063, 12);
            this.HR.Name = "HR";
            this.HR.Size = new System.Drawing.Size(196, 64);
            this.HR.TabIndex = 4;
            this.HR.TabStop = false;
            this.HR.Visible = false;
            // 
            // menuADM
            // 
            this.menuADM.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuADM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nguoidung});
            this.menuADM.Location = new System.Drawing.Point(3, 18);
            this.menuADM.Name = "menuADM";
            this.menuADM.Size = new System.Drawing.Size(190, 28);
            this.menuADM.TabIndex = 0;
            this.menuADM.Text = "NGUOIDUNG";
            // 
            // nguoidung
            // 
            this.nguoidung.Name = "nguoidung";
            this.nguoidung.Size = new System.Drawing.Size(154, 24);
            this.nguoidung.Text = "Quản lý người dùng";
            this.nguoidung.Click += new System.EventHandler(this.nguoidung_Click);
            // 
            // BUS
            // 
            this.BUS.Controls.Add(this.menuBUS);
            this.BUS.Location = new System.Drawing.Point(6, 10);
            this.BUS.Name = "BUS";
            this.BUS.Size = new System.Drawing.Size(363, 64);
            this.BUS.TabIndex = 3;
            this.BUS.TabStop = false;
            this.BUS.Visible = false;
            // 
            // menuBUS
            // 
            this.menuBUS.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuBUS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhacungcap,
            this.khachhang});
            this.menuBUS.Location = new System.Drawing.Point(3, 18);
            this.menuBUS.Name = "menuBUS";
            this.menuBUS.Size = new System.Drawing.Size(357, 28);
            this.menuBUS.TabIndex = 0;
            this.menuBUS.Text = "menuBUS";
            // 
            // nhacungcap
            // 
            this.nhacungcap.Name = "nhacungcap";
            this.nhacungcap.Size = new System.Drawing.Size(165, 26);
            this.nhacungcap.Text = "Quản lý nhà cung cấp";
            this.nhacungcap.Click += new System.EventHandler(this.nhacungcap_Click);
            // 
            // khachhang
            // 
            this.khachhang.Name = "khachhang";
            this.khachhang.Size = new System.Drawing.Size(152, 26);
            this.khachhang.Text = "Quản lý khách hàng";
            this.khachhang.Click += new System.EventHandler(this.khachhang_Click);
            // 
            // groupMENU
            // 
            this.groupMENU.Controls.Add(this.ADM);
            this.groupMENU.Controls.Add(this.ACC);
            this.groupMENU.Controls.Add(this.BUS);
            this.groupMENU.Controls.Add(this.STK);
            this.groupMENU.Controls.Add(this.HR);
            this.groupMENU.Location = new System.Drawing.Point(-2, 2);
            this.groupMENU.Name = "groupMENU";
            this.groupMENU.Size = new System.Drawing.Size(1687, 76);
            this.groupMENU.TabIndex = 6;
            this.groupMENU.TabStop = false;
            this.groupMENU.Visible = false;
            // 
            // ADM
            // 
            this.ADM.Controls.Add(this.menuStrip1);
            this.ADM.Location = new System.Drawing.Point(1274, 10);
            this.ADM.Name = "ADM";
            this.ADM.Size = new System.Drawing.Size(386, 64);
            this.ADM.TabIndex = 5;
            this.ADM.TabStop = false;
            this.ADM.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vai_tro,
            this.thongke,
            this.lichsuchinhsua});
            this.menuStrip1.Location = new System.Drawing.Point(3, 18);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(380, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "NGUOIDUNG";
            // 
            // vai_tro
            // 
            this.vai_tro.Name = "vai_tro";
            this.vai_tro.Size = new System.Drawing.Size(119, 24);
            this.vai_tro.Text = "Quản lý vai trò";
            this.vai_tro.Click += new System.EventHandler(this.vai_tro_Click);
            // 
            // thongke
            // 
            this.thongke.Name = "thongke";
            this.thongke.Size = new System.Drawing.Size(81, 24);
            this.thongke.Text = "thống kê";
            this.thongke.Click += new System.EventHandler(this.thongke_Click);
            // 
            // lichsuchinhsua
            // 
            this.lichsuchinhsua.Name = "lichsuchinhsua";
            this.lichsuchinhsua.Size = new System.Drawing.Size(131, 24);
            this.lichsuchinhsua.Text = "lịch sử chỉnh sửa";
            this.lichsuchinhsua.Click += new System.EventHandler(this.lichsuchinhsua_Click);
            // 
            // ACC
            // 
            this.ACC.Controls.Add(this.menuACC);
            this.ACC.Location = new System.Drawing.Point(878, 10);
            this.ACC.Name = "ACC";
            this.ACC.Size = new System.Drawing.Size(179, 64);
            this.ACC.TabIndex = 6;
            this.ACC.TabStop = false;
            this.ACC.Visible = false;
            // 
            // menuACC
            // 
            this.menuACC.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuACC.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hoadon});
            this.menuACC.Location = new System.Drawing.Point(3, 18);
            this.menuACC.Name = "menuACC";
            this.menuACC.Size = new System.Drawing.Size(173, 28);
            this.menuACC.TabIndex = 0;
            this.menuACC.Text = "menuStrip1";
            // 
            // hoadon
            // 
            this.hoadon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuhoadon,
            this.chitiethd});
            this.hoadon.Name = "hoadon";
            this.hoadon.Size = new System.Drawing.Size(132, 24);
            this.hoadon.Text = "Quản lý hóa đơn";
            // 
            // menuhoadon
            // 
            this.menuhoadon.Name = "menuhoadon";
            this.menuhoadon.Size = new System.Drawing.Size(224, 26);
            this.menuhoadon.Text = "hóa đơn";
            this.menuhoadon.Click += new System.EventHandler(this.menuhoadon_Click);
            // 
            // chitiethd
            // 
            this.chitiethd.Name = "chitiethd";
            this.chitiethd.Size = new System.Drawing.Size(224, 26);
            this.chitiethd.Text = "chi tiết hóa đơn";
            this.chitiethd.Click += new System.EventHandler(this.chitiethd_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menu
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1714, 491);
            this.Controls.Add(this.groupMENU);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Name = "menu";
            this.Text = "menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.menu_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.STK.ResumeLayout(false);
            this.STK.PerformLayout();
            this.menuSTK.ResumeLayout(false);
            this.menuSTK.PerformLayout();
            this.HR.ResumeLayout(false);
            this.HR.PerformLayout();
            this.menuADM.ResumeLayout(false);
            this.menuADM.PerformLayout();
            this.BUS.ResumeLayout(false);
            this.BUS.PerformLayout();
            this.menuBUS.ResumeLayout(false);
            this.menuBUS.PerformLayout();
            this.groupMENU.ResumeLayout(false);
            this.ADM.ResumeLayout(false);
            this.ADM.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ACC.ResumeLayout(false);
            this.ACC.PerformLayout();
            this.menuACC.ResumeLayout(false);
            this.menuACC.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox STK;
        private System.Windows.Forms.MenuStrip menuSTK;
        private System.Windows.Forms.ToolStripMenuItem sanpham;
        private System.Windows.Forms.GroupBox HR;
        private System.Windows.Forms.MenuStrip menuADM;
        private System.Windows.Forms.ToolStripMenuItem nguoidung;
        private System.Windows.Forms.GroupBox BUS;
        private System.Windows.Forms.MenuStrip menuBUS;
        private System.Windows.Forms.ToolStripMenuItem nhacungcap;
        private System.Windows.Forms.ToolStripMenuItem khachhang;
        private System.Windows.Forms.GroupBox groupMENU;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox ACC;
        private System.Windows.Forms.MenuStrip menuACC;
        private System.Windows.Forms.ToolStripMenuItem hoadon;
        private System.Windows.Forms.ToolStripMenuItem phieunhap;
        private System.Windows.Forms.ToolStripMenuItem phieuxuat;
        private System.Windows.Forms.ToolStripMenuItem formPhieuxuat;
        private System.Windows.Forms.ToolStripMenuItem Formsanpham;
        private System.Windows.Forms.ToolStripMenuItem Formchitiet;
        private System.Windows.Forms.ToolStripMenuItem FormPhieunhap;
        private System.Windows.Forms.ToolStripMenuItem Formchitietphieuxuat;
        private System.Windows.Forms.ToolStripMenuItem menuhoadon;
        private System.Windows.Forms.ToolStripMenuItem chitiethd;
        private System.Windows.Forms.ToolStripMenuItem chiTiếtPhiếuNhậpToolStripMenuItem;
        private System.Windows.Forms.GroupBox ADM;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vai_tro;
        private System.Windows.Forms.ToolStripMenuItem thongke;
        private System.Windows.Forms.ToolStripMenuItem lichsuchinhsua;
    }
}

