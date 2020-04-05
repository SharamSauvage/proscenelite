using System;
using System.Collections.Generic;
using System.Text;

namespace ProsceneLite.Models
{
    public class ClassePJ
    {
        #region Champs
        public Guid PJId { get; set; }

        public Guid ClasseId { get; set; }

        /// <summary>
        /// Index non clé
        /// </summary>
        public Guid Id { get; set; }
        #endregion

        #region Constructeur
        public ClassePJ() { }
        #endregion

        #region Methodes
        #endregion
    }
}