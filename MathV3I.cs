using System;
using UnityEngine;

namespace TEDinc.Utils.MathExt.Vectors
{
    public static class MathV3I
    {
        public static Vector3Int Abs(Vector3Int v) =>
            new Vector3Int(Math.Abs(v.x), Math.Abs(v.y), Math.Abs(v.z));
    }
}
