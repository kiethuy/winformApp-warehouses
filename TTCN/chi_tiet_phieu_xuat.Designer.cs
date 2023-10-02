
namespace WindowsFormsApp1
{
    partial class chi_tiet_phieu_xuat
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.PRINT_PHIEU_XUATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.INHD = new WindowsFormsApp1.INHD();
            this.STK003 = new System.Windows.Forms.GroupBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.them = new System.Windows.Forms.Button();
            this.groupBoxMenu = new System.Windows.Forms.GroupBox();
            this.STK006 = new System.Windows.Forms.GroupBox();
            this.btnInPhieu = new System.Windows.Forms.Button();
            this.dataGridViewCTPHIEUXUAT = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxPX = new System.Windows.Forms.GroupBox();
            this.textBoxMANVKD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMANVK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textboxMaPX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxchitietPN = new System.Windows.Forms.GroupBox();
            this.MASPM = new System.Windows.Forms.TextBox();
            this.btnCloseAction = new System.Windows.Forms.Button();
            this.SL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnclose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PRINT_PHIEU_XUATBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.INHD)).BeginInit();
            this.STK003.SuspendLayout();
            this.groupBoxMenu.SuspendLayout();
            this.STK006.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCTPHIEUXUAT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBoxPX.SuspendLayout();
            this.groupBoxchitietPN.SuspendLayout();
            this.SuspendLayout();
            // 
            // PRINT_PHIEU_XUATBindingSource
            // 
            this.PRINT_PHIEU_XUATBindingSource.DataMember = "PRINT_PHIEU_XUAT";
            this.PRINT_PHIEU_XUATBindingSource.DataSource = this.INHD;
            // 
            // INHD
            // 
            this.INHD.DataSetName = "INHD";
            this.INHD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // STK003
            // 
            this.STK003.Controls.Add(this.btnSua);
            this.STK003.Controls.Add(this.btnxoa);
            this.STK003.Controls.Add(this.them);
            this.STK003.Location = new System.Drawing.Point(228, 12);
            this.STK003.Name = "STK003";
            this.STK003.Size = new System.Drawing.Size(258, 51);
            this.STK003.TabIndex = 6;
            this.STK003.TabStop = false;
            // 
            // btnSua
            // 
            this.btnSua.Enabled = false;
            this.btnSua.Location = new System.Drawing.Point(6, 17);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(83, 31);
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
            this.groupBoxMenu.Location = new System.Drawing.Point(728, 497);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Size = new System.Drawing.Size(521, 69);
            this.groupBoxMenu.TabIndex = 35;
            this.groupBoxMenu.TabStop = false;
            // 
            // STK006
            // 
            this.STK006.Controls.Add(this.btnInPhieu);
            this.STK006.Location = new System.Drawing.Point(31, 13);
            this.STK006.Name = "STK006";
            this.STK006.Size = new System.Drawing.Size(113, 50);
            this.STK006.TabIndex = 7;
            this.STK006.TabStop = false;
            // 
            // btnInPhieu
            // 
            this.btnInPhieu.Location = new System.Drawing.Point(18, 11);
            this.btnInPhieu.Name = "btnInPhieu";
            this.btnInPhieu.Size = new System.Drawing.Size(82, 33);
            this.btnInPhieu.TabIndex = 6;
            this.btnInPhieu.Text = "in phiếu";
            this.btnInPhieu.UseVisualStyleBackColor = true;
            this.btnInPhieu.Click += new System.EventHandler(this.btnInPhieu_Click);
            // 
            // dataGridViewCTPHIEUXUAT
            // 
            this.dataGridViewCTPHIEUXUAT.AllowUserToAddRows = false;
            this.dataGridViewCTPHIEUXUAT.AllowUserToDeleteRows = false;
            this.dataGridViewCTPHIEUXUAT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewCTPHIEUXUAT.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewCTPHIEUXUAT.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewCTPHIEUXUAT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCTPHIEUXUAT.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCTPHIEUXUAT.Location = new System.Drawing.Point(12, 10);
            this.dataGridViewCTPHIEUXUAT.Name = "dataGridViewCTPHIEUXUAT";
            this.dataGridViewCTPHIEUXUAT.ReadOnly = true;
            this.dataGridViewCTPHIEUXUAT.RowHeadersWidth = 51;
            this.dataGridViewCTPHIEUXUAT.RowTemplate.Height = 24;
            this.dataGridViewCTPHIEUXUAT.Size = new System.Drawing.Size(654, 382);
            this.dataGridViewCTPHIEUXUAT.TabIndex = 33;
            this.dataGridViewCTPHIEUXUAT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCTPHIEUXUAT_CellClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBoxPX
            // 
            this.groupBoxPX.Controls.Add(this.textBoxMANVKD);
            this.groupBoxPX.Controls.Add(this.label4);
            this.groupBoxPX.Controls.Add(this.textBoxMANVK);
            this.groupBoxPX.Controls.Add(this.label3);
            this.groupBoxPX.Controls.Add(this.textBoxNX);
            this.groupBoxPX.Controls.Add(this.label2);
            this.groupBoxPX.Controls.Add(this.textboxMaPX);
            this.groupBoxPX.Controls.Add(this.label1);
            this.groupBoxPX.Enabled = false;
            this.groupBoxPX.Location = new System.Drawing.Point(24, 426);
            this.groupBoxPX.Name = "groupBoxPX";
            this.groupBoxPX.Size = new System.Drawing.Size(363, 183);
            this.groupBoxPX.TabIndex = 37;
            this.groupBoxPX.TabStop = false;
            // 
            // textBoxMANVKD
            // 
            this.textBoxMANVKD.Enabled = false;
            this.textBoxMANVKD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textBoxMANVKD.Location = new System.Drawing.Point(154, 150);
            this.textBoxMANVKD.Name = "textBoxMANVKD";
            this.textBoxMANVKD.Size = new System.Drawing.Size(181, 22);
            this.textBoxMANVKD.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "người nhận";
            // 
            // textBoxMANVK
            // 
            this.textBoxMANVK.Enabled = false;
            this.textBoxMANVK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textBoxMANVK.Location = new System.Drawing.Point(154, 114);
            this.textBoxMANVK.Name = "textBoxMANVK";
            this.textBoxMANVK.Size = new System.Drawing.Size(181, 22);
            this.textBoxMANVK.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "người lập";
            // 
            // textBoxNX
            // 
            this.textBoxNX.Enabled = false;
            this.textBoxNX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textBoxNX.Location = new System.Drawing.Point(154, 68);
            this.textBoxNX.Multiline = true;
            this.textBoxNX.Name = "textBoxNX";
            this.textBoxNX.Size = new System.Drawing.Size(181, 26);
            this.textBoxNX.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "ngày xuất";
            // 
            // textboxMaPX
            // 
            this.textboxMaPX.Enabled = false;
            this.textboxMaPX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textboxMaPX.Location = new System.Drawing.Point(154, 21);
            this.textboxMaPX.Name = "textboxMaPX";
            this.textboxMaPX.Size = new System.Drawing.Size(181, 22);
            this.textboxMaPX.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "mã phiếu xuất";
            // 
            // groupBoxchitietPN
            // 
            this.groupBoxchitietPN.Controls.Add(this.MASPM);
            this.groupBoxchitietPN.Controls.Add(this.btnCloseAction);
            this.groupBoxchitietPN.Controls.Add(this.SL);
            this.groupBoxchitietPN.Controls.Add(this.label5);
            this.groupBoxchitietPN.Controls.Add(this.label6);
            this.groupBoxchitietPN.Location = new System.Drawing.Point(393, 426);
            this.groupBoxchitietPN.Name = "groupBoxchitietPN";
            this.groupBoxchitietPN.Size = new System.Drawing.Size(282, 183);
            this.groupBoxchitietPN.TabIndex = 38;
            this.groupBoxchitietPN.TabStop = false;
            // 
            // MASPM
            // 
            this.MASPM.Location = new System.Drawing.Point(110, 37);
            this.MASPM.Name = "MASPM";
            this.MASPM.Size = new System.Drawing.Size(121, 22);
            this.MASPM.TabIndex = 6;
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
            this.SL.Location = new System.Drawing.Point(110, 77);
            this.SL.Name = "SL";
            this.SL.Size = new System.Drawing.Size(121, 22);
            this.SL.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "số lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "mã sản phẩm";
            // 
            // reportViewer
            // 
            this.reportViewer.DocumentMapWidth = 42;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PRINT_PHIEU_XUATBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.ReportPX.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(106, 44);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(1002, 622);
            this.reportViewer.TabIndex = 39;
            this.reportViewer.Visible = false;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnclose.Location = new System.Drawing.Point(1066, 24);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(42, 23);
            this.btnclose.TabIndex = 37;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Visible = false;
            this.btnclose.Click += new System.EventHandler(this.button2_Click);
            // 
            // chi_tiet_phieu_xuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 747);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.reportViewer);
            this.Controls.Add(this.groupBoxchitietPN);
            this.Controls.Add(this.groupBoxPX);
            this.Controls.Add(this.groupBoxMenu);
            this.Controls.Add(this.dataGridViewCTPHIEUXUAT);
            this.Name = "chi_tiet_phieu_xuat";
            this.Text = "chi_tiet_phieu_xuat";
            this.Load += new System.EventHandler(this.chi_tiet_phieu_xuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PRINT_PHIEU_XUATBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.INHD)).EndInit();
            this.STK003.ResumeLayout(false);
            this.groupBoxMenu.ResumeLayout(false);
            this.STK006.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCTPHIEUXUAT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBoxPX.ResumeLayout(false);
            this.groupBoxPX.PerformLayout();
            this.groupBoxchitietPN.ResumeLayout(false);
            this.groupBoxchitietPN.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox STK003;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.GroupBox groupBoxMenu;
        private System.Windows.Forms.GroupBox STK006;
        private System.Windows.Forms.DataGridView dataGridViewCTPHIEUXUAT;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBoxPX;
        private System.Windows.Forms.TextBox textBoxMANVKD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMANVK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textboxMaPX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxchitietPN;
        private System.Windows.Forms.TextBox MASPM;
        private System.Windows.Forms.Button btnCloseAction;
        private System.Windows.Forms.TextBox SL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnInPhieu;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.BindingSource PRINT_PHIEU_XUATBindingSource;
        private INHD INHD;
        private System.Windows.Forms.Button btnclose;
    }
}