﻿using UnityEngine;

namespace TEDinc.Utils.MathExt.Enums
{
    public enum Direction
    {
        None,
        Up,
        Down,
        Right,
        Left
    }

    public static class DirectionUtility
    {
        public static Direction GetByDifference(Vector2 differene)
        {
            if (differene.x > 0.01f)
                return Direction.Right;
            else if (differene.x < -0.01f)
                return Direction.Left;
            else if (differene.y > 0.01f)
                return Direction.Up;
            else if (differene.y < -0.01f)
                return Direction.Down;
            else
                return Direction.None;
        }

        public static Vector2Int GetByDirection(Direction direction)
        {
            switch (direction)
            {
                case Direction.None:
                    return Vector2Int.zero;
                case Direction.Up:
                    return Vector2Int.up;
                case Direction.Down:
                    return Vector2Int.down;
                case Direction.Right:
                    return Vector2Int.right;
                case Direction.Left:
                    return Vector2Int.left;
                default:
                    return Vector2Int.zero;
            }
        }
    }
}
