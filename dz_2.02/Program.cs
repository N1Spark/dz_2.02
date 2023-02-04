using System;

namespace dz_2._02
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Зад 1
            Console.Write("Введите размер масива: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] mass = new int[size];
            Random rand = new Random();
            for(int  i = 0; i < mass.Length; i++)
            {
                mass[i] = rand.Next(0, 20);
            }
            int unic = 0;
            bool check = true;
            string evenly = " ", odd = " ", unic_mass = " ";
            Console.Write("Результат: ");
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write($"{mass[i]} ");
            }
            Console.WriteLine();
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] % 2 == 0)
                    evenly += mass[i].ToString() + " ";
                else if (mass[i] % 2 != 0)
                    odd += mass[i].ToString() + " ";
                unic = mass[i];
                for (int j = 0; j < mass.Length; j++)
                {
                    if (i == j)
                        continue;
                    if (unic == mass[j])
                        check = false;
                }
                if (check)
                    unic_mass += unic.ToString() + " ";
                check = true;
            }
            Console.WriteLine("Evenly: {0}\nOdd: {1}\nUnic: {2}", evenly, odd, unic_mass);
            #endregion

            #region Зад 2
            Console.Write("\nВведите максимальное значение: ");
            int max = Convert.ToInt32(Console.ReadLine());
            string mass2 = " ";
            for (int i = 0; i < mass.Length; i++)
            {
                if (max > mass[i])
                    mass2 += mass[i].ToString() + " ";
            }
            Console.WriteLine($"Результат: {mass2}");
            #endregion

            #region Зад 3
            Console.Write("\nВведите последовательность чисел: ");
            string mass3 = Console.ReadLine();
            string mass3_a = "";
            int count = 0, index = 0;
            for (int i = 0; i < mass.Length; i++)
                mass3_a += mass[i].ToString() + " ";
            for (int i = 0; i < mass3_a.Length; i++)
            {
                if (mass3_a.IndexOf(mass3) > -1 + index)
                {
                    count++;
                    index = mass3_a.IndexOf(mass3) + 1;
                }
            }
            Console.WriteLine($"Кол-во повторов = {count}");
            #endregion
        }
    }
}
