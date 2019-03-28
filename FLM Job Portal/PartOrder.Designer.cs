namespace FLM_Job_Portal
{
    partial class PartOrder
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
            this.txtPO = new System.Windows.Forms.TextBox();
            this.lblOrderForm = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmboEmployee = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(423, 484);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(146, 36);
            this.btnSubmit.TabIndex = 31;
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
            this.btnExit.Location = new System.Drawing.Point(133, 484);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(141, 36);
            this.btnExit.TabIndex = 30;
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
            this.label7.Location = new System.Drawing.Point(83, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 22);
            this.label7.TabIndex = 29;
            this.label7.Text = "Job #:";
            // 
            // cmboJob
            // 
            this.cmboJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboJob.FormattingEnabled = true;
            this.cmboJob.Location = new System.Drawing.Point(149, 200);
            this.cmboJob.Name = "cmboJob";
            this.cmboJob.Size = new System.Drawing.Size(135, 21);
            this.cmboJob.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightYellow;
            this.label6.Location = new System.Drawing.Point(310, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 22);
            this.label6.TabIndex = 26;
            this.label6.Text = "Date Ordered:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightYellow;
            this.label5.Location = new System.Drawing.Point(389, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 22);
            this.label5.TabIndex = 27;
            this.label5.Text = "ETA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightYellow;
            this.label4.Location = new System.Drawing.Point(69, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 22);
            this.label4.TabIndex = 25;
            this.label4.Text = "Vendor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightYellow;
            this.label3.Location = new System.Drawing.Point(34, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 22);
            this.label3.TabIndex = 24;
            this.label3.Text = "Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightYellow;
            this.label2.Location = new System.Drawing.Point(89, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 22);
            this.label2.TabIndex = 23;
            this.label2.Text = "PO #:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightYellow;
            this.label1.Location = new System.Drawing.Point(58, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 22);
            this.label1.TabIndex = 22;
            this.label1.Text = "Quantity:";
            // 
            // dtpETA
            // 
            this.dtpETA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpETA.Location = new System.Drawing.Point(441, 305);
            this.dtpETA.Name = "dtpETA";
            this.dtpETA.Size = new System.Drawing.Size(112, 20);
            this.dtpETA.TabIndex = 21;
            // 
            // dtpOrdered
            // 
            this.dtpOrdered.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrdered.Location = new System.Drawing.Point(441, 254);
            this.dtpOrdered.Name = "dtpOrdered";
            this.dtpOrdered.Size = new System.Drawing.Size(112, 20);
            this.dtpOrdered.TabIndex = 20;
            // 
            // cmboVendor
            // 
            this.cmboVendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboVendor.FormattingEnabled = true;
            this.cmboVendor.Location = new System.Drawing.Point(149, 355);
            this.cmboVendor.Name = "cmboVendor";
            this.cmboVendor.Size = new System.Drawing.Size(135, 21);
            this.cmboVendor.Sorted = true;
            this.cmboVendor.TabIndex = 19;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(149, 420);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(420, 20);
            this.txtDescription.TabIndex = 18;
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
            this.cmboQty.Location = new System.Drawing.Point(149, 257);
            this.cmboQty.Name = "cmboQty";
            this.cmboQty.Size = new System.Drawing.Size(92, 21);
            this.cmboQty.TabIndex = 16;
            // 
            // txtPO
            // 
            this.txtPO.Location = new System.Drawing.Point(149, 305);
            this.txtPO.Name = "txtPO";
            this.txtPO.Size = new System.Drawing.Size(135, 20);
            this.txtPO.TabIndex = 34;
            // 
            // lblOrderForm
            // 
            this.lblOrderForm.AutoSize = true;
            this.lblOrderForm.BackColor = System.Drawing.Color.Transparent;
            this.lblOrderForm.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderForm.ForeColor = System.Drawing.Color.White;
            this.lblOrderForm.Location = new System.Drawing.Point(185, 25);
            this.lblOrderForm.Name = "lblOrderForm";
            this.lblOrderForm.Size = new System.Drawing.Size(203, 78);
            this.lblOrderForm.TabIndex = 36;
            this.lblOrderForm.Text = "NEW ORDER\r\nFORM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::FLM_Job_Portal.Properties.Resources.shipping;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightYellow;
            this.label8.Location = new System.Drawing.Point(310, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 22);
            this.label8.TabIndex = 60;
            this.label8.Text = "Requested By:";
            // 
            // cmboEmployee
            // 
            this.cmboEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboEmployee.FormattingEnabled = true;
            this.cmboEmployee.Location = new System.Drawing.Point(441, 200);
            this.cmboEmployee.Name = "cmboEmployee";
            this.cmboEmployee.Size = new System.Drawing.Size(135, 21);
            this.cmboEmployee.TabIndex = 59;
            // 
            // PartOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FLM_Job_Portal.Properties.Resources.Program_Background;
            this.ClientSize = new System.Drawing.Size(661, 561);
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
            this.Name = "PartOrder";
            this.Text = "PART ORDER";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.TextBox txtPO;
        private System.Windows.Forms.Label lblOrderForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmboEmployee;
    }
}