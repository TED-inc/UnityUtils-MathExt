using UnityEngine;
using TEDinc.Utils.MathExt.Vectors;

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
        public static Direction GetByDifference(Vector2 differene) =>
            GetByDifference(differene.x, differene.y);

        public static Direction GetByDifference(float x, float y)
        {
            if (x > 0.01f)
                return Direction.Right;
            else if (x < -0.01f)
                return Direction.Left;
            else if (y > 0.01f)
                return Direction.Up;
            else if (y < -0.01f)
                return Direction.Down;
            else
                return Direction.None;
        }

        public static Direction GetRotationTrend(Direction from, Direction to)
        {
            if (from == to || from == Direction.None || to == Direction.None)
                return Direction.None;
            else
                return GetTrend(from, to);
        }

        public static Direction GetTrend(Direction from, Direction to)
        {
            Vector2Int fromV = GetByDirection(from);
            Vector2Int toV = GetByDirection(to);

            if (from == to)
                return from;
            if (fromV + toV == Vector2Int.zero)
                return Direction.None;

            bool isUpOrDownInFrom = fromV.y != 0;
            Direction upOrDown = isUpOrDownInFrom ? from : to;
            Direction leftOrRight = isUpOrDownInFrom ? to : from;

            if (upOrDown == Direction.Up)
                return isUpOrDownInFrom ? leftOrRight : Invert(leftOrRight);
            else
                return isUpOrDownInFrom ? Invert(leftOrRight) : leftOrRight;

        }

        public static Direction Invert(Direction direction) =>
            GetByDifference(GetByDirection(direction) * -1);


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
