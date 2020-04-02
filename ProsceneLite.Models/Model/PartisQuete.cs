using System;
using System.Collections.Generic;
using System.Text;

namespace ProsceneLite.Models
{
    public class PartisQuete
    {
        #region Champs

        public Guid Id { get; set; }

        public Guid? QueteId { get; set; }
        public string NomParti { get; set; }
        public string Synopsis { get; set; }
        public string But { get; set; }
        public DateTime DebutEnJeu { get; set; }
        public DateTime FinEnJeu { get; set; }

        public virtual Quete Quete
        { get; set; }
        #endregion

        #region Constructeur
        public PartisQuete() { }
        #endregion

        #region Methodes
        #endregion

    }
}