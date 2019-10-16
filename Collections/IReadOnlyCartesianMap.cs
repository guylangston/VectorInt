using System.Collections.Generic;

namespace VectorInt.Collections
{
    public interface IReadOnlyCartesianMap<T> : IEnumerable<(int x, int y, T value)>
    {
        int Width { get; }
        int Height { get; }
        VectorInt2 Size { get; }
        
        T this[int x, int y] { get; }
        T this[VectorInt2 p] { get; }

        IEnumerable<(VectorInt2 p, T v)> ForeachByVector();
        IEnumerable<T> ForeachValue();
    }
}