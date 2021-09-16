using SortedBag;
using Xunit;

namespace SortedBagTest
{
    public class BagTest
    {
        [Theory]
        [InlineData(24)]
        [InlineData(10)]
        [InlineData(99)]
        public void AddTesting(int x)
        {
            //Arrange
            IBag b = new Bag();
            
            //Act
            b.Add(x);
            
            //Assert
            Assert.Contains(x,b.GetList());
        }

        [Theory]
        [InlineData(24,49)]
        [InlineData(99,149)]
        public void RemoveTest(int x, int y)
        {
            //Arrange
            IBag b = new Bag();
            
            //Act
            b.Add(x);
            b.Add(y);
            b.Remove();
            
            //Assert
            Assert.DoesNotContain(x,b.GetList());
        }

        [Fact]
        public void SizeTest()
        {
            //Arrange
            IBag b = new Bag();
            
            //Act
            b.Add(22);
            b.Add(26);
            b.Add(28);
            b.Add(62);
            b.Add(92);

            int expected = 5;

            //Assert
            Assert.Equal(expected,b.Size());
        }
        
        [Theory]
        [InlineData(24 ,55, 1, 85)]
        [InlineData(10,53,7,12)]
        [InlineData(99,2,0,43)]
        public void GetLowestTest(int x,int y, int low, int z)
        {
            //Arrange
            IBag b = new Bag();
            
            //Act
            b.Add(x);
            b.Add(y);
            b.Add(low);
            b.Add(z);

            //Assert
            Assert.Equal(low,b.GetLowest());
        }
    }
}