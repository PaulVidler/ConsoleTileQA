using System;
using System.Collections.Generic;
using System.Text;

namespace TileQA
{

    enum TileState { notChecked, checkedOK, inProgress, resupply }

    enum Colour { white, green, orange, red };

    class Tile
    {
        // Properties:
        public TileState ThisTileState { get; set; }
        public Colour TileColour { get; set; }
        public int TileSideLength { get; set; }
        public string TileName { get; set; }

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
    }
}
