namespace FLM_Job_Portal
{
    partial class JobCardAdder
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
            this.lvCurrent = new System.Windows.Forms.ListView();
            this.colJob = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDept = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colComponent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHoursAllotted = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHoursSpent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNotes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmboHours = new System.Windows.Forms.ComboBox();
            this.cmboOvertime = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbNotes = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbAddLine = new System.Windows.Forms.PictureBox();
            this.cmboItem = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblJob = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbFinished = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lvCurrent
            // 
            this.lvCurrent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colJob,
            this.colItem,
            this.colDept,
            this.colComponent,
            this.colHoursAllotted,
            this.colHoursSpent,
            this.colNotes});
            this.lvCurrent.GridLines = true;
            this.lvCurrent.Location = new System.Drawing.Point(15, 264);
            this.lvCurrent.Name = "lvCurrent";
            this.lvCurrent.Size = new System.Drawing.Size(856, 297);
            this.lvCurrent.TabIndex = 0;
            this.lvCurrent.UseCompatibleStateImageBehavior = false;
            this.lvCurrent.View = System.Windows.Forms.View.Details;
            // 
            // colJob
            // 
            this.colJob.Text = "JOB";
            this.colJob.Width = 108;
            // 
            // colItem
            // 
            this.colItem.Text = "ITEM";
            this.colItem.Width = 66;
            // 
            // colDept
            // 
            this.colDept.Text = "DEPARTMENT";
            this.colDept.Width = 140;
            // 
            // colComponent
            // 
            this.colComponent.Text = "COMPONENT";
            this.colComponent.Width = 144;
            // 
            // colHoursAllotted
            // 
            this.colHoursAllotted.Text = "HRS ALLOTTED";
            this.colHoursAllotted.Width = 99;
            // 
            // colHoursSpent
            // 
            this.colHoursSpent.Text = "HRS SPENT";
            this.colHoursSpent.Width = 78;
            // 
            // colNotes
            // 
            this.colNotes.Text = "NOTES";
            this.colNotes.Width = 214;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox1.Controls.Add(this.cbFinished);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmboHours);
            this.groupBox1.Controls.Add(this.cmboOvertime);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rtbNotes);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pbAddLine);
            this.groupBox1.Controls.Add(this.cmboItem);
            this.groupBox1.Controls.Add(this.dtpDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(447, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 207);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ADD CARD";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(6, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 22);
            this.label8.TabIndex = 26;
            this.label8.Text = "Notes:";
            // 
            // cmboHours
            // 
            this.cmboHours.BackColor = System.Drawing.Color.White;
            this.cmboHours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboHours.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboHours.FormattingEnabled = true;
            this.cmboHours.Items.AddRange(new object[] {
            "0",
            ".5",
            "1",
            "1.5",
            "2",
            "2.5",
            "3",
            "3.5",
            "4",
            "4.5",
            "5",
            "5.5",
            "6",
            "6.5",
            "7",
            "7.5",
            "8",
            "8.5",
            "9",
            "9.5",
            "10",
            "10.5",
            "11",
            "11.5",
            "12",
            "12.5",
            "13",
            "13.5",
            "14",
            "14.5",
            "15"});
            this.cmboHours.Location = new System.Drawing.Point(213, 59);
            this.cmboHours.Name = "cmboHours";
            this.cmboHours.Size = new System.Drawing.Size(63, 25);
            this.cmboHours.TabIndex = 25;
            // 
            // cmboOvertime
            // 
            this.cmboOvertime.BackColor = System.Drawing.Color.White;
            this.cmboOvertime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboOvertime.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboOvertime.FormattingEnabled = true;
            this.cmboOvertime.Items.AddRange(new object[] {
            "0",
            ".5",
            "1",
            "1.5",
            "2",
            "2.5",
            "3",
            "3.5",
            "4",
            "4.5",
            "5",
            "5.5",
            "6",
            "6.5",
            "7",
            "7.5",
            "8",
            "8.5",
            "9",
            "9.5",
            "10",
            "10.5",
            "11",
            "11.5",
            "12",
            "12.5",
            "13",
            "13.5",
            "14",
            "14.5",
            "15"});
            this.cmboOvertime.Location = new System.Drawing.Point(285, 59);
            this.cmboOvertime.Name = "cmboOvertime";
            this.cmboOvertime.Size = new System.Drawing.Size(63, 25);
            this.cmboOvertime.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(281, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 22);
            this.label4.TabIndex = 24;
            this.label4.Text = "OT:";
            // 
            // rtbNotes
            // 
            this.rtbNotes.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbNotes.Location = new System.Drawing.Point(6, 116);
            this.rtbNotes.Name = "rtbNotes";
            this.rtbNotes.Size = new System.Drawing.Size(342, 70);
            this.rtbNotes.TabIndex = 22;
            this.rtbNotes.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(360, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 22);
            this.label6.TabIndex = 21;
            this.label6.Text = "ADD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(117, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 22);
            this.label1.TabIndex = 17;
            this.label1.Text = "Item:";
            // 
            // pbAddLine
            // 
            this.pbAddLine.BackColor = System.Drawing.Color.Transparent;
            this.pbAddLine.BackgroundImage = global::FLM_Job_Portal.Properties.Resources.Add_Line;
            this.pbAddLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAddLine.Location = new System.Drawing.Point(361, 135);
            this.pbAddLine.Name = "pbAddLine";
            this.pbAddLine.Size = new System.Drawing.Size(46, 43);
            this.pbAddLine.TabIndex = 16;
            this.pbAddLine.TabStop = false;
            this.pbAddLine.Click += new System.EventHandler(this.pbAddLine_Click);
            this.pbAddLine.MouseEnter += new System.EventHandler(this.pbAddLine_MouseEnter);
            this.pbAddLine.MouseLeave += new System.EventHandler(this.pbAddLine_MouseLeave);
            // 
            // cmboItem
            // 
            this.cmboItem.BackColor = System.Drawing.Color.White;
            this.cmboItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboItem.FormattingEnabled = true;
            this.cmboItem.Location = new System.Drawing.Point(121, 59);
            this.cmboItem.Name = "cmboItem";
            this.cmboItem.Size = new System.Drawing.Size(79, 25);
            this.cmboItem.TabIndex = 0;
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(6, 61);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(109, 23);
            this.dtpDate.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 22);
            this.label5.TabIndex = 20;
            this.label5.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(209, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 22);
            this.label3.TabIndex = 19;
            this.label3.Text = "Hrs:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 36);
            this.label2.TabIndex = 23;
            this.label2.Text = "CURRENT WORK";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::FLM_Job_Portal.Properties.Resources.Job_Card1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(72, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 109);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(51, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 72);
            this.label7.TabIndex = 25;
            this.label7.Text = "JOB CARD\r\nADDER";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.BackColor = System.Drawing.Color.White;
            this.lblJob.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJob.Location = new System.Drawing.Point(16, 229);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(109, 36);
            this.lblJob.TabIndex = 26;
            this.lblJob.Text = "FOR J#";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(353, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 16);
            this.label9.TabIndex = 27;
            this.label9.Text = "FINISHED?";
            // 
            // cbFinished
            // 
            this.cbFinished.AutoSize = true;
            this.cbFinished.Location = new System.Drawing.Point(378, 63);
            this.cbFinished.Name = "cbFinished";
            this.cbFinished.Size = new System.Drawing.Size(15, 14);
            this.cbFinished.TabIndex = 28;
            this.cbFinished.UseVisualStyleBackColor = true;
            // 
            // JobCardAdder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FLM_Job_Portal.Properties.Resources.Program_Background;
            this.ClientSize = new System.Drawing.Size(883, 575);
            this.Controls.Add(this.lblJob);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvCurrent);
            this.Name = "JobCardAdder";
            this.Text = "JobCardAdder";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvCurrent;
        private System.Windows.Forms.ColumnHeader colItem;
        private System.Windows.Forms.ColumnHeader colDept;
        private System.Windows.Forms.ColumnHeader colComponent;
        private System.Windows.Forms.ColumnHeader colHoursSpent;
        private System.Windows.Forms.ColumnHeader colNotes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbAddLine;
        private System.Windows.Forms.ComboBox cmboItem;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbNotes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmboOvertime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader colHoursAllotted;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmboHours;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.ColumnHeader colJob;
        private System.Windows.Forms.CheckBox cbFinished;
        private System.Windows.Forms.Label label9;
    }
}