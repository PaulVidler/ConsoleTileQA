using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Numerics;

namespace TileQA
{
    public class TcTileLayout : IDisposable
    {
        public string Type { get; set; }
        public ICollection<Feature> Features { get; set; }

        [JsonIgnore]
        private bool disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    Features?.Clear();
                }

                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }
    }

    public class Feature
    {
        public string Type { get; set; }
        public Properties Properties { get; set; }
        public Geometry Geometry { get; set; }
    }

    public class Properties
    {
        public string Name { get; set; }
        public float Xmin { get; set; }
        public float Ymin { get; set; }
        public float Xmax { get; set; }
        public float Ymax { get; set; }
    }

    public class Geometry
    {
        public string Type { get; set; }

        [Browsable(false), Bindable(false),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), 
        EditorBrowsable(EditorBrowsableState.Never)]
        [JsonProperty]
        private ICollection<List<float[]>> Coordinates { get; set; }

        [JsonIgnore]
        public List<Vector2> Points => Coordinates.SelectMany
            (i => i.Select(indice => new Vector2(indice[0], indice[1]))).ToList();
    }



}
