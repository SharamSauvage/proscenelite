using System;
using System.Collections.Generic;
using System.Text;

namespace ProsceneLite.Models
{        
    public class Inscrits
    {
        #region Champs
        public Guid Id { get; set; }

        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string CptFacebook { get; set; }
        public string AdEmail { get; set; }
        public Guid AdresseId { get; set; }
        public DateTime DdN { get; set; }
        // relatif à l'inscription "Administrative"
        public bool ReglementOK { get; set; }
        //les 3 booléens qui suivent s'excluent l'un l'autre
        public bool EstPJ { get; set; } 
        public bool EstPNJ { get; set; }
        public bool EstOrga { get; set; }

        public virtual Adresse Adresse
        { get; set; }

        #endregion

        #region Constructeur
        public Inscrits() { }
        #endregion
        
        #region Methodes
        #endregion
    }
}