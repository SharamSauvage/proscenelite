using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ProsceneLite.Data;
using ProsceneLite.Models;

namespace ProsceneLite.DataAccess
{
    public interface IRepertoireScenario
    {
        #region CReates
        Task<Guid> Create(Models.ObjetScene objeSc);
        Task<Guid> Create(Models.ObjetsQuete objeQt);
        Task<Guid> Create(Models.PartisQuete partQt);
        Task<Guid> Create(Models.PlotPointsQuete pptQt);
        Task<Guid> Create(Models.PNJ peunj);
        Task<Guid> Create(Models.PNJScene pnjscn);
        Task<Guid> Create(Models.Quete quet);
        Task<Guid> Create(Models.Scene scen);
        Task<Guid> Create(Models.Spots spot);
        Task<Guid> Create(Models.TypoQuete typoQt);
        Task<Guid> Create(Models.TypoSpot typoSp);
        #endregion

        #region Updates
        Task Update(Models.ObjetScene objeSc);
        Task Update(Models.ObjetsQuete objeQt);
        Task Update(Models.PartisQuete partQt);
        Task Update(Models.PlotPointsQuete pptQt);
        Task Update(Models.PNJ peunj);
        Task Update(Models.PNJScene pnjscn);
        Task Update(Models.Quete quet);
        Task Update(Models.Scene scen);
        Task Update(Models.Spots spot);
        Task Update(Models.TypoQuete typoQt);
        Task Update(Models.TypoSpot typoSp);
        #endregion

        #region DEletes
        Task Delete(Models.ObjetScene objeSc);
        Task Delete(Models.ObjetsQuete objeQt);
        Task Delete(Models.PartisQuete partQt);
        Task Delete(Models.PlotPointsQuete pptQt);
        Task Delete(Models.PNJ peunj);
        Task Delete(Models.PNJScene pnjscn);
        Task Delete(Models.Quete quet);
        Task Delete(Models.Scene scen);
        Task Delete(Models.Spots spot);
        Task Delete(Models.TypoQuete typoQt);
        Task Delete(Models.TypoSpot typoSp);
        #endregion

        #region Gets
        Task<Models.ObjetScene> GetObjetScene(Guid pId);
        Task<Models.ObjetsQuete> GetObjetsQuete(Guid pId);
        Task<Models.PartisQuete> GetPartisQuete(Guid pId);
        Task<Models.PlotPointsQuete> GetPlotPointsQuete(Guid pId);
        Task<Models.PNJ> GetPNJ(Guid pId);
        Task<Models.PNJScene> GetPNJScene(Guid pId);
        Task<Models.Quete> GetQuete(Guid pId);
        Task<Models.Scene> GetScene(Guid pId);
        Task<Models.Spots> GetSpots(Guid pId);
        Task<Models.TypoQuete> GetTypoQuete(Guid pId);
        Task<Models.TypoSpot> GetTypoSpot(Guid pId);
        #endregion
    }
}
