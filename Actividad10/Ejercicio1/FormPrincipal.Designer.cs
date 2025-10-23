namespace Ejercicio1;

partial class FormPrincipal
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
        saveFileDialog1 = new SaveFileDialog();
        lsbVerSolicitudesImportadas = new ListBox();
        btnImportarSolicitudes = new Button();
        btnConfirmarAtencion = new Button();
        lbSolicitudSeleccionada = new Label();
        lsbColaSolitudesAAtender = new ListBox();
        btnResolverSolicitud = new Button();
        lsbHistorialResoluciones = new ListBox();
        lbRespuesta = new Label();
        label2 = new Label();
        label1 = new Label();
        btnExportarResoluciones = new Button();
        groupBox1 = new GroupBox();
        groupBox2 = new GroupBox();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
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
        lsbVerSolicitudesImportadas.Location = new Point(13, 116);
        lsbVerSolicitudesImportadas.Margin = new Padding(4);
        lsbVerSolicitudesImportadas.Name = "lsbVerSolicitudesImportadas";
        lsbVerSolicitudesImportadas.ScrollAlwaysVisible = true;
        lsbVerSolicitudesImportadas.Size = new Size(169, 242);
        lsbVerSolicitudesImportadas.TabIndex = 0;
        lsbVerSolicitudesImportadas.SelectedValueChanged += lsbVerSolicitudesImportadas_SelectedValueChanged;
        // 
        // btnImportarSolicitudes
        // 
        btnImportarSolicitudes.Location = new Point(13, 37);
        btnImportarSolicitudes.Margin = new Padding(4);
        btnImportarSolicitudes.Name = "btnImportarSolicitudes";
        btnImportarSolicitudes.Size = new Size(129, 50);
        btnImportarSolicitudes.TabIndex = 1;
        btnImportarSolicitudes.Text = "Importar Solicitudes";
        btnImportarSolicitudes.UseVisualStyleBackColor = true;
        btnImportarSolicitudes.Click += btnImportarSolicitudes_Click;
        // 
        // btnConfirmarAtencion
        // 
        btnConfirmarAtencion.Location = new Point(190, 197);
        btnConfirmarAtencion.Margin = new Padding(4);
        btnConfirmarAtencion.Name = "btnConfirmarAtencion";
        btnConfirmarAtencion.Size = new Size(113, 134);
        btnConfirmarAtencion.TabIndex = 2;
        btnConfirmarAtencion.Text = "Confirmar a cola de atención solicitud seleccionada";
        btnConfirmarAtencion.UseVisualStyleBackColor = true;
        btnConfirmarAtencion.Click += btnSeleccionar_Click;
        // 
        // lbSolicitudSeleccionada
        // 
        lbSolicitudSeleccionada.BackColor = SystemColors.ActiveCaption;
        lbSolicitudSeleccionada.Location = new Point(190, 132);
        lbSolicitudSeleccionada.Margin = new Padding(4, 0, 4, 0);
        lbSolicitudSeleccionada.Name = "lbSolicitudSeleccionada";
        lbSolicitudSeleccionada.Size = new Size(113, 61);
        lbSolicitudSeleccionada.TabIndex = 3;
        lbSolicitudSeleccionada.Text = "Seleccione de la lista";
        // 
        // lsbColaSolitudesAAtender
        // 
        lsbColaSolitudesAAtender.Font = new Font("Segoe UI", 9.75F);
        lsbColaSolitudesAAtender.FormattingEnabled = true;
        lsbColaSolitudesAAtender.ItemHeight = 17;
        lsbColaSolitudesAAtender.Location = new Point(311, 117);
        lsbColaSolitudesAAtender.Margin = new Padding(4);
        lsbColaSolitudesAAtender.Name = "lsbColaSolitudesAAtender";
        lsbColaSolitudesAAtender.Size = new Size(174, 242);
        lsbColaSolitudesAAtender.TabIndex = 4;
        // 
        // btnResolverSolicitud
        // 
        btnResolverSolicitud.Location = new Point(493, 132);
        btnResolverSolicitud.Margin = new Padding(4);
        btnResolverSolicitud.Name = "btnResolverSolicitud";
        btnResolverSolicitud.Size = new Size(79, 73);
        btnResolverSolicitud.TabIndex = 5;
        btnResolverSolicitud.Text = "Resolver solicitud";
        btnResolverSolicitud.UseVisualStyleBackColor = true;
        btnResolverSolicitud.Click += btnResolverSolicitud_Click;
        // 
        // lsbHistorialResoluciones
        // 
        lsbHistorialResoluciones.Font = new Font("Segoe UI", 9.75F);
        lsbHistorialResoluciones.FormattingEnabled = true;
        lsbHistorialResoluciones.ItemHeight = 17;
        lsbHistorialResoluciones.Location = new Point(7, 116);
        lsbHistorialResoluciones.Margin = new Padding(4);
        lsbHistorialResoluciones.Name = "lsbHistorialResoluciones";
        lsbHistorialResoluciones.Size = new Size(172, 242);
        lsbHistorialResoluciones.TabIndex = 6;
        // 
        // lbRespuesta
        // 
        lbRespuesta.AutoSize = true;
        lbRespuesta.Location = new Point(311, 92);
        lbRespuesta.Margin = new Padding(4, 0, 4, 0);
        lbRespuesta.Name = "lbRespuesta";
        lbRespuesta.Size = new Size(127, 21);
        lbRespuesta.TabIndex = 7;
        lbRespuesta.Text = "Cola de Atención";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(7, 91);
        label2.Margin = new Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new Size(151, 21);
        label2.TabIndex = 8;
        label2.Text = "Pila de Resoluciones";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(13, 91);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new Size(118, 21);
        label1.TabIndex = 9;
        label1.Text = "Lista Importada";
        // 
        // btnExportarResoluciones
        // 
        btnExportarResoluciones.Location = new Point(17, 37);
        btnExportarResoluciones.Margin = new Padding(4);
        btnExportarResoluciones.Name = "btnExportarResoluciones";
        btnExportarResoluciones.Size = new Size(151, 50);
        btnExportarResoluciones.TabIndex = 10;
        btnExportarResoluciones.Text = "Exportar Resoluciones";
        btnExportarResoluciones.UseVisualStyleBackColor = true;
        btnExportarResoluciones.Click += btnExportarResoluciones_Click;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(lsbVerSolicitudesImportadas);
        groupBox1.Controls.Add(btnResolverSolicitud);
        groupBox1.Controls.Add(btnImportarSolicitudes);
        groupBox1.Controls.Add(lbRespuesta);
        groupBox1.Controls.Add(label1);
        groupBox1.Controls.Add(lsbColaSolitudesAAtender);
        groupBox1.Controls.Add(btnConfirmarAtencion);
        groupBox1.Controls.Add(lbSolicitudSeleccionada);
        groupBox1.Location = new Point(12, 12);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(580, 376);
        groupBox1.TabIndex = 11;
        groupBox1.TabStop = false;
        groupBox1.Text = "Atención de solicitudes";
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(btnExportarResoluciones);
        groupBox2.Controls.Add(lsbHistorialResoluciones);
        groupBox2.Controls.Add(label2);
        groupBox2.Location = new Point(598, 12);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(186, 376);
        groupBox2.TabIndex = 12;
        groupBox2.TabStop = false;
        groupBox2.Text = "Bandeja de Respuestas";
        // 
        // FormPrincipal
        // 
        AutoScaleDimensions = new SizeF(9F, 21F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(790, 400);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4);
        Name = "FormPrincipal";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Form1";
        FormClosing += FormPrincipal_FormClosing;
        Load += FormPrincipal_Load;
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private OpenFileDialog openFileDialog1;
    private SaveFileDialog saveFileDialog1;
    private ListBox lsbVerSolicitudesImportadas;
    private Button btnImportarSolicitudes;
    private Button btnConfirmarAtencion;
    private Label lbSolicitudSeleccionada;
    private ListBox lsbColaSolitudesAAtender;
    private Button btnResolverSolicitud;
    private ListBox lsbHistorialResoluciones;
    private Label lbRespuesta;
    private Label label2;
    private Label label1;
    private Button btnExportarResoluciones;
    private GroupBox groupBox1;
    private GroupBox groupBox2;
}
