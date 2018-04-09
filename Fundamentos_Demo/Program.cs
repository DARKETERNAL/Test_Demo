using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos_Demo
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] valores = { 10, 8, 22, 14, 2, 5, 7};
            Program myProgram = new Program();

            //myProgram.Table(5, 10)
            myProgram.Cuadrados(90, 90, 0);
            //Debería dar alrededor de 9.71
            //Console.WriteLine(myProgram.GetAverage(valores));

            //myProgram.impString("hola......");

            //char[] adios = { 'a', 'd', 'i', 'o', 's' };
            //myProgram.CompareStringWithCharArr("adios", adios);
            //myProgram.Fibonacci();

            /*int n = 0;
            int size = 0;
            Console.WriteLine("Entre valor");
            int.TryParse(Console.ReadLine(), out n);
            Console.WriteLine("Entre tamaño");
            int.TryParse(Console.ReadLine(), out size);

            myProgram.MultiTable(n, size);*/

            //CalculadorDevueltas calculadorDevueltas = new CalculadorDevueltas();
            //calculadorDevueltas.CalcularDevuelta(8000000, 50);            

            Console.ReadLine();

        }

        float GetAverage(int[] values)
        {
            float sum = 0;            

            for (int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }

            return sum / values.Length;
        }

        void impString(string word)
        {
            Console.WriteLine("El tamaño de la cadena es: ");
            Console.WriteLine(word.Length);
            Console.WriteLine(word[2]);
          
        }

        void CompareStringWithCharArr(string word, char[] wordArr)
        {
            Console.WriteLine(string.Format("Las palabras son: {0}, {1}", word, wordArr));
            Console.WriteLine(string.Format("Los elementos en la posición 2 son: {0}, {1}", word[2], wordArr[2]));

            wordArr[3] = '5';

            for (int i = 0; i < wordArr.Length; i++)
            {
                Console.Write(wordArr[i]);
            }

            Console.WriteLine(
                string.Format("\nEl valor del arreglo es: {0}", wordArr));

        }

        void MultiTable(int n, int tableSize)
        {
            for (int i = 0; i <= tableSize; i++)
            {
                //Console.WriteLine(string.Format("{0} x {1} = {2}", n, i, n * i));
                Console.WriteLine(n + " x " + i + "= " + n*i);
            }
        }

        void Table(int Factor1, int Factor2)
        {
            int Factor3 =0;
            int Operacion = 0;

            while(Factor3 <= Factor2)
            {
                Multiplicacion();
                Factor3 += 1;
            }

            void Multiplicacion()
            {
                Operacion = Factor3 * Factor1;
                Console.WriteLine(string.Format("{0}x{1}={2}", Factor1, Factor3, Operacion));
            }
        }

        void Cuadrados(int Angulo1, int Angulo2, int Angulo3)
        {
            int Suma = Angulo2 + Angulo1 + Angulo3;




            if (Suma == 180)
            {
                if (Angulo1 == 90 || Angulo2 == 90 || Angulo3 == 90)
                {
                    Console.WriteLine("Triangulo Rectangulo");
                }

                if (Angulo1 == Angulo2 && Angulo2 == Angulo3)
                {
                    Console.WriteLine("Triangulo Equiangulo");
                }

                if (Angulo1 < 90 && Angulo2 < 90 && Angulo3 < 90)
                {
                    Console.WriteLine("Triangulo Agudo");
                }

                if (Angulo1 > 90 || Angulo2 > 90 || Angulo3 > 90)
                {
                    Console.WriteLine("Triangulo Obtuso");
                }

            }

            else
            {
                Console.WriteLine("no es un triangulo");
            }

        }

        void Fibonacci()
        {
            int suma = 0;
            int n = 0;
            int f1 = 1;
            int f0 = 0;

            Console.WriteLine("escriba el termino que desea hallar");            
            int.TryParse(Console.ReadLine(), out n);


            switch (n)
            {
                case 0:
                    suma = 0;
                    break;
                case 1:
                    suma = 1;
                    break;
                default:
                    for (int x = 2; x <= n;)
                    {
                        suma = f1 + f0;
                        f0 = f1;
                        f1 = suma;
                        Console.WriteLine("did something");
                    }                    
                    break;
            }            

            Console.WriteLine("resultado es");
            Console.WriteLine(suma);



        }


        int[,] Escalar(int[,] matA, int escalar)
        {
            int[,] resultado = new int[matA.GetLength(0), matA.GetLength(1)];

            int i = 0;           

            while (i < resultado.GetLength(0))
            {
                int j = 0;
                while (j < resultado.GetLength(1))
                {
                    resultado[i, j] = matA[i, j] * escalar;
                    j++;
                }

                i++;
            }

            //for (int i = 0; i < resultado.GetLength(0); i++)
            //{
            //    for (int j = 0; j < resultado.GetLength(1); j++)
            //    {
            //        resultado[i, j] = matA[i, j] * escalar;

            //    }
            //}

            return resultado;
        }

        public int[,] ProductoMatrices(int[,] A, int[,] B)
        {
            int[,] C = null;

            if (A.GetLength(1) == B.GetLength(0))
            {
                C = new int[A.GetLength(0), B.GetLength(1)];

                for (int i = 0; i < A.GetLength(0); i++)
                {
                    for (int j = 0; j < B.GetLength(1); j++)
                    {
                        for (int k = 0; k < B.GetLength(0); k++)
                        {
                            C[i, j] += A[i, k] * B[k, j];
                        }
                    }
                } 
            }

            return C;
        }
    }

    
}
