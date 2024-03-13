using System;
using System.Collections.Generic;
using System.Linq;

namespace ListStudents
{
    class Students
    {
        public string Name { get; set; }
        public string BirthDate { get; set; }
        public int AdmissionYear { get; set; }
        public int Course { get; set; }
        public string Group { get; set; }

        public List<int> Grades { get; set; }
        public double GetAvarageGrade()
        {
            return Grades.Average();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Students> students = new List<Students>
            {
            new Students{ Name = "Русаков Рудольф Данилович", BirthDate = "2004, 01, 10", AdmissionYear = 2020, Course = 1, Group = "ИСП-111", Grades = new List<int> {5,5,5,3,3} },
            new Students{ Name = "Бобылёв Демьян Михаилович", BirthDate = "2004, 04, 11", AdmissionYear = 2020, Course = 1, Group = "ИСП-111", Grades = new List<int> {4,4,4,3,2} },
            new Students{ Name = "Шашков Виктор Евгеньевич", BirthDate = "2004, 04, 05", AdmissionYear = 2020, Course = 1, Group = "ИСП-111", Grades = new List<int> {5,2,2,3,4,5} },
            new Students{ Name = "Соловьёв Эдуард Еремеевич", BirthDate = "2004, 01, 11", AdmissionYear = 2020, Course = 1, Group = "ИСП-111", Grades = new List<int> {5, 5, 5, 5, 5} },
            new Students{ Name = "Никифоров Клемент Сергеевич", BirthDate = "2004, 09, 12", AdmissionYear = 2020, Course = 1, Group = "ИСП-111", Grades = new List<int> {4, 4, 4, 3, 4} }
            };

            foreach (var student in students)
            {
                double averageGrade = student.GetAvarageGrade();
                Console.WriteLine($"{student.Name}, {student.BirthDate}, {student.AdmissionYear}, {student.Course}, {student.Group}, средний балл:  {averageGrade}");

            }

            List<Students> sortStudents = students.OrderByDescending(student => student.GetAvarageGrade()).ToList();

            Console.WriteLine("\nСписок студентов по среднему баллу: ");

            foreach (var student in sortStudents)
            {
                Console.WriteLine($"{student.Name} - средний балл: {student.GetAvarageGrade()}");
            }
            Console.ReadKey();

        }
    }
}
