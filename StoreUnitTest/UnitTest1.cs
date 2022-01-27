using Xunit;
using CustomerModel;

namespace StoreUnitTest;

public class CustomerTest
{
    /// <summary>
    /// Checks the validation for Name property for valid data
    /// </summary>
    /// [Fact] is a data annotation in C# and all it means is it will tell the compiler that this specific method is a unit test
    [Fact]
    public void NameShouldSetValidData()
    {
        //Arrange
        Customer cus = new Customer();
        string validName = "Brian Dawkins";
        

        //Act
        cus.Name = validName;

        //Assert
        Assert.NotNull(cus.Name); //checks that the property is not null meaning we did set data in this property
        Assert.Equal(validName, cus.Name); //checks if the property does indeed hold the same value as what we set it as

    }
}