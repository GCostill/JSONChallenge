using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Gaby";
            person.LastName = "Costill";
            person.DOB = new DateTime(2000, 01, 17);
            person.FavoriteIceCreamFlavors = new List<string> { "strawberry", "cookie dough" };

            string json = JsonConvert.SerializeObject(person);

            Console.WriteLine(json);

            Console.ReadKey();
        }
    }
}
