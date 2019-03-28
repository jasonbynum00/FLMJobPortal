namespace FLM_Job_Portal
{
    partial class ServiceOrder
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
            this.lblOrderForm = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPO = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmboJob = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpETA = new System.Windows.Forms.DateTimePicker();
            this.dtpOrdered = new System.Windows.Forms.DateTimePicker();
            this.cmboVendor = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cmboQty = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmboEmployee = new System.Windows.Forms.ComboBox();
            this.txtPart = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmboService = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOrderForm
            // 
            this.lblOrderForm.AutoSize = true;
            this.lblOrderForm.BackColor = System.Drawing.Color.Transparent;
            this.lblOrderForm.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderForm.ForeColor = System.Drawing.Color.White;
            this.lblOrderForm.Location = new System.Drawing.Point(173, 49);
            this.lblOrderForm.Name = "lblOrderForm";
            this.lblOrderForm.Size = new System.Drawing.Size(221, 78);
            this.lblOrderForm.TabIndex = 56;
            this.lblOrderForm.Text = "NEW SERVICE\r\nFORM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::FLM_Job_Portal.Properties.Resources.Outside1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // txtPO
            // 
            this.txtPO.Location = new System.Drawing.Point(141, 229);
            this.txtPO.Name = "txtPO";
            this.txtPO.Size = new System.Drawing.Size(135, 20);
            this.txtPO.TabIndex = 54;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(425, 493);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(146, 36);
            this.btnSubmit.TabIndex = 51;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(102, 493);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(141, 36);
            this.btnExit.TabIndex = 50;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightYellow;
            this.label7.Location = new System.Drawing.Point(75, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 22);
            this.label7.TabIndex = 49;
            this.label7.Text = "Job #:";
            // 
            // cmboJob
            // 
            this.cmboJob.FormattingEnabled = true;
            this.cmboJob.Location = new System.Drawing.Point(141, 184);
            this.cmboJob.Name = "cmboJob";
            this.cmboJob.Size = new System.Drawing.Size(135, 21);
            this.cmboJob.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightYellow;
            this.label6.Location = new System.Drawing.Point(294, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 22);
            this.label6.TabIndex = 46;
            this.label6.Text = "Date Ordered:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightYellow;
            this.label5.Location = new System.Drawing.Point(373, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 22);
            this.label5.TabIndex = 47;
            this.label5.Text = "ETA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightYellow;
            this.label4.Location = new System.Drawing.Point(345, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 22);
            this.label4.TabIndex = 45;
            this.label4.Text = "Vendor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightYellow;
            this.label3.Location = new System.Drawing.Point(26, 429);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 22);
            this.label3.TabIndex = 44;
            this.label3.Text = "Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightYellow;
            this.label2.Location = new System.Drawing.Point(81, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 22);
            this.label2.TabIndex = 43;
            this.label2.Text = "PO #:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightYellow;
            this.label1.Location = new System.Drawing.Point(50, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 22);
            this.label1.TabIndex = 42;
            this.label1.Text = "Quantity:";
            // 
            // dtpETA
            // 
            this.dtpETA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpETA.Location = new System.Drawing.Point(425, 328);
            this.dtpETA.Name = "dtpETA";
            this.dtpETA.Size = new System.Drawing.Size(112, 20);
            this.dtpETA.TabIndex = 41;
            // 
            // dtpOrdered
            // 
            this.dtpOrdered.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrdered.Location = new System.Drawing.Point(425, 277);
            this.dtpOrdered.Name = "dtpOrdered";
            this.dtpOrdered.Size = new System.Drawing.Size(112, 20);
            this.dtpOrdered.TabIndex = 40;
            // 
            // cmboVendor
            // 
            this.cmboVendor.FormattingEnabled = true;
            this.cmboVendor.Location = new System.Drawing.Point(425, 229);
            this.cmboVendor.Name = "cmboVendor";
            this.cmboVendor.Size = new System.Drawing.Size(135, 21);
            this.cmboVendor.Sorted = true;
            this.cmboVendor.TabIndex = 39;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(141, 431);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(420, 20);
            this.txtDescription.TabIndex = 38;
            // 
            // cmboQty
            // 
            this.cmboQty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52 ",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100"});
            this.cmboQty.Location = new System.Drawing.Point(141, 325);
            this.cmboQty.Name = "cmboQty";
            this.cmboQty.Size = new System.Drawing.Size(92, 21);
            this.cmboQty.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightYellow;
            this.label8.Location = new System.Drawing.Point(10, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 22);
            this.label8.TabIndex = 58;
            this.label8.Text = "Requested By:";
            // 
            // cmboEmployee
            // 
            this.cmboEmployee.FormattingEnabled = true;
            this.cmboEmployee.Location = new System.Drawing.Point(141, 274);
            this.cmboEmployee.Name = "cmboEmployee";
            this.cmboEmployee.Size = new System.Drawing.Size(135, 21);
            this.cmboEmployee.TabIndex = 57;
            // 
            // txtPart
            // 
            this.txtPart.Location = new System.Drawing.Point(141, 377);
            this.txtPart.Name = "txtPart";
            this.txtPart.Size = new System.Drawing.Size(135, 20);
            this.txtPart.TabIndex = 60;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.LightYellow;
            this.label9.Location = new System.Drawing.Point(86, 377);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 22);
            this.label9.TabIndex = 59;
            this.label9.Text = "Part:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.LightYellow;
            this.label10.Location = new System.Drawing.Point(347, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 22);
            this.label10.TabIndex = 61;
            this.label10.Text = "Service:";
            // 
            // cmboService
            // 
            this.cmboService.FormattingEnabled = true;
            this.cmboService.Items.AddRange(new object[] {
            "CNC",
            "EDM",
            "HEAT TREAT",
            "LATHE",
            "WELD"});
            this.cmboService.Location = new System.Drawing.Point(425, 182);
            this.cmboService.Name = "cmboService";
            this.cmboService.Size = new System.Drawing.Size(135, 21);
            this.cmboService.Sorted = true;
            this.cmboService.TabIndex = 62;
            // 
            // ServiceOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FLM_Job_Portal.Properties.Resources.Program_Background;
            this.ClientSize = new System.Drawing.Size(661, 561);
            this.Controls.Add(this.cmboService);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPart);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmboEmployee);
            this.Controls.Add(this.lblOrderForm);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPO);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmboJob);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpETA);
            this.Controls.Add(this.dtpOrdered);
            this.Controls.Add(this.cmboVendor);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.cmboQty);
            this.Name = "ServiceOrder";
            this.Text = "SERVICE ORDER";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrderForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPO;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmboJob;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpETA;
        private System.Windows.Forms.DateTimePicker dtpOrdered;
        private System.Windows.Forms.ComboBox cmboVendor;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox cmboQty;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmboEmployee;
        private System.Windows.Forms.TextBox txtPart;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmboService;
    }
}