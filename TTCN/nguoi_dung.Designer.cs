
namespace WindowsFormsApp1
{
    partial class nguoi_dung
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
            this.dataGridViewNGUOIDUNG = new System.Windows.Forms.DataGridView();
            this.groupBoxMenu = new System.Windows.Forms.GroupBox();
            this.HR001 = new System.Windows.Forms.GroupBox();
            this.btnvaitro = new System.Windows.Forms.Button();
            this.timkiem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.groupBoxND = new System.Windows.Forms.GroupBox();
            this.MK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCloseAction = new System.Windows.Forms.Button();
            this.HOTEN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MANDM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNGUOIDUNG)).BeginInit();
            this.groupBoxMenu.SuspendLayout();
            this.HR001.SuspendLayout();
            this.groupBoxND.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewNGUOIDUNG
            // 
            this.dataGridViewNGUOIDUNG.AllowUserToAddRows = false;
            this.dataGridViewNGUOIDUNG.AllowUserToDeleteRows = false;
            this.dataGridViewNGUOIDUNG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNGUOIDUNG.Location = new System.Drawing.Point(80, 4);
            this.dataGridViewNGUOIDUNG.Name = "dataGridViewNGUOIDUNG";
            this.dataGridViewNGUOIDUNG.ReadOnly = true;
            this.dataGridViewNGUOIDUNG.RowHeadersWidth = 51;
            this.dataGridViewNGUOIDUNG.RowTemplate.Height = 24;
            this.dataGridViewNGUOIDUNG.Size = new System.Drawing.Size(913, 409);
            this.dataGridViewNGUOIDUNG.TabIndex = 0;
            this.dataGridViewNGUOIDUNG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNGUOIDUNG_CellClick);
            // 
            // groupBoxMenu
            // 
            this.groupBoxMenu.Controls.Add(this.HR001);
            this.groupBoxMenu.Location = new System.Drawing.Point(685, 492);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Size = new System.Drawing.Size(480, 100);
            this.groupBoxMenu.TabIndex = 28;
            this.groupBoxMenu.TabStop = false;
            // 
            // HR001
            // 
            this.HR001.Controls.Add(this.btnvaitro);
            this.HR001.Controls.Add(this.timkiem);
            this.HR001.Controls.Add(this.btnxoa);
            this.HR001.Controls.Add(this.btnsua);
            this.HR001.Controls.Add(this.btnthem);
            this.HR001.Location = new System.Drawing.Point(6, 21);
            this.HR001.Name = "HR001";
            this.HR001.Size = new System.Drawing.Size(453, 61);
            this.HR001.TabIndex = 1;
            this.HR001.TabStop = false;
            // 
            // btnvaitro
            // 
            this.btnvaitro.Enabled = false;
            this.btnvaitro.Location = new System.Drawing.Point(362, 23);
            this.btnvaitro.Name = "btnvaitro";
            this.btnvaitro.Size = new System.Drawing.Size(75, 23);
            this.btnvaitro.TabIndex = 3;
            this.btnvaitro.Text = "vai trò";
            this.btnvaitro.UseVisualStyleBackColor = true;
            this.btnvaitro.Click += new System.EventHandler(this.btnvaitro_Click);
            // 
            // timkiem
            // 
            this.timkiem.Location = new System.Drawing.Point(267, 23);
            this.timkiem.Name = "timkiem";
            this.timkiem.Size = new System.Drawing.Size(75, 23);
            this.timkiem.TabIndex = 0;
            this.timkiem.Text = "tìm kiếm";
            this.timkiem.UseVisualStyleBackColor = true;
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
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click_1);
            // 
            // groupBoxND
            // 
            this.groupBoxND.Controls.Add(this.MK);
            this.groupBoxND.Controls.Add(this.label4);
            this.groupBoxND.Controls.Add(this.btnCloseAction);
            this.groupBoxND.Controls.Add(this.HOTEN);
            this.groupBoxND.Controls.Add(this.label2);
            this.groupBoxND.Controls.Add(this.MANDM);
            this.groupBoxND.Controls.Add(this.label1);
            this.groupBoxND.Location = new System.Drawing.Point(111, 463);
            this.groupBoxND.Name = "groupBoxND";
            this.groupBoxND.Size = new System.Drawing.Size(545, 129);
            this.groupBoxND.TabIndex = 29;
            this.groupBoxND.TabStop = false;
            // 
            // MK
            // 
            this.MK.Location = new System.Drawing.Point(381, 29);
            this.MK.Name = "MK";
            this.MK.Size = new System.Drawing.Size(160, 22);
            this.MK.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "mật khẩu";
            // 
            // btnCloseAction
            // 
            this.btnCloseAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCloseAction.Location = new System.Drawing.Point(493, 0);
            this.btnCloseAction.Name = "btnCloseAction";
            this.btnCloseAction.Size = new System.Drawing.Size(42, 23);
            this.btnCloseAction.TabIndex = 3;
            this.btnCloseAction.Text = "X";
            this.btnCloseAction.UseVisualStyleBackColor = false;
            this.btnCloseAction.Click += new System.EventHandler(this.btnCloseAction_Click);
            // 
            // HOTEN
            // 
            this.HOTEN.Location = new System.Drawing.Point(146, 70);
            this.HOTEN.Multiline = true;
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Size = new System.Drawing.Size(122, 30);
            this.HOTEN.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "họ tên";
            // 
            // MANDM
            // 
            this.MANDM.Location = new System.Drawing.Point(146, 29);
            this.MANDM.Multiline = true;
            this.MANDM.Name = "MANDM";
            this.MANDM.Size = new System.Drawing.Size(122, 22);
            this.MANDM.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "mã nhân viên";
            // 
            // nguoi_dung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 717);
            this.Controls.Add(this.groupBoxMenu);
            this.Controls.Add(this.groupBoxND);
            this.Controls.Add(this.dataGridViewNGUOIDUNG);
            this.Name = "nguoi_dung";
            this.Text = "nguoi_dung";
            this.Load += new System.EventHandler(this.nguoi_dung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNGUOIDUNG)).EndInit();
            this.groupBoxMenu.ResumeLayout(false);
            this.HR001.ResumeLayout(false);
            this.groupBoxND.ResumeLayout(false);
            this.groupBoxND.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewNGUOIDUNG;
        private System.Windows.Forms.GroupBox groupBoxMenu;
        private System.Windows.Forms.GroupBox HR001;
        private System.Windows.Forms.Button timkiem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.GroupBox groupBoxND;
        private System.Windows.Forms.TextBox MK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCloseAction;
        private System.Windows.Forms.TextBox HOTEN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MANDM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnvaitro;
    }
}