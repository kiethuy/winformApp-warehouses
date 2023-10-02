
namespace WindowsFormsApp1
{
    partial class chi_tiet_phieu_xuat_full
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
            this.dataGridViewCHITIETPXfull = new System.Windows.Forms.DataGridView();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.btnXemPX = new System.Windows.Forms.Button();
            this.btnCloseGrtimkiem = new System.Windows.Forms.Button();
            this.textTimkiem = new System.Windows.Forms.TextBox();
            this.groupBoxMenu = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCHITIETPXfull)).BeginInit();
            this.groupBoxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewCHITIETPXfull
            // 
            this.dataGridViewCHITIETPXfull.AllowUserToAddRows = false;
            this.dataGridViewCHITIETPXfull.AllowUserToDeleteRows = false;
            this.dataGridViewCHITIETPXfull.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCHITIETPXfull.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewCHITIETPXfull.Name = "dataGridViewCHITIETPXfull";
            this.dataGridViewCHITIETPXfull.ReadOnly = true;
            this.dataGridViewCHITIETPXfull.RowHeadersWidth = 51;
            this.dataGridViewCHITIETPXfull.RowTemplate.Height = 24;
            this.dataGridViewCHITIETPXfull.Size = new System.Drawing.Size(1244, 461);
            this.dataGridViewCHITIETPXfull.TabIndex = 10;
            this.dataGridViewCHITIETPXfull.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCHITIETPXfull_CellClick);
            // 
            // btntimkiem
            // 
            this.btntimkiem.Enabled = false;
            this.btntimkiem.Location = new System.Drawing.Point(6, 21);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(75, 23);
            this.btntimkiem.TabIndex = 1;
            this.btntimkiem.Text = "tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            // 
            // btnXemPX
            // 
            this.btnXemPX.Location = new System.Drawing.Point(95, 21);
            this.btnXemPX.Name = "btnXemPX";
            this.btnXemPX.Size = new System.Drawing.Size(138, 23);
            this.btnXemPX.TabIndex = 2;
            this.btnXemPX.Text = "xem phiếu xuất";
            this.btnXemPX.UseVisualStyleBackColor = true;
            this.btnXemPX.Visible = false;
            this.btnXemPX.Click += new System.EventHandler(this.btnXemPX_Click);
            // 
            // btnCloseGrtimkiem
            // 
            this.btnCloseGrtimkiem.BackColor = System.Drawing.Color.LightCoral;
            this.btnCloseGrtimkiem.ForeColor = System.Drawing.Color.Red;
            this.btnCloseGrtimkiem.Location = new System.Drawing.Point(739, 568);
            this.btnCloseGrtimkiem.Name = "btnCloseGrtimkiem";
            this.btnCloseGrtimkiem.Size = new System.Drawing.Size(29, 35);
            this.btnCloseGrtimkiem.TabIndex = 13;
            this.btnCloseGrtimkiem.Text = "X";
            this.btnCloseGrtimkiem.UseVisualStyleBackColor = false;
            this.btnCloseGrtimkiem.Click += new System.EventHandler(this.btnCloseGrtimkiem_Click);
            // 
            // textTimkiem
            // 
            this.textTimkiem.Location = new System.Drawing.Point(511, 540);
            this.textTimkiem.Multiline = true;
            this.textTimkiem.Name = "textTimkiem";
            this.textTimkiem.Size = new System.Drawing.Size(233, 63);
            this.textTimkiem.TabIndex = 12;
            this.textTimkiem.TextChanged += new System.EventHandler(this.textTimkiem_TextChanged);
            // 
            // groupBoxMenu
            // 
            this.groupBoxMenu.Controls.Add(this.btntimkiem);
            this.groupBoxMenu.Controls.Add(this.btnXemPX);
            this.groupBoxMenu.Location = new System.Drawing.Point(505, 479);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Size = new System.Drawing.Size(239, 55);
            this.groupBoxMenu.TabIndex = 11;
            this.groupBoxMenu.TabStop = false;
            // 
            // chi_tiet_phieu_xuat_full
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 611);
            this.Controls.Add(this.dataGridViewCHITIETPXfull);
            this.Controls.Add(this.btnCloseGrtimkiem);
            this.Controls.Add(this.textTimkiem);
            this.Controls.Add(this.groupBoxMenu);
            this.Name = "chi_tiet_phieu_xuat_full";
            this.Text = "chi_tiet_phieu_xuat_full";
            this.Load += new System.EventHandler(this.chi_tiet_phieu_xuat_full_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCHITIETPXfull)).EndInit();
            this.groupBoxMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCHITIETPXfull;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Button btnXemPX;
        private System.Windows.Forms.Button btnCloseGrtimkiem;
        private System.Windows.Forms.TextBox textTimkiem;
        private System.Windows.Forms.GroupBox groupBoxMenu;
    }
}