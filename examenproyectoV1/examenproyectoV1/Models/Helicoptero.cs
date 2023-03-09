using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenproyectoV1.Models
{
    public class Helicoptero : Aereonave, Iporcioncombustible
    {

        public string capacidaddecombustible()
        {
            return "Capacidad de combustible 15,000 galones.";
        }
        public override string Despegar()
        {
            return "El helicoptero está despegando.";
        }

        public override string Volar()
        {
            return "El helicoptero está volando.";
        }

        public override string Aterrizar()
        {
            return "El helicoptero está aterrizando.";
        }

        public int cantidaddeaspas { get; set; }

        public double consumo { get; set; }

    }
}

