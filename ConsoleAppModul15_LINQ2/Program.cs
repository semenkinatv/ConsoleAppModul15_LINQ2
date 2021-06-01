using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppModul15_LINQ2
{
    class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
            {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew" }, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };

            var allStudents = GetAllStudents(classes);

            Console.WriteLine("Список студентов всех классов:");
            Console.WriteLine(string.Join(" ", allStudents));

            Console.WriteLine("\r\nОтсортированный список:");
            Console.WriteLine(string.Join(" ", allStudents.OrderBy(st => st)));
        }

        public static string[] GetAllStudents(Classroom[] classes)
        {
           List<string> listStud = new List<string>();
          
            for (var i = 0; i < classes.Length; i++)
            {
                listStud = listStud.Concat(classes[i].Students).ToList();
            }

            return listStud.ToArray();
        }
    }
}