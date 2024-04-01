
string respuesta;

do
{
    Console.WriteLine("\nPor favor ingrese dos números: \n");

    Console.WriteLine("Primer número: ");
    int numA = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Segundo número: ");
    int numB = Convert.ToInt32(Console.ReadLine());

    int resultado;

    Console.WriteLine("\nSUMA");
    resultado = numA + numB;
    Console.WriteLine(numA + "+" + numB + "=" + resultado);

    Console.WriteLine("\nRESTA");
    resultado = numA - numB;
    Console.WriteLine(numA + "-" + numB + "=" + resultado);

    Console.WriteLine("\nMULTIPLICACION");
    resultado = numA * numB;
    Console.WriteLine(numA + "x" + numB + "=" + resultado);

    if (numB == 0)
    {
        Console.WriteLine("\nERROR: NO SE PUEDE DIVIDIR ENTRE 0");
    }
    else
    {
        Console.WriteLine("\nDIVISION");
        float resultadoD = (float)numA / numB;
        Console.WriteLine(numA + "/" + numB + "=" + resultadoD);
    }
    Console.WriteLine("\n¿Quiere continuar con otros dos números?");
    respuesta = Console.ReadLine();

} while (respuesta == "Si" || respuesta == "si" || respuesta == "SI"); 
    Console.WriteLine("MUCHAS GRACIAS POR USAR EL PROGRAMA!!");
