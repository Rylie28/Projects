namespace real_loginForm
{
    partial class ShareTicketControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnShare = new System.Windows.Forms.Button();
            this.cmbShare = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstUnsolvedTickets = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnShare
            // 
            this.btnShare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(189)))), ((int)(((byte)(152)))));
            this.btnShare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(83)))), ((int)(((byte)(76)))));
            this.btnShare.Location = new System.Drawing.Point(362, 580);
            this.btnShare.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShare.Name = "btnShare";
            this.btnShare.Size = new System.Drawing.Size(127, 46);
            this.btnShare.TabIndex = 44;
            this.btnShare.Text = "Share";
            this.btnShare.UseVisualStyleBackColor = false;
            this.btnShare.Click += new System.EventHandler(this.btnShare_Click);
            // 
            // cmbShare
            // 
            this.cmbShare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(214)))));
            this.cmbShare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(83)))), ((int)(((byte)(76)))));
            this.cmbShare.FormattingEnabled = true;
            this.cmbShare.Location = new System.Drawing.Point(362, 532);
            this.cmbShare.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbShare.Name = "cmbShare";
            this.cmbShare.Size = new System.Drawing.Size(332, 28);
            this.cmbShare.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.label3.Location = new System.Drawing.Point(218, 537);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "Share With:";
            // 
            // lstUnsolvedTickets
            // 
            this.lstUnsolvedTickets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(214)))));
            this.lstUnsolvedTickets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(83)))), ((int)(((byte)(76)))));
            this.lstUnsolvedTickets.FormattingEnabled = true;
            this.lstUnsolvedTickets.ItemHeight = 20;
            this.lstUnsolvedTickets.Location = new System.Drawing.Point(222, 45);
            this.lstUnsolvedTickets.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstUnsolvedTickets.Name = "lstUnsolvedTickets";
            this.lstUnsolvedTickets.Size = new System.Drawing.Size(932, 484);
            this.lstUnsolvedTickets.TabIndex = 45;
            // 
            // ShareTicketControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(125)))), ((int)(((byte)(106)))));
            this.Controls.Add(this.lstUnsolvedTickets);
            this.Controls.Add(this.btnShare);
            this.Controls.Add(this.cmbShare);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ShareTicketControl";
            this.Size = new System.Drawing.Size(1629, 802);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShare;
        private System.Windows.Forms.ComboBox cmbShare;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstUnsolvedTickets;
    }
}
