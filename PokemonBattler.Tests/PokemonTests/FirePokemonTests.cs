using PokemonBattler;
using Xunit;
using FluentAssertions;

namespace PokemonBattler.Tests.PokemonTests;

	public class FirePokemonTests
	{
		[Fact]
		public void shouldHaveTypeAttributeOfFire()
		{
			var pokemon = new FirePokemon("Lewis", 100, 25);

			pokemon.type.Should().Be("Fire");
		}

		[Fact]
		public void isEffectiveAgainstReturnsTrueWhenGivenGrassPokemon()
		{

			var pokemon = new FirePokemon("Lewis", 100, 25);
			var grassPokemon = new GrassPokemon("Lewis", 100, 25);

			pokemon.isEffectiveAgainst(grassPokemon).Should().Be(true);
		}

		[Fact]
		public void isWeakAgainstReturnsTrueWhenGivenWaterPokemon()
		{
			var pokemon = new FirePokemon("Lewis", 100, 25);
			var waterPokemon = new WaterPokemon("Lewis", 100, 25);

			pokemon.isWeakAgainst(waterPokemon).Should().Be(true);
		}

}


