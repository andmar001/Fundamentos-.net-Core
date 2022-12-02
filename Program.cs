using Humanizer;

Console.WriteLine("Ingrese un nombre!");
var nombre = Console.ReadLine();
Console.WriteLine("Ingrese un cargo!");
var cargo = Console.ReadLine();
Console.WriteLine("Ingrese un edad!");
var edad = int.Parse(Console.ReadLine());

Console.WriteLine($"Mi Nombre: {nombre}, Mi Cargo: {cargo}, Mi Edad: {edad.ToWords()}");

Console.WriteLine($"Mi Nombre: {nombre}, Mi Cargo: {cargo}, Mi Edad: {edad.ToWords(new System.Globalization.CultureInfo("es"))}");  // Spanish

DateTime fecha = DateTime.Now;
Console.WriteLine($"Fecha: {fecha.ToOrdinalWords()}");