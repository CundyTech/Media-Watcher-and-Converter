using System.ComponentModel;
using System.Windows.Forms;

namespace mkvMediaConverter
{
    partial class BtnClear
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BtnClear));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TpageConvert = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RbtnMP4toMKV = new System.Windows.Forms.RadioButton();
            this.RbtnMKVtoMP4 = new System.Windows.Forms.RadioButton();
            this.BtnWatch = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ChkCustomOutput = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnSlctWtchFldr = new System.Windows.Forms.Button();
            this.TxtWtchFldr = new System.Windows.Forms.TextBox();
            this.TxtOutput = new System.Windows.Forms.TextBox();
            this.TPageOptions = new System.Windows.Forms.TabPage();
            this.ChkDeleteMkv = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.LstOutput = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.TpageConvert.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.TPageOptions.SuspendLayout();
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
            this.TpageConvert.Controls.Add(this.button1);
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
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(617, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 41;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
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
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(631, 367);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 51;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BtnClearOutput_Click);
            // 
            // LstOutput
            // 
            this.LstOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LstOutput.FormattingEnabled = true;
            this.LstOutput.Location = new System.Drawing.Point(4, 168);
            this.LstOutput.Name = "LstOutput";
            this.LstOutput.Size = new System.Drawing.Size(702, 186);
            this.LstOutput.TabIndex = 52;
            // 
            // BtnClear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(711, 402);
            this.Controls.Add(this.LstOutput);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BtnClear";
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
            this.ResumeLayout(false);

        }

        #endregion

        private Timer timer;
        private TabControl tabControl1;
        private TabPage TpageConvert;
        private Button button1;
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
        private Button button2;
        private ListBox LstOutput;
    }
}

