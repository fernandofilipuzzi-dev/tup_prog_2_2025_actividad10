using Ejercicio1.Models;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Ejercicio1;

public partial class FormPrincipal : Form
{
    CentroAtencion centroAtencion = new CentroAtencion();

    public FormPrincipal()
    {
        InitializeComponent();
    }

    private void btnImportarSolicitudes_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(openFileDialog1.InitialDirectory))
            openFileDialog1.InitialDirectory = "./";

        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        {
            string path = openFileDialog1.FileName;

            FileStream fs = null;
            try
            {
                fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                {
                    centroAtencion.ImportarCsvSolicitudesEntrantes(fs);
                }
                MessageBox.Show("Archivo importado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al importar el archivo: " + ex.Message);
            }
            finally
            {
                fs.Close();
            }
            VerSolicitudesPendientes();
        }
    }
    private void lsbVerSolicitudesImportadas_SelectedValueChanged(object sender, EventArgs e)
    {
        if (lsbVerSolicitudesImportadas.SelectedItem != null)
            lbSolicitudSeleccionada.Text = lsbVerSolicitudesImportadas.SelectedItem.ToString();
        else
            lbSolicitudSeleccionada.Text = "Seleccione un registro";
    }

    private void btnSeleccionar_Click(object sender, EventArgs e)
    {
        Solicitud solicitud = lsbVerSolicitudesImportadas.SelectedItem as Solicitud;

        //2
        if (solicitud != null)
        {
            centroAtencion.Atender(solicitud);

            //4
            VerSolicitudesAAtender();
            VerSolicitudesPendientes();

            lsbVerSolicitudesImportadas.SelectedItem = null;
            lbSolicitudSeleccionada.Text = "Seleccione un registro";
        }
        else
        {
            MessageBox.Show("Debe seleccionar una solicitud para atender.");
        }
    }
    private void btnResolverSolicitud_Click(object sender, EventArgs e)
    {
        //5
        centroAtencion.ResolverSolitudEnEspera();

        VerHistorialResoluciones();

        VerSolicitudesAAtender();
    }

    private void btnExportarResoluciones_Click(object sender, EventArgs e)
    {
        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
        {
            string path = saveFileDialog1.FileName;

            FileStream fs = null;
            try
            {
                fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);

                centroAtencion.ExportarCsvHistorialResoluciones(fs);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el archivo: " + ex.Message);
                return;
            }
            finally
            {
                fs.Close();
            }
        }

    }
    protected void VerSolicitudesPendientes()
    {
        lsbVerSolicitudesImportadas.Items.Clear();
        var nodoActual = centroAtencion.GetSolitudePendiente();
        while (nodoActual != null)
        {
            lsbVerSolicitudesImportadas.Items.Add(nodoActual.Value);

            nodoActual = nodoActual.Next;
        }
    }

    protected void VerSolicitudesAAtender()
    {
        //3
        lsbColaSolitudesAAtender.Items.Clear();
        lsbColaSolitudesAAtender.Items.AddRange(centroAtencion.VerDescripcionColaAtencion());
    }


    protected void VerHistorialResoluciones()
    {
        //3
        lsbHistorialResoluciones.Items.Clear();
        lsbHistorialResoluciones.Items.AddRange(centroAtencion.VerDescripcionPilaHistorica());
    }

    private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
    {
        FileStream fs = null;
        try
        {
            fs = new FileStream("data.bin", FileMode.OpenOrCreate, FileAccess.Write);

#pragma warning disable SYSLIB0011
            BinaryFormatter formatter = new BinaryFormatter();
#pragma warning restore SYSLIB0011
            formatter.Serialize(fs,centroAtencion);
        }
        finally
        {
            fs.Close();
        }
    }

    private void FormPrincipal_Load(object sender, EventArgs e)
    {
        FileStream fs = null;
        try
        {
            fs=new FileStream("data.bin", FileMode.OpenOrCreate, FileAccess.Read);

#pragma warning disable SYSLIB0011
            BinaryFormatter formatter = new BinaryFormatter();
#pragma warning restore SYSLIB0011
            centroAtencion = (CentroAtencion)formatter.Deserialize(fs);
        }
        catch (Exception)
        {
            
        }
        finally
        {
            fs.Close();
        }

        VerSolicitudesPendientes();
        VerSolicitudesAAtender();
        VerHistorialResoluciones();
    }
}
