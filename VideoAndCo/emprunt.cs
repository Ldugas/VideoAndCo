//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VideoAndCo
{
    using System;
    using System.Collections.Generic;
    
    public partial class emprunt
    {
        public int idEmprunt { get; set; }
        public System.DateTime dateEmprunt { get; set; }
        public int idClient { get; set; }
        public int idSupport { get; set; }
    
        public virtual client client { get; set; }
        public virtual support support { get; set; }
    }
}
