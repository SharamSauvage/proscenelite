using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ProsceneLite.Data;
using ProsceneLite.Models;

namespace ProsceneLite.DataAccess
{
    public interface IRepertoireUniv2Jeu
    {
        #region CReates
        Task<Guid> Create(Models.Alignement alig);
        Task<Guid> Create(Models.Archetype arch);
        Task<Guid> Create(Models.Calendrier cale);
        Task<Guid> Create(Models.CalendriersMultiples cale);
        Task<Guid> Create(Models.Caracteristiques cara);
        Task<Guid> Create(Models.ClasseMetier clas);
        Task<Guid> Create(Models.Competences comp);
        Task<Guid> Create(Models.Mois mois);
        Task<Guid> Create(Models.Organisations organs);
        Task<Guid> Create(Models.PaysContree payscontr);
        Task<Guid> Create(Models.Race rac);
        Task<Guid> Create(Models.Religion relig);
        Task<Guid> Create(Models.TyposUnivers typoUn);
        Task<Guid> Create(Models.Univers univ);
        #endregion

        #region Updates
        Task Update(Models.Alignement alig);
        Task Update(Models.Archetype arch);
        Task Update(Models.Calendrier cale);
        Task Update(Models.CalendriersMultiples cale);
        Task Update(Models.Caracteristiques cara);
        Task Update(Models.ClasseMetier clas);
        Task Update(Models.Competences comp);
        Task Update(Models.Mois mois);
        Task Update(Models.Organisations organs);
        Task Update(Models.PaysContree payscontr);
        Task Update(Models.Race rac);
        Task Update(Models.Religion relig);
        Task Update(Models.TyposUnivers typoUn);
        Task Update(Models.Univers univ);
        #endregion

        #region DEletes
        Task Delete(Models.Alignement alig);
        Task Delete(Models.Archetype arch);
        Task Delete(Models.Calendrier cale);
        Task Delete(Models.CalendriersMultiples cale);
        Task Delete(Models.Caracteristiques cara);
        Task Delete(Models.ClasseMetier clas);
        Task Delete(Models.Competences comp);
        Task Delete(Models.Mois mois);
        Task Delete(Models.Organisations organs);
        Task Delete(Models.PaysContree payscontr);
        Task Delete(Models.Race rac);
        Task Delete(Models.Religion relig);
        Task Delete(Models.TyposUnivers typoUn);
        Task Delete(Models.Univers univ);
        #endregion

        #region Gets
        Task<Models.Alignement> GetAlignement(Guid pId);
        Task<Models.Archetype> GetArchetype(Guid pId);
        Task<Models.Calendrier> GetCalendrier(Guid pId);
        Task<Models.CalendriersMultiples> GetCalendriersMultiples(Guid pId);
        Task<Models.Caracteristiques> GetCaracteristiques(Guid pId);
        Task<Models.ClasseMetier> GetClasseMetier(Guid pId);
        Task<Models.Competences> GetCompetences(Guid pId);
        Task<Models.Mois> GetMois(Guid pId);
        Task<Models.Organisations> GetOrganisations(Guid pId);
        Task<Models.PaysContree> GetPaysContree(Guid pId);
        Task<Models.Race> GetRace(Guid pId);
        Task<Models.Religion> GetReligion(Guid pId);
        Task<Models.TyposUnivers> GetTyposUnivers(Guid pId);
        Task<Models.Univers> GetUnivers(Guid pId);
        #endregion
    }
}
