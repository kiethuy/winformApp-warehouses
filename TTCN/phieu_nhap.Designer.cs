
namespace WindowsFormsApp1
{
    partial class phieu_nhap
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
            this.btnloadgrid = new System.Windows.Forms.Button();
            this.textBoxSeach = new System.Windows.Forms.TextBox();
            this.btnCloseGrSeach = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSelectSeach = new System.Windows.Forms.ComboBox();
            this.groupBoxTimKiem = new System.Windows.Forms.GroupBox();
            this.btnseach = new System.Windows.Forms.Button();
            this.groupBoxMenu = new System.Windows.Forms.GroupBox();
            this.STK005 = new System.Windows.Forms.GroupBox();
            this.btnxemChitietPN = new System.Windows.Forms.Button();
            this.timkiem = new System.Windows.Forms.Button();
            this.STK004 = new System.Windows.Forms.GroupBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.them = new System.Windows.Forms.Button();
            this.btnCloseAction = new System.Windows.Forms.Button();
            this.MAPNM = new System.Windows.Forms.TextBox();
            this.dataGridViewPhieuNhap = new System.Windows.Forms.DataGridView();
            this.MANCC = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.MA_SAN_PHAM = new System.Windows.Forms.Label();
            this.groupBoxphieunhap = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TIME = new System.Windows.Forms.DateTimePicker();
            this.NHACUNGCAP = new System.Windows.Forms.Label();
            this.TEN_SAN_PHAM = new System.Windows.Forms.Label();
            this.groupBoxTimKiem.SuspendLayout();
            this.groupBoxMenu.SuspendLayout();
            this.STK005.SuspendLayout();
            this.STK004.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBoxphieunhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnloadgrid
            // 
            this.btnloadgrid.Location = new System.Drawing.Point(1115, 470);
            this.btnloadgrid.Name = "btnloadgrid";
            this.btnloadgrid.Size = new System.Drawing.Size(108, 50);
            this.btnloadgrid.TabIndex = 28;
            this.btnloadgrid.Text = "xem toàn bộ phiếu nhập";
            this.btnloadgrid.UseVisualStyleBackColor = true;
            this.btnloadgrid.Visible = false;
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
            // groupBoxTimKiem
            // 
            this.groupBoxTimKiem.Controls.Add(this.textBoxSeach);
            this.groupBoxTimKiem.Controls.Add(this.btnCloseGrSeach);
            this.groupBoxTimKiem.Controls.Add(this.label1);
            this.groupBoxTimKiem.Controls.Add(this.comboBoxSelectSeach);
            this.groupBoxTimKiem.Controls.Add(this.btnseach);
            this.groupBoxTimKiem.Location = new System.Drawing.Point(914, 84);
            this.groupBoxTimKiem.Name = "groupBoxTimKiem";
            this.groupBoxTimKiem.Size = new System.Drawing.Size(318, 133);
            this.groupBoxTimKiem.TabIndex = 27;
            this.groupBoxTimKiem.TabStop = false;
            this.groupBoxTimKiem.Visible = false;
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
            // groupBoxMenu
            // 
            this.groupBoxMenu.Controls.Add(this.STK005);
            this.groupBoxMenu.Controls.Add(this.STK004);
            this.groupBoxMenu.Location = new System.Drawing.Point(532, 471);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Size = new System.Drawing.Size(510, 69);
            this.groupBoxMenu.TabIndex = 25;
            this.groupBoxMenu.TabStop = false;
            // 
            // STK005
            // 
            this.STK005.Controls.Add(this.btnxemChitietPN);
            this.STK005.Controls.Add(this.timkiem);
            this.STK005.Location = new System.Drawing.Point(18, 13);
            this.STK005.Name = "STK005";
            this.STK005.Size = new System.Drawing.Size(205, 50);
            this.STK005.TabIndex = 7;
            this.STK005.TabStop = false;
            // 
            // btnxemChitietPN
            // 
            this.btnxemChitietPN.Enabled = false;
            this.btnxemChitietPN.Location = new System.Drawing.Point(87, 18);
            this.btnxemChitietPN.Name = "btnxemChitietPN";
            this.btnxemChitietPN.Size = new System.Drawing.Size(99, 23);
            this.btnxemChitietPN.TabIndex = 4;
            this.btnxemChitietPN.Text = "xem chi tiết";
            this.btnxemChitietPN.UseVisualStyleBackColor = true;
            this.btnxemChitietPN.Click += new System.EventHandler(this.btnxemChitietPN_Click);
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
            // STK004
            // 
            this.STK004.Controls.Add(this.btnSua);
            this.STK004.Controls.Add(this.btnxoa);
            this.STK004.Controls.Add(this.them);
            this.STK004.Location = new System.Drawing.Point(229, 13);
            this.STK004.Name = "STK004";
            this.STK004.Size = new System.Drawing.Size(275, 51);
            this.STK004.TabIndex = 6;
            this.STK004.TabStop = false;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(6, 17);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(90, 31);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
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
            // btnCloseAction
            // 
            this.btnCloseAction.Location = new System.Drawing.Point(595, 4);
            this.btnCloseAction.Name = "btnCloseAction";
            this.btnCloseAction.Size = new System.Drawing.Size(29, 23);
            this.btnCloseAction.TabIndex = 18;
            this.btnCloseAction.Text = "X";
            this.btnCloseAction.UseVisualStyleBackColor = true;
            // 
            // MAPNM
            // 
            this.MAPNM.Location = new System.Drawing.Point(149, 11);
            this.MAPNM.Name = "MAPNM";
            this.MAPNM.Size = new System.Drawing.Size(133, 22);
            this.MAPNM.TabIndex = 1;
            // 
            // dataGridViewPhieuNhap
            // 
            this.dataGridViewPhieuNhap.AllowUserToAddRows = false;
            this.dataGridViewPhieuNhap.AllowUserToDeleteRows = false;
            this.dataGridViewPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewPhieuNhap.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewPhieuNhap.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPhieuNhap.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPhieuNhap.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewPhieuNhap.Name = "dataGridViewPhieuNhap";
            this.dataGridViewPhieuNhap.ReadOnly = true;
            this.dataGridViewPhieuNhap.RowHeadersWidth = 51;
            this.dataGridViewPhieuNhap.RowTemplate.Height = 24;
            this.dataGridViewPhieuNhap.Size = new System.Drawing.Size(896, 382);
            this.dataGridViewPhieuNhap.TabIndex = 23;
            this.dataGridViewPhieuNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPhieuNhap_CellClick);
            // 
            // MANCC
            // 
            this.MANCC.Location = new System.Drawing.Point(149, 122);
            this.MANCC.Name = "MANCC";
            this.MANCC.Size = new System.Drawing.Size(115, 22);
            this.MANCC.TabIndex = 6;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // MA_SAN_PHAM
            // 
            this.MA_SAN_PHAM.AllowDrop = true;
            this.MA_SAN_PHAM.AutoSize = true;
            this.MA_SAN_PHAM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MA_SAN_PHAM.Location = new System.Drawing.Point(18, 18);
            this.MA_SAN_PHAM.Name = "MA_SAN_PHAM";
            this.MA_SAN_PHAM.Size = new System.Drawing.Size(104, 19);
            this.MA_SAN_PHAM.TabIndex = 8;
            this.MA_SAN_PHAM.Text = "mã phiếu nhập";
            // 
            // groupBoxphieunhap
            // 
            this.groupBoxphieunhap.Controls.Add(this.button1);
            this.groupBoxphieunhap.Controls.Add(this.TIME);
            this.groupBoxphieunhap.Controls.Add(this.btnCloseAction);
            this.groupBoxphieunhap.Controls.Add(this.MAPNM);
            this.groupBoxphieunhap.Controls.Add(this.MANCC);
            this.groupBoxphieunhap.Controls.Add(this.MA_SAN_PHAM);
            this.groupBoxphieunhap.Controls.Add(this.NHACUNGCAP);
            this.groupBoxphieunhap.Controls.Add(this.TEN_SAN_PHAM);
            this.groupBoxphieunhap.Location = new System.Drawing.Point(98, 421);
            this.groupBoxphieunhap.Name = "groupBoxphieunhap";
            this.groupBoxphieunhap.Size = new System.Drawing.Size(365, 163);
            this.groupBoxphieunhap.TabIndex = 24;
            this.groupBoxphieunhap.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(336, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TIME
            // 
            this.TIME.Location = new System.Drawing.Point(149, 61);
            this.TIME.Name = "TIME";
            this.TIME.Size = new System.Drawing.Size(210, 22);
            this.TIME.TabIndex = 19;
            // 
            // NHACUNGCAP
            // 
            this.NHACUNGCAP.AllowDrop = true;
            this.NHACUNGCAP.AutoSize = true;
            this.NHACUNGCAP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NHACUNGCAP.Location = new System.Drawing.Point(18, 122);
            this.NHACUNGCAP.Name = "NHACUNGCAP";
            this.NHACUNGCAP.Size = new System.Drawing.Size(96, 19);
            this.NHACUNGCAP.TabIndex = 16;
            this.NHACUNGCAP.Text = "nhà cung cấp";
            // 
            // TEN_SAN_PHAM
            // 
            this.TEN_SAN_PHAM.AllowDrop = true;
            this.TEN_SAN_PHAM.AutoSize = true;
            this.TEN_SAN_PHAM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TEN_SAN_PHAM.Location = new System.Drawing.Point(18, 63);
            this.TEN_SAN_PHAM.Name = "TEN_SAN_PHAM";
            this.TEN_SAN_PHAM.Size = new System.Drawing.Size(77, 19);
            this.TEN_SAN_PHAM.TabIndex = 10;
            this.TEN_SAN_PHAM.Text = "ngày nhập";
            // 
            // phieu_nhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 602);
            this.Controls.Add(this.btnloadgrid);
            this.Controls.Add(this.groupBoxTimKiem);
            this.Controls.Add(this.groupBoxMenu);
            this.Controls.Add(this.dataGridViewPhieuNhap);
            this.Controls.Add(this.groupBoxphieunhap);
            this.Name = "phieu_nhap";
            this.Text = "phieu_nhap";
            this.Load += new System.EventHandler(this.phieu_nhap_Load);
            this.groupBoxTimKiem.ResumeLayout(false);
            this.groupBoxTimKiem.PerformLayout();
            this.groupBoxMenu.ResumeLayout(false);
            this.STK005.ResumeLayout(false);
            this.STK004.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBoxphieunhap.ResumeLayout(false);
            this.groupBoxphieunhap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnloadgrid;
        private System.Windows.Forms.TextBox textBoxSeach;
        private System.Windows.Forms.Button btnCloseGrSeach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSelectSeach;
        private System.Windows.Forms.GroupBox groupBoxTimKiem;
        private System.Windows.Forms.Button btnseach;
        private System.Windows.Forms.GroupBox groupBoxMenu;
        private System.Windows.Forms.GroupBox STK005;
        private System.Windows.Forms.Button btnxemChitietPN;
        private System.Windows.Forms.Button timkiem;
        private System.Windows.Forms.GroupBox STK004;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.Button btnCloseAction;
        private System.Windows.Forms.TextBox MAPNM;
        private System.Windows.Forms.DataGridView dataGridViewPhieuNhap;
        private System.Windows.Forms.TextBox MANCC;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBoxphieunhap;
        private System.Windows.Forms.DateTimePicker TIME;
        private System.Windows.Forms.Label MA_SAN_PHAM;
        private System.Windows.Forms.Label NHACUNGCAP;
        private System.Windows.Forms.Label TEN_SAN_PHAM;
        private System.Windows.Forms.Button button1;
    }
}