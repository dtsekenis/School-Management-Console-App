using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Part_A
{
    class Assigment
    {
        private string title { get; set; }
        private string description { get; set; }
        private DateTime subDateTime { get; set; }
        private double oralMark { get; set; }
        private int totalMark { get; set; }
        public static List<Assigment> Assigments { get; set; } = new List<Assigment>();
        public List<Course> Courses { get; set; } = new List<Course>();
        public List<Student> Students { get; set; } = new List<Student>();


        public Assigment()
        {

        }
        public Assigment(string Title,string Description,DateTime SubDateTime,double OralMark,int TotalMark)
        {
            title = Title;
            description = Description;
            subDateTime = SubDateTime;
            oralMark = OralMark;
            totalMark = TotalMark;
        }
        public static void AddAssigment(Assigment assigment)
        {
            Assigments.Add(assigment);
        }
        
        public static void SynthDataAssigment()
        {
            
            string[] AssTitle = { "NooB,", "NooB1,", "NooB3," };
            string[] AssDescr = { "Develop,", "Analyze,", "Execute," };
            DateTime[] AssDateTime= { new DateTime(2019, 6, 5), new DateTime(2019, 6, 11), new DateTime(2020, 7, 9), new DateTime(2021, 8, 7) };
            int[] AssOralMark = { 56, 78, 98 };
            int[] AssTotalMark = { 55, 77, 97 };

            Random random = new Random();
            Random random1 = new Random();
            for (int i = 0; i < 3; i++)
            {
                Assigment assigment = new Assigment(AssTitle[i], AssDescr[i], AssDateTime[i], AssOralMark[i], AssTotalMark[i]);
                AddAssigment(assigment);

                assigment.Courses.Add(Course.Courses[random.Next(0, Course.Courses.Count)]);
                assigment.Students.Add(Student.Students[random1.Next(0, Student.Students.Count)]);

            }

        }

        public static void InputDataAssigment()
        {
            Console.Write("Enter the Title: ");
            string title = Console.ReadLine();
            Console.Write("Enter a description: ");
            string  description= Console.ReadLine();
            
            Console.Write("Enter the deadline (yy/mm/dd): ");
            DateTime subDateTime = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter the oral mark");
            int oralMark = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the total mark");
            int totalMark = Convert.ToInt32(Console.ReadLine());

            Assigment assigment = new Assigment(title, description, subDateTime, oralMark,totalMark);

            Assigment.Assigments.Add(assigment);
        }
        public static void OutputAssigmentData()
        {

            int i = 0;
            foreach (Assigment assigment in Assigment.Assigments)
            {
                Console.WriteLine($"{i + 1}: {assigment.title} {assigment.description} {assigment.subDateTime} {assigment.oralMark} {assigment.totalMark}");
            }
        }
        public static void AssigmentsPerCourse()
        {
            foreach (Assigment assigment in Assigment.Assigments)
            {
                foreach (Course course in assigment.Courses)
                {
                    foreach (Course course1 in Course.Courses)
                    {
                        if (course.title == course1.title)
                        {
                            Console.WriteLine($"{assigment.title} {assigment.description} has {course.title} ");
                        }
                    }
                }

            }

        }
        public static void AssigmentsPerStudent()
        {
            foreach (Assigment assigment in Assigment.Assigments)
            {
                foreach (Student student in assigment.Students)
                {
                    foreach (Student student1 in Student.Students)
                    {
                        if (student.firstName == student1.firstName)
                        {
                            Console.WriteLine($"{assigment.title} {assigment.description} is assigned to {student.firstName} {student.lastName} ");
                        }
                    }
                }

            }

        }
    }
}
