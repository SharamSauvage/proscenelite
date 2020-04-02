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
    public class RepertoireAdminUsers:RepertoireBase<ProsceneContext>,IRepertoireAdminUsers
    {
        public RepertoireAdminUsers(DbContextOptions<ProsceneContext> options)
            : base(options)
        {

        }
    

        #region CReates
        public async Task<Guid> Create(Models.Utilisateurs util)
        {
            try
            { 
                var context = CreateContext();
                var created = new Data.Utilisateurs
                {
                    Id = util.Id,
                    Nom = util.Nom,
                    Prenom = util.Prenom,
                    UserName = util.UserName,
                    Ddn = util.Ddn,
                    Email = util.Email,
                    Avatar = util.Avatar
                };
                var enr = await context
                    ._Utilisateurs
                    .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return util.Id;
            }
        }
        public async Task<Guid> Create(Models.Pays ppays)
        {
            try
            { 
                var context = CreateContext();
                var created = new Data.Pays
                {
                    Id = ppays.Id,
                    NomPays = ppays.NomPays
                };
                var enr = await context
                    ._Pays
                    .AddAsync(created);
                await context.SaveChangesAsync();
                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return ppays.Id;
            }
        }
        public async Task<Guid> Create(Models.Voies pvoies)
        {
            try
            { 
                var context = CreateContext();
                var created = new Data.Voies
                {
                    Id = pvoies.Id,
                    NomVoie = pvoies.NomVoie
                };
                var enr = await context
                    ._Voies
                    .AddAsync(created);
                await context.SaveChangesAsync();
                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return pvoies.Id;
            }
        } 
        public async Task<Guid> Create(Models.Adresse adr)
        {
            try
            { 
                var context = CreateContext();
                var ppays = await context._Pays.FindAsync(adr.Pays);
                var pvoies = await context._Voies.FindAsync(adr.Voie);
                if (ppays != null && pvoies != null)
                {
                    var created = new Data.Adresse
                    {
                        Id = adr.Id,
                        Num = adr.Num,
                        Voie = adr.Voie,
                        NomVoie = adr.NomVoie,
                        CodePostal = adr.CodePostal,
                        Ville = adr.Ville,
                        Region = adr.Region,
                        Pays = adr.Pays
                    };
                    var enr = await context
                        ._Adresse
                        .AddAsync(created);
                    await context.SaveChangesAsync();
                    return enr.Entity.Id;
                }
                else
                    return adr.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return adr.Id;
            }
        }
        public async Task<Guid> Create(Models.Social soc)
        {
            try
            { 
                var context = CreateContext();
                var usr = await context._Utilisateurs.FindAsync(soc.UserId);
                var cont = await context._Utilisateurs.FindAsync(soc.ContactId);
                if (usr != null && cont != null)
                {
                    int StatDem;
                    switch (soc.StatutDemContact)
                    {
                        case StatuDemContact.envoyee:
                            StatDem = 0;
                            break;
                        case StatuDemContact.approuvee:
                            StatDem = 1;
                            break;
                        case StatuDemContact.blacklist:
                            StatDem = 2;
                            break;
                        default:
                            StatDem = 0;
                            break;
                    }
                    int StatCont;
                    switch (soc.StatutContact)
                    {
                        case StatuContact.connecte:
                            StatCont = 0;
                            break;
                        case StatuContact.occupe:
                            StatCont = 1;
                            break;
                        case StatuContact.nepasdéranger:
                            StatCont = 2;
                            break;
                        case StatuContact.deretourbientot:
                            StatCont = 3;
                            break;
                        case StatuContact.absent:
                            StatCont = 4;
                            break;
                        case StatuContact.deconnecte:
                            StatCont = 5;
                            break;
                        default:
                            StatCont = 5;
                            break;
                    }
                    var toCreate = new Data.Social
                    {
                        Id = soc.Id,
                        UserId = soc.UserId,
                        ContactId = soc.ContactId,
                        StatutDemContact = StatDem,
                        StatutContact = StatCont
                    };
                    var enr = await context
                        ._Socials
                        .AddAsync(toCreate);
                    await context.SaveChangesAsync();
                    return enr.Entity.Id;
                }
                else
                    return soc.Id;
            }
            catch(DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return soc.Id;
            }
        }
        public async Task<Guid> Create(Models.AdressesUtilisateurs adusr)
        {
            try
            { 
                var context = CreateContext();
                var toCheckUsr = context._Utilisateurs.FindAsync(adusr.UtilisateurId);
                var toCheckAd = context._Adresse.FindAsync(adusr.AdresseId);
            
                if (toCheckUsr!=null && toCheckAd!=null)
                { 
                    var toCreate = new Data.AdressesUtilisateurs
                    {
                        AdresseId = adusr.AdresseId,
                        UtilisateurId = adusr.UtilisateurId
                    };
                    var enr = await context
                        ._AdressesUtilisateurs
                        .AddAsync(toCreate);
                    await context.SaveChangesAsync();
                    return enr.Entity.AdresseId;
                }
                else
                {
                    return adusr.AdresseId;
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return adusr.AdresseId;
            }
        }
        #endregion

        #region Updates
        public async Task Update(Models.Utilisateurs util)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._Utilisateurs.FindAsync(util.Id);
                
                if (toUpdate!=null)
                {
                    toUpdate.Nom = util.Nom;
                    toUpdate.Prenom = util.Prenom;
                    toUpdate.UserName = util.UserName;
                    toUpdate.Avatar = util.Avatar;
                    toUpdate.Ddn = util.Ddn;
                    toUpdate.Email = util.Email;
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public async Task Update(Models.Pays ppays)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._Pays.FindAsync(ppays.Id);
                if(toUpdate!=null)
                {
                    toUpdate.NomPays = ppays.NomPays;
                    await context.SaveChangesAsync();
                }

            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public async Task Update(Models.Voies pvoies)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._Voies.FindAsync(pvoies.Id);
                if (toUpdate!=null)
                {
                    toUpdate.NomVoie = pvoies.NomVoie;
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public async Task Update(Models.Adresse adr)
        {
            try
            {
                var context = CreateContext();
                var toCheckPays = await context._Pays.FindAsync(adr.Pays);
                var toCheckVoie = await context._Voies.FindAsync(adr.Voie);
                var toUpdate = await context._Adresse.FindAsync(adr.Id);
                if(toCheckPays!=null && toCheckVoie!=null & toUpdate!=null)
                {
                    toUpdate.Num = adr.Num;
                    toUpdate.Voie = adr.Voie;
                    toUpdate.NomVoie = adr.NomVoie;
                    toUpdate.CodePostal = adr.CodePostal;
                    toUpdate.Ville = adr.Ville;
                    toUpdate.Region = adr.Region;
                    toUpdate.Pays = adr.Pays;
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public async Task Update(Models.Social soc)
        {
            var context = CreateContext();
            var toCheckUsr = await context._Utilisateurs.FindAsync(soc.UserId);
            var tocheckCont = await context._Utilisateurs.FindAsync(soc.ContactId);
            var toUpdate = await context._Socials.FindAsync(soc.Id);
            if (tocheckCont!=null && toCheckUsr!=null && toUpdate!=null)
            {
                switch (soc.StatutDemContact)
                {
                    case StatuDemContact.envoyee:
                        toUpdate.StatutDemContact = 0;
                        break;
                    case StatuDemContact.approuvee:
                        toUpdate.StatutDemContact = 1;
                        break;
                    case StatuDemContact.blacklist:
                        toUpdate.StatutDemContact = 2;
                        break;
                    default:
                        toUpdate.StatutDemContact = 0;
                        break;
                }
                switch (soc.StatutContact)
                {
                    case StatuContact.connecte:
                        toUpdate.StatutContact = 0;
                        break;
                    case StatuContact.occupe:
                        toUpdate.StatutContact = 1;
                        break;
                    case StatuContact.nepasdéranger:
                        toUpdate.StatutContact = 2;
                        break;
                    case StatuContact.deretourbientot:
                        toUpdate.StatutContact = 3;
                        break;
                    case StatuContact.absent:
                        toUpdate.StatutContact = 4;
                        break;
                    case StatuContact.deconnecte:
                        toUpdate.StatutContact = 5;
                        break;
                    default:
                        toUpdate.StatutContact = 5;
                        break;
                }

                await context.SaveChangesAsync();
            }
        }
        public async Task Update(Models.AdressesUtilisateurs adusr)
        {
            var context = CreateContext();
            var toCheckUsr = await context._Utilisateurs.FindAsync(adusr.UtilisateurId);
            var toCheckAd = await context._AdressesUtilisateurs.FindAsync(adusr.AdresseId);
            var toUpdate = await context._AdressesUtilisateurs.FindAsync(adusr.UtilisateurId, adusr.AdresseId);

            if(toCheckAd!=null && toCheckUsr!=null && toUpdate!=null)
            {
                //rien à mettre à jour...
            }
        }
        #endregion

        #region DEletes
        public async Task Delete(Models.Utilisateurs util)
        {
            var context = CreateContext();
            var toDelete = await context._Utilisateurs.FindAsync(util.Id);
            if (toDelete!=null)
            {
                var soc1 = context._Socials.Where(u => u.UserId == util.Id).ToList();
                var soc2 = context._Socials.Where(u => u.ContactId == util.Id).ToList();
                var usrEnt = context._UtilisateursEntites.Where(u => u.UtilisateurId == util.Id).ToList();
                var enti = context._Entites.Where(u => u.ReprLegalId == util.Id).ToList();
                var adre = context._AdressesUtilisateurs.Where(u => u.UtilisateurId == util.Id).ToList();
                var entrp = context._Entrepots.Where(u => u.UtilisateurPropId == util.Id).ToList();

                foreach (var utilSoc in soc1)
                {
                    context._Socials.Remove(utilSoc);
                }
                foreach (var utilSoc2 in soc2)
                {
                    context._Socials.Remove(utilSoc2);
                }
                foreach(var usr in usrEnt)
                {
                    context._UtilisateursEntites.Remove(usr);
                }
                foreach(var entit in enti)
                {
                    context._Entites.Remove(entit);
                }
                foreach (var adusr in adre)
                {
                    var adresse = context._Adresse.Where(u => u.Id == adusr.AdresseId).ToList();
                    foreach (var ad in adresse)
                    { 
                        context._Adresse.Remove(ad); 
                    }
                    context._AdressesUtilisateurs.Remove(adusr);
                }
                foreach (var ent in entrp)
                {
                    context._Entrepots.Remove(ent);
                }
                context._Utilisateurs.Remove(toDelete);
                await context.SaveChangesAsync();
            }
        }
        
        public async Task Delete(Models.Pays ppays)
        {
            var contexte = CreateContext();
            var toDelete = await contexte._Pays.FindAsync(ppays.Id);
            var AdPays = contexte._Adresse.Where(u => u.Pays == ppays.Id).ToList();
            foreach (var adresse in AdPays)
            {
                Models.Adresse Ad = new Models.Adresse
                {
                    Id = adresse.Id,

                }

                await Delete((Models.Adresse)adresse);
            }
        }
        public async Task Delete(Models.Voies pvoies)
        {

        }
        public async Task Delete(Models.Adresse adr)
        {

        }
        
        public async Task Delete(Models.Social soc)
        {

        }
        public async Task Delete(Models.AdressesUtilisateurs adusr)
        {

        }
        #endregion

        #region Gets
        #endregion
    }
}
