namespace FLM_Job_Portal
{
    partial class Home
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picRefresh = new System.Windows.Forms.PictureBox();
            this.picAddJob = new System.Windows.Forms.PictureBox();
            this.picDeleteJob = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmboEditor = new System.Windows.Forms.ComboBox();
            this.btnDetailEdit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDown = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmboPriority = new System.Windows.Forms.ComboBox();
            this.btnUp = new System.Windows.Forms.Button();
            this.pbSendRecords = new System.Windows.Forms.PictureBox();
            this.pbStatusUpdate = new System.Windows.Forms.PictureBox();
            this.pnlJobBoard = new System.Windows.Forms.Panel();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.gbDueDate = new System.Windows.Forms.GroupBox();
            this.gbCustomer = new System.Windows.Forms.GroupBox();
            this.gbJobNumber = new System.Windows.Forms.GroupBox();
            this.flpJobNum = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddJob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDeleteJob)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSendRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatusUpdate)).BeginInit();
            this.pnlJobBoard.SuspendLayout();
            this.gbJobNumber.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::FLM_Job_Portal.Properties.Resources.M_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // picRefresh
            // 
            this.picRefresh.BackColor = System.Drawing.Color.Transparent;
            this.picRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRefresh.Image = global::FLM_Job_Portal.Properties.Resources.refresh1;
            this.picRefresh.Location = new System.Drawing.Point(103, 202);
            this.picRefresh.Name = "picRefresh";
            this.picRefresh.Size = new System.Drawing.Size(155, 148);
            this.picRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRefresh.TabIndex = 1;
            this.picRefresh.TabStop = false;
            this.picRefresh.Click += new System.EventHandler(this.picRefresh_Click);
            this.picRefresh.MouseEnter += new System.EventHandler(this.picRefresh_MouseEnter);
            this.picRefresh.MouseLeave += new System.EventHandler(this.picRefresh_MouseLeave);
            // 
            // picAddJob
            // 
            this.picAddJob.BackColor = System.Drawing.Color.Transparent;
            this.picAddJob.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAddJob.Image = global::FLM_Job_Portal.Properties.Resources.Add_Job;
            this.picAddJob.Location = new System.Drawing.Point(24, 364);
            this.picAddJob.Name = "picAddJob";
            this.picAddJob.Size = new System.Drawing.Size(138, 127);
            this.picAddJob.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAddJob.TabIndex = 2;
            this.picAddJob.TabStop = false;
            this.picAddJob.Click += new System.EventHandler(this.picAddJob_Click);
            this.picAddJob.MouseEnter += new System.EventHandler(this.picAddJob_MouseEnter);
            this.picAddJob.MouseLeave += new System.EventHandler(this.picAddJob_MouseLeave);
            // 
            // picDeleteJob
            // 
            this.picDeleteJob.BackColor = System.Drawing.Color.Transparent;
            this.picDeleteJob.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDeleteJob.Image = global::FLM_Job_Portal.Properties.Resources.Delete_Job;
            this.picDeleteJob.Location = new System.Drawing.Point(212, 364);
            this.picDeleteJob.Name = "picDeleteJob";
            this.picDeleteJob.Size = new System.Drawing.Size(138, 127);
            this.picDeleteJob.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDeleteJob.TabIndex = 3;
            this.picDeleteJob.TabStop = false;
            this.picDeleteJob.Click += new System.EventHandler(this.picDeleteJob_Click);
            this.picDeleteJob.MouseEnter += new System.EventHandler(this.picDeleteJob_MouseEnter);
            this.picDeleteJob.MouseLeave += new System.EventHandler(this.picDeleteJob_MouseLeave);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmboEditor);
            this.groupBox1.Controls.Add(this.btnDetailEdit);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(24, 502);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 148);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "JOB EDITOR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "SELECT JOB:";
            // 
            // cmboEditor
            // 
            this.cmboEditor.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboEditor.FormattingEnabled = true;
            this.cmboEditor.Location = new System.Drawing.Point(15, 58);
            this.cmboEditor.Name = "cmboEditor";
            this.cmboEditor.Size = new System.Drawing.Size(133, 30);
            this.cmboEditor.TabIndex = 1;
            // 
            // btnDetailEdit
            // 
            this.btnDetailEdit.BackColor = System.Drawing.Color.Teal;
            this.btnDetailEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDetailEdit.Location = new System.Drawing.Point(15, 98);
            this.btnDetailEdit.Name = "btnDetailEdit";
            this.btnDetailEdit.Size = new System.Drawing.Size(292, 34);
            this.btnDetailEdit.TabIndex = 0;
            this.btnDetailEdit.Text = "EDIT DETAILS";
            this.btnDetailEdit.UseVisualStyleBackColor = false;
            this.btnDetailEdit.Click += new System.EventHandler(this.btnDetailEdit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnDown);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmboPriority);
            this.groupBox2.Controls.Add(this.btnUp);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(24, 665);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 152);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PRIORITY SHIFT";
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDown.Location = new System.Drawing.Point(20, 98);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(119, 34);
            this.btnDown.TabIndex = 3;
            this.btnDown.Text = "DOWN";
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "SELECT JOB:";
            // 
            // cmboPriority
            // 
            this.cmboPriority.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboPriority.FormattingEnabled = true;
            this.cmboPriority.Location = new System.Drawing.Point(101, 57);
            this.cmboPriority.Name = "cmboPriority";
            this.cmboPriority.Size = new System.Drawing.Size(133, 30);
            this.cmboPriority.TabIndex = 1;
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.DarkRed;
            this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUp.Location = new System.Drawing.Point(188, 98);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(119, 34);
            this.btnUp.TabIndex = 0;
            this.btnUp.Text = "UP";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // pbSendRecords
            // 
            this.pbSendRecords.BackColor = System.Drawing.Color.Transparent;
            this.pbSendRecords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSendRecords.Image = global::FLM_Job_Portal.Properties.Resources.Records;
            this.pbSendRecords.Location = new System.Drawing.Point(24, 864);
            this.pbSendRecords.Name = "pbSendRecords";
            this.pbSendRecords.Size = new System.Drawing.Size(138, 98);
            this.pbSendRecords.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSendRecords.TabIndex = 6;
            this.pbSendRecords.TabStop = false;
            this.pbSendRecords.Click += new System.EventHandler(this.pbSendRecords_Click);
            this.pbSendRecords.MouseEnter += new System.EventHandler(this.pbSendRecords_MouseEnter);
            this.pbSendRecords.MouseLeave += new System.EventHandler(this.pbSendRecords_MouseLeave);
            // 
            // pbStatusUpdate
            // 
            this.pbStatusUpdate.BackColor = System.Drawing.Color.Transparent;
            this.pbStatusUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbStatusUpdate.Image = global::FLM_Job_Portal.Properties.Resources.Status1;
            this.pbStatusUpdate.Location = new System.Drawing.Point(171, 864);
            this.pbStatusUpdate.Name = "pbStatusUpdate";
            this.pbStatusUpdate.Size = new System.Drawing.Size(182, 98);
            this.pbStatusUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStatusUpdate.TabIndex = 7;
            this.pbStatusUpdate.TabStop = false;
            this.pbStatusUpdate.Click += new System.EventHandler(this.pbStatusUpdate_Click);
            this.pbStatusUpdate.MouseEnter += new System.EventHandler(this.pbStatusUpdate_MouseEnter);
            this.pbStatusUpdate.MouseLeave += new System.EventHandler(this.pbStatusUpdate_MouseLeave);
            // 
            // pnlJobBoard
            // 
            this.pnlJobBoard.AutoScroll = true;
            this.pnlJobBoard.BackColor = System.Drawing.Color.DarkGray;
            this.pnlJobBoard.Controls.Add(this.gbStatus);
            this.pnlJobBoard.Controls.Add(this.gbDueDate);
            this.pnlJobBoard.Controls.Add(this.gbCustomer);
            this.pnlJobBoard.Controls.Add(this.gbJobNumber);
            this.pnlJobBoard.ForeColor = System.Drawing.Color.White;
            this.pnlJobBoard.Location = new System.Drawing.Point(375, 181);
            this.pnlJobBoard.Name = "pnlJobBoard";
            this.pnlJobBoard.Size = new System.Drawing.Size(991, 848);
            this.pnlJobBoard.TabIndex = 8;
            // 
            // gbStatus
            // 
            this.gbStatus.BackColor = System.Drawing.Color.DarkGray;
            this.gbStatus.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStatus.Location = new System.Drawing.Point(757, 0);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(208, 1629);
            this.gbStatus.TabIndex = 2;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "STATUS";
            this.gbStatus.UseCompatibleTextRendering = true;
            // 
            // gbDueDate
            // 
            this.gbDueDate.BackColor = System.Drawing.Color.DarkGray;
            this.gbDueDate.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDueDate.Location = new System.Drawing.Point(531, 0);
            this.gbDueDate.Name = "gbDueDate";
            this.gbDueDate.Size = new System.Drawing.Size(220, 1629);
            this.gbDueDate.TabIndex = 1;
            this.gbDueDate.TabStop = false;
            this.gbDueDate.Text = "DUE DATE";
            // 
            // gbCustomer
            // 
            this.gbCustomer.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCustomer.Location = new System.Drawing.Point(209, 0);
            this.gbCustomer.Name = "gbCustomer";
            this.gbCustomer.Size = new System.Drawing.Size(316, 1629);
            this.gbCustomer.TabIndex = 0;
            this.gbCustomer.TabStop = false;
            this.gbCustomer.Text = "CUSTOMER";
            // 
            // gbJobNumber
            // 
            this.gbJobNumber.Controls.Add(this.flpJobNum);
            this.gbJobNumber.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbJobNumber.Location = new System.Drawing.Point(3, 0);
            this.gbJobNumber.Name = "gbJobNumber";
            this.gbJobNumber.Size = new System.Drawing.Size(200, 1629);
            this.gbJobNumber.TabIndex = 0;
            this.gbJobNumber.TabStop = false;
            this.gbJobNumber.Text = "JOB #";
            // 
            // flpJobNum
            // 
            this.flpJobNum.Location = new System.Drawing.Point(6, 41);
            this.flpJobNum.Name = "flpJobNum";
            this.flpJobNum.Size = new System.Drawing.Size(188, 1577);
            this.flpJobNum.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(130, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "REFRESH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(36, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "ADD JOB";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(214, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 28);
            this.label5.TabIndex = 10;
            this.label5.Text = "DELETE JOB";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(8, 839);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "SEND TO RECORDS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(188, 840);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 22);
            this.label7.TabIndex = 12;
            this.label7.Text = "UPDATE STATUS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(283, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 78);
            this.label8.TabIndex = 13;
            this.label8.Text = "FINELINE\r\nMOLDS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label9.Location = new System.Drawing.Point(1158, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(208, 128);
            this.label9.TabIndex = 14;
            this.label9.Text = "JOB\r\nBOARD";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(24, 994);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(329, 35);
            this.btnExit.TabIndex = 38;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.LightYellow;
            this.lblWelcome.Location = new System.Drawing.Point(422, 137);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(305, 50);
            this.lblWelcome.TabIndex = 40;
            this.lblWelcome.Text = "Welcome Back ";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::FLM_Job_Portal.Properties.Resources.Program_Background;
            this.ClientSize = new System.Drawing.Size(1428, 1041);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnlJobBoard);
            this.Controls.Add(this.pbStatusUpdate);
            this.Controls.Add(this.pbSendRecords);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picDeleteJob);
            this.Controls.Add(this.picAddJob);
            this.Controls.Add(this.picRefresh);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblWelcome);
            this.Name = "Home";
            this.Text = "HOME";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddJob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDeleteJob)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSendRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatusUpdate)).EndInit();
            this.pnlJobBoard.ResumeLayout(false);
            this.gbJobNumber.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picRefresh;
        private System.Windows.Forms.PictureBox picAddJob;
        private System.Windows.Forms.PictureBox picDeleteJob;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmboEditor;
        private System.Windows.Forms.Button btnDetailEdit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmboPriority;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.PictureBox pbSendRecords;
        private System.Windows.Forms.PictureBox pbStatusUpdate;
        private System.Windows.Forms.Panel pnlJobBoard;
        private System.Windows.Forms.GroupBox gbJobNumber;
        private System.Windows.Forms.FlowLayoutPanel flpJobNum;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.GroupBox gbDueDate;
        private System.Windows.Forms.GroupBox gbCustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblWelcome;
    }
}

