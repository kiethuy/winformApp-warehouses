
namespace WindowsFormsApp1
{
    partial class vai_tro
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
            this.btnCloseAction = new System.Windows.Forms.Button();
            this.TENVT = new System.Windows.Forms.TextBox();
            this.groupBoxMenu = new System.Windows.Forms.GroupBox();
            this.STK002 = new System.Windows.Forms.GroupBox();
            this.timkiem = new System.Windows.Forms.Button();
            this.STK001 = new System.Windows.Forms.GroupBox();
            this.chucnang = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.MAVTM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxVT = new System.Windows.Forms.GroupBox();
            this.dataGridViewvaitro = new System.Windows.Forms.DataGridView();
            this.groupBoxMenu.SuspendLayout();
            this.STK002.SuspendLayout();
            this.STK001.SuspendLayout();
            this.groupBoxVT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewvaitro)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCloseAction
            // 
            this.btnCloseAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCloseAction.Location = new System.Drawing.Point(248, 7);
            this.btnCloseAction.Name = "btnCloseAction";
            this.btnCloseAction.Size = new System.Drawing.Size(42, 23);
            this.btnCloseAction.TabIndex = 3;
            this.btnCloseAction.Text = "X";
            this.btnCloseAction.UseVisualStyleBackColor = false;
            this.btnCloseAction.Click += new System.EventHandler(this.btnCloseAction_Click);
            // 
            // TENVT
            // 
            this.TENVT.Location = new System.Drawing.Point(130, 57);
            this.TENVT.Multiline = true;
            this.TENVT.Name = "TENVT";
            this.TENVT.Size = new System.Drawing.Size(122, 45);
            this.TENVT.TabIndex = 2;
            // 
            // groupBoxMenu
            // 
            this.groupBoxMenu.Controls.Add(this.STK002);
            this.groupBoxMenu.Controls.Add(this.STK001);
            this.groupBoxMenu.Location = new System.Drawing.Point(587, 337);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Size = new System.Drawing.Size(477, 100);
            this.groupBoxMenu.TabIndex = 25;
            this.groupBoxMenu.TabStop = false;
            // 
            // STK002
            // 
            this.STK002.Controls.Add(this.timkiem);
            this.STK002.Location = new System.Drawing.Point(17, 21);
            this.STK002.Name = "STK002";
            this.STK002.Size = new System.Drawing.Size(85, 61);
            this.STK002.TabIndex = 2;
            this.STK002.TabStop = false;
            // 
            // timkiem
            // 
            this.timkiem.Location = new System.Drawing.Point(6, 21);
            this.timkiem.Name = "timkiem";
            this.timkiem.Size = new System.Drawing.Size(75, 23);
            this.timkiem.TabIndex = 0;
            this.timkiem.Text = "tìm kiếm";
            this.timkiem.UseVisualStyleBackColor = true;
            // 
            // STK001
            // 
            this.STK001.Controls.Add(this.chucnang);
            this.STK001.Controls.Add(this.btnxoa);
            this.STK001.Controls.Add(this.btnsua);
            this.STK001.Controls.Add(this.btnthem);
            this.STK001.Location = new System.Drawing.Point(102, 21);
            this.STK001.Name = "STK001";
            this.STK001.Size = new System.Drawing.Size(365, 61);
            this.STK001.TabIndex = 1;
            this.STK001.TabStop = false;
            // 
            // chucnang
            // 
            this.chucnang.Enabled = false;
            this.chucnang.Location = new System.Drawing.Point(255, 21);
            this.chucnang.Name = "chucnang";
            this.chucnang.Size = new System.Drawing.Size(98, 23);
            this.chucnang.TabIndex = 3;
            this.chucnang.Text = "chức năng";
            this.chucnang.UseVisualStyleBackColor = true;
            this.chucnang.Click += new System.EventHandler(this.chucnang_Click);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "tên vai trò";
            // 
            // MAVTM
            // 
            this.MAVTM.Location = new System.Drawing.Point(130, 29);
            this.MAVTM.Multiline = true;
            this.MAVTM.Name = "MAVTM";
            this.MAVTM.Size = new System.Drawing.Size(122, 22);
            this.MAVTM.TabIndex = 1;
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
            // groupBoxVT
            // 
            this.groupBoxVT.Controls.Add(this.btnCloseAction);
            this.groupBoxVT.Controls.Add(this.TENVT);
            this.groupBoxVT.Controls.Add(this.label2);
            this.groupBoxVT.Controls.Add(this.MAVTM);
            this.groupBoxVT.Controls.Add(this.label1);
            this.groupBoxVT.Location = new System.Drawing.Point(245, 335);
            this.groupBoxVT.Name = "groupBoxVT";
            this.groupBoxVT.Size = new System.Drawing.Size(291, 108);
            this.groupBoxVT.TabIndex = 26;
            this.groupBoxVT.TabStop = false;
            // 
            // dataGridViewvaitro
            // 
            this.dataGridViewvaitro.AllowUserToAddRows = false;
            this.dataGridViewvaitro.AllowUserToDeleteRows = false;
            this.dataGridViewvaitro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewvaitro.Location = new System.Drawing.Point(50, 8);
            this.dataGridViewvaitro.Name = "dataGridViewvaitro";
            this.dataGridViewvaitro.ReadOnly = true;
            this.dataGridViewvaitro.RowHeadersWidth = 51;
            this.dataGridViewvaitro.RowTemplate.Height = 24;
            this.dataGridViewvaitro.Size = new System.Drawing.Size(650, 321);
            this.dataGridViewvaitro.TabIndex = 24;
            this.dataGridViewvaitro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewvaitro_CellClick);
            // 
            // vai_tro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 473);
            this.Controls.Add(this.groupBoxMenu);
            this.Controls.Add(this.groupBoxVT);
            this.Controls.Add(this.dataGridViewvaitro);
            this.Name = "vai_tro";
            this.Text = "vai_tro";
            this.Load += new System.EventHandler(this.vai_tro_Load);
            this.groupBoxMenu.ResumeLayout(false);
            this.STK002.ResumeLayout(false);
            this.STK001.ResumeLayout(false);
            this.groupBoxVT.ResumeLayout(false);
            this.groupBoxVT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewvaitro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCloseAction;
        private System.Windows.Forms.TextBox TENVT;
        private System.Windows.Forms.GroupBox groupBoxMenu;
        private System.Windows.Forms.GroupBox STK002;
        private System.Windows.Forms.Button timkiem;
        private System.Windows.Forms.GroupBox STK001;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MAVTM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxVT;
        private System.Windows.Forms.DataGridView dataGridViewvaitro;
        private System.Windows.Forms.Button chucnang;
    }
}