using System;
using System.Collections.Generic;
using System.Text;

namespace ProsceneLite.Models
{
    public class PJ
    {
        #region Champs
        
        public Guid Id { get; set; }

        public string NomPJ { get; set; }
        public string DdNPJ { get; set; } //dans l'univers d'où le stockage en string
        public string Archetype { get; set; }
        public string Synopsis { get; set; }

        //il faut une table pour les Objets de jeu, et une pour les Docs de Jeu ET une dernière pour le BG

        public Guid JoueurID { get; set; }


        public virtual Inscrits Inscrits
        { get; set; }
        #endregion

        #region Constructeur
        public PJ() { }
        #endregion

        #region Methodes
        #endregion

    }
}