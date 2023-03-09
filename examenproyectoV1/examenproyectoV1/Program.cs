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
            capacidadmisiles = 20




        };

        Console.WriteLine("Aereonave: Jet Militar");
        Console.WriteLine("La capacidad de misiles es de: " + jetmilitar.capacidadmisiles + ".");
        Console.WriteLine(jetmilitar.capacidaddecombustible());
        Console.WriteLine("Tanque de gasolina con:" + jetmilitar.combustible + " galones de gasolina.");
        Console.WriteLine(jetmilitar.Despegar());
        Console.WriteLine(jetmilitar.Volar());
        Console.WriteLine(jetmilitar.Aterrizar());

        Console.WriteLine("La distancia recorrida fue de " + jetmilitar.distanciarecorrida + " millas.");
        jetmilitar.consumo = jetmilitar.CalcularConsumo();

        Console.WriteLine("El consumo fue de " + jetmilitar.consumo + " galones de gasolina por milla.");

        Console.WriteLine("\n");

        Helicoptero helicoptero = new Helicoptero
        {

            distanciarecorrida = 250,
            combustible = 4000,
            cantidaddeaspas = 4




        };

        Console.WriteLine("Aereonave: Helicoptero");
        Console.WriteLine("La cantidad de aspas es de: " + helicoptero.cantidaddeaspas + ".");
        Console.WriteLine(helicoptero.capacidaddecombustible());
        Console.WriteLine("Tanque de gasolina con:" + helicoptero.combustible + " galones de gasolina.");
        Console.WriteLine(helicoptero.Despegar());
        Console.WriteLine(helicoptero.Volar());
        Console.WriteLine(helicoptero.Aterrizar());

        Console.WriteLine("La distancia recorrida fue de " + helicoptero.distanciarecorrida + " millas.");
        helicoptero.consumo = helicoptero.CalcularConsumo();

        Console.WriteLine("El consumo fue de " + helicoptero.consumo + " galones de gasolina por milla.");

        Console.WriteLine("\n");

        Dirigible dirigible = new Dirigible
        {

            distanciarecorrida = 40,
            combustible = 2490,
            capacidadhelio = 11000




        };

        Console.WriteLine("Aereonave: Dirigible");
        Console.WriteLine("La cantidad de helio es de: " + dirigible.capacidadhelio + " metros cubicos.");
        Console.WriteLine(dirigible.capacidaddecombustible());
        Console.WriteLine("Tanque de gasolina con:" + dirigible.combustible + " galones de gasolina.");
        Console.WriteLine(dirigible.Despegar());
        Console.WriteLine(dirigible.Volar());
        Console.WriteLine(dirigible.Aterrizar());

        Console.WriteLine("La distancia recorrida fue de " + dirigible.distanciarecorrida + " millas.");
        dirigible.consumo = dirigible.CalcularConsumo();

        Console.WriteLine("El consumo fue de " + dirigible.consumo + " galones de gasolina por milla.");

        Console.WriteLine("\n");

        Avioneta avioneta = new Avioneta
        {

            distanciarecorrida = 300,
            combustible = 3000,
            cantidadderotores = 2




        };

        Console.WriteLine("Aereonave: Avioneta");
        Console.WriteLine("La cantidad de rotores es de: " + avioneta.cantidadderotores + ".");
        Console.WriteLine(avioneta.capacidaddecombustible());
        Console.WriteLine("Tanque de gasolina con:" + avioneta.combustible + " galones de gasolina.");
        Console.WriteLine(avioneta.Despegar());
        Console.WriteLine(avioneta.Volar());
        Console.WriteLine(avioneta.Aterrizar());

        Console.WriteLine("La distancia recorrida fue de " + avioneta.distanciarecorrida + " millas.");
        avioneta.consumo = avioneta.CalcularConsumo();

        Console.WriteLine("El consumo fue de " + avioneta.consumo + " galones de gasolina por milla.");

        Console.WriteLine("\n");

        Avioncomercial avioncomercial = new Avioncomercial
        {

            distanciarecorrida = 12000,
            combustible = 30000,
            capacidadpasajeros = 356




        };

        Console.WriteLine("Aereonave: Avion Comercial");
        Console.WriteLine("La cantidad de pasajeros es de: " + avioncomercial.capacidadpasajeros + ".");
        Console.WriteLine(avioncomercial.capacidaddecombustible());
        Console.WriteLine("Tanque de gasolina con:" + avioncomercial.combustible + " galones de gasolina.");
        Console.WriteLine(avioncomercial.Despegar());
        Console.WriteLine(avioncomercial.Volar());
        Console.WriteLine(avioncomercial.Aterrizar());

        Console.WriteLine("La distancia recorrida fue de " + avioncomercial.distanciarecorrida + " millas.");
        avioncomercial.consumo = avioncomercial.CalcularConsumo();

        Console.WriteLine("El consumo fue de " + avioncomercial.consumo + " galones de gasolina por milla.");

        Console.WriteLine("\n");

        Aviondecarga aviondecarga = new Aviondecarga
        {

            distanciarecorrida = 10000,
            combustible = 40000,
            capacidadcarga = 250




        };

        Console.WriteLine("Aereonave: Avion de Carga");
        Console.WriteLine("La cantidad de carga es de: " + aviondecarga.capacidadcarga + " toneladas.");
        Console.WriteLine(aviondecarga.capacidaddecombustible());
        Console.WriteLine("Tanque de gasolina con:" + aviondecarga.combustible + " galones de gasolina.");
        Console.WriteLine(aviondecarga.Despegar());
        Console.WriteLine(aviondecarga.Volar());
        Console.WriteLine(aviondecarga.Aterrizar());

        Console.WriteLine("La distancia recorrida fue de " + aviondecarga.distanciarecorrida + " millas.");
        aviondecarga.consumo = aviondecarga.CalcularConsumo();

        Console.WriteLine("El consumo fue de " + aviondecarga.consumo + " galones de gasolina por milla.");





    }
}