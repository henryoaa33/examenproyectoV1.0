﻿using System;
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
        public double consumomillas { get; set; }
        public double consumodespegue { get; set; }
        public double consumovolar { get; set; }
        public double consumoaterrizar { get; set; }




        public double CalcularConsumo()
        {
            double consumomillas = combustible / distanciarecorrida;
            return consumomillas;

        }


        public virtual double ConsumoDespegue() => combustible * 0.10;
        public virtual string Despegar()
        {
            return "La aeronave esta Despegando";
        }

        public virtual double ConsumoVolar() => combustible * 0.80;
        public virtual string Volar()
        {
            return "La aeronave esta volando";
        }

        public virtual double ConsumoAterrizar() => combustible * 0.10;
        public virtual string Aterrizar()
        {
            return "La aeronave esta Aterrizando";
        }

    }
}
