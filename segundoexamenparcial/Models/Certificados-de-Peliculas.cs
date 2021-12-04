using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace segundoexamenparcial.Modelo
{
    public class CertificadosdePeliculas{
        [Key]
        public String Certificado {get; set;}
        public int CertificadoId {get; set;}

        public ICollection<Peliculas> Peliculass {get; set;}
        
    }

    
}