namespace DragonFightLib
{
    public class Archer : Character
    {
        public Archer(string name) : base(name, 1, 1, 1, 5, 1, 100, 100, 30, 15)
        {
            ChanceToDodgeAnAttack = 10;
        }

        public int ChanceToDodgeAnAttack { get; set; }

        public override void TakenDamage(int value)
        {

            if (RandomChanceToDoge())
            {
                base.TakenDamage(value);
            }
        }

        public bool RandomChanceToDoge()
        {
            Random random = new Random();
            //if (random.Next(1, 6) != 6) { return true; } else return false;
            return random.Next(1, 6) != 6 ? true : false;
        }

        public override void LevelUp()
        {
            base.LevelUp();
            Strength += 5;
            Skill += 15;
            Inteligance += 5;

            if (ChanceToDodgeAnAttack < 100)
            {
                ChanceToDodgeAnAttack += 5;
            }
        }

    }
}
