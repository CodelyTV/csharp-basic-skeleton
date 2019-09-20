namespace test_csharp_basic_skeleton
{
    using csharp_basic_skeleton;
    using Xunit;

    public class GreeterShould
    {
        [Fact]
        public void Greet_HelloMessage_Receives()
        {
            Greeter greeter = new Greeter();
            Assert.Equal("Hello Jhon", greeter.Greet("Jhon"));
        }
    }
}