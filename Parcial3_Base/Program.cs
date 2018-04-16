using System;

namespace Parcial3_Base
{
    public struct Centro
    {
        public float X { get; private set; }
        public float Y { get; private set; }

        public Centro(float x, float y)
        {
            X = x;
            Y = y;
        }
    }

    public class Program
    {
        private static void Main(string[] args)
        {
            //Puede usar este main para probar sus métodos.
            Program myProgram = new Program();

            Console.WriteLine("Presione Enter para salir");
            Console.ReadLine();
        }

        #region EASY

        // VALOR DE LOS SIGUIENTES NUMERALES: 0.5 / 5.0

        /// <summary>
        /// Determina si dos matrices pueden sumarse
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns>'true' si las matrices pueden sumarse, 'false' de otro modo</returns>
        public bool SePuedenSumarMatrices(int[,] A, int[,] B)
        {
            bool suma2 = true;
            if ((A.GetLength(0) != B.GetLength(0)) || (A.GetLength(1) != B.GetLength(1)))
            {
                suma2 = false;
            }
            return suma2;
        }

        /// <summary>
        /// Retorna el promedio aritmético de los elementos en  arr
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public float PromedioDeArreglo(int[] arr)
        {
            float suma = 0;
            if (arr.Length < 1)
            {
                suma = 0;
            }
            if (arr.Length >= 1)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    suma += arr[i];
                }
                suma = suma / arr.Length;
            }
            return suma;
        }

        /// <summary>
        /// Determina cuántas veces aparece char en input
        /// </summary>
        /// <param name="input"></param>
        /// <param name="car"></param>
        /// <returns>La cantidad de veces que aparece char en input</returns>
        public int ConteoDeCaracter(string input, char car)
        {
            
            int N= 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == car)
                {
                    N++;
                }


            }
            return N;
        }

        #endregion EASY

        #region MEDIUM

        // VALOR DE LOS SIGUIENTES NUMERALES: 1.0 / 5.0

        /// <summary>
        /// Retorna otro arreglo cuyos elementos tengan los mismos que arr, pero con orden invertido.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns>Un arreglo cuyos elementos están en orden inverso a arr</returns>
        public int[] InvertirArreglo(int[] arr)
        {
            int[] arr2 = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
               
                    arr2[i] = arr[arr.Length - (1 + i)];
                
            }
            return arr2;
        }

        /// <summary>
        /// Determina si un string es palíndromo
        /// Un palíndromo es una palabra que se escribe igual al derecho y al revés
        /// </summary>
        /// <param name="input"></param>
        /// <returns>'true' si input es palíndromo, `false` de otro modo</returns>
        public bool EsPalindromo(string input)
        {
            bool pal = true;
            string arr = input;
            for (int i = 0; i < input.Length; i++)
            {
                if (arr[i] != input[input.Length - (1 + i)])
                {
                    pal = false;
                }
               

            }
            return pal;
        }

        /// <summary>
        /// Calcula el n-ésimo término de la serie de Fibonacci, basado en índice 0
        /// </summary>
        /// <param name="n"></param>
        /// <returns>El número correspondiente a la posición n en la serie de Fibonacci</returns>
        public int CalcularFibonacciEn(int n)
        {
            int C1 = 1;
            int C2 = 1;
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }
            if (n >= 2)
            {
                for (int i = 2; i <= n; i++)
                {
                    int temp = C1 + C2;
                    C2 = C1;
                    C1 = temp;
                }
            }
            return C2;
        }

        /// <summary>
        /// Retorna la matriz resultada de multiplicar A x B, si es posible hacer la operación.
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns>La matriz AxB</returns>
        public int[,] MultiplicarMatrices(int[,] A, int[,] B)
        {
            int[,] C = new int[A.GetLength(0),B.GetLength(1)];
            if (A.GetLength(1) != B.GetLength(0))
            {
                return null;
            }
            if (A.GetLength(1) == B.GetLength(0))
            {
                for (int i = 0; i < A.GetLength(0); i++)
                {
                    for (int j = 0; j < B.GetLength(1); j++)
                    {
                        for (int k = 0; k < A.GetLength(1); k++)
                        {
                            C[i, j] += A[i, k] * B[k, j];
                        }
                    }
                }
            }
            return C;
        }

        #endregion MEDIUM

        #region HARD

        //VALOR DE LOS SIGUIENTES NUMERALES: 1.5 / 5.0

        /// <summary>
        ///  Devuelve un string que indique cuántas horas, minutos y segundos hay dada la cantidad total de segundos
        ///  Recuerde: 1 hr = 3600 segs.
        /// </summary>
        /// <param name="totalSegs"></param>
        /// <returns>Un string indicando cuántas horas, minutos y segundos hay en totalSegs</returns>
        public string FormatearTiempo(int totalSegs)
        {
            int hrs = 0;
            int mins = 0;
            int segs = 0;

            if (totalSegs >= 3600)
            {
                hrs = totalSegs / 3600;
                int temp = totalSegs / 3600;
                totalSegs = totalSegs - (temp*3600);
            }
            if ((60 <= totalSegs) && (totalSegs < 3600))
            {
                mins = totalSegs / 60;
                int temp = totalSegs / 60;
                totalSegs = totalSegs - (temp * 60);
            }
            if (totalSegs < 60)
            {segs = totalSegs;}

            return string.Format("{0} hrs : {1} mins : {2} segs", hrs, mins, segs);
        }

        /// <summary>
        /// Determina si dos circunferencias se tocan en algún punto, dados sus radios y centros.
        /// Recuerde, la distancia entre dos puntos está dada por la fórmula
        /// d^2 = [(x2 - x1)^2] + [(y2 - y1)^2]
        /// </summary>
        /// <param name="c1">El centro de la primera circunferencia</param>
        /// <param name="r1">El radio de la primera circunferencia</param>
        /// <param name="c2">El centro de la segunda circunferencia</param>
        /// <param name="r2">El radio de la segunda circunferencia</param>
        /// <returns>'true' si hay algún punto en que las esferas se toquen, 'false' de otro modo</returns>
        public bool HayColisión(Centro c1, float r1, Centro c2, float r2)
        {
            
            return false;
        }

        /// <summary>
        /// Determina el próximo número que sea primo a mayor que n
        /// </summary>
        /// <param name="n"></param>
        /// <returns>El primer número primo mayor que n</returns>
        public int ProximoPrimo(int n)
        {
            bool primos = false;
            int i = 1 + n;
            if ((i == 2) || (i == 3) || (i == 5) || (i == 7) || (i == 11) || (i == 13))
            {
                primos = true;
                return i;
            }


            while (primos == false)
            {
                
                if (i != ((i/2)*2))
                {
                    if (i != ((i / 3) * 3))
                    {
                        if (i != ((i / 5) * 5))
                        {
                            if (i != ((i / 7) * 7))
                            {
                                if (i != ((i / 11) * 11))
                                {
                                    if (i != ((i / 13) * 13))
                                    {
                                        primos = true;
                                        
                                    }
                                    else { i++; }
                                }
                                else { i++; }
                            }
                            else { i++; }
                        }
                        else { i++; }
                    }
                    else { i++; }
                }
                else { i++; }
            }
            return i;
        }

        /// <summary>
        /// Combina los elementos de dos matrices A y B de dimensiones iguales,
        /// de manera que los elementos de la diagonal sean
        /// los elementos de la diagonal de A, y el resto los de B
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public int[,] CombinaMatrices(int[,] A, int[,] B)
        {
            int[,] nueva = new int[A.GetLength(0), A.GetLength(1)];
            if ((A.GetLength(0) != B.GetLength(0)) || (A.GetLength(1) != B.GetLength(1)))
            {
                nueva = null;
            }
            if ((A.GetLength(0) == B.GetLength(0)) && (A.GetLength(1) == B.GetLength(1)))
            {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        nueva[i, j] = A[i, j];
                    }
                    if (i != j)
                    {
                        nueva[i, j] = B[i, j];
                    }

                }
            }
            }
            return nueva;
        }

        #endregion HARD
    }
}