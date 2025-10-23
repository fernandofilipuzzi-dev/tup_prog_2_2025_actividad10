

namespace Ejercicio1_.Models;

[Serializable]
public class CentroDeAtencion
{
    LinkedList<Solicitud> solicitudesEntrantes=new LinkedList<Solicitud>();

    public void ImportarCsvSolicitudesEntrantes(FileStream fs)
    { 
        StreamReader sr= new StreamReader(fs);

        sr.ReadLine(); // Salteo la primer linea (cabecera)

        while (!sr.EndOfStream)
        {
            string linea = sr.ReadLine();
            Solicitud solicitud = new Solicitud();
            solicitud.Importar(linea);

            solicitudesEntrantes.AddLast(solicitud);
        }

        sr.Close();
    }

    public LinkedListNode<Solicitud> GetSolicitudPendiente()
    { 
        return solicitudesEntrantes.First;
    }
}
