using System.Drawing;

namespace real_loginForm
{
    partial class SupportTeamForm
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
            this.welcomeLbl = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabUnsolved = new System.Windows.Forms.TabPage();
            this.tabShare = new System.Windows.Forms.TabPage();
            this.tabTickets = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.AutoSize = true;
            this.welcomeLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.welcomeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.welcomeLbl.Location = new System.Drawing.Point(0, 0);
            this.welcomeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(786, 64);
            this.welcomeLbl.TabIndex = 1;
            this.welcomeLbl.Text = "Welcome, I.T. Support Team!\r\n";
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(189)))), ((int)(((byte)(152)))));
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(83)))), ((int)(((byte)(76)))));
            this.backBtn.Location = new System.Drawing.Point(763, 9);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(145, 27);
            this.backBtn.TabIndex = 17;
            this.backBtn.Text = "Return to Login";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabUnsolved);
            this.tabControl1.Controls.Add(this.tabShare);
            this.tabControl1.Controls.Add(this.tabTickets);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 64);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1011, 537);
            this.tabControl1.TabIndex = 19;
            // 
            // tabUnsolved
            // 
            this.tabUnsolved.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(214)))));
            this.tabUnsolved.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(83)))), ((int)(((byte)(76)))));
            this.tabUnsolved.Location = new System.Drawing.Point(4, 22);
            this.tabUnsolved.Name = "tabUnsolved";
            this.tabUnsolved.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabUnsolved.Size = new System.Drawing.Size(1003, 511);
            this.tabUnsolved.TabIndex = 0;
            this.tabUnsolved.Text = "Unsolved Tickets";
            // 
            // tabShare
            // 
            this.tabShare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(214)))));
            this.tabShare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(83)))), ((int)(((byte)(76)))));
            this.tabShare.Location = new System.Drawing.Point(4, 22);
            this.tabShare.Name = "tabShare";
            this.tabShare.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabShare.Size = new System.Drawing.Size(1003, 534);
            this.tabShare.TabIndex = 2;
            this.tabShare.Text = "Share Ticket";
            // 
            // tabTickets
            // 
            this.tabTickets.Location = new System.Drawing.Point(4, 22);
            this.tabTickets.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabTickets.Name = "tabTickets";
            this.tabTickets.Size = new System.Drawing.Size(1003, 534);
            this.tabTickets.TabIndex = 3;
            this.tabTickets.Text = " My Tickets";
            this.tabTickets.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(929, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(59, 57);
            this.flowLayoutPanel1.TabIndex = 44;
            // 
            // SupportTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(125)))), ((int)(((byte)(106)))));
            this.ClientSize = new System.Drawing.Size(1011, 601);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.welcomeLbl);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SupportTeamForm";
            this.Text = "SupportTeamForm";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLbl;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabUnsolved;
        private System.Windows.Forms.TabPage tabShare;
        private System.Windows.Forms.TabPage tabTickets;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}