using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam.Clases;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите кол-во городов для заполнения:");
                int CityCount;
                int.TryParse(Console.ReadLine(),out CityCount);
                Console.Write("\n");
                City[] cities = new City[CityCount];
                for (int i = 0; i >= CityCount; i++)
                {
                    Console.WriteLine("Введите имя города:");
                    cities[i].Name = Console.ReadLine();
                    Console.WriteLine("Введите кол-во жителей:");
                    Int64 count;
                    Int64.TryParse(Console.ReadLine(), out count);
                    cities[i].Count = count;
                    Console.WriteLine("Введите Дата основания города(YYYY.MM.DD):");
                    string date = Console.ReadLine();
                    DateTime result;
                    DateTime.TryParse(date, out result);
                    cities[i].Date = result;
                }

                foreach (var city in cities)
                {
                    Console.WriteLine(cities.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\n" + ex.StackTrace);
            }

        }
    }
}
