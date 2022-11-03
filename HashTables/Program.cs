using System;
using System.Collections;
using System.Collections.Generic;

namespace HashTables
{
    class Program
    {
        // Key - Value
        // Auto - Car
        static void Main(string[] args)
        {
            Hashtable studentsTable = new Hashtable();
            studentsTable.Clear();
            Student stud1 = new Student(1, "Maria", 98);
            Student stud2 = new Student(2, "Jason", 76);
            Student stud3 = new Student(3, "Clara", 43);
            Student stud4 = new Student(4, "Steve", 55);
            Student stud5 = new Student(3, "Marian", 25);
            Student stud6 = new Student(5, "Melody", 75);
            Student stud7 = new Student(7, "John", 89);
            Student stud8 = new Student(9, "Mark", 32);

            List<Student> studentsList = new List<Student> { stud1, stud2, stud3, stud4
            ,stud5, stud6, stud7, stud8 };
            foreach (Student stud in studentsList)
            {
                try
                {
                    studentsTable.Add(stud.ID, stud);
                    Console.WriteLine("Student {0} was added to the table", stud.Name);
                }
                catch (Exception)
                {
                    Console.WriteLine("Sorry. A student with the same ID already Exists");
                }
            }


            foreach (Student value in studentsTable.Values)
            {
                Console.WriteLine("Student ID:{0}", value.ID);
                Console.WriteLine("Student Name:{0}", value.Name);
                Console.WriteLine("Student GPA:{0}", value.GPA);
            }
        }
    }
}
