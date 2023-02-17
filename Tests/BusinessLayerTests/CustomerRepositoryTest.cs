using BusinessLayer;
using BusinessLayer.Repositories;
using Xunit;

namespace BusinessLayerTests
{
    public class CustomerRepositoryTest
    {
        [Fact]
        public void SaveValidTest()
        {
            //arrange
            var customer = new Customer(1) { FirstName = "Viktor", LastName = "Soviak", Email = "inode16@gmail.com" };
            var customerRepository = new CustomerRepository();

            //act
            var result = customerRepository.Save(customer);

            //assert
            Assert.True(result);
        }

        [Fact]
        public void LoadValidTest()
        {
            //arrange
            var customer = new Customer(1) { FirstName = "Viktor", LastName = "Soviak", Email = "inode16@gmail.com" };
            var customerRepository = new CustomerRepository();
            customerRepository.Save(customer);

            //act
            var result = customerRepository.Load(1);

            //assert
            Assert.NotEqual(customer, result);
            Assert.Equal(customer.Id, result.Id);
            Assert.Equal(customer.FirstName, result.FirstName);
            Assert.Equal(customer.LastName, result.LastName);
            Assert.Equal(customer.Email, result.Email);

        }

        [Fact]
        public void LoadInvalidTest()
        {
            //arrange
            var customer = new Customer(1) { FirstName = "Viktor", LastName = "Soviak", Email = "inode16@gmail.com" };
            var customerRepository = new CustomerRepository();
            customerRepository.Save(customer);

            //act
            var result = customerRepository.Load(2);

            //assert
            Assert.NotEqual(customer, result);
            Assert.Null(result);

        }
    }
}
