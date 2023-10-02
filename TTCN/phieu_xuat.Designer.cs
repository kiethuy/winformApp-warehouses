
namespace WindowsFormsApp1
{
    partial class phieu_xuat
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
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.btnseach = new System.Windows.Forms.Button();
            this.groupBoxTimKiem = new System.Windows.Forms.GroupBox();
            this.btnCloseGrtimkiem = new System.Windows.Forms.Button();
            this.STK003 = new System.Windows.Forms.GroupBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.them = new System.Windows.Forms.Button();
            this.groupBoxMenu = new System.Windows.Forms.GroupBox();
            this.STK006 = new System.Windows.Forms.GroupBox();
            this.btnxemChitietPX = new System.Windows.Forms.Button();
            this.timkiem = new System.Windows.Forms.Button();
            this.dataGridViewPHIEUXUAT = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TIME = new System.Windows.Forms.DateTimePicker();
            this.MANVKD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MANVK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MAPXM = new System.Windows.Forms.TextBox();
            this.MA_SAN_PHAM = new System.Windows.Forms.Label();
            this.groupBoxhoadon = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TEN_SAN_PHAM = new System.Windows.Forms.Label();
            this.groupBoxTimKiem.SuspendLayout();
            this.STK003.SuspendLayout();
            this.groupBoxMenu.SuspendLayout();
            this.STK006.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPHIEUXUAT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBoxhoadon.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(87, 31);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(192, 76);
            this.textBoxSearch.TabIndex = 4;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
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
            // groupBoxTimKiem
            // 
            this.groupBoxTimKiem.Controls.Add(this.textBoxSearch);
            this.groupBoxTimKiem.Controls.Add(this.btnCloseGrtimkiem);
            this.groupBoxTimKiem.Controls.Add(this.btnseach);
            this.groupBoxTimKiem.Location = new System.Drawing.Point(1105, 54);
            this.groupBoxTimKiem.Name = "groupBoxTimKiem";
            this.groupBoxTimKiem.Size = new System.Drawing.Size(290, 133);
            this.groupBoxTimKiem.TabIndex = 36;
            this.groupBoxTimKiem.TabStop = false;
            this.groupBoxTimKiem.Visible = false;
            // 
            // btnCloseGrtimkiem
            // 
            this.btnCloseGrtimkiem.BackColor = System.Drawing.Color.LightCoral;
            this.btnCloseGrtimkiem.ForeColor = System.Drawing.Color.Red;
            this.btnCloseGrtimkiem.Location = new System.Drawing.Point(0, 98);
            this.btnCloseGrtimkiem.Name = "btnCloseGrtimkiem";
            this.btnCloseGrtimkiem.Size = new System.Drawing.Size(29, 35);
            this.btnCloseGrtimkiem.TabIndex = 3;
            this.btnCloseGrtimkiem.Text = "X";
            this.btnCloseGrtimkiem.UseVisualStyleBackColor = false;
            this.btnCloseGrtimkiem.Click += new System.EventHandler(this.btnCloseGrtimkiem_Click);
            // 
            // STK003
            // 
            this.STK003.Controls.Add(this.btnSua);
            this.STK003.Controls.Add(this.btnxoa);
            this.STK003.Controls.Add(this.them);
            this.STK003.Location = new System.Drawing.Point(229, 13);
            this.STK003.Name = "STK003";
            this.STK003.Size = new System.Drawing.Size(275, 51);
            this.STK003.TabIndex = 6;
            this.STK003.TabStop = false;
            // 
            // btnSua
            // 
            this.btnSua.Enabled = false;
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
            this.btnxoa.Enabled = false;
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
            // groupBoxMenu
            // 
            this.groupBoxMenu.Controls.Add(this.STK006);
            this.groupBoxMenu.Controls.Add(this.STK003);
            this.groupBoxMenu.Location = new System.Drawing.Point(787, 500);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Size = new System.Drawing.Size(510, 69);
            this.groupBoxMenu.TabIndex = 35;
            this.groupBoxMenu.TabStop = false;
            // 
            // STK006
            // 
            this.STK006.Controls.Add(this.btnxemChitietPX);
            this.STK006.Controls.Add(this.timkiem);
            this.STK006.Location = new System.Drawing.Point(18, 13);
            this.STK006.Name = "STK006";
            this.STK006.Size = new System.Drawing.Size(205, 50);
            this.STK006.TabIndex = 7;
            this.STK006.TabStop = false;
            // 
            // btnxemChitietPX
            // 
            this.btnxemChitietPX.Enabled = false;
            this.btnxemChitietPX.Location = new System.Drawing.Point(88, 17);
            this.btnxemChitietPX.Name = "btnxemChitietPX";
            this.btnxemChitietPX.Size = new System.Drawing.Size(99, 23);
            this.btnxemChitietPX.TabIndex = 4;
            this.btnxemChitietPX.Text = "xem chi tiết";
            this.btnxemChitietPX.UseVisualStyleBackColor = true;
            this.btnxemChitietPX.Click += new System.EventHandler(this.btnxemChitietPX_Click);
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
            // dataGridViewPHIEUXUAT
            // 
            this.dataGridViewPHIEUXUAT.AllowUserToAddRows = false;
            this.dataGridViewPHIEUXUAT.AllowUserToDeleteRows = false;
            this.dataGridViewPHIEUXUAT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewPHIEUXUAT.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewPHIEUXUAT.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewPHIEUXUAT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPHIEUXUAT.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPHIEUXUAT.Location = new System.Drawing.Point(2, 12);
            this.dataGridViewPHIEUXUAT.Name = "dataGridViewPHIEUXUAT";
            this.dataGridViewPHIEUXUAT.ReadOnly = true;
            this.dataGridViewPHIEUXUAT.RowHeadersWidth = 51;
            this.dataGridViewPHIEUXUAT.RowTemplate.Height = 24;
            this.dataGridViewPHIEUXUAT.Size = new System.Drawing.Size(1059, 392);
            this.dataGridViewPHIEUXUAT.TabIndex = 33;
            this.dataGridViewPHIEUXUAT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPHIEUXUAT_CellClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TIME
            // 
            this.TIME.Location = new System.Drawing.Point(149, 58);
            this.TIME.Name = "TIME";
            this.TIME.Size = new System.Drawing.Size(210, 22);
            this.TIME.TabIndex = 34;
            // 
            // MANVKD
            // 
            this.MANVKD.Location = new System.Drawing.Point(566, 60);
            this.MANVKD.Name = "MANVKD";
            this.MANVKD.Size = new System.Drawing.Size(164, 22);
            this.MANVKD.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(379, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 19);
            this.label1.TabIndex = 32;
            this.label1.Text = "mã nhân viên kinh doanh";
            // 
            // MANVK
            // 
            this.MANVK.Location = new System.Drawing.Point(169, 110);
            this.MANVK.Name = "MANVK";
            this.MANVK.Size = new System.Drawing.Size(150, 22);
            this.MANVK.TabIndex = 31;
            this.MANVK.Visible = false;
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(21, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 19);
            this.label2.TabIndex = 30;
            this.label2.Text = "mã nhân viên kho";
            this.label2.Visible = false;
            // 
            // MAPXM
            // 
            this.MAPXM.Location = new System.Drawing.Point(149, 11);
            this.MAPXM.Name = "MAPXM";
            this.MAPXM.Size = new System.Drawing.Size(133, 22);
            this.MAPXM.TabIndex = 1;
            // 
            // MA_SAN_PHAM
            // 
            this.MA_SAN_PHAM.AllowDrop = true;
            this.MA_SAN_PHAM.AutoSize = true;
            this.MA_SAN_PHAM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MA_SAN_PHAM.Location = new System.Drawing.Point(39, 15);
            this.MA_SAN_PHAM.Name = "MA_SAN_PHAM";
            this.MA_SAN_PHAM.Size = new System.Drawing.Size(98, 19);
            this.MA_SAN_PHAM.TabIndex = 8;
            this.MA_SAN_PHAM.Text = "mã phiếu xuất";
            // 
            // groupBoxhoadon
            // 
            this.groupBoxhoadon.Controls.Add(this.TIME);
            this.groupBoxhoadon.Controls.Add(this.MANVKD);
            this.groupBoxhoadon.Controls.Add(this.label1);
            this.groupBoxhoadon.Controls.Add(this.MANVK);
            this.groupBoxhoadon.Controls.Add(this.label2);
            this.groupBoxhoadon.Controls.Add(this.button1);
            this.groupBoxhoadon.Controls.Add(this.MAPXM);
            this.groupBoxhoadon.Controls.Add(this.MA_SAN_PHAM);
            this.groupBoxhoadon.Controls.Add(this.TEN_SAN_PHAM);
            this.groupBoxhoadon.Location = new System.Drawing.Point(12, 421);
            this.groupBoxhoadon.Name = "groupBoxhoadon";
            this.groupBoxhoadon.Size = new System.Drawing.Size(736, 163);
            this.groupBoxhoadon.TabIndex = 34;
            this.groupBoxhoadon.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(707, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TEN_SAN_PHAM
            // 
            this.TEN_SAN_PHAM.AllowDrop = true;
            this.TEN_SAN_PHAM.AutoSize = true;
            this.TEN_SAN_PHAM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TEN_SAN_PHAM.Location = new System.Drawing.Point(58, 63);
            this.TEN_SAN_PHAM.Name = "TEN_SAN_PHAM";
            this.TEN_SAN_PHAM.Size = new System.Drawing.Size(64, 19);
            this.TEN_SAN_PHAM.TabIndex = 10;
            this.TEN_SAN_PHAM.Text = "ngày lập";
            // 
            // phieu_xuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 596);
            this.Controls.Add(this.groupBoxTimKiem);
            this.Controls.Add(this.groupBoxMenu);
            this.Controls.Add(this.dataGridViewPHIEUXUAT);
            this.Controls.Add(this.groupBoxhoadon);
            this.Name = "phieu_xuat";
            this.Text = "phieu_xuat";
            this.Load += new System.EventHandler(this.phieu_xuat_Load);
            this.groupBoxTimKiem.ResumeLayout(false);
            this.groupBoxTimKiem.PerformLayout();
            this.STK003.ResumeLayout(false);
            this.groupBoxMenu.ResumeLayout(false);
            this.STK006.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPHIEUXUAT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBoxhoadon.ResumeLayout(false);
            this.groupBoxhoadon.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button btnseach;
        private System.Windows.Forms.GroupBox groupBoxTimKiem;
        private System.Windows.Forms.Button btnCloseGrtimkiem;
        private System.Windows.Forms.GroupBox STK003;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.GroupBox groupBoxMenu;
        private System.Windows.Forms.GroupBox STK006;
        private System.Windows.Forms.Button btnxemChitietPX;
        private System.Windows.Forms.Button timkiem;
        private System.Windows.Forms.DataGridView dataGridViewPHIEUXUAT;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBoxhoadon;
        private System.Windows.Forms.DateTimePicker TIME;
        private System.Windows.Forms.TextBox MANVKD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MANVK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox MAPXM;
        private System.Windows.Forms.Label MA_SAN_PHAM;
        private System.Windows.Forms.Label TEN_SAN_PHAM;
    }
}