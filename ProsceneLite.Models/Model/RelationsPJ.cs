using System;
using System.Collections.Generic;
using System.Text;

namespace ProsceneLite.Models
{
    public class RelationsPJ
    {
        #region Champs
        public Guid PJ1Id { get; set; }
        public Guid PJ2Id { get; set; }

        public Guid Id { get; set; }

        public NivRelation? NivRel { get; set; }

        #endregion

        #region Constructeur
        public RelationsPJ() { }
        public RelationsPJ(Guid pPJ1, Guid pPJ2, Guid pId, int? pNiv)
        {
            PJ1Id = pPJ1;
            PJ2Id = pPJ2;
            Id = pId;
            NivRel = pNiv switch
            {
                0 => NivRelation.LienFaible,
                1 => NivRelation.LienFort,
                2 => NivRelation.LienIntime,
                _ => NivRelation.LienFaible,
            };
        }
        #endregion

        #region Methodes
        #endregion
    }
}