using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExercise.Console
{
    class ServiceUniversity
    {
        static Persistence persistence = new Persistence();

        static int maxNumberOfUniversities = 0;
        public static void InsertUniversity()
        {
            try
            {
                if (maxNumberOfUniversities < 3)
                {
                    University university = new University();

                    System.Console.WriteLine("Please enter an id number: ");
                    university.Id = System.Console.ReadLine();

                    if (university.Id == null
                        || university.Id == "0"
                        || university.Id.Contains("-"))
                    {
                        throw new ArgumentException("Please enter a non-null positive number!");
                    }

                    if (university.Id.Contains("%"))
                    {
                        throw new ArgumentException("The id should not contain '%' character!");
                    }

                    if (university.Id.Length > 10)
                    {
                        throw new ArgumentException("Must have maximum of 10 characters!");
                    }         

                    System.Console.WriteLine("Please enter the University name: ");
                    university.Name = System.Console.ReadLine();

                    System.Console.WriteLine("Please enter the University address: ");
                    university.Address = System.Console.ReadLine();

                    persistence.InsertAsync(university);

                    maxNumberOfUniversities++;
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

        public static void GetAllUniversities() => GetAll<University>(persistence);
        public static async Task GetAll<TEntity>(Persistence persistence) where TEntity : IEntity
        {
            var universities = await persistence.GetAllAsync<TEntity>();

            System.Console.WriteLine("The universities are: ");

            foreach (var item in universities)
            {
                System.Console.WriteLine(item.ToString());
            }
        }
    }
}
