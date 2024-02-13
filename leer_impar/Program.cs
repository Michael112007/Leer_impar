// See https://aka.ms/new-console-template for more information
Console.WriteLine("hello, ingrese el numero");
{
    int numero1, numero2;

    Console.WriteLine("introduzca el numero 1");
    numero1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("introduzca el numero 2");
    numero2 = Convert.ToInt32(Console.ReadLine());


    if (numero1 % 2 == 0)
    {
        Console.WriteLine("el numero es par");
    }
    else
    {
        Console.WriteLine("el numero es impar");
    }




    if (numero2 % 2 == 0)
    {
        Console.WriteLine("el numero es par");
    }
    else
    {
        Console.WriteLine("el numero es impar");
    }
}