using System;
using System.Collections.Generic;
using System.Text;

namespace ProsceneLite.Models
{
    public class Social
    {
        #region Champs
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid ContactId { get; set; }
        public StatuDemContact StatutDemCtct { get; set; }
        public StatuContact StatutCtct { get; set; }
        #endregion

        #region Constructeur
        public Social() { }
        public Social(Guid pId, Guid pUserId, Guid pContId, int pStatDem, int pStatCont)
        {
            Id = pId;
            UserId = pUserId;
            ContactId = pContId;
            StatutDemCtct = pStatDem switch
            {
                0 => StatuDemContact.envoyee,
                1 => StatuDemContact.approuvee,
                2 => StatuDemContact.blacklist,
                _ => StatuDemContact.envoyee,
            };
            StatutCtct = pStatCont switch
            {
                0 => StatuContact.connecte,
                1 => StatuContact.occupe,
                2 => StatuContact.nepasdéranger,
                3 => StatuContact.deretourbientot,
                4 => StatuContact.absent,
                5 => StatuContact.deconnecte,
                _ => StatuContact.deconnecte,
            };
        }
        #endregion

        #region Methodes
        #endregion
    }
}
