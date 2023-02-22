//------Ejercicio 1---------
Console.WriteLine("-------Ejercicio 1-------");
Console.Write("Ingrese su nombre: ");
string e1Nombre = Console.ReadLine();
Console.Write("Ingrese su Email: ");
string e1Email = Console.ReadLine();
Console.Write("Ingrese su Cupon(s/n): ");
string e1Cupon = Console.ReadLine()?.ToLower().Trim();

int e1Precio = 390;
int e1Descuento = 10;

if (e1Cupon == "s" || e1Cupon == "si")
{
    Console.WriteLine("Si cuenta con cupon");
    int precioTotal = e1Precio - (e1Precio / e1Descuento);
    Console.WriteLine($"Precio con descuento: ${precioTotal}");
}
else
{
    Console.WriteLine("No cuenta con cupon");
    Console.WriteLine($"Precio sin descuento: ${e1Precio}");
}




//------Ejercicio 2---------

Console.WriteLine("-------Ejercicio 2-------");
Console.WriteLine("Elija una opcion");
Console.WriteLine("1|a) C#");
Console.WriteLine("2|b) Java");
Console.WriteLine("3|c) C++");
Console.WriteLine("4|d) Javascript");
Console.Write("Opcion: ");
string e2Opcion = Console.ReadLine()?.ToLower().Trim();

switch (e2Opcion)
{
    case "1" or "a":
        Console.WriteLine("Hola mundo, desde C#");
        break;
    case "2" or "b":
        Console.WriteLine("Hola mundo, desde Java");
        break;
    case "3" or "c":
        Console.WriteLine("Hola mundo, desde C++");
        break;
    case "4" or "d":
        Console.WriteLine("Hola mundo, desde Javascript");
        break;
    default:
        Console.WriteLine("No eligio ninguna opcion");
        break;
}





