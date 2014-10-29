//--------------------------------------------------------------------
// FILENAME:		FormDWAPISample.Designer.cs
//
// Copyright(c) 2009 Motorola, Inc. All rights reserved.
//
// DESCRIPTION:		Visual Studio generated file for DataWedge API 
//                  CSharp Sample Application
//--------------------------------------------------------------------
namespace CSharpDWAPISample
{
    partial class FormDWAPISample
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.Line1 = new System.Windows.Forms.Button();
            this.Line0 = new System.Windows.Forms.Button();
            this.checkBoxRunning = new System.Windows.Forms.CheckBox();
            this.Line2 = new System.Windows.Forms.Button();
            this.btnDisable = new System.Windows.Forms.Button();
            this.btnEnable = new System.Windows.Forms.Button();
            this.line3 = new System.Windows.Forms.Button();
            this.btnGetStatus = new System.Windows.Forms.Button();
            this.checkBoxPersist = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDWVersion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(3, 65);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(62, 25);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(71, 65);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(62, 25);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // Line1
            // 
            this.Line1.Location = new System.Drawing.Point(0, 96);
            this.Line1.Name = "Line1";
            this.Line1.Size = new System.Drawing.Size(400, 2);
            this.Line1.TabIndex = 4;
            // 
            // Line0
            // 
            this.Line0.Location = new System.Drawing.Point(0, 57);
            this.Line0.Name = "Line0";
            this.Line0.Size = new System.Drawing.Size(400, 2);
            this.Line0.TabIndex = 5;
            // 
            // checkBoxRunning
            // 
            this.checkBoxRunning.ThreeState = true;
            this.checkBoxRunning.AutoCheck = false;
            this.checkBoxRunning.Location = new System.Drawing.Point(4, 31);
            this.checkBoxRunning.Name = "checkBoxRunning";
            this.checkBoxRunning.Size = new System.Drawing.Size(236, 20);
            this.checkBoxRunning.TabIndex = 6;
            this.checkBoxRunning.Text = "DataWedge is running";
            // 
            // Line2
            // 
            this.Line2.Location = new System.Drawing.Point(0, 135);
            this.Line2.Name = "Line2";
            this.Line2.Size = new System.Drawing.Size(400, 2);
            this.Line2.TabIndex = 9;
            // 
            // btnDisable
            // 
            this.btnDisable.Location = new System.Drawing.Point(71, 104);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(62, 25);
            this.btnDisable.TabIndex = 8;
            this.btnDisable.Text = "Disable";
            this.btnDisable.Click += new System.EventHandler(this.btnDisable_Click);
            // 
            // btnEnable
            // 
            this.btnEnable.Location = new System.Drawing.Point(3, 104);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(62, 25);
            this.btnEnable.TabIndex = 7;
            this.btnEnable.Text = "Enable";
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // line3
            // 
            this.line3.Location = new System.Drawing.Point(0, 174);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(400, 2);
            this.line3.TabIndex = 12;
            // 
            // btnGetStatus
            // 
            this.btnGetStatus.Location = new System.Drawing.Point(3, 143);
            this.btnGetStatus.Name = "btnGetStatus";
            this.btnGetStatus.Size = new System.Drawing.Size(62, 25);
            this.btnGetStatus.TabIndex = 10;
            this.btnGetStatus.Text = "Status";
            this.btnGetStatus.Click += new System.EventHandler(this.btnGetStatus_Click);
            // 
            // checkBoxPersist
            // 
            this.checkBoxPersist.Checked = true;
            this.checkBoxPersist.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPersist.Location = new System.Drawing.Point(140, 105);
            this.checkBoxPersist.Name = "checkBoxPersist";
            this.checkBoxPersist.Size = new System.Drawing.Size(100, 20);
            this.checkBoxPersist.TabIndex = 13;
            this.checkBoxPersist.Text = "Persist";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(4, 182);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(62, 25);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(400, 2);
            this.button1.TabIndex = 15;
            // 
            // btnDWVersion
            // 
            this.btnDWVersion.Location = new System.Drawing.Point(71, 143);
            this.btnDWVersion.Name = "btnDWVersion";
            this.btnDWVersion.Size = new System.Drawing.Size(62, 25);
            this.btnDWVersion.TabIndex = 16;
            this.btnDWVersion.Text = "Version";
            this.btnDWVersion.Click += new System.EventHandler(this.btnDWVersion_Click);
            // 
            // FormDWAPISample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.btnDWVersion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.checkBoxPersist);
            this.Controls.Add(this.line3);
            this.Controls.Add(this.btnGetStatus);
            this.Controls.Add(this.Line2);
            this.Controls.Add(this.btnDisable);
            this.Controls.Add(this.btnEnable);
            this.Controls.Add(this.checkBoxRunning);
            this.Controls.Add(this.Line0);
            this.Controls.Add(this.Line1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(0, 0);
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "FormDWAPISample";
            this.Text = "DWAPI C# Sample";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDWAPISample_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.FormDWAPISample_Closing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormDWAPISample_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button Line1;
        private System.Windows.Forms.Button Line0;
        private System.Windows.Forms.CheckBox checkBoxRunning;
        private System.Windows.Forms.Button Line2;
        private System.Windows.Forms.Button btnDisable;
        private System.Windows.Forms.Button btnEnable;
        private System.Windows.Forms.Button line3;
        private System.Windows.Forms.Button btnGetStatus;
        private System.Windows.Forms.CheckBox checkBoxPersist;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDWVersion;

    }
}

