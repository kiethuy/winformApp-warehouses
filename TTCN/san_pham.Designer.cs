
namespace WindowsFormsApp1
{
    partial class san_pham
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSua = new System.Windows.Forms.Button();
            this.dataGridViewSanPham = new System.Windows.Forms.DataGridView();
            this.timkiem = new System.Windows.Forms.Button();
            this.them = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.STK001 = new System.Windows.Forms.GroupBox();
            this.STK002 = new System.Windows.Forms.GroupBox();
            this.btnChitietsp = new System.Windows.Forms.Button();
            this.MA_SAN_PHAM = new System.Windows.Forms.Label();
            this.TEN_SAN_PHAM = new System.Windows.Forms.Label();
            this.GIA_NHAP = new System.Windows.Forms.Label();
            this.GIA_NIEM_YET = new System.Windows.Forms.Label();
            this.NHACUNGCAP = new System.Windows.Forms.Label();
            this.groupBoxSanPham = new System.Windows.Forms.GroupBox();
            this.btnCloseAction = new System.Windows.Forms.Button();
            this.MASPM = new System.Windows.Forms.TextBox();
            this.TENSP = new System.Windows.Forms.TextBox();
            this.GIANHAP = new System.Windows.Forms.TextBox();
            this.GIANY = new System.Windows.Forms.TextBox();
            this.SL = new System.Windows.Forms.TextBox();
            this.MANCC = new System.Windows.Forms.TextBox();
            this.labelSoLuong = new System.Windows.Forms.Label();
            this.groupBoxMenu = new System.Windows.Forms.GroupBox();
            this.groupBoxchitiet = new System.Windows.Forms.GroupBox();
            this.btnthemchitiet = new System.Windows.Forms.Button();
            this.btnCloseChitiet = new System.Windows.Forms.Button();
            this.lableSpct = new System.Windows.Forms.Label();
            this.dataGridViewchitiet = new System.Windows.Forms.DataGridView();
            this.groupBoxTimKiem = new System.Windows.Forms.GroupBox();
            this.textBoxSeach = new System.Windows.Forms.TextBox();
            this.btnCloseGrSeach = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSelectSeach = new System.Windows.Forms.ComboBox();
            this.btnseach = new System.Windows.Forms.Button();
            this.btnloadgrid = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.STK001.SuspendLayout();
            this.STK002.SuspendLayout();
            this.groupBoxSanPham.SuspendLayout();
            this.groupBoxMenu.SuspendLayout();
            this.groupBoxchitiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewchitiet)).BeginInit();
            this.groupBoxTimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(6, 17);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(90, 31);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "cập nhập";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // dataGridViewSanPham
            // 
            this.dataGridViewSanPham.AllowUserToAddRows = false;
            this.dataGridViewSanPham.AllowUserToDeleteRows = false;
            this.dataGridViewSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewSanPham.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewSanPham.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSanPham.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSanPham.Location = new System.Drawing.Point(-10, 3);
            this.dataGridViewSanPham.Name = "dataGridViewSanPham";
            this.dataGridViewSanPham.ReadOnly = true;
            this.dataGridViewSanPham.RowHeadersWidth = 51;
            this.dataGridViewSanPham.RowTemplate.Height = 24;
            this.dataGridViewSanPham.Size = new System.Drawing.Size(1235, 412);
            this.dataGridViewSanPham.TabIndex = 2;
            this.dataGridViewSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSanPham_CellClick);
            // 
            // timkiem
            // 
            this.timkiem.Location = new System.Drawing.Point(6, 17);
            this.timkiem.Name = "timkiem";
            this.timkiem.Size = new System.Drawing.Size(75, 24);
            this.timkiem.TabIndex = 3;
            this.timkiem.Text = "tìm kiếm";
            this.timkiem.UseVisualStyleBackColor = true;
            this.timkiem.Click += new System.EventHandler(this.timkiem_Click);
            // 
            // them
            // 
            this.them.Location = new System.Drawing.Point(102, 15);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(76, 33);
            this.them.TabIndex = 4;
            this.them.Text = "thêm";
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(184, 15);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(64, 33);
            this.btnxoa.TabIndex = 5;
            this.btnxoa.Text = "xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // STK001
            // 
            this.STK001.Controls.Add(this.btnSua);
            this.STK001.Controls.Add(this.btnxoa);
            this.STK001.Controls.Add(this.them);
            this.STK001.Location = new System.Drawing.Point(229, 13);
            this.STK001.Name = "STK001";
            this.STK001.Size = new System.Drawing.Size(275, 51);
            this.STK001.TabIndex = 6;
            this.STK001.TabStop = false;
            // 
            // STK002
            // 
            this.STK002.Controls.Add(this.btnChitietsp);
            this.STK002.Controls.Add(this.timkiem);
            this.STK002.Location = new System.Drawing.Point(18, 13);
            this.STK002.Name = "STK002";
            this.STK002.Size = new System.Drawing.Size(205, 50);
            this.STK002.TabIndex = 7;
            this.STK002.TabStop = false;
            // 
            // btnChitietsp
            // 
            this.btnChitietsp.Enabled = false;
            this.btnChitietsp.Location = new System.Drawing.Point(88, 17);
            this.btnChitietsp.Name = "btnChitietsp";
            this.btnChitietsp.Size = new System.Drawing.Size(99, 23);
            this.btnChitietsp.TabIndex = 4;
            this.btnChitietsp.Text = "xem chi tiết";
            this.btnChitietsp.UseVisualStyleBackColor = true;
            this.btnChitietsp.Click += new System.EventHandler(this.btnChitietsp_Click);
            // 
            // MA_SAN_PHAM
            // 
            this.MA_SAN_PHAM.AllowDrop = true;
            this.MA_SAN_PHAM.AutoSize = true;
            this.MA_SAN_PHAM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MA_SAN_PHAM.Location = new System.Drawing.Point(15, 39);
            this.MA_SAN_PHAM.Name = "MA_SAN_PHAM";
            this.MA_SAN_PHAM.Size = new System.Drawing.Size(95, 19);
            this.MA_SAN_PHAM.TabIndex = 8;
            this.MA_SAN_PHAM.Text = "mã sản phẩm";
            // 
            // TEN_SAN_PHAM
            // 
            this.TEN_SAN_PHAM.AllowDrop = true;
            this.TEN_SAN_PHAM.AutoSize = true;
            this.TEN_SAN_PHAM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TEN_SAN_PHAM.Location = new System.Drawing.Point(15, 84);
            this.TEN_SAN_PHAM.Name = "TEN_SAN_PHAM";
            this.TEN_SAN_PHAM.Size = new System.Drawing.Size(96, 19);
            this.TEN_SAN_PHAM.TabIndex = 10;
            this.TEN_SAN_PHAM.Text = "tên sản phẩm";
            // 
            // GIA_NHAP
            // 
            this.GIA_NHAP.AllowDrop = true;
            this.GIA_NHAP.AutoSize = true;
            this.GIA_NHAP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GIA_NHAP.Location = new System.Drawing.Point(15, 143);
            this.GIA_NHAP.Name = "GIA_NHAP";
            this.GIA_NHAP.Size = new System.Drawing.Size(65, 19);
            this.GIA_NHAP.TabIndex = 12;
            this.GIA_NHAP.Text = "giá nhập";
            // 
            // GIA_NIEM_YET
            // 
            this.GIA_NIEM_YET.AllowDrop = true;
            this.GIA_NIEM_YET.AutoSize = true;
            this.GIA_NIEM_YET.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GIA_NIEM_YET.Location = new System.Drawing.Point(405, 37);
            this.GIA_NIEM_YET.Name = "GIA_NIEM_YET";
            this.GIA_NIEM_YET.Size = new System.Drawing.Size(86, 19);
            this.GIA_NIEM_YET.TabIndex = 14;
            this.GIA_NIEM_YET.Text = "giá niêm yết";
            // 
            // NHACUNGCAP
            // 
            this.NHACUNGCAP.AllowDrop = true;
            this.NHACUNGCAP.AutoSize = true;
            this.NHACUNGCAP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NHACUNGCAP.Location = new System.Drawing.Point(405, 127);
            this.NHACUNGCAP.Name = "NHACUNGCAP";
            this.NHACUNGCAP.Size = new System.Drawing.Size(96, 19);
            this.NHACUNGCAP.TabIndex = 16;
            this.NHACUNGCAP.Text = "nhà cung cấp";
            // 
            // groupBoxSanPham
            // 
            this.groupBoxSanPham.Controls.Add(this.btnCloseAction);
            this.groupBoxSanPham.Controls.Add(this.MASPM);
            this.groupBoxSanPham.Controls.Add(this.TENSP);
            this.groupBoxSanPham.Controls.Add(this.GIANHAP);
            this.groupBoxSanPham.Controls.Add(this.GIANY);
            this.groupBoxSanPham.Controls.Add(this.SL);
            this.groupBoxSanPham.Controls.Add(this.MANCC);
            this.groupBoxSanPham.Controls.Add(this.MA_SAN_PHAM);
            this.groupBoxSanPham.Controls.Add(this.labelSoLuong);
            this.groupBoxSanPham.Controls.Add(this.NHACUNGCAP);
            this.groupBoxSanPham.Controls.Add(this.TEN_SAN_PHAM);
            this.groupBoxSanPham.Controls.Add(this.GIA_NIEM_YET);
            this.groupBoxSanPham.Controls.Add(this.GIA_NHAP);
            this.groupBoxSanPham.Location = new System.Drawing.Point(71, 421);
            this.groupBoxSanPham.Name = "groupBoxSanPham";
            this.groupBoxSanPham.Size = new System.Drawing.Size(624, 168);
            this.groupBoxSanPham.TabIndex = 18;
            this.groupBoxSanPham.TabStop = false;
            // 
            // btnCloseAction
            // 
            this.btnCloseAction.Location = new System.Drawing.Point(595, 4);
            this.btnCloseAction.Name = "btnCloseAction";
            this.btnCloseAction.Size = new System.Drawing.Size(29, 23);
            this.btnCloseAction.TabIndex = 18;
            this.btnCloseAction.Text = "X";
            this.btnCloseAction.UseVisualStyleBackColor = true;
            this.btnCloseAction.Click += new System.EventHandler(this.btnCloseAction_Click);
            // 
            // MASPM
            // 
            this.MASPM.Location = new System.Drawing.Point(146, 32);
            this.MASPM.Name = "MASPM";
            this.MASPM.Size = new System.Drawing.Size(100, 22);
            this.MASPM.TabIndex = 1;
            // 
            // TENSP
            // 
            this.TENSP.Location = new System.Drawing.Point(146, 60);
            this.TENSP.Multiline = true;
            this.TENSP.Name = "TENSP";
            this.TENSP.Size = new System.Drawing.Size(243, 74);
            this.TENSP.TabIndex = 2;
            // 
            // GIANHAP
            // 
            this.GIANHAP.Location = new System.Drawing.Point(146, 140);
            this.GIANHAP.Name = "GIANHAP";
            this.GIANHAP.Size = new System.Drawing.Size(100, 22);
            this.GIANHAP.TabIndex = 3;
            // 
            // GIANY
            // 
            this.GIANY.Location = new System.Drawing.Point(518, 33);
            this.GIANY.Name = "GIANY";
            this.GIANY.Size = new System.Drawing.Size(100, 22);
            this.GIANY.TabIndex = 4;
            // 
            // SL
            // 
            this.SL.Location = new System.Drawing.Point(518, 84);
            this.SL.Name = "SL";
            this.SL.Size = new System.Drawing.Size(100, 22);
            this.SL.TabIndex = 5;
            // 
            // MANCC
            // 
            this.MANCC.Location = new System.Drawing.Point(518, 127);
            this.MANCC.Name = "MANCC";
            this.MANCC.Size = new System.Drawing.Size(100, 22);
            this.MANCC.TabIndex = 6;
            // 
            // labelSoLuong
            // 
            this.labelSoLuong.AllowDrop = true;
            this.labelSoLuong.AutoSize = true;
            this.labelSoLuong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSoLuong.Location = new System.Drawing.Point(405, 84);
            this.labelSoLuong.Name = "labelSoLuong";
            this.labelSoLuong.Size = new System.Drawing.Size(64, 19);
            this.labelSoLuong.TabIndex = 17;
            this.labelSoLuong.Text = "số lượng";
            // 
            // groupBoxMenu
            // 
            this.groupBoxMenu.Controls.Add(this.STK002);
            this.groupBoxMenu.Controls.Add(this.STK001);
            this.groupBoxMenu.Location = new System.Drawing.Point(701, 454);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Size = new System.Drawing.Size(510, 69);
            this.groupBoxMenu.TabIndex = 19;
            this.groupBoxMenu.TabStop = false;
            // 
            // groupBoxchitiet
            // 
            this.groupBoxchitiet.Controls.Add(this.btnthemchitiet);
            this.groupBoxchitiet.Controls.Add(this.btnCloseChitiet);
            this.groupBoxchitiet.Controls.Add(this.lableSpct);
            this.groupBoxchitiet.Controls.Add(this.dataGridViewchitiet);
            this.groupBoxchitiet.Location = new System.Drawing.Point(318, 3);
            this.groupBoxchitiet.Name = "groupBoxchitiet";
            this.groupBoxchitiet.Size = new System.Drawing.Size(482, 393);
            this.groupBoxchitiet.TabIndex = 20;
            this.groupBoxchitiet.TabStop = false;
            this.groupBoxchitiet.Visible = false;
            // 
            // btnthemchitiet
            // 
            this.btnthemchitiet.BackColor = System.Drawing.SystemColors.Info;
            this.btnthemchitiet.Location = new System.Drawing.Point(6, 339);
            this.btnthemchitiet.Name = "btnthemchitiet";
            this.btnthemchitiet.Size = new System.Drawing.Size(146, 48);
            this.btnthemchitiet.TabIndex = 3;
            this.btnthemchitiet.Text = "cập nhập chi tiết cho sản phẩm ";
            this.btnthemchitiet.UseVisualStyleBackColor = false;
            this.btnthemchitiet.Click += new System.EventHandler(this.btnthemchitiet_Click);
            // 
            // btnCloseChitiet
            // 
            this.btnCloseChitiet.BackColor = System.Drawing.Color.Red;
            this.btnCloseChitiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseChitiet.ForeColor = System.Drawing.Color.Transparent;
            this.btnCloseChitiet.Location = new System.Drawing.Point(417, 5);
            this.btnCloseChitiet.Name = "btnCloseChitiet";
            this.btnCloseChitiet.Size = new System.Drawing.Size(59, 34);
            this.btnCloseChitiet.TabIndex = 2;
            this.btnCloseChitiet.Text = "X";
            this.btnCloseChitiet.UseVisualStyleBackColor = false;
            this.btnCloseChitiet.Click += new System.EventHandler(this.btnCloseChitiet_Click);
            // 
            // lableSpct
            // 
            this.lableSpct.AutoSize = true;
            this.lableSpct.Location = new System.Drawing.Point(91, 22);
            this.lableSpct.Name = "lableSpct";
            this.lableSpct.Size = new System.Drawing.Size(0, 17);
            this.lableSpct.TabIndex = 1;
            // 
            // dataGridViewchitiet
            // 
            this.dataGridViewchitiet.AllowUserToAddRows = false;
            this.dataGridViewchitiet.AllowUserToDeleteRows = false;
            this.dataGridViewchitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewchitiet.Location = new System.Drawing.Point(6, 42);
            this.dataGridViewchitiet.Name = "dataGridViewchitiet";
            this.dataGridViewchitiet.ReadOnly = true;
            this.dataGridViewchitiet.RowHeadersWidth = 51;
            this.dataGridViewchitiet.RowTemplate.Height = 24;
            this.dataGridViewchitiet.Size = new System.Drawing.Size(470, 291);
            this.dataGridViewchitiet.TabIndex = 0;
            // 
            // groupBoxTimKiem
            // 
            this.groupBoxTimKiem.Controls.Add(this.textBoxSeach);
            this.groupBoxTimKiem.Controls.Add(this.btnCloseGrSeach);
            this.groupBoxTimKiem.Controls.Add(this.label1);
            this.groupBoxTimKiem.Controls.Add(this.comboBoxSelectSeach);
            this.groupBoxTimKiem.Controls.Add(this.btnseach);
            this.groupBoxTimKiem.Location = new System.Drawing.Point(860, 90);
            this.groupBoxTimKiem.Name = "groupBoxTimKiem";
            this.groupBoxTimKiem.Size = new System.Drawing.Size(318, 133);
            this.groupBoxTimKiem.TabIndex = 21;
            this.groupBoxTimKiem.TabStop = false;
            this.groupBoxTimKiem.Visible = false;
            // 
            // textBoxSeach
            // 
            this.textBoxSeach.Location = new System.Drawing.Point(117, 64);
            this.textBoxSeach.Multiline = true;
            this.textBoxSeach.Name = "textBoxSeach";
            this.textBoxSeach.Size = new System.Drawing.Size(192, 45);
            this.textBoxSeach.TabIndex = 4;
            // 
            // btnCloseGrSeach
            // 
            this.btnCloseGrSeach.BackColor = System.Drawing.Color.LightCoral;
            this.btnCloseGrSeach.ForeColor = System.Drawing.Color.Red;
            this.btnCloseGrSeach.Location = new System.Drawing.Point(0, 98);
            this.btnCloseGrSeach.Name = "btnCloseGrSeach";
            this.btnCloseGrSeach.Size = new System.Drawing.Size(29, 35);
            this.btnCloseGrSeach.TabIndex = 3;
            this.btnCloseGrSeach.Text = "X";
            this.btnCloseGrSeach.UseVisualStyleBackColor = false;
            this.btnCloseGrSeach.Click += new System.EventHandler(this.btnCloseGrSeach_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "tìm kiếm theo";
            // 
            // comboBoxSelectSeach
            // 
            this.comboBoxSelectSeach.FormattingEnabled = true;
            this.comboBoxSelectSeach.Location = new System.Drawing.Point(117, 15);
            this.comboBoxSelectSeach.Name = "comboBoxSelectSeach";
            this.comboBoxSelectSeach.Size = new System.Drawing.Size(192, 24);
            this.comboBoxSelectSeach.TabIndex = 1;
            // 
            // btnseach
            // 
            this.btnseach.Location = new System.Drawing.Point(6, 53);
            this.btnseach.Name = "btnseach";
            this.btnseach.Size = new System.Drawing.Size(75, 23);
            this.btnseach.TabIndex = 0;
            this.btnseach.Text = "tìm kiếm";
            this.btnseach.UseVisualStyleBackColor = true;
            this.btnseach.Click += new System.EventHandler(this.btnseach_Click);
            // 
            // btnloadgrid
            // 
            this.btnloadgrid.Location = new System.Drawing.Point(1103, 539);
            this.btnloadgrid.Name = "btnloadgrid";
            this.btnloadgrid.Size = new System.Drawing.Size(108, 50);
            this.btnloadgrid.TabIndex = 22;
            this.btnloadgrid.Text = "xem toàn bộ sản phẩm";
            this.btnloadgrid.UseVisualStyleBackColor = true;
            this.btnloadgrid.Visible = false;
            this.btnloadgrid.Click += new System.EventHandler(this.btnloadgrid_Click);
            // 
            // san_pham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 593);
            this.Controls.Add(this.btnloadgrid);
            this.Controls.Add(this.groupBoxTimKiem);
            this.Controls.Add(this.groupBoxchitiet);
            this.Controls.Add(this.groupBoxMenu);
            this.Controls.Add(this.groupBoxSanPham);
            this.Controls.Add(this.dataGridViewSanPham);
            this.Name = "san_pham";
            this.Text = "san_pham";
            this.Load += new System.EventHandler(this.san_pham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.STK001.ResumeLayout(false);
            this.STK002.ResumeLayout(false);
            this.groupBoxSanPham.ResumeLayout(false);
            this.groupBoxSanPham.PerformLayout();
            this.groupBoxMenu.ResumeLayout(false);
            this.groupBoxchitiet.ResumeLayout(false);
            this.groupBoxchitiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewchitiet)).EndInit();
            this.groupBoxTimKiem.ResumeLayout(false);
            this.groupBoxTimKiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridView dataGridViewSanPham;
        private System.Windows.Forms.Button timkiem;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox STK002;
        private System.Windows.Forms.GroupBox STK001;

        private System.Windows.Forms.Label NHACUNGCAP;

        private System.Windows.Forms.Label GIA_NIEM_YET;

        private System.Windows.Forms.Label GIA_NHAP;

        private System.Windows.Forms.Label TEN_SAN_PHAM;

        private System.Windows.Forms.Label MA_SAN_PHAM;
        private System.Windows.Forms.GroupBox groupBoxMenu;
        private System.Windows.Forms.GroupBox groupBoxSanPham;

        private System.Windows.Forms.Label labelSoLuong;
        private System.Windows.Forms.TextBox GIANY;
        private System.Windows.Forms.TextBox SL;
        private System.Windows.Forms.TextBox MANCC;
        private System.Windows.Forms.TextBox MASPM;
        private System.Windows.Forms.TextBox TENSP;
        private System.Windows.Forms.TextBox GIANHAP;
        private System.Windows.Forms.Button btnCloseAction;
        private System.Windows.Forms.Button btnChitietsp;
        private System.Windows.Forms.GroupBox groupBoxchitiet;
        private System.Windows.Forms.DataGridView dataGridViewchitiet;
        private System.Windows.Forms.Label lableSpct;
        private System.Windows.Forms.Button btnCloseChitiet;
        private System.Windows.Forms.GroupBox groupBoxTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSelectSeach;
        private System.Windows.Forms.Button btnseach;
        private System.Windows.Forms.Button btnCloseGrSeach;
        private System.Windows.Forms.TextBox textBoxSeach;
        private System.Windows.Forms.Button btnloadgrid;
        private System.Windows.Forms.Button btnthemchitiet;
    }
}