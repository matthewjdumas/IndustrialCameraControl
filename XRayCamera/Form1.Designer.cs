namespace XRayCamera
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.previewPane = new Emgu.CV.UI.ImageBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cameraList = new System.Windows.Forms.ComboBox();
            this.captureButton = new System.Windows.Forms.Button();
            this.colorSettings = new System.Windows.Forms.GroupBox();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.frameAvg = new System.Windows.Forms.NumericUpDown();
            this.takeSnapshot = new System.Windows.Forms.Button();
            this.recordVideo = new System.Windows.Forms.Button();
            this.filterControl = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.smoothScaling = new System.Windows.Forms.CheckBox();
            this.smoothHeight = new System.Windows.Forms.NumericUpDown();
            this.smoothWidth = new System.Windows.Forms.NumericUpDown();
            this.smoothFilterEn = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.medianSize = new System.Windows.Forms.NumericUpDown();
            this.medianFilterEn = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.spaceSigma = new System.Windows.Forms.NumericUpDown();
            this.colorSigma = new System.Windows.Forms.NumericUpDown();
            this.kernelSize = new System.Windows.Forms.NumericUpDown();
            this.bilateralFilterEn = new System.Windows.Forms.CheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.standardDevVer = new System.Windows.Forms.NumericUpDown();
            this.standardDevHor = new System.Windows.Forms.NumericUpDown();
            this.kernelHeight = new System.Windows.Forms.NumericUpDown();
            this.kernelWidth = new System.Windows.Forms.NumericUpDown();
            this.gaussEn = new System.Windows.Forms.CheckBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.aperatureSize = new System.Windows.Forms.NumericUpDown();
            this.yOrder = new System.Windows.Forms.NumericUpDown();
            this.xOrder = new System.Windows.Forms.NumericUpDown();
            this.sobelEn = new System.Windows.Forms.CheckBox();
            this.changeLoc = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.stoLoc = new System.Windows.Forms.Label();
            this.browseDlg = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.imgSettingsTab = new System.Windows.Forms.TabPage();
            this.cameraSettingsBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.previewPane)).BeginInit();
            this.colorSettings.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frameAvg)).BeginInit();
            this.filterControl.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smoothHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smoothWidth)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medianSize)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spaceSigma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorSigma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kernelSize)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.standardDevVer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardDevHor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kernelHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kernelWidth)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aperatureSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xOrder)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.imgSettingsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // previewPane
            // 
            this.previewPane.Location = new System.Drawing.Point(205, 38);
            this.previewPane.Name = "previewPane";
            this.previewPane.Size = new System.Drawing.Size(1920, 1080);
            this.previewPane.TabIndex = 2;
            this.previewPane.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(583, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Camera:";
            // 
            // cameraList
            // 
            this.cameraList.FormattingEnabled = true;
            this.cameraList.Location = new System.Drawing.Point(668, 11);
            this.cameraList.Name = "cameraList";
            this.cameraList.Size = new System.Drawing.Size(575, 21);
            this.cameraList.TabIndex = 4;
            // 
            // captureButton
            // 
            this.captureButton.Location = new System.Drawing.Point(205, 8);
            this.captureButton.Name = "captureButton";
            this.captureButton.Size = new System.Drawing.Size(372, 23);
            this.captureButton.TabIndex = 5;
            this.captureButton.Text = "Start Capture";
            this.captureButton.UseVisualStyleBackColor = true;
            this.captureButton.Click += new System.EventHandler(this.captureButton_Click);
            // 
            // colorSettings
            // 
            this.colorSettings.Controls.Add(this.radioButton7);
            this.colorSettings.Controls.Add(this.radioButton5);
            this.colorSettings.Location = new System.Drawing.Point(6, 3);
            this.colorSettings.Name = "colorSettings";
            this.colorSettings.Size = new System.Drawing.Size(165, 46);
            this.colorSettings.TabIndex = 4;
            this.colorSettings.TabStop = false;
            this.colorSettings.Text = "Color Settings";
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(78, 19);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(47, 17);
            this.radioButton7.TabIndex = 2;
            this.radioButton7.Text = "Gray";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Checked = true;
            this.radioButton5.Location = new System.Drawing.Point(7, 19);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(49, 17);
            this.radioButton5.TabIndex = 0;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Color";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton4);
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Location = new System.Drawing.Point(6, 98);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(165, 74);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resolution";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(7, 44);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(84, 17);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "1920 x 1080";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(7, 20);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(84, 17);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.Text = "2592 x 1944";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(6, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(165, 37);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FPS";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(78, 14);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(37, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "30";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 14);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(37, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "15";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // frameAvg
            // 
            this.frameAvg.Location = new System.Drawing.Point(12, 43);
            this.frameAvg.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.frameAvg.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.frameAvg.Name = "frameAvg";
            this.frameAvg.Size = new System.Drawing.Size(145, 20);
            this.frameAvg.TabIndex = 7;
            this.frameAvg.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // takeSnapshot
            // 
            this.takeSnapshot.Location = new System.Drawing.Point(13, 335);
            this.takeSnapshot.Name = "takeSnapshot";
            this.takeSnapshot.Size = new System.Drawing.Size(185, 23);
            this.takeSnapshot.TabIndex = 8;
            this.takeSnapshot.Text = "Take Snapshot";
            this.takeSnapshot.UseVisualStyleBackColor = true;
            this.takeSnapshot.Click += new System.EventHandler(this.takeSnapshot_Click);
            // 
            // recordVideo
            // 
            this.recordVideo.Location = new System.Drawing.Point(13, 364);
            this.recordVideo.Name = "recordVideo";
            this.recordVideo.Size = new System.Drawing.Size(185, 23);
            this.recordVideo.TabIndex = 9;
            this.recordVideo.Text = "Start Recording";
            this.recordVideo.UseVisualStyleBackColor = true;
            this.recordVideo.Click += new System.EventHandler(this.recordVideo_Click);
            // 
            // filterControl
            // 
            this.filterControl.Controls.Add(this.tabPage6);
            this.filterControl.Controls.Add(this.tabPage1);
            this.filterControl.Controls.Add(this.tabPage2);
            this.filterControl.Controls.Add(this.tabPage3);
            this.filterControl.Controls.Add(this.tabPage4);
            this.filterControl.Controls.Add(this.tabPage5);
            this.filterControl.Location = new System.Drawing.Point(14, 434);
            this.filterControl.Name = "filterControl";
            this.filterControl.SelectedIndex = 0;
            this.filterControl.Size = new System.Drawing.Size(185, 320);
            this.filterControl.TabIndex = 10;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.label16);
            this.tabPage6.Controls.Add(this.frameAvg);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(177, 294);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Frame Averaging";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 17);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(148, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "Number of Frames to Average";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.smoothScaling);
            this.tabPage1.Controls.Add(this.smoothHeight);
            this.tabPage1.Controls.Add(this.smoothWidth);
            this.tabPage1.Controls.Add(this.smoothFilterEn);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(177, 294);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Smooth";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Width";
            // 
            // smoothScaling
            // 
            this.smoothScaling.AutoSize = true;
            this.smoothScaling.Location = new System.Drawing.Point(7, 132);
            this.smoothScaling.Name = "smoothScaling";
            this.smoothScaling.Size = new System.Drawing.Size(61, 17);
            this.smoothScaling.TabIndex = 3;
            this.smoothScaling.Text = "Scaling";
            this.smoothScaling.UseVisualStyleBackColor = true;
            // 
            // smoothHeight
            // 
            this.smoothHeight.Location = new System.Drawing.Point(7, 95);
            this.smoothHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.smoothHeight.Name = "smoothHeight";
            this.smoothHeight.Size = new System.Drawing.Size(120, 20);
            this.smoothHeight.TabIndex = 2;
            this.smoothHeight.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // smoothWidth
            // 
            this.smoothWidth.Location = new System.Drawing.Point(7, 52);
            this.smoothWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.smoothWidth.Name = "smoothWidth";
            this.smoothWidth.Size = new System.Drawing.Size(120, 20);
            this.smoothWidth.TabIndex = 1;
            this.smoothWidth.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // smoothFilterEn
            // 
            this.smoothFilterEn.AutoSize = true;
            this.smoothFilterEn.Location = new System.Drawing.Point(7, 7);
            this.smoothFilterEn.Name = "smoothFilterEn";
            this.smoothFilterEn.Size = new System.Drawing.Size(59, 17);
            this.smoothFilterEn.TabIndex = 0;
            this.smoothFilterEn.Text = "Enable";
            this.smoothFilterEn.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.medianSize);
            this.tabPage2.Controls.Add(this.medianFilterEn);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(177, 294);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Median";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Size";
            // 
            // medianSize
            // 
            this.medianSize.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.medianSize.Location = new System.Drawing.Point(7, 59);
            this.medianSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.medianSize.Name = "medianSize";
            this.medianSize.Size = new System.Drawing.Size(120, 20);
            this.medianSize.TabIndex = 1;
            this.medianSize.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // medianFilterEn
            // 
            this.medianFilterEn.AutoSize = true;
            this.medianFilterEn.Location = new System.Drawing.Point(7, 7);
            this.medianFilterEn.Name = "medianFilterEn";
            this.medianFilterEn.Size = new System.Drawing.Size(59, 17);
            this.medianFilterEn.TabIndex = 0;
            this.medianFilterEn.Text = "Enable";
            this.medianFilterEn.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.spaceSigma);
            this.tabPage3.Controls.Add(this.colorSigma);
            this.tabPage3.Controls.Add(this.kernelSize);
            this.tabPage3.Controls.Add(this.bilateralFilterEn);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(177, 294);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Bilateral";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Space Sigma";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Color Space Sigma";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Kernel Size";
            // 
            // spaceSigma
            // 
            this.spaceSigma.Location = new System.Drawing.Point(4, 140);
            this.spaceSigma.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.spaceSigma.Name = "spaceSigma";
            this.spaceSigma.Size = new System.Drawing.Size(120, 20);
            this.spaceSigma.TabIndex = 3;
            this.spaceSigma.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // colorSigma
            // 
            this.colorSigma.Location = new System.Drawing.Point(4, 101);
            this.colorSigma.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.colorSigma.Name = "colorSigma";
            this.colorSigma.Size = new System.Drawing.Size(120, 20);
            this.colorSigma.TabIndex = 2;
            this.colorSigma.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // kernelSize
            // 
            this.kernelSize.Location = new System.Drawing.Point(4, 60);
            this.kernelSize.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.kernelSize.Name = "kernelSize";
            this.kernelSize.Size = new System.Drawing.Size(120, 20);
            this.kernelSize.TabIndex = 1;
            this.kernelSize.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // bilateralFilterEn
            // 
            this.bilateralFilterEn.AutoSize = true;
            this.bilateralFilterEn.Location = new System.Drawing.Point(4, 13);
            this.bilateralFilterEn.Name = "bilateralFilterEn";
            this.bilateralFilterEn.Size = new System.Drawing.Size(59, 17);
            this.bilateralFilterEn.TabIndex = 0;
            this.bilateralFilterEn.Text = "Enable";
            this.bilateralFilterEn.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.standardDevVer);
            this.tabPage4.Controls.Add(this.standardDevHor);
            this.tabPage4.Controls.Add(this.kernelHeight);
            this.tabPage4.Controls.Add(this.kernelWidth);
            this.tabPage4.Controls.Add(this.gaussEn);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(177, 294);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Gaussian";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 161);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "StDev Vert";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(0, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "StDev Horizontal";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Kernel Height";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(0, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Kernel Width";
            // 
            // standardDevVer
            // 
            this.standardDevVer.DecimalPlaces = 3;
            this.standardDevVer.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.standardDevVer.Location = new System.Drawing.Point(4, 180);
            this.standardDevVer.Name = "standardDevVer";
            this.standardDevVer.Size = new System.Drawing.Size(120, 20);
            this.standardDevVer.TabIndex = 4;
            this.standardDevVer.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            // 
            // standardDevHor
            // 
            this.standardDevHor.DecimalPlaces = 3;
            this.standardDevHor.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.standardDevHor.Location = new System.Drawing.Point(4, 136);
            this.standardDevHor.Name = "standardDevHor";
            this.standardDevHor.Size = new System.Drawing.Size(120, 20);
            this.standardDevHor.TabIndex = 3;
            this.standardDevHor.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            // 
            // kernelHeight
            // 
            this.kernelHeight.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.kernelHeight.Location = new System.Drawing.Point(4, 86);
            this.kernelHeight.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.kernelHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.kernelHeight.Name = "kernelHeight";
            this.kernelHeight.Size = new System.Drawing.Size(120, 20);
            this.kernelHeight.TabIndex = 2;
            this.kernelHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // kernelWidth
            // 
            this.kernelWidth.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.kernelWidth.Location = new System.Drawing.Point(4, 45);
            this.kernelWidth.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.kernelWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.kernelWidth.Name = "kernelWidth";
            this.kernelWidth.Size = new System.Drawing.Size(120, 20);
            this.kernelWidth.TabIndex = 1;
            this.kernelWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // gaussEn
            // 
            this.gaussEn.AutoSize = true;
            this.gaussEn.Location = new System.Drawing.Point(4, 4);
            this.gaussEn.Name = "gaussEn";
            this.gaussEn.Size = new System.Drawing.Size(59, 17);
            this.gaussEn.TabIndex = 0;
            this.gaussEn.Text = "Enable";
            this.gaussEn.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label15);
            this.tabPage5.Controls.Add(this.label14);
            this.tabPage5.Controls.Add(this.label13);
            this.tabPage5.Controls.Add(this.aperatureSize);
            this.tabPage5.Controls.Add(this.yOrder);
            this.tabPage5.Controls.Add(this.xOrder);
            this.tabPage5.Controls.Add(this.sobelEn);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(177, 294);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Sobel";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 98);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Y Order";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "X Order";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 145);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(140, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Aperature Size (1,3,5,7 only)";
            // 
            // aperatureSize
            // 
            this.aperatureSize.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.aperatureSize.Location = new System.Drawing.Point(4, 164);
            this.aperatureSize.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.aperatureSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.aperatureSize.Name = "aperatureSize";
            this.aperatureSize.Size = new System.Drawing.Size(120, 20);
            this.aperatureSize.TabIndex = 3;
            this.aperatureSize.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // yOrder
            // 
            this.yOrder.Location = new System.Drawing.Point(4, 112);
            this.yOrder.Name = "yOrder";
            this.yOrder.Size = new System.Drawing.Size(120, 20);
            this.yOrder.TabIndex = 2;
            // 
            // xOrder
            // 
            this.xOrder.Location = new System.Drawing.Point(4, 71);
            this.xOrder.Name = "xOrder";
            this.xOrder.Size = new System.Drawing.Size(120, 20);
            this.xOrder.TabIndex = 1;
            this.xOrder.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // sobelEn
            // 
            this.sobelEn.AutoSize = true;
            this.sobelEn.Location = new System.Drawing.Point(4, 19);
            this.sobelEn.Name = "sobelEn";
            this.sobelEn.Size = new System.Drawing.Size(59, 17);
            this.sobelEn.TabIndex = 0;
            this.sobelEn.Text = "Enable";
            this.sobelEn.UseVisualStyleBackColor = true;
            // 
            // changeLoc
            // 
            this.changeLoc.Location = new System.Drawing.Point(13, 306);
            this.changeLoc.Name = "changeLoc";
            this.changeLoc.Size = new System.Drawing.Size(185, 23);
            this.changeLoc.TabIndex = 11;
            this.changeLoc.Text = "Change Storage Location";
            this.changeLoc.UseVisualStyleBackColor = true;
            this.changeLoc.Click += new System.EventHandler(this.changeLoc_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(10, 257);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(128, 13);
            this.label17.TabIndex = 12;
            this.label17.Text = "Current Storage Location:";
            // 
            // stoLoc
            // 
            this.stoLoc.AutoSize = true;
            this.stoLoc.Location = new System.Drawing.Point(13, 274);
            this.stoLoc.Name = "stoLoc";
            this.stoLoc.Size = new System.Drawing.Size(0, 13);
            this.stoLoc.TabIndex = 13;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.imgSettingsTab);
            this.tabControl1.Location = new System.Drawing.Point(13, 38);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(185, 206);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.groupBox3);
            this.tabPage7.Controls.Add(this.groupBox2);
            this.tabPage7.Controls.Add(this.colorSettings);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(177, 180);
            this.tabPage7.TabIndex = 0;
            this.tabPage7.Text = "Capture Settings";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // imgSettingsTab
            // 
            this.imgSettingsTab.Controls.Add(this.cameraSettingsBtn);
            this.imgSettingsTab.Location = new System.Drawing.Point(4, 22);
            this.imgSettingsTab.Name = "imgSettingsTab";
            this.imgSettingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.imgSettingsTab.Size = new System.Drawing.Size(177, 180);
            this.imgSettingsTab.TabIndex = 1;
            this.imgSettingsTab.Text = "Image Settings";
            this.imgSettingsTab.UseVisualStyleBackColor = true;
            // 
            // cameraSettingsBtn
            // 
            this.cameraSettingsBtn.Enabled = false;
            this.cameraSettingsBtn.Location = new System.Drawing.Point(6, 55);
            this.cameraSettingsBtn.Name = "cameraSettingsBtn";
            this.cameraSettingsBtn.Size = new System.Drawing.Size(158, 23);
            this.cameraSettingsBtn.TabIndex = 15;
            this.cameraSettingsBtn.Text = "Open Camera Settings Dlg";
            this.cameraSettingsBtn.UseVisualStyleBackColor = true;
            this.cameraSettingsBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1062);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.stoLoc);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.changeLoc);
            this.Controls.Add(this.filterControl);
            this.Controls.Add(this.recordVideo);
            this.Controls.Add(this.takeSnapshot);
            this.Controls.Add(this.captureButton);
            this.Controls.Add(this.cameraList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.previewPane);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.previewPane)).EndInit();
            this.colorSettings.ResumeLayout(false);
            this.colorSettings.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frameAvg)).EndInit();
            this.filterControl.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smoothHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smoothWidth)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medianSize)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spaceSigma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorSigma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kernelSize)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.standardDevVer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardDevHor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kernelHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kernelWidth)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aperatureSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xOrder)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.imgSettingsTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox previewPane;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cameraList;
        private System.Windows.Forms.Button captureButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.NumericUpDown frameAvg;
        private System.Windows.Forms.Button takeSnapshot;
        private System.Windows.Forms.Button recordVideo;
        private System.Windows.Forms.TabControl filterControl;
        public System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox smoothScaling;
        private System.Windows.Forms.NumericUpDown smoothHeight;
        private System.Windows.Forms.NumericUpDown smoothWidth;
        private System.Windows.Forms.CheckBox smoothFilterEn;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox medianFilterEn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown medianSize;
        private System.Windows.Forms.CheckBox bilateralFilterEn;
        private System.Windows.Forms.NumericUpDown spaceSigma;
        private System.Windows.Forms.NumericUpDown colorSigma;
        private System.Windows.Forms.NumericUpDown kernelSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox gaussEn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown standardDevVer;
        private System.Windows.Forms.NumericUpDown standardDevHor;
        private System.Windows.Forms.NumericUpDown kernelHeight;
        private System.Windows.Forms.NumericUpDown kernelWidth;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.CheckBox sobelEn;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown aperatureSize;
        private System.Windows.Forms.NumericUpDown yOrder;
        private System.Windows.Forms.NumericUpDown xOrder;
        private System.Windows.Forms.GroupBox colorSettings;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button changeLoc;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label stoLoc;
        private System.Windows.Forms.FolderBrowserDialog browseDlg;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage imgSettingsTab;
        private System.Windows.Forms.Button cameraSettingsBtn;
    }
}

