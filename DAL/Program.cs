using DAL.Modelos;
using System;

namespace DAL
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
                var grade = new Grade()
                {
                    GradeName = "Grade 1",
                    Section = "One"
                };

                //context.Grades.Add(grade);

                var std = new Student()
                {
                    StudentName = "Danny Mauricio Montero Valencia",
                    Height = 1.73m,
                    Weight = 70.0f,
                    DateOfBirth = new System.DateTime(1975, 3, 15),
                    Grade = grade
                    //Grade = context.Grades.Find(1)
                };

                context.Students.Add(std);
                context.SaveChanges();
            }
        }
    }
}
