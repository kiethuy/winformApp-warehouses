
namespace WindowsFormsApp1
{
    partial class vai_tro_chuc_nang
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
            this.groupBoxMenu = new System.Windows.Forms.GroupBox();
            this.DIR001 = new System.Windows.Forms.GroupBox();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.dataGridViewVTCN = new System.Windows.Forms.DataGridView();
            this.groupBoxND = new System.Windows.Forms.GroupBox();
            this.TENVAITRO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MAVT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxchitietsp = new System.Windows.Forms.GroupBox();
            this.btnCloseAction = new System.Windows.Forms.Button();
            this.CHUCNANG = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxMenu.SuspendLayout();
            this.DIR001.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVTCN)).BeginInit();
            this.groupBoxND.SuspendLayout();
            this.groupBoxchitietsp.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMenu
            // 
            this.groupBoxMenu.Controls.Add(this.DIR001);
            this.groupBoxMenu.Location = new System.Drawing.Point(98, 538);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Size = new System.Drawing.Size(299, 99);
            this.groupBoxMenu.TabIndex = 33;
            this.groupBoxMenu.TabStop = false;
            // 
            // DIR001
            // 
            this.DIR001.Controls.Add(this.btnxoa);
            this.DIR001.Controls.Add(this.btnsua);
            this.DIR001.Controls.Add(this.btnthem);
            this.DIR001.Location = new System.Drawing.Point(6, 21);
            this.DIR001.Name = "DIR001";
            this.DIR001.Size = new System.Drawing.Size(267, 61);
            this.DIR001.TabIndex = 1;
            this.DIR001.TabStop = false;
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
            // dataGridViewVTCN
            // 
            this.dataGridViewVTCN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVTCN.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewVTCN.Name = "dataGridViewVTCN";
            this.dataGridViewVTCN.RowHeadersWidth = 51;
            this.dataGridViewVTCN.RowTemplate.Height = 24;
            this.dataGridViewVTCN.Size = new System.Drawing.Size(1093, 375);
            this.dataGridViewVTCN.TabIndex = 32;
            this.dataGridViewVTCN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVTCN_CellClick);
            // 
            // groupBoxND
            // 
            this.groupBoxND.Controls.Add(this.TENVAITRO);
            this.groupBoxND.Controls.Add(this.label2);
            this.groupBoxND.Controls.Add(this.MAVT);
            this.groupBoxND.Controls.Add(this.label1);
            this.groupBoxND.Enabled = false;
            this.groupBoxND.Location = new System.Drawing.Point(98, 403);
            this.groupBoxND.Name = "groupBoxND";
            this.groupBoxND.Size = new System.Drawing.Size(305, 129);
            this.groupBoxND.TabIndex = 34;
            this.groupBoxND.TabStop = false;
            // 
            // TENVAITRO
            // 
            this.TENVAITRO.Location = new System.Drawing.Point(93, 70);
            this.TENVAITRO.Multiline = true;
            this.TENVAITRO.Name = "TENVAITRO";
            this.TENVAITRO.Size = new System.Drawing.Size(206, 53);
            this.TENVAITRO.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "tên vai trò";
            // 
            // MAVT
            // 
            this.MAVT.Location = new System.Drawing.Point(106, 29);
            this.MAVT.Multiline = true;
            this.MAVT.Name = "MAVT";
            this.MAVT.Size = new System.Drawing.Size(122, 22);
            this.MAVT.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "mã vai trò";
            // 
            // groupBoxchitietsp
            // 
            this.groupBoxchitietsp.Controls.Add(this.btnCloseAction);
            this.groupBoxchitietsp.Controls.Add(this.CHUCNANG);
            this.groupBoxchitietsp.Controls.Add(this.label5);
            this.groupBoxchitietsp.Location = new System.Drawing.Point(409, 412);
            this.groupBoxchitietsp.Name = "groupBoxchitietsp";
            this.groupBoxchitietsp.Size = new System.Drawing.Size(354, 120);
            this.groupBoxchitietsp.TabIndex = 35;
            this.groupBoxchitietsp.TabStop = false;
            // 
            // btnCloseAction
            // 
            this.btnCloseAction.BackColor = System.Drawing.Color.LightCoral;
            this.btnCloseAction.ForeColor = System.Drawing.Color.Red;
            this.btnCloseAction.Location = new System.Drawing.Point(327, -9);
            this.btnCloseAction.Name = "btnCloseAction";
            this.btnCloseAction.Size = new System.Drawing.Size(29, 35);
            this.btnCloseAction.TabIndex = 5;
            this.btnCloseAction.Text = "X";
            this.btnCloseAction.UseVisualStyleBackColor = false;
            this.btnCloseAction.Click += new System.EventHandler(this.btnCloseAction_Click);
            // 
            // CHUCNANG
            // 
            this.CHUCNANG.FormattingEnabled = true;
            this.CHUCNANG.Location = new System.Drawing.Point(134, 15);
            this.CHUCNANG.Name = "CHUCNANG";
            this.CHUCNANG.Size = new System.Drawing.Size(187, 24);
            this.CHUCNANG.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "chức năng";
            // 
            // vai_tro_chuc_nang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 648);
            this.Controls.Add(this.groupBoxMenu);
            this.Controls.Add(this.dataGridViewVTCN);
            this.Controls.Add(this.groupBoxND);
            this.Controls.Add(this.groupBoxchitietsp);
            this.Name = "vai_tro_chuc_nang";
            this.Text = "vai_tro_chuc_nang";
            this.Load += new System.EventHandler(this.vai_tro_chuc_nang_Load);
            this.groupBoxMenu.ResumeLayout(false);
            this.DIR001.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVTCN)).EndInit();
            this.groupBoxND.ResumeLayout(false);
            this.groupBoxND.PerformLayout();
            this.groupBoxchitietsp.ResumeLayout(false);
            this.groupBoxchitietsp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMenu;
        private System.Windows.Forms.GroupBox DIR001;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DataGridView dataGridViewVTCN;
        private System.Windows.Forms.GroupBox groupBoxND;
        private System.Windows.Forms.TextBox TENVAITRO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MAVT;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBoxchitietsp;
        private System.Windows.Forms.Button btnCloseAction;
        private System.Windows.Forms.ComboBox CHUCNANG;
        private System.Windows.Forms.Label label5;
    }
}