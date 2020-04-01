using System;
using System.Collections.Generic;
using System.Text;

namespace ProsceneLite.Models
{
    public class Entite
    {
        #region Champs
        public Guid Id { get; set; }

        public string Nom {get; set;}
        public TypoEntite? TypeEntite { get; set; }
        public string IdLegale { get; set; }
        public Byte[] Logo { get; set; }
        public Guid ReprLegalId { get; set; } //signifie que le Propriétaire de l'entité est celui qui a créé le compte
        public virtual Utilisateurs Utilisateurs
        { get; set; }
        public EntiteBanque[] Banques { get; set; }
        #endregion

        #region Constructeur
        public Entite() { }
        public Entite(Guid pId, string pN, int pType, string plegId,Byte[] pLogo, Guid pReprLegalId)
        {
            Id = pId;
            Nom = pN;
            switch (pType)
            {
                case 0:
                    TypeEntite = TypoEntite.Association;
                    break;
                case 1:
                    TypeEntite = TypoEntite.Collectif;
                    break;
                case 2:
                    TypeEntite = TypoEntite.Entreprise;
                    break;
                case 3:
                    TypeEntite = TypoEntite.Particulier;
                    break;
                case 4:
                    TypeEntite = TypoEntite.Autre;
                    break;
                default:
                    TypeEntite = TypoEntite.Association;
                    break;
            }
            Logo = pLogo;
            IdLegale = plegId;
            ReprLegalId = pReprLegalId;
        }
        #endregion
        #region Méthodes
        
        #endregion
    }
}