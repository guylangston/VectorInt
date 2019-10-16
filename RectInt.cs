using System.Collections;
using System.Collections.Generic;

namespace VectorInt
{

    public interface IRectInt : IEnumerable<VectorInt2>
    {
        int X { get; set; }
        int Y { get; set; }
        int W { get; set; }
        int H { get; set; }

        // Top
        VectorInt2 TL { get; }
        VectorInt2 TM { get; }
        VectorInt2 TR { get; }
        
        // Middle
        VectorInt2 ML { get; }
        VectorInt2 C { get; }
        VectorInt2 MR { get; }
        
        // Bottom
        VectorInt2 BL { get; }
        VectorInt2 BM { get; }
        VectorInt2 BR { get; }
    }

    public class RectInt : IRectInt
    {
        public RectInt(int x, int y, int w, int h)
        {
            X = x;
            Y = y;
            W = w;
            H = h;
        }

        public RectInt(VectorInt2 size)
        {
            X = 0;
            Y = 0;
            W = size.X;
            H = size.Y;
        }

        public int X { get; set; }
        public int Y { get; set; }
        public int W { get; set; }
        public int H { get; set; }
        
        public VectorInt2 Size => new VectorInt2(W, H);
        
        public VectorInt2 TL => (X, Y);
        public VectorInt2 TM => (X + W/2, Y);
        public VectorInt2 TR => (X + W, Y);
        
        public VectorInt2 ML => (X, Y + H/2);
        public VectorInt2 C  => (X + W/2, Y + H/2);
        public VectorInt2 MR => (X + W, Y + H/2);
        
        public VectorInt2 BL => (X, Y + H);
        public VectorInt2 BM => (X + W/2, Y + H);
        public VectorInt2 BR => (X + W, Y + H);
        
        
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        public IEnumerator<VectorInt2> GetEnumerator()
        {
            for (var xx = X; xx < X + W; xx++)
            for (var yy = Y; yy < Y + H; yy++)
                yield return new VectorInt2(xx, yy);
        }

        public static RectInt CenterAt(VectorInt2 at, RectInt rect)
        {
            var half = rect.Size / new VectorInt2(2, 2);
            return new RectInt(at.X - half.X, at.Y - half.Y, rect.W, rect.H);
        }
    }
}