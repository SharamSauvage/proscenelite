using System;
using System.Collections.Generic;
using System.Text;

namespace ProsceneLite.Models
{
    public class Archetype
    {
        #region Champs
        public Guid Id { get; set; }
        public string NomArchetype { get; set; }
        public string Description { get; set; }
        public Guid? UniversId { get; set; }
        #endregion

        #region Constructeur
        public Archetype() { }
        #endregion

        #region Methodes
        #endregion
    }
}
