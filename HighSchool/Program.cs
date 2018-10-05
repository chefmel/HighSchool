using System;
using System.Collections.Generic;
using System.Linq;

namespace HighSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> S = new List<Student>
            {
                new Student(){LastNameOfStudent = "Doddruesing", FirstNameOfStudent = "Melissa", Grade = 12, GPA = 3.9 },
                new Student() { LastNameOfStudent = "Meyer", FirstNameOfStudent = "Aimee", Grade = 9, GPA = 3.5 },
                new Student() { LastNameOfStudent = "Doddruesing", FirstNameOfStudent = "Grace", Grade = 11, GPA = 3.5 },
                new Student() { LastNameOfStudent = "Doddruesing", FirstNameOfStudent = "Lily", Grade = 12, GPA = 3.75 },
                new Student() { LastNameOfStudent = "Meyer", FirstNameOfStudent = "Caroline", Grade = 5, GPA = 2 },
                new Student() { LastNameOfStudent = "Meyer", FirstNameOfStudent = "Nisha", Grade = 6, GPA = 2.9 },
                new Student() { LastNameOfStudent = "Walser", FirstNameOfStudent = "David", Grade = 12, GPA = 3.2 },
                new Student() { LastNameOfStudent = "Ricker", FirstNameOfStudent = "Marilyn", Grade = 12, GPA = 3.0 },
                new Student() { LastNameOfStudent = "Beard", FirstNameOfStudent = "Julie", Grade = 10, GPA = 3.4 },
                new Student() { LastNameOfStudent = "Beard", FirstNameOfStudent = "Dan", Grade = 10, GPA = 2.9 },
            };

            var SmartestStudent = S.Where(p => p.Grade >= 9 && p.GPA >= 3.0);
            //Console.WriteLine(SmartestStudent);
            SmartestStudent = SmartestStudent.OrderByDescending(p => p.Grade).ThenByDescending(p => p.GPA).ThenBy(p => p.LastNameOfStudent).ThenBy(p => p.FirstNameOfStudent);
            


            foreach (var item in SmartestStudent)
            {
                Console.WriteLine("{0} {1} {2} {3}", item.Grade, item.GPA, item.LastNameOfStudent, item.FirstNameOfStudent
                    );
            }


            Console.ReadLine();
        }
    }
}
