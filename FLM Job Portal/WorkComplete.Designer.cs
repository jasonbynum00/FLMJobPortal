namespace FLM_Job_Portal
{
    partial class WorkComplete
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
            this.lvWork = new System.Windows.Forms.ListView();
            this.colJob = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDept = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colComponent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHoursAllotted = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHoursSpent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDateDue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label7 = new System.Windows.Forms.Label();
            this.pbComplete = new System.Windows.Forms.PictureBox();
            this.cmboItem = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbComplete)).BeginInit();
            this.SuspendLayout();
            // 
            // lvWork
            // 
            this.lvWork.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colJob,
            this.colQuantity,
            this.colItem,
            this.colDept,
            this.colComponent,
            this.colHoursAllotted,
            this.colHoursSpent,
            this.colDateDue});
            this.lvWork.GridLines = true;
            this.lvWork.Location = new System.Drawing.Point(24, 247);
            this.lvWork.Name = "lvWork";
            this.lvWork.Size = new System.Drawing.Size(803, 297);
            this.lvWork.TabIndex = 1;
            this.lvWork.UseCompatibleStateImageBehavior = false;
            this.lvWork.View = System.Windows.Forms.View.Details;
            // 
            // colJob
            // 
            this.colJob.Text = "JOB";
            this.colJob.Width = 103;
            // 
            // colQuantity
            // 
            this.colQuantity.Text = "QTY";
            this.colQuantity.Width = 55;
            // 
            // colItem
            // 
            this.colItem.Text = "ITEM";
            this.colItem.Width = 66;
            // 
            // colDept
            // 
            this.colDept.Text = "DEPARTMENT";
            this.colDept.Width = 138;
            // 
            // colComponent
            // 
            this.colComponent.Text = "COMPONENT";
            this.colComponent.Width = 155;
            // 
            // colHoursAllotted
            // 
            this.colHoursAllotted.Text = "HRS ALLOTTED";
            this.colHoursAllotted.Width = 96;
            // 
            // colHoursSpent
            // 
            this.colHoursSpent.Text = "HRS SPENT";
            this.colHoursSpent.Width = 74;
            // 
            // colDateDue
            // 
            this.colDateDue.Text = "DUE";
            this.colDateDue.Width = 112;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightYellow;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label7.Location = new System.Drawing.Point(160, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(273, 100);
            this.label7.TabIndex = 38;
            this.label7.Text = "MARK WORK\r\nCOMPLETE\r\n";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbComplete
            // 
            this.pbComplete.BackColor = System.Drawing.Color.Transparent;
            this.pbComplete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbComplete.Image = global::FLM_Job_Portal.Properties.Resources.complete1;
            this.pbComplete.Location = new System.Drawing.Point(24, 26);
            this.pbComplete.Name = "pbComplete";
            this.pbComplete.Size = new System.Drawing.Size(130, 127);
            this.pbComplete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbComplete.TabIndex = 37;
            this.pbComplete.TabStop = false;
            // 
            // cmboItem
            // 
            this.cmboItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboItem.FormattingEnabled = true;
            this.cmboItem.Location = new System.Drawing.Point(483, 221);
            this.cmboItem.Name = "cmboItem";
            this.cmboItem.Size = new System.Drawing.Size(344, 27);
            this.cmboItem.TabIndex = 39;
            this.cmboItem.SelectedIndexChanged += new System.EventHandler(this.cmboCards_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(522, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(304, 28);
            this.label6.TabIndex = 40;
            this.label6.Text = "SELECT ITEM TO COMPLETE";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(666, 27);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(162, 36);
            this.btnExit.TabIndex = 51;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // WorkComplete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FLM_Job_Portal.Properties.Resources.Program_Background;
            this.ClientSize = new System.Drawing.Size(852, 556);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cmboItem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pbComplete);
            this.Controls.Add(this.lvWork);
            this.Name = "WorkComplete";
            this.Text = "MARK WORK DONE";
            ((System.ComponentModel.ISupportInitialize)(this.pbComplete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvWork;
        private System.Windows.Forms.ColumnHeader colJob;
        private System.Windows.Forms.ColumnHeader colItem;
        private System.Windows.Forms.ColumnHeader colDept;
        private System.Windows.Forms.ColumnHeader colComponent;
        private System.Windows.Forms.ColumnHeader colHoursAllotted;
        private System.Windows.Forms.ColumnHeader colHoursSpent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pbComplete;
        private System.Windows.Forms.ComboBox cmboItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ColumnHeader colDateDue;
        private System.Windows.Forms.ColumnHeader colQuantity;
    }
}