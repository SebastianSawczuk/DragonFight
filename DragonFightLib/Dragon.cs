namespace DragonFightLib
{
    public class Dragon : Character
    {
        public delegate void FireAttackIntensity(int intensity);
        public event FireAttackIntensity OnFireAttack;

        public int FireAttack()
        {
            int intensity = (int)Math.Round((double)(Strength * 2 + Inteligance / 2) * Level / 30);
            OnFireAttack?.Invoke(intensity);
            return intensity;
        }


    }
}
