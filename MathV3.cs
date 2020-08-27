using System;
using UnityEngine;

namespace TEDinc.Utils.MathExt.Vectors
{
    public static class MathV3
    {
        public static Vector3 Abs(Vector3 v) =>
            new Vector3(Math.Abs(v.x), Math.Abs(v.y), Math.Abs(v.z));

        public static Vector3 Blend01(Vector3 a, Vector3 b, float t) =>
            a * (1f - t) + b * t;

        public static bool MoreOrEqualAll(Vector3 l, Vector3 r) =>
            l.x >= r.x && l.y >= r.y && l.z >= r.z;
    }
}
