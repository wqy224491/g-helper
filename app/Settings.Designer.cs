using CustomControls;

namespace GHelper
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.panelMatrix = new System.Windows.Forms.Panel();
            this.checkMatrix = new System.Windows.Forms.CheckBox();
            this.tableLayoutMatrix = new System.Windows.Forms.TableLayoutPanel();
            this.comboMatrix = new CustomControls.RComboBox();
            this.comboMatrixRunning = new CustomControls.RComboBox();
            this.buttonMatrix = new CustomControls.RButton();
            this.pictureMatrix = new System.Windows.Forms.PictureBox();
            this.labelMatrix = new System.Windows.Forms.Label();
            this.panelBattery = new System.Windows.Forms.Panel();
            this.sliderBattery = new WinFormsSliderBar.Slider();
            this.labelModel = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelBattery = new System.Windows.Forms.Label();
            this.pictureBattery = new System.Windows.Forms.PictureBox();
            this.labelBatteryTitle = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.buttonQuit = new CustomControls.RButton();
            this.checkStartup = new System.Windows.Forms.CheckBox();
            this.panelPerformance = new System.Windows.Forms.Panel();
            this.picturePerf = new System.Windows.Forms.PictureBox();
            this.labelPerf = new System.Windows.Forms.Label();
            this.labelCPUFan = new System.Windows.Forms.Label();
            this.tablePerf = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSilent = new CustomControls.RButton();
            this.buttonBalanced = new CustomControls.RButton();
            this.buttonTurbo = new CustomControls.RButton();
            this.buttonFans = new CustomControls.RButton();
            this.panelGPU = new System.Windows.Forms.Panel();
            this.pictureGPU = new System.Windows.Forms.PictureBox();
            this.labelGPU = new System.Windows.Forms.Label();
            this.labelGPUFan = new System.Windows.Forms.Label();
            this.tableGPU = new System.Windows.Forms.TableLayoutPanel();
            this.buttonXGM = new CustomControls.RButton();
            this.buttonEco = new CustomControls.RButton();
            this.buttonStandard = new CustomControls.RButton();
            this.buttonOptimized = new CustomControls.RButton();
            this.buttonUltimate = new CustomControls.RButton();
            this.labelTipGPU = new System.Windows.Forms.Label();
            this.panelScreen = new System.Windows.Forms.Panel();
            this.labelMidFan = new System.Windows.Forms.Label();
            this.labelTipScreen = new System.Windows.Forms.Label();
            this.tableScreen = new System.Windows.Forms.TableLayoutPanel();
            this.buttonScreenAuto = new CustomControls.RButton();
            this.button60Hz = new CustomControls.RButton();
            this.button120Hz = new CustomControls.RButton();
            this.buttonOD = new CustomControls.RButton();
            this.buttonMiniled = new CustomControls.RButton();
            this.pictureScreen = new System.Windows.Forms.PictureBox();
            this.labelSreen = new System.Windows.Forms.Label();
            this.panelKeyboard = new System.Windows.Forms.Panel();
            this.tableLayoutKeyboard = new System.Windows.Forms.TableLayoutPanel();
            this.comboKeyboard = new CustomControls.RComboBox();
            this.panelColor = new System.Windows.Forms.Panel();
            this.pictureColor2 = new System.Windows.Forms.PictureBox();
            this.pictureColor = new System.Windows.Forms.PictureBox();
            this.buttonKeyboardColor = new CustomControls.RButton();
            this.buttonKeyboard = new CustomControls.RButton();
            this.pictureKeyboard = new System.Windows.Forms.PictureBox();
            this.labelKeyboard = new System.Windows.Forms.Label();
            this.panelMatrix.SuspendLayout();
            this.tableLayoutMatrix.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMatrix)).BeginInit();
            this.panelBattery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBattery)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.panelPerformance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePerf)).BeginInit();
            this.tablePerf.SuspendLayout();
            this.panelGPU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGPU)).BeginInit();
            this.tableGPU.SuspendLayout();
            this.panelScreen.SuspendLayout();
            this.tableScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureScreen)).BeginInit();
            this.panelKeyboard.SuspendLayout();
            this.tableLayoutKeyboard.SuspendLayout();
            this.panelColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureColor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureKeyboard)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMatrix
            // 
            this.panelMatrix.AutoSize = true;
            this.panelMatrix.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelMatrix.Controls.Add(this.checkMatrix);
            this.panelMatrix.Controls.Add(this.tableLayoutMatrix);
            this.panelMatrix.Controls.Add(this.pictureMatrix);
            this.panelMatrix.Controls.Add(this.labelMatrix);
            this.panelMatrix.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMatrix.Location = new System.Drawing.Point(6, 476);
            this.panelMatrix.Margin = new System.Windows.Forms.Padding(5);
            this.panelMatrix.Name = "panelMatrix";
            this.panelMatrix.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.panelMatrix.Size = new System.Drawing.Size(496, 108);
            this.panelMatrix.TabIndex = 33;
            // 
            // checkMatrix
            // 
            this.checkMatrix.AutoSize = true;
            this.checkMatrix.ForeColor = System.Drawing.SystemColors.GrayText;
            this.checkMatrix.Location = new System.Drawing.Point(15, 76);
            this.checkMatrix.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.checkMatrix.Name = "checkMatrix";
            this.checkMatrix.Size = new System.Drawing.Size(155, 24);
            this.checkMatrix.TabIndex = 44;
            this.checkMatrix.Text = global::GHelper.Properties.Strings.TurnOffOnBattery;
            this.checkMatrix.UseVisualStyleBackColor = true;
            // 
            // tableLayoutMatrix
            // 
            this.tableLayoutMatrix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutMatrix.AutoSize = true;
            this.tableLayoutMatrix.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutMatrix.ColumnCount = 3;
            this.tableLayoutMatrix.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutMatrix.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutMatrix.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutMatrix.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutMatrix.Controls.Add(this.comboMatrix, 0, 0);
            this.tableLayoutMatrix.Controls.Add(this.comboMatrixRunning, 1, 0);
            this.tableLayoutMatrix.Controls.Add(this.buttonMatrix, 2, 0);
            this.tableLayoutMatrix.Location = new System.Drawing.Point(10, 35);
            this.tableLayoutMatrix.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutMatrix.Name = "tableLayoutMatrix";
            this.tableLayoutMatrix.RowCount = 1;
            this.tableLayoutMatrix.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutMatrix.Size = new System.Drawing.Size(465, 39);
            this.tableLayoutMatrix.TabIndex = 43;
            // 
            // comboMatrix
            // 
            this.comboMatrix.BorderColor = System.Drawing.Color.White;
            this.comboMatrix.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboMatrix.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboMatrix.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboMatrix.FormattingEnabled = true;
            this.comboMatrix.ItemHeight = 20;
            this.comboMatrix.Items.AddRange(new object[] {
            global::GHelper.Properties.Strings.MatrixOff,
            global::GHelper.Properties.Strings.MatrixDim,
            global::GHelper.Properties.Strings.MatrixMedium,
            global::GHelper.Properties.Strings.MatrixBright});
            this.comboMatrix.Location = new System.Drawing.Point(2, 6);
            this.comboMatrix.Margin = new System.Windows.Forms.Padding(2, 6, 2, 5);
            this.comboMatrix.Name = "comboMatrix";
            this.comboMatrix.Size = new System.Drawing.Size(151, 28);
            this.comboMatrix.TabIndex = 41;
            this.comboMatrix.TabStop = false;
            // 
            // comboMatrixRunning
            // 
            this.comboMatrixRunning.BorderColor = System.Drawing.Color.White;
            this.comboMatrixRunning.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboMatrixRunning.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboMatrixRunning.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboMatrixRunning.FormattingEnabled = true;
            this.comboMatrixRunning.ItemHeight = 20;
            this.comboMatrixRunning.Items.AddRange(new object[] {
            global::GHelper.Properties.Strings.MatrixBanner,
            global::GHelper.Properties.Strings.MatrixLogo,
            global::GHelper.Properties.Strings.MatrixPicture,
            global::GHelper.Properties.Strings.MatrixClock,
            global::GHelper.Properties.Strings.MatrixAudio});
            this.comboMatrixRunning.Location = new System.Drawing.Point(157, 6);
            this.comboMatrixRunning.Margin = new System.Windows.Forms.Padding(2, 6, 2, 5);
            this.comboMatrixRunning.Name = "comboMatrixRunning";
            this.comboMatrixRunning.Size = new System.Drawing.Size(151, 28);
            this.comboMatrixRunning.TabIndex = 42;
            this.comboMatrixRunning.TabStop = false;
            // 
            // buttonMatrix
            // 
            this.buttonMatrix.Activated = false;
            this.buttonMatrix.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonMatrix.BorderColor = System.Drawing.Color.Transparent;
            this.buttonMatrix.BorderRadius = 2;
            this.buttonMatrix.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMatrix.FlatAppearance.BorderSize = 0;
            this.buttonMatrix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMatrix.Location = new System.Drawing.Point(312, 4);
            this.buttonMatrix.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.buttonMatrix.Name = "buttonMatrix";
            this.buttonMatrix.Secondary = true;
            this.buttonMatrix.Size = new System.Drawing.Size(151, 28);
            this.buttonMatrix.TabIndex = 43;
            this.buttonMatrix.Text = global::GHelper.Properties.Strings.PictureGif;
            this.buttonMatrix.UseVisualStyleBackColor = false;
            // 
            // pictureMatrix
            // 
            this.pictureMatrix.BackgroundImage = global::GHelper.Properties.Resources.icons8_matrix_desktop_48;
            this.pictureMatrix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureMatrix.Location = new System.Drawing.Point(15, 10);
            this.pictureMatrix.Margin = new System.Windows.Forms.Padding(2);
            this.pictureMatrix.Name = "pictureMatrix";
            this.pictureMatrix.Size = new System.Drawing.Size(20, 20);
            this.pictureMatrix.TabIndex = 39;
            this.pictureMatrix.TabStop = false;
            // 
            // labelMatrix
            // 
            this.labelMatrix.AutoSize = true;
            this.labelMatrix.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMatrix.Location = new System.Drawing.Point(38, 9);
            this.labelMatrix.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelMatrix.Name = "labelMatrix";
            this.labelMatrix.Size = new System.Drawing.Size(105, 20);
            this.labelMatrix.TabIndex = 38;
            this.labelMatrix.Text = "Anime Matrix";
            // 
            // panelBattery
            // 
            this.panelBattery.AutoSize = true;
            this.panelBattery.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelBattery.Controls.Add(this.sliderBattery);
            this.panelBattery.Controls.Add(this.labelModel);
            this.panelBattery.Controls.Add(this.labelVersion);
            this.panelBattery.Controls.Add(this.labelBattery);
            this.panelBattery.Controls.Add(this.pictureBattery);
            this.panelBattery.Controls.Add(this.labelBatteryTitle);
            this.panelBattery.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBattery.Location = new System.Drawing.Point(6, 584);
            this.panelBattery.Margin = new System.Windows.Forms.Padding(5);
            this.panelBattery.Name = "panelBattery";
            this.panelBattery.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.panelBattery.Size = new System.Drawing.Size(496, 96);
            this.panelBattery.TabIndex = 34;
            // 
            // sliderBattery
            // 
            this.sliderBattery.Location = new System.Drawing.Point(10, 35);
            this.sliderBattery.Margin = new System.Windows.Forms.Padding(2);
            this.sliderBattery.Max = 100;
            this.sliderBattery.Min = 50;
            this.sliderBattery.Name = "sliderBattery";
            this.sliderBattery.Size = new System.Drawing.Size(471, 25);
            this.sliderBattery.TabIndex = 39;
            this.sliderBattery.Text = "sliderBattery";
            this.sliderBattery.Value = 80;
            // 
            // labelModel
            // 
            this.labelModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelModel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelModel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelModel.Location = new System.Drawing.Point(227, 70);
            this.labelModel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(250, 20);
            this.labelModel.TabIndex = 38;
            this.labelModel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelVersion
            // 
            this.labelVersion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelVersion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.labelVersion.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelVersion.Location = new System.Drawing.Point(16, 70);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(188, 20);
            this.labelVersion.TabIndex = 37;
            this.labelVersion.Text = "v.0";
            // 
            // labelBattery
            // 
            this.labelBattery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBattery.Location = new System.Drawing.Point(253, 6);
            this.labelBattery.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelBattery.Name = "labelBattery";
            this.labelBattery.Size = new System.Drawing.Size(228, 28);
            this.labelBattery.TabIndex = 36;
            this.labelBattery.Text = "                ";
            this.labelBattery.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBattery
            // 
            this.pictureBattery.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBattery.BackgroundImage")));
            this.pictureBattery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBattery.Location = new System.Drawing.Point(15, 10);
            this.pictureBattery.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBattery.Name = "pictureBattery";
            this.pictureBattery.Size = new System.Drawing.Size(20, 20);
            this.pictureBattery.TabIndex = 35;
            this.pictureBattery.TabStop = false;
            // 
            // labelBatteryTitle
            // 
            this.labelBatteryTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBatteryTitle.Location = new System.Drawing.Point(38, 9);
            this.labelBatteryTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelBatteryTitle.Name = "labelBatteryTitle";
            this.labelBatteryTitle.Size = new System.Drawing.Size(246, 22);
            this.labelBatteryTitle.TabIndex = 34;
            this.labelBatteryTitle.Text = "Battery Charge Limit";
            // 
            // panelFooter
            // 
            this.panelFooter.AutoSize = true;
            this.panelFooter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelFooter.Controls.Add(this.buttonQuit);
            this.panelFooter.Controls.Add(this.checkStartup);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFooter.Location = new System.Drawing.Point(6, 680);
            this.panelFooter.Margin = new System.Windows.Forms.Padding(5);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.panelFooter.Size = new System.Drawing.Size(496, 46);
            this.panelFooter.TabIndex = 35;
            // 
            // buttonQuit
            // 
            this.buttonQuit.Activated = false;
            this.buttonQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonQuit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonQuit.BorderColor = System.Drawing.Color.Transparent;
            this.buttonQuit.BorderRadius = 2;
            this.buttonQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuit.Location = new System.Drawing.Point(363, 10);
            this.buttonQuit.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Secondary = true;
            this.buttonQuit.Size = new System.Drawing.Size(116, 28);
            this.buttonQuit.TabIndex = 18;
            this.buttonQuit.Text = global::GHelper.Properties.Strings.Quit;
            this.buttonQuit.UseVisualStyleBackColor = false;
            // 
            // checkStartup
            // 
            this.checkStartup.AutoSize = true;
            this.checkStartup.Location = new System.Drawing.Point(15, 13);
            this.checkStartup.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.checkStartup.Name = "checkStartup";
            this.checkStartup.Size = new System.Drawing.Size(129, 24);
            this.checkStartup.TabIndex = 17;
            this.checkStartup.Text = global::GHelper.Properties.Strings.RunOnStartup;
            this.checkStartup.UseVisualStyleBackColor = true;
            // 
            // panelPerformance
            // 
            this.panelPerformance.AutoSize = true;
            this.panelPerformance.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelPerformance.Controls.Add(this.picturePerf);
            this.panelPerformance.Controls.Add(this.labelPerf);
            this.panelPerformance.Controls.Add(this.labelCPUFan);
            this.panelPerformance.Controls.Add(this.tablePerf);
            this.panelPerformance.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPerformance.Location = new System.Drawing.Point(6, 6);
            this.panelPerformance.Margin = new System.Windows.Forms.Padding(0);
            this.panelPerformance.Name = "panelPerformance";
            this.panelPerformance.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.panelPerformance.Size = new System.Drawing.Size(496, 123);
            this.panelPerformance.TabIndex = 36;
            this.panelPerformance.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPerformance_Paint);
            // 
            // picturePerf
            // 
            this.picturePerf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picturePerf.BackgroundImage")));
            this.picturePerf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picturePerf.InitialImage = null;
            this.picturePerf.Location = new System.Drawing.Point(15, 10);
            this.picturePerf.Margin = new System.Windows.Forms.Padding(2);
            this.picturePerf.Name = "picturePerf";
            this.picturePerf.Size = new System.Drawing.Size(20, 20);
            this.picturePerf.TabIndex = 32;
            this.picturePerf.TabStop = false;
            // 
            // labelPerf
            // 
            this.labelPerf.AutoSize = true;
            this.labelPerf.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPerf.Location = new System.Drawing.Point(38, 9);
            this.labelPerf.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelPerf.Name = "labelPerf";
            this.labelPerf.Size = new System.Drawing.Size(143, 20);
            this.labelPerf.TabIndex = 31;
            this.labelPerf.Text = "Performance Mode";
            // 
            // labelCPUFan
            // 
            this.labelCPUFan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCPUFan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCPUFan.Location = new System.Drawing.Point(229, 6);
            this.labelCPUFan.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelCPUFan.Name = "labelCPUFan";
            this.labelCPUFan.Size = new System.Drawing.Size(250, 22);
            this.labelCPUFan.TabIndex = 30;
            this.labelCPUFan.Text = "      ";
            this.labelCPUFan.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tablePerf
            // 
            this.tablePerf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablePerf.AutoSize = true;
            this.tablePerf.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tablePerf.ColumnCount = 4;
            this.tablePerf.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablePerf.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablePerf.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablePerf.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablePerf.Controls.Add(this.buttonSilent, 0, 0);
            this.tablePerf.Controls.Add(this.buttonBalanced, 1, 0);
            this.tablePerf.Controls.Add(this.buttonTurbo, 2, 0);
            this.tablePerf.Controls.Add(this.buttonFans, 3, 0);
            this.tablePerf.Location = new System.Drawing.Point(10, 35);
            this.tablePerf.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.tablePerf.Name = "tablePerf";
            this.tablePerf.RowCount = 1;
            this.tablePerf.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tablePerf.Size = new System.Drawing.Size(472, 80);
            this.tablePerf.TabIndex = 29;
            // 
            // buttonSilent
            // 
            this.buttonSilent.Activated = false;
            this.buttonSilent.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSilent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSilent.BorderColor = System.Drawing.Color.Transparent;
            this.buttonSilent.BorderRadius = 5;
            this.buttonSilent.CausesValidation = false;
            this.buttonSilent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSilent.FlatAppearance.BorderSize = 0;
            this.buttonSilent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSilent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSilent.Image = global::GHelper.Properties.Resources.icons8_bicycle_48__1_;
            this.buttonSilent.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSilent.Location = new System.Drawing.Point(2, 2);
            this.buttonSilent.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSilent.Name = "buttonSilent";
            this.buttonSilent.Secondary = false;
            this.buttonSilent.Size = new System.Drawing.Size(114, 76);
            this.buttonSilent.TabIndex = 0;
            this.buttonSilent.Text = global::GHelper.Properties.Strings.Silent;
            this.buttonSilent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonSilent.UseVisualStyleBackColor = false;
            // 
            // buttonBalanced
            // 
            this.buttonBalanced.Activated = false;
            this.buttonBalanced.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBalanced.BorderColor = System.Drawing.Color.Transparent;
            this.buttonBalanced.BorderRadius = 5;
            this.buttonBalanced.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonBalanced.FlatAppearance.BorderSize = 0;
            this.buttonBalanced.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBalanced.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonBalanced.Image = global::GHelper.Properties.Resources.icons8_fiat_500_48;
            this.buttonBalanced.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonBalanced.Location = new System.Drawing.Point(120, 2);
            this.buttonBalanced.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBalanced.Name = "buttonBalanced";
            this.buttonBalanced.Secondary = false;
            this.buttonBalanced.Size = new System.Drawing.Size(114, 76);
            this.buttonBalanced.TabIndex = 1;
            this.buttonBalanced.Text = global::GHelper.Properties.Strings.Balanced;
            this.buttonBalanced.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonBalanced.UseVisualStyleBackColor = false;
            // 
            // buttonTurbo
            // 
            this.buttonTurbo.Activated = false;
            this.buttonTurbo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonTurbo.BorderColor = System.Drawing.Color.Transparent;
            this.buttonTurbo.BorderRadius = 5;
            this.buttonTurbo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonTurbo.FlatAppearance.BorderSize = 0;
            this.buttonTurbo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTurbo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonTurbo.Image = global::GHelper.Properties.Resources.icons8_rocket_48;
            this.buttonTurbo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonTurbo.Location = new System.Drawing.Point(238, 2);
            this.buttonTurbo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTurbo.Name = "buttonTurbo";
            this.buttonTurbo.Secondary = false;
            this.buttonTurbo.Size = new System.Drawing.Size(114, 76);
            this.buttonTurbo.TabIndex = 2;
            this.buttonTurbo.Text = global::GHelper.Properties.Strings.Turbo;
            this.buttonTurbo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonTurbo.UseVisualStyleBackColor = false;
            // 
            // buttonFans
            // 
            this.buttonFans.Activated = false;
            this.buttonFans.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonFans.BorderColor = System.Drawing.Color.Transparent;
            this.buttonFans.BorderRadius = 5;
            this.buttonFans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFans.FlatAppearance.BorderSize = 0;
            this.buttonFans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFans.Image = global::GHelper.Properties.Resources.icons8_fan_48;
            this.buttonFans.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonFans.Location = new System.Drawing.Point(356, 2);
            this.buttonFans.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFans.Name = "buttonFans";
            this.buttonFans.Secondary = true;
            this.buttonFans.Size = new System.Drawing.Size(114, 76);
            this.buttonFans.TabIndex = 35;
            this.buttonFans.Text = "Options";
            this.buttonFans.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonFans.UseVisualStyleBackColor = false;
            this.buttonFans.Click += new System.EventHandler(this.buttonFans_Click_1);
            // 
            // panelGPU
            // 
            this.panelGPU.AutoSize = true;
            this.panelGPU.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelGPU.Controls.Add(this.pictureGPU);
            this.panelGPU.Controls.Add(this.labelGPU);
            this.panelGPU.Controls.Add(this.labelGPUFan);
            this.panelGPU.Controls.Add(this.tableGPU);
            this.panelGPU.Controls.Add(this.labelTipGPU);
            this.panelGPU.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGPU.Location = new System.Drawing.Point(6, 129);
            this.panelGPU.Margin = new System.Windows.Forms.Padding(5);
            this.panelGPU.Name = "panelGPU";
            this.panelGPU.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.panelGPU.Size = new System.Drawing.Size(496, 146);
            this.panelGPU.TabIndex = 37;
            this.panelGPU.TabStop = true;
            this.panelGPU.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGPU_Paint_2);
            // 
            // pictureGPU
            // 
            this.pictureGPU.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureGPU.BackgroundImage")));
            this.pictureGPU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureGPU.Location = new System.Drawing.Point(15, 10);
            this.pictureGPU.Margin = new System.Windows.Forms.Padding(2);
            this.pictureGPU.Name = "pictureGPU";
            this.pictureGPU.Size = new System.Drawing.Size(20, 20);
            this.pictureGPU.TabIndex = 19;
            this.pictureGPU.TabStop = false;
            this.pictureGPU.Click += new System.EventHandler(this.pictureGPU_Click);
            // 
            // labelGPU
            // 
            this.labelGPU.AutoSize = true;
            this.labelGPU.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGPU.Location = new System.Drawing.Point(38, 9);
            this.labelGPU.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelGPU.Name = "labelGPU";
            this.labelGPU.Size = new System.Drawing.Size(84, 20);
            this.labelGPU.TabIndex = 18;
            this.labelGPU.Text = "GPU Mode";
            this.labelGPU.Click += new System.EventHandler(this.labelGPU_Click);
            // 
            // labelGPUFan
            // 
            this.labelGPUFan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGPUFan.Location = new System.Drawing.Point(229, 6);
            this.labelGPUFan.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelGPUFan.Name = "labelGPUFan";
            this.labelGPUFan.Size = new System.Drawing.Size(250, 21);
            this.labelGPUFan.TabIndex = 17;
            this.labelGPUFan.Text = "         ";
            this.labelGPUFan.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelGPUFan.Click += new System.EventHandler(this.labelGPUFan_Click);
            // 
            // tableGPU
            // 
            this.tableGPU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableGPU.AutoSize = true;
            this.tableGPU.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableGPU.ColumnCount = 5;
            this.tableGPU.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableGPU.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableGPU.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableGPU.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableGPU.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableGPU.Controls.Add(this.buttonXGM, 2, 0);
            this.tableGPU.Controls.Add(this.buttonEco, 0, 0);
            this.tableGPU.Controls.Add(this.buttonStandard, 1, 0);
            this.tableGPU.Controls.Add(this.buttonOptimized, 2, 0);
            this.tableGPU.Controls.Add(this.buttonUltimate, 2, 0);
            this.tableGPU.Location = new System.Drawing.Point(10, 35);
            this.tableGPU.Margin = new System.Windows.Forms.Padding(5, 2, 5, 5);
            this.tableGPU.Name = "tableGPU";
            this.tableGPU.RowCount = 1;
            this.tableGPU.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableGPU.Size = new System.Drawing.Size(475, 80);
            this.tableGPU.TabIndex = 16;
            this.tableGPU.Paint += new System.Windows.Forms.PaintEventHandler(this.tableGPU_Paint);
            // 
            // buttonXGM
            // 
            this.buttonXGM.Activated = false;
            this.buttonXGM.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonXGM.BorderColor = System.Drawing.Color.Transparent;
            this.buttonXGM.BorderRadius = 5;
            this.buttonXGM.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonXGM.FlatAppearance.BorderSize = 0;
            this.buttonXGM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXGM.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonXGM.Image = global::GHelper.Properties.Resources.icons8_video_48;
            this.buttonXGM.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonXGM.Location = new System.Drawing.Point(382, 2);
            this.buttonXGM.Margin = new System.Windows.Forms.Padding(2);
            this.buttonXGM.Name = "buttonXGM";
            this.buttonXGM.Secondary = false;
            this.buttonXGM.Size = new System.Drawing.Size(91, 76);
            this.buttonXGM.TabIndex = 2;
            this.buttonXGM.Text = "XG Mobile";
            this.buttonXGM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonXGM.UseVisualStyleBackColor = false;
            this.buttonXGM.Visible = false;
            // 
            // buttonEco
            // 
            this.buttonEco.Activated = false;
            this.buttonEco.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEco.BorderColor = System.Drawing.Color.Transparent;
            this.buttonEco.BorderRadius = 5;
            this.buttonEco.CausesValidation = false;
            this.buttonEco.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEco.FlatAppearance.BorderSize = 0;
            this.buttonEco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEco.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonEco.Image = global::GHelper.Properties.Resources.icons8_leaf_48;
            this.buttonEco.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEco.Location = new System.Drawing.Point(2, 2);
            this.buttonEco.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEco.Name = "buttonEco";
            this.buttonEco.Secondary = false;
            this.buttonEco.Size = new System.Drawing.Size(91, 75);
            this.buttonEco.TabIndex = 0;
            this.buttonEco.Text = global::GHelper.Properties.Strings.EcoMode;
            this.buttonEco.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonEco.UseVisualStyleBackColor = false;
            // 
            // buttonStandard
            // 
            this.buttonStandard.Activated = false;
            this.buttonStandard.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonStandard.BorderColor = System.Drawing.Color.Transparent;
            this.buttonStandard.BorderRadius = 5;
            this.buttonStandard.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStandard.FlatAppearance.BorderSize = 0;
            this.buttonStandard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStandard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonStandard.Image = global::GHelper.Properties.Resources.icons8_spa_flower_48;
            this.buttonStandard.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonStandard.Location = new System.Drawing.Point(97, 2);
            this.buttonStandard.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStandard.Name = "buttonStandard";
            this.buttonStandard.Secondary = false;
            this.buttonStandard.Size = new System.Drawing.Size(91, 75);
            this.buttonStandard.TabIndex = 1;
            this.buttonStandard.Text = global::GHelper.Properties.Strings.StandardMode;
            this.buttonStandard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonStandard.UseVisualStyleBackColor = false;
            // 
            // buttonOptimized
            // 
            this.buttonOptimized.Activated = false;
            this.buttonOptimized.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonOptimized.BorderColor = System.Drawing.Color.Transparent;
            this.buttonOptimized.BorderRadius = 5;
            this.buttonOptimized.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonOptimized.FlatAppearance.BorderSize = 0;
            this.buttonOptimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOptimized.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonOptimized.Image = global::GHelper.Properties.Resources.icons8_project_management_48__1_;
            this.buttonOptimized.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonOptimized.Location = new System.Drawing.Point(287, 2);
            this.buttonOptimized.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOptimized.Name = "buttonOptimized";
            this.buttonOptimized.Secondary = false;
            this.buttonOptimized.Size = new System.Drawing.Size(91, 75);
            this.buttonOptimized.TabIndex = 3;
            this.buttonOptimized.Text = global::GHelper.Properties.Strings.Optimized;
            this.buttonOptimized.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonOptimized.UseVisualStyleBackColor = false;
            // 
            // buttonUltimate
            // 
            this.buttonUltimate.Activated = false;
            this.buttonUltimate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonUltimate.BorderColor = System.Drawing.Color.Transparent;
            this.buttonUltimate.BorderRadius = 5;
            this.buttonUltimate.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonUltimate.FlatAppearance.BorderSize = 0;
            this.buttonUltimate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUltimate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonUltimate.Image = global::GHelper.Properties.Resources.icons8_game_controller_48;
            this.buttonUltimate.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonUltimate.Location = new System.Drawing.Point(192, 2);
            this.buttonUltimate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUltimate.Name = "buttonUltimate";
            this.buttonUltimate.Secondary = false;
            this.buttonUltimate.Size = new System.Drawing.Size(91, 75);
            this.buttonUltimate.TabIndex = 2;
            this.buttonUltimate.Text = global::GHelper.Properties.Strings.UltimateMode;
            this.buttonUltimate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonUltimate.UseVisualStyleBackColor = false;
            // 
            // labelTipGPU
            // 
            this.labelTipGPU.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelTipGPU.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.labelTipGPU.Location = new System.Drawing.Point(15, 118);
            this.labelTipGPU.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTipGPU.Name = "labelTipGPU";
            this.labelTipGPU.Size = new System.Drawing.Size(465, 22);
            this.labelTipGPU.TabIndex = 21;
            this.labelTipGPU.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.labelTipGPU.Click += new System.EventHandler(this.labelTipGPU_Click_1);
            // 
            // panelScreen
            // 
            this.panelScreen.AutoSize = true;
            this.panelScreen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelScreen.Controls.Add(this.labelMidFan);
            this.panelScreen.Controls.Add(this.labelTipScreen);
            this.panelScreen.Controls.Add(this.tableScreen);
            this.panelScreen.Controls.Add(this.pictureScreen);
            this.panelScreen.Controls.Add(this.labelSreen);
            this.panelScreen.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelScreen.Location = new System.Drawing.Point(6, 275);
            this.panelScreen.Margin = new System.Windows.Forms.Padding(5);
            this.panelScreen.Name = "panelScreen";
            this.panelScreen.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.panelScreen.Size = new System.Drawing.Size(496, 116);
            this.panelScreen.TabIndex = 38;
            // 
            // labelMidFan
            // 
            this.labelMidFan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMidFan.Location = new System.Drawing.Point(292, 6);
            this.labelMidFan.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelMidFan.Name = "labelMidFan";
            this.labelMidFan.Size = new System.Drawing.Size(185, 21);
            this.labelMidFan.TabIndex = 25;
            this.labelMidFan.Text = "         ";
            this.labelMidFan.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelTipScreen
            // 
            this.labelTipScreen.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelTipScreen.Location = new System.Drawing.Point(15, 88);
            this.labelTipScreen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTipScreen.Name = "labelTipScreen";
            this.labelTipScreen.Size = new System.Drawing.Size(465, 22);
            this.labelTipScreen.TabIndex = 24;
            // 
            // tableScreen
            // 
            this.tableScreen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableScreen.AutoSize = true;
            this.tableScreen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableScreen.ColumnCount = 5;
            this.tableScreen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableScreen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableScreen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableScreen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableScreen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableScreen.Controls.Add(this.buttonScreenAuto, 0, 0);
            this.tableScreen.Controls.Add(this.button60Hz, 1, 0);
            this.tableScreen.Controls.Add(this.button120Hz, 2, 0);
            this.tableScreen.Controls.Add(this.buttonOD, 3, 0);
            this.tableScreen.Controls.Add(this.buttonMiniled, 4, 0);
            this.tableScreen.Location = new System.Drawing.Point(10, 35);
            this.tableScreen.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.tableScreen.Name = "tableScreen";
            this.tableScreen.RowCount = 1;
            this.tableScreen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableScreen.Size = new System.Drawing.Size(465, 50);
            this.tableScreen.TabIndex = 23;
            // 
            // buttonScreenAuto
            // 
            this.buttonScreenAuto.Activated = false;
            this.buttonScreenAuto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonScreenAuto.BorderColor = System.Drawing.Color.Transparent;
            this.buttonScreenAuto.BorderRadius = 5;
            this.buttonScreenAuto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonScreenAuto.FlatAppearance.BorderSize = 0;
            this.buttonScreenAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonScreenAuto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonScreenAuto.Location = new System.Drawing.Point(2, 2);
            this.buttonScreenAuto.Margin = new System.Windows.Forms.Padding(2);
            this.buttonScreenAuto.Name = "buttonScreenAuto";
            this.buttonScreenAuto.Secondary = false;
            this.buttonScreenAuto.Size = new System.Drawing.Size(89, 46);
            this.buttonScreenAuto.TabIndex = 0;
            this.buttonScreenAuto.Text = global::GHelper.Properties.Strings.AutoMode;
            this.buttonScreenAuto.UseVisualStyleBackColor = false;
            // 
            // button60Hz
            // 
            this.button60Hz.Activated = false;
            this.button60Hz.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button60Hz.BorderColor = System.Drawing.Color.Transparent;
            this.button60Hz.BorderRadius = 5;
            this.button60Hz.CausesValidation = false;
            this.button60Hz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button60Hz.FlatAppearance.BorderSize = 0;
            this.button60Hz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button60Hz.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button60Hz.Location = new System.Drawing.Point(95, 2);
            this.button60Hz.Margin = new System.Windows.Forms.Padding(2);
            this.button60Hz.Name = "button60Hz";
            this.button60Hz.Secondary = false;
            this.button60Hz.Size = new System.Drawing.Size(89, 46);
            this.button60Hz.TabIndex = 1;
            this.button60Hz.Text = "60Hz";
            this.button60Hz.UseVisualStyleBackColor = false;
            // 
            // button120Hz
            // 
            this.button120Hz.Activated = false;
            this.button120Hz.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button120Hz.BorderColor = System.Drawing.Color.Transparent;
            this.button120Hz.BorderRadius = 5;
            this.button120Hz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button120Hz.FlatAppearance.BorderSize = 0;
            this.button120Hz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button120Hz.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button120Hz.Location = new System.Drawing.Point(188, 2);
            this.button120Hz.Margin = new System.Windows.Forms.Padding(2);
            this.button120Hz.Name = "button120Hz";
            this.button120Hz.Secondary = false;
            this.button120Hz.Size = new System.Drawing.Size(89, 46);
            this.button120Hz.TabIndex = 2;
            this.button120Hz.Text = "120Hz";
            this.button120Hz.UseVisualStyleBackColor = false;
            // 
            // buttonOD
            // 
            this.buttonOD.Activated = false;
            this.buttonOD.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonOD.BorderColor = System.Drawing.Color.Transparent;
            this.buttonOD.BorderRadius = 5;
            this.buttonOD.CausesValidation = false;
            this.buttonOD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonOD.FlatAppearance.BorderSize = 0;
            this.buttonOD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonOD.Location = new System.Drawing.Point(281, 2);
            this.buttonOD.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOD.Name = "buttonOD";
            this.buttonOD.Secondary = false;
            this.buttonOD.Size = new System.Drawing.Size(89, 46);
            this.buttonOD.TabIndex = 3;
            this.buttonOD.Text = "Override";
            this.buttonOD.UseVisualStyleBackColor = false;
            // 
            // buttonMiniled
            // 
            this.buttonMiniled.Activated = false;
            this.buttonMiniled.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonMiniled.BorderColor = System.Drawing.Color.Transparent;
            this.buttonMiniled.BorderRadius = 5;
            this.buttonMiniled.CausesValidation = false;
            this.buttonMiniled.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMiniled.FlatAppearance.BorderSize = 0;
            this.buttonMiniled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMiniled.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonMiniled.Location = new System.Drawing.Point(374, 2);
            this.buttonMiniled.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMiniled.Name = "buttonMiniled";
            this.buttonMiniled.Secondary = false;
            this.buttonMiniled.Size = new System.Drawing.Size(89, 46);
            this.buttonMiniled.TabIndex = 4;
            this.buttonMiniled.Text = global::GHelper.Properties.Strings.Multizone;
            this.buttonMiniled.UseVisualStyleBackColor = false;
            // 
            // pictureScreen
            // 
            this.pictureScreen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureScreen.BackgroundImage")));
            this.pictureScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureScreen.Location = new System.Drawing.Point(15, 10);
            this.pictureScreen.Margin = new System.Windows.Forms.Padding(2);
            this.pictureScreen.Name = "pictureScreen";
            this.pictureScreen.Size = new System.Drawing.Size(20, 20);
            this.pictureScreen.TabIndex = 22;
            this.pictureScreen.TabStop = false;
            // 
            // labelSreen
            // 
            this.labelSreen.AutoSize = true;
            this.labelSreen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSreen.Location = new System.Drawing.Point(38, 9);
            this.labelSreen.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelSreen.Name = "labelSreen";
            this.labelSreen.Size = new System.Drawing.Size(108, 20);
            this.labelSreen.TabIndex = 21;
            this.labelSreen.Text = "Laptop Screen";
            // 
            // panelKeyboard
            // 
            this.panelKeyboard.AutoSize = true;
            this.panelKeyboard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelKeyboard.Controls.Add(this.tableLayoutKeyboard);
            this.panelKeyboard.Controls.Add(this.pictureKeyboard);
            this.panelKeyboard.Controls.Add(this.labelKeyboard);
            this.panelKeyboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelKeyboard.Location = new System.Drawing.Point(6, 391);
            this.panelKeyboard.Margin = new System.Windows.Forms.Padding(5);
            this.panelKeyboard.Name = "panelKeyboard";
            this.panelKeyboard.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.panelKeyboard.Size = new System.Drawing.Size(496, 85);
            this.panelKeyboard.TabIndex = 39;
            // 
            // tableLayoutKeyboard
            // 
            this.tableLayoutKeyboard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutKeyboard.AutoSize = true;
            this.tableLayoutKeyboard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutKeyboard.ColumnCount = 3;
            this.tableLayoutKeyboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutKeyboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutKeyboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutKeyboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutKeyboard.Controls.Add(this.comboKeyboard, 0, 0);
            this.tableLayoutKeyboard.Controls.Add(this.panelColor, 1, 0);
            this.tableLayoutKeyboard.Controls.Add(this.buttonKeyboard, 2, 0);
            this.tableLayoutKeyboard.Location = new System.Drawing.Point(10, 35);
            this.tableLayoutKeyboard.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutKeyboard.Name = "tableLayoutKeyboard";
            this.tableLayoutKeyboard.RowCount = 1;
            this.tableLayoutKeyboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutKeyboard.Size = new System.Drawing.Size(465, 39);
            this.tableLayoutKeyboard.TabIndex = 39;
            // 
            // comboKeyboard
            // 
            this.comboKeyboard.BorderColor = System.Drawing.Color.White;
            this.comboKeyboard.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboKeyboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboKeyboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboKeyboard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboKeyboard.FormattingEnabled = true;
            this.comboKeyboard.ItemHeight = 20;
            this.comboKeyboard.Items.AddRange(new object[] {
            "Static",
            "Breathe",
            "Rainbow",
            "Strobe"});
            this.comboKeyboard.Location = new System.Drawing.Point(2, 6);
            this.comboKeyboard.Margin = new System.Windows.Forms.Padding(2, 6, 2, 5);
            this.comboKeyboard.Name = "comboKeyboard";
            this.comboKeyboard.Size = new System.Drawing.Size(151, 28);
            this.comboKeyboard.TabIndex = 35;
            this.comboKeyboard.TabStop = false;
            // 
            // panelColor
            // 
            this.panelColor.AutoSize = true;
            this.panelColor.Controls.Add(this.pictureColor2);
            this.panelColor.Controls.Add(this.pictureColor);
            this.panelColor.Controls.Add(this.buttonKeyboardColor);
            this.panelColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelColor.Location = new System.Drawing.Point(157, 4);
            this.panelColor.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(151, 31);
            this.panelColor.TabIndex = 36;
            // 
            // pictureColor2
            // 
            this.pictureColor2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureColor2.Location = new System.Drawing.Point(113, 8);
            this.pictureColor2.Margin = new System.Windows.Forms.Padding(5);
            this.pictureColor2.Name = "pictureColor2";
            this.pictureColor2.Size = new System.Drawing.Size(12, 12);
            this.pictureColor2.TabIndex = 41;
            this.pictureColor2.TabStop = false;
            // 
            // pictureColor
            // 
            this.pictureColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureColor.Location = new System.Drawing.Point(129, 8);
            this.pictureColor.Margin = new System.Windows.Forms.Padding(5);
            this.pictureColor.Name = "pictureColor";
            this.pictureColor.Size = new System.Drawing.Size(12, 12);
            this.pictureColor.TabIndex = 40;
            this.pictureColor.TabStop = false;
            // 
            // buttonKeyboardColor
            // 
            this.buttonKeyboardColor.Activated = false;
            this.buttonKeyboardColor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonKeyboardColor.BorderColor = System.Drawing.Color.Transparent;
            this.buttonKeyboardColor.BorderRadius = 2;
            this.buttonKeyboardColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonKeyboardColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKeyboardColor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonKeyboardColor.Location = new System.Drawing.Point(0, 0);
            this.buttonKeyboardColor.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.buttonKeyboardColor.Name = "buttonKeyboardColor";
            this.buttonKeyboardColor.Secondary = false;
            this.buttonKeyboardColor.Size = new System.Drawing.Size(151, 28);
            this.buttonKeyboardColor.TabIndex = 39;
            this.buttonKeyboardColor.Text = global::GHelper.Properties.Strings.Color;
            this.buttonKeyboardColor.UseVisualStyleBackColor = false;
            // 
            // buttonKeyboard
            // 
            this.buttonKeyboard.Activated = false;
            this.buttonKeyboard.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonKeyboard.BorderColor = System.Drawing.Color.Transparent;
            this.buttonKeyboard.BorderRadius = 2;
            this.buttonKeyboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonKeyboard.FlatAppearance.BorderSize = 0;
            this.buttonKeyboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKeyboard.Location = new System.Drawing.Point(312, 4);
            this.buttonKeyboard.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.buttonKeyboard.Name = "buttonKeyboard";
            this.buttonKeyboard.Secondary = true;
            this.buttonKeyboard.Size = new System.Drawing.Size(151, 28);
            this.buttonKeyboard.TabIndex = 37;
            this.buttonKeyboard.Text = global::GHelper.Properties.Strings.Extra;
            this.buttonKeyboard.UseVisualStyleBackColor = false;
            // 
            // pictureKeyboard
            // 
            this.pictureKeyboard.BackgroundImage = global::GHelper.Properties.Resources.icons8_keyboard_48;
            this.pictureKeyboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureKeyboard.Location = new System.Drawing.Point(15, 10);
            this.pictureKeyboard.Margin = new System.Windows.Forms.Padding(2);
            this.pictureKeyboard.Name = "pictureKeyboard";
            this.pictureKeyboard.Size = new System.Drawing.Size(20, 20);
            this.pictureKeyboard.TabIndex = 33;
            this.pictureKeyboard.TabStop = false;
            // 
            // labelKeyboard
            // 
            this.labelKeyboard.AutoSize = true;
            this.labelKeyboard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelKeyboard.Location = new System.Drawing.Point(38, 9);
            this.labelKeyboard.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelKeyboard.Name = "labelKeyboard";
            this.labelKeyboard.Size = new System.Drawing.Size(129, 20);
            this.labelKeyboard.TabIndex = 32;
            this.labelKeyboard.Text = "Laptop Keyboard";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(508, 731);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelBattery);
            this.Controls.Add(this.panelMatrix);
            this.Controls.Add(this.panelKeyboard);
            this.Controls.Add(this.panelScreen);
            this.Controls.Add(this.panelGPU);
            this.Controls.Add(this.panelPerformance);
            this.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(526, 62);
            this.Name = "SettingsForm";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "G-Helper";
            this.panelMatrix.ResumeLayout(false);
            this.panelMatrix.PerformLayout();
            this.tableLayoutMatrix.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureMatrix)).EndInit();
            this.panelBattery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBattery)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.panelPerformance.ResumeLayout(false);
            this.panelPerformance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePerf)).EndInit();
            this.tablePerf.ResumeLayout(false);
            this.panelGPU.ResumeLayout(false);
            this.panelGPU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGPU)).EndInit();
            this.tableGPU.ResumeLayout(false);
            this.panelScreen.ResumeLayout(false);
            this.panelScreen.PerformLayout();
            this.tableScreen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureScreen)).EndInit();
            this.panelKeyboard.ResumeLayout(false);
            this.panelKeyboard.PerformLayout();
            this.tableLayoutKeyboard.ResumeLayout(false);
            this.tableLayoutKeyboard.PerformLayout();
            this.panelColor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureColor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureKeyboard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panelMatrix;
        private PictureBox pictureMatrix;
        private Label labelMatrix;
        private Panel panelBattery;
        private Label labelVersion;
        private Label labelBattery;
        private PictureBox pictureBattery;
        private Label labelBatteryTitle;
        private Panel panelFooter;
        private RButton buttonQuit;
        private CheckBox checkStartup;
        private Panel panelPerformance;
        private PictureBox picturePerf;
        private Label labelPerf;
        private Label labelCPUFan;
        private TableLayoutPanel tablePerf;
        private RButton buttonTurbo;
        private RButton buttonBalanced;
        private RButton buttonSilent;
        private Panel panelGPU;
        private PictureBox pictureGPU;
        private Label labelGPU;
        private Label labelGPUFan;
        private TableLayoutPanel tableGPU;
        private RButton buttonXGM;
        private RButton buttonUltimate;
        private RButton buttonStandard;
        private RButton buttonEco;
        private Panel panelScreen;
        private TableLayoutPanel tableScreen;
        private RButton buttonScreenAuto;
        private RButton button60Hz;
        private PictureBox pictureScreen;
        private Label labelSreen;
        private Panel panelKeyboard;
        private PictureBox pictureKeyboard;
        private Label labelKeyboard;
        private TableLayoutPanel tableLayoutMatrix;
        private RComboBox comboMatrixRunning;
        private RComboBox comboMatrix;
        private TableLayoutPanel tableLayoutKeyboard;
        private RComboBox comboKeyboard;
        private Panel panelColor;
        private PictureBox pictureColor2;
        private PictureBox pictureColor;
        private CheckBox checkMatrix;
        private RButton button120Hz;
        private RButton buttonOptimized;
        private Label labelTipGPU;
        private Label labelTipScreen;
        private RButton buttonMiniled;
        private RButton buttonMatrix;
        private RButton buttonKeyboard;
        private RButton buttonKeyboardColor;
        private RButton buttonFans;
        private Label labelMidFan;
        private Label labelModel;
        private WinFormsSliderBar.Slider sliderBattery;
        private RButton rButton1;
        private RButton buttonOD;
    }
}