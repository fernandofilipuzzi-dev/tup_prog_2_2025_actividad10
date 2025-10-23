
namespace Ejercicio1_.Models;

[Serializable]
public class Solicitud:IExportable
{
    public int Numero { get; set; }
    public string Motivo { get; set; }

    /// <summary>
    /// Metod que me permite importar datos desde un formato separado con punto y coma
    /// </summary>
    /// <param name="datos">linea a importar</param>
    public void Importar(string datos)
    {
        string[] campos = datos.Split(';');
        Numero = Convert.ToInt32(campos[0]);
        Motivo = campos[1];
    }

    override public string ToString()
    {
        return $"{Numero}({Motivo})";
    }
}
