
namespace WindowsFormsApp1
{
    partial class chi_tiet_phieu_nhap
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.PRIN_PHIEU_NHAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.INHD = new WindowsFormsApp1.INHD();
            this.textBoxSeach = new System.Windows.Forms.TextBox();
            this.btnCloseGrSeach = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxSelectSeach = new System.Windows.Forms.ComboBox();
            this.groupBoxTimKiem = new System.Windows.Forms.GroupBox();
            this.btnseach = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxmancc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNgayNhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCloseAction = new System.Windows.Forms.Button();
            this.SL = new System.Windows.Forms.TextBox();
            this.textboxMaPN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxPN = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.STK001 = new System.Windows.Forms.GroupBox();
            this.btnInPhieu = new System.Windows.Forms.Button();
            this.timkiem = new System.Windows.Forms.Button();
            this.STK002 = new System.Windows.Forms.GroupBox();
            this.groupBoxchitietPN = new System.Windows.Forms.GroupBox();
            this.MCTPNM = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DONGIA = new System.Windows.Forms.TextBox();
            this.MASP = new System.Windows.Forms.TextBox();
            this.groupBoxMenu = new System.Windows.Forms.GroupBox();
            this.dataGridViewchitietPN = new System.Windows.Forms.DataGridView();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button2 = new System.Windows.Forms.Button();
            this.PRIN_PHIEU_NHAPTableAdapter = new WindowsFormsApp1.INHDTableAdapters.PRIN_PHIEU_NHAPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PRIN_PHIEU_NHAPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.INHD)).BeginInit();
            this.groupBoxTimKiem.SuspendLayout();
            this.groupBoxPN.SuspendLayout();
            this.STK001.SuspendLayout();
            this.STK002.SuspendLayout();
            this.groupBoxchitietPN.SuspendLayout();
            this.groupBoxMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewchitietPN)).BeginInit();
            this.SuspendLayout();
            // 
            // PRIN_PHIEU_NHAPBindingSource
            // 
            this.PRIN_PHIEU_NHAPBindingSource.DataMember = "PRIN_PHIEU_NHAP";
            this.PRIN_PHIEU_NHAPBindingSource.DataSource = this.INHD;
            // 
            // INHD
            // 
            this.INHD.DataSetName = "INHD";
            this.INHD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "tìm kiếm theo";
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
            this.groupBoxTimKiem.Controls.Add(this.label6);
            this.groupBoxTimKiem.Controls.Add(this.comboBoxSelectSeach);
            this.groupBoxTimKiem.Controls.Add(this.btnseach);
            this.groupBoxTimKiem.Location = new System.Drawing.Point(921, 83);
            this.groupBoxTimKiem.Name = "groupBoxTimKiem";
            this.groupBoxTimKiem.Size = new System.Drawing.Size(318, 133);
            this.groupBoxTimKiem.TabIndex = 29;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "mã sản phẩm";
            // 
            // textBoxmancc
            // 
            this.textBoxmancc.Enabled = false;
            this.textBoxmancc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textBoxmancc.Location = new System.Drawing.Point(154, 114);
            this.textBoxmancc.Name = "textBoxmancc";
            this.textBoxmancc.Size = new System.Drawing.Size(181, 22);
            this.textBoxmancc.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "mã nhà cung cấp";
            // 
            // textBoxNgayNhap
            // 
            this.textBoxNgayNhap.Enabled = false;
            this.textBoxNgayNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textBoxNgayNhap.Location = new System.Drawing.Point(154, 49);
            this.textBoxNgayNhap.Multiline = true;
            this.textBoxNgayNhap.Name = "textBoxNgayNhap";
            this.textBoxNgayNhap.Size = new System.Drawing.Size(181, 59);
            this.textBoxNgayNhap.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "ngày nhập";
            // 
            // btnCloseAction
            // 
            this.btnCloseAction.BackColor = System.Drawing.Color.LightCoral;
            this.btnCloseAction.ForeColor = System.Drawing.Color.Red;
            this.btnCloseAction.Location = new System.Drawing.Point(253, 0);
            this.btnCloseAction.Name = "btnCloseAction";
            this.btnCloseAction.Size = new System.Drawing.Size(29, 35);
            this.btnCloseAction.TabIndex = 5;
            this.btnCloseAction.Text = "X";
            this.btnCloseAction.UseVisualStyleBackColor = false;
            this.btnCloseAction.Click += new System.EventHandler(this.btnCloseAction_Click);
            // 
            // SL
            // 
            this.SL.Location = new System.Drawing.Point(110, 109);
            this.SL.Name = "SL";
            this.SL.Size = new System.Drawing.Size(121, 22);
            this.SL.TabIndex = 7;
            // 
            // textboxMaPN
            // 
            this.textboxMaPN.Enabled = false;
            this.textboxMaPN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textboxMaPN.Location = new System.Drawing.Point(154, 21);
            this.textboxMaPN.Name = "textboxMaPN";
            this.textboxMaPN.Size = new System.Drawing.Size(181, 22);
            this.textboxMaPN.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "mã phiếu nhập";
            // 
            // groupBoxPN
            // 
            this.groupBoxPN.Controls.Add(this.textBox1);
            this.groupBoxPN.Controls.Add(this.label9);
            this.groupBoxPN.Controls.Add(this.textBoxmancc);
            this.groupBoxPN.Controls.Add(this.label3);
            this.groupBoxPN.Controls.Add(this.textBoxNgayNhap);
            this.groupBoxPN.Controls.Add(this.label2);
            this.groupBoxPN.Controls.Add(this.textboxMaPN);
            this.groupBoxPN.Controls.Add(this.label1);
            this.groupBoxPN.Location = new System.Drawing.Point(36, 332);
            this.groupBoxPN.Name = "groupBoxPN";
            this.groupBoxPN.Size = new System.Drawing.Size(363, 183);
            this.groupBoxPN.TabIndex = 27;
            this.groupBoxPN.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textBox1.Location = new System.Drawing.Point(154, 143);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 22);
            this.textBox1.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(0, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "mã nhà nhân viên kho";
            // 
            // btnxoa
            // 
            this.btnxoa.Enabled = false;
            this.btnxoa.Location = new System.Drawing.Point(168, 21);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 2;
            this.btnxoa.Text = "xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Enabled = false;
            this.btnsua.Location = new System.Drawing.Point(87, 21);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 1;
            this.btnsua.Text = "sửa ";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(6, 21);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // STK001
            // 
            this.STK001.Controls.Add(this.btnInPhieu);
            this.STK001.Controls.Add(this.btnxoa);
            this.STK001.Controls.Add(this.btnsua);
            this.STK001.Controls.Add(this.btnthem);
            this.STK001.Location = new System.Drawing.Point(112, 21);
            this.STK001.Name = "STK001";
            this.STK001.Size = new System.Drawing.Size(365, 61);
            this.STK001.TabIndex = 1;
            this.STK001.TabStop = false;
            // 
            // btnInPhieu
            // 
            this.btnInPhieu.Location = new System.Drawing.Point(261, 16);
            this.btnInPhieu.Name = "btnInPhieu";
            this.btnInPhieu.Size = new System.Drawing.Size(82, 33);
            this.btnInPhieu.TabIndex = 7;
            this.btnInPhieu.Text = "in phiếu";
            this.btnInPhieu.UseVisualStyleBackColor = true;
            this.btnInPhieu.Click += new System.EventHandler(this.btnInPhieu_Click);
            // 
            // timkiem
            // 
            this.timkiem.Location = new System.Drawing.Point(6, 21);
            this.timkiem.Name = "timkiem";
            this.timkiem.Size = new System.Drawing.Size(75, 23);
            this.timkiem.TabIndex = 0;
            this.timkiem.Text = "tìm kiếm";
            this.timkiem.UseVisualStyleBackColor = true;
            this.timkiem.Click += new System.EventHandler(this.timkiem_Click);
            // 
            // STK002
            // 
            this.STK002.Controls.Add(this.timkiem);
            this.STK002.Location = new System.Drawing.Point(17, 21);
            this.STK002.Name = "STK002";
            this.STK002.Size = new System.Drawing.Size(89, 61);
            this.STK002.TabIndex = 2;
            this.STK002.TabStop = false;
            // 
            // groupBoxchitietPN
            // 
            this.groupBoxchitietPN.Controls.Add(this.MCTPNM);
            this.groupBoxchitietPN.Controls.Add(this.label8);
            this.groupBoxchitietPN.Controls.Add(this.label7);
            this.groupBoxchitietPN.Controls.Add(this.DONGIA);
            this.groupBoxchitietPN.Controls.Add(this.MASP);
            this.groupBoxchitietPN.Controls.Add(this.btnCloseAction);
            this.groupBoxchitietPN.Controls.Add(this.SL);
            this.groupBoxchitietPN.Controls.Add(this.label4);
            this.groupBoxchitietPN.Controls.Add(this.label5);
            this.groupBoxchitietPN.Location = new System.Drawing.Point(396, 332);
            this.groupBoxchitietPN.Name = "groupBoxchitietPN";
            this.groupBoxchitietPN.Size = new System.Drawing.Size(282, 183);
            this.groupBoxchitietPN.TabIndex = 28;
            this.groupBoxchitietPN.TabStop = false;
            // 
            // MCTPNM
            // 
            this.MCTPNM.Location = new System.Drawing.Point(110, 26);
            this.MCTPNM.Name = "MCTPNM";
            this.MCTPNM.Size = new System.Drawing.Size(121, 22);
            this.MCTPNM.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "mã chi tiết ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "đơn giá nhập";
            // 
            // DONGIA
            // 
            this.DONGIA.Location = new System.Drawing.Point(110, 145);
            this.DONGIA.Name = "DONGIA";
            this.DONGIA.Size = new System.Drawing.Size(121, 22);
            this.DONGIA.TabIndex = 8;
            // 
            // MASP
            // 
            this.MASP.Location = new System.Drawing.Point(110, 63);
            this.MASP.Name = "MASP";
            this.MASP.Size = new System.Drawing.Size(121, 22);
            this.MASP.TabIndex = 6;
            // 
            // groupBoxMenu
            // 
            this.groupBoxMenu.Controls.Add(this.STK002);
            this.groupBoxMenu.Controls.Add(this.STK001);
            this.groupBoxMenu.Location = new System.Drawing.Point(696, 353);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Size = new System.Drawing.Size(484, 100);
            this.groupBoxMenu.TabIndex = 26;
            this.groupBoxMenu.TabStop = false;
            // 
            // dataGridViewchitietPN
            // 
            this.dataGridViewchitietPN.AllowUserToAddRows = false;
            this.dataGridViewchitietPN.AllowUserToDeleteRows = false;
            this.dataGridViewchitietPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewchitietPN.Location = new System.Drawing.Point(20, 40);
            this.dataGridViewchitietPN.Name = "dataGridViewchitietPN";
            this.dataGridViewchitietPN.ReadOnly = true;
            this.dataGridViewchitietPN.RowHeadersWidth = 51;
            this.dataGridViewchitietPN.RowTemplate.Height = 24;
            this.dataGridViewchitietPN.Size = new System.Drawing.Size(859, 286);
            this.dataGridViewchitietPN.TabIndex = 25;
            this.dataGridViewchitietPN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewchitietPN_CellClick);
            // 
            // reportViewer
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PRIN_PHIEU_NHAPBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.ReportPN.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(84, 40);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(999, 503);
            this.reportViewer.TabIndex = 30;
            this.reportViewer.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.Location = new System.Drawing.Point(1041, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 23);
            this.button2.TabIndex = 37;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PRIN_PHIEU_NHAPTableAdapter
            // 
            this.PRIN_PHIEU_NHAPTableAdapter.ClearBeforeFill = true;
            // 
            // chi_tiet_phieu_nhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 555);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.reportViewer);
            this.Controls.Add(this.groupBoxTimKiem);
            this.Controls.Add(this.groupBoxPN);
            this.Controls.Add(this.groupBoxchitietPN);
            this.Controls.Add(this.groupBoxMenu);
            this.Controls.Add(this.dataGridViewchitietPN);
            this.Name = "chi_tiet_phieu_nhap";
            this.Text = "chi_tiet_phieu_nhap";
            this.Load += new System.EventHandler(this.chi_tiet_phieu_nhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PRIN_PHIEU_NHAPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.INHD)).EndInit();
            this.groupBoxTimKiem.ResumeLayout(false);
            this.groupBoxTimKiem.PerformLayout();
            this.groupBoxPN.ResumeLayout(false);
            this.groupBoxPN.PerformLayout();
            this.STK001.ResumeLayout(false);
            this.STK002.ResumeLayout(false);
            this.groupBoxchitietPN.ResumeLayout(false);
            this.groupBoxchitietPN.PerformLayout();
            this.groupBoxMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewchitietPN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxSeach;
        private System.Windows.Forms.Button btnCloseGrSeach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxSelectSeach;
        private System.Windows.Forms.GroupBox groupBoxTimKiem;
        private System.Windows.Forms.Button btnseach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxmancc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNgayNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCloseAction;
        private System.Windows.Forms.TextBox SL;
        private System.Windows.Forms.TextBox textboxMaPN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxPN;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.GroupBox STK001;
        private System.Windows.Forms.Button timkiem;
        private System.Windows.Forms.GroupBox STK002;
        private System.Windows.Forms.GroupBox groupBoxchitietPN;
        private System.Windows.Forms.GroupBox groupBoxMenu;
        private System.Windows.Forms.DataGridView dataGridViewchitietPN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DONGIA;
        private System.Windows.Forms.TextBox MASP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox MCTPNM;
        private System.Windows.Forms.Button btnInPhieu;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource PRIN_PHIEU_NHAPBindingSource;
        private INHD INHD;
        private INHDTableAdapters.PRIN_PHIEU_NHAPTableAdapter PRIN_PHIEU_NHAPTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
    }
}