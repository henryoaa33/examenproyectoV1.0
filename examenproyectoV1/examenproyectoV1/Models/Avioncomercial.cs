using examenproyectoV1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenproyectoV1
{
    public class Avioncomercial : Aereonave, Iporcioncombustible

    {
        public string capacidaddecombustible()
        {
            return "Capacidad de combustible 36,000 galones.";
        }
        public override string Despegar()
        {
            return "El avion comercial está despegando.";
        }

        public override string Volar()
        {
            return "El avion comercial está volando.";
        }

        public override string Aterrizar()
        {
            return "El avion comercial está aterrizando.";
        }

        public int capacidadpasajeros { get; set; }

        public double consumo { get; set; }

    }
}