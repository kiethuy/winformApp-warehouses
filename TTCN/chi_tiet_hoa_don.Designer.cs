
namespace WindowsFormsApp1
{
    partial class chi_tiet_hoa_don
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
            this.select_HDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnsua = new System.Windows.Forms.Button();
            this.ACC001 = new System.Windows.Forms.GroupBox();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btninHD = new System.Windows.Forms.Button();
            this.groupBoxCTHD = new System.Windows.Forms.GroupBox();
            this.TONG = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MASPM = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DONGIA = new System.Windows.Forms.TextBox();
            this.btnCloseAction = new System.Windows.Forms.Button();
            this.SL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MAKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TIME = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MAHD = new System.Windows.Forms.TextBox();
            this.dataGridViewchitietHD = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxHD = new System.Windows.Forms.GroupBox();
            this.MANVKT = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TONGTIEN = new System.Windows.Forms.TextBox();
            this.MANVKD = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBoxMenu = new System.Windows.Forms.GroupBox();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button2 = new System.Windows.Forms.Button();
            this.INHD = new WindowsFormsApp1.INHD();
            this.select_HDTableAdapter = new WindowsFormsApp1.INHDTableAdapters.select_HDTableAdapter();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.select_HDBindingSource)).BeginInit();
            this.ACC001.SuspendLayout();
            this.groupBoxCTHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewchitietHD)).BeginInit();
            this.groupBoxHD.SuspendLayout();
            this.groupBoxMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.INHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // select_HDBindingSource
            // 
            this.select_HDBindingSource.DataMember = "select_HD";
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
            // ACC001
            // 
            this.ACC001.Controls.Add(this.btninHD);
            this.ACC001.Controls.Add(this.btnxoa);
            this.ACC001.Controls.Add(this.btnsua);
            this.ACC001.Controls.Add(this.btnthem);
            this.ACC001.Location = new System.Drawing.Point(19, 21);
            this.ACC001.Name = "ACC001";
            this.ACC001.Size = new System.Drawing.Size(372, 61);
            this.ACC001.TabIndex = 1;
            this.ACC001.TabStop = false;
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
            // btninHD
            // 
            this.btninHD.Location = new System.Drawing.Point(265, 21);
            this.btninHD.Name = "btninHD";
            this.btninHD.Size = new System.Drawing.Size(88, 23);
            this.btninHD.TabIndex = 3;
            this.btninHD.Text = "in hóa đơn";
            this.btninHD.UseVisualStyleBackColor = true;
            this.btninHD.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBoxCTHD
            // 
            this.groupBoxCTHD.Controls.Add(this.TONG);
            this.groupBoxCTHD.Controls.Add(this.label6);
            this.groupBoxCTHD.Controls.Add(this.MASPM);
            this.groupBoxCTHD.Controls.Add(this.label5);
            this.groupBoxCTHD.Controls.Add(this.label7);
            this.groupBoxCTHD.Controls.Add(this.DONGIA);
            this.groupBoxCTHD.Controls.Add(this.btnCloseAction);
            this.groupBoxCTHD.Controls.Add(this.SL);
            this.groupBoxCTHD.Controls.Add(this.label4);
            this.groupBoxCTHD.Location = new System.Drawing.Point(525, 316);
            this.groupBoxCTHD.Name = "groupBoxCTHD";
            this.groupBoxCTHD.Size = new System.Drawing.Size(282, 232);
            this.groupBoxCTHD.TabIndex = 33;
            this.groupBoxCTHD.TabStop = false;
            // 
            // TONG
            // 
            this.TONG.Enabled = false;
            this.TONG.Location = new System.Drawing.Point(108, 148);
            this.TONG.Name = "TONG";
            this.TONG.Size = new System.Drawing.Size(121, 22);
            this.TONG.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "tổng";
            // 
            // MASPM
            // 
            this.MASPM.Location = new System.Drawing.Point(108, 35);
            this.MASPM.Name = "MASPM";
            this.MASPM.Size = new System.Drawing.Size(121, 22);
            this.MASPM.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "mã sản phẩm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "giá bán";
            // 
            // DONGIA
            // 
            this.DONGIA.Location = new System.Drawing.Point(108, 111);
            this.DONGIA.Name = "DONGIA";
            this.DONGIA.Size = new System.Drawing.Size(121, 22);
            this.DONGIA.TabIndex = 14;
            this.DONGIA.TextChanged += new System.EventHandler(this.DONGIA_TextChanged);
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
            this.SL.Location = new System.Drawing.Point(108, 65);
            this.SL.Name = "SL";
            this.SL.Size = new System.Drawing.Size(121, 22);
            this.SL.TabIndex = 13;
            this.SL.TextChanged += new System.EventHandler(this.SL_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "số lượng";
            // 
            // MAKH
            // 
            this.MAKH.Enabled = false;
            this.MAKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.MAKH.Location = new System.Drawing.Point(195, 104);
            this.MAKH.Name = "MAKH";
            this.MAKH.Size = new System.Drawing.Size(181, 22);
            this.MAKH.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "mã khách hàng";
            // 
            // TIME
            // 
            this.TIME.Enabled = false;
            this.TIME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.TIME.Location = new System.Drawing.Point(195, 57);
            this.TIME.Multiline = true;
            this.TIME.Name = "TIME";
            this.TIME.Size = new System.Drawing.Size(181, 23);
            this.TIME.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "ngày lập";
            // 
            // MAHD
            // 
            this.MAHD.Enabled = false;
            this.MAHD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.MAHD.Location = new System.Drawing.Point(195, 13);
            this.MAHD.Name = "MAHD";
            this.MAHD.Size = new System.Drawing.Size(181, 22);
            this.MAHD.TabIndex = 2;
            // 
            // dataGridViewchitietHD
            // 
            this.dataGridViewchitietHD.AllowUserToAddRows = false;
            this.dataGridViewchitietHD.AllowUserToDeleteRows = false;
            this.dataGridViewchitietHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewchitietHD.Location = new System.Drawing.Point(-1, 12);
            this.dataGridViewchitietHD.Name = "dataGridViewchitietHD";
            this.dataGridViewchitietHD.ReadOnly = true;
            this.dataGridViewchitietHD.RowHeadersWidth = 51;
            this.dataGridViewchitietHD.RowTemplate.Height = 24;
            this.dataGridViewchitietHD.Size = new System.Drawing.Size(875, 286);
            this.dataGridViewchitietHD.TabIndex = 30;
            this.dataGridViewchitietHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewchitietHD_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "mã hóa đơn";
            // 
            // groupBoxHD
            // 
            this.groupBoxHD.Controls.Add(this.MANVKT);
            this.groupBoxHD.Controls.Add(this.label10);
            this.groupBoxHD.Controls.Add(this.TONGTIEN);
            this.groupBoxHD.Controls.Add(this.MANVKD);
            this.groupBoxHD.Controls.Add(this.label11);
            this.groupBoxHD.Controls.Add(this.label9);
            this.groupBoxHD.Controls.Add(this.MAKH);
            this.groupBoxHD.Controls.Add(this.label3);
            this.groupBoxHD.Controls.Add(this.TIME);
            this.groupBoxHD.Controls.Add(this.label2);
            this.groupBoxHD.Controls.Add(this.MAHD);
            this.groupBoxHD.Controls.Add(this.label1);
            this.groupBoxHD.Enabled = false;
            this.groupBoxHD.Location = new System.Drawing.Point(8, 316);
            this.groupBoxHD.Name = "groupBoxHD";
            this.groupBoxHD.Size = new System.Drawing.Size(517, 232);
            this.groupBoxHD.TabIndex = 32;
            this.groupBoxHD.TabStop = false;
            // 
            // MANVKT
            // 
            this.MANVKT.Enabled = false;
            this.MANVKT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.MANVKT.Location = new System.Drawing.Point(195, 179);
            this.MANVKT.Name = "MANVKT";
            this.MANVKT.Size = new System.Drawing.Size(181, 22);
            this.MANVKT.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "mã nhân viên kế toán";
            // 
            // TONGTIEN
            // 
            this.TONGTIEN.Enabled = false;
            this.TONGTIEN.Location = new System.Drawing.Point(393, 49);
            this.TONGTIEN.Name = "TONGTIEN";
            this.TONGTIEN.Size = new System.Drawing.Size(115, 22);
            this.TONGTIEN.TabIndex = 11;
            this.TONGTIEN.UseWaitCursor = true;
            // 
            // MANVKD
            // 
            this.MANVKD.Enabled = false;
            this.MANVKD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.MANVKD.Location = new System.Drawing.Point(195, 148);
            this.MANVKD.Name = "MANVKD";
            this.MANVKD.Size = new System.Drawing.Size(181, 22);
            this.MANVKD.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(418, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "tổng tiền";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "mã nhân viên kinh doanh";
            // 
            // groupBoxMenu
            // 
            this.groupBoxMenu.Controls.Add(this.ACC001);
            this.groupBoxMenu.Location = new System.Drawing.Point(813, 365);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Size = new System.Drawing.Size(502, 100);
            this.groupBoxMenu.TabIndex = 31;
            this.groupBoxMenu.TabStop = false;
            // 
            // reportViewer
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.select_HDBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.ReportHD.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(95, 12);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(1160, 595);
            this.reportViewer.TabIndex = 35;
            this.reportViewer.Visible = false;
            this.reportViewer.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.Location = new System.Drawing.Point(1213, -3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 23);
            this.button2.TabIndex = 36;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // INHD
            // 
            this.INHD.DataSetName = "INHD";
            this.INHD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // select_HDTableAdapter
            // 
            this.select_HDTableAdapter.ClearBeforeFill = true;
            // 
            // chi_tiet_hoa_don
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 612);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.reportViewer);
            this.Controls.Add(this.groupBoxCTHD);
            this.Controls.Add(this.dataGridViewchitietHD);
            this.Controls.Add(this.groupBoxHD);
            this.Controls.Add(this.groupBoxMenu);
            this.Name = "chi_tiet_hoa_don";
            this.Text = "CHI_TIET_HOA_DONcs";
            this.Load += new System.EventHandler(this.chi_tiet_hoa_don_Load);
            ((System.ComponentModel.ISupportInitialize)(this.select_HDBindingSource)).EndInit();
            this.ACC001.ResumeLayout(false);
            this.groupBoxCTHD.ResumeLayout(false);
            this.groupBoxCTHD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewchitietHD)).EndInit();
            this.groupBoxHD.ResumeLayout(false);
            this.groupBoxHD.PerformLayout();
            this.groupBoxMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.INHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.GroupBox ACC001;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.GroupBox groupBoxCTHD;
        private System.Windows.Forms.TextBox TONGTIEN;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DONGIA;
        private System.Windows.Forms.Button btnCloseAction;
        private System.Windows.Forms.TextBox SL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MAKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TIME;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MAHD;
        private System.Windows.Forms.DataGridView dataGridViewchitietHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxHD;
        private System.Windows.Forms.TextBox MANVKT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox MANVKD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBoxMenu;
        private System.Windows.Forms.TextBox MASPM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TONG;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btninHD;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private System.Windows.Forms.BindingSource select_HDBindingSource;
        private INHD INHD;
        private INHDTableAdapters.select_HDTableAdapter select_HDTableAdapter;
        private System.Windows.Forms.Button button2;
    }  
}