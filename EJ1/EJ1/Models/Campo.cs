
namespace EJ1.Models;

public class Campo:IComparable
{
    public string Identificador { get; set; }
    public double Superficie { get; set; }

    public Campo (string identificador, double superficie)
    {
        Identificador = identificador;
        Superficie = superficie;
    }

    public int CompareTo(object otro)
    {
        Campo otroCampo = otro as Campo;
        if (otroCampo!=null)
        {
            return Identificador.CompareTo(otroCampo.Identificador);
        }
        return 1;
    }
}
