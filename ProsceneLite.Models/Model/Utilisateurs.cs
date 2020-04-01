using System;
using System.Collections.Generic;
using System.Text;

namespace ProsceneLite.Models
{
    
    public class Utilisateurs
    {
        #region Champs
        
        public Guid Id { get; set; }
        
        public string Nom { get; set; }
        
        public string Prenom { get; set; }
        
        public string UserName { get; set; }
        
        public string Email { get; set; }
        
        public DateTime Ddn { get; set; }
        public Byte[] Avatar { get; set; }
        #endregion

        #region Constructeur
        public Utilisateurs() { }
        #endregion

        #region Methodes
        #endregion

    }
}