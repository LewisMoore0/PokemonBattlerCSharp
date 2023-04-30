using PokemonBattler;
using Xunit;
using FluentAssertions;

namespace PokemonBattler.Tests.PokemonTests;

public class PokemonTest
{
    [Fact]
    public void shouldHaveNameProperty()
    {
        var lewis = new Pokemon();
        var result = lewis.testFunction();

        result.Should().Be("Hi!");
    }
}

