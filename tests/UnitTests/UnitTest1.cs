using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Testing_SalaryWithPositiveIntegers()
        {
            double wageRate = 11.25;
            int hours = 9;
            var expected = 101.25;
            var actual = calcSalary(wageRate, hours);
            Assert.Equal(expected,actual);
        }

        [Fact]
        public void Testing_SalaryWithNegativeIntegers()
        {
            double wageRate = -11.25;
            int hours = -1;
            var expected = 0;
            var actual = calcSalary(wageRate, hours);
            Assert.Equal(expected,actual);
        }

        [Theory]
        [InlineData(20.00,10,2)]
        [InlineData(0, -7,-5)]
        [InlineData(0, 0,0)]
        public void Is_CalcSalaryWithAllInputs(int exp, double wage, int hrs)
        {
 
            var actual = calcSalary(wage, hrs);
            Assert.Equal(exp,actual);
        }

        double calcSalary(double wageRate, int hours){
            if(hours <= 0 || wageRate <= 0){
              return 0;
            }
            else{
                return wageRate * hours;
            }
         }
    }
}
