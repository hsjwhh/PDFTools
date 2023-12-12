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
            //openFileDialogPDF.Title = "��ѡ���ļ�";
            //openFileDialogPDF.Filter = "���� PDF �ļ�|*.pdf"; //����Ҫѡ����ļ�������
            if (openFileDialogPDF.ShowDialog() == DialogResult.OK)
            {
                //System.IO.Path.GetFullPath(openFileDialogPDF.FileName);//����·��
                //System.IO.Path.GetExtension(openFileDialogPDF.FileName);//�ļ���չ��
                //System.IO.Path.GetFileNameWithoutExtension(openFileDialogPDF.FileName);//�ļ���û����չ��
                //System.IO.Path.GetFileName(openFileDialogPDF.FileName);//�õ��ļ���
                //System.IO.Path.GetDirectoryName(openFileDialogPDF.FileName);//�õ�·��

                // tbFilename.Text = openFileDialogPDF.FileName;//�����ļ�������·��
                // ��� listbox ��Ŀ
                lbPdfFiles.Items.Clear();
                // ��� listbox
                foreach (String file in openFileDialogPDF.FileNames)
                {
                    try
                    {
                        lbPdfFiles.Items.Add(file);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("�ļ��򿪴���");
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
                // ����PDF�ļ�·��
                string inputFilePath = Path.GetFullPath(dest);

                // ���PDF�ļ���·��
                string outputFolder = Path.GetDirectoryName(dest);

                // ���� PdfReader
                using (PdfReader pdfReader = new PdfReader(inputFilePath))
                {
                    // ��ȡ PdfDocument
                    using (PdfDocument pdfDocument = new PdfDocument(pdfReader))
                    {
                        // ѭ������ÿһҳ
                        for (int pageNum = 1; pageNum <= pdfDocument.GetNumberOfPages(); pageNum++)
                        {
                            // �����µ� PdfDocument
                            using (PdfDocument newPdfDocument = new PdfDocument(new PdfWriter(outputFolder + "page_" + pageNum + ".pdf")))
                            {
                                // ���Ƶ�ǰҳ���µ� PdfDocument
                                pdfDocument.CopyPagesTo(pageNum, pageNum, newPdfDocument);

                                // �ر��µ� PdfDocument
                                newPdfDocument.Close();
                            }
                        }
                    }
                }

                Console.WriteLine("PDF �ָ���ɣ�");
            }
            catch (Exception e)
            {
                Console.WriteLine($"��������: {e.Message}");
            }
        }
    }
}
