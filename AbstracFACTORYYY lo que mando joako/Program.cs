// See https://aka.ms/new-console-template for more information
using AbstracFACTORYYY_lo_que_mando_joako;

Console.WriteLine("Hello, World!");

Console.WriteLine("En esta fabrica vendemos estos discos: ");

var BluRay = new BluRayFactory();
var Dvd = new DVDFactory();

var discoSimple = BluRay.CrearDiscosimple();
var discoDoble = BluRay.CrearDiscodoble();
var discoSimple2 = Dvd.CrearDiscosimple();
var discoDoble2 = Dvd.CrearDiscodoble();

Console.WriteLine($"Disco simple BluRay: {discoSimple.Capacidad} - {discoSimple.Precio}");
Console.WriteLine($"Disco doble BluRay: {discoDoble.Capacidad} - {discoDoble.Precio}");
Console.WriteLine($"Disco simple DVD: {discoSimple2.Capacidad} - {discoSimple2.Precio}");
Console.WriteLine($"Disco doble DVD: {discoDoble2.Capacidad} - {discoDoble2.Precio}");