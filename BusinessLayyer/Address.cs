using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    class Address
    {
        private int _id;
        private int _type;
        private string _streetLine1;
        private string _streetLine2;
        private string _city;
        private string _state;
        private string _country;
        private string _code;

        public int Id { get => _id; set => _id = value; }
        public int Type { get => _type; set => _type = value; }
        public string StreetLine1 { get => _streetLine1; set => _streetLine1 = value; }
        public string StreetLine2 { get => _streetLine2; set => _streetLine2 = value; }
        public string City { get => _city; set => _city = value; }
        public string State { get => _state; set => _state = value; }
        public string Country { get => _country; set => _country = value; }
        public string Code { get => _code; set => _code = value; }

        public Address()
        {

        }

        public Address(int id)
        {
            _id = id;
        }

        public bool Validate()
        {
            var result = true;

            if (String.IsNullOrWhiteSpace(StreetLine1))
                result = false;
            if (String.IsNullOrWhiteSpace(City))
                result = false;
            if (String.IsNullOrWhiteSpace(Country))
                result = false;
            if (String.IsNullOrWhiteSpace(Code))
                result = false;

            return result;          
        }
    }
}
