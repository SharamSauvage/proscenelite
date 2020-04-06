using System;
using System.Collections.Generic;
using System.Text;

namespace ProsceneLite.Models
{
    public class ChronoPJ
    {
        #region Champs
        public Guid Id { get; set; }
        public Guid PJId { get; set; }
        public Guid MoisId { get; set; }
        public int Annee { get; set; }
        public string DescrpFaits { get; set; }

        #endregion

        #region Constructeur
        public ChronoPJ() { }
        #endregion

        #region Methodes
        #endregion
    }
}