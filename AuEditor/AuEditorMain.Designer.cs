namespace AuEditor
{
    partial class AuEditorMain
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
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.gbFileInfo = new System.Windows.Forms.GroupBox();
            this.lblIsValid = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblSamplesPerChannel = new System.Windows.Forms.Label();
            this.lblBytesPerSample = new System.Windows.Forms.Label();
            this.lblChannels = new System.Windows.Forms.Label();
            this.lblSampleRate = new System.Windows.Forms.Label();
            this.lblEncoding = new System.Windows.Forms.Label();
            this.lblDataSize = new System.Windows.Forms.Label();
            this.lblHeaderSize = new System.Windows.Forms.Label();
            this.lblMagicNumber = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlWave = new System.Windows.Forms.Panel();
            this.gbActions = new System.Windows.Forms.GroupBox();
            this.btnApplyFadeIn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCurrentFile = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnSaveFileAs = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.gbFileInfo.SuspendLayout();
            this.gbActions.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(12, 12);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // gbFileInfo
            // 
            this.gbFileInfo.Controls.Add(this.lblIsValid);
            this.gbFileInfo.Controls.Add(this.label8);
            this.gbFileInfo.Controls.Add(this.lblDuration);
            this.gbFileInfo.Controls.Add(this.lblSamplesPerChannel);
            this.gbFileInfo.Controls.Add(this.lblBytesPerSample);
            this.gbFileInfo.Controls.Add(this.lblChannels);
            this.gbFileInfo.Controls.Add(this.lblSampleRate);
            this.gbFileInfo.Controls.Add(this.lblEncoding);
            this.gbFileInfo.Controls.Add(this.lblDataSize);
            this.gbFileInfo.Controls.Add(this.lblHeaderSize);
            this.gbFileInfo.Controls.Add(this.lblMagicNumber);
            this.gbFileInfo.Controls.Add(this.label12);
            this.gbFileInfo.Controls.Add(this.label14);
            this.gbFileInfo.Controls.Add(this.label7);
            this.gbFileInfo.Controls.Add(this.label6);
            this.gbFileInfo.Controls.Add(this.label5);
            this.gbFileInfo.Controls.Add(this.label4);
            this.gbFileInfo.Controls.Add(this.label3);
            this.gbFileInfo.Controls.Add(this.label2);
            this.gbFileInfo.Controls.Add(this.label1);
            this.gbFileInfo.Location = new System.Drawing.Point(12, 41);
            this.gbFileInfo.Name = "gbFileInfo";
            this.gbFileInfo.Size = new System.Drawing.Size(210, 153);
            this.gbFileInfo.TabIndex = 1;
            this.gbFileInfo.TabStop = false;
            this.gbFileInfo.Text = "File Info";
            // 
            // lblIsValid
            // 
            this.lblIsValid.AutoSize = true;
            this.lblIsValid.ForeColor = System.Drawing.Color.Red;
            this.lblIsValid.Location = new System.Drawing.Point(102, 133);
            this.lblIsValid.Name = "lblIsValid";
            this.lblIsValid.Size = new System.Drawing.Size(32, 13);
            this.lblIsValid.TabIndex = 20;
            this.lblIsValid.Text = "False";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(6, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Valid Header:";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDuration.Location = new System.Drawing.Point(102, 120);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(13, 13);
            this.lblDuration.TabIndex = 18;
            this.lblDuration.Text = "0";
            // 
            // lblSamplesPerChannel
            // 
            this.lblSamplesPerChannel.AutoSize = true;
            this.lblSamplesPerChannel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblSamplesPerChannel.Location = new System.Drawing.Point(102, 107);
            this.lblSamplesPerChannel.Name = "lblSamplesPerChannel";
            this.lblSamplesPerChannel.Size = new System.Drawing.Size(13, 13);
            this.lblSamplesPerChannel.TabIndex = 17;
            this.lblSamplesPerChannel.Text = "0";
            // 
            // lblBytesPerSample
            // 
            this.lblBytesPerSample.AutoSize = true;
            this.lblBytesPerSample.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblBytesPerSample.Location = new System.Drawing.Point(102, 94);
            this.lblBytesPerSample.Name = "lblBytesPerSample";
            this.lblBytesPerSample.Size = new System.Drawing.Size(13, 13);
            this.lblBytesPerSample.TabIndex = 16;
            this.lblBytesPerSample.Text = "0";
            // 
            // lblChannels
            // 
            this.lblChannels.AutoSize = true;
            this.lblChannels.Location = new System.Drawing.Point(102, 81);
            this.lblChannels.Name = "lblChannels";
            this.lblChannels.Size = new System.Drawing.Size(13, 13);
            this.lblChannels.TabIndex = 15;
            this.lblChannels.Text = "0";
            // 
            // lblSampleRate
            // 
            this.lblSampleRate.AutoSize = true;
            this.lblSampleRate.Location = new System.Drawing.Point(102, 68);
            this.lblSampleRate.Name = "lblSampleRate";
            this.lblSampleRate.Size = new System.Drawing.Size(13, 13);
            this.lblSampleRate.TabIndex = 14;
            this.lblSampleRate.Text = "0";
            // 
            // lblEncoding
            // 
            this.lblEncoding.AutoSize = true;
            this.lblEncoding.Location = new System.Drawing.Point(102, 55);
            this.lblEncoding.Name = "lblEncoding";
            this.lblEncoding.Size = new System.Drawing.Size(33, 13);
            this.lblEncoding.TabIndex = 13;
            this.lblEncoding.Text = "None";
            // 
            // lblDataSize
            // 
            this.lblDataSize.AutoSize = true;
            this.lblDataSize.Location = new System.Drawing.Point(102, 42);
            this.lblDataSize.Name = "lblDataSize";
            this.lblDataSize.Size = new System.Drawing.Size(13, 13);
            this.lblDataSize.TabIndex = 12;
            this.lblDataSize.Text = "0";
            // 
            // lblHeaderSize
            // 
            this.lblHeaderSize.AutoSize = true;
            this.lblHeaderSize.Location = new System.Drawing.Point(102, 29);
            this.lblHeaderSize.Name = "lblHeaderSize";
            this.lblHeaderSize.Size = new System.Drawing.Size(13, 13);
            this.lblHeaderSize.TabIndex = 11;
            this.lblHeaderSize.Text = "0";
            // 
            // lblMagicNumber
            // 
            this.lblMagicNumber.AutoSize = true;
            this.lblMagicNumber.Location = new System.Drawing.Point(102, 16);
            this.lblMagicNumber.Name = "lblMagicNumber";
            this.lblMagicNumber.Size = new System.Drawing.Size(13, 13);
            this.lblMagicNumber.TabIndex = 10;
            this.lblMagicNumber.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label12.Location = new System.Drawing.Point(6, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Duration:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label14.Location = new System.Drawing.Point(6, 107);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Samples/Channel:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(6, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Bytes/Sample:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Channels:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sample Rate:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Encoding:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data Size:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Header Size:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Magic Number:";
            // 
            // pnlWave
            // 
            this.pnlWave.BackColor = System.Drawing.Color.White;
            this.pnlWave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlWave.Location = new System.Drawing.Point(12, 200);
            this.pnlWave.Name = "pnlWave";
            this.pnlWave.Size = new System.Drawing.Size(460, 200);
            this.pnlWave.TabIndex = 0;
            this.pnlWave.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlWave_Paint);
            // 
            // gbActions
            // 
            this.gbActions.Controls.Add(this.radioButton5);
            this.gbActions.Controls.Add(this.radioButton1);
            this.gbActions.Controls.Add(this.radioButton2);
            this.gbActions.Enabled = false;
            this.gbActions.Location = new System.Drawing.Point(228, 12);
            this.gbActions.Name = "gbActions";
            this.gbActions.Size = new System.Drawing.Size(88, 89);
            this.gbActions.TabIndex = 3;
            this.gbActions.TabStop = false;
            this.gbActions.Text = "Audio Effect";
            // 
            // btnApplyFadeIn
            // 
            this.btnApplyFadeIn.Location = new System.Drawing.Point(60, 152);
            this.btnApplyFadeIn.Name = "btnApplyFadeIn";
            this.btnApplyFadeIn.Size = new System.Drawing.Size(75, 23);
            this.btnApplyFadeIn.TabIndex = 0;
            this.btnApplyFadeIn.Text = "Apply";
            this.btnApplyFadeIn.UseVisualStyleBackColor = true;
            this.btnApplyFadeIn.Click += new System.EventHandler(this.btnApplyFadeIn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblCurrentFile});
            this.statusStrip1.Location = new System.Drawing.Point(0, 411);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(486, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(71, 17);
            this.toolStripStatusLabel1.Text = "Current File:";
            // 
            // lblCurrentFile
            // 
            this.lblCurrentFile.Name = "lblCurrentFile";
            this.lblCurrentFile.Size = new System.Drawing.Size(36, 17);
            this.lblCurrentFile.Text = "None";
            // 
            // btnSaveFileAs
            // 
            this.btnSaveFileAs.Enabled = false;
            this.btnSaveFileAs.Location = new System.Drawing.Point(93, 12);
            this.btnSaveFileAs.Name = "btnSaveFileAs";
            this.btnSaveFileAs.Size = new System.Drawing.Size(75, 23);
            this.btnSaveFileAs.TabIndex = 5;
            this.btnSaveFileAs.Text = "Save File";
            this.btnSaveFileAs.UseVisualStyleBackColor = true;
            this.btnSaveFileAs.Click += new System.EventHandler(this.btnSaveFileAs_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.btnApplyFadeIn);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Location = new System.Drawing.Point(322, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 182);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Effect Options";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(61, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Fade In";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(69, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Fade Out";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 14);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(54, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Linear";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 37);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(79, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Logarithmic";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(83, 95);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(52, 20);
            this.numericUpDown1.TabIndex = 4;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(83, 121);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(52, 20);
            this.numericUpDown2.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(83, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(52, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Channel:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Start:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Duration:";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(6, 65);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(75, 17);
            this.radioButton5.TabIndex = 2;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "CrossFade";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Play";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AuEditorMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 433);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlWave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSaveFileAs);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gbActions);
            this.Controls.Add(this.gbFileInfo);
            this.Controls.Add(this.btnOpenFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AuEditorMain";
            this.Text = "Au Editor";
            this.gbFileInfo.ResumeLayout(false);
            this.gbFileInfo.PerformLayout();
            this.gbActions.ResumeLayout(false);
            this.gbActions.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.GroupBox gbFileInfo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblSamplesPerChannel;
        private System.Windows.Forms.Label lblBytesPerSample;
        private System.Windows.Forms.Label lblChannels;
        private System.Windows.Forms.Label lblSampleRate;
        private System.Windows.Forms.Label lblEncoding;
        private System.Windows.Forms.Label lblDataSize;
        private System.Windows.Forms.Label lblHeaderSize;
        private System.Windows.Forms.Label lblMagicNumber;
        private System.Windows.Forms.Label lblIsValid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbActions;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblCurrentFile;
        private System.Windows.Forms.Panel pnlWave;
        private System.Windows.Forms.Button btnSaveFileAs;
        private System.Windows.Forms.Button btnApplyFadeIn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Button button1;
    }
}

