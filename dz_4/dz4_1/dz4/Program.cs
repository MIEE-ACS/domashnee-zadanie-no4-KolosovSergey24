using System;

namespace dz_4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите размер массива: ");
            int N = 0;
            while (!int.TryParse(Console.ReadLine(), out N))
            {
                Console.WriteLine("Ошибка ввода. Введите целое, неотрицательное число: ");
            }
            double[] array = new double[N];
            Random rnd = new Random();
            Console.WriteLine("Массив: ");
            for (int i = 0; i < N; i++)
            {
                array[i] = Math.Round(rnd.Next(-100, 100) * 0.1, 3);//округляем до 3-го знака после запятой
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("Сумма элементов массива с нечетными номерами");
            double summa = 0;
            for (int i = 1; i < N; i += 2)
            {
                summa += array[i];
            }
            Console.WriteLine(summa);
            int otr1;
            int otr2;

            int k = 0;
            while (array[k] > 0)//ищем первый отрицательный
            {
                k++;
            }
            otr1 = k;
            k = N;
            while (array[k - 1] > 0)
            {
                k--;
            }
            otr2 = k;
            double summa2 = 0;
            for (int i = otr1; i < otr2; i++)
            {
                summa2 += array[i];
            }
            Console.WriteLine("Сумма элементов массива, расположенных между первым и последним отрицательным элементом");

            Console.WriteLine(summa2);
            double[] array2 = new double[N];
            int j = 0;
            for (int i = 0; i < N; i++)
            {
                if (Math.Abs(array[i]) <= 1)//модуль не превышает 1
                {
                    array2[j] = array[i];
                    j++;
                }
            }
            for (int i = j; i < N; i++)
            {
                array2[i] = 0;
            }
            Console.WriteLine("Сжатый массив: ");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(array2[i]);
            }
        }
    }
}