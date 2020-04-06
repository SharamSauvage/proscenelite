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
        /// <summary>
        /// Index non clé
        /// </summary>
        public Guid Id { get; set; }
        #endregion

        #region Constructeur
        public PartisPJ() { }
        #endregion

        #region Methodes
        #endregion



    }
}