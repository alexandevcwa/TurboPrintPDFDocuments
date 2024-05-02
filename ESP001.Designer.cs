
namespace TurboPrintDocument
{
    partial class ESP001
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ESP001));
            this.openFileDialog_LoadPDFDocuments = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView_Documents = new System.Windows.Forms.DataGridView();
            this.PATH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox_Printers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_StatusApp = new System.Windows.Forms.ToolStripStatusLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.previewControl_PdfDocument = new System.Windows.Forms.PrintPreviewControl();
            this.button_ActualizarImpresoras = new System.Windows.Forms.Button();
            this.button_PrintOnlyOne = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_CleanTable = new System.Windows.Forms.Button();
            this.button_PrintAll = new System.Windows.Forms.Button();
            this.button_LoadPdfDocuments = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Documents)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog_LoadPDFDocuments
            // 
            this.openFileDialog_LoadPDFDocuments.FileName = "openFileDialog_LoadPDFDocuments";
            // 
            // dataGridView_Documents
            // 
            this.dataGridView_Documents.AllowUserToAddRows = false;
            this.dataGridView_Documents.AllowUserToDeleteRows = false;
            this.dataGridView_Documents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView_Documents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Documents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Documents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Documents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PATH,
            this.STATUS});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Documents.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_Documents.Location = new System.Drawing.Point(12, 148);
            this.dataGridView_Documents.MultiSelect = false;
            this.dataGridView_Documents.Name = "dataGridView_Documents";
            this.dataGridView_Documents.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Documents.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_Documents.RowHeadersWidth = 51;
            this.dataGridView_Documents.RowTemplate.Height = 24;
            this.dataGridView_Documents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Documents.Size = new System.Drawing.Size(901, 552);
            this.dataGridView_Documents.TabIndex = 4;
            this.dataGridView_Documents.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PdfDocumentPreview_CellDoubleClick);
            this.dataGridView_Documents.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.PdfDocumentPreview_CellEnter);
            this.dataGridView_Documents.TabIndexChanged += new System.EventHandler(this.INdex);
            this.dataGridView_Documents.Enter += new System.EventHandler(this.Teesst);
            // 
            // PATH
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PATH.DefaultCellStyle = dataGridViewCellStyle2;
            this.PATH.HeaderText = "RUTA DE ARCHIVOS";
            this.PATH.MinimumWidth = 6;
            this.PATH.Name = "PATH";
            this.PATH.ReadOnly = true;
            this.PATH.Width = 154;
            // 
            // STATUS
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STATUS.DefaultCellStyle = dataGridViewCellStyle3;
            this.STATUS.HeaderText = "ESTADO";
            this.STATUS.MinimumWidth = 6;
            this.STATUS.Name = "STATUS";
            this.STATUS.ReadOnly = true;
            this.STATUS.Width = 92;
            // 
            // comboBox_Printers
            // 
            this.comboBox_Printers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Printers.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Printers.FormattingEnabled = true;
            this.comboBox_Printers.Location = new System.Drawing.Point(12, 112);
            this.comboBox_Printers.Name = "comboBox_Printers";
            this.comboBox_Printers.Size = new System.Drawing.Size(368, 28);
            this.comboBox_Printers.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Impresoras";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_StatusApp});
            this.statusStrip1.Location = new System.Drawing.Point(0, 703);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1365, 24);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_StatusApp
            // 
            this.toolStripStatusLabel_StatusApp.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel_StatusApp.Name = "toolStripStatusLabel_StatusApp";
            this.toolStripStatusLabel_StatusApp.Size = new System.Drawing.Size(216, 18);
            this.toolStripStatusLabel_StatusApp.Text = "Developed By AlexanDev_CWA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(71, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(406, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Turbo Print PDF Documents (PDF Only)";
            // 
            // previewControl_PdfDocument
            // 
            this.previewControl_PdfDocument.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.previewControl_PdfDocument.AutoZoom = false;
            this.previewControl_PdfDocument.Location = new System.Drawing.Point(919, 148);
            this.previewControl_PdfDocument.Name = "previewControl_PdfDocument";
            this.previewControl_PdfDocument.Size = new System.Drawing.Size(434, 552);
            this.previewControl_PdfDocument.TabIndex = 11;
            this.previewControl_PdfDocument.Zoom = 0.95D;
            // 
            // button_ActualizarImpresoras
            // 
            this.button_ActualizarImpresoras.BackColor = System.Drawing.SystemColors.Control;
            this.button_ActualizarImpresoras.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button_ActualizarImpresoras.FlatAppearance.BorderSize = 2;
            this.button_ActualizarImpresoras.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ActualizarImpresoras.Image = global::TurboPrintDocument.Properties.Resources.icons8_refresh_30;
            this.button_ActualizarImpresoras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ActualizarImpresoras.Location = new System.Drawing.Point(223, 62);
            this.button_ActualizarImpresoras.Name = "button_ActualizarImpresoras";
            this.button_ActualizarImpresoras.Size = new System.Drawing.Size(157, 44);
            this.button_ActualizarImpresoras.TabIndex = 13;
            this.button_ActualizarImpresoras.Text = "Actualizar\r\nImpresoras";
            this.button_ActualizarImpresoras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_ActualizarImpresoras.UseVisualStyleBackColor = false;
            this.button_ActualizarImpresoras.Click += new System.EventHandler(this.button_ActualizarImpresoras_Click);
            // 
            // button_PrintOnlyOne
            // 
            this.button_PrintOnlyOne.BackColor = System.Drawing.SystemColors.Control;
            this.button_PrintOnlyOne.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button_PrintOnlyOne.FlatAppearance.BorderSize = 2;
            this.button_PrintOnlyOne.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_PrintOnlyOne.Image = global::TurboPrintDocument.Properties.Resources.icons8_one_page_30;
            this.button_PrintOnlyOne.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_PrintOnlyOne.Location = new System.Drawing.Point(638, 69);
            this.button_PrintOnlyOne.Name = "button_PrintOnlyOne";
            this.button_PrintOnlyOne.Size = new System.Drawing.Size(120, 73);
            this.button_PrintOnlyOne.TabIndex = 12;
            this.button_PrintOnlyOne.Text = "Imprimir\r\nun PDF";
            this.button_PrintOnlyOne.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button_PrintOnlyOne.UseVisualStyleBackColor = false;
            this.button_PrintOnlyOne.Click += new System.EventHandler(this.button_PrintOnlyOne_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TurboPrintDocument.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // button_CleanTable
            // 
            this.button_CleanTable.BackColor = System.Drawing.SystemColors.Control;
            this.button_CleanTable.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button_CleanTable.FlatAppearance.BorderSize = 2;
            this.button_CleanTable.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CleanTable.Image = global::TurboPrintDocument.Properties.Resources.icons8_broom_30;
            this.button_CleanTable.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_CleanTable.Location = new System.Drawing.Point(764, 69);
            this.button_CleanTable.Name = "button_CleanTable";
            this.button_CleanTable.Size = new System.Drawing.Size(120, 73);
            this.button_CleanTable.TabIndex = 3;
            this.button_CleanTable.Text = "Limpar Tabla";
            this.button_CleanTable.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button_CleanTable.UseVisualStyleBackColor = false;
            this.button_CleanTable.Click += new System.EventHandler(this.button_CleanTable_Click);
            // 
            // button_PrintAll
            // 
            this.button_PrintAll.BackColor = System.Drawing.SystemColors.Control;
            this.button_PrintAll.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button_PrintAll.FlatAppearance.BorderSize = 2;
            this.button_PrintAll.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_PrintAll.Image = global::TurboPrintDocument.Properties.Resources.icons8_print_30;
            this.button_PrintAll.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_PrintAll.Location = new System.Drawing.Point(512, 69);
            this.button_PrintAll.Name = "button_PrintAll";
            this.button_PrintAll.Size = new System.Drawing.Size(120, 73);
            this.button_PrintAll.TabIndex = 2;
            this.button_PrintAll.Text = "Imprimir PDFs";
            this.button_PrintAll.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button_PrintAll.UseVisualStyleBackColor = false;
            this.button_PrintAll.Click += new System.EventHandler(this.button_Print_Click);
            // 
            // button_LoadPdfDocuments
            // 
            this.button_LoadPdfDocuments.BackColor = System.Drawing.SystemColors.Control;
            this.button_LoadPdfDocuments.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.button_LoadPdfDocuments.FlatAppearance.BorderSize = 2;
            this.button_LoadPdfDocuments.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_LoadPdfDocuments.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_LoadPdfDocuments.Image = global::TurboPrintDocument.Properties.Resources.icons8_upload_to_ftp_30;
            this.button_LoadPdfDocuments.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_LoadPdfDocuments.Location = new System.Drawing.Point(386, 69);
            this.button_LoadPdfDocuments.Name = "button_LoadPdfDocuments";
            this.button_LoadPdfDocuments.Size = new System.Drawing.Size(120, 73);
            this.button_LoadPdfDocuments.TabIndex = 1;
            this.button_LoadPdfDocuments.Text = "Cargar PDFs";
            this.button_LoadPdfDocuments.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button_LoadPdfDocuments.UseVisualStyleBackColor = false;
            this.button_LoadPdfDocuments.Click += new System.EventHandler(this.button_LoadDocuments_Click);
            // 
            // ESP001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1365, 727);
            this.Controls.Add(this.button_ActualizarImpresoras);
            this.Controls.Add(this.button_PrintOnlyOne);
            this.Controls.Add(this.previewControl_PdfDocument);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button_CleanTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Printers);
            this.Controls.Add(this.dataGridView_Documents);
            this.Controls.Add(this.button_PrintAll);
            this.Controls.Add(this.button_LoadPdfDocuments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ESP001";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turbo Print PDF Documents (v1.0.0)";
            this.Load += new System.EventHandler(this.ESP001_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Documents)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_LoadPdfDocuments;
        private System.Windows.Forms.Button button_PrintAll;
        private System.Windows.Forms.OpenFileDialog openFileDialog_LoadPDFDocuments;
        private System.Windows.Forms.DataGridView dataGridView_Documents;
        private System.Windows.Forms.ComboBox comboBox_Printers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_CleanTable;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_StatusApp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PATH;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
        private System.Windows.Forms.PrintPreviewControl previewControl_PdfDocument;
        private System.Windows.Forms.Button button_PrintOnlyOne;
        private System.Windows.Forms.Button button_ActualizarImpresoras;
    }
}

