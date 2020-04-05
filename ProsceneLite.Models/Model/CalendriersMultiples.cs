using System;
using System.Collections.Generic;
using System.Text;

namespace ProsceneLite.Models
{
    public class CalendriersMultiples
    {
        #region Champs
        public Guid CalendrierId { get; set; }
        public Guid PaysContreeId { get; set; }

        /// <summary>
        /// Index non clé
        /// </summary>
        public Guid Id { get; set; }
        #endregion

        #region Constructeur
        public CalendriersMultiples() { }
        #endregion

        #region Methodes
        #endregion
    }
}