using System;
using UnityEngine;

namespace TEDinc.Utils.MathExt.Vectors
{
    public static class MathV2I
    {
        public static Vector2Int Abs(Vector2Int v) =>
            new Vector2Int(Math.Abs(v.x), Math.Abs(v.y));

        public static Vector2Int Blend01(Vector2Int a, Vector2Int b, float t) =>
            FromV2(MathV3.Blend01((Vector2)a, (Vector2)b, t));

        public static Vector2Int FromV2(Vector2 v) =>
            new Vector2Int((int)v.x, (int)v.y);

        public static bool MoreOrEqualAll(Vector3Int l, Vector3Int r) =>
            l.x >= r.x && l.y >= r.y && l.z >= r.z;
    }
}
