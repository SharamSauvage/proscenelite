using System;
using System.Collections.Generic;
using System.Text;

namespace ProsceneLite.Models
{
    public class CaracteristiquesPJ
    {
        #region Champs
        public Guid PJId { get; set; }
        public Guid CaracId { get; set; }

        public string CaracVal { get; set; }
        /// <summary>
        /// Index non clé
        /// </summary>
        public Guid Id { get; set; }
        #endregion

        #region Constructeur
        public CaracteristiquesPJ() { }
        #endregion

        #region Methodes
        #endregion
    }
}