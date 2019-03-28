namespace FLM_Job_Portal
{
    partial class EditWork
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
            this.flpEmployees = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddSubmit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmboAddEmployee = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmboAddAllotted = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmboAddDept = new System.Windows.Forms.ComboBox();
            this.pbAddEmployee = new System.Windows.Forms.PictureBox();
            this.dtpAddDue = new System.Windows.Forms.DateTimePicker();
            this.cmboAddComp = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // flpEmployees
            // 
            this.flpEmployees.AutoScroll = true;
            this.flpEmployees.BackColor = System.Drawing.Color.DarkGray;
            this.flpEmployees.Location = new System.Drawing.Point(12, 198);
            this.flpEmployees.Name = "flpEmployees";
            this.flpEmployees.Size = new System.Drawing.Size(761, 831);
            this.flpEmployees.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox1.Controls.Add(this.cmboAddComp);
            this.groupBox1.Controls.Add(this.dtpAddDue);
            this.groupBox1.Controls.Add(this.btnAddSubmit);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmboAddEmployee);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmboAddAllotted);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmboAddDept);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(818, 198);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 163);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ADD WORK TO EXISTING EMPLOYEE";
            // 
            // btnAddSubmit
            // 
            this.btnAddSubmit.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnAddSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddSubmit.ForeColor = System.Drawing.Color.White;
            this.btnAddSubmit.Location = new System.Drawing.Point(365, 106);
            this.btnAddSubmit.Name = "btnAddSubmit";
            this.btnAddSubmit.Size = new System.Drawing.Size(158, 37);
            this.btnAddSubmit.TabIndex = 15;
            this.btnAddSubmit.Text = "SUBMIT";
            this.btnAddSubmit.UseVisualStyleBackColor = false;
            this.btnAddSubmit.Click += new System.EventHandler(this.btnAddSubmit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(167, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "Date Due:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(22, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Employee:";
            // 
            // cmboAddEmployee
            // 
            this.cmboAddEmployee.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboAddEmployee.FormattingEnabled = true;
            this.cmboAddEmployee.Location = new System.Drawing.Point(22, 48);
            this.cmboAddEmployee.Name = "cmboAddEmployee";
            this.cmboAddEmployee.Size = new System.Drawing.Size(158, 24);
            this.cmboAddEmployee.TabIndex = 11;
            this.cmboAddEmployee.SelectedIndexChanged += new System.EventHandler(this.cmboAddEmployee_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(17, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Hrs. Allotted:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(380, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Component:";
            // 
            // cmboAddAllotted
            // 
            this.cmboAddAllotted.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboAddAllotted.FormattingEnabled = true;
            this.cmboAddAllotted.Location = new System.Drawing.Point(22, 116);
            this.cmboAddAllotted.Name = "cmboAddAllotted";
            this.cmboAddAllotted.Size = new System.Drawing.Size(115, 24);
            this.cmboAddAllotted.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(204, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Department:";
            // 
            // cmboAddDept
            // 
            this.cmboAddDept.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboAddDept.FormattingEnabled = true;
            this.cmboAddDept.Items.AddRange(new object[] {
            "GRINDING",
            "CNC MILL",
            "LATHE",
            "SINKER EDM",
            "WIRE EDM",
            "HAND MILL"});
            this.cmboAddDept.Location = new System.Drawing.Point(208, 48);
            this.cmboAddDept.Name = "cmboAddDept";
            this.cmboAddDept.Size = new System.Drawing.Size(141, 24);
            this.cmboAddDept.TabIndex = 0;
            // 
            // pbAddEmployee
            // 
            this.pbAddEmployee.BackgroundImage = global::FLM_Job_Portal.Properties.Resources.Add_Employee;
            this.pbAddEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAddEmployee.Location = new System.Drawing.Point(1230, 31);
            this.pbAddEmployee.Name = "pbAddEmployee";
            this.pbAddEmployee.Size = new System.Drawing.Size(150, 127);
            this.pbAddEmployee.TabIndex = 5;
            this.pbAddEmployee.TabStop = false;
            this.pbAddEmployee.Click += new System.EventHandler(this.pbAddEmployee_Click);
            // 
            // dtpAddDue
            // 
            this.dtpAddDue.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAddDue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAddDue.Location = new System.Drawing.Point(171, 116);
            this.dtpAddDue.Name = "dtpAddDue";
            this.dtpAddDue.Size = new System.Drawing.Size(133, 21);
            this.dtpAddDue.TabIndex = 16;
            // 
            // cmboAddComp
            // 
            this.cmboAddComp.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboAddComp.FormattingEnabled = true;
            this.cmboAddComp.Location = new System.Drawing.Point(382, 48);
            this.cmboAddComp.Name = "cmboAddComp";
            this.cmboAddComp.Size = new System.Drawing.Size(141, 24);
            this.cmboAddComp.TabIndex = 17;
            // 
            // EditWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FLM_Job_Portal.Properties.Resources.Program_Background;
            this.ClientSize = new System.Drawing.Size(1395, 1041);
            this.Controls.Add(this.pbAddEmployee);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flpEmployees);
            this.Name = "EditWork";
            this.Text = "EDIT WORK";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpEmployees;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmboAddAllotted;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmboAddDept;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmboAddEmployee;
        private System.Windows.Forms.Button btnAddSubmit;
        private System.Windows.Forms.PictureBox pbAddEmployee;
        private System.Windows.Forms.DateTimePicker dtpAddDue;
        private System.Windows.Forms.ComboBox cmboAddComp;
    }
}