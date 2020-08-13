using System;

namespace TEDinc.Utils.MathExt.Rand
{
    public static class RandomExt
    {
        private static string randomChar = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz";
        public static Random Random
        { 
            get
            {
                if (random == null)
                    random = new Random();
                return random;
            }
            private set => random = value;
        }
        private static Random random;
        public static string NextString(this Random rand, int size)
        {
            string result = "";
            for (int i = 0; i < size; i++)
                result += randomChar[rand.Next(0, randomChar.Length)];
            return result;
        }

        public static string NextString(int size)
        {
            if (Random == null)
                Random = new Random();

            return Random.NextString(size);
        }
    }
}
