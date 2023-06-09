﻿using System;
using System.Xml.Linq;

namespace PokemonBattler
{
    public class GrassPokemon : Pokemon
    {
        public new string name;
        public new int health;
        public new int attackDamage;
        public new string move;
        public string type;

        public GrassPokemon(string Name, int Health, int AttackDamage, string Move = "Tackle") : base(Name, Health, AttackDamage, Move)
        {
            name = Name;
            health = Health;
            attackDamage = AttackDamage;
            move = Move;
            type = "Grass";
        }
    }
}

