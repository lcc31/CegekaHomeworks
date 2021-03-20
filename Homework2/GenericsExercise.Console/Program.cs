using System;

namespace GenericsExercise.Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    DisplayMenuOptions();
                    
                    int action = int.Parse(System.Console.ReadLine());

                    switch (action)
                    {
                        default:
                            System.Console.WriteLine(
                                "Please choose a number between 0 and 4!");
                            break;
                        case 0:
                            return;
                        case 1:
                            ServiceStudent.InsertStudent();
                            break;
                        case 2:
                            ServiceStudent.GetAllStudents();
                            break;
                        case 3:
                            ServiceUniversity.InsertUniversity();
                            break;
                        case 4:
                            ServiceUniversity.GetAllUniversities();
                            break;
                    }
                }
                catch (Exception)
                {
                    System.Console.WriteLine(
                        "Please choose a valid option!");
                }
            }
        }

        private static void DisplayMenuOptions()
        {
            System.Console.WriteLine(
                "  Choose an option: " +
                        "\n 0 - Quit " +
                        "\n 1 - Insert student " +
                        "\n 2 - Read students " +
                        "\n 3 - Insert university " +
                        "\n 4 - Read universities " +
                        "\n");
        }
    }
}