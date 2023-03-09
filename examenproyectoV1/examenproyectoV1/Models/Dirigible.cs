using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenproyectoV1.Models
{
    public class Dirigible : Aereonave, Icaracteristicas
    {
        public string capacidaddecombustible()
        {
            return "Capacidad de combustible 5,000 galones.";
        }
        public override string Despegar()
        {
            return "El dirigible está despegando.";
        }

        public override string Volar()
        {
            return "El dirigible está volando.";
        }

        public override string Aterrizar()
        {
            return "El dirigible está aterrizando.";
        }

        public int capacidadhelio { get; set; }

        public double consumo { get; set; }
    }
}
