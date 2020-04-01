using System;
using System.Collections.Generic;
using System.Text;

namespace ProsceneLite.Models
{
    public class ListeChampsInscriptions
    {
        #region Champs

        public Guid ListeChampsUniversId { get; set; }
        public Guid ProjetId { get; set; }

        public virtual ListeChampsUnivers ListeChampsUnivers
        { get; set; }

        public virtual Projet Projet
        { get; set; }
        #endregion

        #region Constructeur
        public ListeChampsInscriptions()
        {

        }
        #endregion

        #region Methodes
        #endregion
    }
}