namespace real_loginForm
{
    partial class MyTicketsControl
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
            this.lstTickets = new System.Windows.Forms.ListBox();
            this.pnlMonitor = new System.Windows.Forms.Panel();
            this.txtUpdatedDate = new System.Windows.Forms.TextBox();
            this.txtCreatedDate = new System.Windows.Forms.TextBox();
            this.txtSolution = new System.Windows.Forms.TextBox();
            this.txtTicketID = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnUpdateTicket = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMonitor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstTickets
            // 
            this.lstTickets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(214)))));
            this.lstTickets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(83)))), ((int)(((byte)(76)))));
            this.lstTickets.FormattingEnabled = true;
            this.lstTickets.ItemHeight = 20;
            this.lstTickets.Location = new System.Drawing.Point(85, 72);
            this.lstTickets.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstTickets.Name = "lstTickets";
            this.lstTickets.Size = new System.Drawing.Size(1002, 224);
            this.lstTickets.TabIndex = 46;
            this.lstTickets.SelectedIndexChanged += new System.EventHandler(this.lstTickets_SelectedIndexChanged);
            // 
            // pnlMonitor
            // 
            this.pnlMonitor.Controls.Add(this.txtUpdatedDate);
            this.pnlMonitor.Controls.Add(this.txtCreatedDate);
            this.pnlMonitor.Controls.Add(this.txtSolution);
            this.pnlMonitor.Controls.Add(this.txtTicketID);
            this.pnlMonitor.Controls.Add(this.txtDescription);
            this.pnlMonitor.Controls.Add(this.btnUpdateTicket);
            this.pnlMonitor.Controls.Add(this.label6);
            this.pnlMonitor.Controls.Add(this.label5);
            this.pnlMonitor.Controls.Add(this.label4);
            this.pnlMonitor.Controls.Add(this.label2);
            this.pnlMonitor.Controls.Add(this.label1);
            this.pnlMonitor.Location = new System.Drawing.Point(85, 325);
            this.pnlMonitor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlMonitor.Name = "pnlMonitor";
            this.pnlMonitor.Size = new System.Drawing.Size(476, 341);
            this.pnlMonitor.TabIndex = 47;
            // 
            // txtUpdatedDate
            // 
            this.txtUpdatedDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(214)))));
            this.txtUpdatedDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(83)))), ((int)(((byte)(76)))));
            this.txtUpdatedDate.Location = new System.Drawing.Point(102, 218);
            this.txtUpdatedDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUpdatedDate.Name = "txtUpdatedDate";
            this.txtUpdatedDate.ReadOnly = true;
            this.txtUpdatedDate.Size = new System.Drawing.Size(319, 26);
            this.txtUpdatedDate.TabIndex = 63;
            // 
            // txtCreatedDate
            // 
            this.txtCreatedDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(214)))));
            this.txtCreatedDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(83)))), ((int)(((byte)(76)))));
            this.txtCreatedDate.Location = new System.Drawing.Point(101, 176);
            this.txtCreatedDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCreatedDate.Name = "txtCreatedDate";
            this.txtCreatedDate.ReadOnly = true;
            this.txtCreatedDate.Size = new System.Drawing.Size(319, 26);
            this.txtCreatedDate.TabIndex = 62;
            // 
            // txtSolution
            // 
            this.txtSolution.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(214)))));
            this.txtSolution.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(83)))), ((int)(((byte)(76)))));
            this.txtSolution.Location = new System.Drawing.Point(100, 109);
            this.txtSolution.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSolution.Multiline = true;
            this.txtSolution.Name = "txtSolution";
            this.txtSolution.Size = new System.Drawing.Size(319, 57);
            this.txtSolution.TabIndex = 61;
            // 
            // txtTicketID
            // 
            this.txtTicketID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(214)))));
            this.txtTicketID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(83)))), ((int)(((byte)(76)))));
            this.txtTicketID.Location = new System.Drawing.Point(100, 5);
            this.txtTicketID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTicketID.Name = "txtTicketID";
            this.txtTicketID.ReadOnly = true;
            this.txtTicketID.Size = new System.Drawing.Size(80, 26);
            this.txtTicketID.TabIndex = 60;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(214)))));
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(83)))), ((int)(((byte)(76)))));
            this.txtDescription.Location = new System.Drawing.Point(100, 39);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(319, 62);
            this.txtDescription.TabIndex = 59;
            // 
            // btnUpdateTicket
            // 
            this.btnUpdateTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(189)))), ((int)(((byte)(152)))));
            this.btnUpdateTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTicket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(83)))), ((int)(((byte)(76)))));
            this.btnUpdateTicket.Location = new System.Drawing.Point(12, 273);
            this.btnUpdateTicket.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateTicket.Name = "btnUpdateTicket";
            this.btnUpdateTicket.Size = new System.Drawing.Size(125, 51);
            this.btnUpdateTicket.TabIndex = 5;
            this.btnUpdateTicket.Text = "Update";
            this.btnUpdateTicket.UseVisualStyleBackColor = false;
            this.btnUpdateTicket.Click += new System.EventHandler(this.btnUpdateTicket_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.label6.Location = new System.Drawing.Point(9, 219);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 43;
            this.label6.Text = "Updated:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.label5.Location = new System.Drawing.Point(9, 178);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 42;
            this.label5.Text = "Created:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.label4.Location = new System.Drawing.Point(8, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "Solution: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.label2.Location = new System.Drawing.Point(4, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Ticket ID: ";
            // 
            // MyTicketsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(125)))), ((int)(((byte)(106)))));
            this.Controls.Add(this.pnlMonitor);
            this.Controls.Add(this.lstTickets);
            this.Name = "MyTicketsControl";
            this.Size = new System.Drawing.Size(1329, 761);
            //this.Load += new System.EventHandler(this.MyTicketsControl_Load);
            this.pnlMonitor.ResumeLayout(false);
            this.pnlMonitor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstTickets;
        private System.Windows.Forms.Panel pnlMonitor;
        private System.Windows.Forms.TextBox txtUpdatedDate;
        private System.Windows.Forms.TextBox txtCreatedDate;
        private System.Windows.Forms.TextBox txtSolution;
        private System.Windows.Forms.TextBox txtTicketID;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnUpdateTicket;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
