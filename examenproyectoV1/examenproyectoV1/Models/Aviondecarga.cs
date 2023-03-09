using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenproyectoV1.Models
{
    public class Aviondecarga : Aereonave, Iporcioncombustible
    {

        public string capacidaddecombustible()
        {
            return "Capacidad de combustible 40,000 galones.";
        }
        public override string Despegar()
        {
            return "El aviondecarga está despegando.";
        }

        public override string Volar()
        {
            return "El aviondecarga está volando.";
        }

        public override string Aterrizar()
        {
            return "El aviondecarga está aterrizando.";
        }

        public int capacidadcarga { get; set; }

        public double consumo { get; set; }

    }
}
