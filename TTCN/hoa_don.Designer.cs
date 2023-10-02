
namespace WindowsFormsApp1
{
    partial class hoa_don
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
            this.button1 = new System.Windows.Forms.Button();
            this.TEN_SAN_PHAM = new System.Windows.Forms.Label();
            this.groupBoxhoadon = new System.Windows.Forms.GroupBox();
            this.TIME = new System.Windows.Forms.DateTimePicker();
            this.MANVKT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MANVKD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MAHDM = new System.Windows.Forms.TextBox();
            this.MAKH = new System.Windows.Forms.TextBox();
            this.MA_SAN_PHAM = new System.Windows.Forms.Label();
            this.NHACUNGCAP = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridViewHOADON = new System.Windows.Forms.DataGridView();
            this.btnSua = new System.Windows.Forms.Button();
            this.timkiem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.them = new System.Windows.Forms.Button();
            this.btnxemChitietHD = new System.Windows.Forms.Button();
            this.ACC002 = new System.Windows.Forms.GroupBox();
            this.groupBoxMenu = new System.Windows.Forms.GroupBox();
            this.ACC001 = new System.Windows.Forms.GroupBox();
            this.groupBoxTimKiem = new System.Windows.Forms.GroupBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.btnCloseGrtimkiem = new System.Windows.Forms.Button();
            this.btnseach = new System.Windows.Forms.Button();
            this.groupBoxhoadon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHOADON)).BeginInit();
            this.ACC002.SuspendLayout();
            this.groupBoxMenu.SuspendLayout();
            this.ACC001.SuspendLayout();
            this.groupBoxTimKiem.SuspendLayout();
            this.SuspendLayout();
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
            this.TEN_SAN_PHAM.Location = new System.Drawing.Point(18, 63);
            this.TEN_SAN_PHAM.Name = "TEN_SAN_PHAM";
            this.TEN_SAN_PHAM.Size = new System.Drawing.Size(64, 19);
            this.TEN_SAN_PHAM.TabIndex = 10;
            this.TEN_SAN_PHAM.Text = "ngày lập";
            // 
            // groupBoxhoadon
            // 
            this.groupBoxhoadon.Controls.Add(this.TIME);
            this.groupBoxhoadon.Controls.Add(this.MANVKT);
            this.groupBoxhoadon.Controls.Add(this.label2);
            this.groupBoxhoadon.Controls.Add(this.MANVKD);
            this.groupBoxhoadon.Controls.Add(this.label1);
            this.groupBoxhoadon.Controls.Add(this.button1);
            this.groupBoxhoadon.Controls.Add(this.MAHDM);
            this.groupBoxhoadon.Controls.Add(this.MAKH);
            this.groupBoxhoadon.Controls.Add(this.MA_SAN_PHAM);
            this.groupBoxhoadon.Controls.Add(this.NHACUNGCAP);
            this.groupBoxhoadon.Controls.Add(this.TEN_SAN_PHAM);
            this.groupBoxhoadon.Location = new System.Drawing.Point(12, 403);
            this.groupBoxhoadon.Name = "groupBoxhoadon";
            this.groupBoxhoadon.Size = new System.Drawing.Size(736, 163);
            this.groupBoxhoadon.TabIndex = 30;
            this.groupBoxhoadon.TabStop = false;
            // 
            // TIME
            // 
            this.TIME.Location = new System.Drawing.Point(149, 58);
            this.TIME.Name = "TIME";
            this.TIME.Size = new System.Drawing.Size(210, 22);
            this.TIME.TabIndex = 34;
            // 
            // MANVKT
            // 
            this.MANVKT.Location = new System.Drawing.Point(532, 96);
            this.MANVKT.Name = "MANVKT";
            this.MANVKT.Size = new System.Drawing.Size(150, 22);
            this.MANVKT.TabIndex = 33;
            this.MANVKT.Visible = false;
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(357, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 19);
            this.label2.TabIndex = 32;
            this.label2.Text = "mã nhân viên kế toán";
            this.label2.Visible = false;
            // 
            // MANVKD
            // 
            this.MANVKD.Location = new System.Drawing.Point(532, 15);
            this.MANVKD.Name = "MANVKD";
            this.MANVKD.Size = new System.Drawing.Size(150, 22);
            this.MANVKD.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(357, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 19);
            this.label1.TabIndex = 30;
            this.label1.Text = "mã nhân viên kinh doanh";
            // 
            // MAHDM
            // 
            this.MAHDM.Location = new System.Drawing.Point(149, 11);
            this.MAHDM.Name = "MAHDM";
            this.MAHDM.Size = new System.Drawing.Size(133, 22);
            this.MAHDM.TabIndex = 1;
            // 
            // MAKH
            // 
            this.MAKH.Location = new System.Drawing.Point(149, 105);
            this.MAKH.Name = "MAKH";
            this.MAKH.Size = new System.Drawing.Size(115, 22);
            this.MAKH.TabIndex = 6;
            // 
            // MA_SAN_PHAM
            // 
            this.MA_SAN_PHAM.AllowDrop = true;
            this.MA_SAN_PHAM.AutoSize = true;
            this.MA_SAN_PHAM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MA_SAN_PHAM.Location = new System.Drawing.Point(18, 18);
            this.MA_SAN_PHAM.Name = "MA_SAN_PHAM";
            this.MA_SAN_PHAM.Size = new System.Drawing.Size(85, 19);
            this.MA_SAN_PHAM.TabIndex = 8;
            this.MA_SAN_PHAM.Text = "mã hóa đơn";
            // 
            // NHACUNGCAP
            // 
            this.NHACUNGCAP.AllowDrop = true;
            this.NHACUNGCAP.AutoSize = true;
            this.NHACUNGCAP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NHACUNGCAP.Location = new System.Drawing.Point(18, 105);
            this.NHACUNGCAP.Name = "NHACUNGCAP";
            this.NHACUNGCAP.Size = new System.Drawing.Size(107, 19);
            this.NHACUNGCAP.TabIndex = 16;
            this.NHACUNGCAP.Text = "mã khách hàng";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dataGridViewHOADON
            // 
            this.dataGridViewHOADON.AllowUserToAddRows = false;
            this.dataGridViewHOADON.AllowUserToDeleteRows = false;
            this.dataGridViewHOADON.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewHOADON.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewHOADON.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewHOADON.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewHOADON.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewHOADON.Location = new System.Drawing.Point(12, 3);
            this.dataGridViewHOADON.Name = "dataGridViewHOADON";
            this.dataGridViewHOADON.ReadOnly = true;
            this.dataGridViewHOADON.RowHeadersWidth = 51;
            this.dataGridViewHOADON.RowTemplate.Height = 24;
            this.dataGridViewHOADON.Size = new System.Drawing.Size(933, 382);
            this.dataGridViewHOADON.TabIndex = 29;
            this.dataGridViewHOADON.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHOADON_CellClick);
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
            // btnxemChitietHD
            // 
            this.btnxemChitietHD.Enabled = false;
            this.btnxemChitietHD.Location = new System.Drawing.Point(88, 17);
            this.btnxemChitietHD.Name = "btnxemChitietHD";
            this.btnxemChitietHD.Size = new System.Drawing.Size(99, 23);
            this.btnxemChitietHD.TabIndex = 4;
            this.btnxemChitietHD.Text = "xem chi tiết";
            this.btnxemChitietHD.UseVisualStyleBackColor = true;
            this.btnxemChitietHD.Click += new System.EventHandler(this.btnxemChitietHD_Click);
            // 
            // ACC002
            // 
            this.ACC002.Controls.Add(this.btnxemChitietHD);
            this.ACC002.Controls.Add(this.timkiem);
            this.ACC002.Location = new System.Drawing.Point(18, 13);
            this.ACC002.Name = "ACC002";
            this.ACC002.Size = new System.Drawing.Size(205, 50);
            this.ACC002.TabIndex = 7;
            this.ACC002.TabStop = false;
            // 
            // groupBoxMenu
            // 
            this.groupBoxMenu.Controls.Add(this.ACC002);
            this.groupBoxMenu.Controls.Add(this.ACC001);
            this.groupBoxMenu.Location = new System.Drawing.Point(771, 449);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Size = new System.Drawing.Size(510, 69);
            this.groupBoxMenu.TabIndex = 31;
            this.groupBoxMenu.TabStop = false;
            // 
            // ACC001
            // 
            this.ACC001.Controls.Add(this.btnSua);
            this.ACC001.Controls.Add(this.btnxoa);
            this.ACC001.Controls.Add(this.them);
            this.ACC001.Location = new System.Drawing.Point(229, 13);
            this.ACC001.Name = "ACC001";
            this.ACC001.Size = new System.Drawing.Size(275, 51);
            this.ACC001.TabIndex = 6;
            this.ACC001.TabStop = false;
            // 
            // groupBoxTimKiem
            // 
            this.groupBoxTimKiem.Controls.Add(this.textBoxSearch);
            this.groupBoxTimKiem.Controls.Add(this.btnCloseGrtimkiem);
            this.groupBoxTimKiem.Controls.Add(this.btnseach);
            this.groupBoxTimKiem.Location = new System.Drawing.Point(951, 69);
            this.groupBoxTimKiem.Name = "groupBoxTimKiem";
            this.groupBoxTimKiem.Size = new System.Drawing.Size(290, 133);
            this.groupBoxTimKiem.TabIndex = 32;
            this.groupBoxTimKiem.TabStop = false;
            this.groupBoxTimKiem.Visible = false;
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
            this.btnCloseGrtimkiem.Click += new System.EventHandler(this.btnCloseGrSeach_Click);
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
            // hoa_don
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 610);
            this.Controls.Add(this.groupBoxTimKiem);
            this.Controls.Add(this.groupBoxhoadon);
            this.Controls.Add(this.dataGridViewHOADON);
            this.Controls.Add(this.groupBoxMenu);
            this.Name = "hoa_don";
            this.Text = "hoa_don";
            this.Load += new System.EventHandler(this.hoa_don_Load);
            this.groupBoxhoadon.ResumeLayout(false);
            this.groupBoxhoadon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHOADON)).EndInit();
            this.ACC002.ResumeLayout(false);
            this.groupBoxMenu.ResumeLayout(false);
            this.ACC001.ResumeLayout(false);
            this.groupBoxTimKiem.ResumeLayout(false);
            this.groupBoxTimKiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label TEN_SAN_PHAM;
        private System.Windows.Forms.GroupBox groupBoxhoadon;
        private System.Windows.Forms.TextBox MANVKT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MANVKD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MAHDM;
        private System.Windows.Forms.TextBox MAKH;
        private System.Windows.Forms.Label MA_SAN_PHAM;
        private System.Windows.Forms.Label NHACUNGCAP;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dataGridViewHOADON;
        private System.Windows.Forms.GroupBox groupBoxMenu;
        private System.Windows.Forms.GroupBox ACC002;
        private System.Windows.Forms.Button btnxemChitietHD;
        private System.Windows.Forms.Button timkiem;
        private System.Windows.Forms.GroupBox ACC001;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.GroupBox groupBoxTimKiem;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button btnCloseGrtimkiem;
        private System.Windows.Forms.Button btnseach;
        private System.Windows.Forms.DateTimePicker TIME;
    }
}