using System;
using System.Collections.Generic;
using System.Text;

namespace ProsceneLite.Models
{
    public class RelationsPJ_BG
    {
        #region Champs
        public Guid Id { get; set; }

        public Guid? RelationId { get; set; }
        public int Version { get; set; }
        public string TitreBg { get; set; }
        public string BG_Corps { get; set; }
        #endregion

        #region Constructeur
        public RelationsPJ_BG() { }
        #endregion

        #region Methodes
        #endregion


    }
}