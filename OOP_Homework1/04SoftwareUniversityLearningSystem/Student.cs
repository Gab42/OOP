namespace _04SoftwareUniversityLearningSystem
{
    public class Student : Person
    {
        public Student(string firstName, string lastName, int age, int studentNumber, double averageGrade) : base(firstName, lastName, age)
        {
            this.studentNumber = studentNumber;
            this.averageGrade = averageGrade;
        }
        public int studentNumber { set; get; }
        public double averageGrade { set; get; }
    }










}
