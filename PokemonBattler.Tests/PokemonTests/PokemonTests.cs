using PokemonBattler.Pokemon;
using Xunit;
using FluentAssertions;

namespace PokemonBattler.Tests.PokemonTests;

public class PokemonTest
{
    [Fact]
    public void shouldHaveNameProperty()
    {
        var lewis = new PokemonClass();
        var result = lewis.testFunction();

        result.Should().Be("Hi!");
    }
}

