
namespace WindowsFormsApp1
{
    partial class chi_tiet_san_pham
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
            this.dataGridViewchitietsp = new System.Windows.Forms.DataGridView();
            this.groupBoxMenu = new System.Windows.Forms.GroupBox();
            this.STK002 = new System.Windows.Forms.GroupBox();
            this.timkiem = new System.Windows.Forms.Button();
            this.STK001 = new System.Windows.Forms.GroupBox();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.groupBoxsp = new System.Windows.Forms.GroupBox();
            this.textBoxmancc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTensp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textboxMasp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxchitietsp = new System.Windows.Forms.GroupBox();
            this.btnCloseAction = new System.Windows.Forms.Button();
            this.Chitietvalue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chitiet = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxTimKiem = new System.Windows.Forms.GroupBox();
            this.textBoxSeach = new System.Windows.Forms.TextBox();
            this.btnCloseGrSeach = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxSelectSeach = new System.Windows.Forms.ComboBox();
            this.btnseach = new System.Windows.Forms.Button();
            this.btnloadgrid = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewchitietsp)).BeginInit();
            this.groupBoxMenu.SuspendLayout();
            this.STK002.SuspendLayout();
            this.STK001.SuspendLayout();
            this.groupBoxsp.SuspendLayout();
            this.groupBoxchitietsp.SuspendLayout();
            this.groupBoxTimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewchitietsp
            // 
            this.dataGridViewchitietsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewchitietsp.Location = new System.Drawing.Point(-4, 12);
            this.dataGridViewchitietsp.Name = "dataGridViewchitietsp";
            this.dataGridViewchitietsp.RowHeadersWidth = 51;
            this.dataGridViewchitietsp.RowTemplate.Height = 24;
            this.dataGridViewchitietsp.Size = new System.Drawing.Size(859, 286);
            this.dataGridViewchitietsp.TabIndex = 0;
            this.dataGridViewchitietsp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewchitietsp_CellClick);
            // 
            // groupBoxMenu
            // 
            this.groupBoxMenu.Controls.Add(this.STK002);
            this.groupBoxMenu.Controls.Add(this.STK001);
            this.groupBoxMenu.Location = new System.Drawing.Point(672, 325);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Size = new System.Drawing.Size(364, 100);
            this.groupBoxMenu.TabIndex = 4;
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
            this.timkiem.Click += new System.EventHandler(this.timkiem_Click);
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
            // groupBoxsp
            // 
            this.groupBoxsp.Controls.Add(this.textBoxmancc);
            this.groupBoxsp.Controls.Add(this.label3);
            this.groupBoxsp.Controls.Add(this.textBoxTensp);
            this.groupBoxsp.Controls.Add(this.label2);
            this.groupBoxsp.Controls.Add(this.textboxMasp);
            this.groupBoxsp.Controls.Add(this.label1);
            this.groupBoxsp.Location = new System.Drawing.Point(12, 304);
            this.groupBoxsp.Name = "groupBoxsp";
            this.groupBoxsp.Size = new System.Drawing.Size(363, 183);
            this.groupBoxsp.TabIndex = 5;
            this.groupBoxsp.TabStop = false;
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
            // textBoxTensp
            // 
            this.textBoxTensp.Enabled = false;
            this.textBoxTensp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textBoxTensp.Location = new System.Drawing.Point(154, 49);
            this.textBoxTensp.Multiline = true;
            this.textBoxTensp.Name = "textBoxTensp";
            this.textBoxTensp.Size = new System.Drawing.Size(181, 59);
            this.textBoxTensp.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "tên sản phẩm";
            // 
            // textboxMasp
            // 
            this.textboxMasp.Enabled = false;
            this.textboxMasp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textboxMasp.Location = new System.Drawing.Point(154, 21);
            this.textboxMasp.Name = "textboxMasp";
            this.textboxMasp.Size = new System.Drawing.Size(181, 22);
            this.textboxMasp.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "mã sản phẩm";
            // 
            // groupBoxchitietsp
            // 
            this.groupBoxchitietsp.Controls.Add(this.btnCloseAction);
            this.groupBoxchitietsp.Controls.Add(this.Chitietvalue);
            this.groupBoxchitietsp.Controls.Add(this.label4);
            this.groupBoxchitietsp.Controls.Add(this.chitiet);
            this.groupBoxchitietsp.Controls.Add(this.label5);
            this.groupBoxchitietsp.Location = new System.Drawing.Point(372, 304);
            this.groupBoxchitietsp.Name = "groupBoxchitietsp";
            this.groupBoxchitietsp.Size = new System.Drawing.Size(237, 183);
            this.groupBoxchitietsp.TabIndex = 6;
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
            this.btnCloseAction.Click += new System.EventHandler(this.btnCloseAction_Click);
            // 
            // Chitietvalue
            // 
            this.Chitietvalue.Location = new System.Drawing.Point(77, 109);
            this.Chitietvalue.Name = "Chitietvalue";
            this.Chitietvalue.Size = new System.Drawing.Size(121, 22);
            this.Chitietvalue.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "giá trị";
            // 
            // chitiet
            // 
            this.chitiet.FormattingEnabled = true;
            this.chitiet.Location = new System.Drawing.Point(77, 71);
            this.chitiet.Name = "chitiet";
            this.chitiet.Size = new System.Drawing.Size(121, 24);
            this.chitiet.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "chi tiết";
            // 
            // groupBoxTimKiem
            // 
            this.groupBoxTimKiem.Controls.Add(this.textBoxSeach);
            this.groupBoxTimKiem.Controls.Add(this.btnCloseGrSeach);
            this.groupBoxTimKiem.Controls.Add(this.label6);
            this.groupBoxTimKiem.Controls.Add(this.comboBoxSelectSeach);
            this.groupBoxTimKiem.Controls.Add(this.btnseach);
            this.groupBoxTimKiem.Location = new System.Drawing.Point(897, 55);
            this.groupBoxTimKiem.Name = "groupBoxTimKiem";
            this.groupBoxTimKiem.Size = new System.Drawing.Size(318, 133);
            this.groupBoxTimKiem.TabIndex = 23;
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
            this.btnloadgrid.Location = new System.Drawing.Point(928, 227);
            this.btnloadgrid.Name = "btnloadgrid";
            this.btnloadgrid.Size = new System.Drawing.Size(108, 50);
            this.btnloadgrid.TabIndex = 24;
            this.btnloadgrid.Text = "xem toàn bộ ";
            this.btnloadgrid.UseVisualStyleBackColor = true;
            this.btnloadgrid.Visible = false;
            this.btnloadgrid.Click += new System.EventHandler(this.btnloadgrid_Click);
            // 
            // chi_tiet_san_pham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 600);
            this.Controls.Add(this.btnloadgrid);
            this.Controls.Add(this.groupBoxTimKiem);
            this.Controls.Add(this.groupBoxchitietsp);
            this.Controls.Add(this.groupBoxsp);
            this.Controls.Add(this.groupBoxMenu);
            this.Controls.Add(this.dataGridViewchitietsp);
            this.Name = "chi_tiet_san_pham";
            this.Text = "chi_tiet_san_pham";
            this.Load += new System.EventHandler(this.chi_tiet_san_pham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewchitietsp)).EndInit();
            this.groupBoxMenu.ResumeLayout(false);
            this.STK002.ResumeLayout(false);
            this.STK001.ResumeLayout(false);
            this.groupBoxsp.ResumeLayout(false);
            this.groupBoxsp.PerformLayout();
            this.groupBoxchitietsp.ResumeLayout(false);
            this.groupBoxchitietsp.PerformLayout();
            this.groupBoxTimKiem.ResumeLayout(false);
            this.groupBoxTimKiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewchitietsp;
        private System.Windows.Forms.GroupBox groupBoxMenu;
        private System.Windows.Forms.GroupBox STK002;
        private System.Windows.Forms.Button timkiem;
        private System.Windows.Forms.GroupBox STK001;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.GroupBox groupBoxsp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxMasp;
        private System.Windows.Forms.TextBox textBoxmancc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTensp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxchitietsp;
        private System.Windows.Forms.TextBox Chitietvalue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox chitiet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxTimKiem;
        private System.Windows.Forms.TextBox textBoxSeach;
        private System.Windows.Forms.Button btnCloseGrSeach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxSelectSeach;
        private System.Windows.Forms.Button btnseach;
        private System.Windows.Forms.Button btnloadgrid;
        private System.Windows.Forms.Button btnCloseAction;
    }
}