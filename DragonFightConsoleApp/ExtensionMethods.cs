using DragonFightLib;

namespace DragonFightConsoleApp
{
    public static class ExtensionMethods
    {
        public static void HPotion(this Character obj)
        {
            int potionValue = obj.NumOfMaxHelthPoints - obj.NumOfActualHelthPoints;
            obj.NumOfActualHelthPoints += potionValue;
        }

        public static bool CheckIsDead(this Character character)
        {
            return character.NumOfActualHelthPoints < 1;
        }

        ///<summary>
        ///    Metoda służąca do podnoszenia doświadczenia postaci
        ///</summary>
        public static void ExperianceIncrese(this Character character, int i)
        {
            character.Experience += i;
            while (character.Experience > 100)
            {
                character.Experience -= 100;
                character.LevelUp();
            }
        }

        public static void ManaPotion(this Wizard wizard)
        {
            int potionValue = wizard.NumOfMaxManaPoints - wizard.NumOfActualManaPoints;
            wizard.NumOfActualManaPoints += potionValue;
        }

        public static void UnArming(this Character character, int i)
        {
            character.Damage -= i;
        }

        public static void RemovingArmor(this Character character, int i)
        {
            character.Resistance -= i;
        }
    }
}
