
namespace WindowsFormsApp1
{
    partial class lich_su
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
            this.dataGridViewLichsu = new System.Windows.Forms.DataGridView();
            this.textBoxlichsu = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCloseAction = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxLS = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLichsu)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLichsu
            // 
            this.dataGridViewLichsu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLichsu.Location = new System.Drawing.Point(2, 3);
            this.dataGridViewLichsu.Name = "dataGridViewLichsu";
            this.dataGridViewLichsu.RowHeadersWidth = 51;
            this.dataGridViewLichsu.RowTemplate.Height = 24;
            this.dataGridViewLichsu.Size = new System.Drawing.Size(1293, 570);
            this.dataGridViewLichsu.TabIndex = 0;
            // 
            // textBoxlichsu
            // 
            this.textBoxlichsu.Location = new System.Drawing.Point(410, 641);
            this.textBoxlichsu.Multiline = true;
            this.textBoxlichsu.Name = "textBoxlichsu";
            this.textBoxlichsu.Size = new System.Drawing.Size(308, 62);
            this.textBoxlichsu.TabIndex = 1;
            this.textBoxlichsu.TextChanged += new System.EventHandler(this.textBoxlichsu_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(643, 709);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCloseAction
            // 
            this.btnCloseAction.BackColor = System.Drawing.Color.LightCoral;
            this.btnCloseAction.ForeColor = System.Drawing.Color.Red;
            this.btnCloseAction.Location = new System.Drawing.Point(724, 635);
            this.btnCloseAction.Name = "btnCloseAction";
            this.btnCloseAction.Size = new System.Drawing.Size(29, 35);
            this.btnCloseAction.TabIndex = 6;
            this.btnCloseAction.Text = "X";
            this.btnCloseAction.UseVisualStyleBackColor = false;
            this.btnCloseAction.Click += new System.EventHandler(this.btnCloseAction_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(432, 602);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "tìm kiếm theo";
            // 
            // comboBoxLS
            // 
            this.comboBoxLS.FormattingEnabled = true;
            this.comboBoxLS.Location = new System.Drawing.Point(529, 599);
            this.comboBoxLS.Name = "comboBoxLS";
            this.comboBoxLS.Size = new System.Drawing.Size(189, 24);
            this.comboBoxLS.TabIndex = 8;
            // 
            // lich_su
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 738);
            this.Controls.Add(this.comboBoxLS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCloseAction);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxlichsu);
            this.Controls.Add(this.dataGridViewLichsu);
            this.Name = "lich_su";
            this.Text = "lich_su";
            this.Load += new System.EventHandler(this.lich_su_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLichsu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLichsu;
        private System.Windows.Forms.TextBox textBoxlichsu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCloseAction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxLS;
    }
}