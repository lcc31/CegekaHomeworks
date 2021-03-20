using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExercise.Console
{
    class ServiceStudent
    {
        static Persistence persistence = new Persistence();

        static int maxNumberOfStudents = 0;
        public static void InsertStudent()
        {
            try
            {
                if (maxNumberOfStudents < 3)
                {
                    Student student = new Student();

                    System.Console.WriteLine("Please enter an id number");
                    student.Id = System.Console.ReadLine();

                    if (student.Id == null
                        || student.Id == "0"
                        || student.Id.Contains("-"))
                    {
                        throw new ArgumentException("Please enter a non-null positive number!");
                    }

                    if (student.Id.Contains("%"))
                    {
                        throw new ArgumentException("The id should not contain '%' character!");
                    }

                    if (student.Id.Length > 10)
                    {
                        throw new ArgumentException("Must have maximum 10 characters!");
                    }

                    System.Console.WriteLine("Please enter the First name");
                    student.FirstName = System.Console.ReadLine();

                    System.Console.WriteLine("Please enter the Last name");
                    student.LastName = System.Console.ReadLine();

                    persistence.InsertAsync(student);

                    maxNumberOfStudents++;
                }
                else
                {
                    throw new InvalidOperationException("Only a maximum of 3 objects of each type are allowed.");
                }
            }
            catch (Exception exception)
            {
                System.Console.WriteLine(exception);
            }
        }

        public static void GetAllStudents() => GetStudents<Student>(persistence);
        public static async Task GetStudents<TEntity>(Persistence persistence) where TEntity : IEntity
        {
            var collection = await persistence.GetAllAsync<TEntity>();

            System.Console.WriteLine("The students are: ");

            foreach (var item in collection)
            {
                System.Console.WriteLine(item.ToString());
            }
        }
    }
}
