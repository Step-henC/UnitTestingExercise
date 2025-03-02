using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var tabulate = new Calculator();
            

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual
                var actual = tabulate.Add(num1, num2, num3);    

            //Assert
                //Assert.Equal(expected, actual);
                Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5,4,1)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var tab2 = new Calculator();    
            //Act
            var actual = tab2.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3,5,15)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var tab3 = new Calculator();    
            //Act
            var actual = tab3.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(14,7,2)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var tab4 = new Calculator();    
            //Act
            var actual = tab4.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
