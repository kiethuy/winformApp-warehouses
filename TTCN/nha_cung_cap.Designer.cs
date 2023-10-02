
namespace WindowsFormsApp1
{
    partial class nha_cung_cap
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
            this.groupBoxChitiet = new System.Windows.Forms.GroupBox();
            this.btnCloseAction = new System.Windows.Forms.Button();
            this.TENNCC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MANCCM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxMenu = new System.Windows.Forms.GroupBox();
            this.BUS002 = new System.Windows.Forms.GroupBox();
            this.timkiem = new System.Windows.Forms.Button();
            this.BUS001 = new System.Windows.Forms.GroupBox();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.dataGridViewNCC = new System.Windows.Forms.DataGridView();
            this.btnloadgrid = new System.Windows.Forms.Button();
            this.groupBoxTimKiem = new System.Windows.Forms.GroupBox();
            this.textBoxSeach = new System.Windows.Forms.TextBox();
            this.btnCloseGrSeach = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSelectSeach = new System.Windows.Forms.ComboBox();
            this.btnseach = new System.Windows.Forms.Button();
            this.groupBoxChitiet.SuspendLayout();
            this.groupBoxMenu.SuspendLayout();
            this.BUS002.SuspendLayout();
            this.BUS001.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNCC)).BeginInit();
            this.groupBoxTimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxChitiet
            // 
            this.groupBoxChitiet.Controls.Add(this.btnCloseAction);
            this.groupBoxChitiet.Controls.Add(this.TENNCC);
            this.groupBoxChitiet.Controls.Add(this.label2);
            this.groupBoxChitiet.Controls.Add(this.MANCCM);
            this.groupBoxChitiet.Controls.Add(this.label1);
            this.groupBoxChitiet.Location = new System.Drawing.Point(186, 330);
            this.groupBoxChitiet.Name = "groupBoxChitiet";
            this.groupBoxChitiet.Size = new System.Drawing.Size(291, 108);
            this.groupBoxChitiet.TabIndex = 6;
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
            // TENNCC
            // 
            this.TENNCC.Location = new System.Drawing.Point(130, 57);
            this.TENNCC.Multiline = true;
            this.TENNCC.Name = "TENNCC";
            this.TENNCC.Size = new System.Drawing.Size(122, 45);
            this.TENNCC.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "tên nhà cung cấp";
            // 
            // MANCCM
            // 
            this.MANCCM.Location = new System.Drawing.Point(130, 29);
            this.MANCCM.Multiline = true;
            this.MANCCM.Name = "MANCCM";
            this.MANCCM.Size = new System.Drawing.Size(122, 22);
            this.MANCCM.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "mã nhà cung cấp";
            // 
            // groupBoxMenu
            // 
            this.groupBoxMenu.Controls.Add(this.BUS002);
            this.groupBoxMenu.Controls.Add(this.BUS001);
            this.groupBoxMenu.Location = new System.Drawing.Point(528, 332);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Size = new System.Drawing.Size(364, 100);
            this.groupBoxMenu.TabIndex = 5;
            this.groupBoxMenu.TabStop = false;
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
            // dataGridViewNCC
            // 
            this.dataGridViewNCC.AllowUserToAddRows = false;
            this.dataGridViewNCC.AllowUserToDeleteRows = false;
            this.dataGridViewNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNCC.Location = new System.Drawing.Point(12, 3);
            this.dataGridViewNCC.Name = "dataGridViewNCC";
            this.dataGridViewNCC.ReadOnly = true;
            this.dataGridViewNCC.RowHeadersWidth = 51;
            this.dataGridViewNCC.RowTemplate.Height = 24;
            this.dataGridViewNCC.Size = new System.Drawing.Size(650, 321);
            this.dataGridViewNCC.TabIndex = 7;
            this.dataGridViewNCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNCC_CellClick);
            // 
            // btnloadgrid
            // 
            this.btnloadgrid.Location = new System.Drawing.Point(849, 215);
            this.btnloadgrid.Name = "btnloadgrid";
            this.btnloadgrid.Size = new System.Drawing.Size(108, 50);
            this.btnloadgrid.TabIndex = 25;
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
            this.groupBoxTimKiem.Location = new System.Drawing.Point(717, 51);
            this.groupBoxTimKiem.Name = "groupBoxTimKiem";
            this.groupBoxTimKiem.Size = new System.Drawing.Size(318, 133);
            this.groupBoxTimKiem.TabIndex = 24;
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
            // nha_cung_cap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 450);
            this.Controls.Add(this.btnloadgrid);
            this.Controls.Add(this.groupBoxTimKiem);
            this.Controls.Add(this.dataGridViewNCC);
            this.Controls.Add(this.groupBoxChitiet);
            this.Controls.Add(this.groupBoxMenu);
            this.Name = "nha_cung_cap";
            this.Text = "nha_cung_cap";
            this.Load += new System.EventHandler(this.nha_cung_cap_Load);
            this.groupBoxChitiet.ResumeLayout(false);
            this.groupBoxChitiet.PerformLayout();
            this.groupBoxMenu.ResumeLayout(false);
            this.BUS002.ResumeLayout(false);
            this.BUS001.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNCC)).EndInit();
            this.groupBoxTimKiem.ResumeLayout(false);
            this.groupBoxTimKiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxChitiet;
        private System.Windows.Forms.Button btnCloseAction;
        private System.Windows.Forms.TextBox TENNCC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MANCCM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxMenu;
        private System.Windows.Forms.GroupBox BUS002;
        private System.Windows.Forms.Button timkiem;
        private System.Windows.Forms.GroupBox BUS001;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DataGridView dataGridViewNCC;
        private System.Windows.Forms.Button btnloadgrid;
        private System.Windows.Forms.GroupBox groupBoxTimKiem;
        private System.Windows.Forms.TextBox textBoxSeach;
        private System.Windows.Forms.Button btnCloseGrSeach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxSelectSeach;
        private System.Windows.Forms.Button btnseach;
    }
}