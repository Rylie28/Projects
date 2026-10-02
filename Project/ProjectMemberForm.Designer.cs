namespace real_loginForm
{
    partial class ProjectMemberForm
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
            this.savedTicketsBtn = new System.Windows.Forms.Button();
            this.accessLbl = new System.Windows.Forms.Label();
            this.existingTicketsBtn = new System.Windows.Forms.Button();
            this.onlineHelpBtn = new System.Windows.Forms.Button();
            this.raiseBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.lstTickets = new System.Windows.Forms.ListBox();
            this.pnlMonitor = new System.Windows.Forms.Panel();
            this.txtPriority = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtUpdatedDate = new System.Windows.Forms.ListBox();
            this.txtCreatedDate = new System.Windows.Forms.ListBox();
            this.txtUser = new System.Windows.Forms.ListBox();
            this.txtStatus = new System.Windows.Forms.ListBox();
            this.txtTicketID = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnReOpen = new System.Windows.Forms.Button();
            this.btnSolution = new System.Windows.Forms.Button();
            //this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlMonitor.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.welcomeLbl.AutoSize = true;
            this.welcomeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.welcomeLbl.Location = new System.Drawing.Point(96, 22);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(757, 64);
            this.welcomeLbl.TabIndex = 2;
            this.welcomeLbl.Text = "Welcome, Project Members!\r\n";
            // 
            // savedTicketsBtn
            // 
            this.savedTicketsBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.savedTicketsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(83)))), ((int)(((byte)(76)))));
            this.savedTicketsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savedTicketsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savedTicketsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savedTicketsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(214)))));
            this.savedTicketsBtn.Location = new System.Drawing.Point(988, 97);
            this.savedTicketsBtn.Name = "savedTicketsBtn";
            this.savedTicketsBtn.Size = new System.Drawing.Size(399, 49);
            this.savedTicketsBtn.TabIndex = 3;
            this.savedTicketsBtn.Text = "All Tickets";
            this.savedTicketsBtn.UseVisualStyleBackColor = false;
            this.savedTicketsBtn.Click += new System.EventHandler(this.savedTicketsBtn_Click);
            // 
            // accessLbl
            // 
            this.accessLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.accessLbl.AutoSize = true;
            this.accessLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accessLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.accessLbl.Location = new System.Drawing.Point(139, 107);
            this.accessLbl.Name = "accessLbl";
            this.accessLbl.Size = new System.Drawing.Size(209, 37);
            this.accessLbl.TabIndex = 4;
            this.accessLbl.Text = "Click to View:";
            // 
            // existingTicketsBtn
            // 
            this.existingTicketsBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.existingTicketsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(83)))), ((int)(((byte)(76)))));
            this.existingTicketsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.existingTicketsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.existingTicketsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.existingTicketsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(214)))));
            this.existingTicketsBtn.Location = new System.Drawing.Point(346, 97);
            this.existingTicketsBtn.Name = "existingTicketsBtn";
            this.existingTicketsBtn.Size = new System.Drawing.Size(434, 49);
            this.existingTicketsBtn.TabIndex = 8;
            this.existingTicketsBtn.Text = "My Existing Tickets";
            this.existingTicketsBtn.UseVisualStyleBackColor = false;
            this.existingTicketsBtn.Click += new System.EventHandler(this.existingTicketsBtn_Click);
            // 
            // onlineHelpBtn
            // 
            this.onlineHelpBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.onlineHelpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(83)))), ((int)(((byte)(76)))));
            this.onlineHelpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.onlineHelpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.onlineHelpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlineHelpBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(214)))));
            this.onlineHelpBtn.Location = new System.Drawing.Point(785, 97);
            this.onlineHelpBtn.Name = "onlineHelpBtn";
            this.onlineHelpBtn.Size = new System.Drawing.Size(196, 49);
            this.onlineHelpBtn.TabIndex = 9;
            this.onlineHelpBtn.Text = "ONLINE HELP";
            this.onlineHelpBtn.UseVisualStyleBackColor = false;
            this.onlineHelpBtn.Click += new System.EventHandler(this.onlineHelpBtn_Click);
            // 
            // raiseBtn
            // 
            this.raiseBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.raiseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(83)))), ((int)(((byte)(76)))));
            this.raiseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.raiseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.raiseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raiseBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(230)))), ((int)(((byte)(214)))));
            this.raiseBtn.Location = new System.Drawing.Point(615, 485);
            this.raiseBtn.Name = "raiseBtn";
            this.raiseBtn.Size = new System.Drawing.Size(262, 92);
            this.raiseBtn.TabIndex = 11;
            this.raiseBtn.Text = "Raise Ticket";
            this.raiseBtn.UseVisualStyleBackColor = false;
            this.raiseBtn.Click += new System.EventHandler(this.raiseBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(189)))), ((int)(((byte)(152)))));
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(1179, 485);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(202, 114);
            this.backBtn.TabIndex = 15;
            this.backBtn.Text = "Return to Login";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // lstTickets
            // 
            this.lstTickets.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lstTickets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(214)))));
            this.lstTickets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(83)))), ((int)(((byte)(76)))));
            this.lstTickets.FormattingEnabled = true;
            this.lstTickets.ItemHeight = 20;
            this.lstTickets.Location = new System.Drawing.Point(106, 172);
            this.lstTickets.Name = "lstTickets";
            this.lstTickets.Size = new System.Drawing.Size(1274, 304);
            this.lstTickets.TabIndex = 16;
            this.lstTickets.SelectedIndexChanged += new System.EventHandler(this.lstTickets_SelectedIndexChanged);
            // 
            // pnlMonitor
            // 
            this.pnlMonitor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlMonitor.Controls.Add(this.txtPriority);
            this.pnlMonitor.Controls.Add(this.txtDescription);
            this.pnlMonitor.Controls.Add(this.txtUpdatedDate);
            this.pnlMonitor.Controls.Add(this.txtCreatedDate);
            this.pnlMonitor.Controls.Add(this.txtUser);
            this.pnlMonitor.Controls.Add(this.txtStatus);
            this.pnlMonitor.Controls.Add(this.txtTicketID);
            this.pnlMonitor.Controls.Add(this.label7);
            this.pnlMonitor.Controls.Add(this.label6);
            this.pnlMonitor.Controls.Add(this.label5);
            this.pnlMonitor.Controls.Add(this.label4);
            this.pnlMonitor.Controls.Add(this.label3);
            this.pnlMonitor.Controls.Add(this.label2);
            this.pnlMonitor.Controls.Add(this.label1);
            this.pnlMonitor.Location = new System.Drawing.Point(106, 485);
            this.pnlMonitor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlMonitor.Name = "pnlMonitor";
            this.pnlMonitor.Size = new System.Drawing.Size(476, 294);
            this.pnlMonitor.TabIndex = 37;
            // 
            // txtPriority
            // 
            this.txtPriority.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(189)))), ((int)(((byte)(152)))));
            this.txtPriority.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(83)))), ((int)(((byte)(76)))));
            this.txtPriority.FormattingEnabled = true;
            this.txtPriority.Items.AddRange(new object[] {
            "Emergency Code Red",
            "High Priority",
            "Medium Priority",
            "Low Priority"});
            this.txtPriority.Location = new System.Drawing.Point(100, 200);
            this.txtPriority.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPriority.Name = "txtPriority";
            this.txtPriority.Size = new System.Drawing.Size(338, 28);
            this.txtPriority.TabIndex = 60;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(189)))), ((int)(((byte)(152)))));
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(83)))), ((int)(((byte)(76)))));
            this.txtDescription.Location = new System.Drawing.Point(100, 38);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(338, 26);
            this.txtDescription.TabIndex = 59;
            // 
            // txtUpdatedDate
            // 
            this.txtUpdatedDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(214)))));
            this.txtUpdatedDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(83)))), ((int)(((byte)(76)))));
            this.txtUpdatedDate.FormattingEnabled = true;
            this.txtUpdatedDate.ItemHeight = 20;
            this.txtUpdatedDate.Location = new System.Drawing.Point(100, 162);
            this.txtUpdatedDate.Name = "txtUpdatedDate";
            this.txtUpdatedDate.Size = new System.Drawing.Size(338, 24);
            this.txtUpdatedDate.TabIndex = 58;
            // 
            // txtCreatedDate
            // 
            this.txtCreatedDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(214)))));
            this.txtCreatedDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(83)))), ((int)(((byte)(76)))));
            this.txtCreatedDate.FormattingEnabled = true;
            this.txtCreatedDate.ItemHeight = 20;
            this.txtCreatedDate.Location = new System.Drawing.Point(100, 122);
            this.txtCreatedDate.Name = "txtCreatedDate";
            this.txtCreatedDate.Size = new System.Drawing.Size(338, 24);
            this.txtCreatedDate.TabIndex = 57;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(214)))));
            this.txtUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(83)))), ((int)(((byte)(76)))));
            this.txtUser.FormattingEnabled = true;
            this.txtUser.ItemHeight = 20;
            this.txtUser.Location = new System.Drawing.Point(100, 242);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(338, 24);
            this.txtUser.TabIndex = 56;
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(214)))));
            this.txtStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(83)))), ((int)(((byte)(76)))));
            this.txtStatus.FormattingEnabled = true;
            this.txtStatus.ItemHeight = 20;
            this.txtStatus.Location = new System.Drawing.Point(100, 82);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(338, 24);
            this.txtStatus.TabIndex = 55;
            // 
            // txtTicketID
            // 
            this.txtTicketID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(214)))));
            this.txtTicketID.CausesValidation = false;
            this.txtTicketID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(83)))), ((int)(((byte)(76)))));
            this.txtTicketID.FormattingEnabled = true;
            this.txtTicketID.ItemHeight = 20;
            this.txtTicketID.Location = new System.Drawing.Point(100, 5);
            this.txtTicketID.Name = "txtTicketID";
            this.txtTicketID.Size = new System.Drawing.Size(102, 24);
            this.txtTicketID.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.label7.Location = new System.Drawing.Point(4, 245);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 44;
            this.label7.Text = "Created By: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.label6.Location = new System.Drawing.Point(4, 166);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 43;
            this.label6.Text = "Updated:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.label5.Location = new System.Drawing.Point(4, 125);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 42;
            this.label5.Text = "Created:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.label4.Location = new System.Drawing.Point(4, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "Status: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.label3.Location = new System.Drawing.Point(4, 205);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "Priority:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
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
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Ticket ID: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(117, 800);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(234, 20);
            this.label8.TabIndex = 38;
            this.label8.Text = "*Only fill in the highlighted boxes";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(83)))), ((int)(((byte)(76)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(214)))));
            this.btnClear.Location = new System.Drawing.Point(615, 686);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(152, 92);
            this.btnClear.TabIndex = 39;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnReOpen
            // 
            this.btnReOpen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(83)))), ((int)(((byte)(76)))));
            this.btnReOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReOpen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(214)))));
            this.btnReOpen.Location = new System.Drawing.Point(615, 588);
            this.btnReOpen.Name = "btnReOpen";
            this.btnReOpen.Size = new System.Drawing.Size(262, 92);
            this.btnReOpen.TabIndex = 40;
            this.btnReOpen.Text = "Re-Open Ticket";
            this.btnReOpen.UseVisualStyleBackColor = false;
            this.btnReOpen.Click += new System.EventHandler(this.btnReOpen_Click);
            // 
            // btnSolution
            // 
            this.btnSolution.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSolution.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(83)))), ((int)(((byte)(76)))));
            this.btnSolution.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSolution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolution.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(214)))));
            this.btnSolution.Location = new System.Drawing.Point(897, 485);
            this.btnSolution.Name = "btnSolution";
            this.btnSolution.Size = new System.Drawing.Size(262, 92);
            this.btnSolution.TabIndex = 41;
            this.btnSolution.Text = "View Solution";
            this.btnSolution.UseVisualStyleBackColor = false;
            this.btnSolution.Click += new System.EventHandler(this.btnSolution_Click);
            // 
            // flowLayoutPanel1
            // 
            //this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            ////this.flowLayoutPanel1.BackgroundImage = global::real_loginForm.Properties.Resources.GreenLogo;
            //this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            //this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            //this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            //this.flowLayoutPanel1.Size = new System.Drawing.Size(88, 88);
            //this.flowLayoutPanel1.TabIndex = 44;
            // 
            // ProjectMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(125)))), ((int)(((byte)(106)))));
            this.ClientSize = new System.Drawing.Size(1444, 846);
            //this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnSolution);
            this.Controls.Add(this.btnReOpen);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pnlMonitor);
            this.Controls.Add(this.lstTickets);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.raiseBtn);
            this.Controls.Add(this.onlineHelpBtn);
            this.Controls.Add(this.existingTicketsBtn);
            this.Controls.Add(this.accessLbl);
            this.Controls.Add(this.savedTicketsBtn);
            this.Controls.Add(this.welcomeLbl);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(83)))), ((int)(((byte)(76)))));
            this.Name = "ProjectMemberForm";
            this.Text = "I.T. Helpdesk - Home";
            this.pnlMonitor.ResumeLayout(false);
            this.pnlMonitor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLbl;
        private System.Windows.Forms.Button savedTicketsBtn;
        private System.Windows.Forms.Label accessLbl;
        private System.Windows.Forms.Button existingTicketsBtn;
        private System.Windows.Forms.Button onlineHelpBtn;
        private System.Windows.Forms.Button raiseBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.ListBox lstTickets;
        private System.Windows.Forms.Panel pnlMonitor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox txtUser;
        private System.Windows.Forms.ListBox txtStatus;
        private System.Windows.Forms.ListBox txtTicketID;
        private System.Windows.Forms.ListBox txtUpdatedDate;
        private System.Windows.Forms.ListBox txtCreatedDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnReOpen;
        private System.Windows.Forms.Button btnSolution;
        private System.Windows.Forms.ComboBox txtPriority;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}