using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProsceneLite.DataAccess
{
    public interface IRepertoireAdminUsers
    {
        #region #CReates
        Task<Guid> Create(Models.Utilisateurs util);
        Task<Guid> Create(Models.UtilisateursEntites utilent);
        Task<Guid> Create(Models.Entite enti);
        Task<Guid> Create(Models.EntiteBanque entbk);
        Task<Guid> Create(Models.Pays ppays);
        Task<Guid> Create(Models.Voies pvoies);
        Task<Guid> Create(Models.Adresse adr);
        Task<Guid> Create(Models.Entrepot entrp);
        Task<Guid> Create(Models.StockEntrepot stckentr);
        Task<Guid> Create(Models.Social soc);
        #endregion

        #region Updates
        Task Update(Models.Utilisateurs util);
        Task Update(Models.UtilisateursEntites utilent);
        Task Update(Models.Entite enti);
        Task Update(Models.EntiteBanque entbk);
        Task Update(Models.Pays ppays);
        Task Update(Models.Voies pvoies);
        Task Update(Models.Adresse adr);
        Task Update(Models.Entrepot entrp);
        Task Update(Models.StockEntrepot stckentr);
        Task Update(Models.Social soc);
        #endregion

        #region DEletes
        #endregion

        #region GETS
        #endregion

    }
}
