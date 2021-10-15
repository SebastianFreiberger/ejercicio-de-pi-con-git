using System;

namespace PracticaPildorasInformaticas
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numero = new Random();
            int aleatorio = numero.Next(0, 100);
            int minumero = 101;
            int intentos = 0;
            Console.WriteLine("Introduce un numero entre 0 y 100");
            do
            {
                intentos++;
                try
                {
                minumero = int.Parse(Console.ReadLine());
                }
                
                catch (Exception e) when (e.GetType() != typeof(FormatException))
                {
                    Console.WriteLine("Ha habido un error. Tomaremos como ingresado el 0");
                    minumero = 0;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Has introducido texto");
                    minumero = 0;
                }

                if (minumero > aleatorio) Console.WriteLine("El numero es mas bajo");
                if (minumero < aleatorio) Console.WriteLine("El numero es mas alto");
            }
            while (aleatorio != minumero);
            Console.WriteLine($"Correcto!! Has encontrado el numero en {intentos} intentos");
            Console.WriteLine("Primera pagina");
        }
    }
}
