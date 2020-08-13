using UnityEngine;

namespace TEDinc.Utils.MathExt.ColorExt
{
    public struct ColorHSV
    {
        public float h, s, v;

        public ColorHSV(Color color) =>
            Color.RGBToHSV(color, out h, out s, out v);

        public ColorHSV(float h, float s, float v)
        {
            this.h = h;
            this.s = s;
            this.v = v;
        }


        public static Vector3 operator *(ColorHSV color, float f) =>
            new Vector3(color.h, color.s, color.v) * f;

        public static ColorHSV operator -(ColorHSV a, ColorHSV b) =>
            new ColorHSV(CirculeDiff(a.h, b.h), a.s - b.s, a.v - b.v);

        public static implicit operator Color(ColorHSV c) => Color.HSVToRGB(c.h, c.s, c.v);

        private static float CirculeDiff(float a, float b)
        {
            float min = Mathf.Min(a, b);
            float max = Mathf.Max(a, b);

            if (max - min > 0.5f)
                return (1f - max + min) * Mathf.Sign(b - a);
            else
                return (max - min) * Mathf.Sign(a - b);
        }

        public override string ToString()
        {
            return $"({h}, {s}, {v})";
        }
    }
}
