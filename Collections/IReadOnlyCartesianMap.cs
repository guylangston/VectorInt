using System.Collections.Generic;

namespace VectorInt.Collections
{
    public interface IReadOnlyCartesianMap<T> : IEnumerable<(VectorInt2 Position, T Value)>
    {
        int Width { get; }
        int Height { get; }
        VectorInt2 Size { get; }
        
        T this[int x, int y] { get; }
        T this[VectorInt2 p] { get; }
        
        IEnumerable<T> ForEachValue();
    }
}