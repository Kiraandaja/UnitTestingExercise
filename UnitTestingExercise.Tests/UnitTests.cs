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

            var test = new UnitTests();


            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual

            var actual = test.Add(num1, num2, num3);

            //Assert
            //Assert.Equal(expected, actual);
            Assert.Equal(expected, actual);
        }

        private object Add(int num1, int num2, int num3)
        {
            throw new NotImplementedException();
        }

        [Theory]
        [InlineData(5,5,0)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var tester = new UnitTests();

            //Act
            var actual = tester.Subtract( minuend,  subtrhend);

            //Assert
            Assert.Equal(expected, actual);
        }

        private object Subtract(int minuend, int subtrhend)
        {
            throw new NotImplementedException();
        }

        internal object Multiply(int num1, int num2)
        {
            throw new NotImplementedException();
        }

        [Theory]
        [InlineData(20, 4, 5)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var tester = new UnitTests();

            //Act
            var actual = tester.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        private object Divide(int num1, int num2)
        {
            throw new NotImplementedException();
        }
    }

        [Theory]
        [InlineData(3,4,12)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
        //Arrange
        var tester = new UnitTests();

        //Act
        var actual = tester.Multiply(num1, num2);

        //Assert
        Assert.Equal(expected, actual);
    }
}
       




    


