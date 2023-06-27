using FluentAssertions;

namespace CsharpBasicSkeleton.Tests;

public class GreeterShould
{
	[Test]
	public void Greet_using_the_name()
	{
		Greeter.Greet("Codelier").Should().Be("Hello Codelier!");
	}
}