using TileQA.Types;

namespace TileQA
{
    enum TileState { notChecked, checkedOK, inProgress, resupply }

    enum Colour { white, green, orange, red };

    class TcTile
    {     
        public TileState ThisTileState { get; set; }
        public Colour TileColour { get; set; }
        public string TileName { get; set; }
        public TcTileRect Rect { get; set; }

        public int TileSideLength => (int)(Rect?.TileSize.Length() ?? 0);

        public void SetTileColour()
        {
            switch (ThisTileState)
            {
                case TileState.notChecked:
                    TileColour = Colour.white;
                    break;
                case TileState.checkedOK:
                    TileColour = Colour.green;
                    break;
                case TileState.inProgress:
                    TileColour = Colour.orange;
                    break;
                case TileState.resupply:
                    TileColour = Colour.red;
                    break;
                default:
                    break;
            }
        }

        public override string ToString()
        {
            return string.Format("[{0}-{1}]", TileName, ThisTileState);
        }
    }
}
