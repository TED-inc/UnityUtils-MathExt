using System;
using UnityEngine;

namespace TEDinc.Utils.MathExt.ColorExt
{
    [Serializable]
    public struct ColorHSV
    {
        public ushort h, s, v;
        public const ushort maxH = 360;
        public const ushort maxSV = 256;
        public float H 
        {
            get => ColorHSVUtils.ConvertH(h);
            set => h = ColorHSVUtils.ConvertH(value);
        }
        public float S
        {
            get => ColorHSVUtils.ConvertSV(s);
            set => s = ColorHSVUtils.ConvertSV(value);
        }
        public float V
        {
            get => ColorHSVUtils.ConvertSV(v);
            set => v = ColorHSVUtils.ConvertSV(value);
        }


        public ColorHSV(Color color)
        {
            this.h = this.s = this.v = 0;
            float h, s, v;
            Color.RGBToHSV(color, out h, out s, out v);
            H = h;
            S = s;
            V = v;
        }
            

        public ColorHSV(float h, float s, float v)
        {
            this.h = this.s = this.v = 0;
            H = h;
            S = s;
            V = v;
        }

        public ColorHSV(ushort h, ushort s, ushort v)
        {
            this.h = h;
            this.s = s;
            this.v = v;
        }


        public static Vector3 operator *(ColorHSV color, float f) =>
            new Vector3(color.H, color.S, color.V) * f;

        public static Vector3Int operator -(ColorHSV a, ColorHSV b) =>
            new Vector3Int(ColorHSVUtils.CirculeDiff(a.h, b.h, maxH), a.s - b.s, a.v - b.v);

        public static implicit operator Color(ColorHSV c) => Color.HSVToRGB(c.H, c.S, c.V);
    }
}
