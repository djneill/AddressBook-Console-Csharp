using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nameAddress
{
    public class InputService
    {
        public static PersonModel GetPersonInput()
        {
            Console.Write("What is your first name or type (exit) to stop: ");
            string firstName = Console.ReadLine();

            if (firstName.ToLower() == "exit")
                return null;

            Console.Write("what is your last name: ");
            string lastName = Console.ReadLine();

            return new PersonModel
            {
                FirstName = firstName,
                LastName = lastName
            };
        }

        public static AddressModel GetAddressInput()
        {
            bool validNumber = false;
            int houseNumber = 0;
            int zip = 0;

            while (!validNumber)
            {
                Console.Write("Enter your house number: ");
                string houseResult = Console.ReadLine();
                validNumber = int.TryParse(houseResult, out houseNumber);

                if (!validNumber)
                {
                    Console.WriteLine("invalid number format, please use keys 1 - 9");
                }
            }

            Console.Write("Enter your street name: ");
            string street = Console.ReadLine();

            Console.Write("Enter your city: ");
            string city = Console.ReadLine();

            Console.Write("Enter your state: ");
            string state = Console.ReadLine();

            do
            {
                Console.Write("Enter your zip: ");
                string zipResult = Console.ReadLine();
                validNumber = int.TryParse(zipResult, out zip) && zipResult.Length == 5;

                if (!validNumber)
                {
                    Console.WriteLine("invalid number format, please use keys 1 - 9, zipcode should be 5 digits long.");
                }
            } while (!validNumber);

            return new AddressModel
            {
                HouseNumber = houseNumber,
                StreetName = street,
                City = city,
                State = state,
                ZipCode = zip,
            };


        }
    }
}