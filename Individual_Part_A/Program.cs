using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Part_A
{
    public class Program
    {
        static void Main(string[] args)
        {
    
            int option1, option2, option3;
            string answer;
            do
            {
                Console.WriteLine("Do you want to use synthetic data? (y/n)");
                answer = Console.ReadLine();

            } while (answer!="y" && answer!="n");
            if (answer == "y")
            {
                Course.SynthDataCourse();
                Student.SynthDataStudent();
                Trainer.SynthDataTrainer();
                Assigment.SynthDataAssigment();
            }

            do
            {
                do
                {
                    Console.WriteLine("");
                    Console.WriteLine("1) Create an Entite: ");
                    Console.WriteLine("2) Preview Entites: ");
                    Console.WriteLine("3) Exit: ");

                    Console.Write("Choose an option: ");
                } while (!int.TryParse(Console.ReadLine(),out option1));


                MainMenu mainMenu = (MainMenu)option1;
                
                switch (mainMenu)
                {
                    
                    case MainMenu.AddEntity:
                        //Console.WriteLine("1) Create an Entity ");
                        do
                        {
                            do
                            {
                                Console.WriteLine("");
                                Console.WriteLine("1) Create a new Student: ");
                                Console.WriteLine("2) Create a new Course: ");
                                Console.WriteLine("3) Create a new Trainer: ");
                                Console.WriteLine("4) Create a new Assigment: ");
                                Console.WriteLine("5) Previous Menu<== ");
                                
                                Console.Write("Choose an option: ");

                            } while (!int.TryParse(Console.ReadLine(), out option2));

                            AddEntity addEntity = (AddEntity)option2;
                            
                            switch (addEntity)
                            {
                                case AddEntity.AddStudent:
                                    Student.InputDataStudent();                                   
                                    break;
                                case AddEntity.AddCourse:
                                    Course.InputDataCourse();
                                    //Console.WriteLine("2) Create a new Course ");
                                    break;
                                case AddEntity.AddTrainer:
                                    Trainer.InputDataTrainer();
                                    //Console.WriteLine("3) Create a new Trainer ");
                                    break;
                                case AddEntity.AddAssigment:
                                    Assigment.InputDataAssigment();
                                    //Console.WriteLine("4) Create a new Assigment ");
                                    break;
                                case AddEntity.PreviousMenu:
                                    break;
                            }
                        }while(option2 != 5);
                        break;
                    //case MainMenu.SynthData:
                    //    break;
                    case MainMenu.ShowData:
                        //Console.WriteLine("2) Preview ");
                        do
                        {
                            do
                            {
                                Console.WriteLine("1) Show me Students: ");
                                Console.WriteLine("2) Show me Course: ");
                                Console.WriteLine("3) Show me Trainers: ");
                                Console.WriteLine("4) Show me Assigments: ");
                                Console.WriteLine("5) Previous Menu<== ");

                                Console.Write("Choose an option: ");
                            } while (!int.TryParse(Console.ReadLine(), out option3));

                            ShowData showData = (ShowData)option3;

                            switch (showData)
                            {
                                case ShowData.ShowStudent:
                                    Console.WriteLine("");
                                    Student.OutputStudentData();
                                    Console.WriteLine("");
                                    Console.WriteLine("Students per Course: ");
                                    Student.StudentsPerCourse();
                                    Console.WriteLine("");
                                    Console.WriteLine("More than one Student per Course: ");
                                    Console.WriteLine(" ");
                                    Student.MoreThanOneStudent();
                                    //Console.Write("");
                                    break;
                                case ShowData.ShowCourse:
                                    Console.WriteLine("");
                                    Course.OutputCourseData();
                                    Console.WriteLine("");
                                    break;
                                case ShowData.ShowTrainer:
                                    Trainer.OutputTrainerData();
                                    Trainer.TrainersPerCourse();
                                    break;
                                case ShowData.ShowAssigment:
                                    Assigment.OutputAssigmentData();
                                    Console.WriteLine("");
                                    Console.WriteLine(" Assigments Per Course: ");
                                    Console.WriteLine("");
                                    Assigment.AssigmentsPerCourse();
                                    Console.WriteLine("");
                                    Console.WriteLine(" Assigments Per Student: ");
                                    Console.WriteLine("");
                                    Assigment.AssigmentsPerStudent();
                                    
                                    break;
                                case ShowData.PreviousMenu:
                                    break;
                            }
                        } while (option3 != 5);
                        break;
                    case MainMenu.Exit:                      
                        break;
                    default:
                        break;
                }
            } while (option1 != 3);
        }
    }
}