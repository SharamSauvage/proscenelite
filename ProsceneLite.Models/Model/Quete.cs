using System;
using System.Collections.Generic;
using System.Text;

namespace ProsceneLite.Models
{
    
    public class Quete
    {
        #region Champs
        public Guid Id { get; set; }
        public string TitreQuete { get; set; }
        public Guid? ReferentId { get; set; }
        public Guid? StatuValidId { get; set; }
        public Guid? TypoQueteId { get; set; }
        public virtual Utilisateurs Utilisateurs
        {
            get;
            set;
        }
        public virtual TypoQuete TypoQuete
        {
            get;
            set;
        }
        public virtual StatutValidation StatutValidation
        {
            get;
            set;
        }
        #endregion

        #region Constructeur
        public Quete() { }
        #endregion

        #region Methodes
        #endregion

    }
}