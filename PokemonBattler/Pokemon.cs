using System;
namespace PokemonBattler
{
	public class Pokemon
	{
		public string name;
		public int health;
		public int attackDamage;
		public string move;

		public Pokemon(string Name, int Health, int AttackDamage, string Move = "Tackle")
		{
			name = Name;
			health = Health;
			attackDamage = AttackDamage;
			move = Move;
		}

        public int Health
        {
            get => health;
            set => health = value;
        }

        public void takeDamage(int damage)
		{
			Health = health -= damage;
		}

		public int attack()
		{
			return attackDamage;
		}

		public bool hasFainted()
		{
			if (health == 0)
			{
				return true;
			}

			return false;
		}

	}
}

