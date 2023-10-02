
namespace WindowsFormsApp1
{
    partial class chi_tiet
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
            this.dataGridViewchitiet = new System.Windows.Forms.DataGridView();
            this.STK001 = new System.Windows.Forms.GroupBox();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.STK002 = new System.Windows.Forms.GroupBox();
            this.timkiem = new System.Windows.Forms.Button();
            this.groupBoxMenu = new System.Windows.Forms.GroupBox();
            this.groupBoxChitiet = new System.Windows.Forms.GroupBox();
            this.btnCloseAction = new System.Windows.Forms.Button();
            this.TENCT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MACTM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxTimKiem = new System.Windows.Forms.GroupBox();
            this.textBoxSeach = new System.Windows.Forms.TextBox();
            this.btnCloseGrSeach = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSelectSeach = new System.Windows.Forms.ComboBox();
            this.btnseach = new System.Windows.Forms.Button();
            this.btnloadgrid = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewchitiet)).BeginInit();
            this.STK001.SuspendLayout();
            this.STK002.SuspendLayout();
            this.groupBoxMenu.SuspendLayout();
            this.groupBoxChitiet.SuspendLayout();
            this.groupBoxTimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewchitiet
            // 
            this.dataGridViewchitiet.AllowUserToAddRows = false;
            this.dataGridViewchitiet.AllowUserToDeleteRows = false;
            this.dataGridViewchitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewchitiet.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewchitiet.Name = "dataGridViewchitiet";
            this.dataGridViewchitiet.ReadOnly = true;
            this.dataGridViewchitiet.RowHeadersWidth = 51;
            this.dataGridViewchitiet.RowTemplate.Height = 24;
            this.dataGridViewchitiet.Size = new System.Drawing.Size(650, 321);
            this.dataGridViewchitiet.TabIndex = 0;
            this.dataGridViewchitiet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewchitiet_CellClick);
            // 
            // STK001
            // 
            this.STK001.Controls.Add(this.btnxoa);
            this.STK001.Controls.Add(this.btnsua);
            this.STK001.Controls.Add(this.btnthem);
            this.STK001.Location = new System.Drawing.Point(102, 21);
            this.STK001.Name = "STK001";
            this.STK001.Size = new System.Drawing.Size(252, 61);
            this.STK001.TabIndex = 1;
            this.STK001.TabStop = false;
            // 
            // btnxoa
            // 
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
            this.timkiem.Click += new System.EventHandler(this.timkiem_Click);
            // 
            // groupBoxMenu
            // 
            this.groupBoxMenu.Controls.Add(this.STK002);
            this.groupBoxMenu.Controls.Add(this.STK001);
            this.groupBoxMenu.Location = new System.Drawing.Point(540, 332);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Size = new System.Drawing.Size(364, 100);
            this.groupBoxMenu.TabIndex = 3;
            this.groupBoxMenu.TabStop = false;
            // 
            // groupBoxChitiet
            // 
            this.groupBoxChitiet.Controls.Add(this.btnCloseAction);
            this.groupBoxChitiet.Controls.Add(this.TENCT);
            this.groupBoxChitiet.Controls.Add(this.label2);
            this.groupBoxChitiet.Controls.Add(this.MACTM);
            this.groupBoxChitiet.Controls.Add(this.label1);
            this.groupBoxChitiet.Location = new System.Drawing.Point(198, 330);
            this.groupBoxChitiet.Name = "groupBoxChitiet";
            this.groupBoxChitiet.Size = new System.Drawing.Size(291, 108);
            this.groupBoxChitiet.TabIndex = 4;
            this.groupBoxChitiet.TabStop = false;
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
            // TENCT
            // 
            this.TENCT.Location = new System.Drawing.Point(130, 57);
            this.TENCT.Multiline = true;
            this.TENCT.Name = "TENCT";
            this.TENCT.Size = new System.Drawing.Size(122, 45);
            this.TENCT.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "tên chi tiết";
            // 
            // MACTM
            // 
            this.MACTM.Location = new System.Drawing.Point(130, 29);
            this.MACTM.Multiline = true;
            this.MACTM.Name = "MACTM";
            this.MACTM.Size = new System.Drawing.Size(122, 22);
            this.MACTM.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "mã chi tiết";
            // 
            // groupBoxTimKiem
            // 
            this.groupBoxTimKiem.Controls.Add(this.textBoxSeach);
            this.groupBoxTimKiem.Controls.Add(this.btnCloseGrSeach);
            this.groupBoxTimKiem.Controls.Add(this.label3);
            this.groupBoxTimKiem.Controls.Add(this.comboBoxSelectSeach);
            this.groupBoxTimKiem.Controls.Add(this.btnseach);
            this.groupBoxTimKiem.Location = new System.Drawing.Point(664, 65);
            this.groupBoxTimKiem.Name = "groupBoxTimKiem";
            this.groupBoxTimKiem.Size = new System.Drawing.Size(318, 133);
            this.groupBoxTimKiem.TabIndex = 22;
            this.groupBoxTimKiem.TabStop = false;
            this.groupBoxTimKiem.Visible = false;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "tìm kiếm theo";
            // 
            // comboBoxSelectSeach
            // 
            this.comboBoxSelectSeach.FormattingEnabled = true;
            this.comboBoxSelectSeach.Location = new System.Drawing.Point(117, 15);
            this.comboBoxSelectSeach.Name = "comboBoxSelectSeach";
            this.comboBoxSelectSeach.Size = new System.Drawing.Size(192, 24);
            this.comboBoxSelectSeach.TabIndex = 1;
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
            // btnloadgrid
            // 
            this.btnloadgrid.Location = new System.Drawing.Point(796, 229);
            this.btnloadgrid.Name = "btnloadgrid";
            this.btnloadgrid.Size = new System.Drawing.Size(108, 50);
            this.btnloadgrid.TabIndex = 23;
            this.btnloadgrid.Text = "xem toàn bộ ";
            this.btnloadgrid.UseVisualStyleBackColor = true;
            this.btnloadgrid.Visible = false;
            this.btnloadgrid.Click += new System.EventHandler(this.btnloadgrid_Click);
            // 
            // chi_tiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 450);
            this.Controls.Add(this.btnloadgrid);
            this.Controls.Add(this.groupBoxTimKiem);
            this.Controls.Add(this.groupBoxChitiet);
            this.Controls.Add(this.groupBoxMenu);
            this.Controls.Add(this.dataGridViewchitiet);
            this.Name = "chi_tiet";
            this.Text = "chi_tiet";
            this.Load += new System.EventHandler(this.chi_tiet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewchitiet)).EndInit();
            this.STK001.ResumeLayout(false);
            this.STK002.ResumeLayout(false);
            this.groupBoxMenu.ResumeLayout(false);
            this.groupBoxChitiet.ResumeLayout(false);
            this.groupBoxChitiet.PerformLayout();
            this.groupBoxTimKiem.ResumeLayout(false);
            this.groupBoxTimKiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewchitiet;
        private System.Windows.Forms.GroupBox STK001;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.GroupBox STK002;
        private System.Windows.Forms.Button timkiem;
        private System.Windows.Forms.GroupBox groupBoxMenu;
        private System.Windows.Forms.GroupBox groupBoxChitiet;
        private System.Windows.Forms.TextBox TENCT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MACTM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCloseAction;
        private System.Windows.Forms.GroupBox groupBoxTimKiem;
        private System.Windows.Forms.TextBox textBoxSeach;
        private System.Windows.Forms.Button btnCloseGrSeach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxSelectSeach;
        private System.Windows.Forms.Button btnseach;
        private System.Windows.Forms.Button btnloadgrid;
    }
}