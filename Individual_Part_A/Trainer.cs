using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Part_A
{
    public class Trainer
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string subject { get; set; }
        public static List<Trainer> Trainers { get; set; } = new List<Trainer>();
        public List<Course> Courses { get; set; } = new List<Course>();



        public Trainer() //default contructor
        {

        }

        public Trainer(string firstname, string lastname,
                string Subject)
        {
            firstName = firstname;
            lastName = lastname;
            subject = Subject;

        }
        public static void AddTrainer(Trainer trainer)
        {
            Trainers.Add(trainer);
        }
        public static void ShowTrainer(Trainer trainer)
        {
            Trainer.ShowTrainer(trainer);
        }
        public static void SynthDataTrainer()
        {
            
            string[] TrainerFName = { "Mike", "Tony", "Anthony", "Vyron" };
            string[] TrainerLName = { "Nikolaidis", "Stark", "Hopkins", "Vasileiadis" };
            string[] TrainerSubject = { "Developer","Engineer","Physicos","Developer" };
            Random random = new Random();
            for (int i = 0; i < 4; i++)
            {
                Trainer trainer = new Trainer(TrainerFName[i], TrainerLName[i], TrainerSubject[i]);
                AddTrainer(trainer);

                trainer.Courses.Add(Course.Courses[random.Next(0, Course.Courses.Count)]);

            }

        }

        public static void InputDataTrainer()
        {
            Console.Write("Enter the First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter the Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter your subject: ");
            string subject = Console.ReadLine();

            Trainer trainer = new Trainer(firstName, lastName, subject);
            //Student student1 = new Student(firstName, lastName, dateOfBirth, tuitionFee);

            Trainer.Trainers.Add(trainer);
            //Student.ShowStudent(student1);
        }
        public static void OutputTrainerData()
        {

            int i = 0;
            foreach (Trainer trainer in Trainer.Trainers)
            {
                Console.WriteLine($"{i + 1}: {trainer.firstName} {trainer.lastName} {trainer.subject} ");
            }

        }
        public static void TrainersPerCourse()
        {
            foreach (Trainer trainer in Trainer.Trainers)
            {
                foreach (Course course in trainer.Courses)
                {
                    foreach (Course course1 in Course.Courses)
                    {
                        if (course.title == course1.title)
                        {
                            Console.WriteLine($"{trainer.firstName} {trainer.lastName} has {course.title} ");
                        }
                    }
                }

            }

        }
        

    }
}
