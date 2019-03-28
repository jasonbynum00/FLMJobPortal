namespace FLM_Job_Portal
{
    partial class WorkViewer
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmboJob = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pbMyWork = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lvWork = new System.Windows.Forms.ListView();
            this.colJob = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDept = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colComp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAllotted = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSpent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLeft = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colComplete = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNotes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.pbComplete = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMyWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComplete)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox2.Controls.Add(this.cmboJob);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(14, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 90);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SELECT BY JOB";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightYellow;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label7.Location = new System.Drawing.Point(168, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(217, 100);
            this.label7.TabIndex = 42;
            this.label7.Text = "MY WORK\r\nVIEWER";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbMyWork
            // 
            this.pbMyWork.BackColor = System.Drawing.Color.Transparent;
            this.pbMyWork.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pbMyWork.Image = global::FLM_Job_Portal.Properties.Resources.Todays_Work;
            this.pbMyWork.Location = new System.Drawing.Point(13, 12);
            this.pbMyWork.Name = "pbMyWork";
            this.pbMyWork.Size = new System.Drawing.Size(149, 127);
            this.pbMyWork.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMyWork.TabIndex = 41;
            this.pbMyWork.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.ForestGreen;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(478, 211);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(155, 33);
            this.btnClear.TabIndex = 40;
            this.btnClear.Text = "CLEAR LINES";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lvWork
            // 
            this.lvWork.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colJob,
            this.colQty,
            this.colItem,
            this.colDept,
            this.colComp,
            this.colAllotted,
            this.colSpent,
            this.colLeft,
            this.colDue,
            this.colComplete,
            this.colNotes});
            this.lvWork.Location = new System.Drawing.Point(13, 246);
            this.lvWork.Name = "lvWork";
            this.lvWork.Size = new System.Drawing.Size(1112, 372);
            this.lvWork.TabIndex = 38;
            this.lvWork.UseCompatibleStateImageBehavior = false;
            this.lvWork.View = System.Windows.Forms.View.Details;
            // 
            // colJob
            // 
            this.colJob.Text = "JOB";
            this.colJob.Width = 98;
            // 
            // colQty
            // 
            this.colQty.Text = "QTY";
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
            this.colComp.Width = 135;
            // 
            // colAllotted
            // 
            this.colAllotted.Text = "HRS ALLOTTED";
            this.colAllotted.Width = 95;
            // 
            // colSpent
            // 
            this.colSpent.Text = "HRS SPENT";
            this.colSpent.Width = 80;
            // 
            // colLeft
            // 
            this.colLeft.Text = "HRS LEFT";
            this.colLeft.Width = 89;
            // 
            // colDue
            // 
            this.colDue.Text = "DUE";
            this.colDue.Width = 99;
            // 
            // colComplete
            // 
            this.colComplete.Text = "COMPLETE";
            this.colComplete.Width = 99;
            // 
            // colNotes
            // 
            this.colNotes.Text = "NOTES";
            this.colNotes.Width = 170;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label2.Location = new System.Drawing.Point(24, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 56);
            this.label2.TabIndex = 45;
            this.label2.Text = "MARK WORK\r\nCOMPLETE\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbComplete
            // 
            this.pbComplete.BackColor = System.Drawing.Color.Transparent;
            this.pbComplete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbComplete.Image = global::FLM_Job_Portal.Properties.Resources.complete1;
            this.pbComplete.Location = new System.Drawing.Point(54, 80);
            this.pbComplete.Name = "pbComplete";
            this.pbComplete.Size = new System.Drawing.Size(101, 90);
            this.pbComplete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbComplete.TabIndex = 44;
            this.pbComplete.TabStop = false;
            this.pbComplete.Click += new System.EventHandler(this.pbComplete_Click);
            this.pbComplete.MouseEnter += new System.EventHandler(this.pbComplete_MouseEnter);
            this.pbComplete.MouseLeave += new System.EventHandler(this.pbComplete_MouseLeave);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox1.Controls.Add(this.pbComplete);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(850, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 197);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COMPLETE";
            // 
            // WorkViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FLM_Job_Portal.Properties.Resources.Program_Background;
            this.ClientSize = new System.Drawing.Size(1137, 632);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pbMyWork);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lvWork);
            this.Name = "WorkViewer";
            this.Text = "MY WORK";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMyWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComplete)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmboJob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pbMyWork;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListView lvWork;
        private System.Windows.Forms.ColumnHeader colJob;
        private System.Windows.Forms.ColumnHeader colItem;
        private System.Windows.Forms.ColumnHeader colDept;
        private System.Windows.Forms.ColumnHeader colComp;
        private System.Windows.Forms.ColumnHeader colAllotted;
        private System.Windows.Forms.ColumnHeader colSpent;
        private System.Windows.Forms.ColumnHeader colLeft;
        private System.Windows.Forms.ColumnHeader colDue;
        private System.Windows.Forms.ColumnHeader colComplete;
        private System.Windows.Forms.ColumnHeader colNotes;
        private System.Windows.Forms.ColumnHeader colQty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbComplete;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}