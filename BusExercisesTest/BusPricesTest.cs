using Xunit;
using BusExercise1;
namespace BusExercisesTest

{
    public class BusPricesTest
    {
        [Fact]
        public void Below100KmUnder12Pass()
        {
            //Arrange
            IBusPrices bp = new BusPrices();
            
            //Act
            double fee = 130;
            double perKm = 3.2;
            int km = 30;
            int passengers = 4;
            double expected = km * perKm + fee;

            //Assert
            Assert.Equal(expected,bp.TotalCost(passengers, km));
        }
        
        [Fact]
        public void Below100KmOver12Pass()
        {
            //Arrange
            IBusPrices bp = new BusPrices();
            
            //Act
            double fee = 130;
            double perKm = 3.2;
            int km = 30;
            int passengers = 16;
            double expected = km * perKm + fee;

            //Assert
            Assert.Equal(expected,bp.TotalCost(passengers, km));
        }
        
        [Fact]
        public void Over100KmUnder12Pass()
        {
            //Arrange
            IBusPrices bp = new BusPrices();
            
            //Act
            double fee = 130;
            double perKm = 2.75;
            int km = 230;
            int passengers = 4;
            double expected = km * perKm + fee;

            //Assert
            Assert.Equal(expected,bp.TotalCost(passengers, km));
        }
        
        [Fact]
        public void Over100KmOver12Pass()
        {
            //Arrange
            IBusPrices bp = new BusPrices();
            
            //Act
            double fee = 130;
            double perKm = 3.0;
            int km = 230;
            int passengers = 20;
            double expected = km * perKm + fee;

            //Assert
            Assert.Equal(expected,bp.TotalCost(passengers, km));
        }
        
        [Fact]
        public void Over500KmOver12Pass()
        {
            //Arrange
            IBusPrices bp = new BusPrices();
            
            //Act
            double fee = 130;
            double perKm = 2.25;
            int km = 550;
            int passengers = 20;
            double expected = km * perKm + fee;

            //Assert
            Assert.Equal(expected,bp.TotalCost(passengers, km));
        }
        
        [Fact]
        public void Over500KmUnder12Pass()
        {
            //Arrange
            IBusPrices bp = new BusPrices();
            
            //Act
            double fee = 130;
            double perKm = 2.25;
            int km = 550;
            int passengers = 3;
            double expected = km * perKm + fee;

            //Assert
            Assert.Equal(expected,bp.TotalCost(passengers, km));
        }
    }
}