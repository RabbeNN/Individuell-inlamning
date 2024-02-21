namespace TestOfStatistics
{
    public class UnitTestOfStatistics
    {
        [Fact]
        public void TestMaximum()
        {
            //Arrange
            int Expected = 378;
            //Act
            int Actual = Statistics.Statistics.Maximum();
            //Assert
            Assert.Equal(Expected, Actual);
        }
        [Fact]
        public void TestMinimum()
        {   //Arrange
            int Expected = -42;
            //Act
            int Actual = Statistics.Statistics.Minimum();
            //Assert
            Assert.Equal(Expected, Actual);
        }
        [Fact]
        public void TestMean()
        {
            //För att köra detta testet korrekt var jag tvungen att fixa metoden i Statistics. Double.Total ska vara = 0;.
            //Arrange
            double Expected = 167.3088;
            //Act
            double Actual = Statistics.Statistics.Mean();
            //Assert
            Assert.Equal(Expected, Actual);
        }
        [Fact]
        public void TestMedian()
        {
            //Arrange
            double Expected = 165;
            //Act
            double Actual = Statistics.Statistics.Median();
            //Assert
            Assert.Equal(Expected, Actual);
        }
        [Fact]
        public void TestMode()
        {
            //Arrange
            IEnumerable<int> Expected = [228, 87, 31];
            //Act
            IEnumerable<int> Actual = Statistics.Statistics.Mode();
            //Assert
            Assert.Equal(Expected, Actual);
        }
        [Fact]
        public void TestRange()
        {
            //Arrange
            int Expected = 420;
            //Act
            int Actual = Statistics.Statistics.Range();
            //Assert
            Assert.Equal(Expected, Actual);
        }
        [Fact]
        public void TestStandardDeviation()
        {
            //Arrange
            double Expected = 122.3;
            //Act
            double Actual = Statistics.Statistics.StandardDeviation();
            //Assert
            Assert.Equal(Expected, Actual);
        }
    }
}