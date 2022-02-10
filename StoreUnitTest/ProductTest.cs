using ProductModel;
using Xunit;

namespace StoreUnitTest
{
    public class ProductTest
    {
        /// <summary>
        /// Checks the validation for Name property for valid data
        /// </summary>
        /// [Fact] is a data annotation in C# and all it means is it will tell the compiler that this specific method is a unit test
        [Fact]
        public void CategoryShouldSetValidData()
        {
            //Arrange
            Products cat = new Products();
            string validCat = "Basketball";
        
            //Act
            cat.Category = validCat;
        
            //Assert
            Assert.NotNull(cat.Category);//checks that the property is not null meaning we did set data in this property
            Assert.Equal(validCat, cat.Category);//checks if the property does indeed hold the same value as what we set it as
        }
        /// <summary>
        /// Checks the validation for Name property for valid data
        /// </summary>
        /// [Fact] is a data annotation in C# and all it means is it will tell the compiler that this specific method is a unit test
        [Fact]
        public void PriceShouldSetValidData()
        {
            //Arrange
            Products price = new Products();
            double validPrice = 5.99;
        
            //Act
            price._price = validPrice;
        
            //Assert
            Assert.NotNull(price._price);//checks that the property is not null meaning we did set data in this property
            Assert.Equal(validPrice, price._price);//checks if the property does indeed hold the same value as what we set it as
        }
    }
}