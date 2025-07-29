using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nameAddress
{
    public class ProcessPerson
    {
        public static void PersonDetails(PersonModel person)
        {
            Console.WriteLine($"Hello {person.FirstName} {person.LastName}");
            Console.WriteLine($"{person.HomeAddress.HouseNumber} {person.HomeAddress.StreetName}");
            Console.WriteLine($"{person.HomeAddress.City} {person.HomeAddress.State} {person.HomeAddress.ZipCode}");
        }
    }
}