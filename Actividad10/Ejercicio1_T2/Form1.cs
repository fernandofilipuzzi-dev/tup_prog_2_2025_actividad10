using Ejercicio1.Models;
using System.Runtime.Serialization.Formatters.Binary;

namespace Ejercicio1;

public partial class Form1 : Form
{
    CentroDeAtencion centro = new CentroDeAtencion();

    public Form1()
    {
        InitializeComponent();
    }

    private void btnImportarSolicitudes_Click(object sender, EventArgs e)
    {
        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        {
            string path = openFileDialog1.FileName;

            FileStream fs = null;
            try
            {
                fs = new FileStream(path, FileMode.Open, FileAccess.Read);

                centro.ImportarCsvSolicitudesEntradas(fs);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al importar las solicitudes: " + ex.Message);
            }
            finally
            {
                if (fs != null) fs.Close();
            }

            VerSolicitudesPendientes();
        }
    }

    protected void VerSolicitudesPendientes()
    {
        lsbVerSolicitudesImportadas.Items.Clear();

        LinkedListNode<Solicitud> nodo = centro.GetSolicitudPendiente();

        while (nodo != null)
        {
            lsbVerSolicitudesImportadas.Items.Add(nodo.Value);
            nodo = nodo.Next;
        }
    }

    private void lsbVerSolicitudesImportadas_SelectedValueChanged(object sender, EventArgs e)
    {
        Solicitud seleccion = lsbVerSolicitudesImportadas.SelectedItem as Solicitud;

        if (seleccion != null)
        {
            lbSolicitudSeleccionada.Text = seleccion.ToString();
        }
    }

    private void btnConfirmarAtencion_Click(object sender, EventArgs e)
    {
        Solicitud seleccion = lsbVerSolicitudesImportadas.SelectedItem as Solicitud;
        if (seleccion != null)
        {
            centro.Atender(seleccion);

            VerSolicitudesPendientes();
            VerSolicitudesAAtender();
        }
    }

    public void VerSolicitudesAAtender()
    {
        lsbColaSolicitudesAAtender.Items.Clear();
        lsbColaSolicitudesAAtender.Items.AddRange(centro.VerDescripcionColaAtencion());
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        #region deserializar centro de atencion
        FileStream fs = null;
        try
        {
            fs = new FileStream("datos.bin", FileMode.OpenOrCreate,
                                        FileAccess.Read);
#pragma warning disable SYSLIB0011
            BinaryFormatter bf = new BinaryFormatter();
            centro = bf.Deserialize(fs) as CentroDeAtencion;
#pragma warning restore SYSLIB0011

        }
        catch (Exception)
        {
        }
        finally
        {
            if (fs != null) fs.Close();
        }
        #endregion

        #region actualizar pantalla
        if (centro != null)
        {
            VerSolicitudesAAtender();
            VerSolicitudesPendientes();
        }
        else
        {
            centro = new CentroDeAtencion();
        }
        #endregion
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
        #region serializar centro de atencion
        FileStream fs = null;
        try
        {
            fs = new FileStream("datos.bin", FileMode.OpenOrCreate,
                                        FileAccess.Write);

#pragma warning disable SYSLIB0011
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, centro);
#pragma warning restore SYSLIB0011
        }
        catch (Exception)
        {
        }
        finally
        {
            if (fs != null) fs.Close();
        }
        #endregion
    }

    private void button1_Click(object sender, EventArgs e)
    {

    }
}
