using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace segundoexamenparcial.Modelo
{
    public class CertificadosdePeliculas{
        [Key]
        public int CertificadoId {get; set;}
        [Required]
        public String Descripcion {get; set;}

        public ICollection<Peliculas> Peliculass {get; set;}
        
    }

    
}