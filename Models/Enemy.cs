namespace ShadowWizardMath.Models
{
    public class Enemy
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Health { get; set; }
        public int Stage { get; set; }
        public int AttackPower { get; set; }
        public int ExperienceGained { get; set; }

        // Base constructor
        public Enemy(string name, string description, int health, int stage, int attack, int exp)
        {
            Name = name;
            Description = description;
            Health = health;
            Stage = stage;
            AttackPower = attack;
            ExperienceGained = exp;
        }
    }

    public class Goblin : Enemy
    {
        
        // Derived constructor for Goblin
        public Goblin(string name, string description, int health, int stage, int attack, int exp)
            : base(name, description, health, stage, attack, exp)
        {
            name = "Jeff";
            description = "A small green creature";
            health = 5;
            stage = 1;
            attack = 2;
            exp = 3;
        }
    }
}
