namespace EE4Test
{
    partial class frmJobApplicantWebCam
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
            this.panelVideoPreview = new System.Windows.Forms.Panel();
            this.btnPreview = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lstVideoDevices = new System.Windows.Forms.ListBox();
            this.lblVideoDeviceSelectedForPreview = new System.Windows.Forms.Label();
            this.btnGrabImage = new System.Windows.Forms.Button();
            this.checkBoxShowConfigDialog = new System.Windows.Forms.CheckBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.rbSpanish = new System.Windows.Forms.RadioButton();
            this.rbEnglish = new System.Windows.Forms.RadioButton();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelVideoPreview
            // 
            this.panelVideoPreview.Location = new System.Drawing.Point(357, 1);
            this.panelVideoPreview.Name = "panelVideoPreview";
            this.panelVideoPreview.Size = new System.Drawing.Size(325, 240);
            this.panelVideoPreview.TabIndex = 0;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(159, 78);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(94, 32);
            this.btnPreview.TabIndex = 1;
            this.btnPreview.Text = "Start";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 339);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(685, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // lstVideoDevices
            // 
            this.lstVideoDevices.FormattingEnabled = true;
            this.lstVideoDevices.Location = new System.Drawing.Point(13, 12);
            this.lstVideoDevices.Name = "lstVideoDevices";
            this.lstVideoDevices.Size = new System.Drawing.Size(338, 43);
            this.lstVideoDevices.TabIndex = 3;
            // 
            // lblVideoDeviceSelectedForPreview
            // 
            this.lblVideoDeviceSelectedForPreview.AutoSize = true;
            this.lblVideoDeviceSelectedForPreview.Location = new System.Drawing.Point(14, 59);
            this.lblVideoDeviceSelectedForPreview.Name = "lblVideoDeviceSelectedForPreview";
            this.lblVideoDeviceSelectedForPreview.Size = new System.Drawing.Size(173, 13);
            this.lblVideoDeviceSelectedForPreview.TabIndex = 6;
            this.lblVideoDeviceSelectedForPreview.Text = "lblVideoDeviceSelectedForPreview";
            // 
            // btnGrabImage
            // 
            this.btnGrabImage.Enabled = false;
            this.btnGrabImage.Location = new System.Drawing.Point(257, 78);
            this.btnGrabImage.Name = "btnGrabImage";
            this.btnGrabImage.Size = new System.Drawing.Size(94, 32);
            this.btnGrabImage.TabIndex = 8;
            this.btnGrabImage.Text = "Take Picture";
            this.btnGrabImage.UseVisualStyleBackColor = true;
            this.btnGrabImage.Click += new System.EventHandler(this.cmdGrabImage_Click);
            // 
            // checkBoxShowConfigDialog
            // 
            this.checkBoxShowConfigDialog.AutoSize = true;
            this.checkBoxShowConfigDialog.Location = new System.Drawing.Point(3, 312);
            this.checkBoxShowConfigDialog.Name = "checkBoxShowConfigDialog";
            this.checkBoxShowConfigDialog.Size = new System.Drawing.Size(194, 17);
            this.checkBoxShowConfigDialog.TabIndex = 9;
            this.checkBoxShowConfigDialog.Text = "Show config dialogs before preview";
            this.checkBoxShowConfigDialog.UseVisualStyleBackColor = true;
            this.checkBoxShowConfigDialog.Visible = false;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(124, 159);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(227, 170);
            this.webBrowser1.TabIndex = 10;
            this.webBrowser1.Visible = false;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(17, 154);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 11;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(257, 116);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 32);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lstVideoDevices);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnPreview);
            this.panel1.Controls.Add(this.lblMessage);
            this.panel1.Controls.Add(this.lblVideoDeviceSelectedForPreview);
            this.panel1.Controls.Add(this.webBrowser1);
            this.panel1.Controls.Add(this.btnGrabImage);
            this.panel1.Controls.Add(this.checkBoxShowConfigDialog);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 335);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblLanguage);
            this.panel2.Controls.Add(this.rbSpanish);
            this.panel2.Controls.Add(this.rbEnglish);
            this.panel2.Location = new System.Drawing.Point(13, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(87, 70);
            this.panel2.TabIndex = 14;
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(4, 4);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(58, 13);
            this.lblLanguage.TabIndex = 15;
            this.lblLanguage.Text = "Language:";
            // 
            // rbSpanish
            // 
            this.rbSpanish.AutoSize = true;
            this.rbSpanish.Location = new System.Drawing.Point(4, 44);
            this.rbSpanish.Name = "rbSpanish";
            this.rbSpanish.Size = new System.Drawing.Size(63, 17);
            this.rbSpanish.TabIndex = 14;
            this.rbSpanish.TabStop = true;
            this.rbSpanish.Text = "Español";
            this.rbSpanish.UseVisualStyleBackColor = true;
            this.rbSpanish.CheckedChanged += new System.EventHandler(this.rbEnglish_CheckedChanged);
            // 
            // rbEnglish
            // 
            this.rbEnglish.AutoSize = true;
            this.rbEnglish.Location = new System.Drawing.Point(4, 21);
            this.rbEnglish.Name = "rbEnglish";
            this.rbEnglish.Size = new System.Drawing.Size(59, 17);
            this.rbEnglish.TabIndex = 13;
            this.rbEnglish.TabStop = true;
            this.rbEnglish.Text = "English";
            this.rbEnglish.UseVisualStyleBackColor = true;
            this.rbEnglish.CheckedChanged += new System.EventHandler(this.rbEnglish_CheckedChanged);
            // 
            // frmJobApplicantWebCam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(685, 361);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panelVideoPreview);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmJobApplicantWebCam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMILE!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmJobApplicantWebCam_FormClosing);
            this.Load += new System.EventHandler(this.frmJobApplicantWebCam_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelVideoPreview;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ListBox lstVideoDevices;
        private System.Windows.Forms.Label lblVideoDeviceSelectedForPreview;
        private System.Windows.Forms.Button btnGrabImage;
        private System.Windows.Forms.CheckBox checkBoxShowConfigDialog;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.RadioButton rbSpanish;
        private System.Windows.Forms.RadioButton rbEnglish;
    }
}

