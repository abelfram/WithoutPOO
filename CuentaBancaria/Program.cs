using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal saldo = 0;
            string opcionStr;
            int opcion;
            Console.WriteLine("¡Bienvenido a tu Banco!");
            do
            {
                
                Console.WriteLine("¿Qué acción desea realizar?");
                Console.WriteLine("1. Introducir dinero");
                Console.WriteLine("2. Sacar dinero");
                Console.WriteLine("3. Lista de movimientos");
                Console.WriteLine("4. Lista de movimientos de entrada");
                Console.WriteLine("5. Lista de movimientos de salida");
                Console.WriteLine("6. Mostrar saldo actual");
                Console.WriteLine("7. Salir");


                
                List<string> ingresosBancariosList = new List<string>();
                List<string> ExtraccionBancariasList = new List<string>();

                opcionStr = Console.ReadLine();
                opcion = Convert.ToInt32(opcionStr);
                if (opcion == 1)
                {
                    int contadorIngreso = 0;
                    string dineroAIngresarStr;
                    Console.WriteLine("¿Cúanto dinero desea ingresar?");
                    dineroAIngresarStr = Console.ReadLine();
                    decimal dineroAIngresar = Convert.ToDecimal(dineroAIngresarStr);
                    saldo = +dineroAIngresar;
                    Console.WriteLine("Se han ingresado " + dineroAIngresar + " euros en su cuenta bancaría");
                    contadorIngreso++;
                    ingresosBancariosList.Add("ingreso " + contadorIngreso + ":" + dineroAIngresar + "€");

                }
                else if (opcion == 2)
                {
                    int contadorVecesRetirar = 0;
                    string dineroARetirarStr;
                    Console.WriteLine("¿Cúanto dinero desea reitrar?");
                    dineroARetirarStr = Console.ReadLine();
                    decimal dineroARetirar = Convert.ToDecimal(dineroARetirarStr);
                    saldo = -dineroARetirar;
                    Console.WriteLine("Se han retirado " + dineroARetirar + " euros de su cuenta bancaría");
                    contadorVecesRetirar++;
                    ExtraccionBancariasList.Add("Retirada " + contadorVecesRetirar + ":" + dineroARetirar + "€");
                }
                else if (opcion == 3)
                {
                    foreach (var ingreso in ingresosBancariosList)
                    {
                        Console.WriteLine("+ " + ingreso + " euros");
                    }
                    foreach (var Extraccion in ExtraccionBancariasList)
                    {
                        Console.WriteLine("- " + Extraccion + " euros");
                    }
                }
                else if (opcion == 4)
                {
                    //foreach (var ingreso in ingresosBancariosList)
                    //{
                    //    Console.WriteLine("+ " + ingreso + "€");
                    //}

                    for (int i = 0; i<ingresosBancariosList.Count; i++)
                    {
                        Console.WriteLine("hola");
                    }
                }
                else if (opcion == 5)
                {

                    foreach (var Extraccion in ExtraccionBancariasList)
                    {
                        Console.WriteLine(/*"- " + */Extraccion/* + "€"*/);
                    }
                }
                else if (opcion == 6)
                {
                    Console.WriteLine("Su saldo actual es de " + saldo + "€");
                }
                else if (opcion == 7)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Por favor, introduzca un valor entre 1 y 7");
                }

            } while (opcion != 7);
            Console.WriteLine("¡Gracias por trabajar con nosotros!");
        }
    }
}
