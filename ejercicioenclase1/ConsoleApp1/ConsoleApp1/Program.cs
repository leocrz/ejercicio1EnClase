int num1, num2;
int seleccion = 0;
double respuesta;

// pide los numeros
Console.WriteLine("ingrese el primer numero: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ingrese el segundo numero: ");
num2 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("¿Qué es lo que desea hacer con esos 2 numeros?");
Console.WriteLine("1. suma");
Console.WriteLine("2. resta");
Console.WriteLine("3. multiplicacion");
Console.WriteLine("4. division");
seleccion = Convert.ToInt32(Console.ReadLine());
switch (seleccion)
{
    case 1:
        respuesta = num1 + num2;
        Console.WriteLine($"La suma de los 2 numeros es: {respuesta}");
        break;
    case 2:
        respuesta = num1 - num2;
        Console.WriteLine($"La resta de los 2 numeros es: {respuesta}");
        break;
    case 3:
        respuesta = num1 * num2;
        Console.WriteLine($"La multiplicacion de los 2 numeros es: {respuesta}");
        break;
    case 4:
        respuesta = num1 / num2;
        Console.WriteLine($"La division de los 2 numeros es: {respuesta}");
        break;
}