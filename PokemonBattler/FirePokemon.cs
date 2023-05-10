using System;
using System.Xml.Linq;

namespace PokemonBattler
{
	public class FirePokemon : Pokemon
	{
        public new string name;
        public new int health;
        public new int attackDamage;
        public new string move;
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

        public bool isWeakAgainst(WaterPokemon pokemon)
        {
            return pokemon.type == "Water" ? true : false;
        }

    }
}

