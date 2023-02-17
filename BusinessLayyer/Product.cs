using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    class Product
    {
        public static int InstanceCount { get; set; }

        private int _id;
        private string _name;
        private string _decription;
        private double? _price; //can be null


        public int Id { get => _id; private set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Decription { get => _decription; set => _decription = value; }
        public double? Price { get => _price; set => _price = value; }

        public Product()
        {

        }
        public Product(int id)
        {
            _id = id;
        }

        public List<Product> Load()
        {
            return new List<Product>();
        }

        public Product Load(int id)
        {
            return new Product();
        }

        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            var result = true;

            if (String.IsNullOrWhiteSpace(Name))
                result = false;
            if (Price == null)
                result = false;

            return result;
        }
    }
}
