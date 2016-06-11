using System.ComponentModel;
using System.Windows.Forms;

namespace mkvMediaConverter
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TpageConvert = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RbtnMP4toMKV = new System.Windows.Forms.RadioButton();
            this.RbtnMKVtoMP4 = new System.Windows.Forms.RadioButton();
            this.BtnWatch = new System.Windows.Forms.Button();
            this.BtnSlctCstmFldr = new System.Windows.Forms.Button();
            this.ChkCustomOutput = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnSlctWtchFldr = new System.Windows.Forms.Button();
            this.TxtWtchFldr = new System.Windows.Forms.TextBox();
            this.TxtOutput = new System.Windows.Forms.TextBox();
            this.TPageOptions = new System.Windows.Forms.TabPage();
            this.ChkDeleteMkv = new System.Windows.Forms.CheckBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.LbConvertedFiles = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.LstOutput = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.LstFfmpegOutput = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.TpageConvert.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.TPageOptions.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.TpageConvert);
            this.tabControl1.Controls.Add(this.TPageOptions);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(710, 162);
            this.tabControl1.TabIndex = 30;
            // 
            // TpageConvert
            // 
            this.TpageConvert.BackColor = System.Drawing.Color.Transparent;
            this.TpageConvert.Controls.Add(this.groupBox3);
            this.TpageConvert.Controls.Add(this.BtnWatch);
            this.TpageConvert.Controls.Add(this.BtnSlctCstmFldr);
            this.TpageConvert.Controls.Add(this.ChkCustomOutput);
            this.TpageConvert.Controls.Add(this.label5);
            this.TpageConvert.Controls.Add(this.BtnSlctWtchFldr);
            this.TpageConvert.Controls.Add(this.TxtWtchFldr);
            this.TpageConvert.Controls.Add(this.TxtOutput);
            this.TpageConvert.ForeColor = System.Drawing.Color.Black;
            this.TpageConvert.Location = new System.Drawing.Point(4, 22);
            this.TpageConvert.Name = "TpageConvert";
            this.TpageConvert.Padding = new System.Windows.Forms.Padding(3);
            this.TpageConvert.Size = new System.Drawing.Size(702, 136);
            this.TpageConvert.TabIndex = 0;
            this.TpageConvert.Text = "Convert";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.RbtnMP4toMKV);
            this.groupBox3.Controls.Add(this.RbtnMKVtoMP4);
            this.groupBox3.Location = new System.Drawing.Point(6, 91);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(603, 28);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            // 
            // RbtnMP4toMKV
            // 
            this.RbtnMP4toMKV.AutoSize = true;
            this.RbtnMP4toMKV.Location = new System.Drawing.Point(94, 9);
            this.RbtnMP4toMKV.Name = "RbtnMP4toMKV";
            this.RbtnMP4toMKV.Size = new System.Drawing.Size(85, 17);
            this.RbtnMP4toMKV.TabIndex = 1;
            this.RbtnMP4toMKV.Text = "MP4 to MKV";
            this.RbtnMP4toMKV.UseVisualStyleBackColor = true;
            this.RbtnMP4toMKV.Visible = false;
            // 
            // RbtnMKVtoMP4
            // 
            this.RbtnMKVtoMP4.AutoSize = true;
            this.RbtnMKVtoMP4.Checked = true;
            this.RbtnMKVtoMP4.Location = new System.Drawing.Point(6, 9);
            this.RbtnMKVtoMP4.Name = "RbtnMKVtoMP4";
            this.RbtnMKVtoMP4.Size = new System.Drawing.Size(85, 17);
            this.RbtnMKVtoMP4.TabIndex = 0;
            this.RbtnMKVtoMP4.TabStop = true;
            this.RbtnMKVtoMP4.Text = "MKV to MP4";
            this.RbtnMKVtoMP4.UseVisualStyleBackColor = true;
            // 
            // BtnWatch
            // 
            this.BtnWatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnWatch.Location = new System.Drawing.Point(617, 97);
            this.BtnWatch.Name = "BtnWatch";
            this.BtnWatch.Size = new System.Drawing.Size(75, 23);
            this.BtnWatch.TabIndex = 42;
            this.BtnWatch.Text = "Watch";
            this.BtnWatch.UseVisualStyleBackColor = true;
            this.BtnWatch.Click += new System.EventHandler(this.BtnWatch_Click);
            // 
            // BtnSlctCstmFldr
            // 
            this.BtnSlctCstmFldr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSlctCstmFldr.Location = new System.Drawing.Point(617, 64);
            this.BtnSlctCstmFldr.Name = "BtnSlctCstmFldr";
            this.BtnSlctCstmFldr.Size = new System.Drawing.Size(75, 23);
            this.BtnSlctCstmFldr.TabIndex = 41;
            this.BtnSlctCstmFldr.Text = "Select";
            this.BtnSlctCstmFldr.UseVisualStyleBackColor = true;
            this.BtnSlctCstmFldr.Click += new System.EventHandler(this.BtnSlctCstmFldr_Click);
            // 
            // ChkCustomOutput
            // 
            this.ChkCustomOutput.AutoSize = true;
            this.ChkCustomOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkCustomOutput.Location = new System.Drawing.Point(6, 48);
            this.ChkCustomOutput.Name = "ChkCustomOutput";
            this.ChkCustomOutput.Size = new System.Drawing.Size(128, 17);
            this.ChkCustomOutput.TabIndex = 40;
            this.ChkCustomOutput.Text = "Custom Output Folder";
            this.ChkCustomOutput.UseVisualStyleBackColor = true;
            this.ChkCustomOutput.CheckedChanged += new System.EventHandler(this.ChkCustomOutput_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Watch Folder:";
            // 
            // BtnSlctWtchFldr
            // 
            this.BtnSlctWtchFldr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSlctWtchFldr.Location = new System.Drawing.Point(617, 22);
            this.BtnSlctWtchFldr.Name = "BtnSlctWtchFldr";
            this.BtnSlctWtchFldr.Size = new System.Drawing.Size(75, 23);
            this.BtnSlctWtchFldr.TabIndex = 36;
            this.BtnSlctWtchFldr.Text = "Select";
            this.BtnSlctWtchFldr.UseVisualStyleBackColor = true;
            this.BtnSlctWtchFldr.Click += new System.EventHandler(this.BtnSlctWtchFldr_Click);
            // 
            // TxtWtchFldr
            // 
            this.TxtWtchFldr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtWtchFldr.Location = new System.Drawing.Point(6, 23);
            this.TxtWtchFldr.Name = "TxtWtchFldr";
            this.TxtWtchFldr.Size = new System.Drawing.Size(603, 20);
            this.TxtWtchFldr.TabIndex = 32;
            // 
            // TxtOutput
            // 
            this.TxtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtOutput.Enabled = false;
            this.TxtOutput.Location = new System.Drawing.Point(6, 66);
            this.TxtOutput.Name = "TxtOutput";
            this.TxtOutput.Size = new System.Drawing.Size(603, 20);
            this.TxtOutput.TabIndex = 33;
            // 
            // TPageOptions
            // 
            this.TPageOptions.BackColor = System.Drawing.Color.Transparent;
            this.TPageOptions.Controls.Add(this.ChkDeleteMkv);
            this.TPageOptions.Location = new System.Drawing.Point(4, 22);
            this.TPageOptions.Name = "TPageOptions";
            this.TPageOptions.Padding = new System.Windows.Forms.Padding(3);
            this.TPageOptions.Size = new System.Drawing.Size(702, 136);
            this.TPageOptions.TabIndex = 1;
            this.TPageOptions.Text = "Options";
            // 
            // ChkDeleteMkv
            // 
            this.ChkDeleteMkv.AutoSize = true;
            this.ChkDeleteMkv.Checked = global::mkvMediaConverter.Properties.Settings.Default.ChkDeleteMkv;
            this.ChkDeleteMkv.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::mkvMediaConverter.Properties.Settings.Default, "ChkDeleteMkv", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ChkDeleteMkv.Location = new System.Drawing.Point(18, 18);
            this.ChkDeleteMkv.Name = "ChkDeleteMkv";
            this.ChkDeleteMkv.Size = new System.Drawing.Size(119, 17);
            this.ChkDeleteMkv.TabIndex = 0;
            this.ChkDeleteMkv.Text = "Delete original .mkv";
            this.ChkDeleteMkv.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Location = new System.Drawing.Point(4, 169);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(702, 274);
            this.tabControl2.TabIndex = 53;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.LbConvertedFiles);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(694, 248);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Converted Files";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // LbConvertedFiles
            // 
            this.LbConvertedFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbConvertedFiles.FormattingEnabled = true;
            this.LbConvertedFiles.Location = new System.Drawing.Point(0, 0);
            this.LbConvertedFiles.Name = "LbConvertedFiles";
            this.LbConvertedFiles.Size = new System.Drawing.Size(694, 212);
            this.LbConvertedFiles.TabIndex = 55;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(613, 219);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 54;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.LstOutput);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(694, 248);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Watcher Logs";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // LstOutput
            // 
            this.LstOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LstOutput.FormattingEnabled = true;
            this.LstOutput.Location = new System.Drawing.Point(0, 0);
            this.LstOutput.Name = "LstOutput";
            this.LstOutput.Size = new System.Drawing.Size(694, 212);
            this.LstOutput.TabIndex = 53;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(613, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 51;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BtnClearOutput_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.LstFfmpegOutput);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(694, 248);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Conversion Logs";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // LstFfmpegOutput
            // 
            this.LstFfmpegOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LstFfmpegOutput.BackColor = System.Drawing.SystemColors.MenuText;
            this.LstFfmpegOutput.ForeColor = System.Drawing.Color.White;
            this.LstFfmpegOutput.FormattingEnabled = true;
            this.LstFfmpegOutput.Location = new System.Drawing.Point(0, 0);
            this.LstFfmpegOutput.Name = "LstFfmpegOutput";
            this.LstFfmpegOutput.Size = new System.Drawing.Size(694, 212);
            this.LstFfmpegOutput.TabIndex = 55;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(613, 219);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 54;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip.Location = new System.Drawing.Point(0, 451);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(711, 22);
            this.statusStrip.TabIndex = 54;
            this.statusStrip.Text = "StpStatus";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(657, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(91, 17);
            this.toolStripStatusLabel2.Text = "Uptime 00:00:00";
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripStatusLabel2.Visible = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(711, 473);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "mkv Media Converter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.TpageConvert.ResumeLayout(false);
            this.TpageConvert.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.TPageOptions.ResumeLayout(false);
            this.TPageOptions.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Timer timer;
        private TabControl tabControl1;
        private TabPage TpageConvert;
        private Button BtnSlctCstmFldr;
        private CheckBox ChkCustomOutput;
        private Label label5;
        private Button BtnSlctWtchFldr;
        private TextBox TxtWtchFldr;
        private TextBox TxtOutput;
        private TabPage TPageOptions;
        private CheckBox ChkDeleteMkv;
        private GroupBox groupBox3;
        private RadioButton RbtnMP4toMKV;
        private RadioButton RbtnMKVtoMP4;
        private Button BtnWatch;
        private TabControl tabControl2;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ListBox LstOutput;
        private Button button2;
        private ListBox LstFfmpegOutput;
        private Button button3;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel toolStripStatusLabel;
        private TabPage tabPage3;
        private ListBox LbConvertedFiles;
        private Button button4;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private Timer timer1;
    }
}

