using System;
using Xunit;

namespace CalculatorTest
{
    public class UnitTest1
    {
        [Fact]
        public void Task_Add_TwoNumber()
        {
            // Arrange  
            double num1 = 4.1;
            double num2 = 2;
            double expectedValue = 6.1;

            // Act  
            double sub = Calculator.Program.Addition(num1, num2);

            //Assert  
            Assert.Equal(expectedValue, sub, 1);
        }

        [Fact]
        public void Task_Add_TwoNumber1()
        {
            // Arrange  
            double num1 = -4;
            double num2 = 2;
            double expectedValue = -2;

            // Act  
            double sub = Calculator.Program.Addition(num1, num2);

            //Assert  
            Assert.Equal(expectedValue, sub, 1);
        }
        [Fact]
        public void Task_Substract_TwoNumber()
        {
            // Arrange  
            double num1 = 4.1;
            double num2 = 2;
            double expectedValue = 2.1;

            // Act  
            double sub = Calculator.Program.Substraction(num1, num2);

            //Assert  
            Assert.Equal(expectedValue, sub, 1);
        }

        [Fact]
        public void Task_Substract_TwoNumber1()
        {
            // Arrange  
            double num1 = -4;
            double num2 = 2;
            double expectedValue = -6;

            // Act  
            double sub = Calculator.Program.Substraction(num1, num2);

            //Assert  
            Assert.Equal(expectedValue, sub, 1);
        }
        [Fact]
        public void Task_Multiply_TwoNumber()
        {
            // Arrange  
            double num1 = 4.1;
            double num2 = 2;
            double expectedValue = 8.2;

            // Act  
            double sub = Calculator.Program.Multiplication(num1, num2);

            //Assert  
            Assert.Equal(expectedValue, sub, 1);
        }

        [Fact]
        public void Task_Multiply_TwoNumber1()
        {
            // Arrange  
            double num1 = -4;
            double num2 = 2;
            //double expectedValue = -8;

            // Act  
            //double sub = Calculator.Program.Multiplication(num1, num2);

            //Assert  
            //Assert.Equal(expectedValue, sub, 1);
            Assert.Equal(num1 * num2, Calculator.Program.Multiplication(num1, num2));
        }
        [Fact]
        public void Task_Division_TwoNumber()
        {
            // Arrange  
            double num1 = 4.1;
            double num2 = 2;
            double expectedValue = 2.05;

            // Act  
            double sub = Calculator.Program.Division(num1, num2);

            //Assert  
            Assert.Equal(expectedValue, sub, 1);
        }

        [Fact]
        public void Task_Division_TwoNumber1()
        {
            // Arrange  
            double num1 = -4;
            double num2 = 0;
            //string expectedValue = "cant divide with zero";
            double expectedValue = 0;

            // Act  
            double sub = Calculator.Program.Division(num1, num2);

            //Assert  
            Assert.Equal(expectedValue, sub, 1);
        }
        [Fact]
        public void Task_Addition_Array()
        {
            //Arrange
            int[] num = new number;
            int[] number = { 1, 2, 3, 4, 5 };
            int expectedValue = 15;


            //Act
            //double z = new z + z;

            for (int i=0; i <= num; i++)
            {
                double sub = Calculator.Program.Addition[i + i+];
                double sub = new sub + sub;
            }
            //double sub = Calculator.Program.Addition.Array(num);

            //Assert
            Assert.Equal(expectedValue, sub);


        }
        [Fact]
        public void Task_Substraction_Array()
        {
            //Arrange
            double[] num = { 1, 2, 3, 4, 5 };
            double expectedValue = -13;


            //Act
            //double z = new z + z;

            for (int i = 0; i <= num; i++)
            {
                double sub = Calculator.Program.Substraction[i];
                double sub = sub - new sub;
            }
            //double sub = Calculator.Program.Addition.Array(num);

            //Assert
            Assert.Equal(expectedValue, sub);


        }
    }
}
