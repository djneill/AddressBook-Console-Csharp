using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using nameAddress.Models;

namespace nameAddress.Processors
{
    public class ProcessPerson
    {
        public static void PersonDetails(PersonModel person)
        {
            Console.WriteLine(person.FullName);
            Console.WriteLine(person.HomeAddress.FullAddress);
        }
    }
}