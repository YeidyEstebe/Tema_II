
/* Tema II Programa 1: - Realizar la carga del lado de un cuadrado, mostrar por pantalla el perímetro del mismo
(El perímetro de un cuadrado se calcula multiplicando el valor del lado por cuatro)*/



//CalcularPerimetroCuadrado();
void CalcularPerimetroCuadrado()
{
    int cantidadlado = 4;
    decimal longitu_lado;
    decimal perimetro;
    string? Linea = string.Empty;


    try
    {
        Console.WriteLine("Indique la longitud del lado del cuadrado:");
        Linea = Console.ReadLine();
        longitu_lado = decimal.Parse(Linea);


        perimetro = (longitu_lado * cantidadlado);

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine($"El perimetro de este cuadro es: " + perimetro);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Gracias");
    }
    catch (Exception ex)
    {

        Console.WriteLine("ERROR" + ex.Message);
        Console.WriteLine();
        CalcularPerimetroCuadrado();

    }

}


/*Tema II Programa 2: Escribir un programa en el cual se ingresen cuatro números, calcular e informar 
la suma de los dos primeros y el producto del tercero y el cuarto.*/

//SUMAyPRODUCTO();

void SUMAyPRODUCTO()
{

    decimal numero1;
    decimal numero2;
    decimal numero3;
    decimal numero4;
    decimal suma;
    decimal producto;
    string? linea = string.Empty;

    try
    {

        Console.WriteLine("Indique el primer numero:");
        linea = Console.ReadLine();
        numero1 = decimal.Parse(linea);

        Console.WriteLine();
        Console.WriteLine("Indique el segundo numero:");
        linea = Console.ReadLine();
        numero2 = decimal.Parse(linea);

        Console.WriteLine();
        Console.WriteLine("Indique el tercer numero:");
        linea = Console.ReadLine();
        numero3 = decimal.Parse(linea);

        Console.WriteLine();
        Console.WriteLine("Indique el cuarto numero:");
        linea = Console.ReadLine();
        numero4 = decimal.Parse(linea);

        Console.WriteLine();
        suma = numero1 + numero2;
        Console.WriteLine($"La suma del primer numero y el segundo numero es igual a: " + suma);

        Console.WriteLine();
        producto = numero3 * numero4;
        Console.WriteLine($"El producto del tercero y el cuarto numero es: " + producto);

    }
    catch (Exception ex)
    {
        Console.WriteLine("ERROR" + ex.Message);
        Console.WriteLine();
        SUMAyPRODUCTO();
    }
}

/*Tema II - Progrma 3: Realizar un programa que lea cuatro valores numéricos e informar su suma y promedio.*/

//SUMAyPROMEDIO();

void SUMAyPROMEDIO()
{

    decimal valor1;
    decimal valor2;
    decimal valor3;
    decimal valor4;
    decimal suma;
    decimal promedio;
    string? linea = string.Empty;

    try
    {
        Console.WriteLine("Indique el primer valor:");
        linea = Console.ReadLine();
        valor1 = decimal.Parse(linea);

        Console.WriteLine();
        Console.WriteLine("Indique el segundo valor:");
        linea = Console.ReadLine();
        valor2 = decimal.Parse(linea);

        Console.WriteLine();
        Console.WriteLine("Indique el tercer valor:");
        linea = Console.ReadLine();
        valor3 = decimal.Parse(linea);

        Console.WriteLine();
        Console.WriteLine("Indique el cuarto valoro:");
        linea = Console.ReadLine();
        valor4 = decimal.Parse(linea);

        Console.WriteLine();
        suma = valor1 + valor2 + valor3 + valor4;
        Console.WriteLine($"La suma de los cuatros valores numericos ingresados es igual a: " + suma);


        Console.WriteLine();
        promedio = suma / 4;
        Console.WriteLine($"El promedio de los cuatros valores ingrezado es igual a: " + promedio);


    }
    catch (Exception ex)
    {
        Console.WriteLine("ERROR" + ex.Message);

    }




}
