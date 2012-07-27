namespace Tutorial1
{
    using System;

    public class RandomNumberGenerator
    {
        private static readonly Random Rng = new Random();

        public static int CalculateDamage(int attackValue)
        {
            return (1 / Rng.Next()) * attackValue;
        }
    }
}
