using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace nameAddress.Models
{
    public class AddressModel
    {
        public int HouseNumber { private get; set; }
        public string StreetName { private get; set; }
        public string City { private get; set; }
        public string State { private get; set; }
        // public int ZipCode { get; set; }
        private int _zipcode;
        public int ZipCode
        {
            private get
            {
                return _zipcode;
            }
            set
            {
                if (value.ToString().Length == 5)
                {
                    _zipcode = value;
                }
                else
                {
                    // throw new ArgumentOutOfRangeException("zip code needs to 5 digits long.");
                }
            }
        }

        public string FullAddress
        {
            get
            {
                return $"{HouseNumber} {StreetName}\n{City} {State} {ZipCode}";
            }
        }
    }
}