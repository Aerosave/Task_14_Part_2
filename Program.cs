using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_14_Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
            {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };
            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));
        }
        //Напишите метод, который соберет всех учеников всех классов в один список, используя LINQ.
        static string[] GetAllStudents(Classroom[] classes)
        {
             return classes.SelectMany(c => c.Students).ToArray();
        }

    
    }
}