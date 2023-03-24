using Spire.Pdf;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurboPrintDocument
{
    public partial class ESP001 : System.Windows.Forms.Form
    {
        private const char Separator = '\\';

        public ESP001()
        {
            InitializeComponent();
            openFileDialog_LoadPDFDocuments.InitialDirectory = @"C:\Users\" + Environment.GetEnvironmentVariable("USERNAME");
            openFileDialog_LoadPDFDocuments.RestoreDirectory = true;
            openFileDialog_LoadPDFDocuments.Title = "Load PDF Documents to Print";
            openFileDialog_LoadPDFDocuments.DefaultExt = ".pdf";
            openFileDialog_LoadPDFDocuments.Filter = "PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*";
            openFileDialog_LoadPDFDocuments.FilterIndex = 1;
            openFileDialog_LoadPDFDocuments.CheckFileExists = true;
            openFileDialog_LoadPDFDocuments.CheckPathExists = true;
            openFileDialog_LoadPDFDocuments.Multiselect = true;
        }

        private void button_Print_Click(object sender, EventArgs e)
        {
            PrintPDF(comboBox_Printers.Text);
        }

        private void button_LoadDocuments_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog_LoadPDFDocuments.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                foreach (string path in openFileDialog_LoadPDFDocuments.FileNames)
                {
                    dataGridView_Documents.Rows.Add(
                        new object[] { path, "LOADED" }
                        );
                }
            }
            toolStripStatusLabel_StatusApp.Text = "Files loaded in table: " + dataGridView_Documents.Rows.Count.ToString();
        }

        private void ESP001_Load(object sender, EventArgs e)
        {
            foreach (string printerName in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                comboBox_Printers.Items.Add(printerName);
            }
            comboBox_Printers.SelectedIndex = 0;

        }

        private async void PrintPDF(string printer)
        {
            foreach (DataGridViewRow row in dataGridView_Documents.Rows)
            {
                row.Cells[1].Value = "SEND TO PRINT...";
                row.Cells[1].Style.BackColor = Color.Orange;

                PdfDocument doc = new PdfDocument();
                doc.LoadFromFile(row.Cells[0].Value.ToString());
                doc.PrintSettings.PrinterName = comboBox_Printers.Text;
                await Task.Run(() => doc.Print());
                row.Cells[1].Value = "SENDED TO PRINT ";
                row.Cells[1].Style.BackColor = Color.Green;
                row.Cells[1].Style.ForeColor = Color.White;
            }
            MessageBox.Show("Everithing is all right !!!", "I want to print more PDF documents...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_CleanTable_Click(object sender, EventArgs e)
        {
            dataGridView_Documents.Rows.Clear();
            toolStripStatusLabel_StatusApp.Text = "Table cleaned";
        }
    }
}
