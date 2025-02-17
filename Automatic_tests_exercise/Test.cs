using SimpleApp;
using Xunit;

namespace SimpleAppTests
{
    public class ProgramTests
    {
        [Fact]
        public void TestAdd()
        {
            // Arrange
            var program = new Program();
            int a = 5;
            int b = 3;
            int expected = 8;

            // Act
            int result = program.Add(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestMain()
        {
            // Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            // Act
            Program.Main(new string[] { });

            // Assert
            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("Hello, World!", output);
        }
    }
}