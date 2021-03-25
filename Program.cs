using System;

namespace Parcial_2_Ej._2
{
    class Empleado
{
        private string[] Empleados;
        private int[,] Sueldos;
        private int[] Tsueldo;

        public void Cargar() 
        {
            Empleados=new String[5];
            Sueldos=new int[5,1];

            for(int m = 0; m < Empleados.Length; m++)
            {
                Console.Write("Ingrese el nombre: ");
                Empleados[m]=Console.ReadLine();
                
                for(int a = 0; a < Sueldos.GetLength(1); a++) 
                {
                    Console.Write("Ingrese el sueldo: ");
                    string let;
                    let = Console.ReadLine();
                    Sueldos[m,a]=int.Parse(let);
                }
            }
        }

        public void CalculoS()
        {
            Tsueldo = new int[5];
            for (int m = 0; m < Sueldos.GetLength(0); m++)
            {
                int sum = 0;

                for (int a = 0; a < Sueldos.GetLength(1); a++)
                {
                    sum = sum + Sueldos[m,a];
                }
               Tsueldo[m] = sum;
            }
        }

        public void SEmpleados() 
        {
            Console.WriteLine("\nTotal de sueldos");
            for(int m = 0; m < Tsueldo.Length; m++) 
            {
                Console.WriteLine(Empleados[m]+": "+Tsueldo[m]);
            }
        }

        public void EmpleadoMayorSueldo() 
        {
            int my=Tsueldo[0];
            string nom=Empleados[0];
            for(int f = 0; f < Tsueldo.Length; f++) 
            {
                if (Tsueldo[f] > my) 
                {
                    my=Tsueldo[f];
                    nom=Empleados[f];
                }
            }
            Console.WriteLine("\nEl empleado con mayor sueldo es {0}, su sueldo es: {1}\n",nom ,my);
        }
          static void Main(string[] args)
        {
            Empleado empleado = new Empleado();
            empleado.Cargar();
            empleado.CalculoS();
            empleado.SEmpleados();
            empleado.EmpleadoMayorSueldo();
           
        }
}
}

