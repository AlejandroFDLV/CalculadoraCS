using System;
namespace CalculadoraCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float number1, number2, oper;
            string fullName;
            Console.WriteLine("Bienvenido a la Calculadora");
            Console.WriteLine("Ingrese su Nombre");
            fullName = Console.ReadLine();
            Console.WriteLine("Operaciones: 1 - Sumar, 2 - Restar, 3 - Multiplicación, 4 - División. Presione cualquier otro número para salir.");
            oper = int.Parse(Console.ReadLine());

            while (oper >=0 && oper<6 && oper!=5)
            {
                Console.WriteLine("Ingrese el primer número: ");
                number1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo número: ");
                number2 = int.Parse(Console.ReadLine());
                float result=0; string operationName="";
                switch (oper)
                {

                    case 1:
                        result = number1 + number2;
                        operationName = "suma";
                        break;
                    case 2:
                        result = number1 - number2;
                        operationName = "resta";
                        break;
                    case 3:
                        result = number1 * number2;
                        operationName = "multiplicación";
                        break;
                    case 4:
                        result = number1 / number2;
                        operationName = "división";
                        break;
                    case 5:
                        result = 0;
                        operationName = "Salir";
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
                Console.Write(fullName + " el resultado de la "+ operationName);
                Console.WriteLine(" es: " + result);
                Console.ReadKey();
                Console.WriteLine("Operaciones: 1 - Sumar, 2 - Restar, 3 - Multiplicación, 4 - División. Presione cualquier otro número para salir.");
                oper = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Saliendo del programa.");
            Console.ReadKey();

        }
    }
}