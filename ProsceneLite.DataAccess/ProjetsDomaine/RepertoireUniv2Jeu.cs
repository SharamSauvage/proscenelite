using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
using ProsceneLite.Data;
using ProsceneLite.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ProsceneLite.DataAccess
{
    public class RepertoireUniv2Jeu : RepertoireBase<ProsceneContext>, IRepertoireUniv2Jeu
    {
        public RepertoireUniv2Jeu(DbContextOptions<ProsceneContext> options)
            : base(options)
        {

        }

        #region CReates
        public async Task<Guid> Create(Models.Alignement alig)
        {
            try
            {
                var context = CreateContext();
                var created = new Data.Alignement
                {
                    Id = alig.Id,
                    UniversId = alig.UniversId,
                    NomAlignement = alig.NomAlignement,

                };
                var enr = await context
                ._Alignement
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return alig.Id;
            }
        }

        public async Task<Guid> Create(Models.Archetype arch)
        {
            try
            {
                var context = CreateContext();
                var created = new Data.Archetype
                {
                    Id = arch.Id,
                    NomArchetype = arch.NomArchetype,
                    Description = arch.Description,
                    UniversId = arch.UniversId,

                };
                var enr = await context
                ._Archetype
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return arch.Id;
            }
        }

        public async Task<Guid> Create(Models.Calendrier cale)
        {
            try
            {
                var context = CreateContext();
                var created = new Data.Calendrier
                {
                    Id = cale.Id,
                    UniversId = cale.UniversId,
                    NbMois = cale.NbMois,
                    NbJoursAnnée = cale.NbJoursAnnée,

                };
                var enr = await context
                ._Calendrier
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return cale.Id;
            }
        }

        public async Task<Guid> Create(Models.CalendriersMultiples cale)
        {
            try
            {
                var context = CreateContext();
                var created = new Data.CalendriersMultiples
                {
                    CalendrierId = cale.CalendrierId,
                    PaysContreeId = cale.PaysContreeId,
                    Id = cale.Id,

                };
                var enr = await context
                ._CalendriersMultiples
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return cale.Id;
            }
        }

        public async Task<Guid> Create(Models.Caracteristiques cara)
        {
            try
            {
                var context = CreateContext();
                var created = new Data.Caracteristiques
                {
                    Id = cara.Id,
                    UniversId = cara.UniversId,
                    NomCarac = cara.NomCarac,

                };
                var enr = await context
                ._Caracteristiques
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return cara.Id;
            }
        }

        public async Task<Guid> Create(Models.ClasseMetier clas)
        {
            try
            {
                var context = CreateContext();
                var created = new Data.ClasseMetier
                {
                    Id = clas.Id,
                    UniversId = clas.UniversId,
                    NomClasse = clas.NomClasse,

                };
                var enr = await context
                ._ClasseMetier
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return clas.Id;
            }
        }

        public async Task<Guid> Create(Models.Competences comp)
        {
            try
            {
                var context = CreateContext();
                var created = new Data.Competences
                {
                    Id = comp.Id,
                    UniversId = comp.UniversId,
                    NomCompetence = comp.NomCompetence,
                    EstNumerique = comp.EstNumerique,

                };
                var enr = await context
                ._Competences
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return comp.Id;
            }
        }

        public async Task<Guid> Create(Models.Mois mois)
        {
            try
            {
                var context = CreateContext();
                var created = new Data.Mois
                {
                    Id = mois.Id,
                    CalendrierId = mois.CalendrierId,
                    NomMois = mois.NomMois,
                    NbJours = mois.NbJours,

                };
                var enr = await context
                ._Mois
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return mois.Id;
            }
        }

        public async Task<Guid> Create(Models.Organisations organs)
        {
            try
            {
                var context = CreateContext();
                var created = new Data.Organisations
                {
                    Id = organs.Id,
                    UniversId = organs.UniversId,
                    NomOrganisation = organs.NomOrganisation,

                };
                var enr = await context
                ._Organisations
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return organs.Id;
            }
        }

        public async Task<Guid> Create(Models.PaysContree payscontr)
        {
            try
            {
                var context = CreateContext();
                var created = new Data.PaysContree
                {
                    Id = payscontr.Id,
                    UniversId = payscontr.UniversId,
                    Nom = payscontr.Nom,

                };
                var enr = await context
                ._PaysContree
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return payscontr.Id;
            }
        }

        public async Task<Guid> Create(Models.Race rac)
        {
            try
            {
                var context = CreateContext();
                var created = new Data.Race
                {
                    Id = rac.Id,
                    UniversId = rac.UniversId,
                    NomRace = rac.NomRace,

                };
                var enr = await context
                ._Race
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return rac.Id;
            }
        }

        public async Task<Guid> Create(Models.Religion relig)
        {
            try
            {
                var context = CreateContext();
                var created = new Data.Religion
                {
                    Id = relig.Id,
                    UniversId = relig.UniversId,
                    NomReligion = relig.NomReligion,

                };
                var enr = await context
                ._Religion
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return relig.Id;
            }
        }

        public async Task<Guid> Create(Models.TyposUnivers typoUn)
        {
            try
            {
                var context = CreateContext();
                var created = new Data.TyposUnivers
                {
                    Id = typoUn.Id,
                    TypeUnivers = typoUn.TypeUnivers,

                };
                var enr = await context
                ._TyposUnivers
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return typoUn.Id;
            }
        }

        public async Task<Guid> Create(Models.Univers univ)
        {
            try
            {
                var context = CreateContext();
                var created = new Data.Univers
                {
                    Id = univ.Id,
                    NomUnivers = univ.NomUnivers,
                    TypoUniversId = univ.TypoUniversId,

                };
                var enr = await context
                ._Univers
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return univ.Id;
            }
        }
        #endregion

        #region Updates
        public async Task Update(Models.Alignement alig)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._Alignement.FindAsync(alig.Id);
                if (toUpdate != null)
                {
                    toUpdate.Id = alig.Id;
                    toUpdate.UniversId = alig.UniversId;
                    toUpdate.NomAlignement = alig.NomAlignement;

                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Update(Models.Archetype arch)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._Archetype.FindAsync(arch.Id);
                if (toUpdate != null)
                {
                    toUpdate.Id = arch.Id;
                    toUpdate.NomArchetype = arch.NomArchetype;
                    toUpdate.Description = arch.Description;
                    toUpdate.UniversId = arch.UniversId;

                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Update(Models.Calendrier cale)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._Calendrier.FindAsync(cale.Id);
                if (toUpdate != null)
                {
                    toUpdate.Id = cale.Id;
                    toUpdate.UniversId = cale.UniversId;
                    toUpdate.NbMois = cale.NbMois;
                    toUpdate.NbJoursAnnée = cale.NbJoursAnnée;

                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Update(Models.CalendriersMultiples cale)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._CalendriersMultiples.FindAsync(cale.Id);
                if (toUpdate != null)
                {
                    toUpdate.CalendrierId = cale.CalendrierId;
                    toUpdate.PaysContreeId = cale.PaysContreeId;
                    toUpdate.Id = cale.Id;

                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Update(Models.Caracteristiques cara)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._Caracteristiques.FindAsync(cara.Id);
                if (toUpdate != null)
                {
                    toUpdate.Id = cara.Id;
                    toUpdate.UniversId = cara.UniversId;
                    toUpdate.NomCarac = cara.NomCarac;

                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Update(Models.ClasseMetier clas)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._ClasseMetier.FindAsync(clas.Id);
                if (toUpdate != null)
                {
                    toUpdate.Id = clas.Id;
                    toUpdate.UniversId = clas.UniversId;
                    toUpdate.NomClasse = clas.NomClasse;

                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Update(Models.Competences comp)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._Competences.FindAsync(comp.Id);
                if (toUpdate != null)
                {
                    toUpdate.Id = comp.Id;
                    toUpdate.UniversId = comp.UniversId;
                    toUpdate.NomCompetence = comp.NomCompetence;
                    toUpdate.EstNumerique = comp.EstNumerique;

                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Update(Models.Mois mois)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._Mois.FindAsync(mois.Id);
                if (toUpdate != null)
                {
                    toUpdate.Id = mois.Id;
                    toUpdate.CalendrierId = mois.CalendrierId;
                    toUpdate.NomMois = mois.NomMois;
                    toUpdate.NbJours = mois.NbJours;

                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Update(Models.Organisations organs)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._Organisations.FindAsync(organs.Id);
                if (toUpdate != null)
                {
                    toUpdate.Id = organs.Id;
                    toUpdate.UniversId = organs.UniversId;
                    toUpdate.NomOrganisation = organs.NomOrganisation;

                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Update(Models.PaysContree payscontr)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._PaysContree.FindAsync(payscontr.Id);
                if (toUpdate != null)
                {
                    toUpdate.Id = payscontr.Id;
                    toUpdate.UniversId = payscontr.UniversId;
                    toUpdate.Nom = payscontr.Nom;

                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Update(Models.Race rac)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._Race.FindAsync(rac.Id);
                if (toUpdate != null)
                {
                    toUpdate.Id = rac.Id;
                    toUpdate.UniversId = rac.UniversId;
                    toUpdate.NomRace = rac.NomRace;

                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Update(Models.Religion relig)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._Religion.FindAsync(relig.Id);
                if (toUpdate != null)
                {
                    toUpdate.Id = relig.Id;
                    toUpdate.UniversId = relig.UniversId;
                    toUpdate.NomReligion = relig.NomReligion;

                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Update(Models.TyposUnivers typoUn)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._TyposUnivers.FindAsync(typoUn.Id);
                if (toUpdate != null)
                {
                    toUpdate.Id = typoUn.Id;
                    toUpdate.TypeUnivers = typoUn.TypeUnivers;

                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Update(Models.Univers univ)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._Univers.FindAsync(univ.Id);
                if (toUpdate != null)
                {
                    toUpdate.Id = univ.Id;
                    toUpdate.NomUnivers = univ.NomUnivers;
                    toUpdate.TypoUniversId = univ.TypoUniversId;

                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        #endregion

        #region DEletes
        public async Task Delete(Models.Alignement alig)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._Alignement.FindAsync(alig.Id);
                if (toDelete != null)
                {
                    context._Alignement.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.Archetype arch)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._Archetype.FindAsync(arch.Id);
                if (toDelete != null)
                {
                    context._Archetype.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.Calendrier cale)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._Calendrier.FindAsync(cale.Id);
                if (toDelete != null)
                {
                    context._Calendrier.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.CalendriersMultiples cale)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._CalendriersMultiples.FindAsync(cale.Id);
                if (toDelete != null)
                {
                    context._CalendriersMultiples.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.Caracteristiques cara)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._Caracteristiques.FindAsync(cara.Id);
                if (toDelete != null)
                {
                    context._Caracteristiques.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.ClasseMetier clas)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._ClasseMetier.FindAsync(clas.Id);
                if (toDelete != null)
                {
                    context._ClasseMetier.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.Competences comp)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._Competences.FindAsync(comp.Id);
                if (toDelete != null)
                {
                    context._Competences.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.Mois mois)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._Mois.FindAsync(mois.Id);
                if (toDelete != null)
                {
                    context._Mois.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.Organisations organs)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._Organisations.FindAsync(organs.Id);
                if (toDelete != null)
                {
                    context._Organisations.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.PaysContree payscontr)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._PaysContree.FindAsync(payscontr.Id);
                if (toDelete != null)
                {
                    context._PaysContree.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.Race rac)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._Race.FindAsync(rac.Id);
                if (toDelete != null)
                {
                    context._Race.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.Religion relig)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._Religion.FindAsync(relig.Id);
                if (toDelete != null)
                {
                    context._Religion.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.TyposUnivers typoUn)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._TyposUnivers.FindAsync(typoUn.Id);
                if (toDelete != null)
                {
                    context._TyposUnivers.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.Univers univ)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._Univers.FindAsync(univ.Id);
                if (toDelete != null)
                {
                    context._Univers.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }        
        #endregion

        #region Gets
        public async Task<Models.Alignement> GetAlignement(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._Alignement
                .Where(t => t.Id == pId)
                .Select(t => new Models.Alignement
                {
                    Id = t.Id,
                    UniversId = t.UniversId,
                    NomAlignement = t.NomAlignement,

                })
                .FirstOrDefaultAsync();
                return toGet;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<Models.Archetype> GetArchetype(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._Archetype
                .Where(t => t.Id == pId)
                .Select(t => new Models.Archetype
                {
                    Id = t.Id,
                    NomArchetype = t.NomArchetype,
                    Description = t.Description,
                    UniversId = t.UniversId,

                })
                .FirstOrDefaultAsync();
                return toGet;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<Models.Calendrier> GetCalendrier(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._Calendrier
                .Where(t => t.Id == pId)
                .Select(t => new Models.Calendrier
                {
                    Id = t.Id,
                    UniversId = t.UniversId,
                    NbMois = t.NbMois,
                    NbJoursAnnée = t.NbJoursAnnée,

                })
                .FirstOrDefaultAsync();
                return toGet;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<Models.CalendriersMultiples> GetCalendriersMultiples(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._CalendriersMultiples
                .Where(t => t.Id == pId)
                .Select(t => new Models.CalendriersMultiples
                {
                    CalendrierId = t.CalendrierId,
                    PaysContreeId = t.PaysContreeId,
                    Id = t.Id,

                })
                .FirstOrDefaultAsync();
                return toGet;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<Models.Caracteristiques> GetCaracteristiques(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._Caracteristiques
                .Where(t => t.Id == pId)
                .Select(t => new Models.Caracteristiques
                {
                    Id = t.Id,
                    UniversId = t.UniversId,
                    NomCarac = t.NomCarac,

                })
                .FirstOrDefaultAsync();
                return toGet;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<Models.ClasseMetier> GetClasseMetier(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._ClasseMetier
                .Where(t => t.Id == pId)
                .Select(t => new Models.ClasseMetier
                {
                    Id = t.Id,
                    UniversId = t.UniversId,
                    NomClasse = t.NomClasse,

                })
                .FirstOrDefaultAsync();
                return toGet;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<Models.Competences> GetCompetences(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._Competences
                .Where(t => t.Id == pId)
                .Select(t => new Models.Competences
                {
                    Id = t.Id,
                    UniversId = t.UniversId,
                    NomCompetence = t.NomCompetence,
                    EstNumerique = t.EstNumerique,

                })
                .FirstOrDefaultAsync();
                return toGet;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<Models.Mois> GetMois(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._Mois
                .Where(t => t.Id == pId)
                .Select(t => new Models.Mois
                {
                    Id = t.Id,
                    CalendrierId = t.CalendrierId,
                    NomMois = t.NomMois,
                    NbJours = t.NbJours,

                })
                .FirstOrDefaultAsync();
                return toGet;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<Models.Organisations> GetOrganisations(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._Organisations
                .Where(t => t.Id == pId)
                .Select(t => new Models.Organisations
                {
                    Id = t.Id,
                    UniversId = t.UniversId,
                    NomOrganisation = t.NomOrganisation,

                })
                .FirstOrDefaultAsync();
                return toGet;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<Models.PaysContree> GetPaysContree(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._PaysContree
                .Where(t => t.Id == pId)
                .Select(t => new Models.PaysContree
                {
                    Id = t.Id,
                    UniversId = t.UniversId,
                    Nom = t.Nom,

                })
                .FirstOrDefaultAsync();
                return toGet;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<Models.Race> GetRace(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._Race
                .Where(t => t.Id == pId)
                .Select(t => new Models.Race
                {
                    Id = t.Id,
                    UniversId = t.UniversId,
                    NomRace = t.NomRace,
                    
                })
                .FirstOrDefaultAsync();
                return toGet;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<Models.Religion> GetReligion(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._Religion
                .Where(t => t.Id == pId)
                .Select(t => new Models.Religion
                {
                    Id = t.Id,
                    UniversId = t.UniversId,
                    NomReligion = t.NomReligion,

                })
                .FirstOrDefaultAsync();
                return toGet;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<Models.TyposUnivers> GetTyposUnivers(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._TyposUnivers
                .Where(t => t.Id == pId)
                .Select(t => new Models.TyposUnivers
                {
                    Id = t.Id,
                    TypeUnivers = t.TypeUnivers,

                })
                .FirstOrDefaultAsync();
                return toGet;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<Models.Univers> GetUnivers(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._Univers
                .Where(t => t.Id == pId)
                .Select(t => new Models.Univers
                {
                    Id = t.Id,
                    NomUnivers = t.NomUnivers,
                    TypoUniversId = t.TypoUniversId,

                })
                .FirstOrDefaultAsync();
                return toGet;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }      
        #endregion
    }
}
