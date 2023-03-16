// See https://aka.ms/new-console-template for more information

bool resp = false;
double n = 0;
int A = 0;
int B = 1;
int C = 0;
int i = 2;
int resultado = 0;




while (!resp)
{

    Console.WriteLine("Sucesion de Fibonacci");

    try
    {


        Console.WriteLine("Ingrese un numero mayor que 0");
        n = Convert.ToDouble(Console.ReadLine());

        resp = true;

    }


    catch (Exception)
    {
        Console.WriteLine("Recuerde ingresar un numero");
        resp = false;
        Console.ReadKey();
        Console.Clear();

    }



}


if (n == 1)
{

    Console.WriteLine("1");

}
else if (n > 1)
{


    while (C < n)
    {
        C = A + B;

        if (C < n)
        {
            Console.Write(C + ", ");
        }

        A = B;
        B = C;

    }


}


Console.WriteLine("Fin del programa");