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
    
    public interface ICartesianMap<T> : IReadOnlyCartesianMap<T>
    {
        new T this[int x, int y] { get; set; }
        new T this[VectorInt2 p] { get; set; }
    }
}