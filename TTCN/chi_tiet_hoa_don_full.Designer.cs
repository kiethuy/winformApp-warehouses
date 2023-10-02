
namespace WindowsFormsApp1
{
    partial class chi_tiet_hoa_don_full
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
            this.dataGridViewCHITIETHDfull = new System.Windows.Forms.DataGridView();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.btnXemh = new System.Windows.Forms.Button();
            this.groupBoxMenu = new System.Windows.Forms.GroupBox();
            this.textTimkiem = new System.Windows.Forms.TextBox();
            this.btnCloseGrtimkiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCHITIETHDfull)).BeginInit();
            this.groupBoxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewCHITIETHDfull
            // 
            this.dataGridViewCHITIETHDfull.AllowUserToAddRows = false;
            this.dataGridViewCHITIETHDfull.AllowUserToDeleteRows = false;
            this.dataGridViewCHITIETHDfull.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCHITIETHDfull.Location = new System.Drawing.Point(5, 3);
            this.dataGridViewCHITIETHDfull.Name = "dataGridViewCHITIETHDfull";
            this.dataGridViewCHITIETHDfull.ReadOnly = true;
            this.dataGridViewCHITIETHDfull.RowHeadersWidth = 51;
            this.dataGridViewCHITIETHDfull.RowTemplate.Height = 24;
            this.dataGridViewCHITIETHDfull.Size = new System.Drawing.Size(1275, 340);
            this.dataGridViewCHITIETHDfull.TabIndex = 0;
            this.dataGridViewCHITIETHDfull.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCHITIETHDfull_CellClick);
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(6, 21);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(75, 23);
            this.btntimkiem.TabIndex = 1;
            this.btntimkiem.Text = "tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // btnXemh
            // 
            this.btnXemh.Location = new System.Drawing.Point(95, 21);
            this.btnXemh.Name = "btnXemh";
            this.btnXemh.Size = new System.Drawing.Size(138, 23);
            this.btnXemh.TabIndex = 2;
            this.btnXemh.Text = "xem hóa đơn này";
            this.btnXemh.UseVisualStyleBackColor = true;
            this.btnXemh.Visible = false;
            this.btnXemh.Click += new System.EventHandler(this.btnXemhd_Click);
            // 
            // groupBoxMenu
            // 
            this.groupBoxMenu.Controls.Add(this.btntimkiem);
            this.groupBoxMenu.Controls.Add(this.btnXemh);
            this.groupBoxMenu.Location = new System.Drawing.Point(502, 367);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Size = new System.Drawing.Size(239, 55);
            this.groupBoxMenu.TabIndex = 3;
            this.groupBoxMenu.TabStop = false;
            // 
            // textTimkiem
            // 
            this.textTimkiem.Location = new System.Drawing.Point(508, 428);
            this.textTimkiem.Multiline = true;
            this.textTimkiem.Name = "textTimkiem";
            this.textTimkiem.Size = new System.Drawing.Size(233, 63);
            this.textTimkiem.TabIndex = 4;
            this.textTimkiem.TextChanged += new System.EventHandler(this.textTimkiem_TextChanged);
            // 
            // btnCloseGrtimkiem
            // 
            this.btnCloseGrtimkiem.BackColor = System.Drawing.Color.LightCoral;
            this.btnCloseGrtimkiem.ForeColor = System.Drawing.Color.Red;
            this.btnCloseGrtimkiem.Location = new System.Drawing.Point(736, 456);
            this.btnCloseGrtimkiem.Name = "btnCloseGrtimkiem";
            this.btnCloseGrtimkiem.Size = new System.Drawing.Size(29, 35);
            this.btnCloseGrtimkiem.TabIndex = 5;
            this.btnCloseGrtimkiem.Text = "X";
            this.btnCloseGrtimkiem.UseVisualStyleBackColor = false;
            this.btnCloseGrtimkiem.Click += new System.EventHandler(this.btnCloseGrtimkiem_Click);
            // 
            // chi_tiet_hoa_don_full
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 515);
            this.Controls.Add(this.btnCloseGrtimkiem);
            this.Controls.Add(this.textTimkiem);
            this.Controls.Add(this.groupBoxMenu);
            this.Controls.Add(this.dataGridViewCHITIETHDfull);
            this.Name = "chi_tiet_hoa_don_full";
            this.Text = "chi_tiet_hoa_don_full";
            this.Load += new System.EventHandler(this.chi_tiet_hoa_don_full_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCHITIETHDfull)).EndInit();
            this.groupBoxMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCHITIETHDfull;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Button btnXemh;
        private System.Windows.Forms.GroupBox groupBoxMenu;
        private System.Windows.Forms.TextBox textTimkiem;
        private System.Windows.Forms.Button btnCloseGrtimkiem;
    }
}