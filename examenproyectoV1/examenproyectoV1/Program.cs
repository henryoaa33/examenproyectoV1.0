using examenproyectoV1;
using examenproyectoV1.Models;

class program
{
    static void Main(string[] args)
    {
        Jetmilitar jetmilitar = new Jetmilitar
        {

            distanciarecorrida = 100,
            combustible = 2000,
            capacidadmisiles = 20,
            consumodespegue = 2000,
            consumovolar = 2000,
            consumoaterrizar = 2000




        };

        Console.WriteLine("Aereonave: Jet Militar");
        Console.WriteLine("La capacidad de misiles es de: " + jetmilitar.capacidadmisiles + ".");
        Console.WriteLine("La capacidad de gasolina es de " + jetmilitar.capacidaddecombustible() + " galones.");
        Console.WriteLine("Tanque de gasolina con:" + jetmilitar.combustible + " galones de gasolina.");
        Console.WriteLine(jetmilitar.Despegar());
        Console.WriteLine(jetmilitar.Volar());
        Console.WriteLine(jetmilitar.Aterrizar());

        Console.WriteLine("La distancia recorrida fue de " + jetmilitar.distanciarecorrida + " millas.");
        jetmilitar.consumomillas = jetmilitar.CalcularConsumo();

        Console.WriteLine("El consumo fue de " + jetmilitar.consumomillas + " galones de gasolina por milla.");

        Console.WriteLine("\n");

        Helicoptero helicoptero = new Helicoptero
        {

            distanciarecorrida = 250,
            combustible = 4000,
            cantidaddeaspas = 4,
            consumodespegue = 4000,
            consumovolar = 4000,
            consumoaterrizar = 4000



        };

        Console.WriteLine("Aereonave: Helicoptero");
        Console.WriteLine("La cantidad de aspas es de: " + helicoptero.cantidaddeaspas + ".");
        Console.WriteLine("La capacidad de gasolina es de " + helicoptero.capacidaddecombustible() + " galones.");
        Console.WriteLine("Tanque de gasolina con:" + helicoptero.combustible + " galones de gasolina.");
        Console.WriteLine(helicoptero.Despegar());
        Console.WriteLine(helicoptero.Volar());
        Console.WriteLine(helicoptero.Aterrizar());

        Console.WriteLine("La distancia recorrida fue de " + helicoptero.distanciarecorrida + " millas.");
        helicoptero.consumomillas = helicoptero.CalcularConsumo();

        Console.WriteLine("El consumo fue de " + helicoptero.consumomillas + " galones de gasolina por milla.");

        Console.WriteLine("\n");

        Dirigible dirigible = new Dirigible
        {

            distanciarecorrida = 40,
            combustible = 2490,
            capacidadhelio = 11000,
            consumodespegue = 2490,
            consumovolar = 2490,
            consumoaterrizar = 2490



        };

        Console.WriteLine("Aereonave: Dirigible");
        Console.WriteLine("La cantidad de helio es de: " + dirigible.capacidadhelio + " metros cubicos.");
        Console.WriteLine("La capacidad de gasolina es de " + dirigible.capacidaddecombustible() + " galones.");
        Console.WriteLine("Tanque de gasolina con:" + dirigible.combustible + " galones de gasolina.");
        Console.WriteLine(dirigible.Despegar());
        Console.WriteLine(dirigible.Volar());
        Console.WriteLine(dirigible.Aterrizar());

        Console.WriteLine("La distancia recorrida fue de " + dirigible.distanciarecorrida + " millas.");
        dirigible.consumomillas = dirigible.CalcularConsumo();

        Console.WriteLine("El consumo fue de " + dirigible.consumomillas + " galones de gasolina por milla.");

        Console.WriteLine("\n");

        Avioneta avioneta = new Avioneta
        {

            distanciarecorrida = 300,
            combustible = 3000,
            cantidadderotores = 2,
            consumodespegue = 3000,
            consumovolar = 3000,
            consumoaterrizar = 3000



        };

        Console.WriteLine("Aereonave: Avioneta");
        Console.WriteLine("La cantidad de rotores es de: " + avioneta.cantidadderotores + ".");
        Console.WriteLine("La capacidad de gasolina es de " + avioneta.capacidaddecombustible() + " galones.");
        Console.WriteLine("Tanque de gasolina con:" + avioneta.combustible + " galones de gasolina.");
        Console.WriteLine(avioneta.Despegar());
        Console.WriteLine(avioneta.Volar());
        Console.WriteLine(avioneta.Aterrizar());

        Console.WriteLine("La distancia recorrida fue de " + avioneta.distanciarecorrida + " millas.");
        avioneta.consumomillas = avioneta.CalcularConsumo();

        Console.WriteLine("El consumo fue de " + avioneta.consumomillas + " galones de gasolina por milla.");

        Console.WriteLine("\n");

        Avioncomercial avioncomercial = new Avioncomercial
        {

            distanciarecorrida = 12000,
            combustible = 30000,
            capacidadpasajeros = 356,
            consumodespegue = 30000,
            consumovolar = 30000,
            consumoaterrizar = 30000



        };

        Console.WriteLine("Aereonave: Avion Comercial");
        Console.WriteLine("La cantidad de pasajeros es de: " + avioncomercial.capacidadpasajeros + ".");
        Console.WriteLine("La capacidad de gasolina es de " + avioncomercial.capacidaddecombustible() + " galones.");
        Console.WriteLine("Tanque de gasolina con:" + avioncomercial.combustible + " galones de gasolina.");
        Console.WriteLine(avioncomercial.Despegar());
        Console.WriteLine(avioncomercial.Volar());
        Console.WriteLine(avioncomercial.Aterrizar());

        Console.WriteLine("La distancia recorrida fue de " + avioncomercial.distanciarecorrida + " millas.");
        avioncomercial.consumomillas = avioncomercial.CalcularConsumo();

        Console.WriteLine("El consumo fue de " + avioncomercial.consumomillas + " galones de gasolina por milla.");

        Console.WriteLine("\n");

        Aviondecarga aviondecarga = new Aviondecarga
        {

            distanciarecorrida = 10000,
            combustible = 40000,
            capacidadcarga = 250,
            consumodespegue = 40000,
            consumovolar = 40000,
            consumoaterrizar = 40000




        };

        Console.WriteLine("Aereonave: Avion de Carga");
        Console.WriteLine("La cantidad de carga es de: " + aviondecarga.capacidadcarga + " toneladas.");
        Console.WriteLine("La capacidad de gasolina es de " + aviondecarga.capacidaddecombustible() + " galones.");
        Console.WriteLine("Tanque de gasolina con:" + aviondecarga.combustible + " galones de gasolina.");
        Console.WriteLine(aviondecarga.Despegar());
        Console.WriteLine(aviondecarga.Volar());
        Console.WriteLine(aviondecarga.Aterrizar());

        Console.WriteLine("La distancia recorrida fue de " + aviondecarga.distanciarecorrida + " millas.");
        aviondecarga.consumomillas = aviondecarga.CalcularConsumo();

        Console.WriteLine("El consumo fue de " + aviondecarga.consumomillas + " galones de gasolina por milla.");





    }
}