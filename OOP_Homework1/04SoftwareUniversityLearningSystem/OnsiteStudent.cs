namespace _04SoftwareUniversityLearningSystem
{
    public class OnsiteStudent : CurrentStudent
    {
        public OnsiteStudent(string firstName, string lastName, int age, int studentNumber, double averageGrade, string currentCourse, int numberOfVisits) : base(firstName, lastName, age, studentNumber, averageGrade, currentCourse)
        {
            this.numberOfVisits = numberOfVisits;
        }

        public int numberOfVisits { set; get; }
    }
}
