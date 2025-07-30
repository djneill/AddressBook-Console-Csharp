using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nameAddress.Models
{
    public class PersonModel
    {
        public string FirstName { private get; set; }
        public string LastName { private get; set; }
        // public string EmailAddress { get; set; }
        public AddressModel HomeAddress { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}