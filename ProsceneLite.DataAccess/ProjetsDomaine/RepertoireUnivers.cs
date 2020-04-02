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

        #endregion




    }
}
