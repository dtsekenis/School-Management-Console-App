using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Part_A
{
    public class Student
    {
        public  string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime dateOfBirth { get; set; }
        public decimal tuitionFees { get; set; }
        public static List<Student> Students { get; set; } = new List<Student>();
       
        public List<Course> Courses { get; set; } = new List<Course>();

        #region Constructors
        public Student()
        {

        }

        public Student(string firstname, string lastname, 
                DateTime DateOfBirth, decimal TuitionFees)
        {
            firstName = firstname;
            lastName = lastname;
            dateOfBirth = DateOfBirth;
            tuitionFees = TuitionFees;
        }

        #endregion
        
        public static void AddStudent(Student student)
        {
            Students.Add(student);
        }
        
        public static void SynthDataStudent()
        {
            
            string[] StudFName = {"Mitsos","Michalis","Giannis","Soulis"};
            string[] StudLName = { "Tsekenis,", "Vorisis,", "Strakastroukas,", "Karfakis," };
            DateTime[] DateOfBirth = { new DateTime(1992, 5, 5), new DateTime(1993,6,11), new DateTime(1992,7,9), new DateTime(1993,8,7)};
            Random random = new Random();
            for(int i = 0; i < 4; i++)
            {
                Student student = new Student(StudFName[i], StudLName[i], DateOfBirth[i], 2500m);
                AddStudent(student);
                
                student.Courses.Add(Course.Courses[random.Next(0,Course.Courses.Count)]);
                

            }
        }

        public static void InputDataStudent()
        {
            Console.WriteLine("");
            Console.Write("Enter the First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter the Last Name:");
            string lastName = Console.ReadLine();
            Console.Write("Enter your Date of Birth:(yy/mm/dd): ");
            DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter your Tuitions: ");
            decimal tuitionFee = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("");

            Student student = new Student(firstName, lastName, dateOfBirth, tuitionFee);
            //Student student1 = new Student(firstName, lastName, dateOfBirth, tuitionFee);

            Student.Students.Add(student);

            //Student.ShowStudent(student1);
        }
        public static void OutputStudentData()
        {
           
            int i=0;
            foreach (Student student in Student.Students)
            {
                Console.WriteLine($"{i+1}: {student.firstName} {student.lastName} {student.dateOfBirth} {student.tuitionFees}");
            }           
        }
        public static void StudentsPerCourse()
        {
            foreach (Student student in Student.Students)
            {
                foreach(Course course in student.Courses)
                {
                    foreach (Course course1 in Course.Courses)
                    {
                        if (course.title == course1.title)
                        {
                            Console.WriteLine($"{student.firstName} {student.lastName} has {course.title} ");
                        }
                    }
                }

            }
     
        }
        public static void MoreThanOneStudent()
        {
            foreach (Student student in Student.Students)
            {
                   
                if (student.Courses.Count > 1)
                {
                    Console.Write($"{student.firstName} {student.lastName}");
                }               
            }
        }
    }
}
