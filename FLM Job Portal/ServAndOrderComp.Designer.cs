namespace FLM_Job_Portal
{
    partial class ServAndOrderComp
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
            this.lblComplete = new System.Windows.Forms.Label();
            this.pbServAndOrder = new System.Windows.Forms.PictureBox();
            this.calComplete = new System.Windows.Forms.MonthCalendar();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblPO = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbServAndOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // lblComplete
            // 
            this.lblComplete.AutoSize = true;
            this.lblComplete.BackColor = System.Drawing.Color.Transparent;
            this.lblComplete.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplete.ForeColor = System.Drawing.Color.White;
            this.lblComplete.Location = new System.Drawing.Point(173, 60);
            this.lblComplete.Name = "lblComplete";
            this.lblComplete.Size = new System.Drawing.Size(240, 78);
            this.lblComplete.TabIndex = 58;
            this.lblComplete.Text = "MARK SERVICE\r\nCOMPLETE\r\n";
            // 
            // pbServAndOrder
            // 
            this.pbServAndOrder.BackColor = System.Drawing.Color.Transparent;
            this.pbServAndOrder.Image = global::FLM_Job_Portal.Properties.Resources.Outside1;
            this.pbServAndOrder.Location = new System.Drawing.Point(16, 23);
            this.pbServAndOrder.Name = "pbServAndOrder";
            this.pbServAndOrder.Size = new System.Drawing.Size(155, 138);
            this.pbServAndOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbServAndOrder.TabIndex = 57;
            this.pbServAndOrder.TabStop = false;
            // 
            // calComplete
            // 
            this.calComplete.Location = new System.Drawing.Point(99, 252);
            this.calComplete.Name = "calComplete";
            this.calComplete.TabIndex = 59;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(247, 444);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(146, 36);
            this.btnSubmit.TabIndex = 61;
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
            this.btnExit.Location = new System.Drawing.Point(34, 444);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(141, 36);
            this.btnExit.TabIndex = 60;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblPO
            // 
            this.lblPO.AutoSize = true;
            this.lblPO.BackColor = System.Drawing.Color.Transparent;
            this.lblPO.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPO.ForeColor = System.Drawing.Color.White;
            this.lblPO.Location = new System.Drawing.Point(27, 182);
            this.lblPO.Name = "lblPO";
            this.lblPO.Size = new System.Drawing.Size(157, 39);
            this.lblPO.TabIndex = 62;
            this.lblPO.Text = "FOR PO #";
            // 
            // ServAndOrderComp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FLM_Job_Portal.Properties.Resources.Program_Background;
            this.ClientSize = new System.Drawing.Size(430, 513);
            this.Controls.Add(this.lblPO);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.calComplete);
            this.Controls.Add(this.lblComplete);
            this.Controls.Add(this.pbServAndOrder);
            this.Name = "ServAndOrderComp";
            this.Text = "MARK SERVICE/ORDER COMPLETE";
            ((System.ComponentModel.ISupportInitialize)(this.pbServAndOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblComplete;
        private System.Windows.Forms.PictureBox pbServAndOrder;
        private System.Windows.Forms.MonthCalendar calComplete;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblPO;
    }
}