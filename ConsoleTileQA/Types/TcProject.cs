using System.Collections.ObjectModel;
using System.Linq;

namespace TileQA
{
    class TcProject
    {
        public readonly Collection<TcTile> ProjectTiles = new Collection<TcTile>();
        public string ProjectName { get; set; }
        public int TileCount         => ProjectTiles.Count;
        public bool ProjectComplete  => ProjectTiles.All(i => i.ThisTileState == TileState.checkedOK);


        /*
        public Collection<TcTile> ProjectTiles = new Collection<TcTile>();

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
        */
    }
}
