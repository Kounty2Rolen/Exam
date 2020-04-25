//Описать тип City для хранения данных о городе (название, дата основания, количество жителей).
using System;
using System.Collections;
using System.Collections.Generic;

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
        public override string ToString()
        {
            return "Название города:" + Name + "\nДата основания:" + Date.ToShortDateString() + "\nНаселение:" + Count + "\n";
        }

    }
}
