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
        public async Task<Guid> Create(Models.UtilisateursEntites utilent)
        {
            try
            { 
                var context = CreateContext();
                var util = await context._Utilisateurs.FindAsync(utilent.UtilisateurId);
                var ent = await context._Entites.FindAsync(utilent.EntiteId);
                if(util!=null && ent!=null)
                {
                    var created = new Data.UtilisateursEntites
                    {
                        UtilisateurId=utilent.UtilisateurId,
                        EntiteId=utilent.EntiteId,
                        EstPermanent=utilent.EstPermanent
                    };
                    var enr = await context
                        ._UtilisateursEntites
                        .AddAsync(created);
                    await context.SaveChangesAsync();
                    return enr.Entity.EntiteId;
                }
                else
                {
                    return utilent.UtilisateurId;
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return utilent.EntiteId;
            }
        }
        public async Task<Guid> Create(Models.Entite enti)
        {
            try
            { 
                var context = CreateContext();
                var util = await context._Utilisateurs.FindAsync(enti.ReprLegalId);
                if (util!=null)
                {
                    int T;
                    switch (enti.TypeEntite)
                    {
                        case TypoEntite.Association:
                            T = 0;
                            break;
                        case TypoEntite.Collectif:
                            T = 1;
                            break;
                        case TypoEntite.Entreprise:
                            T = 2;
                            break;
                        case TypoEntite.Particulier:
                            T = 3;
                            break;
                        case TypoEntite.Autre:
                            T = 4;
                            break;
                        default:
                            T = 0;
                            break;
                    }
                    var created = new Data.Entite
                    {
                        Id = enti.Id,
                        Nom = enti.Nom,
                        IdLegale = enti.IdLegale,
                        Logo = enti.Logo,
                        ReprLegalId = enti.ReprLegalId,
                        TypeEntite = T
                    };

                    var enr = await context
                        ._Entites
                        .AddAsync(created);
                    await context.SaveChangesAsync();
                    return enr.Entity.Id;
                }
                else
                { return enti.Id; }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return enti.Id;
            }
        }
        public async Task<Guid> Create(Models.EntiteBanque entbk)
        {
            try
            { 
                var context = CreateContext();
                var enti = await context._Entites.FindAsync(entbk.EntiteId);
                if(enti!=null)
                {
                    int T;
                    switch (entbk.TypoBk)
                    {
                        case TypoBanque.CompteBanque:
                            T = 0;
                            break;
                        case TypoBanque.Paypal:
                            T = 1;
                            break;
                        case TypoBanque.HelloAsso:
                            T = 2;
                            break;
                        default:
                            T = 0;
                            break;
                    }
                    
                    var created = new Data.EntiteBanque
                    {
                        EntiteId = entbk.EntiteId,
                        TypoBk = T,
                        Compte=entbk.Compte
                    };
                    var enr = await context
                        ._EntiteBanques
                        .AddAsync(created);
                    await context.SaveChangesAsync();
                    return enr.Entity.EntiteId;
                }
                else
                { return entbk.EntiteId; }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return entbk.EntiteId;
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
        public async Task<Guid> Create(Models.Entrepot entrp)
        {
            try
            { 
                var context = CreateContext();
                var util = await context._Utilisateurs.FindAsync(entrp.UtilisateurPropId);
                var adr = await context._Adresse.FindAsync(entrp.AdresseId);
                if (util != null && adr!=null)
                {
                    var created = new Data.Entrepot
                    {
                        Id=entrp.Id,
                        UtilisateurPropId=entrp.UtilisateurPropId,
                        AdresseId=entrp.AdresseId,
                        NomEntrepot=entrp.NomEntrepot,
                        Partage=entrp.Partage,
                    };
                    var enr = await context
                        ._Entrepots
                        .AddAsync(created);
                    await context.SaveChangesAsync();
                    return enr.Entity.Id;
                }
                else
                    return entrp.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return entrp.Id;
            }
        }
        public async Task<Guid> Create(Models.StockEntrepot stckentr )
        {
            try
            { 
                var context = CreateContext();
                var entrpt = await context._Entrepots.FindAsync(stckentr.EntrepotId);
                if (entrpt != null)
                {
                    var created = new Data.StockEntrepot
                    {
                        Id = stckentr.Id,
                        EntrepotId = stckentr.EntrepotId,
                        DesignationItem = stckentr.DesignationItem,
                        Quantite = stckentr.Quantite,
                        CheminPhoto = stckentr.CheminPhoto,
                        Photo = stckentr.Photo,
                        QRCode = stckentr.QRCode,
                        Remarque = stckentr.Remarque
                    };
                    var enr = await context
                        ._StockEntrepots
                        .AddAsync(created);
                    await context.SaveChangesAsync();
                    return enr.Entity.Id;
                }
                else
                    return stckentr.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return stckentr.Id;
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
        public async Task Update(Models.UtilisateursEntites utilent)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._UtilisateursEntites.FindAsync(utilent.EntiteId, utilent.UtilisateurId);
                if (toUpdate!=null)
                {
                    toUpdate.EstPermanent = utilent.EstPermanent;
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public async Task Update(Models.Entite enti)
        {
            try
            {
                var context = CreateContext();
                var toCheck =  await context._Utilisateurs.FindAsync(enti.ReprLegalId);
                var toUpdate = await context._Entites.FindAsync(enti.Id);
                if (toUpdate!=null && toCheck!=null)
                {
                    toUpdate.Nom = enti.Nom;
                    toUpdate.IdLegale = enti.IdLegale;
                    toUpdate.Logo = enti.Logo;
                    toUpdate.ReprLegalId = enti.ReprLegalId;
                    switch (enti.TypeEntite)
                    {
                        case TypoEntite.Association:
                            toUpdate.TypeEntite = 0;
                            break;
                        case TypoEntite.Collectif:
                            toUpdate.TypeEntite = 1;
                            break;
                        case TypoEntite.Entreprise:
                            toUpdate.TypeEntite = 2;
                            break;
                        case TypoEntite.Particulier:
                            toUpdate.TypeEntite = 3;
                            break;
                        case TypoEntite.Autre:
                            toUpdate.TypeEntite = 4;
                            break;
                        default:
                            toUpdate.TypeEntite = 0;
                            break;


                    }
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public async Task Update(Models.EntiteBanque entbk)
        {
            try
            {
                var context = CreateContext();
                int T;
                switch (entbk.TypoBk)
                {
                    case TypoBanque.CompteBanque:
                        T = 0;
                        break;
                    case TypoBanque.Paypal:
                        T = 1;
                        break;
                    case TypoBanque.HelloAsso:
                        T = 2;
                        break;
                    default:
                        T = 0;
                        break;
                }
                var toUpdate = await context._EntiteBanques.FindAsync(entbk.EntiteId, T);
                var toCheck = await context._Entites.FindAsync(entbk.EntiteId);
                if (toUpdate!=null && toCheck!=null)
                {
                    toUpdate.Compte = entbk.Compte;
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
        public async Task Update(Models.Entrepot entrp)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._Entrepots.FindAsync(entrp.Id);
                var toCheckAdr = await context._Adresse.FindAsync(entrp.AdresseId);
                var toCheckUser = await context._Utilisateurs.FindAsync(entrp.UtilisateurPropId);

                if(toUpdate!=null && toCheckAdr!=null && toCheckUser!=null)
                {
                    toUpdate.NomEntrepot = entrp.NomEntrepot;
                    toUpdate.Partage = entrp.Partage;
                    toUpdate.UtilisateurPropId = entrp.UtilisateurPropId;
                    toUpdate.AdresseId = entrp.AdresseId;
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public async Task Update(Models.StockEntrepot stckentr)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._StockEntrepots.FindAsync(stckentr.Id);
                var toCheck = await context._Entrepots.FindAsync(stckentr.EntrepotId);
                
                if (toCheck!=null && toUpdate!=null)
                {
                    toUpdate.DesignationItem = stckentr.DesignationItem;
                    toUpdate.Quantite = stckentr.Quantite;
                    toUpdate.CheminPhoto = stckentr.CheminPhoto;
                    toUpdate.EntrepotId = stckentr.EntrepotId;
                    toUpdate.Photo = stckentr.Photo;
                    toUpdate.QRCode = stckentr.QRCode;
                    toUpdate.Remarque = stckentr.Remarque;
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
        public async Task Delete (Models.UtilisateursEntites utilent)
        {
            var context = CreateContext();
            var toDelete = await context._UtilisateursEntites.FindAsync(utilent.UtilisateurId, utilent.EntiteId);
            if (toDelete != null)
            { 
                context._UtilisateursEntites.Remove(toDelete);
                await context.SaveChangesAsync();
            }

        }
        public async Task Delete(Models.Entite enti)
        {
            var context = CreateContext();
            var toDelete = await context._Entites.FindAsync(enti.Id);
            if (toDelete!=null)
            {
                var utilEnt = context._UtilisateursEntites.Where(u => u.EntiteId == enti.Id).ToList();
                var bkEnt = context._EntiteBanques.Where(u => u.EntiteId == enti.Id).ToList();
                var adEnt = context._AdressesEntites.Where(u => u.EntiteId == enti.Id).ToList();
                foreach (var membre in utilEnt)
                {
                    context._UtilisateursEntites.Remove(membre);
                }
                foreach (var banque in bkEnt)
                {
                    context._EntiteBanques.Remove(banque);
                }
                foreach (var adresse in adEnt)
                {
                    //commenté parce que l'adresse peut aussi être celui d'un utilisateur...
                    //signifie qu'il faut une routine qui supprime toutes les adresses non affectées régulièrement...
                    /*
                     * var adasupp = context._Adresse.Where(u => u.Id == adresse.AdresseId).ToList();
                    foreach (var adr1 in adasupp)
                    {
                        context._Adresse.Remove(adr1);
                    }
                    */
                    context._AdressesEntites.Remove(adresse);
                }
                context._Entites.Remove(toDelete);
                await context.SaveChangesAsync();
            }
        }
        public async Task Delete(Models.EntiteBanque entbk)
        {
            var context = CreateContext();
            int T;
            switch (entbk.TypoBk)
            {
                case TypoBanque.CompteBanque:
                    T = 0;
                    break;
                case TypoBanque.Paypal:
                    T = 1;
                    break;
                case TypoBanque.HelloAsso:
                    T = 2;
                    break;
                default:
                    T = 0;
                    break;
            }
            var toDelete = await context._EntiteBanques.FindAsync(entbk.EntiteId, T);
            if (toDelete!=null)
            {
                context._EntiteBanques.Remove(toDelete);
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
        public async Task Delete(Models.Entrepot entrp)
        {

        }
        public async Task Delete(Models.StockEntrepot stckentr)
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
