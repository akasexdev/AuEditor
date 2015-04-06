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
            this.gbEffects = new System.Windows.Forms.GroupBox();
            this.rbCrossFade = new System.Windows.Forms.RadioButton();
            this.rbFadeIn = new System.Windows.Forms.RadioButton();
            this.rbFadeOut = new System.Windows.Forms.RadioButton();
            this.btnApplyEffect = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCurrentFile = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCurrentEffect = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblEffectOption = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnSaveFileAs = new System.Windows.Forms.Button();
            this.gbEffectOptions = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.rbLogarithmic = new System.Windows.Forms.RadioButton();
            this.rbLinear = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nuDuration = new System.Windows.Forms.NumericUpDown();
            this.nuStart = new System.Windows.Forms.NumericUpDown();
            this.btnPlayAudio = new System.Windows.Forms.Button();
            this.btnSetMaxDuration = new System.Windows.Forms.Button();
            this.gbFileInfo.SuspendLayout();
            this.gbEffects.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.gbEffectOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuStart)).BeginInit();
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
            this.gbFileInfo.Size = new System.Drawing.Size(237, 153);
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
            this.pnlWave.Size = new System.Drawing.Size(472, 200);
            this.pnlWave.TabIndex = 0;
            this.pnlWave.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlWave_Paint);
            // 
            // gbEffects
            // 
            this.gbEffects.Controls.Add(this.rbCrossFade);
            this.gbEffects.Controls.Add(this.rbFadeIn);
            this.gbEffects.Controls.Add(this.rbFadeOut);
            this.gbEffects.Enabled = false;
            this.gbEffects.Location = new System.Drawing.Point(255, 9);
            this.gbEffects.Name = "gbEffects";
            this.gbEffects.Size = new System.Drawing.Size(229, 39);
            this.gbEffects.TabIndex = 3;
            this.gbEffects.TabStop = false;
            this.gbEffects.Text = "Audio Effect";
            // 
            // rbCrossFade
            // 
            this.rbCrossFade.AutoSize = true;
            this.rbCrossFade.Location = new System.Drawing.Point(148, 19);
            this.rbCrossFade.Name = "rbCrossFade";
            this.rbCrossFade.Size = new System.Drawing.Size(75, 17);
            this.rbCrossFade.TabIndex = 2;
            this.rbCrossFade.Text = "CrossFade";
            this.rbCrossFade.UseVisualStyleBackColor = true;
            this.rbCrossFade.CheckedChanged += new System.EventHandler(this.rbCrossFade_CheckedChanged);
            // 
            // rbFadeIn
            // 
            this.rbFadeIn.AutoSize = true;
            this.rbFadeIn.Checked = true;
            this.rbFadeIn.Location = new System.Drawing.Point(6, 19);
            this.rbFadeIn.Name = "rbFadeIn";
            this.rbFadeIn.Size = new System.Drawing.Size(61, 17);
            this.rbFadeIn.TabIndex = 0;
            this.rbFadeIn.TabStop = true;
            this.rbFadeIn.Text = "Fade In";
            this.rbFadeIn.UseVisualStyleBackColor = true;
            this.rbFadeIn.CheckedChanged += new System.EventHandler(this.rbFadeIn_CheckedChanged);
            // 
            // rbFadeOut
            // 
            this.rbFadeOut.AutoSize = true;
            this.rbFadeOut.Location = new System.Drawing.Point(73, 19);
            this.rbFadeOut.Name = "rbFadeOut";
            this.rbFadeOut.Size = new System.Drawing.Size(69, 17);
            this.rbFadeOut.TabIndex = 1;
            this.rbFadeOut.Text = "Fade Out";
            this.rbFadeOut.UseVisualStyleBackColor = true;
            this.rbFadeOut.CheckedChanged += new System.EventHandler(this.rbFadeOut_CheckedChanged);
            // 
            // btnApplyEffect
            // 
            this.btnApplyEffect.Enabled = false;
            this.btnApplyEffect.Location = new System.Drawing.Point(6, 68);
            this.btnApplyEffect.Name = "btnApplyEffect";
            this.btnApplyEffect.Size = new System.Drawing.Size(75, 23);
            this.btnApplyEffect.TabIndex = 0;
            this.btnApplyEffect.Text = "Apply";
            this.btnApplyEffect.UseVisualStyleBackColor = true;
            this.btnApplyEffect.Click += new System.EventHandler(this.btnApplyEffect_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblCurrentFile,
            this.toolStripStatusLabel2,
            this.lblCurrentEffect,
            this.toolStripStatusLabel3,
            this.lblEffectOption});
            this.statusStrip1.Location = new System.Drawing.Point(0, 411);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(630, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(28, 17);
            this.toolStripStatusLabel1.Text = "File:";
            // 
            // lblCurrentFile
            // 
            this.lblCurrentFile.Name = "lblCurrentFile";
            this.lblCurrentFile.Size = new System.Drawing.Size(36, 17);
            this.lblCurrentFile.Text = "None";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(40, 17);
            this.toolStripStatusLabel2.Text = "Effect:";
            // 
            // lblCurrentEffect
            // 
            this.lblCurrentEffect.Name = "lblCurrentEffect";
            this.lblCurrentEffect.Size = new System.Drawing.Size(36, 17);
            this.lblCurrentEffect.Text = "None";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(47, 17);
            this.toolStripStatusLabel3.Text = "Option:";
            // 
            // lblEffectOption
            // 
            this.lblEffectOption.Name = "lblEffectOption";
            this.lblEffectOption.Size = new System.Drawing.Size(39, 17);
            this.lblEffectOption.Text = "Linear";
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
            // gbEffectOptions
            // 
            this.gbEffectOptions.Controls.Add(this.btnSetMaxDuration);
            this.gbEffectOptions.Controls.Add(this.lblStatus);
            this.gbEffectOptions.Controls.Add(this.rbLogarithmic);
            this.gbEffectOptions.Controls.Add(this.rbLinear);
            this.gbEffectOptions.Controls.Add(this.label11);
            this.gbEffectOptions.Controls.Add(this.label10);
            this.gbEffectOptions.Controls.Add(this.nuDuration);
            this.gbEffectOptions.Controls.Add(this.btnApplyEffect);
            this.gbEffectOptions.Controls.Add(this.nuStart);
            this.gbEffectOptions.Enabled = false;
            this.gbEffectOptions.Location = new System.Drawing.Point(255, 54);
            this.gbEffectOptions.Name = "gbEffectOptions";
            this.gbEffectOptions.Size = new System.Drawing.Size(229, 140);
            this.gbEffectOptions.TabIndex = 1;
            this.gbEffectOptions.TabStop = false;
            this.gbEffectOptions.Text = "Effect Options";
            // 
            // lblStatus
            // 
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatus.ForeColor = System.Drawing.Color.Green;
            this.lblStatus.Location = new System.Drawing.Point(6, 97);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(217, 40);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "Not Applied";
            // 
            // rbLogarithmic
            // 
            this.rbLogarithmic.AutoSize = true;
            this.rbLogarithmic.Location = new System.Drawing.Point(6, 37);
            this.rbLogarithmic.Name = "rbLogarithmic";
            this.rbLogarithmic.Size = new System.Drawing.Size(79, 17);
            this.rbLogarithmic.TabIndex = 3;
            this.rbLogarithmic.Text = "Logarithmic";
            this.rbLogarithmic.UseVisualStyleBackColor = true;
            this.rbLogarithmic.CheckedChanged += new System.EventHandler(this.rbLogarithmic_CheckedChanged);
            // 
            // rbLinear
            // 
            this.rbLinear.AutoSize = true;
            this.rbLinear.Checked = true;
            this.rbLinear.Location = new System.Drawing.Point(6, 14);
            this.rbLinear.Name = "rbLinear";
            this.rbLinear.Size = new System.Drawing.Size(54, 17);
            this.rbLinear.TabIndex = 2;
            this.rbLinear.TabStop = true;
            this.rbLinear.Text = "Linear";
            this.rbLinear.UseVisualStyleBackColor = true;
            this.rbLinear.CheckedChanged += new System.EventHandler(this.rbLinear_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(115, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Duration:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(107, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Start Time:";
            // 
            // nuDuration
            // 
            this.nuDuration.DecimalPlaces = 2;
            this.nuDuration.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nuDuration.Location = new System.Drawing.Point(171, 40);
            this.nuDuration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuDuration.Name = "nuDuration";
            this.nuDuration.Size = new System.Drawing.Size(52, 20);
            this.nuDuration.TabIndex = 5;
            this.nuDuration.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nuStart
            // 
            this.nuStart.DecimalPlaces = 2;
            this.nuStart.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nuStart.Location = new System.Drawing.Point(171, 14);
            this.nuStart.Name = "nuStart";
            this.nuStart.Size = new System.Drawing.Size(52, 20);
            this.nuStart.TabIndex = 4;
            // 
            // btnPlayAudio
            // 
            this.btnPlayAudio.Enabled = false;
            this.btnPlayAudio.Location = new System.Drawing.Point(174, 12);
            this.btnPlayAudio.Name = "btnPlayAudio";
            this.btnPlayAudio.Size = new System.Drawing.Size(75, 23);
            this.btnPlayAudio.TabIndex = 6;
            this.btnPlayAudio.Text = "Play";
            this.btnPlayAudio.UseVisualStyleBackColor = true;
            // 
            // btnSetMaxDuration
            // 
            this.btnSetMaxDuration.Location = new System.Drawing.Point(118, 68);
            this.btnSetMaxDuration.Name = "btnSetMaxDuration";
            this.btnSetMaxDuration.Size = new System.Drawing.Size(105, 23);
            this.btnSetMaxDuration.TabIndex = 12;
            this.btnSetMaxDuration.Text = "Set Max Duration";
            this.btnSetMaxDuration.UseVisualStyleBackColor = true;
            this.btnSetMaxDuration.Click += new System.EventHandler(this.btnSetMaxDuration_Click);
            // 
            // AuEditorMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 433);
            this.Controls.Add(this.btnPlayAudio);
            this.Controls.Add(this.pnlWave);
            this.Controls.Add(this.gbEffectOptions);
            this.Controls.Add(this.btnSaveFileAs);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gbEffects);
            this.Controls.Add(this.gbFileInfo);
            this.Controls.Add(this.btnOpenFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AuEditorMain";
            this.Text = "Au Editor";
            this.gbFileInfo.ResumeLayout(false);
            this.gbFileInfo.PerformLayout();
            this.gbEffects.ResumeLayout(false);
            this.gbEffects.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.gbEffectOptions.ResumeLayout(false);
            this.gbEffectOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuStart)).EndInit();
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
        private System.Windows.Forms.GroupBox gbEffects;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblCurrentFile;
        private System.Windows.Forms.Panel pnlWave;
        private System.Windows.Forms.Button btnSaveFileAs;
        private System.Windows.Forms.Button btnApplyEffect;
        private System.Windows.Forms.GroupBox gbEffectOptions;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nuDuration;
        private System.Windows.Forms.NumericUpDown nuStart;
        private System.Windows.Forms.RadioButton rbLogarithmic;
        private System.Windows.Forms.RadioButton rbLinear;
        private System.Windows.Forms.RadioButton rbFadeOut;
        private System.Windows.Forms.RadioButton rbFadeIn;
        private System.Windows.Forms.RadioButton rbCrossFade;
        private System.Windows.Forms.Button btnPlayAudio;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lblCurrentEffect;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel lblEffectOption;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnSetMaxDuration;
    }
}

