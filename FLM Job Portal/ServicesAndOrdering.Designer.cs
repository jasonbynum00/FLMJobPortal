namespace FLM_Job_Portal
{
    partial class ServicesAndOrdering
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
            this.lvOrder = new System.Windows.Forms.ListView();
            this.colJob = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colVendor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colOrdered = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colETA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colReceived = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.pbAddOrder = new System.Windows.Forms.PictureBox();
            this.lvOutsideServices = new System.Windows.Forms.ListView();
            this.colOSJob = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colOSPo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colOSReqBy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colOSQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colOSPart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colOSService = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colOSVendor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colOSSent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colOSETA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colOSReceived = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.pbAddService = new System.Windows.Forms.PictureBox();
            this.cmboPO = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLineClear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmboService = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmboJob = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cmboServComplete = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmboOrderComp = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lvOrder
            // 
            this.lvOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colJob,
            this.colPO,
            this.colBy,
            this.colQuantity,
            this.colDescription,
            this.colVendor,
            this.colOrdered,
            this.colETA,
            this.colReceived});
            this.lvOrder.GridLines = true;
            this.lvOrder.Location = new System.Drawing.Point(19, 273);
            this.lvOrder.Name = "lvOrder";
            this.lvOrder.Size = new System.Drawing.Size(836, 401);
            this.lvOrder.TabIndex = 0;
            this.lvOrder.UseCompatibleStateImageBehavior = false;
            this.lvOrder.View = System.Windows.Forms.View.Details;
            // 
            // colJob
            // 
            this.colJob.Text = "JOB";
            this.colJob.Width = 99;
            // 
            // colPO
            // 
            this.colPO.Text = "PO #";
            this.colPO.Width = 87;
            // 
            // colBy
            // 
            this.colBy.Text = "REQ BY";
            // 
            // colQuantity
            // 
            this.colQuantity.Text = "QTY";
            this.colQuantity.Width = 45;
            // 
            // colDescription
            // 
            this.colDescription.Text = "DESCRIPTION";
            this.colDescription.Width = 133;
            // 
            // colVendor
            // 
            this.colVendor.Text = "VENDOR";
            this.colVendor.Width = 117;
            // 
            // colOrdered
            // 
            this.colOrdered.Text = "ORDERED";
            this.colOrdered.Width = 95;
            // 
            // colETA
            // 
            this.colETA.Text = "ETA";
            this.colETA.Width = 90;
            // 
            // colReceived
            // 
            this.colReceived.Text = "RECEIVED";
            this.colReceived.Width = 103;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "PARTS TO ORDER";
            // 
            // pbAddOrder
            // 
            this.pbAddOrder.BackColor = System.Drawing.Color.Transparent;
            this.pbAddOrder.Image = global::FLM_Job_Portal.Properties.Resources.shipping;
            this.pbAddOrder.Location = new System.Drawing.Point(372, 129);
            this.pbAddOrder.Name = "pbAddOrder";
            this.pbAddOrder.Size = new System.Drawing.Size(146, 128);
            this.pbAddOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAddOrder.TabIndex = 2;
            this.pbAddOrder.TabStop = false;
            this.pbAddOrder.Click += new System.EventHandler(this.pbAddOrder_Click);
            this.pbAddOrder.MouseEnter += new System.EventHandler(this.pbAddOrder_MouseEnter);
            this.pbAddOrder.MouseLeave += new System.EventHandler(this.pbAddOrder_MouseLeave);
            // 
            // lvOutsideServices
            // 
            this.lvOutsideServices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colOSJob,
            this.colOSPo,
            this.colOSReqBy,
            this.colOSQuantity,
            this.colOSPart,
            this.colOSService,
            this.colOSVendor,
            this.colOSSent,
            this.colOSETA,
            this.colOSReceived});
            this.lvOutsideServices.GridLines = true;
            this.lvOutsideServices.Location = new System.Drawing.Point(891, 270);
            this.lvOutsideServices.Name = "lvOutsideServices";
            this.lvOutsideServices.Size = new System.Drawing.Size(850, 401);
            this.lvOutsideServices.TabIndex = 3;
            this.lvOutsideServices.UseCompatibleStateImageBehavior = false;
            this.lvOutsideServices.View = System.Windows.Forms.View.Details;
            // 
            // colOSJob
            // 
            this.colOSJob.Text = "JOB";
            this.colOSJob.Width = 87;
            // 
            // colOSPo
            // 
            this.colOSPo.Text = "PO #";
            // 
            // colOSReqBy
            // 
            this.colOSReqBy.Text = "REQ BY";
            // 
            // colOSQuantity
            // 
            this.colOSQuantity.Text = "QTY";
            this.colOSQuantity.Width = 42;
            // 
            // colOSPart
            // 
            this.colOSPart.Text = "PART";
            this.colOSPart.Width = 97;
            // 
            // colOSService
            // 
            this.colOSService.Text = "SERVICE";
            this.colOSService.Width = 93;
            // 
            // colOSVendor
            // 
            this.colOSVendor.Text = "VENDOR";
            this.colOSVendor.Width = 93;
            // 
            // colOSSent
            // 
            this.colOSSent.Text = "DATE SENT";
            this.colOSSent.Width = 98;
            // 
            // colOSETA
            // 
            this.colOSETA.Text = "ETA";
            this.colOSETA.Width = 96;
            // 
            // colOSReceived
            // 
            this.colOSReceived.Text = "DATE RECEIVED";
            this.colOSReceived.Width = 116;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(892, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "OUTSIDE SERVICES";
            // 
            // pbAddService
            // 
            this.pbAddService.BackColor = System.Drawing.Color.Transparent;
            this.pbAddService.Image = global::FLM_Job_Portal.Properties.Resources.Outside1;
            this.pbAddService.Location = new System.Drawing.Point(1281, 155);
            this.pbAddService.Name = "pbAddService";
            this.pbAddService.Size = new System.Drawing.Size(124, 102);
            this.pbAddService.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAddService.TabIndex = 5;
            this.pbAddService.TabStop = false;
            this.pbAddService.Click += new System.EventHandler(this.pbAddService_Click);
            this.pbAddService.MouseEnter += new System.EventHandler(this.pbAddService_MouseEnter);
            this.pbAddService.MouseLeave += new System.EventHandler(this.pbAddService_MouseLeave);
            // 
            // cmboPO
            // 
            this.cmboPO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboPO.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboPO.FormattingEnabled = true;
            this.cmboPO.Location = new System.Drawing.Point(656, 197);
            this.cmboPO.Name = "cmboPO";
            this.cmboPO.Size = new System.Drawing.Size(199, 27);
            this.cmboPO.TabIndex = 6;
            this.cmboPO.SelectedIndexChanged += new System.EventHandler(this.cmboPO_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(657, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "EDIT ORDER:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(223, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 78);
            this.label8.TabIndex = 17;
            this.label8.Text = "FINELINE\r\nMOLDS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::FLM_Job_Portal.Properties.Resources.M_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(19, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightYellow;
            this.label4.Location = new System.Drawing.Point(24, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 36);
            this.label4.TabIndex = 18;
            this.label4.Text = "JOB #:";
            // 
            // btnLineClear
            // 
            this.btnLineClear.BackColor = System.Drawing.Color.ForestGreen;
            this.btnLineClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLineClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLineClear.ForeColor = System.Drawing.Color.White;
            this.btnLineClear.Location = new System.Drawing.Point(763, 10);
            this.btnLineClear.Name = "btnLineClear";
            this.btnLineClear.Size = new System.Drawing.Size(203, 36);
            this.btnLineClear.TabIndex = 21;
            this.btnLineClear.Text = "CLEAR LINES";
            this.btnLineClear.UseVisualStyleBackColor = false;
            this.btnLineClear.Click += new System.EventHandler(this.btnLineClear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1543, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 22);
            this.label5.TabIndex = 23;
            this.label5.Text = "EDIT SERVICE:";
            // 
            // cmboService
            // 
            this.cmboService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboService.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboService.FormattingEnabled = true;
            this.cmboService.Location = new System.Drawing.Point(1542, 194);
            this.cmboService.Name = "cmboService";
            this.cmboService.Size = new System.Drawing.Size(199, 27);
            this.cmboService.TabIndex = 22;
            this.cmboService.SelectedIndexChanged += new System.EventHandler(this.cmboService_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightYellow;
            this.label6.Location = new System.Drawing.Point(405, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 52);
            this.label6.TabIndex = 36;
            this.label6.Text = "NEW\r\nORDER";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightYellow;
            this.label7.Location = new System.Drawing.Point(1302, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 52);
            this.label7.TabIndex = 37;
            this.label7.Text = "NEW\r\nSERVICE";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmboJob
            // 
            this.cmboJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboJob.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboJob.FormattingEnabled = true;
            this.cmboJob.Location = new System.Drawing.Point(122, 155);
            this.cmboJob.Name = "cmboJob";
            this.cmboJob.Size = new System.Drawing.Size(199, 27);
            this.cmboJob.TabIndex = 38;
            this.cmboJob.SelectedIndexChanged += new System.EventHandler(this.cmboJob_SelectedIndexChanged);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1547, 10);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(194, 36);
            this.btnExit.TabIndex = 39;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Window;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1543, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 22);
            this.label9.TabIndex = 41;
            this.label9.Text = "SERVICE COMPLETE:";
            // 
            // cmboServComplete
            // 
            this.cmboServComplete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboServComplete.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboServComplete.FormattingEnabled = true;
            this.cmboServComplete.Location = new System.Drawing.Point(1542, 243);
            this.cmboServComplete.Name = "cmboServComplete";
            this.cmboServComplete.Size = new System.Drawing.Size(199, 27);
            this.cmboServComplete.TabIndex = 40;
            this.cmboServComplete.SelectedIndexChanged += new System.EventHandler(this.cmboServComplete_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Window;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(657, 224);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 22);
            this.label10.TabIndex = 43;
            this.label10.Text = "ORDER COMPLETE:";
            // 
            // cmboOrderComp
            // 
            this.cmboOrderComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboOrderComp.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboOrderComp.FormattingEnabled = true;
            this.cmboOrderComp.Location = new System.Drawing.Point(656, 246);
            this.cmboOrderComp.Name = "cmboOrderComp";
            this.cmboOrderComp.Size = new System.Drawing.Size(199, 27);
            this.cmboOrderComp.TabIndex = 42;
            this.cmboOrderComp.SelectedIndexChanged += new System.EventHandler(this.cmboOrderComp_SelectedIndexChanged);
            // 
            // ServicesAndOrdering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FLM_Job_Portal.Properties.Resources.Program_Background;
            this.ClientSize = new System.Drawing.Size(1775, 686);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmboOrderComp);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmboServComplete);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cmboJob);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmboService);
            this.Controls.Add(this.btnLineClear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmboPO);
            this.Controls.Add(this.pbAddService);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvOutsideServices);
            this.Controls.Add(this.pbAddOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvOrder);
            this.Name = "ServicesAndOrdering";
            this.Text = "SERVICES AND ORDERING";
            ((System.ComponentModel.ISupportInitialize)(this.pbAddOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvOrder;
        private System.Windows.Forms.ColumnHeader colPO;
        private System.Windows.Forms.ColumnHeader colQuantity;
        private System.Windows.Forms.ColumnHeader colDescription;
        private System.Windows.Forms.ColumnHeader colVendor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbAddOrder;
        private System.Windows.Forms.ColumnHeader colJob;
        private System.Windows.Forms.ColumnHeader colOrdered;
        private System.Windows.Forms.ColumnHeader colETA;
        private System.Windows.Forms.ColumnHeader colReceived;
        private System.Windows.Forms.ListView lvOutsideServices;
        private System.Windows.Forms.ColumnHeader colOSJob;
        private System.Windows.Forms.ColumnHeader colOSQuantity;
        private System.Windows.Forms.ColumnHeader colOSPart;
        private System.Windows.Forms.ColumnHeader colOSService;
        private System.Windows.Forms.ColumnHeader colOSVendor;
        private System.Windows.Forms.ColumnHeader colOSSent;
        private System.Windows.Forms.ColumnHeader colOSETA;
        private System.Windows.Forms.ColumnHeader colOSReceived;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbAddService;
        private System.Windows.Forms.ComboBox cmboPO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLineClear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmboService;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader colBy;
        private System.Windows.Forms.ComboBox cmboJob;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ColumnHeader colOSPo;
        private System.Windows.Forms.ColumnHeader colOSReqBy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmboServComplete;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmboOrderComp;
    }
}