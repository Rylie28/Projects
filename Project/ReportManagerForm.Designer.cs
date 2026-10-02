namespace real_loginForm
{
    partial class ReportManagerForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.monitorTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstTickets = new System.Windows.Forms.ListBox();
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.pnlMonitor = new System.Windows.Forms.Panel();
            this.txtAssigned = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSolution = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPriority = new System.Windows.Forms.TextBox();
            this.txtUpdatedDate = new System.Windows.Forms.TextBox();
            this.txtCreatedDate = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtTicketID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlAssign = new System.Windows.Forms.Panel();
            this.txtSelectedUser = new System.Windows.Forms.TextBox();
            this.btnAssignTicket = new System.Windows.Forms.Button();
            this.cbxPriority = new System.Windows.Forms.ComboBox();
            this.btnPriority = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.pnlMonitor.SuspendLayout();
            this.pnlAssign.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.AutoSize = true;
            this.welcomeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.welcomeLbl.Location = new System.Drawing.Point(330, 14);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(765, 64);
            this.welcomeLbl.TabIndex = 0;
            this.welcomeLbl.Text = "Welcome, Report Managers!\r\n";
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(189)))), ((int)(((byte)(152)))));
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(83)))), ((int)(((byte)(76)))));
            this.backBtn.Location = new System.Drawing.Point(1334, 785);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(134, 92);
            this.backBtn.TabIndex = 16;
            this.backBtn.Text = "Return to Login";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(83)))), ((int)(((byte)(76)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.monitorTicketToolStripMenuItem,
            this.assignTicketToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(148, 925);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // monitorTicketToolStripMenuItem
            // 
            this.monitorTicketToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(83)))), ((int)(((byte)(76)))));
            this.monitorTicketToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(214)))));
            this.monitorTicketToolStripMenuItem.Name = "monitorTicketToolStripMenuItem";
            this.monitorTicketToolStripMenuItem.Size = new System.Drawing.Size(135, 29);
            this.monitorTicketToolStripMenuItem.Text = "Monitor Ticket";
            this.monitorTicketToolStripMenuItem.Click += new System.EventHandler(this.monitorTicketToolStripMenuItem_Click);
            // 
            // assignTicketToolStripMenuItem
            // 
            this.assignTicketToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(83)))), ((int)(((byte)(76)))));
            this.assignTicketToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(214)))));
            this.assignTicketToolStripMenuItem.Name = "assignTicketToolStripMenuItem";
            this.assignTicketToolStripMenuItem.Size = new System.Drawing.Size(135, 29);
            this.assignTicketToolStripMenuItem.Text = "Assign Ticket";
            this.assignTicketToolStripMenuItem.Click += new System.EventHandler(this.assignTicketToolStripMenuItem_Click);
            // 
            // lstTickets
            // 
            this.lstTickets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(214)))));
            this.lstTickets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(83)))), ((int)(((byte)(76)))));
            this.lstTickets.FormattingEnabled = true;
            this.lstTickets.HorizontalScrollbar = true;
            this.lstTickets.ItemHeight = 20;
            this.lstTickets.Location = new System.Drawing.Point(196, 120);
            this.lstTickets.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstTickets.Name = "lstTickets";
            this.lstTickets.Size = new System.Drawing.Size(430, 264);
            this.lstTickets.TabIndex = 18;
            this.lstTickets.Visible = false;
            this.lstTickets.SelectedIndexChanged += new System.EventHandler(this.lstTickets_SelectedIndexChanged);
            // 
            // lstUsers
            // 
            this.lstUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(214)))));
            this.lstUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(83)))), ((int)(((byte)(76)))));
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.HorizontalScrollbar = true;
            this.lstUsers.ItemHeight = 20;
            this.lstUsers.Location = new System.Drawing.Point(196, 511);
            this.lstUsers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(430, 244);
            this.lstUsers.TabIndex = 33;
            this.lstUsers.Visible = false;
            this.lstUsers.SelectedIndexChanged += new System.EventHandler(this.lstUsers_SelectedIndexChanged);
            // 
            // pnlMonitor
            // 
            this.pnlMonitor.Controls.Add(this.txtAssigned);
            this.pnlMonitor.Controls.Add(this.label10);
            this.pnlMonitor.Controls.Add(this.txtSolution);
            this.pnlMonitor.Controls.Add(this.label9);
            this.pnlMonitor.Controls.Add(this.txtDescription);
            this.pnlMonitor.Controls.Add(this.txtUser);
            this.pnlMonitor.Controls.Add(this.txtPriority);
            this.pnlMonitor.Controls.Add(this.txtUpdatedDate);
            this.pnlMonitor.Controls.Add(this.txtCreatedDate);
            this.pnlMonitor.Controls.Add(this.txtStatus);
            this.pnlMonitor.Controls.Add(this.txtTicketID);
            this.pnlMonitor.Controls.Add(this.label7);
            this.pnlMonitor.Controls.Add(this.label6);
            this.pnlMonitor.Controls.Add(this.label5);
            this.pnlMonitor.Controls.Add(this.label4);
            this.pnlMonitor.Controls.Add(this.label3);
            this.pnlMonitor.Controls.Add(this.label2);
            this.pnlMonitor.Controls.Add(this.label1);
            this.pnlMonitor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.pnlMonitor.Location = new System.Drawing.Point(716, 120);
            this.pnlMonitor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlMonitor.Name = "pnlMonitor";
            this.pnlMonitor.Size = new System.Drawing.Size(801, 382);
            this.pnlMonitor.TabIndex = 36;
            this.pnlMonitor.Visible = false;
            // 
            // txtAssigned
            // 
            this.txtAssigned.Location = new System.Drawing.Point(567, 26);
            this.txtAssigned.Multiline = true;
            this.txtAssigned.Name = "txtAssigned";
            this.txtAssigned.ReadOnly = true;
            this.txtAssigned.Size = new System.Drawing.Size(134, 72);
            this.txtAssigned.TabIndex = 55;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(464, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 20);
            this.label10.TabIndex = 54;
            this.label10.Text = "Assigned IT:";
            // 
            // txtSolution
            // 
            this.txtSolution.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(214)))));
            this.txtSolution.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(83)))), ((int)(((byte)(76)))));
            this.txtSolution.Location = new System.Drawing.Point(100, 280);
            this.txtSolution.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSolution.Multiline = true;
            this.txtSolution.Name = "txtSolution";
            this.txtSolution.ReadOnly = true;
            this.txtSolution.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSolution.Size = new System.Drawing.Size(338, 95);
            this.txtSolution.TabIndex = 53;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 285);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 20);
            this.label9.TabIndex = 52;
            this.label9.Text = "Solution:";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(214)))));
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(83)))), ((int)(((byte)(76)))));
            this.txtDescription.Location = new System.Drawing.Point(100, 40);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(338, 26);
            this.txtDescription.TabIndex = 51;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(214)))));
            this.txtUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(83)))), ((int)(((byte)(76)))));
            this.txtUser.Location = new System.Drawing.Point(100, 240);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = true;
            this.txtUser.Size = new System.Drawing.Size(338, 26);
            this.txtUser.TabIndex = 50;
            // 
            // txtPriority
            // 
            this.txtPriority.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(214)))));
            this.txtPriority.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(83)))), ((int)(((byte)(76)))));
            this.txtPriority.Location = new System.Drawing.Point(100, 200);
            this.txtPriority.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPriority.Name = "txtPriority";
            this.txtPriority.ReadOnly = true;
            this.txtPriority.Size = new System.Drawing.Size(338, 26);
            this.txtPriority.TabIndex = 49;
            // 
            // txtUpdatedDate
            // 
            this.txtUpdatedDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(214)))));
            this.txtUpdatedDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(83)))), ((int)(((byte)(76)))));
            this.txtUpdatedDate.Location = new System.Drawing.Point(100, 160);
            this.txtUpdatedDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUpdatedDate.Name = "txtUpdatedDate";
            this.txtUpdatedDate.ReadOnly = true;
            this.txtUpdatedDate.Size = new System.Drawing.Size(338, 26);
            this.txtUpdatedDate.TabIndex = 48;
            // 
            // txtCreatedDate
            // 
            this.txtCreatedDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(214)))));
            this.txtCreatedDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(83)))), ((int)(((byte)(76)))));
            this.txtCreatedDate.Location = new System.Drawing.Point(100, 120);
            this.txtCreatedDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCreatedDate.Name = "txtCreatedDate";
            this.txtCreatedDate.ReadOnly = true;
            this.txtCreatedDate.Size = new System.Drawing.Size(338, 26);
            this.txtCreatedDate.TabIndex = 47;
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(214)))));
            this.txtStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(83)))), ((int)(((byte)(76)))));
            this.txtStatus.Location = new System.Drawing.Point(100, 80);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(338, 26);
            this.txtStatus.TabIndex = 46;
            // 
            // txtTicketID
            // 
            this.txtTicketID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(214)))));
            this.txtTicketID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(83)))), ((int)(((byte)(76)))));
            this.txtTicketID.Location = new System.Drawing.Point(100, 0);
            this.txtTicketID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTicketID.Name = "txtTicketID";
            this.txtTicketID.ReadOnly = true;
            this.txtTicketID.Size = new System.Drawing.Size(64, 26);
            this.txtTicketID.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
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
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Ticket ID: ";
            // 
            // pnlAssign
            // 
            this.pnlAssign.Controls.Add(this.txtSelectedUser);
            this.pnlAssign.Controls.Add(this.btnAssignTicket);
            this.pnlAssign.Controls.Add(this.cbxPriority);
            this.pnlAssign.Controls.Add(this.btnPriority);
            this.pnlAssign.Controls.Add(this.label8);
            this.pnlAssign.Location = new System.Drawing.Point(716, 511);
            this.pnlAssign.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlAssign.Name = "pnlAssign";
            this.pnlAssign.Size = new System.Drawing.Size(742, 223);
            this.pnlAssign.TabIndex = 42;
            this.pnlAssign.Visible = false;
            // 
            // txtSelectedUser
            // 
            this.txtSelectedUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(214)))));
            this.txtSelectedUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(83)))), ((int)(((byte)(76)))));
            this.txtSelectedUser.Location = new System.Drawing.Point(51, 43);
            this.txtSelectedUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSelectedUser.Name = "txtSelectedUser";
            this.txtSelectedUser.Size = new System.Drawing.Size(199, 26);
            this.txtSelectedUser.TabIndex = 48;
            // 
            // btnAssignTicket
            // 
            this.btnAssignTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(83)))), ((int)(((byte)(76)))));
            this.btnAssignTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssignTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignTicket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(214)))));
            this.btnAssignTicket.Location = new System.Drawing.Point(51, 97);
            this.btnAssignTicket.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAssignTicket.Name = "btnAssignTicket";
            this.btnAssignTicket.Size = new System.Drawing.Size(201, 35);
            this.btnAssignTicket.TabIndex = 47;
            this.btnAssignTicket.Text = "Assign Ticket";
            this.btnAssignTicket.UseVisualStyleBackColor = true;
            this.btnAssignTicket.Click += new System.EventHandler(this.btnAssignTicket_Click);
            // 
            // cbxPriority
            // 
            this.cbxPriority.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(214)))));
            this.cbxPriority.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(83)))), ((int)(((byte)(76)))));
            this.cbxPriority.FormattingEnabled = true;
            this.cbxPriority.Items.AddRange(new object[] {
            "Emergency Code Red",
            "High Priority",
            "Medium Priority",
            "Low Priority"});
            this.cbxPriority.Location = new System.Drawing.Point(318, 43);
            this.cbxPriority.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxPriority.Name = "cbxPriority";
            this.cbxPriority.Size = new System.Drawing.Size(186, 28);
            this.cbxPriority.TabIndex = 46;
            // 
            // btnPriority
            // 
            this.btnPriority.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(83)))), ((int)(((byte)(76)))));
            this.btnPriority.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPriority.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPriority.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(214)))));
            this.btnPriority.Location = new System.Drawing.Point(318, 97);
            this.btnPriority.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPriority.Name = "btnPriority";
            this.btnPriority.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnPriority.Size = new System.Drawing.Size(188, 35);
            this.btnPriority.TabIndex = 45;
            this.btnPriority.Text = "Set Priority";
            this.btnPriority.UseVisualStyleBackColor = false;
            this.btnPriority.Click += new System.EventHandler(this.btnPriority_Click);
            // 
            // label8
            // 
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label8.Location = new System.Drawing.Point(21, 137);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(252, 74);
            this.label8.TabIndex = 42;
            this.label8.Text = "To assign IT members, please select the ticket and the user and click assign";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // flowLayoutPanel1
            // 
            //this.flowLayoutPanel1.BackgroundImage = global::real_loginForm.Properties.Resources.GreenLogo;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(158, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(88, 88);
            this.flowLayoutPanel1.TabIndex = 43;
            // 
            // ReportManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(125)))), ((int)(((byte)(106)))));
            this.ClientSize = new System.Drawing.Size(1516, 925);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pnlAssign);
            this.Controls.Add(this.pnlMonitor);
            this.Controls.Add(this.lstUsers);
            this.Controls.Add(this.lstTickets);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.welcomeLbl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ReportManagerForm";
            this.Text = "Report Manager - Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlMonitor.ResumeLayout(false);
            this.pnlMonitor.PerformLayout();
            this.pnlAssign.ResumeLayout(false);
            this.pnlAssign.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLbl;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem monitorTicketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignTicketToolStripMenuItem;
        private System.Windows.Forms.ListBox lstTickets;
        private System.Windows.Forms.ListBox lstUsers;
        private System.Windows.Forms.Panel pnlMonitor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPriority;
        private System.Windows.Forms.TextBox txtUpdatedDate;
        private System.Windows.Forms.TextBox txtCreatedDate;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtTicketID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlAssign;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxPriority;
        private System.Windows.Forms.Button btnPriority;
        private System.Windows.Forms.TextBox txtSelectedUser;
        private System.Windows.Forms.Button btnAssignTicket;
        private System.Windows.Forms.TextBox txtSolution;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAssigned;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}