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
            rbtMerge = new RadioButton();
            rbtSplit = new RadioButton();
            btRun = new Button();
            lbPdfFiles = new ListBox();
            btSelect = new Button();
            openFileDialogPDF = new OpenFileDialog();
            materialTabControlMain = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPage1 = new TabPage();
            materialButton2 = new ReaLTaiizor.Controls.MaterialButton();
            materialButton1 = new ReaLTaiizor.Controls.MaterialButton();
            materialLabel2 = new ReaLTaiizor.Controls.MaterialLabel();
            tabPage2 = new TabPage();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            materialTabControlMain.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // rbtMerge
            // 
            rbtMerge.AutoSize = true;
            rbtMerge.Location = new Point(450, 106);
            rbtMerge.Name = "rbtMerge";
            rbtMerge.Size = new Size(50, 21);
            rbtMerge.TabIndex = 5;
            rbtMerge.Text = "合并";
            rbtMerge.UseVisualStyleBackColor = true;
            rbtMerge.CheckedChanged += rbtMerge_CheckedChanged;
            // 
            // rbtSplit
            // 
            rbtSplit.AutoSize = true;
            rbtSplit.Checked = true;
            rbtSplit.Location = new Point(450, 69);
            rbtSplit.Name = "rbtSplit";
            rbtSplit.Size = new Size(50, 21);
            rbtSplit.TabIndex = 4;
            rbtSplit.TabStop = true;
            rbtSplit.Text = "拆分";
            rbtSplit.UseVisualStyleBackColor = true;
            // 
            // btRun
            // 
            btRun.Location = new Point(450, 258);
            btRun.Name = "btRun";
            btRun.Size = new Size(78, 23);
            btRun.TabIndex = 3;
            btRun.Text = "运行";
            btRun.UseVisualStyleBackColor = true;
            btRun.Click += btRun_Click;
            // 
            // lbPdfFiles
            // 
            lbPdfFiles.FormattingEnabled = true;
            lbPdfFiles.ItemHeight = 17;
            lbPdfFiles.Location = new Point(6, 38);
            lbPdfFiles.Name = "lbPdfFiles";
            lbPdfFiles.Size = new Size(438, 259);
            lbPdfFiles.TabIndex = 2;
            // 
            // btSelect
            // 
            btSelect.Location = new Point(451, 229);
            btSelect.Name = "btSelect";
            btSelect.Size = new Size(75, 23);
            btSelect.TabIndex = 1;
            btSelect.Text = "选择";
            btSelect.UseVisualStyleBackColor = true;
            btSelect.Click += btSelect_Click;
            // 
            // openFileDialogPDF
            // 
            openFileDialogPDF.Filter = "所有 PDF 文件|*.pdf";
            openFileDialogPDF.Title = "选择 PDF 文件";
            // 
            // materialTabControlMain
            // 
            materialTabControlMain.Controls.Add(tabPage1);
            materialTabControlMain.Controls.Add(tabPage2);
            materialTabControlMain.Depth = 0;
            materialTabControlMain.Dock = DockStyle.Fill;
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
            tabPage1.Controls.Add(materialButton2);
            tabPage1.Controls.Add(materialButton1);
            tabPage1.Controls.Add(materialLabel2);
            tabPage1.Controls.Add(btRun);
            tabPage1.Controls.Add(rbtMerge);
            tabPage1.Controls.Add(lbPdfFiles);
            tabPage1.Controls.Add(btSelect);
            tabPage1.Controls.Add(rbtSplit);
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(586, 303);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "主页";
            // 
            // materialButton2
            // 
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            materialButton2.Location = new Point(451, 184);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(64, 36);
            materialButton2.TabIndex = 8;
            materialButton2.Text = "运行";
            materialButton2.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            materialButton1.Location = new Point(451, 136);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(64, 36);
            materialButton1.TabIndex = 7;
            materialButton1.Text = "选择";
            materialButton1.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(6, 17);
            materialLabel2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(49, 19);
            materialLabel2.TabIndex = 6;
            materialLabel2.Text = "文件：";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.Controls.Add(pictureBox5);
            tabPage2.Controls.Add(pictureBox4);
            tabPage2.Controls.Add(pictureBox3);
            tabPage2.Controls.Add(pictureBox2);
            tabPage2.Controls.Add(pictureBox1);
            tabPage2.Controls.Add(materialLabel1);
            tabPage2.Location = new Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(586, 303);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "关于";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.net60_blue;
            pictureBox5.Location = new Point(19, 16);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(80, 20);
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.badge;
            pictureBox4.Location = new Point(19, 42);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(103, 20);
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.badge_2;
            pictureBox3.Location = new Point(128, 42);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(150, 20);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.csharp;
            pictureBox2.Location = new Point(105, 16);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(80, 20);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.IDE_VS2022_blue;
            pictureBox1.Location = new Point(191, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(84, 20);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // materialLabel1
            // 
            materialLabel1.BackColor = Color.Transparent;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(19, 78);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(551, 131);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "NuGet：RealTaiizor, iText\r\n";
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
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btRun;
        private ListBox lbPdfFiles;
        private Button btSelect;
        private RadioButton rbtMerge;
        private RadioButton rbtSplit;
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
        private ReaLTaiizor.Controls.MaterialButton materialButton2;
        private ReaLTaiizor.Controls.MaterialButton materialButton1;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel2;
    }
}
