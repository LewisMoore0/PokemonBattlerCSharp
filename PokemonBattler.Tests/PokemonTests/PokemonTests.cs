using PokemonBattler;
using Xunit;
using FluentAssertions;

namespace PokemonBattler.Tests.PokemonTests;

public class PokemonTest
{
    [Fact]
    public void shouldHavePropertiesOnInstantiation()
    {
        var pokemon = new Pokemon("Lewis", 100, 25, "HeadButt");

        pokemon.name.Should().Be("Lewis");
        pokemon.Health.Should().Be(100);
        pokemon.attackDamage.Should().Be(25);
        pokemon.move.Should().Be("HeadButt");
    }

    [Fact]
    public void shouldHaveMovePropertySetByDefault()
    {
        var pokemon = new Pokemon("Lewis", 100, 25);

        pokemon.move.Should().Be("Tackle");

    }

    [Fact]
    public void takeDamageShouldReducePokemonsHealth()
    {
        var pokemon = new Pokemon("Lewis", 100, 25);
        pokemon.takeDamage(50);

        pokemon.Health.Should().Be(50);
    }

    [Fact]
    public void attackReturnsAttackDamage()
    {
        var pokemon = new Pokemon("Lewis", 100, 25);

        pokemon.attack().Should().Be(25);
    }

    [Fact]
    public void hasFaintedReturnsTrueIfHealthIsZero()
    {
        var pokemon = new Pokemon("Lewis", 0, 25);

        pokemon.hasFainted().Should().Be(true);

    }

    [Fact]
    public void hasFaintedReturnsFalseWhenOverZero()
    {
        var pokemon = new Pokemon("Lewis", 100, 25);

        pokemon.hasFainted().Should().Be(false);
    }
}

