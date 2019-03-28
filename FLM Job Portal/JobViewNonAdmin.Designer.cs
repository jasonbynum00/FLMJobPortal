namespace FLM_Job_Portal
{
    partial class JobViewNonAdmin
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
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flpEmployees = new System.Windows.Forms.FlowLayoutPanel();
            this.flpCalendar = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMonth = new System.Windows.Forms.Label();
            this.pbJobCard = new System.Windows.Forms.PictureBox();
            this.lblClock = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblJob = new System.Windows.Forms.Label();
            this.pbOutside = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbComplete = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJobCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOutside)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbComplete)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(279, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 78);
            this.label8.TabIndex = 26;
            this.label8.Text = "FINELINE\r\nMOLDS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::FLM_Job_Portal.Properties.Resources.M_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // flpEmployees
            // 
            this.flpEmployees.AutoScroll = true;
            this.flpEmployees.BackColor = System.Drawing.Color.Transparent;
            this.flpEmployees.Location = new System.Drawing.Point(13, 550);
            this.flpEmployees.Name = "flpEmployees";
            this.flpEmployees.Size = new System.Drawing.Size(761, 434);
            this.flpEmployees.TabIndex = 24;
            // 
            // flpCalendar
            // 
            this.flpCalendar.AutoScroll = true;
            this.flpCalendar.BackColor = System.Drawing.Color.DarkGray;
            this.flpCalendar.Location = new System.Drawing.Point(790, 81);
            this.flpCalendar.Name = "flpCalendar";
            this.flpCalendar.Size = new System.Drawing.Size(1099, 903);
            this.flpCalendar.TabIndex = 23;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.BackColor = System.Drawing.Color.DarkGray;
            this.lblMonth.Font = new System.Drawing.Font("Microsoft YaHei", 36F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblMonth.Location = new System.Drawing.Point(791, 18);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(226, 64);
            this.lblMonth.TabIndex = 27;
            this.lblMonth.Text = "MONTH";
            // 
            // pbJobCard
            // 
            this.pbJobCard.BackColor = System.Drawing.Color.Transparent;
            this.pbJobCard.BackgroundImage = global::FLM_Job_Portal.Properties.Resources.Job_Card1;
            this.pbJobCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbJobCard.Location = new System.Drawing.Point(247, 52);
            this.pbJobCard.Name = "pbJobCard";
            this.pbJobCard.Size = new System.Drawing.Size(129, 105);
            this.pbJobCard.TabIndex = 28;
            this.pbJobCard.TabStop = false;
            this.pbJobCard.Click += new System.EventHandler(this.pbJobCard_Click);
            this.pbJobCard.MouseEnter += new System.EventHandler(this.pbJobCard_MouseEnter);
            this.pbJobCard.MouseLeave += new System.EventHandler(this.pbJobCard_MouseLeave);
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.BackColor = System.Drawing.Color.Transparent;
            this.lblClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.ForeColor = System.Drawing.Color.LightYellow;
            this.lblClock.Location = new System.Drawing.Point(1309, 24);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(132, 46);
            this.lblClock.TabIndex = 31;
            this.lblClock.Text = "label2";
            this.lblClock.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1695, 31);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(194, 44);
            this.btnExit.TabIndex = 32;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.BackColor = System.Drawing.Color.Transparent;
            this.lblJob.Font = new System.Drawing.Font("Microsoft YaHei", 36F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJob.ForeColor = System.Drawing.Color.LightYellow;
            this.lblJob.Location = new System.Drawing.Point(12, 161);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(168, 64);
            this.lblJob.TabIndex = 33;
            this.lblJob.Text = "JOB #";
            // 
            // pbOutside
            // 
            this.pbOutside.BackColor = System.Drawing.Color.Transparent;
            this.pbOutside.BackgroundImage = global::FLM_Job_Portal.Properties.Resources.Outside1;
            this.pbOutside.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbOutside.Location = new System.Drawing.Point(32, 52);
            this.pbOutside.Name = "pbOutside";
            this.pbOutside.Size = new System.Drawing.Size(129, 105);
            this.pbOutside.TabIndex = 34;
            this.pbOutside.TabStop = false;
            this.pbOutside.Click += new System.EventHandler(this.pbOutside_Click);
            this.pbOutside.MouseEnter += new System.EventHandler(this.pbOutside_MouseEnter);
            this.pbOutside.MouseLeave += new System.EventHandler(this.pbOutside_MouseLeave);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pbComplete);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.pbOutside);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.pbJobCard);
            this.groupBox1.Location = new System.Drawing.Point(23, 272);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(631, 181);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "JOB DETAILS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(450, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 26);
            this.label2.TabIndex = 41;
            this.label2.Text = "FINISH WORK";
            // 
            // pbComplete
            // 
            this.pbComplete.BackColor = System.Drawing.Color.Transparent;
            this.pbComplete.BackgroundImage = global::FLM_Job_Portal.Properties.Resources.complete1;
            this.pbComplete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbComplete.Location = new System.Drawing.Point(456, 52);
            this.pbComplete.Name = "pbComplete";
            this.pbComplete.Size = new System.Drawing.Size(129, 105);
            this.pbComplete.TabIndex = 40;
            this.pbComplete.TabStop = false;
            this.pbComplete.Click += new System.EventHandler(this.pbComplete_Click);
            this.pbComplete.MouseEnter += new System.EventHandler(this.pbComplete_MouseEnter);
            this.pbComplete.MouseLeave += new System.EventHandler(this.pbComplete_MouseLeave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(45, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 26);
            this.label6.TabIndex = 39;
            this.label6.Text = "ORDERING";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(255, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 26);
            this.label7.TabIndex = 35;
            this.label7.Text = "JOB CARD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 36F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightYellow;
            this.label1.Location = new System.Drawing.Point(12, 483);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 64);
            this.label1.TabIndex = 42;
            this.label1.Text = "WORK LIST";
            // 
            // JobViewNonAdmin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.BackgroundImage = global::FLM_Job_Portal.Properties.Resources.Program_Background;
            this.ClientSize = new System.Drawing.Size(1904, 1013);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblJob);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblClock);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flpEmployees);
            this.Controls.Add(this.flpCalendar);
            this.Controls.Add(this.lblMonth);
            this.Name = "JobViewNonAdmin";
            this.Text = "JOB VIEW";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJobCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOutside)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbComplete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flpEmployees;
        private System.Windows.Forms.FlowLayoutPanel flpCalendar;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.PictureBox pbJobCard;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.PictureBox pbOutside;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbComplete;
    }
}