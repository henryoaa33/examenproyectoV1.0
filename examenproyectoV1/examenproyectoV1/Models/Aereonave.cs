using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenproyectoV1.Models
{
    public class Aereonave
    {
        public double capacidadcombustible { get; set; }
        public double distanciarecorrida { get; set; }
        public double combustible { get; set; }
        public double consumo { get; set; }


        public double CalcularConsumo()
        {
            double consumo = combustible / distanciarecorrida;
            return consumo;

        }


         
        public virtual string Despegar()
        {
            return "La aeronave esta Despegando";
        }
        public virtual string Volar()
        {
            return "La aeronave esta volando";
        }

        public virtual string Aterrizar()
        {
            return "La aeronave esta Aterrizando";
        }

    }
}
