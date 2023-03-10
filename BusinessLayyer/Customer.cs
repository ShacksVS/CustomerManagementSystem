using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class Customer
    {
        public static int InstanceCount{get; set;}

        private int _id;
        private string _lastName;
        private string _firstName;
        private string _email;

        public string LastName { get => _lastName; set => _lastName = value; }
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string Email { get => _email; set => _email = value; }
        public int Id { get => _id; private set => _id = value; }

        public string FullName
        {
            get
            {
                var result = LastName;
                if (!String.IsNullOrWhiteSpace(FirstName))
                {
                    if (!String.IsNullOrWhiteSpace(LastName))
                    {
                        result += ", ";
                    }
                    result += FirstName;
                }
                return result;
            }
        }

        //constructor without parameters
        public Customer()
        {

        }

        public Customer(int id)
        {
            _id = id;
        }

        public bool Validate()
        {
            var result = true;

            if (String.IsNullOrWhiteSpace(LastName))
                result = false;
            if (String.IsNullOrWhiteSpace(Email))
                result = false;

            return result;
        }
    }
}
