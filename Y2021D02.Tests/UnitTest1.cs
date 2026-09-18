namespace Y2021D02.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("(()())", 0)]
        [InlineData("((()))", 0)]
        [InlineData("(()))", -1)]
        [InlineData("(((", 3)]
        [InlineData("Hej från tomten", 0)]
        public void CountTomteFloor_KnownInputs_ReturnsExpected(string floors, int expected)
        {
            // Arrange
            var sut = new Tomte();

            // Act
            var actual = sut.CountTomteFloor(floors);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("(()())", -1)]
        [InlineData("((()))", -1)]
        [InlineData("(()))", 5)]
        [InlineData("(((", -1)]
        [InlineData("Hej från tomten", -1)]
        public void FindFirstNegativeFloor_KnownInputs_ReturnsExpected(string floors, int expected)
        {
            // Arrange
            var sut = new Tomte();

            // Act
            var actual = sut.FindFirstNegativeFloor(floors);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
