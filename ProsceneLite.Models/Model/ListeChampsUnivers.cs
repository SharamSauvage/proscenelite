using System;
using System.Collections.Generic;
using System.Text;

namespace ProsceneLite.Models
{
    public class ListeChampsUnivers
    {
        #region Champs
        public Guid Id { get; set; }

        public string NomChamps { get; set; }
        public TyposChampsInscription TypoChamps { get; set; }

        public Guid UniversId { get; set; }

        public virtual Univers Univers
        { get; set; }
        #endregion

        #region Constructeur
        public ListeChampsUnivers() { }
        public ListeChampsUnivers(Guid pId, string pN, Guid pUnId, int pTypo)
        {
            Id = pId;
            NomChamps = pN;
            UniversId = pUnId;
            switch (pTypo)
            {
                case 0: 
                    TypoChamps = TyposChampsInscription.texte;
                    break;
                case 1:
                    TypoChamps = TyposChampsInscription.entier;
                    break;
                case 2:
                    TypoChamps = TyposChampsInscription.decimale;
                    break;
                case 3:
                    TypoChamps = TyposChampsInscription.booleen;
                    break;
                default:
                    TypoChamps = TyposChampsInscription.texte;
                    break;
            }
        }
        #endregion

        #region Methodes
        public TyposChampsInscription ConvertiIntTypo (int p)
        {
            TyposChampsInscription r;
            switch (p)
            {
                case 0:
                    r = TyposChampsInscription.texte;
                    break;
                case 1:
                    r = TyposChampsInscription.entier;
                    break;
                case 2:
                    r = TyposChampsInscription.decimale;
                    break;
                case 3:
                    r = TyposChampsInscription.booleen;
                    break;
                default:
                    r = TyposChampsInscription.texte;
                    break;
            }
            return r;
        }
        #endregion
    }
}