namespace Ejercicio1_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            openFileDialog1 = new OpenFileDialog();
            lsbVerSolicitudesImportadas = new ListBox();
            btnImportarSolicitudes = new Button();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // lsbVerSolicitudesImportadas
            // 
            lsbVerSolicitudesImportadas.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lsbVerSolicitudesImportadas.FormattingEnabled = true;
            lsbVerSolicitudesImportadas.ItemHeight = 17;
            lsbVerSolicitudesImportadas.Location = new Point(13, 98);
            lsbVerSolicitudesImportadas.Margin = new Padding(4, 4, 4, 4);
            lsbVerSolicitudesImportadas.Name = "lsbVerSolicitudesImportadas";
            lsbVerSolicitudesImportadas.Size = new Size(211, 208);
            lsbVerSolicitudesImportadas.TabIndex = 0;
            // 
            // btnImportarSolicitudes
            // 
            btnImportarSolicitudes.Location = new Point(13, 31);
            btnImportarSolicitudes.Margin = new Padding(4, 4, 4, 4);
            btnImportarSolicitudes.Name = "btnImportarSolicitudes";
            btnImportarSolicitudes.Size = new Size(137, 59);
            btnImportarSolicitudes.TabIndex = 1;
            btnImportarSolicitudes.Text = "Importar Solicitudes";
            btnImportarSolicitudes.UseVisualStyleBackColor = true;
            btnImportarSolicitudes.Click += btnImportarSolicitudes_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 344);
            Controls.Add(btnImportarSolicitudes);
            Controls.Add(lsbVerSolicitudesImportadas);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private ListBox lsbVerSolicitudesImportadas;
        private Button btnImportarSolicitudes;
    }
}
