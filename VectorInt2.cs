using System;

namespace VectorInt
{
    public struct VectorInt2 : IEquatable<VectorInt2>
    {
        public VectorInt2(int x, int y) : this()
        {
            X = x;
            Y = y;
        }
        
        public VectorInt2(int scalar) : this()
        {
            X = scalar;
            Y = scalar;
        }

        public void Deconstruct(out int x, out int y)
        {
            x = X;
            y = Y;
        }


        public int X { get; set; }
        public int Y { get; set; }

        public bool IsUnit => this == Up || this == Down || this == Left || this == Right;
        public bool IsZero => X == 0 && Y == 0;

        public static readonly VectorInt2 Zero = new VectorInt2(0);
        public static readonly VectorInt2 Unit = new VectorInt2(1);
        public static readonly VectorInt2 MinValue = new VectorInt2(int.MinValue);
        public static readonly VectorInt2 MaxValue = new VectorInt2(int.MaxValue);
        
        public static readonly VectorInt2 Up     = new VectorInt2(0, -1);
        public static readonly VectorInt2 Down   = new VectorInt2(0, 1);
        public static readonly VectorInt2 Left   = new VectorInt2(-1, 0);
        public static readonly VectorInt2 Right  = new VectorInt2(1, 0);
        public static readonly VectorInt2[] Directions = {Up, Down, Left, Right};

        public static VectorInt2 operator +(VectorInt2 lhs, VectorInt2 rhs) => new VectorInt2(lhs.X + rhs.X, lhs.Y + rhs.Y);
        public static VectorInt2 operator -(VectorInt2 lhs, VectorInt2 rhs) => new VectorInt2(lhs.X - rhs.X, lhs.Y - rhs.Y);
        public static VectorInt2 operator *(VectorInt2 lhs, VectorInt2 rhs) => new VectorInt2(lhs.X * rhs.X, lhs.Y * rhs.Y);
        public static VectorInt2 operator /(VectorInt2 lhs, VectorInt2 rhs) => new VectorInt2(lhs.X / rhs.X, lhs.Y / rhs.Y);
        public static bool operator ==(VectorInt2 lhs, VectorInt2 rhs) => lhs.Equals(rhs);
        public static bool operator !=(VectorInt2 lhs, VectorInt2 rhs) => !lhs.Equals(rhs);
        public static implicit operator  VectorInt2((int x, int y) tuple) => new VectorInt2(tuple.x, tuple.y);
        
        public bool Equals(VectorInt2 other) => X == other.X && Y == other.Y;

        public override bool Equals(object obj) => Equals((VectorInt2) obj);

        public override int GetHashCode() => X.GetHashCode() ^ Y.GetHashCode();

        public override string ToString() => $"({X},{Y})";
    }
}
