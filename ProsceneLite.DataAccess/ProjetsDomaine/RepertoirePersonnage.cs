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
                    //ajouter les champs séparés par des , 
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
                    //ajouter les champs séparés par des , 
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
                    //ajouter les champs séparés par des , 
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
                    //ajouter les champs séparés par des , 
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
                    //ajouter les champs séparés par des , 
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
                    //ajouter les champs séparés par des , 
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
                    //ajouter les champs séparés par des , 
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
                    //ajouter les champs séparés par des , 
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
                    //ajouter les champs séparés par des , 
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
                var created = new Data.RelationsPJ
                {
                    //ajouter les champs séparés par des , 
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
                    //ajouter les champs séparés par des , 
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
                    //mise à jour des champs séparation ;
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
                    //mise à jour des champs séparation ;
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
                    //mise à jour des champs séparation ;
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
                    //mise à jour des champs séparation ;
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
                    //mise à jour des champs séparation ;
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
                    //mise à jour des champs séparation ;
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
                    //mise à jour des champs séparation ;
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
                    //mise à jour des champs séparation ;
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
                    //mise à jour des champs séparation ;
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
                if (toUpdate != null)
                {
                    //mise à jour des champs séparation ;
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
                    //mise à jour des champs séparation ;
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
                    //récupérer les valeurs des champs
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
                    //récupérer les valeurs des champs
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
                    //récupérer les valeurs des champs
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
                    //récupérer les valeurs des champs
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
                    //récupérer les valeurs des champs
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
                    //récupérer les valeurs des champs
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
                    //récupérer les valeurs des champs
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
                    //récupérer les valeurs des champs
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
                    //récupérer les valeurs des champs
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
                .Select(t => new Models.RelationsPJ
                {
                    //récupérer les valeurs des champs
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
                    //récupérer les valeurs des champs
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
