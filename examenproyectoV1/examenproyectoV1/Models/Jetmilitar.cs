using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenproyectoV1.Models
{
    public class Jetmilitar : Aereonave, Icaracteristicas
    {

        public string capacidaddecombustible()
        {
            return "Capacidad de combustible 9,000 galones.";
        }
        public override string Despegar()
        {
            return "El jetmilitar está despegando.";
        }

        public override string Volar()
        {
            return "El jetmilitar está volando.";
        }

        public override string Aterrizar()
        {
            return "El jetmilitar está aterrizando.";
        }

        public int capacidadmisiles { get; set; }
        public double consumo { get; set; }

    }
}
