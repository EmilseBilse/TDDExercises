using WeatherExercise2;
using Xunit;
namespace WeatherExercisesTest
{
    public class WeatherTests
    {
        [Fact]
        public void TrueCloudBurst()
        {
            //Arrange
            ICloudburst cb = new Cloudburst();
            double[] rain = {0, 0, 0, 1, 3, 4, 5, 2, 2, 0, 1, 4, 2, 2};
            //Act
            int expected = 4;
            
            //Assert
            Assert.Equal(expected, cb.ContainsCloudburst(rain));
        }
        
        [Fact]
        public void FalseCloudBurst()
        {
            //Arrange
            ICloudburst cb = new Cloudburst();
            double[] rain = {2,1,2,1,1,1,3,1,1,3,1,1,1,2};
            //Act
            int expected = -1;
            
            //Assert
            Assert.Equal(expected, cb.ContainsCloudburst(rain));
        }
        
        [Fact]
        public void FalseHeavyRain()
        {
            //Arrange
            ICloudburst cb = new Cloudburst();
            double[] rain = {1,0,0,2,1,1,0,0,0,0,1,1,0,1,0,0,2,1};
            //Act
            int expected = -1;
            
            //Assert
            Assert.Equal(expected, cb.ContainsHeavyRain(rain));
        }
        
        [Fact]
        public void TrueHeavyRain()
        {
            //Arrange
            ICloudburst cb = new Cloudburst();
            double[] rain = {1,0,0,2,1,1,0,0,0,0,1,1,0,1,2,0,2,1};
            //Act
            int expected = 3;
            
            //Assert
            Assert.Equal(expected, cb.ContainsHeavyRain(rain));
        }
        
        
        
    }
}