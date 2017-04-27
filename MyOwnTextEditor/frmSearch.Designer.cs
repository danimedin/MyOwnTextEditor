namespace MyOwnTextEditor
{
    partial class FrmSearch
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
            this.lblFind = new System.Windows.Forms.Label();
            this.cmbFind = new System.Windows.Forms.ComboBox();
            this.btbFind = new System.Windows.Forms.Button();
            this.btbClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFind
            // 
            this.lblFind.AutoSize = true;
            this.lblFind.Location = new System.Drawing.Point(13, 13);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(56, 13);
            this.lblFind.TabIndex = 0;
            this.lblFind.Text = "Find what:";
            // 
            // cmbFind
            // 
            this.cmbFind.FormattingEnabled = true;
            this.cmbFind.Location = new System.Drawing.Point(89, 15);
            this.cmbFind.Name = "cmbFind";
            this.cmbFind.Size = new System.Drawing.Size(345, 21);
            this.cmbFind.TabIndex = 1;
            // 
            // btbFind
            // 
            this.btbFind.Location = new System.Drawing.Point(441, 15);
            this.btbFind.Name = "btbFind";
            this.btbFind.Size = new System.Drawing.Size(125, 23);
            this.btbFind.TabIndex = 2;
            this.btbFind.Text = "Find Next";
            this.btbFind.UseVisualStyleBackColor = true;
            this.btbFind.Click += new System.EventHandler(this.btbFind_Click);
            // 
            // btbClose
            // 
            this.btbClose.Location = new System.Drawing.Point(441, 107);
            this.btbClose.Name = "btbClose";
            this.btbClose.Size = new System.Drawing.Size(125, 23);
            this.btbClose.TabIndex = 3;
            this.btbClose.Text = "Close";
            this.btbClose.UseVisualStyleBackColor = true;
            this.btbClose.Click += new System.EventHandler(this.btbClose_Click);
            // 
            // FrmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 142);
            this.Controls.Add(this.btbClose);
            this.Controls.Add(this.btbFind);
            this.Controls.Add(this.cmbFind);
            this.Controls.Add(this.lblFind);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSearch";
            this.Text = "Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFind;
        private System.Windows.Forms.ComboBox cmbFind;
        private System.Windows.Forms.Button btbFind;
        private System.Windows.Forms.Button btbClose;
    }
}