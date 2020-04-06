using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ProsceneLite.Data;
using ProsceneLite.Models;

namespace ProsceneLite.DataAccess
{
    public interface IRepertoireAdmin
    {
        #region CReates
        Task<Guid> Create(Models.Adresse adre);
        Task<Guid> Create(Models.AdressesUtilisateurs adreutil);
        Task<Guid> Create(Models.Inscrits insc);
        Task<Guid> Create(Models.Pays ppays);
        Task<Guid> Create(Models.Projet proj);
        Task<Guid> Create(Models.ProjetsUtilisateurs projutil);
        Task<Guid> Create(Models.Social soci);
        Task<Guid> Create(Models.Utilisateurs util);
        Task<Guid> Create(Models.Voies voie);
        #endregion

        #region Updates
        Task Update(Models.Adresse adre);
        Task Update(Models.AdressesUtilisateurs adreutil);
        Task Update(Models.Inscrits insc);
        Task Update(Models.Pays ppays);
        Task Update(Models.Projet proj);
        Task Update(Models.ProjetsUtilisateurs projutil);
        Task Update(Models.Social soci);
        Task Update(Models.Utilisateurs util);
        Task Update(Models.Voies voie);
        #endregion

        #region DEletes
        Task Delete(Models.Adresse adre);
        Task Delete(Models.AdressesUtilisateurs adreutil);
        Task Delete(Models.Inscrits insc);
        Task Delete(Models.Pays ppays);
        Task Delete(Models.Projet proj);
        Task Delete(Models.ProjetsUtilisateurs projutil);
        Task Delete(Models.Social soci);
        Task Delete(Models.Utilisateurs util);
        Task Delete(Models.Voies voie);
        #endregion

        #region Gets
        Task<Models.Adresse> GetAdresse(Guid pId);
        Task<Models.AdressesUtilisateurs> GetAdressesUtilisateurs(Guid pId);
        Task<Models.Inscrits> GetInscrits(Guid pId);
        Task<Models.Pays> GetPays(Guid pId);
        Task<Models.Projet> GetProjet(Guid pId);
        Task<Models.ProjetsUtilisateurs> GetProjetsUtilisateurs(Guid pId);
        Task<Models.Social> GetSocial(Guid pId);
        Task<Models.Utilisateurs> GetUtilisateurs(Guid pId);
        Task<Models.Voies> GetVoies(Guid pId);

        #endregion
    }
}
