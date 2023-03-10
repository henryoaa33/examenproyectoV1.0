using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenproyectoV1.Models
{
    public class Avioneta : Aereonave, Iporcioncombustible
    {

        public string capacidaddecombustible()
        {
            return "Capacidad de combustible 3,000 galones.";
        }
        public override string Despegar()
        {
            return "El avioneta está despegando.";
        }

        public override string Volar()
        {
            return "El avioneta está volando.";
        }

        public override string Aterrizar()
        {
            return "El avioneta está aterrizando.";
        }

        public int cantidadderotores { get; set; }
    }
}
