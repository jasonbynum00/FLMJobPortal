namespace FLM_Job_Portal
{
    partial class EditEmployee
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
            this.lvAdded = new System.Windows.Forms.ListView();
            this.colItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDepartment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colComponent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAllotted = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbAddLine = new System.Windows.Forms.PictureBox();
            this.cmboComp = new System.Windows.Forms.ComboBox();
            this.cmboDept = new System.Windows.Forms.ComboBox();
            this.dtpDue = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cmboHours = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmboSelectEmp = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.cmboQty = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.colQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddLine)).BeginInit();
            this.SuspendLayout();
            // 
            // lvAdded
            // 
            this.lvAdded.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colQty,
            this.colItem,
            this.colDepartment,
            this.colComponent,
            this.colAllotted,
            this.colDue});
            this.lvAdded.GridLines = true;
            this.lvAdded.Location = new System.Drawing.Point(22, 248);
            this.lvAdded.Name = "lvAdded";
            this.lvAdded.Size = new System.Drawing.Size(754, 339);
            this.lvAdded.TabIndex = 27;
            this.lvAdded.UseCompatibleStateImageBehavior = false;
            this.lvAdded.View = System.Windows.Forms.View.Details;
            // 
            // colItem
            // 
            this.colItem.Text = "ITEM";
            // 
            // colDepartment
            // 
            this.colDepartment.Text = "DEPARTMENT";
            this.colDepartment.Width = 162;
            // 
            // colComponent
            // 
            this.colComponent.Text = "COMPONENT";
            this.colComponent.Width = 184;
            // 
            // colAllotted
            // 
            this.colAllotted.Text = "HRS ALLOTTED";
            this.colAllotted.Width = 105;
            // 
            // colDue
            // 
            this.colDue.Text = "DATE DUE";
            this.colDue.Width = 127;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox1.Controls.Add(this.cmboQty);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pbAddLine);
            this.groupBox1.Controls.Add(this.cmboComp);
            this.groupBox1.Controls.Add(this.cmboDept);
            this.groupBox1.Controls.Add(this.dtpDue);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmboHours);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(22, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 120);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Work";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(698, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 22);
            this.label6.TabIndex = 21;
            this.label6.Text = "Add";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(101, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 22);
            this.label1.TabIndex = 17;
            this.label1.Text = "Department:";
            // 
            // pbAddLine
            // 
            this.pbAddLine.BackColor = System.Drawing.Color.Transparent;
            this.pbAddLine.BackgroundImage = global::FLM_Job_Portal.Properties.Resources.Add_Line;
            this.pbAddLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAddLine.Location = new System.Drawing.Point(699, 50);
            this.pbAddLine.Name = "pbAddLine";
            this.pbAddLine.Size = new System.Drawing.Size(46, 43);
            this.pbAddLine.TabIndex = 16;
            this.pbAddLine.TabStop = false;
            this.pbAddLine.Click += new System.EventHandler(this.pbAddLine_Click);
            this.pbAddLine.MouseEnter += new System.EventHandler(this.pbAddLine_MouseEnter);
            this.pbAddLine.MouseLeave += new System.EventHandler(this.pbAddLine_MouseLeave);
            // 
            // cmboComp
            // 
            this.cmboComp.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboComp.FormattingEnabled = true;
            this.cmboComp.Items.AddRange(new object[] {
            "CAVITY",
            "CORE",
            "CORE PINS",
            "EJECTOR PINS",
            "EJECTOR PLATE",
            "INSERT",
            "MOLD BASE",
            "RUNNER SYSTEM",
            "SLIDES"});
            this.cmboComp.Location = new System.Drawing.Point(293, 65);
            this.cmboComp.Name = "cmboComp";
            this.cmboComp.Size = new System.Drawing.Size(186, 25);
            this.cmboComp.Sorted = true;
            this.cmboComp.TabIndex = 1;
            // 
            // cmboDept
            // 
            this.cmboDept.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboDept.FormattingEnabled = true;
            this.cmboDept.Items.AddRange(new object[] {
            "GRINDING",
            "MILLING",
            "CNC",
            "EDM",
            "POLISH"});
            this.cmboDept.Location = new System.Drawing.Point(101, 65);
            this.cmboDept.Name = "cmboDept";
            this.cmboDept.Size = new System.Drawing.Size(186, 25);
            this.cmboDept.TabIndex = 0;
            // 
            // dtpDue
            // 
            this.dtpDue.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDue.Location = new System.Drawing.Point(583, 65);
            this.dtpDue.Name = "dtpDue";
            this.dtpDue.Size = new System.Drawing.Size(109, 23);
            this.dtpDue.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(583, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 22);
            this.label5.TabIndex = 20;
            this.label5.Text = "Due:";
            // 
            // cmboHours
            // 
            this.cmboHours.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboHours.FormattingEnabled = true;
            this.cmboHours.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25"});
            this.cmboHours.Location = new System.Drawing.Point(485, 65);
            this.cmboHours.Name = "cmboHours";
            this.cmboHours.Size = new System.Drawing.Size(92, 25);
            this.cmboHours.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(293, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 22);
            this.label2.TabIndex = 18;
            this.label2.Text = "Component:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(485, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 22);
            this.label3.TabIndex = 19;
            this.label3.Text = "Hrs.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 28);
            this.label4.TabIndex = 25;
            this.label4.Text = "Employee:";
            // 
            // cmboSelectEmp
            // 
            this.cmboSelectEmp.FormattingEnabled = true;
            this.cmboSelectEmp.Location = new System.Drawing.Point(22, 64);
            this.cmboSelectEmp.Name = "cmboSelectEmp";
            this.cmboSelectEmp.Size = new System.Drawing.Size(192, 21);
            this.cmboSelectEmp.TabIndex = 29;
            this.cmboSelectEmp.SelectedIndexChanged += new System.EventHandler(this.cmboSelectEmp_SelectedIndexChanged);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(647, 43);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 28);
            this.btnExit.TabIndex = 30;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cmboQty
            // 
            this.cmboQty.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboQty.FormattingEnabled = true;
            this.cmboQty.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25"});
            this.cmboQty.Location = new System.Drawing.Point(6, 65);
            this.cmboQty.Name = "cmboQty";
            this.cmboQty.Size = new System.Drawing.Size(92, 25);
            this.cmboQty.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(6, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 22);
            this.label7.TabIndex = 25;
            this.label7.Text = "Qty.";
            // 
            // colQty
            // 
            this.colQty.Text = "QTY";
            // 
            // EditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FLM_Job_Portal.Properties.Resources.Program_Background;
            this.ClientSize = new System.Drawing.Size(796, 599);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cmboSelectEmp);
            this.Controls.Add(this.lvAdded);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Name = "EditEmployee";
            this.Text = "EDIT EMPLOYEE";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddLine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lvAdded;
        private System.Windows.Forms.ColumnHeader colItem;
        private System.Windows.Forms.ColumnHeader colDepartment;
        private System.Windows.Forms.ColumnHeader colComponent;
        private System.Windows.Forms.ColumnHeader colAllotted;
        private System.Windows.Forms.ColumnHeader colDue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbAddLine;
        private System.Windows.Forms.ComboBox cmboComp;
        private System.Windows.Forms.ComboBox cmboDept;
        private System.Windows.Forms.DateTimePicker dtpDue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmboHours;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmboSelectEmp;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ColumnHeader colQty;
        private System.Windows.Forms.ComboBox cmboQty;
        private System.Windows.Forms.Label label7;
    }
}