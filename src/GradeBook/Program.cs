using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Jai's Grade Book");
            var grades = new List<double>(){12.7, 10.3, 6.11, 4.1 };
            foreach(var number in grades){
                book.AddGrade(number);
            }
            book.ShowStats();

        }
    }
}
