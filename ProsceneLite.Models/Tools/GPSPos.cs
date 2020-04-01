using System;
using System.Collections.Generic;
using System.Text;

namespace ProsceneLite.Tools
{
    public class GPSPos
    {
        #region Champs
        public float Longitude { get; set; }
        public float Latitude { get; set; }
        #endregion

        #region Constructeurs
        public GPSPos()
        { }

        public GPSPos(float pLong, float pLat)
        {
            Longitude = pLong;
            Latitude = pLat;
        }

        #endregion

        #region Methodes
        
        #endregion
    }
}
