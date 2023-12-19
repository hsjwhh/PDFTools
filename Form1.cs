using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;
using iText.Kernel.Utils;
using ReaLTaiizor.Forms;

namespace PDFTools
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btSelect_Click(object sender, EventArgs e)
        {
            //OpenFileDialog fileDialog = new OpenFileDialog();

            //openFileDialogPDF.Multiselect = true;
            //openFileDialogPDF.Title = "请选择文件";
            //openFileDialogPDF.Filter = "所有 PDF 文件|*.pdf"; //设置要选择的文件的类型
            if (openFileDialogPDF.ShowDialog() == DialogResult.OK)
            {
                //System.IO.Path.GetFullPath(openFileDialogPDF.FileName);//绝对路径
                //System.IO.Path.GetExtension(openFileDialogPDF.FileName);//文件扩展名
                //System.IO.Path.GetFileNameWithoutExtension(openFileDialogPDF.FileName);//文件名没有扩展名
                //System.IO.Path.GetFileName(openFileDialogPDF.FileName);//得到文件名
                //System.IO.Path.GetDirectoryName(openFileDialogPDF.FileName);//得到路径

                // tbFilename.Text = openFileDialogPDF.FileName;//返回文件的完整路径
                // 清除 listbox 项目
                lbPdfFiles.Items.Clear();
                // 填充 listbox
                foreach (String file in openFileDialogPDF.FileNames)
                {
                    try
                    {
                        lbPdfFiles.Items.Add(file);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("文件打开错误！");
                    }
                }
            }
        }

        private void rbtMerge_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbtMerge.Checked)
            {
                this.openFileDialogPDF.Multiselect = true;
            }
            else
            {
                this.openFileDialogPDF.Multiselect = false;
            }
        }

        private void btRun_Click(object sender, EventArgs e)
        {
            // string msg = string.Empty;
            if (lbPdfFiles.Items.Count > 0)
            {
                if (rbtSplit.Checked)
                {
                    foreach (String file in lbPdfFiles.Items)
                    {
                        splitePDF(file);
                    }
                }
                if (rbtMerge.Checked)
                {
                    List<String> sourceFiles = new List<String>();
                    string outputFolder = string.Empty;
                    foreach (String file in lbPdfFiles.Items)
                    {
                        sourceFiles.Add(file);
                        if (outputFolder == string.Empty)
                        {
                            outputFolder = Path.GetDirectoryName(file);
                        }
                    }
                    mergePdfFiles(sourceFiles, outputFolder + "Merge_PDF.pdf");
                }
                lbPdfFiles.Items.Clear();
            }
            else
            {
                MessageBox.Show("请选择 PDF 文件后，再执行！");
            }
        }

        #region 分割 PDF 文件方法
        /// <summary>
        /// 分割 PDF 文件
        /// </summary>
        /// <param name="dest">需要分割的原始 PDF 文件</param>
        private void splitePDF(string dest)
        {
            try
            {
                // 输入PDF文件路径
                string inputFilePath = Path.GetFullPath(dest);

                // 输出PDF文件夹路径
                string outputFolder = Path.GetDirectoryName(dest);

                // 创建 PdfReader
                using (PdfReader pdfReader = new PdfReader(inputFilePath))
                {
                    // 获取 PdfDocument
                    using (PdfDocument pdfDocument = new PdfDocument(pdfReader))
                    {
                        // 循环处理每一页
                        for (int pageNum = 1; pageNum <= pdfDocument.GetNumberOfPages(); pageNum++)
                        {
                            // 创建新的 PdfDocument
                            using (PdfDocument newPdfDocument = new PdfDocument(new PdfWriter(outputFolder + "page_" + pageNum + ".pdf")))
                            {
                                // 复制当前页到新的 PdfDocument
                                pdfDocument.CopyPagesTo(pageNum, pageNum, newPdfDocument);

                                // 关闭新的 PdfDocument
                                newPdfDocument.Close();
                            }
                        }
                    }
                }

                // Console.WriteLine("PDF 分割完成！");

                MessageBox.Show("PDF 分割完成！");
            }
            catch (Exception e)
            {
                Console.WriteLine($"发生错误: {e.Message}");
            }
        }
        #endregion

        #region 合并 PDF 文件方法
        /// <summary>
        /// 合并 PDF 文件
        /// </summary>
        /// <param name="sourceFiles">数组包含要合并的源 PDF 文件的路径</param>
        /// <param name="destinationFile">是合并后的 PDF 文件的路径</param>
        static void mergePdfFiles(List<String> sourceFiles, string destinationFile)
        {
            using (var destinationStream = new FileStream(destinationFile, FileMode.Create))
            {
                using (var pdfWriter = new PdfWriter(destinationStream))
                {
                    using (var pdfDocument = new PdfDocument(pdfWriter))
                    {
                        var pdfMerger = new PdfMerger(pdfDocument);

                        foreach (var sourceFile in sourceFiles)
                        {
                            using (var sourceStream = new FileStream(sourceFile, FileMode.Open))
                            {
                                using (var sourceDocument = new PdfDocument(new PdfReader(sourceStream)))
                                {
                                    pdfMerger.Merge(sourceDocument, 1, sourceDocument.GetNumberOfPages());
                                }
                            }
                        }
                        MessageBox.Show("PDF 合并完毕！");
                    }
                }
            }
        }
        #endregion
    }
}
