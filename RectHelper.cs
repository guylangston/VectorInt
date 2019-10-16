﻿namespace VectorInt
{
    public static class RectHelper
    {
        public static RectInt Inset(this IRectInt rect, int top, int right, int bottom, int left) 
            => new RectInt(rect.X + left, rect.Y + top, rect.W - right, rect.H - bottom);
        
        public static RectInt Outset(this IRectInt rect, int top, int right, int bottom, int left) 
            => new RectInt(rect.X - left, rect.Y - top, rect.W + right + left -1, rect.H + top + bottom -1);
        
    }
}