using System.IO;

namespace ASCII_2_BRAILLE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnConverter_Click(object sender, EventArgs e)
        {
            G11_1.Checked = true;
            G11_2.Checked = true;
            G11_3.Checked = true;
            G11_5.Checked = true;
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult fileDialog;

            OFDFile.Title = "Open File Text";
            OFDFile.Filter = "File Text | *.txt";
            OFDFile.FileName = "";

            fileDialog = OFDFile.ShowDialog();
            if (fileDialog == DialogResult.OK)
            {
                MessageBox.Show("File opened");
            }
            else
            {
                MessageBox.Show("Proccess canceled");
            }
        }
    }
}