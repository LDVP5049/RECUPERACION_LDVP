using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RECUPERACION_LDVP
{
    internal class Ejercicios
    {
        //EJERCICIO DE LA CURP
        public void Curp()
        {
            Console.WriteLine("Ingresa tu curp (18 Digitos)");
            char[] curp = new char[18];

            for (int i = 0; i < curp.Length; i++)
            {
                char letra = Console.ReadKey().KeyChar;
                curp[i] = letra;
            }
            char genero = curp[10];
            string fechaNac = new string(curp, 4, 6);
            int yyyy = int.Parse(fechaNac.Substring(0, 2));
            int mm = int.Parse(fechaNac.Substring(2, 2));
            int dd = int.Parse(fechaNac.Substring(4, 2));

            if (genero == 'H' || genero == 'h')
            {
                Console.WriteLine("\nEres hombre");
            }
            else if (genero == 'M' || genero == 'm')
            {
                Console.WriteLine("\nEres mujer");
            }
            else
            {
                Console.WriteLine("\nGenero no definido");
            }

            DateTime fechad = new DateTime(2000 + yyyy, mm, dd);
            Console.WriteLine("Fecha de nacimiento: " + fechad.ToShortDateString());
        }

        //EJERCICIO DE LA BUSQUEDA Y ESO
        public void Numeros()
        {
            Random random = new Random();
            int[] arreglo = new int[100];
            Console.WriteLine("Numeros del arreglo (Clase random)");
            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = random.Next(1, 100);
                Console.WriteLine(arreglo[i]);
            }
            int menor = 0;
            int pos = 0;
            int tem = 0;

            for (int i = 0; i < arreglo.Length - 1; i++)
            {
                menor = arreglo[i];
                pos = i;
                for (int j = i + 1; j < arreglo.Length; j++)
                {
                    if (arreglo[j] < menor)
                    {
                        menor = arreglo[j];
                        pos = j;
                    }
                }
                if (pos != i)
                {
                    tem = arreglo[i];
                    arreglo[i] = arreglo[pos];
                    arreglo[pos] = tem;
                }
            }
            Console.WriteLine("Numeros de manera descendente");
            for (int i = arreglo.Length -1; i >= 0; i--)
            {
                Console.WriteLine(arreglo[i]);
            }
            int n = arreglo.Length;
            Console.WriteLine("Numeros del arreglo ordenados");
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine(arreglo[i]);
            }
            int inf = 0;
            int centro = 0;
            int sup = n - 1;
            bool bandera = false;
            int numeroBuscado = 75;


            while (inf <= sup)
            {
                centro = (sup + inf) / 2;
                if (arreglo[centro] == numeroBuscado)
                {
                    bandera = true;
                    break;
                }
                else if (numeroBuscado < arreglo[centro])
                {
                    sup = centro - 1;
                }
                else
                {
                    inf = centro + 1;
                }
            }
            if (bandera == true)
            {
                Console.WriteLine($"El valor {numeroBuscado} esta en la posicion {centro + 1}");
            }
            else
            {
                Console.WriteLine("No se encontró el numero :))");
            }
        }
    

        public void Tabla()
        {
            //EJERCICIO DE LA TABLA
            Console.WriteLine("Valores de la tabla");
            int[,] tabla = new int[5, 4] {
            {500, 3000, 100, 400},
            {1000, 150, 200, 500},
            {250, 1800, 2900, 300},
            {400, 130, 90, 2400 },
            {60 , 20 , 4000, 3600 }
            };

            for (int filas = 0; filas < tabla.GetLength(0); filas++)
            {
                for (int columnas = 0; columnas < tabla.GetLength(1); columnas++)
                {  
                    Console.Write(tabla[filas, columnas]+ "\t"); //LA INFINIDAAAADE FORMAS QUE INTENTÉ PARA QUE LA TABLA QUEDARA JAJAJAJ
                }
                Console.WriteLine(" ");
            }



            Console.WriteLine("\nGANANCIAS DE VENDEDORES");
            //VENDEDOR 1
            int vendedor1 = tabla[0,0] + tabla[1,0] + tabla[2,0] + tabla[3,0] + tabla[4,0]; 
            Console.WriteLine("\nEl vendedor 1 ganó: " + vendedor1);
            //VENDEDOR 2
            int vendedor2 = tabla[0, 1] + tabla[1, 1] + tabla[2, 1] + tabla[3, 1] + tabla[4, 1];
            Console.WriteLine("El vendedor 1 ganó: " + vendedor2);
            //VENDEDOR 3
            int vendedor3 = tabla[0, 2] + tabla[1, 2] + tabla[2, 2] + tabla[3, 2] + tabla[4, 2];
            Console.WriteLine("El vendedor 1 ganó: " + vendedor3);
            //VENDEDOR 4 
            int vendedor4 = tabla[0, 3] + tabla[1, 3] + tabla[2, 3] + tabla[3, 3] + tabla[4, 3];
            Console.WriteLine("El vendedor 1 ganó: " + vendedor4);




            Console.WriteLine("\nGANANCIAS PRODUCTOS");
            //PRODUCTO 1
            int p1 = tabla[0, 0] + tabla[0, 1] + tabla[0, 2] + tabla[0,3];
            Console.WriteLine("\nGanancias de producto 1: " + p1 );
            //PRODUCTO 2
            int p2 = tabla[1, 0] + tabla[1, 1] + tabla[1, 2] + tabla[1, 3];
            Console.WriteLine("Ganancias de producto 2: " + p2);
            //PRODUCTO 3
            int p3 = tabla[2, 0] + tabla[2, 1] + tabla[2, 2] + tabla[2, 3];
            Console.WriteLine("Ganancias de producto 1: " + p3);
            //PRODUCTO 4
            int p4 = tabla[3, 0] + tabla[3, 1] + tabla[3, 2] + tabla[3, 3];
            Console.WriteLine("Ganancias de producto 1: " + p4);
            //PRODUCTO 5
            int p5 = tabla[4, 0] + tabla[4, 1] + tabla[4, 2] + tabla[4, 3];
            Console.WriteLine("Ganancias de producto 1: " + p5);

        }
    }
}
