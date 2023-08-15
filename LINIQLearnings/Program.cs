using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINIQLearnings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Language integrated Query
            // random unshorted array
            Console.WriteLine("------------Without LINQ----------");
            int[] numbers = { 21, 3, 4, 5, 6, 7, 8, 9, 10, 1 };
            int count = 0;
            foreach (int i in numbers)
            {
                if (i > 5)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            int[] brr = new int[count];
            int index = 0;
            foreach (int i in numbers)
            {
                if (i > 5)
                {
                    brr[index] = i;
                    index++;
                }
            }
            Array.Sort(brr);
            Array.Reverse(brr);
            foreach (var item in brr) Console.Write(item + " ");

            Console.WriteLine("\n------------With LINQ----------");
            // from i in arr select i;
            // from i in arr where i>5 select i;
            // from i in arr where i>5 orderby i select i;
            // from i in arr where i>5 orderby i descending select i;

            var myarr = from i in numbers where i > 5 orderby i descending select i;

            foreach (var item in myarr) Console.Write(item + " ");

            // LINQ to sql
            //enable-migrations
            //add-migration CreateAnimalTable
            //update-database
            //using (var context = new AnimalContext())
            //{
            //    var animalsToAdd = new[]
            //    {
            //    new Animal { name = "Lion", location = "Africa" },
            //    new Animal { name = "Tiger", location = "India" },
            //    new Animal { name = "Elephant", location = "Africa" },
            //    new Animal { name = "Panda", location = "China" },
            //    new Animal { name = "Kangaroo", location = "Australia" }
            //};

            //    context.Animals.AddRange(animalsToAdd);

            //    // Save changes to the database
            //    context.SaveChanges();
            //}
            Console.WriteLine("Inserted 5 dummy rows into the Animals table.");
            using (var context = new AnimalContext())
            {
                // Retrieve a single entity by its primary key (id)
                var animal = context.Animals.Find(2);

                // Retrieve multiple entities using LINQ queries
                var animalsInAfrica = context.Animals.Where(a => a.location == "Africa").ToList();
                Console.WriteLine(animal.name);
                foreach(Animal i in animalsInAfrica) Console.WriteLine(i.name);
            }
            using (var context = new AnimalContext())
            {
                var animalToUpdate = context.Animals.Find(2);

                // Modify the properties of the entity
                animalToUpdate.name = "Giraffe";
                context.SaveChanges();
            }
            using (var context = new AnimalContext())
            {
                var animalToDelete = context.Animals.Find(2);

                // Remove the entity from the DbSet
                context.Animals.Remove(animalToDelete);
                context.SaveChanges();
            }
            Console.ReadLine();

        }
    }
}