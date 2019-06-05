using System;
using System.Numerics;

namespace TileQA.Types
{
    public class TcTileRect
    {
        public Vector2 Top     { get; set; }
        public Vector2 Left    { get; set; }
        public Vector2 Right   { get; set; }
        public Vector2 Bottom  { get; set; }

        public Vector2 TileSize => Left - Right;

        public TcTileRect(Geometry lpGeometry)
        {
            if (lpGeometry == null || lpGeometry.Points.Count < 5)
            {
                throw new Exception("Error, Unsupported Geometry type.");
            }

            Top    = lpGeometry.Points[0];
            Left   = lpGeometry.Points[1];
            Right  = lpGeometry.Points[2];
            Bottom = lpGeometry.Points[3];
        }
    }
}
