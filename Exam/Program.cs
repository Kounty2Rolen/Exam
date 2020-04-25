using System;
using System.Collections.Generic;
using System.IO;
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
                int.TryParse(Console.ReadLine(), out CityCount);
                Console.Write("\n");
                City[] cities = new City[CityCount];
                for (int i = 0; i < CityCount; i++)
                {
                    Console.WriteLine("Введите имя города:");
                    var name = Console.ReadLine();
                    Console.WriteLine("Введите кол-во жителей:");
                    Int64 count;
                    Int64.TryParse(Console.ReadLine(), out count);
                    Console.WriteLine("Введите Дата основания города(YYYY.MM.DD):");
                    string date = Console.ReadLine();
                    DateTime result;
                    DateTime.TryParse(date, out result);
                    cities[i] = new City(name, result, count);
                }

                foreach (var city in cities)
                {
                    Console.WriteLine(city.ToString());
                }
                Console.WriteLine("Введите путь для сохранения файлов");
                var path = Console.ReadLine();
                path = Path.GetFullPath(path);
                City.SaveAs(path, cities);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\n" + ex.StackTrace);
            }

        }
    }
}
