using Spire.Pdf;
using System;
using System.Drawing;
using System.Management;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurboPrintDocument
{
    public partial class ESP001 : System.Windows.Forms.Form
    {

        private static PdfDocument _pdfDocument;

        public ESP001()
        {
            InitializeComponent();
            //openFileDialog_LoadPDFDocuments.InitialDirectory = @"C:\Users\" + Environment.GetEnvironmentVariable("USERNAME");
            openFileDialog_LoadPDFDocuments.RestoreDirectory = true;
            openFileDialog_LoadPDFDocuments.Title = "Cargar archivos PDF";
            openFileDialog_LoadPDFDocuments.DefaultExt = ".pdf";
            openFileDialog_LoadPDFDocuments.Filter = "PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*";
            openFileDialog_LoadPDFDocuments.FilterIndex = 1;
            openFileDialog_LoadPDFDocuments.CheckFileExists = true;
            openFileDialog_LoadPDFDocuments.CheckPathExists = true;
            openFileDialog_LoadPDFDocuments.Multiselect = true;
            previewControl_PdfDocument.Rows = 1;
            previewControl_PdfDocument.Columns = 1;


        }

        private void button_Print_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Deseas imprimir todos los documentos?", "Impresión de tabla de documentos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
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
                        new object[] { path, "CARGADO" }
                        );
                }
            }
            toolStripStatusLabel_StatusApp.Text = "Archivos cargados en tabla: " + dataGridView_Documents.Rows.Count.ToString();
        }

        private void ESP001_Load(object sender, EventArgs e)
        {
            foreach (string printerName in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                if (PrinterStatus(printerName))
                {
                    comboBox_Printers.Items.Add(printerName);
                }
                else
                {
                    comboBox_Printers.Items.Add(printerName + " (Sin conexión)");
                }
            }
            comboBox_Printers.SelectedIndex = 0;

        }

        private async void PrintPDF(string printer)
        {
            foreach (DataGridViewRow row in dataGridView_Documents.Rows)
            {
                row.Cells[1].Value = "ENVIANDO A IMPRIMIR...";
                row.Cells[1].Style.BackColor = Color.Orange;
                await SendToPrint((row.Cells[0].Value.ToString()));
                row.Cells[1].Value = "ENVIADO A IMPRIMIR";
                row.Cells[1].Style.BackColor = Color.Green;
                row.Cells[1].Style.ForeColor = Color.White;
            }

            MessageBox.Show("Todos los documentos fueron enviados a imprimir", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async Task SendToPrint(string filePath)
        {
            PdfDocument doc = new PdfDocument();
            doc.LoadFromFile(filePath);
            doc.PrintSettings.PrinterName = comboBox_Printers.Text;
            await Task.Run(() => doc.Print());
        }


        private void button_CleanTable_Click(object sender, EventArgs e)
        {
            dataGridView_Documents.Rows.Clear();
            toolStripStatusLabel_StatusApp.Text = "Tabal limpiada";
        }

        private bool PrinterStatus(string printerName)
        {
            string str = "";
            bool online = false;
            ManagementScope scope = new ManagementScope(ManagementPath.DefaultPath);
            scope.Connect();

            //Consulta para obtener las impresoras, en la API Win32
            SelectQuery query = new SelectQuery("select * from Win32_Printer");
            ManagementClass m = new ManagementClass("Win32_Printer");

            ManagementObjectSearcher obj = new ManagementObjectSearcher(scope, query);
            //Obtenemos cada instancia del objeto ManagementObjectSearcher
            using (ManagementObjectCollection printers = m.GetInstances())
                foreach (ManagementObject printer in printers)
                {
                    if (printer != null)
                    {
                        //Obtenemos la primera impresora en el bucle
                        str = printer["Name"].ToString().ToLower();

                        if (str.Equals(printerName.ToLower()))
                        {
                            //Una vez encontrada verificamos el estado de ésta
                            if (printer["WorkOffline"].ToString().ToLower().Equals("true") || printer["PrinterStatus"].Equals(7))
                                //Fuera de línea
                                online = false;
                            else
                                //En línea
                                online = true;
                        }
                    }
                    else
                        throw new Exception("No fueron encontradas impresoras instaladas en el equipo");
                }
            return online;
        }

        private void Teesst(object sender, EventArgs e)
        {

        }

        private void INdex(object sender, EventArgs e)
        {

        }

        private void PdfDocumentPreview_CellEnter(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void PdfDocumentPreview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _pdfDocument = null;
            string filePath = "";

            try
            {
                // Limpiar el contenido actual
                previewControl_PdfDocument.Document = null;

                // Invalidar y refrescar el control
                previewControl_PdfDocument.InvalidatePreview();
                previewControl_PdfDocument.Refresh();

                filePath = dataGridView_Documents.CurrentRow.Cells[0].Value.ToString();
                _pdfDocument = new PdfDocument(filePath);
                _pdfDocument.Preview(previewControl_PdfDocument);
            }
            catch (Exception)
            {
                toolStripStatusLabel_StatusApp.Text = $"El documento {filePath} contiene mas de 10 páginas.";
            }
        }

        private void button_PrintOnlyOne_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = dataGridView_Documents.CurrentRow.Cells[0].Value.ToString();
                SendToPrint(filePath);
            }
            catch (NullReferenceException)
            {
                toolStripStatusLabel_StatusApp.Text = "No existen documentos cargados en tabla para imprimir";
            }
            
        }
    }
}
