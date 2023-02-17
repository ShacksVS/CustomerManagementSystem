using BusinessLayer;
using System;
using Xunit;


namespace BusinessLayerTests
{
    public class CustomerTest
    {
        [Fact]
        public void FullNameTestValid()
        {
            //arrange

            var customer = new Customer {FirstName = "Viktor", LastName = "Soviak" };

            var expected = "Soviak, Viktor";

            //Act
            var actual = customer.FullName;

            //assert
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void FullNameNoFirstNameTest()
        {
            //arrange

            var customer = new Customer { LastName = "Soviak" };

            var expected = "Soviak";

            //Act
            var actual = customer.FullName;

            //assert
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void FullNameNoLastNameTest()
        {
            //arrange

            var customer = new Customer { LastName = "Viktor" };

            var expected = "Viktor";

            //Act
            var actual = customer.FullName;

            //assert
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void StaticTest()
        {
            //arrange

            var customer = new Customer();
            customer.LastName = "Soviak";
            Customer.InstanceCount += 1;

            var customer1 = new Customer();
            customer1.LastName = "Apple";
            Customer.InstanceCount += 1;

            var customer2 = new Customer();
            customer2.LastName = "Mohyla";
            Customer.InstanceCount += 1;

            var expected = 3;

            //act 
            var actual = Customer.InstanceCount;

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ValidateValid()
        {
            //arrange
            var customer = new Customer() { LastName = "Soviak", Email = "inode16@gmail.com" };

            var expected = true;

            //act
            var actual = customer.Validate();

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ValidateOnlyEmail()
        {
            //arrange
            var customer = new Customer() { Email = "inode16@gmail.com" };

            var expected = false;

            //act
            var actual = customer.Validate();

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
