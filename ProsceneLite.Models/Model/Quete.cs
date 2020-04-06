using System;
using System.Collections.Generic;
using System.Text;

namespace ProsceneLite.Models
{
    
    public class Quete
    {
        #region Champs
        public Guid Id { get; set; }
        public string TitreQuete { get; set; }
        public Guid? ReferentId { get; set; }
        public StatuValid? StatuValidId { get; set; }
        public Guid? TypoQueteId { get; set; }
        public Guid? ProjetId { get; set; }
        public string SynopsisQuete { get; set; }
        #endregion

        #region Constructeur
        public Quete() { }
        public Quete(Guid pId, string pTitre, Guid? pRef, int? pStat, Guid? pTypoQ, Guid? pProjId, String pSynops)
        {
            Id = pId;
            TitreQuete = pTitre;
            ReferentId = pRef;
            TypoQueteId = pTypoQ;
            ProjetId = pProjId;
            SynopsisQuete = pSynops;
            StatuValidId = pStat switch
            {
                0 => StatuValid.redact,
                1 => StatuValid.relecture,
                2 => StatuValid.validation,
                3 => StatuValid.validé,
                _ => StatuValid.redact,
            };
        }
        #endregion

        #region Methodes
        #endregion

    }
}