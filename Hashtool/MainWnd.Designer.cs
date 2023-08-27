
namespace Hashtool
{
    partial class MainWnd
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWnd));
            this.textResult = new System.Windows.Forms.TextBox();
            this.cbSHA2_384 = new System.Windows.Forms.CheckBox();
            this.cbSHA3_384 = new System.Windows.Forms.CheckBox();
            this.cbSHA2_256 = new System.Windows.Forms.CheckBox();
            this.cbSHA3_256 = new System.Windows.Forms.CheckBox();
            this.cbSM3 = new System.Windows.Forms.CheckBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.labelSingle = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.pbSingle = new System.Windows.Forms.ProgressBar();
            this.pbTotal = new System.Windows.Forms.ProgressBar();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnAbout = new System.Windows.Forms.Button();
            this.cbSHA2_512 = new System.Windows.Forms.CheckBox();
            this.algPanel = new System.Windows.Forms.TableLayoutPanel();
            this.cbSHA3_512 = new System.Windows.Forms.CheckBox();
            this.panelStatus = new System.Windows.Forms.TableLayoutPanel();
            this.panelSetting = new System.Windows.Forms.TableLayoutPanel();
            this.cbUpperCase = new System.Windows.Forms.CheckBox();
            this.cbUseMultiThread = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlButton.SuspendLayout();
            this.algPanel.SuspendLayout();
            this.panelStatus.SuspendLayout();
            this.panelSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // textResult
            // 
            this.textResult.AllowDrop = true;
            this.textResult.BackColor = System.Drawing.SystemColors.Window;
            this.textResult.Location = new System.Drawing.Point(4, 5);
            this.textResult.Margin = new System.Windows.Forms.Padding(0);
            this.textResult.Multiline = true;
            this.textResult.Name = "textResult";
            this.textResult.ReadOnly = true;
            this.textResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textResult.Size = new System.Drawing.Size(513, 313);
            this.textResult.TabIndex = 0;
            this.textResult.WordWrap = false;
            this.textResult.DragDrop += new System.Windows.Forms.DragEventHandler(this.textResult_DragDrop);
            this.textResult.DragEnter += new System.Windows.Forms.DragEventHandler(this.textResult_DragEnter);
            // 
            // cbSHA2_384
            // 
            this.cbSHA2_384.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSHA2_384.AutoSize = true;
            this.cbSHA2_384.Location = new System.Drawing.Point(1, 57);
            this.cbSHA2_384.Margin = new System.Windows.Forms.Padding(0);
            this.cbSHA2_384.Name = "cbSHA2_384";
            this.cbSHA2_384.Size = new System.Drawing.Size(94, 28);
            this.cbSHA2_384.TabIndex = 2;
            this.cbSHA2_384.Text = "SHA384";
            this.cbSHA2_384.UseVisualStyleBackColor = true;
            // 
            // cbSHA3_384
            // 
            this.cbSHA3_384.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSHA3_384.AutoSize = true;
            this.cbSHA3_384.Location = new System.Drawing.Point(1, 141);
            this.cbSHA3_384.Margin = new System.Windows.Forms.Padding(0);
            this.cbSHA3_384.Name = "cbSHA3_384";
            this.cbSHA3_384.Size = new System.Drawing.Size(94, 28);
            this.cbSHA3_384.TabIndex = 5;
            this.cbSHA3_384.Text = "SHA3-384";
            this.cbSHA3_384.UseVisualStyleBackColor = true;
            // 
            // cbSHA2_256
            // 
            this.cbSHA2_256.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSHA2_256.AutoSize = true;
            this.cbSHA2_256.Location = new System.Drawing.Point(1, 29);
            this.cbSHA2_256.Margin = new System.Windows.Forms.Padding(0);
            this.cbSHA2_256.Name = "cbSHA2_256";
            this.cbSHA2_256.Size = new System.Drawing.Size(94, 28);
            this.cbSHA2_256.TabIndex = 1;
            this.cbSHA2_256.Text = "SHA256";
            this.toolTip1.SetToolTip(this.cbSHA2_256, "美國SHA-256, ISO/IEC 10118-3:2018");
            this.cbSHA2_256.UseVisualStyleBackColor = true;
            // 
            // cbSHA3_256
            // 
            this.cbSHA3_256.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSHA3_256.AutoSize = true;
            this.cbSHA3_256.Location = new System.Drawing.Point(1, 113);
            this.cbSHA3_256.Margin = new System.Windows.Forms.Padding(0);
            this.cbSHA3_256.Name = "cbSHA3_256";
            this.cbSHA3_256.Size = new System.Drawing.Size(94, 28);
            this.cbSHA3_256.TabIndex = 4;
            this.cbSHA3_256.Text = "SHA3-256";
            this.toolTip1.SetToolTip(this.cbSHA3_256, "美國SHA3-256, ISO/IEC 10118-3:2018");
            this.cbSHA3_256.UseVisualStyleBackColor = true;
            // 
            // cbSM3
            // 
            this.cbSM3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSM3.AutoSize = true;
            this.cbSM3.Location = new System.Drawing.Point(1, 1);
            this.cbSM3.Margin = new System.Windows.Forms.Padding(0);
            this.cbSM3.Name = "cbSM3";
            this.cbSM3.Size = new System.Drawing.Size(94, 28);
            this.cbSM3.TabIndex = 0;
            this.cbSM3.Text = "SM3";
            this.toolTip1.SetToolTip(this.cbSM3, "中華人民共和國國密3 , ISO/IEC 10118-3:2018");
            this.cbSM3.UseVisualStyleBackColor = true;
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.AutoSize = true;
            this.btnOpen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOpen.Location = new System.Drawing.Point(1, 1);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(0);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(101, 38);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "打開(O)";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // labelSingle
            // 
            this.labelSingle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSingle.AutoSize = true;
            this.labelSingle.Location = new System.Drawing.Point(1, 1);
            this.labelSingle.Margin = new System.Windows.Forms.Padding(0);
            this.labelSingle.Name = "labelSingle";
            this.labelSingle.Size = new System.Drawing.Size(74, 24);
            this.labelSingle.TabIndex = 3;
            this.labelSingle.Text = "當前進度";
            // 
            // labelTotal
            // 
            this.labelTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(1, 26);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(74, 24);
            this.labelTotal.TabIndex = 4;
            this.labelTotal.Text = "總進度";
            // 
            // pbSingle
            // 
            this.pbSingle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSingle.Location = new System.Drawing.Point(75, 3);
            this.pbSingle.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.pbSingle.MarqueeAnimationSpeed = 1000;
            this.pbSingle.Maximum = 10000;
            this.pbSingle.Name = "pbSingle";
            this.pbSingle.Size = new System.Drawing.Size(551, 21);
            this.pbSingle.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbSingle.TabIndex = 5;
            // 
            // pbTotal
            // 
            this.pbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbTotal.Location = new System.Drawing.Point(75, 28);
            this.pbTotal.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.pbTotal.MarqueeAnimationSpeed = 1000;
            this.pbTotal.Maximum = 10000;
            this.pbTotal.Name = "pbTotal";
            this.pbTotal.Size = new System.Drawing.Size(551, 21);
            this.pbTotal.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbTotal.TabIndex = 6;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.AutoSize = true;
            this.btnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClear.Location = new System.Drawing.Point(102, 1);
            this.btnClear.Margin = new System.Windows.Forms.Padding(0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(101, 38);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "清除(L)";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.AutoSize = true;
            this.btnCopy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCopy.Location = new System.Drawing.Point(203, 1);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(0);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(101, 38);
            this.btnCopy.TabIndex = 8;
            this.btnCopy.Text = "複製(C)";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.AutoSize = true;
            this.btnStop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStop.Location = new System.Drawing.Point(405, 1);
            this.btnStop.Margin = new System.Windows.Forms.Padding(0);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(101, 38);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "停止(T)";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.AutoSize = true;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Location = new System.Drawing.Point(304, 1);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 38);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "儲存(S)";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlButton
            // 
            this.pnlButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlButton.ColumnCount = 6;
            this.pnlButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.pnlButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.pnlButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.pnlButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.pnlButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.pnlButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.pnlButton.Controls.Add(this.btnOpen, 0, 0);
            this.pnlButton.Controls.Add(this.btnSave, 3, 0);
            this.pnlButton.Controls.Add(this.btnClear, 1, 0);
            this.pnlButton.Controls.Add(this.btnCopy, 2, 0);
            this.pnlButton.Controls.Add(this.btnStop, 4, 0);
            this.pnlButton.Controls.Add(this.btnAbout, 5, 0);
            this.pnlButton.Location = new System.Drawing.Point(4, 323);
            this.pnlButton.Margin = new System.Windows.Forms.Padding(0);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Padding = new System.Windows.Forms.Padding(1);
            this.pnlButton.RowCount = 1;
            this.pnlButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlButton.Size = new System.Drawing.Size(612, 40);
            this.pnlButton.TabIndex = 11;
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbout.AutoSize = true;
            this.btnAbout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAbout.Location = new System.Drawing.Point(506, 1);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(0);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(105, 38);
            this.btnAbout.TabIndex = 11;
            this.btnAbout.Text = "關於(A)";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // cbSHA2_512
            // 
            this.cbSHA2_512.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSHA2_512.AutoSize = true;
            this.cbSHA2_512.Location = new System.Drawing.Point(1, 85);
            this.cbSHA2_512.Margin = new System.Windows.Forms.Padding(0);
            this.cbSHA2_512.Name = "cbSHA2_512";
            this.cbSHA2_512.Size = new System.Drawing.Size(94, 28);
            this.cbSHA2_512.TabIndex = 3;
            this.cbSHA2_512.Text = "SHA512";
            this.toolTip1.SetToolTip(this.cbSHA2_512, "美國SHA-512, ISO/IEC 10118-3:2018");
            this.cbSHA2_512.UseVisualStyleBackColor = true;
            // 
            // algPanel
            // 
            this.algPanel.AutoSize = true;
            this.algPanel.ColumnCount = 1;
            this.algPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.algPanel.Controls.Add(this.cbSHA2_256, 0, 2);
            this.algPanel.Controls.Add(this.cbSM3, 0, 1);
            this.algPanel.Controls.Add(this.cbSHA3_384, 0, 6);
            this.algPanel.Controls.Add(this.cbSHA2_384, 0, 3);
            this.algPanel.Controls.Add(this.cbSHA2_512, 0, 4);
            this.algPanel.Controls.Add(this.cbSHA3_512, 0, 7);
            this.algPanel.Controls.Add(this.cbSHA3_256, 0, 5);
            this.algPanel.Location = new System.Drawing.Point(520, 5);
            this.algPanel.Margin = new System.Windows.Forms.Padding(0);
            this.algPanel.Name = "algPanel";
            this.algPanel.Padding = new System.Windows.Forms.Padding(1);
            this.algPanel.RowCount = 8;
            this.algPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.algPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.algPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.algPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.algPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.algPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.algPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.algPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.algPanel.Size = new System.Drawing.Size(96, 227);
            this.algPanel.TabIndex = 12;
            // 
            // cbSHA3_512
            // 
            this.cbSHA3_512.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSHA3_512.AutoSize = true;
            this.cbSHA3_512.Location = new System.Drawing.Point(1, 169);
            this.cbSHA3_512.Margin = new System.Windows.Forms.Padding(0);
            this.cbSHA3_512.Name = "cbSHA3_512";
            this.cbSHA3_512.Size = new System.Drawing.Size(94, 28);
            this.cbSHA3_512.TabIndex = 6;
            this.cbSHA3_512.Text = "SHA3-512";
            this.toolTip1.SetToolTip(this.cbSHA3_512, "美國SHA3-512, ISO/IEC 10118-3:2018");
            this.cbSHA3_512.UseVisualStyleBackColor = true;
            // 
            // panelStatus
            // 
            this.panelStatus.AutoSize = true;
            this.panelStatus.ColumnCount = 2;
            this.panelStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelStatus.Controls.Add(this.labelTotal, 0, 1);
            this.panelStatus.Controls.Add(this.labelSingle, 0, 0);
            this.panelStatus.Controls.Add(this.pbTotal, 1, 1);
            this.panelStatus.Controls.Add(this.pbSingle, 1, 0);
            this.panelStatus.Location = new System.Drawing.Point(4, 365);
            this.panelStatus.Margin = new System.Windows.Forms.Padding(0);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Padding = new System.Windows.Forms.Padding(1);
            this.panelStatus.RowCount = 2;
            this.panelStatus.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelStatus.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.panelStatus.Size = new System.Drawing.Size(627, 52);
            this.panelStatus.TabIndex = 13;
            // 
            // panelSetting
            // 
            this.panelSetting.AutoSize = true;
            this.panelSetting.ColumnCount = 1;
            this.panelSetting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelSetting.Controls.Add(this.cbUpperCase, 0, 0);
            this.panelSetting.Controls.Add(this.cbUseMultiThread, 0, 1);
            this.panelSetting.Location = new System.Drawing.Point(520, 260);
            this.panelSetting.Margin = new System.Windows.Forms.Padding(0);
            this.panelSetting.Name = "panelSetting";
            this.panelSetting.Padding = new System.Windows.Forms.Padding(1);
            this.panelSetting.RowCount = 2;
            this.panelSetting.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelSetting.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelSetting.Size = new System.Drawing.Size(96, 58);
            this.panelSetting.TabIndex = 14;
            // 
            // cbUpperCase
            // 
            this.cbUpperCase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbUpperCase.AutoSize = true;
            this.cbUpperCase.Location = new System.Drawing.Point(1, 1);
            this.cbUpperCase.Margin = new System.Windows.Forms.Padding(0);
            this.cbUpperCase.Name = "cbUpperCase";
            this.cbUpperCase.Size = new System.Drawing.Size(94, 28);
            this.cbUpperCase.TabIndex = 0;
            this.cbUpperCase.Text = "結果大寫";
            this.toolTip1.SetToolTip(this.cbUpperCase, "驗證碼以大階顯示");
            this.cbUpperCase.UseVisualStyleBackColor = true;
            // 
            // cbUseMultiThread
            // 
            this.cbUseMultiThread.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbUseMultiThread.AutoSize = true;
            this.cbUseMultiThread.Location = new System.Drawing.Point(1, 29);
            this.cbUseMultiThread.Margin = new System.Windows.Forms.Padding(0);
            this.cbUseMultiThread.Name = "cbUseMultiThread";
            this.cbUseMultiThread.Size = new System.Drawing.Size(94, 28);
            this.cbUseMultiThread.TabIndex = 1;
            this.cbUseMultiThread.Text = "做快點";
            this.toolTip1.SetToolTip(this.cbUseMultiThread, "快點出到結果不好嗎?");
            this.cbUseMultiThread.UseVisualStyleBackColor = true;
            // 
            // MainWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(622, 423);
            this.Controls.Add(this.panelSetting);
            this.Controls.Add(this.panelStatus);
            this.Controls.Add(this.algPanel);
            this.Controls.Add(this.pnlButton);
            this.Controls.Add(this.textResult);
            this.Font = new System.Drawing.Font("Noto Sans Mono CJK TC Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "MainWnd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "朱熹改Hashtool";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlButton.PerformLayout();
            this.algPanel.ResumeLayout(false);
            this.algPanel.PerformLayout();
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            this.panelSetting.ResumeLayout(false);
            this.panelSetting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.CheckBox cbSHA2_384; //SHA384
        private System.Windows.Forms.CheckBox cbSHA3_384; //SHA3-384
        private System.Windows.Forms.CheckBox cbSHA2_256;
        private System.Windows.Forms.CheckBox cbSHA3_256;
        private System.Windows.Forms.CheckBox cbSM3;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label labelSingle;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.ProgressBar pbSingle;
        private System.Windows.Forms.ProgressBar pbTotal;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TableLayoutPanel pnlButton;
        private System.Windows.Forms.CheckBox cbSHA2_512;
        private System.Windows.Forms.TableLayoutPanel algPanel;
        private System.Windows.Forms.TableLayoutPanel panelStatus;
        private System.Windows.Forms.TableLayoutPanel panelSetting;
        private System.Windows.Forms.CheckBox cbUpperCase;
        private System.Windows.Forms.CheckBox cbUseMultiThread;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.CheckBox cbSHA3_512;
    }
}

