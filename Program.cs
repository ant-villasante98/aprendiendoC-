// Ejercicio 1
Console.WriteLine("----------Ejercicio  1---------------");
Console.Write("Ingrese un numero: ");
int num = Convert.ToInt32(Console.ReadLine());
int cont = 1;

while (cont <= 10)
{
    Console.WriteLine($"{cont} x {num} = {num * cont}");
    cont++;
}
Console.WriteLine("----------Ejercicio  2---------------");
int e2Num = 0;
int e2ContPositivo = 0;
int e2ContNegativo = 0;
do
{
    Console.Write("Ingrese un numero('0' cero para salir): ");
    e2Num = Convert.ToInt32(Console.ReadLine());
    if (e2Num > 0) e2ContPositivo++;
    if (e2Num < 0) e2ContNegativo++;
    if (e2Num == 0)
    {
        Console.WriteLine($"Cantidad de numeros negativos: {e2ContNegativo}");
        Console.WriteLine($"Cantidad de numeros positivos: {e2ContPositivo}");
    }
} while (e2Num != 0);



Console.WriteLine("----------Ejercicio  3---------------");
Console.Write("Ancho: ");
int e3Ancho = Convert.ToInt32(Console.ReadLine());
Console.Write("Alto: ");
int e3Alto = Convert.ToInt32(Console.ReadLine());
Console.Write("Relleno('1' con, '0' sin): ");
int e3Relleno = Convert.ToInt32(Console.ReadLine());

for (int j = 0; j < e3Alto; j++)
{
    for (int i = 0; i < e3Ancho; i++)
    {
        if (i == 0 || j == 0 || i == (e3Ancho - 1) || j == (e3Alto - 1)) Console.Write("* ");
        else
        {
            string rell = "  ";
            if (e3Relleno == 1) rell = "* ";
            Console.Write(rell);
        }
    }
    Console.WriteLine();
}


