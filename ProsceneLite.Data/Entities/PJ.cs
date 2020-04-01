﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProsceneLite.Data
{
    [Table("PJ")]
    public class PJ
    {
        #region Key(s)
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        #endregion

        #region Champs
        public string NomPJ { get; set; }
        public string DdNPJ { get; set; } //dans l'univers d'où le stockage en string
        public string Archetype { get; set; }
        public string Synopsis { get; set; }

        //il faut une table pour les Objets de jeu, et une pour les Docs de Jeu ET une dernière pour le BG

        public Guid JoueurID { get; set; }

        #endregion

        #region ForeignKeys
        [ForeignKey(nameof(JoueurID))]
        public virtual Inscrits Inscrits
        { get; set; }
        #endregion

        
    }
}