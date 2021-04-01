using System;
using System.Collections.Generic;

namespace GradeBook{
    public class Book{

        List<double> grades;
        string name;
        public Book(string name){
            grades = new List<double>();
            this.name = name;
        }

        public void ShowStats()
        {
            var result = 0.0; 
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            foreach(var number in grades){
                highGrade = Math.Max(number,highGrade);
                lowGrade = Math.Min(number,lowGrade);
                result += number;
            }
            result /= grades.Count;
            Console.WriteLine($"The average grade is {result:N2}");
            Console.WriteLine($"The high grade is {highGrade}");
            Console.WriteLine($"The low grade is {lowGrade}");
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }
    }
}