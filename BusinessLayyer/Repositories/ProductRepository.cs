using System.Collections.Generic;

namespace BusinessLayer.Repositories
{
     public class ProductRepository
    {
        private List<Product> _storage = new List<Product>();

        public List<Product> Load()
        {
            var result = new List<Product>();
            //protect storage
            foreach (var product in _storage)
            {
                var newProduct = CreateClone(product);
                result.Add(newProduct);
            }

            return result;
        }

        //returns client by ID
        public Product Load(int id)
        {
            //protect storage
            foreach (var product in _storage)
            {
                if (product.Id == id)
                {
                    var newProduct = CreateClone(product);
                    return newProduct;
                }
            }
            return null;
        }

        public bool Save(Product product)
        {
            var newProduct = CreateClone(product);
            _storage.Add(newProduct);
            return true;
        }

        private Product CreateClone(Product product)
        {
            var newProduct = new Product(product.Id)
            {
                Name = product.Name,
                Decription = product.Decription,
                Price = product.Price
            };
            return newProduct;
        }
    }
}
