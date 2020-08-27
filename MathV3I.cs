using System;
using UnityEngine;

namespace TEDinc.Utils.MathExt.Vectors
{
    public static class MathV3I
    {
        public static Vector3Int Abs(Vector3Int v) =>
            new Vector3Int(Math.Abs(v.x), Math.Abs(v.y), Math.Abs(v.z));

        public static Vector3Int Blend01(Vector3Int a, Vector3Int b, float t) =>
            FromV3(MathV3.Blend01(a, b, t));

        public static Vector3Int FromV3(Vector3 v) =>
            new Vector3Int((int)v.x, (int)v.y, (int)v.z);

        public static bool MoreOrEqualAll(Vector3Int l, Vector3Int r) =>
            l.x >= r.x && l.y >= r.y && l.z >= r.z;
    }
}
