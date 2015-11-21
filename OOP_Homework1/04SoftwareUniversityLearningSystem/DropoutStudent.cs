using System;

namespace _04SoftwareUniversityLearningSystem
{
    public class DropoutStudent : Student
    {
        public DropoutStudent(string firstName, string lastName, int age, int studentNumber, double averageGrade, string dropoutReason) : base(firstName, lastName, age, studentNumber, averageGrade)
        {
            this.dropoutReason = dropoutReason;
        }

        public string dropoutReason { set; get; }
        public void Reapply()
        {
            Console.WriteLine("Name: {0} {1}, age: {2}, Student number: {3}, Average grade: {4}, Dropout reason: {5}",
                 firstName, lastName, age, studentNumber, averageGrade, dropoutReason);
        }
    }
}
