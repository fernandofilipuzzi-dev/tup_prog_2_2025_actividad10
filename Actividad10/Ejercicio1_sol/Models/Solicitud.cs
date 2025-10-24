namespace Ejercicio1.Models;

[Serializable]
public class Solicitud: IExportable
{
    public int Numero { get; set; }
    public string Motivo { get; set; }

    public Solicitud()
    { }
    public Solicitud(int Numero, string motivo)
    {
        this.Numero = Numero;
        this.Motivo = motivo;
    }

    public string Exportar()
    {
        return $"{Numero};{Motivo}";
    }

    public void Importar(string datos)
    {
        string[] campos = datos.Split(';');
        Numero = Convert.ToInt32(campos[0]);
        Motivo = campos[1];
    }

    override public string ToString()
    {
        return $"{Numero}({Motivo.Substring(0, Math.Min(Motivo.Length, 20))})";
    }   
}
