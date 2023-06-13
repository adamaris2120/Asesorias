using System;
namespace AsesoriasAris.Funciones
{
	public class Opciones
	{
        public  void Menu()
        {

            Operaciones opera = new Operaciones();



            int num1, num2, result = 0;

            Console.WriteLine("ingresa una opcion");
            Console.WriteLine("1)suma");
            Console.WriteLine("2)resta");
            Console.WriteLine("3)multiplicar");
            Console.WriteLine("4)dividir");

            int opcion = int.Parse(Console.ReadLine());

            Console.WriteLine("ingressa un numero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingresa otro numero");
            num2 = int.Parse(Console.ReadLine());

            switch (opcion)
            {

                case 1:
                    result = opera.suma(num1, num2);

                    Console.WriteLine("la suma es :" + result);
                    break;

                case 2:
                    result = opera.resta(num1, num2);

                    Console.WriteLine("la resta es :" + result);
                    break;

                case 3:
                    result = opera.Multiplicacion(num1, num2);

                    Console.WriteLine("la multiplicacion es :" + result);
                    break;
                case 4:
                    result = opera.Dividir(num1, num2);

                    Console.WriteLine("la divicion es :" + result);
                    break;
                default:
                    Console.WriteLine("no tengo mas opciones");
                    break;
            }
        }
    }
}

