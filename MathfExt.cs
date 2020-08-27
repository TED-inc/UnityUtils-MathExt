using UnityEngine;

namespace TEDinc.Utils.MathExt
{
    public static class MathfExt
    {
        public static float DivisionModulo(float f, float d)
        {
            if (f < 0)
                f += Mathf.CeilToInt(Mathf.Abs(f) / d) * d;

            return f % d;
        }

        public static int DivisionModulo(int i, int d)
        {
            if (i < 0)
                i += (Mathf.Abs(i) / d) * d;

            return i % d;
        }

        public static float Blend01(float a, float b, float t) =>
             a * (1f - t) + b * t;
    }
}
