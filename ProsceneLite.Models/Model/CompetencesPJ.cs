using System;
using System.Collections.Generic;
using System.Text;

namespace ProsceneLite.Models
{
    
    public class CompetencesPJ
    {
        #region Champs

        public Guid PJId { get; set; }
        public Guid CompetenceId { get; set; }
        public string CompVal { get; set; }
        /// <summary>
        /// Index non clé
        /// </summary>
        public Guid Id { get; set; }
        #endregion

        #region Constructeur
        public CompetencesPJ() { }
        #endregion

        #region Methodes
        #endregion
    }
}