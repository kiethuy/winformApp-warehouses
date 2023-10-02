
namespace WindowsFormsApp1
{
    partial class khach_hang
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
            this.textBoxSeach = new System.Windows.Forms.TextBox();
            this.btnCloseGrSeach = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnseach = new System.Windows.Forms.Button();
            this.btnloadgrid = new System.Windows.Forms.Button();
            this.groupBoxTimKiem = new System.Windows.Forms.GroupBox();
            this.comboBoxSelectSeach = new System.Windows.Forms.ComboBox();
            this.dataGridViewKh = new System.Windows.Forms.DataGridView();
            this.BUS001 = new System.Windows.Forms.GroupBox();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.BUS002 = new System.Windows.Forms.GroupBox();
            this.timkiem = new System.Windows.Forms.Button();
            this.groupBoxMenu = new System.Windows.Forms.GroupBox();
            this.btnCloseAction = new System.Windows.Forms.Button();
            this.TENKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MAKHM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxChitiet = new System.Windows.Forms.GroupBox();
            this.DIACHI = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SDT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKh)).BeginInit();
            this.BUS001.SuspendLayout();
            this.BUS002.SuspendLayout();
            this.groupBoxMenu.SuspendLayout();
            this.groupBoxChitiet.SuspendLayout();
            this.SuspendLayout();
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
            this.btnloadgrid.Location = new System.Drawing.Point(958, 198);
            this.btnloadgrid.Name = "btnloadgrid";
            this.btnloadgrid.Size = new System.Drawing.Size(108, 50);
            this.btnloadgrid.TabIndex = 30;
            this.btnloadgrid.Text = "xem toàn bộ ";
            this.btnloadgrid.UseVisualStyleBackColor = true;
            this.btnloadgrid.Visible = false;
            this.btnloadgrid.Click += new System.EventHandler(this.btnloadgrid_Click);
            // 
            // groupBoxTimKiem
            // 
            this.groupBoxTimKiem.Controls.Add(this.textBoxSeach);
            this.groupBoxTimKiem.Controls.Add(this.btnCloseGrSeach);
            this.groupBoxTimKiem.Controls.Add(this.label3);
            this.groupBoxTimKiem.Controls.Add(this.comboBoxSelectSeach);
            this.groupBoxTimKiem.Controls.Add(this.btnseach);
            this.groupBoxTimKiem.Location = new System.Drawing.Point(952, 28);
            this.groupBoxTimKiem.Name = "groupBoxTimKiem";
            this.groupBoxTimKiem.Size = new System.Drawing.Size(318, 133);
            this.groupBoxTimKiem.TabIndex = 29;
            this.groupBoxTimKiem.TabStop = false;
            this.groupBoxTimKiem.Visible = false;
            // 
            // comboBoxSelectSeach
            // 
            this.comboBoxSelectSeach.FormattingEnabled = true;
            this.comboBoxSelectSeach.Location = new System.Drawing.Point(117, 15);
            this.comboBoxSelectSeach.Name = "comboBoxSelectSeach";
            this.comboBoxSelectSeach.Size = new System.Drawing.Size(192, 24);
            this.comboBoxSelectSeach.TabIndex = 1;
            // 
            // dataGridViewKh
            // 
            this.dataGridViewKh.AllowUserToAddRows = false;
            this.dataGridViewKh.AllowUserToDeleteRows = false;
            this.dataGridViewKh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKh.Location = new System.Drawing.Point(6, 8);
            this.dataGridViewKh.MultiSelect = false;
            this.dataGridViewKh.Name = "dataGridViewKh";
            this.dataGridViewKh.ReadOnly = true;
            this.dataGridViewKh.RowHeadersWidth = 51;
            this.dataGridViewKh.RowTemplate.Height = 24;
            this.dataGridViewKh.Size = new System.Drawing.Size(946, 367);
            this.dataGridViewKh.TabIndex = 28;
            this.dataGridViewKh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKh_CellClick);
            // 
            // BUS001
            // 
            this.BUS001.Controls.Add(this.btnxoa);
            this.BUS001.Controls.Add(this.btnsua);
            this.BUS001.Controls.Add(this.btnthem);
            this.BUS001.Location = new System.Drawing.Point(102, 21);
            this.BUS001.Name = "BUS001";
            this.BUS001.Size = new System.Drawing.Size(252, 61);
            this.BUS001.TabIndex = 1;
            this.BUS001.TabStop = false;
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
            // BUS002
            // 
            this.BUS002.Controls.Add(this.timkiem);
            this.BUS002.Location = new System.Drawing.Point(17, 21);
            this.BUS002.Name = "BUS002";
            this.BUS002.Size = new System.Drawing.Size(85, 61);
            this.BUS002.TabIndex = 2;
            this.BUS002.TabStop = false;
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
            this.groupBoxMenu.Controls.Add(this.BUS002);
            this.groupBoxMenu.Controls.Add(this.BUS001);
            this.groupBoxMenu.Location = new System.Drawing.Point(568, 381);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Size = new System.Drawing.Size(364, 100);
            this.groupBoxMenu.TabIndex = 26;
            this.groupBoxMenu.TabStop = false;
            // 
            // btnCloseAction
            // 
            this.btnCloseAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCloseAction.Location = new System.Drawing.Point(472, 9);
            this.btnCloseAction.Name = "btnCloseAction";
            this.btnCloseAction.Size = new System.Drawing.Size(42, 23);
            this.btnCloseAction.TabIndex = 3;
            this.btnCloseAction.Text = "X";
            this.btnCloseAction.UseVisualStyleBackColor = false;
            this.btnCloseAction.Click += new System.EventHandler(this.btnCloseAction_Click);
            // 
            // TENKH
            // 
            this.TENKH.Location = new System.Drawing.Point(146, 70);
            this.TENKH.Multiline = true;
            this.TENKH.Name = "TENKH";
            this.TENKH.Size = new System.Drawing.Size(122, 30);
            this.TENKH.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "tên khách hàng";
            // 
            // MAKHM
            // 
            this.MAKHM.Location = new System.Drawing.Point(146, 29);
            this.MAKHM.Multiline = true;
            this.MAKHM.Name = "MAKHM";
            this.MAKHM.Size = new System.Drawing.Size(122, 22);
            this.MAKHM.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "mã nhà khách hàng";
            // 
            // groupBoxChitiet
            // 
            this.groupBoxChitiet.Controls.Add(this.DIACHI);
            this.groupBoxChitiet.Controls.Add(this.label4);
            this.groupBoxChitiet.Controls.Add(this.SDT);
            this.groupBoxChitiet.Controls.Add(this.label5);
            this.groupBoxChitiet.Controls.Add(this.btnCloseAction);
            this.groupBoxChitiet.Controls.Add(this.TENKH);
            this.groupBoxChitiet.Controls.Add(this.label2);
            this.groupBoxChitiet.Controls.Add(this.MAKHM);
            this.groupBoxChitiet.Controls.Add(this.label1);
            this.groupBoxChitiet.Location = new System.Drawing.Point(48, 381);
            this.groupBoxChitiet.Name = "groupBoxChitiet";
            this.groupBoxChitiet.Size = new System.Drawing.Size(514, 164);
            this.groupBoxChitiet.TabIndex = 27;
            this.groupBoxChitiet.TabStop = false;
            // 
            // DIACHI
            // 
            this.DIACHI.Location = new System.Drawing.Point(340, 42);
            this.DIACHI.Multiline = true;
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.Size = new System.Drawing.Size(151, 81);
            this.DIACHI.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "địa chỉ";
            // 
            // SDT
            // 
            this.SDT.Location = new System.Drawing.Point(146, 122);
            this.SDT.Multiline = true;
            this.SDT.Name = "SDT";
            this.SDT.Size = new System.Drawing.Size(122, 22);
            this.SDT.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "số điện thoại";
            // 
            // khach_hang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 557);
            this.Controls.Add(this.btnloadgrid);
            this.Controls.Add(this.groupBoxTimKiem);
            this.Controls.Add(this.dataGridViewKh);
            this.Controls.Add(this.groupBoxMenu);
            this.Controls.Add(this.groupBoxChitiet);
            this.Name = "khach_hang";
            this.Text = "khach_hang";
            this.Load += new System.EventHandler(this.khach_hang_Load);
            this.groupBoxTimKiem.ResumeLayout(false);
            this.groupBoxTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKh)).EndInit();
            this.BUS001.ResumeLayout(false);
            this.BUS002.ResumeLayout(false);
            this.groupBoxMenu.ResumeLayout(false);
            this.groupBoxChitiet.ResumeLayout(false);
            this.groupBoxChitiet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSeach;
        private System.Windows.Forms.Button btnCloseGrSeach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnseach;
        private System.Windows.Forms.Button btnloadgrid;
        private System.Windows.Forms.GroupBox groupBoxTimKiem;
        private System.Windows.Forms.ComboBox comboBoxSelectSeach;
        private System.Windows.Forms.DataGridView dataGridViewKh;
        private System.Windows.Forms.GroupBox BUS001;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.GroupBox BUS002;
        private System.Windows.Forms.Button timkiem;
        private System.Windows.Forms.GroupBox groupBoxMenu;
        private System.Windows.Forms.Button btnCloseAction;
        private System.Windows.Forms.TextBox TENKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MAKHM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxChitiet;
        private System.Windows.Forms.TextBox DIACHI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SDT;
        private System.Windows.Forms.Label label5;
    }
}