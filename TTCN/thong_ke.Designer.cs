
namespace WindowsFormsApp1
{
    partial class thong_ke
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
            this.dataGridViewTK = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTK
            // 
            this.dataGridViewTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTK.Location = new System.Drawing.Point(3, 2);
            this.dataGridViewTK.Name = "dataGridViewTK";
            this.dataGridViewTK.RowHeadersWidth = 51;
            this.dataGridViewTK.RowTemplate.Height = 24;
            this.dataGridViewTK.Size = new System.Drawing.Size(800, 376);
            this.dataGridViewTK.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(826, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(610, 376);
            this.dataGridView1.TabIndex = 1;
            // 
            // thong_ke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1446, 586);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridViewTK);
            this.Name = "thong_ke";
            this.Text = "thong_ke";
            this.Load += new System.EventHandler(this.thong_ke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTK;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}