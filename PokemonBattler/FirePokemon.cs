using System;
using System.Xml.Linq;

namespace PokemonBattler
{
	public class FirePokemon : Pokemon
	{
        public string name;
        public int health;
        public int attackDamage;
        public string move;
        public string type;

        public FirePokemon(string Name, int Health, int AttackDamage, string Move = "Tackle"): base(Name, Health, AttackDamage, Move)
        {
            name = Name;
            health = Health;
            attackDamage = AttackDamage;
            move = Move;
            type = "Fire";
        }


        public bool isEffectiveAgainst(GrassPokemon pokemon)
        {
            return pokemon.type == "Grass" ? true : false;
        }
    }
}

