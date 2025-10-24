
namespace Ejercicio1.Models;

[Serializable]
public class Solicitud: IExportable
{
    public int Numero { get; set; }
    public string Descripcion { get; set; }

    public void Importar(string datos)
    {
        //3234234;pedido de algo
        string[] campos=datos.Split(';');

        //if (Verificiar(campos[0]) == false)
        //    throw new Exception("El numero de solicitud no es valido");

        Numero = Convert.ToInt32(campos[0]);
        Descripcion=campos[1];
    }

    override public string ToString()
    {
        return $"{Numero}({Descripcion})";
    }
}
