using System;
using GradingScale;
using Xunit;

namespace GradingScaleTest
{
    public class GradingTest
    {
        private IGrading g;
        public GradingTest()
        {
            g = new Grading();
        }

        [Theory]
        [InlineData(0,-3)]
        [InlineData(1,-3)]
        [InlineData(5,-3)]
        [InlineData(6,0)]
        [InlineData(7,0)]
        [InlineData(49,0)]
        [InlineData(50,2)]
        [InlineData(51,2)]
        [InlineData(59,2)]
        [InlineData(60,4)]
        [InlineData(61,4)]
        [InlineData(79,4)]
        [InlineData(80,7)]
        [InlineData(81,7)]
        [InlineData(84,7)]
        [InlineData(85,10)]
        [InlineData(86,10)]
        [InlineData(94,10)]
        [InlineData(95,12)]
        [InlineData(96,12)]
        [InlineData(100,12)]
        public void GradeTest(int percent, int expectedGrade)
        {
            //Arrange

            //Act
            int actual = g.ToGrade(percent);
            
            //Assert
            Assert.Equal(expectedGrade,actual);
        }
        
        [Theory]
        [InlineData(-2)]
        [InlineData(101)]
        public void GradeTestException(int percent)
        {
            //Arrange

            //Act
            
            //Assert
            Assert.Throws<ArgumentException>(() => g.ToGrade(percent));

        }
    }
}