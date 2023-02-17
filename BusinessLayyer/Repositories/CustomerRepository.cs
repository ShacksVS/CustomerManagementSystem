using System.Collections.Generic;

namespace BusinessLayer.Repositories
{
    public class CustomerRepository
    {
        private List<Customer> _storage = new List<Customer>();

        public List<Customer> Load()
        {
            var result = new List<Customer>();
            //protect storage
            foreach(var customer in _storage)
            {
                var newCustomer = CreateClone(customer);
                result.Add(newCustomer);
            }

            return result;
        }

        //returns client by ID
        public Customer Load(int id)
        {
            //protect storage
            foreach (var customer in _storage)
            {
                if (customer.Id == id)
                {
                    var newCustomer = CreateClone(customer);
                    return newCustomer;
                }
            }
            return null;
        }

        public bool Save(Customer customer)
        {
            var newCustomer = CreateClone(customer);
            _storage.Add(newCustomer);
            return true;
        }

        private Customer CreateClone(Customer customer)
        {
            var newCustomer = new Customer(customer.Id) {
                LastName = customer.LastName,
                FirstName = customer.FirstName, 
                Email = customer.Email
            };
            return newCustomer;
        }
    }
}
