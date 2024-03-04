namespace DragonFightLib
{
    public class Wizard : Character
    {
        public Wizard(string name) : base(name, 1, 1, 1, 5, 1, 100, 100, 30, 15)
        {
            NumOfMaxManaPoints = 100;
            NumOfActualManaPoints = 100;
        }
        public int NumOfMaxManaPoints { get; set; }
        public int NumOfActualManaPoints { get; set; }

        public override void LevelUp()
        {
            base.LevelUp();
            Strength += 5;
            Skill += 5;
            Inteligance += 15;
            NumOfMaxManaPoints += 10;
        }
    }
}
