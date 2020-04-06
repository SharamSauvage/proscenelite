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
    public class RepertoirePersonnage : RepertoireBase<ProsceneContext>, IRepertoirePersonnage
    {
        public RepertoirePersonnage(DbContextOptions<ProsceneContext> options)
            : base(options)
        {

        }

        #region CReates
        public async Task<Guid> Create(Models.BgPJ bgpj)
        {
            try
            {
                var context = CreateContext();
                var created = new Data.BgPJ
                {
                    Id = bgpj.Id,
                    PJId = bgpj.PJId,
                    Ordre = bgpj.Ordre,
                    PersoBgId = bgpj.PersoBgId,
                    RelationBgId = bgpj.RelationBgId,
                    PartisBgId = bgpj.PartisBgId,
                    ChronoPJId = bgpj.ChronoPJId,
                };
                var enr = await context
                ._BgPJ
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return bgpj.Id;
            }
        }

        public async Task<Guid> Create(Models.CaracteristiquesPJ caraPJ)
        {
            try
            {
                var context = CreateContext();
                var created = new Data.CaracteristiquesPJ
                {
                    PJId = caraPJ.PJId,
                    CaracId = caraPJ.CaracId,
                    CaracVal = caraPJ.CaracVal,
                    Id = caraPJ.Id,
                };
                var enr = await context
                ._CaracteristiquesPJ
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return caraPJ.Id;
            }
        }

        public async Task<Guid> Create(Models.ChronoPJ chroPJ)
        {
            try
            {
                var context = CreateContext();
                var created = new Data.ChronoPJ
                {
                    Id = chroPJ.Id,
                    PJId = chroPJ.PJId,
                    MoisId = chroPJ.MoisId,
                    Annee = chroPJ.Annee,
                    DescrpFaits = chroPJ.DescrpFaits,
                };
                var enr = await context
                ._ChronoPJ
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return chroPJ.Id;
            }
        }

        public async Task<Guid> Create(Models.ClassePJ clasPJ)
        {
            try
            {
                var context = CreateContext();
                var created = new Data.ClassePJ
                {
                    PJId = clasPJ.PJId,
                    ClasseId = clasPJ.ClasseId,
                    Id = clasPJ.Id,
                };
                var enr = await context
                ._ClassePJ
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return clasPJ.Id;
            }
        }

        public async Task<Guid> Create(Models.CompetencesPJ compPJ)
        {
            try
            {
                var context = CreateContext();
                var created = new Data.CompetencesPJ
                {
                    PJId = compPJ.PJId,
                    CompetenceId = compPJ.CompetenceId,
                    CompVal = compPJ.CompVal,
                    Id = compPJ.Id,
                };
                var enr = await context
                ._CompetencesPJ
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return compPJ.Id;
            }
        }

        public async Task<Guid> Create(Models.PartisPJ partPJ)
        {
            try
            {
                var context = CreateContext();
                var created = new Data.PartisPJ
                {
                    PJId = partPJ.PJId,
                    PartiId = partPJ.PartiId,
                    Description = partPJ.Description,
                    Id = partPJ.Id,
                };
                var enr = await context
                ._PartisPJ
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return partPJ.Id;
            }
        }

        public async Task<Guid> Create(Models.PartisPJ_BG partBg)
        {
            try
            {
                var context = CreateContext();
                var created = new Data.PartisPJ_BG
                {
                    Id = partBg.Id,
                    PartisPJId = partBg.PartisPJId,
                    Version = partBg.Version,
                    TitreBg = partBg.TitreBg,
                    BG_Corps = partBg.BG_Corps,
                };
                var enr = await context
                ._PartisPJ_BG
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return partBg.Id;
            }
        }

        public async Task<Guid> Create(Models.PersoPJ_BG perPJBg)
        {
            try
            {
                var context = CreateContext();
                var created = new Data.PersoPJ_BG
                {
                    Id = perPJBg.Id,
                    PJId = perPJBg.PJId,
                    Version = perPJBg.Version,
                    TitreBg = perPJBg.TitreBg,
                    BG_Corps = perPJBg.BG_Corps,
                };
                var enr = await context
                ._PersoPJ_BG
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return perPJBg.Id;
            }
        }

        public async Task<Guid> Create(Models.PJ pjs)
        {
            try
            {
                var context = CreateContext();
                var created = new Data.PJ
                {
                    Id = pjs.Id,
                    NomPJ = pjs.NomPJ,
                    DdNPJ = pjs.DdNPJ,
                    ArchetypeId = pjs.ArchetypeId,
                    Synopsis = pjs.Synopsis,
                    JoueurID = pjs.JoueurID,
                };
                var enr = await context
                ._PJ
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return pjs.Id;
            }
        }

        public async Task<Guid> Create(Models.RelationsPJ relaPJ)
        {
            try
            {
                var context = CreateContext();
                int niv;
                niv = relaPJ.NivRel switch
                {
                    NivRelation.LienFaible => niv = 0,
                    NivRelation.LienFort => niv = 1,
                    NivRelation.LienIntime => niv = 2,
                    _ => niv = 0,
                };
                var created = new Data.RelationsPJ
                {
                    PJ1Id = relaPJ.PJ1Id,
                    PJ2Id = relaPJ.PJ2Id,
                    Id = relaPJ.Id,
                    NivRelation = niv,
                };
                var enr = await context
                ._RelationsPJ
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return relaPJ.Id;
            }
        }

        public async Task<Guid> Create(Models.RelationsPJ_BG relaBG)
        {
            try
            {
                var context = CreateContext();
                var created = new Data.RelationsPJ_BG
                {
                    Id = relaBG.Id,
                    RelationId = relaBG.RelationId,
                    Version = relaBG.Version,
                    TitreBg = relaBG.TitreBg,
                    BG_Corps = relaBG.BG_Corps,
                };
                var enr = await context
                ._RelationsPJ_BG
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return relaBG.Id;
            }
        }
        #endregion

        #region Updates
        public async Task Update(Models.BgPJ bgpj)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._BgPJ.FindAsync(bgpj.Id);
                if (toUpdate != null)
                {
                    toUpdate.Id = bgpj.Id;
                    toUpdate.PJId = bgpj.PJId;
                    toUpdate.Ordre = bgpj.Ordre;
                    toUpdate.PersoBgId = bgpj.PersoBgId;
                    toUpdate.RelationBgId = bgpj.RelationBgId;
                    toUpdate.PartisBgId = bgpj.PartisBgId;
                    toUpdate.ChronoPJId = bgpj.ChronoPJId;

                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Update(Models.CaracteristiquesPJ caraPJ)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._CaracteristiquesPJ.FindAsync(caraPJ.Id);
                if (toUpdate != null)
                {
                    toUpdate.PJId = caraPJ.PJId;
                    toUpdate.CaracId = caraPJ.CaracId;
                    toUpdate.CaracVal = caraPJ.CaracVal;
                    toUpdate.Id = caraPJ.Id;

                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Update(Models.ChronoPJ chroPJ)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._ChronoPJ.FindAsync(chroPJ.Id);
                if (toUpdate != null)
                {
                    toUpdate.Id = chroPJ.Id;
                    toUpdate.PJId = chroPJ.PJId;
                    toUpdate.MoisId = chroPJ.MoisId;
                    toUpdate.Annee = chroPJ.Annee;
                    toUpdate.DescrpFaits = chroPJ.DescrpFaits;

                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Update(Models.ClassePJ clasPJ)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._ClassePJ.FindAsync(clasPJ.Id);
                if (toUpdate != null)
                {
                    toUpdate.PJId = clasPJ.PJId;
                    toUpdate.ClasseId = clasPJ.ClasseId;
                    toUpdate.Id = clasPJ.Id;

                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Update(Models.CompetencesPJ compPJ)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._CompetencesPJ.FindAsync(compPJ.Id);
                if (toUpdate != null)
                {
                    toUpdate.PJId = compPJ.PJId;
                    toUpdate.CompetenceId = compPJ.CompetenceId;
                    toUpdate.CompVal = compPJ.CompVal;
                    toUpdate.Id = compPJ.Id;

                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Update(Models.PartisPJ partPJ)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._PartisPJ.FindAsync(partPJ.Id);
                if (toUpdate != null)
                {
                    toUpdate.PJId = partPJ.PJId;
                    toUpdate.PartiId = partPJ.PartiId;
                    toUpdate.Description = partPJ.Description;
                    toUpdate.Id = partPJ.Id;

                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Update(Models.PartisPJ_BG partBg)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._PartisPJ_BG.FindAsync(partBg.Id);
                if (toUpdate != null)
                {
                    toUpdate.Id = partBg.Id;
                    toUpdate.PartisPJId = partBg.PartisPJId;
                    toUpdate.Version = partBg.Version;
                    toUpdate.TitreBg = partBg.TitreBg;
                    toUpdate.BG_Corps = partBg.BG_Corps;

                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Update(Models.PersoPJ_BG perPJBg)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._PersoPJ_BG.FindAsync(perPJBg.Id);
                if (toUpdate != null)
                {
                    toUpdate.Id = perPJBg.Id;
                    toUpdate.PJId = perPJBg.PJId;
                    toUpdate.Version = perPJBg.Version;
                    toUpdate.TitreBg = perPJBg.TitreBg;
                    toUpdate.BG_Corps = perPJBg.BG_Corps;

                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Update(Models.PJ pjs)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._PJ.FindAsync(pjs.Id);
                if (toUpdate != null)
                {
                    toUpdate.Id = pjs.Id;
                    toUpdate.NomPJ = pjs.NomPJ;
                    toUpdate.DdNPJ = pjs.DdNPJ;
                    toUpdate.ArchetypeId = pjs.ArchetypeId;
                    toUpdate.Synopsis = pjs.Synopsis;
                    toUpdate.JoueurID = pjs.JoueurID;

                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Update(Models.RelationsPJ relaPJ)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._RelationsPJ.FindAsync(relaPJ.Id);
                int niv;
                niv = relaPJ.NivRel switch
                {
                    NivRelation.LienFaible => niv = 0,
                    NivRelation.LienFort => niv = 1,
                    NivRelation.LienIntime => niv = 2,
                    _ => niv = 0,
                };
                if (toUpdate != null)
                {
                    toUpdate.PJ1Id = relaPJ.PJ1Id;
                    toUpdate.PJ2Id = relaPJ.PJ2Id;
                    toUpdate.Id = relaPJ.Id;
                    toUpdate.NivRelation = niv;

                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Update(Models.RelationsPJ_BG relaBG)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._RelationsPJ_BG.FindAsync(relaBG.Id);
                if (toUpdate != null)
                {
                    toUpdate.Id = relaBG.Id;
                    toUpdate.RelationId = relaBG.RelationId;
                    toUpdate.Version = relaBG.Version;
                    toUpdate.TitreBg = relaBG.TitreBg;
                    toUpdate.BG_Corps = relaBG.BG_Corps;
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
        public async Task Delete(Models.BgPJ bgpj)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._BgPJ.FindAsync(bgpj.Id);
                if (toDelete != null)
                {
                    context._BgPJ.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.CaracteristiquesPJ caraPJ)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._CaracteristiquesPJ.FindAsync(caraPJ.Id);
                if (toDelete != null)
                {
                    context._CaracteristiquesPJ.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.ChronoPJ chroPJ)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._ChronoPJ.FindAsync(chroPJ.Id);
                if (toDelete != null)
                {
                    context._ChronoPJ.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.ClassePJ clasPJ)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._ClassePJ.FindAsync(clasPJ.Id);
                if (toDelete != null)
                {
                    context._ClassePJ.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.CompetencesPJ compPJ)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._CompetencesPJ.FindAsync(compPJ.Id);
                if (toDelete != null)
                {
                    context._CompetencesPJ.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.PartisPJ partPJ)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._PartisPJ.FindAsync(partPJ.Id);
                if (toDelete != null)
                {
                    context._PartisPJ.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.PartisPJ_BG partBg)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._PartisPJ_BG.FindAsync(partBg.Id);
                if (toDelete != null)
                {
                    context._PartisPJ_BG.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.PersoPJ_BG perPJBg)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._PersoPJ_BG.FindAsync(perPJBg.Id);
                if (toDelete != null)
                {
                    context._PersoPJ_BG.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.PJ pjs)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._PJ.FindAsync(pjs.Id);
                if (toDelete != null)
                {
                    context._PJ.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.RelationsPJ relaPJ)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._RelationsPJ.FindAsync(relaPJ.Id);
                if (toDelete != null)
                {
                    context._RelationsPJ.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.RelationsPJ_BG relaBG)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._RelationsPJ_BG.FindAsync(relaBG.Id);
                if (toDelete != null)
                {
                    context._RelationsPJ_BG.Remove(toDelete);
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
        public async Task<Models.BgPJ> GetBgPJ(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._BgPJ
                .Where(t => t.Id == pId)
                .Select(t => new Models.BgPJ
                {
                    Id = t.Id,
                    PJId = t.PJId,
                    Ordre = t.Ordre,
                    PersoBgId = t.PersoBgId,
                    RelationBgId = t.RelationBgId,
                    PartisBgId = t.PartisBgId,
                    ChronoPJId = t.ChronoPJId,

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

        public async Task<Models.CaracteristiquesPJ> GetCaracteristiquesPJ(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._CaracteristiquesPJ
                .Where(t => t.Id == pId)
                .Select(t => new Models.CaracteristiquesPJ
                {
                    PJId = t.PJId,
                    CaracId = t.CaracId,
                    CaracVal = t.CaracVal,
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

        public async Task<Models.ChronoPJ> GetChronoPJ(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._ChronoPJ
                .Where(t => t.Id == pId)
                .Select(t => new Models.ChronoPJ
                {
                    Id = t.Id,
                    PJId = t.PJId,
                    MoisId = t.MoisId,
                    Annee = t.Annee,
                    DescrpFaits = t.DescrpFaits,
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

        public async Task<Models.ClassePJ> GetClassePJ(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._ClassePJ
                .Where(t => t.Id == pId)
                .Select(t => new Models.ClassePJ
                {
                    PJId = t.PJId,
                    ClasseId = t.ClasseId,
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

        public async Task<Models.CompetencesPJ> GetCompetencesPJ(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._CompetencesPJ
                .Where(t => t.Id == pId)
                .Select(t => new Models.CompetencesPJ
                {
                    PJId = t.PJId,
                    CompetenceId = t.CompetenceId,
                    CompVal = t.CompVal,
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

        public async Task<Models.PartisPJ> GetPartisPJ(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._PartisPJ
                .Where(t => t.Id == pId)
                .Select(t => new Models.PartisPJ
                {
                    PJId = t.PJId,
                    PartiId = t.PartiId,
                    Description = t.Description,
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

        public async Task<Models.PartisPJ_BG> GetPartisPJ_BG(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._PartisPJ_BG
                .Where(t => t.Id == pId)
                .Select(t => new Models.PartisPJ_BG
                {
                    Id = t.Id,
                    PartisPJId = t.PartisPJId,
                    Version = t.Version,
                    TitreBg = t.TitreBg,
                    BG_Corps = t.BG_Corps,

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

        public async Task<Models.PersoPJ_BG> GetPersoPJ_BG(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._PersoPJ_BG
                .Where(t => t.Id == pId)
                .Select(t => new Models.PersoPJ_BG
                {
                    Id = t.Id,
                    PJId = t.PJId,
                    Version = t.Version,
                    TitreBg = t.TitreBg,
                    BG_Corps = t.BG_Corps,

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

        public async Task<Models.PJ> GetPJ(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._PJ
                .Where(t => t.Id == pId)
                .Select(t => new Models.PJ
                {
                    Id = t.Id,
                    NomPJ = t.NomPJ,
                    DdNPJ = t.DdNPJ,
                    ArchetypeId = t.ArchetypeId,
                    Synopsis = t.Synopsis,
                    JoueurID = t.JoueurID,

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

        public async Task<Models.RelationsPJ> GetRelationsPJ(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._RelationsPJ
                .Where(t => t.Id == pId)
                .Select(t => new Models.RelationsPJ(t.PJ1Id,t.PJ2Id,t.Id,t.NivRelation))
                .FirstOrDefaultAsync();
                return toGet;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<Models.RelationsPJ_BG> GetRelationsPJ_BG(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._RelationsPJ_BG
                .Where(t => t.Id == pId)
                .Select(t => new Models.RelationsPJ_BG
                {
                    Id = t.Id,
                    RelationId = t.RelationId,
                    Version = t.Version,
                    TitreBg = t.TitreBg,
                    BG_Corps = t.BG_Corps,
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
