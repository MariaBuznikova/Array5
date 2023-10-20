//Даны две матрицы размерами 100000*100000. Структура хранения при
//элементов матриц – одномерный массив, первые 100 000 элементов это первая строка
//матрица, следующие 100000 элементов это вторая строка матрицы ит.д. Выполнить
//умножение матриц и результат записать в третью матрицу
using System;

namespace Массивы5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Random r = new Random();
            do
            {
                Console.WriteLine("Введите размерность матриц");
                 n = Convert.ToInt32(Console.ReadLine());
            } while (n <= 1);
            int[] m1 = new int[n * n];
            int[] m2 = new int[n * n];
            for (int i =0; i<n*n;i++)
            {
                m1[i] = r.Next(0, 100);
                m2[i] = r.Next(0, 100);
            }
            Console.WriteLine("Первая матрица:");
            for(int i=0;i<m1.Length; i++)
            {
                if ((i + 1) % n == 0)
                {
                    Console.WriteLine(m1[i]);
                }
                else Console.Write(m1[i] + "\t");
            }
            Console.WriteLine("Вторая матрица:");
            for (int i = 0; i < m2.Length; i++)
            {
                if ((i + 1) % n == 0)
                {
                    Console.WriteLine(m2[i]);
                }
                else Console.Write(m2[i] + "\t");
            }

            Console.WriteLine("Третья матрица(матрица произведения):");
            int[] m3 = new int[n * n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                        m3[i*n+j] += m1[i * n + k] * m2[k * n + j];
                }
            }
            for (int i = 0; i < m3.Length; i++)
            {
                if ((i + 1) % n == 0)
                {
                    Console.WriteLine(m3[i]);
                }
                else Console.Write(m3[i] + "\t");
            }

        }
    }
}
