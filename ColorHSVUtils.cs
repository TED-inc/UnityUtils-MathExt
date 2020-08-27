using System;
using UnityEngine;

namespace TEDinc.Utils.MathExt.ColorExt
{
    public static class ColorHSVUtils
    {

        #region Convert fields
        public static float ConvertH(int h) =>
            MathfExt.DivisionModulo(h, ColorHSV.maxH) / (float)ColorHSV.maxH;

        public static ushort ConvertH(this float h) =>
            (ushort)(MathfExt.DivisionModulo(h, 1f) * ColorHSV.maxH);

        public static float ConvertSV(int sv) =>
            MathfExt.DivisionModulo(sv, ColorHSV.maxSV) / (float)ColorHSV.maxSV;

        public static ushort ConvertSV(this float sv) =>
            (ushort)(MathfExt.DivisionModulo(sv, 1f) * ColorHSV.maxSV);

        #endregion

        public static int CirculeDiff(ushort from, ushort to, ushort circuit)
        {
            if ((to >= from && to - from < circuit / 2)
                || (from >= to && from - to < circuit / 2))
                return to - from;
            else if (to > from)
                return -circuit - from + to;
            else
                return +circuit - from + to;
        }

        public static Vector3 ConvertTo01(Vector3Int color) =>
            new Vector3(ConvertH(color.x), ConvertSV(color.y), ConvertSV(color.z));

        public static Vector3 ConvertTom1p1(Vector3Int color) =>
            new Vector3(
                color.x / (float)ColorHSV.maxH, 
                color.y / (float)ColorHSV.maxSV, 
                color.z / (float)ColorHSV.maxSV);

        public static string ToString(this ColorHSV color)
        {
            return $"({color.h}, {color.s}, {color.v})";
        }
    }
}
