﻿
namespace Hashtool
{
    partial class AboutBox
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox));
            this.okButton = new System.Windows.Forms.Button();
            this.labelSrcCodeURL = new System.Windows.Forms.Label();
            this.linkLabelSrcCodeURL = new System.Windows.Forms.LinkLabel();
            this.labelIntro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okButton.Location = new System.Drawing.Point(153, 89);
            this.okButton.Margin = new System.Windows.Forms.Padding(4);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(95, 31);
            this.okButton.TabIndex = 24;
            this.okButton.Text = "OK";
            // 
            // labelSrcCodeURL
            // 
            this.labelSrcCodeURL.AutoSize = true;
            this.labelSrcCodeURL.Location = new System.Drawing.Point(19, 55);
            this.labelSrcCodeURL.Name = "labelSrcCodeURL";
            this.labelSrcCodeURL.Size = new System.Drawing.Size(69, 19);
            this.labelSrcCodeURL.TabIndex = 26;
            this.labelSrcCodeURL.Text = "Where?";
            // 
            // linkLabelSrcCodeURL
            // 
            this.linkLabelSrcCodeURL.AutoSize = true;
            this.linkLabelSrcCodeURL.Location = new System.Drawing.Point(104, 55);
            this.linkLabelSrcCodeURL.Name = "linkLabelSrcCodeURL";
            this.linkLabelSrcCodeURL.Size = new System.Drawing.Size(79, 19);
            this.linkLabelSrcCodeURL.TabIndex = 27;
            this.linkLabelSrcCodeURL.TabStop = true;
            this.linkLabelSrcCodeURL.Text = "CodeURL";
            this.linkLabelSrcCodeURL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCodeAddr_LinkClicked);
            // 
            // labelIntro
            // 
            this.labelIntro.Location = new System.Drawing.Point(19, 12);
            this.labelIntro.Name = "labelIntro";
            this.labelIntro.Size = new System.Drawing.Size(484, 43);
            this.labelIntro.TabIndex = 28;
            this.labelIntro.Text = "ProgramIntro";
            // 
            // AboutBox
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 211);
            this.Controls.Add(this.labelIntro);
            this.Controls.Add(this.linkLabelSrcCodeURL);
            this.Controls.Add(this.labelSrcCodeURL);
            this.Controls.Add(this.okButton);
            this.Font = new System.Drawing.Font("Noto Mono", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox";
            this.Padding = new System.Windows.Forms.Padding(16, 12, 16, 12);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About the gadget?";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AboutBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label labelSrcCodeURL;
        private System.Windows.Forms.LinkLabel linkLabelSrcCodeURL;
        private System.Windows.Forms.Label labelIntro;
    }
}
