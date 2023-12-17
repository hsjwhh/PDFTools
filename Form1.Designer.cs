﻿namespace PDFTools
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
            groupBox1 = new GroupBox();
            rbtMerge = new RadioButton();
            rbtSplit = new RadioButton();
            btRun = new Button();
            lbPdfFiles = new ListBox();
            btSelect = new Button();
            label1 = new Label();
            groupBox2 = new GroupBox();
            openFileDialogPDF = new OpenFileDialog();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtMerge);
            groupBox1.Controls.Add(rbtSplit);
            groupBox1.Controls.Add(btRun);
            groupBox1.Controls.Add(lbPdfFiles);
            groupBox1.Controls.Add(btSelect);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(560, 231);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "工作区";
            // 
            // rbtMerge
            // 
            rbtMerge.AutoSize = true;
            rbtMerge.Location = new Point(423, 15);
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
            rbtSplit.Location = new Point(367, 15);
            rbtSplit.Name = "rbtSplit";
            rbtSplit.Size = new Size(50, 21);
            rbtSplit.TabIndex = 4;
            rbtSplit.TabStop = true;
            rbtSplit.Text = "拆分";
            rbtSplit.UseVisualStyleBackColor = true;
            // 
            // btRun
            // 
            btRun.Location = new Point(6, 202);
            btRun.Name = "btRun";
            btRun.Size = new Size(548, 23);
            btRun.TabIndex = 3;
            btRun.Text = "运行";
            btRun.UseVisualStyleBackColor = true;
            btRun.Click += btRun_Click;
            // 
            // lbPdfFiles
            // 
            lbPdfFiles.FormattingEnabled = true;
            lbPdfFiles.ItemHeight = 17;
            lbPdfFiles.Location = new Point(6, 39);
            lbPdfFiles.Name = "lbPdfFiles";
            lbPdfFiles.Size = new Size(548, 157);
            lbPdfFiles.TabIndex = 2;
            // 
            // btSelect
            // 
            btSelect.Location = new Point(479, 16);
            btSelect.Name = "btSelect";
            btSelect.Size = new Size(75, 23);
            btSelect.TabIndex = 1;
            btSelect.Text = "选择";
            btSelect.UseVisualStyleBackColor = true;
            btSelect.Click += btSelect_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(70, 17);
            label1.TabIndex = 0;
            label1.Text = "PDF 文件：";
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(12, 249);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(560, 100);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "说明";
            // 
            // openFileDialogPDF
            // 
            openFileDialogPDF.Filter = "所有 PDF 文件|*.pdf";
            openFileDialogPDF.Title = "选择 PDF 文件";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 361);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "PDF 工具";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btRun;
        private ListBox lbPdfFiles;
        private Button btSelect;
        private Label label1;
        private GroupBox groupBox2;
        private RadioButton rbtMerge;
        private RadioButton rbtSplit;
        private OpenFileDialog openFileDialogPDF;
    }
}
