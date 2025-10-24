

namespace Ejercicio1.Models;

[Serializable]
public class CentroDeAtencion
{
    LinkedList<Solicitud> solicitudesPendientes=
                                        new LinkedList<Solicitud>();
    Queue<Solicitud> colaDeAtencion = new Queue<Solicitud>();
   
    public void ImportarCsvSolicitudesEntradas(FileStream fs)
    { 
        StreamReader sr=new StreamReader(fs);

        sr.ReadLine(); //salteo la primer linea (cabecera)

        while ( !sr.EndOfStream )
        {
            string linea=sr.ReadLine();

            Solicitud solicitud=new Solicitud();    
            solicitud.Importar(linea);

            solicitudesPendientes.AddLast(solicitud);
        }

        fs.Close();
    }

    public LinkedListNode<Solicitud> GetSolicitudPendiente()
    {
        return solicitudesPendientes.First;
    }

    public void Atender(Solicitud seleccion)
    {
        if (solicitudesPendientes.Remove(seleccion))
        {
            colaDeAtencion.Enqueue(seleccion);
        }
    }

    public string[] VerDescripcionColaAtencion()
    {
        string[] descripciones = new string[colaDeAtencion.Count];

        int n = 0;
        foreach (Solicitud s in colaDeAtencion)
        {
            descripciones[n++] = s.ToString();
        }

        return descripciones;
    }
}
