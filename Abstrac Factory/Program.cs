// See https://aka.ms/new-console-template for more information

using Abstrac_Factory;

Console.WriteLine();
Console.WriteLine("Hola, soy un auto a nafta\n");

Console.WriteLine("Necesito que me ayudes a elegir a mi nuevo amigo\n");

Console.WriteLine("Pulsa algo");
Console.ReadLine();

while (true)
{
    Console.Clear();
    Console.WriteLine("1. Auto a nafta");
    Console.WriteLine("2. Auto a diesel");
    Console.WriteLine("3. Camion a nafta");
    Console.WriteLine("4. Camion a diesel");
    string? opcion = Console.ReadLine();
    if (opcion == "1")
    {
        var Fabrica = new PetroleoFactory();
        var auto = Fabrica.CrearAuto();
        auto.Conducir();
        break;
    }
    else if (opcion == "2")
    {
        var Fabrica = new DieselFactory();
        var auto = Fabrica.CrearAuto();
        auto.Conducir();
        break;
    }
    else if (opcion == "3")
    {
        var Fabrica = new PetroleoFactory();
        var camion = Fabrica.CrearCamion();
        camion.Conducir();
        break;
    }
    else if (opcion == "4")
    {
        var Fabrica = new DieselFactory();
        var camion = Fabrica.CrearCamion();
        camion.Conducir();
        break;
    }
    else
    {
        Console.Clear();
        Console.WriteLine("PELOTUDOOOOOOOOOOOOOOOOOOO!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
        Console.ReadLine();
    }
}

Console.WriteLine("...................................................");