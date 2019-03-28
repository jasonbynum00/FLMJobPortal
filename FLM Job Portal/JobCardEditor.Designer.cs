namespace FLM_Job_Portal
{
    partial class JobCardEditor
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
            this.lvCards = new System.Windows.Forms.ListView();
            this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colJob = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDept = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colComp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRegHours = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colOvertimeHours = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNotes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmboCards = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmboJob = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pbJobCards = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbJobCards)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvCards
            // 
            this.lvCards.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDate,
            this.colJob,
            this.colItem,
            this.colDept,
            this.colComp,
            this.colRegHours,
            this.colOvertimeHours,
            this.colNotes});
            this.lvCards.Location = new System.Drawing.Point(13, 248);
            this.lvCards.Name = "lvCards";
            this.lvCards.Size = new System.Drawing.Size(1112, 372);
            this.lvCards.TabIndex = 0;
            this.lvCards.UseCompatibleStateImageBehavior = false;
            this.lvCards.View = System.Windows.Forms.View.Details;
            // 
            // colDate
            // 
            this.colDate.Text = "DATE";
            this.colDate.Width = 122;
            // 
            // colJob
            // 
            this.colJob.Text = "JOB";
            this.colJob.Width = 98;
            // 
            // colItem
            // 
            this.colItem.Text = "ITEM";
            this.colItem.Width = 65;
            // 
            // colDept
            // 
            this.colDept.Text = "DEPARTMENT";
            this.colDept.Width = 148;
            // 
            // colComp
            // 
            this.colComp.Text = "COMPONENT";
            this.colComp.Width = 134;
            // 
            // colRegHours
            // 
            this.colRegHours.Text = "HOURS";
            this.colRegHours.Width = 104;
            // 
            // colOvertimeHours
            // 
            this.colOvertimeHours.Text = "OVERTIME";
            this.colOvertimeHours.Width = 106;
            // 
            // colNotes
            // 
            this.colNotes.Text = "NOTES";
            this.colNotes.Width = 599;
            // 
            // cmboCards
            // 
            this.cmboCards.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboCards.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboCards.FormattingEnabled = true;
            this.cmboCards.Location = new System.Drawing.Point(781, 221);
            this.cmboCards.Name = "cmboCards";
            this.cmboCards.Size = new System.Drawing.Size(344, 27);
            this.cmboCards.TabIndex = 1;
            this.cmboCards.SelectedIndexChanged += new System.EventHandler(this.cmboCards_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtpEnd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpStart);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 90);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SELECT BY RANGE";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.Location = new System.Drawing.Point(290, 37);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(99, 33);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(150, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "END:";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(149, 47);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(124, 21);
            this.dtpEnd.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(7, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "START:";
            // 
            // dtpStart
            // 
            this.dtpStart.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(6, 48);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(124, 21);
            this.dtpStart.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "JOB # :";
            // 
            // cmboJob
            // 
            this.cmboJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboJob.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboJob.FormattingEnabled = true;
            this.cmboJob.Location = new System.Drawing.Point(12, 43);
            this.cmboJob.Name = "cmboJob";
            this.cmboJob.Size = new System.Drawing.Size(203, 24);
            this.cmboJob.TabIndex = 0;
            this.cmboJob.SelectedIndexChanged += new System.EventHandler(this.cmboJob_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(962, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 28);
            this.label6.TabIndex = 9;
            this.label6.Text = "DELETE CARD:";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.ForestGreen;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(504, 213);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(155, 33);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "CLEAR LINES";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightYellow;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label7.Location = new System.Drawing.Point(618, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(277, 128);
            this.label7.TabIndex = 36;
            this.label7.Text = "JOB CARD\r\nVIEWER\r\n";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pbJobCards
            // 
            this.pbJobCards.BackColor = System.Drawing.Color.Transparent;
            this.pbJobCards.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbJobCards.Image = global::FLM_Job_Portal.Properties.Resources.Job_Card1;
            this.pbJobCards.Location = new System.Drawing.Point(910, 18);
            this.pbJobCards.Name = "pbJobCards";
            this.pbJobCards.Size = new System.Drawing.Size(130, 127);
            this.pbJobCards.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbJobCards.TabIndex = 35;
            this.pbJobCards.TabStop = false;
            this.pbJobCards.Click += new System.EventHandler(this.pbJobCards_Click);
            this.pbJobCards.MouseEnter += new System.EventHandler(this.pbJobCards_MouseEnter);
            this.pbJobCards.MouseLeave += new System.EventHandler(this.pbJobCards_MouseLeave);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox2.Controls.Add(this.cmboJob);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 90);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SELECT BY JOB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(101, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 42);
            this.label2.TabIndex = 38;
            this.label2.Text = "-OR-";
            // 
            // JobCardEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FLM_Job_Portal.Properties.Resources.Program_Background;
            this.ClientSize = new System.Drawing.Size(1137, 632);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pbJobCards);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvCards);
            this.Controls.Add(this.cmboCards);
            this.Controls.Add(this.label6);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "JobCardEditor";
            this.Text = "JOB CARD EDITOR";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbJobCards)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvCards;
        private System.Windows.Forms.ColumnHeader colJob;
        private System.Windows.Forms.ColumnHeader colDate;
        private System.Windows.Forms.ColumnHeader colItem;
        private System.Windows.Forms.ColumnHeader colRegHours;
        private System.Windows.Forms.ColumnHeader colOvertimeHours;
        private System.Windows.Forms.ColumnHeader colNotes;
        private System.Windows.Forms.ComboBox cmboCards;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmboJob;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ColumnHeader colDept;
        private System.Windows.Forms.ColumnHeader colComp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pbJobCards;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
    }
}