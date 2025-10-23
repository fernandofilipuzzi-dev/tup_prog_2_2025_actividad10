using Ejercicio1_.Models;

namespace Ejercicio1_;

public partial class Form1 : Form
{
    CentroDeAtencion centro = new CentroDeAtencion();
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void btnImportarSolicitudes_Click(object sender, EventArgs e)
    {
        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        {
            string path = openFileDialog1.FileName;

            FileStream fs = null;
            try
            {
                fs = new FileStream(path, FileMode.Open,
                                                 FileAccess.Read);

                centro.ImportarCsvSolicitudesEntrantes(fs);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (fs != null) fs.Close();
            }

            VerSolicitudesPendiente();
        }
    }

    protected void VerSolicitudesPendiente()
    {
        lsbVerSolicitudesImportadas.Items.Clear();

        LinkedListNode<Solicitud> nodo = centro.GetSolicitudPendiente();

        while (nodo != null)
        {
            lsbVerSolicitudesImportadas.Items.Add(nodo.Value);

            nodo =nodo.Next;
        }
       
    }
}
