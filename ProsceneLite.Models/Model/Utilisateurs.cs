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
        public Utilisateurs(Guid pId, string pNom, string pPrenom, string pUsername, string pEmail, DateTime pDdn, Byte[] pAvatar)
        {
            Id = pId;
            Nom = pNom;
            Prenom = pPrenom;
            UserName = pUsername;
            Email = pEmail;
            Ddn = pDdn;
            Avatar = pAvatar;
        }
        #endregion

        #region Methodes
        #endregion

    }
}