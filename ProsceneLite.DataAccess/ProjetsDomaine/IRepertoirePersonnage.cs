using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ProsceneLite.Data;
using ProsceneLite.Models;

namespace ProsceneLite.DataAccess
{
    public interface IRepertoirePersonnage
    {
        #region CReates
        Task<Guid> Create(Models.BgPJ bgpj);
        Task<Guid> Create(Models.CaracteristiquesPJ caraPJ);
        Task<Guid> Create(Models.ChronoPJ chroPJ);
        Task<Guid> Create(Models.ClassePJ clasPJ);
        Task<Guid> Create(Models.CompetencesPJ compPJ);
        Task<Guid> Create(Models.PartisPJ partPJ);
        Task<Guid> Create(Models.PartisPJ_BG partBg);
        Task<Guid> Create(Models.PersoPJ_BG perPJBg);
        Task<Guid> Create(Models.PJ pjs);
        Task<Guid> Create(Models.RelationsPJ relaPJ);
        Task<Guid> Create(Models.RelationsPJ_BG relaBG);
        #endregion

        #region Updates
        Task Update(Models.BgPJ bgpj);
        Task Update(Models.CaracteristiquesPJ caraPJ);
        Task Update(Models.ChronoPJ chroPJ);
        Task Update(Models.ClassePJ clasPJ);
        Task Update(Models.CompetencesPJ compPJ);
        Task Update(Models.PartisPJ partPJ);
        Task Update(Models.PartisPJ_BG partBg);
        Task Update(Models.PersoPJ_BG perPJBg);
        Task Update(Models.PJ pjs);
        Task Update(Models.RelationsPJ relaPJ);
        Task Update(Models.RelationsPJ_BG relaBG);
        #endregion

        #region DEletes
        Task Delete(Models.BgPJ bgpj);
        Task Delete(Models.CaracteristiquesPJ caraPJ);
        Task Delete(Models.ChronoPJ chroPJ);
        Task Delete(Models.ClassePJ clasPJ);
        Task Delete(Models.CompetencesPJ compPJ);
        Task Delete(Models.PartisPJ partPJ);
        Task Delete(Models.PartisPJ_BG partBg);
        Task Delete(Models.PersoPJ_BG perPJBg);
        Task Delete(Models.PJ pjs);
        Task Delete(Models.RelationsPJ relaPJ);
        Task Delete(Models.RelationsPJ_BG relaBG);
        #endregion

        #region Gets
        Task<Models.BgPJ> GetBgPJ(Guid pId);
        Task<Models.CaracteristiquesPJ> GetCaracteristiquesPJ(Guid pId);
        Task<Models.ChronoPJ> GetChronoPJ(Guid pId);
        Task<Models.ClassePJ> GetClassePJ(Guid pId);
        Task<Models.CompetencesPJ> GetCompetencesPJ(Guid pId);
        Task<Models.PartisPJ> GetPartisPJ(Guid pId);
        Task<Models.PartisPJ_BG> GetPartisPJ_BG(Guid pId);
        Task<Models.PersoPJ_BG> GetPersoPJ_BG(Guid pId);
        Task<Models.PJ> GetPJ(Guid pId);
        Task<Models.RelationsPJ> GetRelationsPJ(Guid pId);
        Task<Models.RelationsPJ_BG> GetRelationsPJ_BG(Guid pId);
        #endregion
    }
}
