using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProsceneLite.Models
{
    public class ProjetsEntites
    {
        #region Champs

        public Guid EntiteId { get; set; }
        

        public Guid ProjetId { get; set; }
        public virtual Entite Entite
        {
            get;
            set;
        }
        
        public virtual Projet Projet
        {
            get;
            set;
        }
        #endregion

        #region Constructeur
        public ProjetsEntites() { }
        #endregion

        #region Methodes
        #endregion

    }
}