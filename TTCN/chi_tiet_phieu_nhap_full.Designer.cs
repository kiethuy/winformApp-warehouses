
namespace WindowsFormsApp1
{
    partial class chi_tiet_phieu_nhap_full
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
            this.dataGridViewCHITIETPNfull = new System.Windows.Forms.DataGridView();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.btnXemPN = new System.Windows.Forms.Button();
            this.btnCloseGrtimkiem = new System.Windows.Forms.Button();
            this.textTimkiem = new System.Windows.Forms.TextBox();
            this.groupBoxMenu = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCHITIETPNfull)).BeginInit();
            this.groupBoxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewCHITIETPNfull
            // 
            this.dataGridViewCHITIETPNfull.AllowUserToAddRows = false;
            this.dataGridViewCHITIETPNfull.AllowUserToDeleteRows = false;
            this.dataGridViewCHITIETPNfull.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCHITIETPNfull.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewCHITIETPNfull.Name = "dataGridViewCHITIETPNfull";
            this.dataGridViewCHITIETPNfull.ReadOnly = true;
            this.dataGridViewCHITIETPNfull.RowHeadersWidth = 51;
            this.dataGridViewCHITIETPNfull.RowTemplate.Height = 24;
            this.dataGridViewCHITIETPNfull.Size = new System.Drawing.Size(1275, 482);
            this.dataGridViewCHITIETPNfull.TabIndex = 6;
            this.dataGridViewCHITIETPNfull.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCHITIETPNfull_CellClick);
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(6, 21);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(75, 23);
            this.btntimkiem.TabIndex = 1;
            this.btntimkiem.Text = "tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            // 
            // btnXemPN
            // 
            this.btnXemPN.Location = new System.Drawing.Point(95, 21);
            this.btnXemPN.Name = "btnXemPN";
            this.btnXemPN.Size = new System.Drawing.Size(138, 23);
            this.btnXemPN.TabIndex = 2;
            this.btnXemPN.Text = "xem phiếu nhập này";
            this.btnXemPN.UseVisualStyleBackColor = true;
            this.btnXemPN.Visible = false;
            this.btnXemPN.Click += new System.EventHandler(this.btnXemPN_Click);
            // 
            // btnCloseGrtimkiem
            // 
            this.btnCloseGrtimkiem.BackColor = System.Drawing.Color.LightCoral;
            this.btnCloseGrtimkiem.ForeColor = System.Drawing.Color.Red;
            this.btnCloseGrtimkiem.Location = new System.Drawing.Point(720, 600);
            this.btnCloseGrtimkiem.Name = "btnCloseGrtimkiem";
            this.btnCloseGrtimkiem.Size = new System.Drawing.Size(29, 35);
            this.btnCloseGrtimkiem.TabIndex = 9;
            this.btnCloseGrtimkiem.Text = "X";
            this.btnCloseGrtimkiem.UseVisualStyleBackColor = false;
            this.btnCloseGrtimkiem.Click += new System.EventHandler(this.btnCloseGrtimkiem_Click);
            // 
            // textTimkiem
            // 
            this.textTimkiem.Location = new System.Drawing.Point(492, 572);
            this.textTimkiem.Multiline = true;
            this.textTimkiem.Name = "textTimkiem";
            this.textTimkiem.Size = new System.Drawing.Size(233, 63);
            this.textTimkiem.TabIndex = 8;
            this.textTimkiem.TextChanged += new System.EventHandler(this.textTimkiem_TextChanged);
            // 
            // groupBoxMenu
            // 
            this.groupBoxMenu.Controls.Add(this.btntimkiem);
            this.groupBoxMenu.Controls.Add(this.btnXemPN);
            this.groupBoxMenu.Location = new System.Drawing.Point(486, 511);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Size = new System.Drawing.Size(239, 55);
            this.groupBoxMenu.TabIndex = 7;
            this.groupBoxMenu.TabStop = false;
            // 
            // chi_tiet_phieu_nhap_full
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 696);
            this.Controls.Add(this.dataGridViewCHITIETPNfull);
            this.Controls.Add(this.btnCloseGrtimkiem);
            this.Controls.Add(this.textTimkiem);
            this.Controls.Add(this.groupBoxMenu);
            this.Name = "chi_tiet_phieu_nhap_full";
            this.Text = "chi_tiet_phieu_nhap_full";
            this.Load += new System.EventHandler(this.chi_tiet_phieu_nhap_full_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCHITIETPNfull)).EndInit();
            this.groupBoxMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCHITIETPNfull;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Button btnXemPN;
        private System.Windows.Forms.Button btnCloseGrtimkiem;
        private System.Windows.Forms.TextBox textTimkiem;
        private System.Windows.Forms.GroupBox groupBoxMenu;
    }
}