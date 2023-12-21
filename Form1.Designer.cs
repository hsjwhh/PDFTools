namespace PDFTools
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lbPdfFiles = new ListBox();
            openFileDialogPDF = new OpenFileDialog();
            materialTabControlMain = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPage1 = new TabPage();
            materialLabel2 = new ReaLTaiizor.Controls.MaterialLabel();
            mrbtMerge = new ReaLTaiizor.Controls.MaterialRadioButton();
            mrbtSplit = new ReaLTaiizor.Controls.MaterialRadioButton();
            mbtRun = new ReaLTaiizor.Controls.MaterialButton();
            mbtSelectPDF = new ReaLTaiizor.Controls.MaterialButton();
            tabPage3 = new TabPage();
            tabPage2 = new TabPage();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            menuiconList = new ImageList(components);
            materialTabControlMain.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbPdfFiles
            // 
            lbPdfFiles.FormattingEnabled = true;
            lbPdfFiles.ItemHeight = 17;
            lbPdfFiles.Location = new Point(12, 39);
            lbPdfFiles.Name = "lbPdfFiles";
            lbPdfFiles.Size = new Size(500, 225);
            lbPdfFiles.TabIndex = 2;
            // 
            // openFileDialogPDF
            // 
            openFileDialogPDF.Filter = "所有 PDF 文件|*.pdf";
            openFileDialogPDF.Title = "选择 PDF 文件";
            // 
            // materialTabControlMain
            // 
            materialTabControlMain.Controls.Add(tabPage1);
            materialTabControlMain.Controls.Add(tabPage3);
            materialTabControlMain.Controls.Add(tabPage2);
            materialTabControlMain.Depth = 0;
            materialTabControlMain.Dock = DockStyle.Fill;
            materialTabControlMain.ImageList = menuiconList;
            materialTabControlMain.Location = new Point(3, 64);
            materialTabControlMain.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialTabControlMain.Multiline = true;
            materialTabControlMain.Name = "materialTabControlMain";
            materialTabControlMain.SelectedIndex = 0;
            materialTabControlMain.Size = new Size(594, 333);
            materialTabControlMain.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(materialLabel2);
            tabPage1.Controls.Add(mrbtMerge);
            tabPage1.Controls.Add(mrbtSplit);
            tabPage1.Controls.Add(mbtRun);
            tabPage1.Controls.Add(mbtSelectPDF);
            tabPage1.Controls.Add(lbPdfFiles);
            tabPage1.ImageKey = "round_assessment_white_24dp.png";
            tabPage1.Location = new Point(4, 31);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(586, 298);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "PDF 分割 合并";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel2.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Button;
            materialLabel2.Location = new Point(12, 13);
            materialLabel2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(117, 17);
            materialLabel2.TabIndex = 11;
            materialLabel2.Text = "待处理 PDF 列表：";
            // 
            // mrbtMerge
            // 
            mrbtMerge.Depth = 0;
            mrbtMerge.Location = new Point(101, 283);
            mrbtMerge.Margin = new Padding(0);
            mrbtMerge.MouseLocation = new Point(-1, -1);
            mrbtMerge.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            mrbtMerge.Name = "mrbtMerge";
            mrbtMerge.Ripple = true;
            mrbtMerge.Size = new Size(67, 32);
            mrbtMerge.TabIndex = 10;
            mrbtMerge.TabStop = true;
            mrbtMerge.Text = "合并";
            mrbtMerge.UseAccentColor = false;
            mrbtMerge.UseVisualStyleBackColor = true;
            mrbtMerge.CheckedChanged += mrbtMerge_CheckedChanged;
            // 
            // mrbtSplit
            // 
            mrbtSplit.Checked = true;
            mrbtSplit.Depth = 0;
            mrbtSplit.Location = new Point(12, 283);
            mrbtSplit.Margin = new Padding(0);
            mrbtSplit.MouseLocation = new Point(-1, -1);
            mrbtSplit.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            mrbtSplit.Name = "mrbtSplit";
            mrbtSplit.Ripple = true;
            mrbtSplit.Size = new Size(67, 32);
            mrbtSplit.TabIndex = 9;
            mrbtSplit.TabStop = true;
            mrbtSplit.Text = "拆分";
            mrbtSplit.UseAccentColor = false;
            mrbtSplit.UseVisualStyleBackColor = true;
            mrbtSplit.CheckedChanged += mrbtSplit_CheckedChanged;
            // 
            // mbtRun
            // 
            mbtRun.AutoSize = false;
            mbtRun.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mbtRun.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            mbtRun.Depth = 0;
            mbtRun.HighEmphasis = true;
            mbtRun.Icon = null;
            mbtRun.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            mbtRun.Location = new Point(362, 283);
            mbtRun.Margin = new Padding(4, 6, 4, 6);
            mbtRun.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            mbtRun.Name = "mbtRun";
            mbtRun.NoAccentTextColor = Color.Empty;
            mbtRun.Size = new Size(150, 32);
            mbtRun.TabIndex = 8;
            mbtRun.Text = "运行";
            mbtRun.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            mbtRun.UseAccentColor = false;
            mbtRun.UseVisualStyleBackColor = true;
            mbtRun.Click += mbtRun_Click;
            // 
            // mbtSelectPDF
            // 
            mbtSelectPDF.AutoSize = false;
            mbtSelectPDF.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mbtSelectPDF.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            mbtSelectPDF.Depth = 0;
            mbtSelectPDF.HighEmphasis = true;
            mbtSelectPDF.Icon = null;
            mbtSelectPDF.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            mbtSelectPDF.Location = new Point(190, 283);
            mbtSelectPDF.Margin = new Padding(4, 6, 4, 6);
            mbtSelectPDF.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            mbtSelectPDF.Name = "mbtSelectPDF";
            mbtSelectPDF.NoAccentTextColor = Color.Empty;
            mbtSelectPDF.Size = new Size(150, 32);
            mbtSelectPDF.TabIndex = 7;
            mbtSelectPDF.Text = "选择文件";
            mbtSelectPDF.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            mbtSelectPDF.UseAccentColor = false;
            mbtSelectPDF.UseVisualStyleBackColor = true;
            mbtSelectPDF.Click += mbtSelectPDF_Click;
            // 
            // tabPage3
            // 
            tabPage3.ImageKey = "round_swap_vert_white_24dp.png";
            tabPage3.Location = new Point(4, 31);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(586, 298);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "IMG TO PDF";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.Controls.Add(pictureBox8);
            tabPage2.Controls.Add(pictureBox7);
            tabPage2.Controls.Add(pictureBox6);
            tabPage2.Controls.Add(pictureBox5);
            tabPage2.Controls.Add(pictureBox4);
            tabPage2.Controls.Add(pictureBox3);
            tabPage2.Controls.Add(pictureBox2);
            tabPage2.Controls.Add(pictureBox1);
            tabPage2.Controls.Add(materialLabel1);
            tabPage2.ImageKey = "round_bookmark_white_24dp.png";
            tabPage2.Location = new Point(4, 31);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(586, 298);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "关于";
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.iText_Logo_Small;
            pictureBox8.Location = new Point(6, 69);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(110, 50);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 8;
            pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.Taiizor_Logo;
            pictureBox7.Location = new Point(122, 69);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(50, 50);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 7;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.GitHub_Mark;
            pictureBox6.Location = new Point(178, 69);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(50, 50);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 6;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.net60_blue;
            pictureBox5.Location = new Point(6, 27);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(80, 20);
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.badge;
            pictureBox4.Location = new Point(268, 27);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(103, 20);
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.badge_2;
            pictureBox3.Location = new Point(377, 27);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(150, 20);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.csharp;
            pictureBox2.Location = new Point(92, 27);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(80, 20);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.IDE_VS2022_blue;
            pictureBox1.Location = new Point(178, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(84, 20);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // materialLabel1
            // 
            materialLabel1.BackColor = Color.Transparent;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Overline;
            materialLabel1.Location = new Point(6, 296);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(76, 14);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "create by Michael\r\n";
            // 
            // menuiconList
            // 
            menuiconList.ColorDepth = ColorDepth.Depth32Bit;
            menuiconList.ImageStream = (ImageListStreamer)resources.GetObject("menuiconList.ImageStream");
            menuiconList.TransparentColor = Color.Transparent;
            menuiconList.Images.SetKeyName(0, "round_assessment_white_24dp.png");
            menuiconList.Images.SetKeyName(1, "round_bookmark_white_24dp.png");
            menuiconList.Images.SetKeyName(2, "round_swap_vert_white_24dp.png");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 400);
            Controls.Add(materialTabControlMain);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = materialTabControlMain;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Sizable = false;
            Text = "PDF 工具";
            materialTabControlMain.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ListBox lbPdfFiles;
        private OpenFileDialog openFileDialogPDF;
        private ReaLTaiizor.Controls.MaterialTabControl materialTabControlMain;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox5;
        private ReaLTaiizor.Controls.MaterialButton mbtRun;
        private ReaLTaiizor.Controls.MaterialButton mbtSelectPDF;
        private ImageList menuiconList;
        private PictureBox pictureBox6;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private ReaLTaiizor.Controls.MaterialRadioButton mrbtMerge;
        private ReaLTaiizor.Controls.MaterialRadioButton mrbtSplit;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel2;
        private TabPage tabPage3;
    }
}
