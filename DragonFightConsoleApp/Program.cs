using DragonFightLib;

namespace DragonFightConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            List<Character> fellowShip = new List<Character>();

            Warrior Stasio = new Warrior("Rafcio");
            Archer Jasio = new Archer("Adaś");
            Wizard Grzesio = new Wizard("Grzesio");

            fellowShip.Add(Stasio);
            fellowShip.Add(Jasio);
            fellowShip.Add(Grzesio);

            Dragon dragon = new Dragon() { Name = "Smaug", Level = 15, Experience = 50, Strength = 100, Skill = 10, Inteligance = 40, NumOfMaxHelthPoints = 600, NumOfActualHelthPoints = 600, Damage = 60, Resistance = 10 };

            dragon.OnFireAttack += (intensity) =>
            {
                Console.WriteLine("Smok zionął ogniem o intensywności: " + intensity);
                foreach (Character c in fellowShip)
                {
                    c.NumOfActualHelthPoints -= intensity;
                }
            };



            //dragon.FireAttack();

            //Stasio.HPotion();

            //Stasio.ExperianceIncrese(1000);


            int RoundCounter = 1;
            while (true)
            {
                //foreach (Character c in fellowShip)
                //{
                //    if (c.CheckIsDead())
                //    {
                //        fellowShip.Remove(c);
                //        Console.ForegroundColor = ConsoleColor.Red;
                //        Console.WriteLine(" Bohater " + c.Name + " został pokonany przez smoka !");
                //        Console.ForegroundColor = ConsoleColor.White;
                //    }
                //}

                for (int i = fellowShip.Count - 1; i >= 0; i--)
                {
                    Character c = fellowShip[i];
                    if (c.CheckIsDead())
                    {
                        fellowShip.RemoveAt(i);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Bohater " + c.Name + " został pokonany przez smoka!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }


                if (fellowShip.Count == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" Smok pokonał drużynę !!!");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }

                if (dragon.CheckIsDead())
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(" Drużyna pokonała smoka !!!");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }

                Console.WriteLine($"---------------------- RUNDA {RoundCounter} ----------------------");
                RoundCounter++;
                OneRound(dragon, fellowShip);

            }

        }

        public static void OneRound(Dragon dragon, List<Character> fellowShip)
        {
            int attackIntense = 0;
            foreach (var c in fellowShip)
            {
                c.ExperianceIncrese(300);
                c.HPotion();
                dragon.TakenDamage(c.DemagePerRound());
                attackIntense += c.DemagePerRound();
            }
            Console.WriteLine($"Dzielna drużyna zadaje smokowi {attackIntense} punktów obrażeń");

            dragon.FireAttack();
        }
    }
}