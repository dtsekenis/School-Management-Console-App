using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Part_A
{
    public class Course
    {
        public string title { get; set; }
        public string stream { get; set; }
        public string type { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public static List<Course> Courses { get; set; } = new List<Course>();

        public Course()
        {

        }
        public Course(string Title,string Stream,string Type,
                            DateTime StarDate,DateTime EndDate)
        {
            title = Title;
            stream = Stream;
            type = Type;
            startDate = StarDate;
            endDate = EndDate;

        }
        public static void AddCourse(Course course)
        {
            Courses.Add(course);
        }
        public static void ShowCourse(Course course)
        {
            Course.ShowCourse(course);
        }
        public static void SynthDataCourse()
        {
            string[] ctitle = {"c#","java","math","english" };
            string[] cstream = { "technical", "technical", "theoritical", "theoritical" };
            string[] coursetype = { "full time", "full time", "full time", "part time" };
            DateTime[] stDate = { new DateTime(2019, 5, 13), new DateTime(2019, 5, 13), new DateTime(2019, 5, 8), new DateTime(2019, 5, 13) };
            DateTime[] edDate = { new DateTime(2019, 8, 13), new DateTime(2019, 8, 14), new DateTime(2019, 7, 10), new DateTime(2019, 6, 9) };

            for (int i = 0; i < 4; i++)
            {
                Course course = new Course(ctitle[i], cstream[i], coursetype[i], stDate[i], edDate[i]);
                AddCourse(course);
                //($"studfname{i+1},studlname{i+1}");
            }
        }

        public static void InputDataCourse()
        {
            Console.Write("Enter the title: ");
            string title = Console.ReadLine();
            Console.Write("Choose your stream: ");
            string stream = Console.ReadLine();
            Console.Write("Enter the type: ");
            string type = Console.ReadLine();
            Console.Write("Enter when it begins(yy/mm/dd): ");
            DateTime startDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter when it ends(yy/mm/dd): ");
            DateTime endDate = DateTime.Parse(Console.ReadLine());
            Course course = new Course(title,stream,type,startDate,endDate);
            Course.Courses.Add(course);


        }
        public static void OutputCourseData()
        {
           
            int i = 0;
            foreach (Course course in Course.Courses)
            {
                Console.WriteLine($"{i+1}: {course.title} {course.stream} {course.type} {course.startDate} {course.endDate}");
            }

        }



    }
}
/*for(int i=0; i<List.Courses.Count; i++){
 if(Lists.Courses[i].Title==title)
 {sc.Courses.Add(Lists.Courses[i]));
   }  
     
     
     
     
     }*/