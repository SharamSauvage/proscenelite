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
    public class RepertoireScenario : RepertoireBase<ProsceneContext>, IRepertoireScenario
    {
        public RepertoireScenario(DbContextOptions<ProsceneContext> options)
            : base(options)
        {

        }

        #region CReates
        public async Task<Guid> Create(Models.ObjetScene objeSc)
        {
            try
            {
                var context = CreateContext();
                var created = new Data.ObjetScene
                {
                    //ajouter les champs séparés par des , 
                };
                var enr = await context
                ._ObjetScene
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return objeSc.Id;
            }
        }

        public async Task<Guid> Create(Models.ObjetsQuete objeQt)
        {
            try
            {
                var context = CreateContext();
                var created = new Data.ObjetsQuete
                {
                    //ajouter les champs séparés par des , 
                };
                var enr = await context
                ._ObjetsQuete
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return objeQt.Id;
            }
        }

        public async Task<Guid> Create(Models.PartisQuete partQt)
        {
            try
            {
                var context = CreateContext();
                var created = new Data.PartisQuete
                {
                    //ajouter les champs séparés par des , 
                };
                var enr = await context
                ._PartisQuete
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return partQt.Id;
            }
        }

        public async Task<Guid> Create(Models.PlotPointsQuete pptQt)
        {
            try
            {
                var context = CreateContext();
                var created = new Data.PlotPointsQuete
                {
                    //ajouter les champs séparés par des , 
                };
                var enr = await context
                ._PlotPointsQuete
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return pptQt.Id;
            }
        }

        public async Task<Guid> Create(Models.PNJ peunj)
        {
            try
            {
                var context = CreateContext();
                var created = new Data.PNJ
                {
                    //ajouter les champs séparés par des , 
                };
                var enr = await context
                ._PNJ
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return peunj.Id;
            }
        }

        public async Task<Guid> Create(Models.PNJScene pnjscn)
        {
            try
            {
                var context = CreateContext();
                var created = new Data.PNJScene
                {
                    //ajouter les champs séparés par des , 
                };
                var enr = await context
                ._PNJScene
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return pnjscn.Id;
            }
        }

        public async Task<Guid> Create(Models.Quete quet)
        {
            try
            {
                var context = CreateContext();
                var created = new Data.Quete
                {
                    //ajouter les champs séparés par des , 
                };
                var enr = await context
                ._Quete
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return quet.Id;
            }
        }

        public async Task<Guid> Create(Models.Scene scen)
        {
            try
            {
                var context = CreateContext();
                var created = new Data.Scene
                {
                    //ajouter les champs séparés par des , 
                };
                var enr = await context
                ._Scene
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return scen.Id;
            }
        }

        public async Task<Guid> Create(Models.Spots spot)
        {
            try
            {
                var context = CreateContext();
                var created = new Data.Spots
                {
                    //ajouter les champs séparés par des , 
                };
                var enr = await context
                ._Spots
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return spot.Id;
            }
        }

        public async Task<Guid> Create(Models.TypoQuete typoQt)
        {
            try
            {
                var context = CreateContext();
                var created = new Data.TypoQuete
                {
                    //ajouter les champs séparés par des , 
                };
                var enr = await context
                ._TypoQuete
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return typoQt.Id;
            }
        }

        public async Task<Guid> Create(Models.TypoSpot typoSp)
        {
            try
            {
                var context = CreateContext();
                var created = new Data.TypoSpot
                {
                    //ajouter les champs séparés par des , 
                };
                var enr = await context
                ._TypoSpot
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return typoSp.Id;
            }
        }
        #endregion

        #region Updates
        public async Task Update(Models.ObjetScene objeSc)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._ObjetScene.FindAsync(objeSc.Id);
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

        public async Task Update(Models.ObjetsQuete objeQt)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._ObjetsQuete.FindAsync(objeQt.Id);
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

        public async Task Update(Models.PartisQuete partQt)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._PartisQuete.FindAsync(partQt.Id);
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

        public async Task Update(Models.PlotPointsQuete pptQt)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._PlotPointsQuete.FindAsync(pptQt.Id);
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

        public async Task Update(Models.PNJ peunj)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._PNJ.FindAsync(peunj.Id);
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

        public async Task Update(Models.PNJScene pnjscn)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._PNJScene.FindAsync(pnjscn.Id);
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

        public async Task Update(Models.Quete quet)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._Quete.FindAsync(quet.Id);
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

        public async Task Update(Models.Scene scen)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._Scene.FindAsync(scen.Id);
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

        public async Task Update(Models.Spots spot)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._Spots.FindAsync(spot.Id);
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

        public async Task Update(Models.TypoQuete typoQt)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._TypoQuete.FindAsync(typoQt.Id);
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
        
        public async Task Update(Models.TypoSpot typoSp)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._TypoSpot.FindAsync(typoSp.Id);
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
        public async Task Delete(Models.ObjetScene objeSc)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._ObjetScene.FindAsync(objeSc.Id);
                if (toDelete != null)
                {
                    context._ObjetScene.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.ObjetsQuete objeQt)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._ObjetsQuete.FindAsync(objeQt.Id);
                if (toDelete != null)
                {
                    context._ObjetsQuete.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.PartisQuete partQt)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._PartisQuete.FindAsync(partQt.Id);
                if (toDelete != null)
                {
                    context._PartisQuete.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.PlotPointsQuete pptQt)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._PlotPointsQuete.FindAsync(pptQt.Id);
                if (toDelete != null)
                {
                    context._PlotPointsQuete.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.PNJ peunj)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._PNJ.FindAsync(peunj.Id);
                if (toDelete != null)
                {
                    context._PNJ.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.PNJScene pnjscn)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._PNJScene.FindAsync(pnjscn.Id);
                if (toDelete != null)
                {
                    context._PNJScene.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.Quete quet)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._Quete.FindAsync(quet.Id);
                if (toDelete != null)
                {
                    context._Quete.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.Scene scen)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._Scene.FindAsync(scen.Id);
                if (toDelete != null)
                {
                    context._Scene.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.Spots spot)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._Spots.FindAsync(spot.Id);
                if (toDelete != null)
                {
                    context._Spots.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.TypoQuete typoQt)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._TypoQuete.FindAsync(typoQt.Id);
                if (toDelete != null)
                {
                    context._TypoQuete.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.TypoSpot typoSp)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._TypoSpot.FindAsync(typoSp.Id);
                if (toDelete != null)
                {
                    context._TypoSpot.Remove(toDelete);
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
        public async Task<Models.ObjetScene> GetObjetScene(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._ObjetScene
                .Where(t => t.Id == pId)
                .Select(t => new Models.ObjetScene
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

        public async Task<Models.ObjetsQuete> GetObjetsQuete(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._ObjetsQuete
                .Where(t => t.Id == pId)
                .Select(t => new Models.ObjetsQuete
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

        public async Task<Models.PartisQuete> GetPartisQuete(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._PartisQuete
                .Where(t => t.Id == pId)
                .Select(t => new Models.PartisQuete
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

        public async Task<Models.PlotPointsQuete> GetPlotPointsQuete(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._PlotPointsQuete
                .Where(t => t.Id == pId)
                .Select(t => new Models.PlotPointsQuete
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

        public async Task<Models.PNJ> GetPNJ(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._PNJ
                .Where(t => t.Id == pId)
                .Select(t => new Models.PNJ
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

        public async Task<Models.PNJScene> GetPNJScene(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._PNJScene
                .Where(t => t.Id == pId)
                .Select(t => new Models.PNJScene
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

        public async Task<Models.Quete> GetQuete(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._Quete
                .Where(t => t.Id == pId)
                .Select(t => new Models.Quete
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

        public async Task<Models.Scene> GetScene(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._Scene
                .Where(t => t.Id == pId)
                .Select(t => new Models.Scene
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

        public async Task<Models.Spots> GetSpots(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._Spots
                .Where(t => t.Id == pId)
                .Select(t => new Models.Spots
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

        public async Task<Models.TypoQuete> GetTypoQuete(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._TypoQuete
                .Where(t => t.Id == pId)
                .Select(t => new Models.TypoQuete
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

        public async Task<Models.TypoSpot> GetTypoSpot(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._TypoSpot
                .Where(t => t.Id == pId)
                .Select(t => new Models.TypoSpot
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
