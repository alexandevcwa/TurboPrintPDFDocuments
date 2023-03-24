
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_CleanTable = new System.Windows.Forms.Button();
            this.button_Print = new System.Windows.Forms.Button();
            this.button_GetDocuments = new System.Windows.Forms.Button();
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
            this.dataGridView_Documents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_Documents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Documents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PATH,
            this.STATUS});
            this.dataGridView_Documents.Location = new System.Drawing.Point(12, 148);
            this.dataGridView_Documents.MultiSelect = false;
            this.dataGridView_Documents.Name = "dataGridView_Documents";
            this.dataGridView_Documents.ReadOnly = true;
            this.dataGridView_Documents.RowHeadersWidth = 51;
            this.dataGridView_Documents.RowTemplate.Height = 24;
            this.dataGridView_Documents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Documents.Size = new System.Drawing.Size(1183, 507);
            this.dataGridView_Documents.TabIndex = 4;
            // 
            // PATH
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PATH.DefaultCellStyle = dataGridViewCellStyle1;
            this.PATH.HeaderText = "PATH";
            this.PATH.MinimumWidth = 6;
            this.PATH.Name = "PATH";
            this.PATH.ReadOnly = true;
            this.PATH.Width = 74;
            // 
            // STATUS
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STATUS.DefaultCellStyle = dataGridViewCellStyle2;
            this.STATUS.HeaderText = "STATUS";
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
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select a Printer";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_StatusApp});
            this.statusStrip1.Location = new System.Drawing.Point(0, 674);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1207, 24);
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
            this.button_CleanTable.Location = new System.Drawing.Point(638, 69);
            this.button_CleanTable.Name = "button_CleanTable";
            this.button_CleanTable.Size = new System.Drawing.Size(120, 73);
            this.button_CleanTable.TabIndex = 3;
            this.button_CleanTable.Text = "Clean\r\nAll Table";
            this.button_CleanTable.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button_CleanTable.UseVisualStyleBackColor = false;
            this.button_CleanTable.Click += new System.EventHandler(this.button_CleanTable_Click);
            // 
            // button_Print
            // 
            this.button_Print.BackColor = System.Drawing.SystemColors.Control;
            this.button_Print.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button_Print.FlatAppearance.BorderSize = 2;
            this.button_Print.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Print.Image = global::TurboPrintDocument.Properties.Resources.icons8_print_30;
            this.button_Print.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_Print.Location = new System.Drawing.Point(512, 69);
            this.button_Print.Name = "button_Print";
            this.button_Print.Size = new System.Drawing.Size(120, 73);
            this.button_Print.TabIndex = 2;
            this.button_Print.Text = "Print PDF\r\nDocuments";
            this.button_Print.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button_Print.UseVisualStyleBackColor = false;
            this.button_Print.Click += new System.EventHandler(this.button_Print_Click);
            // 
            // button_GetDocuments
            // 
            this.button_GetDocuments.BackColor = System.Drawing.SystemColors.Control;
            this.button_GetDocuments.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.button_GetDocuments.FlatAppearance.BorderSize = 2;
            this.button_GetDocuments.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_GetDocuments.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_GetDocuments.Image = global::TurboPrintDocument.Properties.Resources.icons8_upload_to_ftp_30;
            this.button_GetDocuments.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_GetDocuments.Location = new System.Drawing.Point(386, 69);
            this.button_GetDocuments.Name = "button_GetDocuments";
            this.button_GetDocuments.Size = new System.Drawing.Size(120, 73);
            this.button_GetDocuments.TabIndex = 1;
            this.button_GetDocuments.Text = "Load PDF\r\nDocuments";
            this.button_GetDocuments.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button_GetDocuments.UseVisualStyleBackColor = false;
            this.button_GetDocuments.Click += new System.EventHandler(this.button_LoadDocuments_Click);
            // 
            // ESP001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1207, 698);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button_CleanTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Printers);
            this.Controls.Add(this.dataGridView_Documents);
            this.Controls.Add(this.button_Print);
            this.Controls.Add(this.button_GetDocuments);
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
        private System.Windows.Forms.Button button_GetDocuments;
        private System.Windows.Forms.Button button_Print;
        private System.Windows.Forms.OpenFileDialog openFileDialog_LoadPDFDocuments;
        private System.Windows.Forms.DataGridView dataGridView_Documents;
        private System.Windows.Forms.ComboBox comboBox_Printers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_CleanTable;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_StatusApp;
        private System.Windows.Forms.DataGridViewTextBoxColumn PATH;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

