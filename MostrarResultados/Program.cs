using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostrarResultados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region booleano
            bool prueba = false;
            Console.WriteLine("El boleano prueba tiene un resultado " + prueba);
            #endregion

            #region numero entero
            Console.WriteLine("Por favor, introduce un numero entero");
            string nEntero = Console.ReadLine();
            int numero = Convert.ToInt32(nEntero);
            #endregion

            #region numero decimal
            Console.WriteLine("Ahora introduce un numero decimal (no uses un punto, usa una coma)");
            string nDecimalStr = Console.ReadLine();
            decimal nDecimal = Convert.ToDecimal(nDecimalStr);
            #endregion

            #region division

            decimal division = numero / nDecimal;
            Console.WriteLine("El resultado de dividir " + numero + " entre " + nDecimal + " es: " + division);
            #endregion


            #region caracter
            string caracterStr;
            Console.WriteLine("Introduce un unico caracter");
            caracterStr = Console.ReadLine();
            char caracter = Convert.ToChar(caracterStr);
            #endregion

            #region texto
            Console.WriteLine("Escribe un texto");
            string texto;
            texto = Console.ReadLine();
            #endregion

            #region suma caracteres mas texto
            Console.WriteLine(caracter + "(" + texto + ")" + caracter);
            #endregion

            #region introducir y modificar fechas
            Console.WriteLine("Ingrese una fecha (dd/mm/yyyy):");
            string fecha = Console.ReadLine();

            if (DateTime.TryParse(fecha, out DateTime date))
            {
                DateTime ultimoDiaDelMes = new DateTime(date.Year, date.Month, DateTime.DaysInMonth(date.Year, date.Month));
                DateTime ultimoSegundoDelDia = new DateTime(ultimoDiaDelMes.Year, ultimoDiaDelMes.Month, ultimoDiaDelMes.Day, 23, 59, 59);

                Console.WriteLine($"El último segundo del último día del mes es: {ultimoSegundoDelDia.ToString("dd/MM/yyyy HH:mm:ss")}");
            }
            else
            {
                Console.WriteLine("Introduce la fecha con el formato indicado");
            }
            #endregion

            #region fin
            Console.WriteLine("Introduzca cualquier tecla para terminar");
            string fin;
            fin = Console.ReadLine();
            #endregion
        }
    }
}
