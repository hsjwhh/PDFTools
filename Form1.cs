using iText.IO.Image;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Kernel.Utils;
using iText.Layout;
using iText.Layout.Element;
using ReaLTaiizor.Forms;
using System.Windows.Forms;
using Path = System.IO.Path;

namespace PDFTools
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
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
                string inputFilename = Path.GetFileNameWithoutExtension(dest);

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
                            using (PdfDocument newPdfDocument = new PdfDocument(new PdfWriter(outputFolder + "\\" + inputFilename + "_page_" + pageNum + ".pdf")))
                            {
                                // 复制当前页到新的 PdfDocument
                                pdfDocument.CopyPagesTo(pageNum, pageNum, newPdfDocument);

                                // 关闭新的 PdfDocument
                                newPdfDocument.Close();
                            }
                        }
                    }
                }

                MessageBox.Show("PDF 分割完成！");
            }
            catch (Exception e)
            {
                MessageBox.Show($"发生错误: {e.Message}");
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

        private void mbtSelectPDF_Click(object sender, EventArgs e)
        {
            //OpenFileDialog fileDialog = new OpenFileDialog();

            // 检查确认是否可以多选文件
            checkMrbtChecked();
            openFileDialogPDF.Title = "请选择 PDF 文件";
            openFileDialogPDF.Filter = "PDF 文件|*.pdf"; //设置要选择的文件的类型
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

        private void mbtRun_Click(object sender, EventArgs e)
        {
            // string msg = string.Empty;
            if (lbPdfFiles.Items.Count > 0)
            {
                if (mrbtSplit.Checked)
                {
                    foreach (String file in lbPdfFiles.Items)
                    {
                        splitePDF(file);
                    }
                }
                if (mrbtMerge.Checked)
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
                    mergePdfFiles(sourceFiles, outputFolder + "\\Merge_PDF.pdf");
                }
                lbPdfFiles.Items.Clear();
            }
            else
            {
                MessageBox.Show("请选择 PDF 文件后，再执行！");
            }
        }


        private void checkMrbtChecked()
        {
            if (this.mrbtMerge.Checked)
            {
                this.openFileDialogPDF.Multiselect = true;
            }
            else
            {
                this.openFileDialogPDF.Multiselect = false;
            }
        }

        private void mbtSelectIMG_Click(object sender, EventArgs e)
        {
            //OpenFileDialog fileDialog = new OpenFileDialog();

            this.openFileDialogPDF.Multiselect = true;
            this.openFileDialogPDF.Title = "请选择需要转换到 PDF 的【图像】文件";
            this.openFileDialogPDF.Filter = "JPEG 文件|*.jpg|PNG 文件|*.png"; //设置要选择的文件的类型
            if (openFileDialogPDF.ShowDialog() == DialogResult.OK)
            {
                // 清除 listbox 项目
                lbImgFiles.Items.Clear();
                // 填充 listbox
                foreach (String file in openFileDialogPDF.FileNames)
                {
                    try
                    {
                        lbImgFiles.Items.Add(file);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("文件打开错误！");
                    }
                }
            }
        }

        private void mbtImgToPDFRun_Click(object sender, EventArgs e)
        {
            // string msg = string.Empty;
            if (lbImgFiles.Items.Count > 0)
            {

                List<String> sourceFiles = new List<String>();
                string outputFolder = string.Empty;
                foreach (String file in lbImgFiles.Items)
                {
                    sourceFiles.Add(file);
                    if (outputFolder == string.Empty)
                    {
                        outputFolder = Path.GetDirectoryName(file);
                    }
                }
                imgToPdfFiles(sourceFiles, outputFolder + "\\ImgToPDF.pdf");

                lbImgFiles.Items.Clear();
            }
            else
            {
                MessageBox.Show("请选择 图像 文件后，再执行！");
            }
        }

        private void imgToPdfFiles(List<string> imageFiles, string outputPath)
        {
            // 创建一个 PDF 文档
            using (PdfWriter writer = new PdfWriter(outputPath))
            {
                using (PdfDocument pdf = new PdfDocument(writer))
                {
                    // 创建文档布局
                    Document document = new Document(pdf);

                    // 判断图片的宽高比，用于确定文档方向
                    bool isLandscape = CalculateImageAspectRatio(imageFiles) > 1;

                    // 设置文档方向
                    pdf.SetDefaultPageSize(isLandscape ? PageSize.A4.Rotate() : PageSize.A4);

                    // 循环处理每张图片
                    for (int i = 0; i < imageFiles.Count; i++)
                    {
                        // 添加图片到 PDF，并让图片自适应大小
                        addImageToPdf(document, imageFiles[i]);
                        // 判断是否最后一张图片
                        if (i < imageFiles.Count - 1)
                        {
                            // 添加空白页
                            document.Add(new AreaBreak()); // 添加换行new Paragraph("\n")，可根据需要调整
                        }

                    }

                    // 关闭文档
                    document.Close();
                }
            }
            MessageBox.Show("PDF 文件已生成： " + outputPath);
        }

        // 计算大多数图片的宽高比
        static double CalculateImageAspectRatio(List<string> imageFiles)
        {
            double totalAspectRatio = 0;

            // 获取所有图片的宽高比
            foreach (var imagePath in imageFiles)
            {
                using (var stream = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                {
                    // 如果图片格式为常见几种 jpeg、png等直接使用 Create，否则请指定具体格式
                    var image = ImageDataFactory.Create(new Uri(imagePath));
                    double aspectRatio = (double)image.GetWidth() / image.GetHeight();
                    totalAspectRatio += aspectRatio;
                }
            }

            // 计算平均宽高比
            double averageAspectRatio = totalAspectRatio / imageFiles.Count;

            return averageAspectRatio;
        }

        // 添加图片到 PDF，并让图片自适应大小
        static void addImageToPdf(Document document, string imagePath)
        {
            // 读取图片文件
            iText.Layout.Element.Image image = new iText.Layout.Element.Image(ImageDataFactory.Create(imagePath));

            // 启用自动缩放
            image.SetAutoScale(true);

            // 添加图片到文档
            document.Add(image);
        }
    }
}
