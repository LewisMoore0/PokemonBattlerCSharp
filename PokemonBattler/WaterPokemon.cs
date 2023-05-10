using System;
namespace PokemonBattler
{
	public class WaterPokemon : Pokemon
	{
        public new string name;
        public new int health;
        public new int attackDamage;
        public new string move;
        public string type;

        public WaterPokemon(string Name, int Health, int AttackDamage, string Move = "Tackle") : base(Name, Health, AttackDamage, Move)
        {
            name = Name;
            health = Health;
            attackDamage = AttackDamage;
            move = Move;
            type = "Water";
        }
    }
}

