using System;
using System.Collections.Generic;

namespace _04SoftwareUniversityLearningSystem
{
    public class Person
    {
        public string firstName { set; get; }
        public string lastName { set; get; }
        public int age {set; get;}

        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }       
    }

    class SULSTest
    {
        public static List<Person> list = new List<Person>();
        public static List<CurrentStudent> currentStudents = new List<CurrentStudent>();

        static void Main(string[] args)
        {           
            DefaultValues();
            PrintResults();
        }

        public static void DefaultValues()
        {
            var student1 = new OnlineStudent("John","Smith",25,3484939,5.80,"OOP");
            list.Add(student1);
            var student2 = new OnsiteStudent("Maria","Lovett",20,9392929,4.80,"Java",5);
            list.Add(student2);
            var student3 = new DropoutStudent("Dick","Haley",17,4839493,4.50,"Not enough time to attend classes");
            list.Add(student3);
            var student4 = new GraduateStudent("Jane","Doe",35,12389524,5.50);
            list.Add(student4);
            var student5 = new OnlineStudent("Beatrice", "Richardson", 26, 57888345, 3.80, "C#");
            list.Add(student5);
            var student6 = new OnsiteStudent("Paul", "Rider", 18, 76576521, 4.90, "Java", 8);
            list.Add(student6);
            var trainer1 = new SeniorTrainer("George","March",28);
            list.Add(trainer1);
            var trainer2 = new JuniorTrainer("Harry","Potter",22);
            list.Add(trainer2);
        }

        public static void PrintResults()
        {
            foreach (var item in list)
            {
                if (item is CurrentStudent)
                {
                    currentStudents.Add((CurrentStudent)item);
                }
            }
            //sortedStudents = currentStudents.OrderByDescending(s => s.averageGrade).ToList();
            currentStudents.Sort((x, y) => x.averageGrade.CompareTo(y.averageGrade));

            foreach (var curr in currentStudents)
            {
                Console.WriteLine("Name: {0} {1}", curr.firstName, curr.lastName);
                Console.WriteLine("Age: {0}", curr.age);
                Console.WriteLine("Student number: {0}", curr.studentNumber);
                Console.WriteLine("Average grade: {0}", curr.averageGrade);
                Console.WriteLine("Course: {0}", curr.currentCourse);
                Console.WriteLine("##############################");
            }
        }
    }
}
