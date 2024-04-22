using System;

namespace ISNP022923_UNIDAD1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean continuar = true;
            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("╔═════════════════════════════════════╗");
                Console.WriteLine("║        *** MENÚ PRINCIPAL***        ║");
                Console.WriteLine("╚═════════════════════════════════════╝");
                Console.WriteLine("1. DETERMINAR POSITIVO O NEGATIVO");
                Console.WriteLine("2. NUMEROS DEL 1 AL 10");
                Console.WriteLine("3. SUMAR NÚMEROS");
                Console.WriteLine("4. SUMATORIA DE 5 NÚMEROS");
                Console.WriteLine("5. PROMEDIO");
                Console.WriteLine("SALIR DEL PROGRAMA, DIGITE CUALQUIER NÚMERO");
                Console.Write("DIGITE LA OPCIÓN: ");
                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        EJERCICIO1();
                        break;
                    case 2:
                        Console.Clear();
                        EJERCICIO2();
                        break;
                    case 3:
                        Console.Clear();
                        EJERCICIO3();
                        break;
                    case 4:
                        Console.Clear();
                        EJERCICIO4();
                        break;
                    case 5:
                        Console.Clear();
                        EJERCICIO5();
                        break;
                    default:
                        continuar = false;
                        break;
                }



            }
        }
        static void EJERCICIO1()
        {
            while (true)
            {

                Console.WriteLine("Ingrese un Número (Digite 0 para salir):");
                Double numero = double.Parse(Console.ReadLine());

                if (numero > 0)
                {
                    Console.WriteLine("El número ingresado es positivo");
                }
                else if (numero < 0)
                {
                    Console.WriteLine("El número ingresado es negativo");
                }
                else
                {
                    Console.WriteLine("INGRESASTE ÉL NÚMERO 0. CERRANDO  EL PROGRAMA...");
                    break;
                }

            }


        }
        static void EJERCICIO2()
        {
            int n = 1;
            while (n <= 10)
            {
                Console.WriteLine(n);
                n += 1;
            }
            Console.ReadKey();
        }
        static void EJERCICIO3()
        {
            int suma = 0;
            int numero;

            do
            {
                Console.Write("Introduce un número positivo (0 o negativo para salir): ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero > 0)
                {
                    suma += numero;
                    Console.WriteLine("La suma de los números ingresados es: " + suma);
                }
                else if (numero < 0)
                {
                    Console.WriteLine("Ingresaste un número negativo. Saliendo del programa...");
                }
                else
                {
                    Console.WriteLine("Has introducido 0. Saliendo del programa...");
                }
            } while (numero > 0);

            Console.WriteLine("La suma de los números positivos ingresados es: " + suma);
        }
        static void EJERCICIO4()
        {
            int suma = 0;
            int contador = 0;

            do
            {
                Console.Write("Introduzca los números que desea sumar {0}:", contador + 1);
                int numero = Convert.ToInt32(Console.ReadLine());
                suma += numero;
                contador++;
            } while (contador < 5);
            Console.WriteLine("El resultado de la suma de los números ingresados es :" + suma);
            Console.ReadKey();
        }
        static void EJERCICIO5()

        {
            int suma = 0;
            int contador = 0;
            int numero;

            Console.WriteLine("Introduce una serie de números (Digite 0 para finalizar):");

            while (true)
            {
                Console.Write("Número {0}: ", contador + 1);
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero == 0)
                {
                    break;
                }
                suma += numero;
                contador++;

            }

            if (contador > 0)
            {
                double promedio = (double)suma / contador;
                Console.WriteLine("El promedio de los números ingresados es: " + promedio);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Debe untroducir una serie de números ");
            }
        }

    }

}
