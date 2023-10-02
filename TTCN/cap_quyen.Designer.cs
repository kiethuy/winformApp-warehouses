
namespace WindowsFormsApp1
{
    partial class cap_quyen
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
            this.dataGridViewCapquyen = new System.Windows.Forms.DataGridView();
            this.groupBoxMenu = new System.Windows.Forms.GroupBox();
            this.HR001 = new System.Windows.Forms.GroupBox();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.groupBoxND = new System.Windows.Forms.GroupBox();
            this.HOTEN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MANDM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxchitietsp = new System.Windows.Forms.GroupBox();
            this.btnCloseAction = new System.Windows.Forms.Button();
            this.VAITRO = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCapquyen)).BeginInit();
            this.groupBoxMenu.SuspendLayout();
            this.HR001.SuspendLayout();
            this.groupBoxND.SuspendLayout();
            this.groupBoxchitietsp.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewCapquyen
            // 
            this.dataGridViewCapquyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCapquyen.Location = new System.Drawing.Point(22, 12);
            this.dataGridViewCapquyen.Name = "dataGridViewCapquyen";
            this.dataGridViewCapquyen.RowHeadersWidth = 51;
            this.dataGridViewCapquyen.RowTemplate.Height = 24;
            this.dataGridViewCapquyen.Size = new System.Drawing.Size(528, 276);
            this.dataGridViewCapquyen.TabIndex = 0;
            this.dataGridViewCapquyen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCapquyen_CellClick);
            // 
            // groupBoxMenu
            // 
            this.groupBoxMenu.Controls.Add(this.HR001);
            this.groupBoxMenu.Location = new System.Drawing.Point(22, 443);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Size = new System.Drawing.Size(284, 99);
            this.groupBoxMenu.TabIndex = 29;
            this.groupBoxMenu.TabStop = false;
            // 
            // HR001
            // 
            this.HR001.Controls.Add(this.btnxoa);
            this.HR001.Controls.Add(this.btnsua);
            this.HR001.Controls.Add(this.btnthem);
            this.HR001.Location = new System.Drawing.Point(6, 21);
            this.HR001.Name = "HR001";
            this.HR001.Size = new System.Drawing.Size(256, 61);
            this.HR001.TabIndex = 1;
            this.HR001.TabStop = false;
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
            // groupBoxND
            // 
            this.groupBoxND.Controls.Add(this.HOTEN);
            this.groupBoxND.Controls.Add(this.label2);
            this.groupBoxND.Controls.Add(this.MANDM);
            this.groupBoxND.Controls.Add(this.label1);
            this.groupBoxND.Enabled = false;
            this.groupBoxND.Location = new System.Drawing.Point(22, 308);
            this.groupBoxND.Name = "groupBoxND";
            this.groupBoxND.Size = new System.Drawing.Size(249, 129);
            this.groupBoxND.TabIndex = 30;
            this.groupBoxND.TabStop = false;
            // 
            // HOTEN
            // 
            this.HOTEN.Location = new System.Drawing.Point(106, 70);
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
            this.MANDM.Location = new System.Drawing.Point(106, 29);
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
            // groupBoxchitietsp
            // 
            this.groupBoxchitietsp.Controls.Add(this.btnCloseAction);
            this.groupBoxchitietsp.Controls.Add(this.VAITRO);
            this.groupBoxchitietsp.Controls.Add(this.label5);
            this.groupBoxchitietsp.Location = new System.Drawing.Point(277, 308);
            this.groupBoxchitietsp.Name = "groupBoxchitietsp";
            this.groupBoxchitietsp.Size = new System.Drawing.Size(237, 129);
            this.groupBoxchitietsp.TabIndex = 31;
            this.groupBoxchitietsp.TabStop = false;
            // 
            // btnCloseAction
            // 
            this.btnCloseAction.BackColor = System.Drawing.Color.LightCoral;
            this.btnCloseAction.ForeColor = System.Drawing.Color.Red;
            this.btnCloseAction.Location = new System.Drawing.Point(208, 8);
            this.btnCloseAction.Name = "btnCloseAction";
            this.btnCloseAction.Size = new System.Drawing.Size(29, 35);
            this.btnCloseAction.TabIndex = 5;
            this.btnCloseAction.Text = "X";
            this.btnCloseAction.UseVisualStyleBackColor = false;
            // 
            // VAITRO
            // 
            this.VAITRO.FormattingEnabled = true;
            this.VAITRO.Location = new System.Drawing.Point(69, 49);
            this.VAITRO.Name = "VAITRO";
            this.VAITRO.Size = new System.Drawing.Size(136, 24);
            this.VAITRO.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "vai trò";
            // 
            // cap_quyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 609);
            this.Controls.Add(this.groupBoxchitietsp);
            this.Controls.Add(this.groupBoxND);
            this.Controls.Add(this.groupBoxMenu);
            this.Controls.Add(this.dataGridViewCapquyen);
            this.Name = "cap_quyen";
            this.Text = "cap_quyen";
            this.Load += new System.EventHandler(this.cap_quyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCapquyen)).EndInit();
            this.groupBoxMenu.ResumeLayout(false);
            this.HR001.ResumeLayout(false);
            this.groupBoxND.ResumeLayout(false);
            this.groupBoxND.PerformLayout();
            this.groupBoxchitietsp.ResumeLayout(false);
            this.groupBoxchitietsp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCapquyen;
        private System.Windows.Forms.GroupBox groupBoxMenu;
        private System.Windows.Forms.GroupBox HR001;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.GroupBox groupBoxND;
        private System.Windows.Forms.TextBox HOTEN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MANDM;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBoxchitietsp;
        private System.Windows.Forms.Button btnCloseAction;
        private System.Windows.Forms.ComboBox VAITRO;
        private System.Windows.Forms.Label label5;
    }
}