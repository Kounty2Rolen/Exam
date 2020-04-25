//Описать тип City для хранения данных о городе (название, дата основания, количество жителей).
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Exam.Clases
{

    class City : Object
    {
        private string name;
        private DateTime date;
        private Int64 count;//Думаю что Int64 хватит

        public string Name { get => name; set => name = value; }
        public DateTime Date { get => date; set => date = value; }
        public Int64 Count { get => count; set => count = value; }

        public City(string name, DateTime date, Int64 count)
        {
            this.Name = name;
            this.Date = date;
            this.Count = count;
        }
        public City()
        {
            this.Name = "";
            this.Date = DateTime.MinValue;
            this.Count = 0;
        }
        public City[] Sort(City[] cities)
        {
            return cities = cities.AsQueryable<City>().OrderBy(c => c.Name).ThenBy(c => c.Date).ToArray();
        }

        public bool SaveAs(string path, City[] cities)
        {
            if (File.Exists(path.ToString()))
            {

                Console.WriteLine("Файл существует,перезаписать?(Y/N)");
                string answer = Console.ReadLine();
                if (answer == "y" || answer == "Y" || answer == "у" || answer == "У" || answer == "д" || answer == "Д")
                {
                    File.Delete(path);
                    TextWriter opnFile = new StreamWriter(path);
                    foreach (var cty in cities)
                    {
                        opnFile.WriteLine(cty.ToString());
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                TextWriter opnFile = new StreamWriter(path.ToString());
                foreach (var cty in cities)
                {
                    opnFile.WriteLine(cty.ToString());
                }
                return true;
            }

        }
        public override string ToString()
        {
            return "Название города:" + Name + "\nДата основания:" + Date.ToShortDateString() + "\nНаселение:" + Count + "\n";
        }

    }
}
