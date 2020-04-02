using System;
using System.Collections.Generic;
using System.Text;


namespace ProsceneLite.Models
{
    
    public class Univers
    {
        
        #region Champs
        
        public Guid Id { get; set; }
        
        public string NomUnivers { get; set; }
        public Guid? TypoUniversId { get; set; }
        
        #endregion

        #region Constructeur
        public Univers() { }
        public Univers(Guid pId, string pNuniv, Guid pTypoUniv)
        {
            Id = pId;
            NomUnivers = pNuniv;
            TypoUniversId = pTypoUniv;
        }
        #endregion

        #region Methodes
        #endregion


    }
}