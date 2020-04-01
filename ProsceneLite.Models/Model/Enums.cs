using System;
using System.Collections.Generic;
using System.Text;

namespace ProsceneLite.Models
{
    public enum TypoEntite { Association, Collectif, Entreprise, Particulier, Autre}

    public enum TypoBanque { CompteBanque,Paypal, HelloAsso}

    public enum TypoInscription { Invitation, Publique, Mixte}

    public enum TypoStockage { Distribue, Centralise, Mixte}

    public enum TyposChampsInscription {texte, entier, decimale, booleen }

    public enum StatuDemContact { envoyee, approuvee, blacklist}

    public enum StatuContact { connecte, occupe, nepasdéranger, deretourbientot, absent, deconnecte}
}
