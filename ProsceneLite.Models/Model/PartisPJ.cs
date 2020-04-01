using System;
using System.Collections.Generic;
using System.Text;

namespace ProsceneLite.Models
{
    public class PartisPJ
    {
        #region Champs

        public Guid PJId { get; set; }
        public Guid PartiId { get; set; }

        public string Description { get; set; }

        public virtual PartisQuete PartisQuete
        { get; set; }
        public virtual PJ PJ
        { get; set; }
        #endregion

        #region Constructeur
        public PartisPJ() { }
        #endregion

        #region Methodes
        #endregion



    }
}