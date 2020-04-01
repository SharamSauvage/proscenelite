using System;
using System.Collections.Generic;
using System.Text;

namespace ProsceneLite.Models
{
    public class FormulaireInscriptions
    {
        #region Champs
        public Guid Id { get; set; }
        
        public Guid ProjetId { get; set; }

        public string NomFormulaire { get; set; }

        public virtual Projet Projet
        { get; set; }
        #endregion

        #region Constructeur
        public FormulaireInscriptions()
        {

        }
        #endregion

        #region Methodes

        #endregion
    }
}