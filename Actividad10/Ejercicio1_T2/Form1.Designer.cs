namespace Ejercicio1
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
            lsbVerSolicitudesImportadas = new ListBox();
            btnImportarSolicitudes = new Button();
            openFileDialog1 = new OpenFileDialog();
            lsbColaSolicitudesAAtender = new ListBox();
            lbSolicitudSeleccionada = new Label();
            btnConfirmarAtencion = new Button();
            listBox1 = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // lsbVerSolicitudesImportadas
            // 
            lsbVerSolicitudesImportadas.FormattingEnabled = true;
            lsbVerSolicitudesImportadas.ItemHeight = 21;
            lsbVerSolicitudesImportadas.Location = new Point(13, 63);
            lsbVerSolicitudesImportadas.Margin = new Padding(4);
            lsbVerSolicitudesImportadas.Name = "lsbVerSolicitudesImportadas";
            lsbVerSolicitudesImportadas.Size = new Size(156, 193);
            lsbVerSolicitudesImportadas.TabIndex = 0;
            lsbVerSolicitudesImportadas.SelectedValueChanged += lsbVerSolicitudesImportadas_SelectedValueChanged;
            // 
            // btnImportarSolicitudes
            // 
            btnImportarSolicitudes.Location = new Point(15, 13);
            btnImportarSolicitudes.Margin = new Padding(4);
            btnImportarSolicitudes.Name = "btnImportarSolicitudes";
            btnImportarSolicitudes.Size = new Size(96, 32);
            btnImportarSolicitudes.TabIndex = 1;
            btnImportarSolicitudes.Text = "Importar Solicitudes";
            btnImportarSolicitudes.UseVisualStyleBackColor = true;
            btnImportarSolicitudes.Click += btnImportarSolicitudes_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // lsbColaSolicitudesAAtender
            // 
            lsbColaSolicitudesAAtender.FormattingEnabled = true;
            lsbColaSolicitudesAAtender.ItemHeight = 21;
            lsbColaSolicitudesAAtender.Location = new Point(333, 63);
            lsbColaSolicitudesAAtender.Margin = new Padding(4);
            lsbColaSolicitudesAAtender.Name = "lsbColaSolicitudesAAtender";
            lsbColaSolicitudesAAtender.Size = new Size(159, 193);
            lsbColaSolicitudesAAtender.TabIndex = 2;
            // 
            // lbSolicitudSeleccionada
            // 
            lbSolicitudSeleccionada.BackColor = SystemColors.ActiveCaption;
            lbSolicitudSeleccionada.Location = new Point(192, 63);
            lbSolicitudSeleccionada.Margin = new Padding(4, 0, 4, 0);
            lbSolicitudSeleccionada.Name = "lbSolicitudSeleccionada";
            lbSolicitudSeleccionada.Size = new Size(121, 55);
            lbSolicitudSeleccionada.TabIndex = 3;
            lbSolicitudSeleccionada.Text = "Seleccione de la lista";
            // 
            // btnConfirmarAtencion
            // 
            btnConfirmarAtencion.Location = new Point(177, 141);
            btnConfirmarAtencion.Margin = new Padding(4);
            btnConfirmarAtencion.Name = "btnConfirmarAtencion";
            btnConfirmarAtencion.Size = new Size(121, 106);
            btnConfirmarAtencion.TabIndex = 4;
            btnConfirmarAtencion.Text = "Confirmar selección hacia cola de atención";
            btnConfirmarAtencion.UseVisualStyleBackColor = true;
            btnConfirmarAtencion.Click += btnConfirmarAtencion_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Location = new Point(638, 63);
            listBox1.Margin = new Padding(4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(159, 193);
            listBox1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(509, 88);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(121, 106);
            button1.TabIndex = 6;
            button1.Text = "Confirmar selección hacia cola de atención";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 273);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(btnConfirmarAtencion);
            Controls.Add(lbSolicitudSeleccionada);
            Controls.Add(lsbColaSolicitudesAAtender);
            Controls.Add(btnImportarSolicitudes);
            Controls.Add(lsbVerSolicitudesImportadas);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lsbVerSolicitudesImportadas;
        private Button btnImportarSolicitudes;
        private OpenFileDialog openFileDialog1;
        private ListBox lsbColaSolicitudesAAtender;
        private Label lbSolicitudSeleccionada;
        private Button btnConfirmarAtencion;
        private ListBox listBox1;
        private Button button1;
    }
}
