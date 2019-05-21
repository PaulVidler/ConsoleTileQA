using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TileQA;

namespace TileQA
{
    class QAProject
    {
        public Collection<Tile> ProjectTiles = new Collection<Tile>();
        public bool ProjectComplete { get; set; } = false;
        private int _tileCount = 0;
        public int TileCount
        {
            get { return _tileCount; }
            set
            {
                _tileCount = ProjectTiles.Count;
            }
        }

        // public int TileCount { get; set; }
        public string ProjectName { get; set; }


        public void IsComplete()
        {
            int tileCounter = 0;

            foreach (var tile in ProjectTiles)
            {
                if (tile.ThisTileState == TileState.checkedOK)
                {
                    tileCounter += 1;
                }

                else
                {
                    break;
                }
            }

            if (tileCounter == TileCount)
            {
                ProjectComplete = true;
            }
            else
            {
                ProjectComplete = false;
            }

        }


    }
}
