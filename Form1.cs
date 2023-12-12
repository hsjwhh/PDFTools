using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;

namespace PDFTools
{
    public partial class Form1 : Form
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
            string msg = string.Empty;
            if (lbPdfFiles.Items.Count > 0)
            {
                foreach (String file in lbPdfFiles.Items)
                {
                    splitePDF(file);
                }
                //MessageBox.Show(msg);
            }
            else
            {
                //MessageBox.Show(msg);
            }
        }

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

                Console.WriteLine("PDF 分割完成！");
            }
            catch (Exception e)
            {
                Console.WriteLine($"发生错误: {e.Message}");
            }
        }
    }
}
