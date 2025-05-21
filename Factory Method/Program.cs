// See https://aka.ms/new-console-template for more information
using Factory_Method;

Console.WriteLine("Hello, World!");

var Mensaje = "";
Console.WriteLine("Hola, soy un auto a nafta\n");
Console.WriteLine("tengo que mandar un mensaje a mi nobio gay como se lo mando por sms o email");

Console.WriteLine("Pulsa algo");
Console.ReadLine();

Console.Clear();
Console.WriteLine("Primero que le mando??? ");
Console.WriteLine("Pulsa algo");
Console.ReadLine();

while (true)
{
    Console.WriteLine("1. podes venir a mi casa a chuparme la pija joaqui");
    Console.WriteLine("2. TENGO UNAS GANAS DE ROMPERTE EL ORTO");
    Console.WriteLine("3. Joaqui te la chuparia toda");
    string? opcion = Console.ReadLine();
    if (opcion == "1")
    {
        Mensaje = "podes venir a mi casa a chuparme la pija joaqui";
        break;
    }
    else if (opcion == "2")
    {
        Mensaje = "TENGO UNAS GANAS DE ROMPERTE EL ORTO";
        break;
    }
    else if (opcion == "3")
    {
        Mensaje = "Joaqui te la chuparia toda";
        break;
    }
    else
    {
        Console.Clear();
        Console.WriteLine("PELOTUDOOOOOO DECIDI ALGO NO CUALQUIER COSAS CHUPA PIJA");
        Console.ReadLine();
    }
}
Console.Clear();

Console.WriteLine("Ahora tenemos que decidir por donde se los mandamos");
Console.WriteLine("Pulsa algo");
Console.ReadLine();

while (true)
{
    Console.Clear();
    Console.WriteLine("1. Enviar por SMS");
    Console.WriteLine("2. Enviar por Email");
    string? opcion = Console.ReadLine();
    if (opcion == "1")
    {
        SmsCreador smsCreador = new SmsCreador();
        var msg = smsCreador.CrearMensaje();
        msg.EnviarMensaje(Mensaje);

        break;
    }
    else if (opcion == "2")
    {
        EmailCreador emailCreador = new EmailCreador();
        var msg = emailCreador.CrearMensaje();
        msg.EnviarMensaje(Mensaje);
        break;
    }
    else
    {
        Console.Clear();
        Console.WriteLine("PELOTUDOOOOOOOOO ME ABURRISTE");
        Console.ReadLine();
        break;
    }
}