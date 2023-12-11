using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

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
    }
}
