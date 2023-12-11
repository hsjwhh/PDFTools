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
    }
}
