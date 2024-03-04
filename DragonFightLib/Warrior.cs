namespace DragonFightLib
{
    public class Warrior : Character
    {
        public Warrior(string name) : base(name, 1, 1, 1, 5, 1, 100, 100, 30, 15)
        {
            NumOfAttacsPerRound = 3;
        }
        public int NumOfAttacsPerRound { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"Liczba ataków na rundę: {NumOfAttacsPerRound}";
        }

        public override int DemagePerRound()
        {
            return Damage * NumOfAttacsPerRound;
        }

        public override void LevelUp()
        {
            base.LevelUp();
            this.Strength += 15;
            this.Skill += 5;
            this.Inteligance += 5;
            this.NumOfAttacsPerRound++;
        }
    }
}
