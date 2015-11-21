namespace _04SoftwareUniversityLearningSystem
{
    public class CurrentStudent : Student
    {
        public CurrentStudent(string firstName, string lastName, int age, int studentNumber, double averageGrade, string currentCourse) : base(firstName, lastName, age, studentNumber, averageGrade)
        {
            this.currentCourse = currentCourse;
        }
        public string currentCourse { set; get; }
    }
}
