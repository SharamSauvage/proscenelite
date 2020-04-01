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
    public class RepertoireUnivers:RepertoireBase<ProsceneContext>,IRepertoireUnivers
    {
        /// <summary>
        /// quelle que soit la table appellée
        /// </summary>
        /// <param name="options"></param>
        public RepertoireUnivers(DbContextOptions<ProsceneContext> options)
            :base(options)
        {

        }

        #region CReates
        
        public async Task<Guid> Create(Models.TyposUnivers tpu)
        {
            var context = CreateContext();
            var created = new Data.TyposUnivers
            {
                TypeUnivers = tpu.TypeUnivers
            };

            var enr = await context
                ._TypoUnivers
                .AddAsync(created);
            await context
                .SaveChangesAsync();

            return enr.Entity.Id;
        }

        public async Task<Guid> Create(Models.Univers univ)
        {
            try
            {
                var context = CreateContext();
                var tpu = await context._TypoUnivers.FindAsync(univ.TypoUniversId);
                if (tpu != null)
                {
                    var created = new Data.Univers
                    {
                        NomUnivers = univ.NomUnivers,
                        TypoUniversId = univ.TypoUniversId

                    };
                    var enr = await context
                        ._Univers
                        .AddAsync(created);
                    await context
                        .SaveChangesAsync();
                    return enr.Entity.Id;
                }
                else
                {
                    return univ.Id; //voir avec MABD si c'est OK
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return univ.Id; //voir avec MABD si c'est OK
            }
        }

        public async Task<Guid> Create(Models.ListeChampsUnivers lcu)
        {
            try
            {
                var context = CreateContext();
                var univ = await context._Univers.FindAsync(lcu.UniversId);
                if(univ!=null)
                {
                    int typo;
                    switch (lcu.TypoChamps)
                    {
                        case TyposChampsInscription.texte:
                            typo = 0;
                            break;
                        case TyposChampsInscription.entier:
                            typo = 1;
                            break;
                        case TyposChampsInscription.decimale:
                            typo = 0;
                            break;
                        case TyposChampsInscription.booleen:
                        default:
                            typo = 3;
                            break;
                    }
                    var created = new Data.ListeChampsUnivers
                    {
                        NomChamps = lcu.NomChamps,
                        TypoChamps = typo,
                        UniversId = lcu.UniversId
                    };
                    var enr = await context
                        ._ListeChampsUnivers
                        .AddAsync(created);
                    await context
                        .SaveChangesAsync();
                    return enr.Entity.Id;
                }
                else
                {
                    return lcu.UniversId;
                }
            }
            catch (DbUpdateException e)
            { 
                Console.WriteLine(e.Message);
                return lcu.Id;
            }
        }
        #endregion

        #region Updates
        public async Task Update(Models.TyposUnivers tpu)
        {
            try
            { 
                var context = CreateContext();
                var toUpdate = await context._TypoUnivers.FindAsync(tpu.Id);

                if (toUpdate!=null)
                {
                    toUpdate.TypeUnivers = tpu.TypeUnivers;
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
                var tocheck = await context._TypoUnivers.FindAsync(univ.TypoUniversId);
                if (toUpdate != null && tocheck!=null)
                {
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

        public async Task Update(Models.ListeChampsUnivers lcu)
        {
            try
            {
                var context = CreateContext();
                var toCheck = await context._Univers.FindAsync(lcu.UniversId);
                var toUpdate = await context._ListeChampsUnivers.FindAsync(lcu.Id);
                if(toUpdate!=null && toCheck!=null)
                {
                    toUpdate.NomChamps = lcu.NomChamps;
                    switch (lcu.TypoChamps)
                    { 
                        case TyposChampsInscription.texte:
                            toUpdate.TypoChamps = 0;
                            break;
                        case TyposChampsInscription.entier:
                            toUpdate.TypoChamps = 1;
                            break;
                        case TyposChampsInscription.decimale:
                            toUpdate.TypoChamps = 2;
                            break;
                        case TyposChampsInscription.booleen:
                        default:
                            toUpdate.TypoChamps = 3;
                            break;
                    }
                    toUpdate.UniversId = lcu.UniversId;
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

        public async Task Delete(Models.TyposUnivers tpu)
        {
            try 
            { 
                var context = CreateContext();
                var toDelete = await context._TypoUnivers.FindAsync(tpu.Id);

                if (toDelete!=null)
                {
                    var universAssociés = context._Univers.Where(u => u.TypoUniversId == toDelete.Id).ToList();
                    foreach(var _univ in universAssociés)
                    {
                        context._Univers.Remove(_univ);
                    }
                    context._TypoUnivers.Remove(toDelete);

                    await context.SaveChangesAsync();
                }
            }
            catch(DbUpdateException e)
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
                    var champsAssociés = context._ListeChampsUnivers.Where(u => u.UniversId == toDelete.Id).ToList();
                    foreach (var _lcu in champsAssociés )
                    {
                        context._ListeChampsUnivers.Remove(_lcu);
                    }
                    context._Univers.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.ListeChampsUnivers lcu)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._ListeChampsUnivers.FindAsync(lcu.Id);
                if(toDelete!=null)
                {
                    var ListChampsInscriptionAssociés = context._ListeChampsInscriptions.Where(u => u.ListeChampsUniversId == toDelete.Id).ToList();
                    foreach(var _lcia in ListChampsInscriptionAssociés )
                    {
                        context._ListeChampsInscriptions.Remove(_lcia);
                    }
                    context._ListeChampsUnivers.Remove(toDelete);
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
        public async Task<Models.TyposUnivers> GetTypo(Guid id)
        {
            var context = CreateContext();
            var typo = await context
                ._TypoUnivers
                .Where(t => t.Id == id)
                .Select(t => new Models.TyposUnivers
                {
                    Id = t.Id,
                    TypeUnivers = t.TypeUnivers
                })
                .FirstOrDefaultAsync();

            
            return typo;
        }

        public async Task<Models.Univers> GetUnivers(Guid id)
        {
            var context = CreateContext();
            var univ = await context
                ._Univers
                .Where(u => u.Id == id)
                .Select(u => new Models.Univers
                {
                    Id = u.Id,
                    TypoUniversId = u.TypoUniversId
                })
                .FirstOrDefaultAsync();
            return univ;
        }

        public async Task<Models.ListeChampsUnivers> GetListeChampsUnivers(Guid id)
        {
            var context = CreateContext();

            var univ = await context
                ._ListeChampsUnivers
                .Where(u => u.Id == id)
                .Select(u => new Models.ListeChampsUnivers(u.Id,u.NomChamps,u.UniversId,u.TypoChamps))
                //.Select(u => new Models.ListeChampsUnivers
                //{
                //    Id = u.Id,
                //    NomChamps = u.NomChamps,
                //    TypoChamps = u.TypoChamps,
                //    UniversId=u.UniversId
                    
                //})
                .FirstOrDefaultAsync();
            return univ;
        }
        #endregion




    }
}
