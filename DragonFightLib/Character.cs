namespace DragonFightLib
{
    public abstract class Character : IComparable<Character>
    {
        protected Character()
        {
        }

        public string Name { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        public int Strength { get; set; }
        public int Skill { get; set; }
        public int Inteligance { get; set; }
        public int NumOfMaxHelthPoints { get; set; }
        public int NumOfActualHelthPoints { get; set; }
        public int Damage { get; set; }
        public int Resistance { get; set; }

        protected Character(string name, int level, int experience, int strength, int skill, int inteligance, int numOfMaxHelthPoints, int numOfActualHelthPoints, int damage, int resistance)
        {
            Name = name;
            Level = level;
            Experience = experience;
            Strength = strength;
            Skill = skill;
            Inteligance = inteligance;
            NumOfMaxHelthPoints = numOfMaxHelthPoints;
            NumOfActualHelthPoints = numOfActualHelthPoints;
            Damage = damage;
            Resistance = resistance;
        }

        public virtual string ToString()
        {
            return $"Imie: {Name} /n" +
                $"Poziom: {Level} /n" +
                $"Doświadczenie: {Experience} /n" +
                $"Siła: {Strength} /n" +
                $"Zręczność: {Skill} /n" +
                $"Inteligencja: {Inteligance} /n" +
                $"HP: {NumOfActualHelthPoints}/{NumOfMaxHelthPoints} /n" +
                $"Obrażenia: {Damage} /n" +
                $"Odporność na obrażenia: {Resistance} /n";
        }

        public virtual void Arming(int value)
        {
            this.Damage += value;
        }

        public virtual void PuttingOnArmor(int value)
        {
            this.Resistance += value;
        }

        public virtual int DemagePerRound()
        {
            return this.Damage;
        }

        public virtual void TakenDamage(int value)
        {
            this.NumOfActualHelthPoints -= value - (value * (Resistance / 100));
        }

        public virtual void LevelUp()
        {
            Level++;
            Experience += 15;
            NumOfMaxHelthPoints += 20;
        }

        public int CompareTo(Character? other)
        {
            throw new NotImplementedException();
        }
    }

}