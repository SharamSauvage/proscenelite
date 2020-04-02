using System;
using System.Collections.Generic;
using System.Text;

namespace ProsceneLite.Models
{
    public class Alignement
    {
        #region Key(s)
        public Guid Id { get; set; }

        public Guid? UniversId { get; set; }
        public string NomAlignement { get; set; }

        #endregion

        #region Constructeur
        public Alignement() { }
        #endregion

        #region Methodes
        #endregion
    }
}