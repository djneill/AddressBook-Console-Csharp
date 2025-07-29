using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nameAddress
{
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        // public string EmailAddress { get; set; }
        public AddressModel HomeAddress { get; set; }
    }
}