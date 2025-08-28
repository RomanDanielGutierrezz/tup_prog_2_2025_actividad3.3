
using System.Collections;

namespace EJ1.Models;

public class Estancia
{
    public string nombre { get; set; }

    public Casco casco { get; set; }
    ArrayList puestos = new ArrayList();

    ArrayList campos = new ArrayList();
    public Estancia (string nombre, string idCampo, double sup)
    {
        this.nombre = nombre;
        this.casco = new Casco();
        this.casco.Administrador = "sin asignar";
        
        Puesto puesto = new Puesto();
        puestos.Add(puesto);
        puesto.Responsable = "sin asignar";
     

    }
    public Campo AgregarCampo(string Identificador, double Superficie)
    {
        Campo campo = new Campo(Identificador, Superficie);
        campos.Add(campo);
        return campo;
    }
    public Campo VerCampo(int idx)
    {
        if (campos!=null && idx >= 0 && idx < campos.Count)
        {
            return campos[idx] as Campo;
        }
        return null;
    }
    public int VerCantidadCampos()
    {
        if (campos != null)
        {
            return campos.Count;
        }
        return 0;
    }
}
