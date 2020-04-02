using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ProsceneLite.Data;
using ProsceneLite.Models;

namespace ProsceneLite.DataAccess
{
    public interface IRepertoireAdminUsers
    {
        #region #CReates
        Task<Guid> Create(Models.Utilisateurs util);
        Task<Guid> Create(Models.Pays ppays);
        Task<Guid> Create(Models.Voies pvoies);
        Task<Guid> Create(Models.Adresse adr);
        Task<Guid> Create(Models.Social soc);
        #endregion

        #region Updates
        Task Update(Models.Utilisateurs util);
        Task Update(Models.Pays ppays);
        Task Update(Models.Voies pvoies);
        Task Update(Models.Adresse adr);
        Task Update(Models.Social soc);
        #endregion

        #region DEletes
        #endregion

        #region GETS
        #endregion

    }
}
