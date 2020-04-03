using System;
using System.Collections.Generic;
using System.Text;

namespace ProsceneLite.Models
{
    public class BgPJ
    {
        #region Champs
        public Guid Id { get; set; }
        
        public Guid PJId { get; set; }
        public int Ordre { get; set; }
        

        public Guid? PersoBgId { get; set; }
        public Guid? RelationBgId { get; set; }
        public Guid? PartisBgId { get; set; }
        public Guid? ChronoPJId { get; set; }
        
        #endregion

        #region Constructeur
        public BgPJ() { }
        #endregion

        #region Methodes
        #endregion
    }
}