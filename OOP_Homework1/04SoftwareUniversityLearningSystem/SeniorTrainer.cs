﻿using System;

namespace _04SoftwareUniversityLearningSystem
{
    public class SeniorTrainer : Trainer
    {
        public SeniorTrainer(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {
        }
        public void DeleteCourse(string courseName)
        {
            Console.WriteLine("Course {0} has been deleted.", courseName);
        }
    }
}
