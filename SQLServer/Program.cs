using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLServer
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new PersonContext();
            //context.Person.Add(new Person() { Id = 2, FirstName = "Bill", LastName = "Gates", Occupation = "N/A" });
            //context.SaveChanges();

            var persons = from p in db.Person
                          where p.FirstName.Length < 5
                          select p;

            foreach(var p in persons)
            {
                Console.WriteLine("Id: {0}\tFirstName: {1}\tLastName: {2}\tOccupation: {3}", p.Id, p.FirstName, p.LastName, p.Occupation);
            }

            Console.ReadKey();
            
        }
    }
}
