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
        public virtual TyposUnivers TyposUnivers
        { get; set; }
        #endregion

        #region Constructeur
        public Univers() { }
        #endregion

        #region Methodes
        #endregion


    }
}