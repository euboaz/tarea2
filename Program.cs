using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea2
{
    internal class Program
    {

        public static void aguinaldos(string nombreEmplado, double salario)
        {
            for (int i = 0; i < 0; i++)
            {
                double aguinaldo = salario * 12;
                Console.WriteLine("El empleado: " + nombreEmplado + " tiene un salario de: " + salario + " Y su aguinalo total es de: " + aguinaldo);
            }
        }


        static void Main(string[] args)
        {
            //Mensaje de Bienvenida
            Console.WriteLine("*** Bienvenido al sistema de Registro de Empleados y Calculo Aguinaldo ***");

            //Menu de Opciones
            Console.WriteLine("Ingrese la opcion a realizar: \n 1) Agregar Empleados\n 2) Consultar Aguinaldos\n 3) Salir");
            int option = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de empleados a agregar: ");
            int cantEmpleados = Convert.ToInt32(Console.ReadLine());
            double[] salario = new double[cantEmpleados];
            string[] nombresEmpleados = new string[cantEmpleados];
            double[] aguinaldos = new double[cantEmpleados];

            for (int a = 0; a != 1;)
            {

                switch (option)
                {


                    case 1:


                        for (int i = 0; i < cantEmpleados; i++)
                        {

                            Console.WriteLine("Ingrese el nombre del empleado: ");
                            nombresEmpleados[i] = Console.ReadLine();
                            Console.WriteLine("Ingrese el salario del empleado: ");
                            salario[i] = Convert.ToDouble(Console.ReadLine());
                            aguinaldos[i] = salario[i] * 12;
                        }
                        Console.WriteLine("Empleados agregados Exitosamente");
                        option = 0;
                        break;

                    case 2:

                        for (int i = 0; i < cantEmpleados; i++)
                        {
                            Console.WriteLine("Nombre Empleado: " + nombresEmpleados[i] + " Salario del empleado: " + salario[i] + " El aguinaldo total del empleado es: " + aguinaldos[i]);
                        }
                        option = 0;
                        break;

                    case 3:
                        a = 1;
                        break;


                    default:
                        Console.WriteLine("Por favor, ingrese una opcion valida: \n 1) Agregar Empleados\n 2) Mostrar Datos \n 3) Salir");
                        option = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }

            Console.WriteLine("*** Gracias por Utilizar nuestro sistema ***");

        }
    }
}