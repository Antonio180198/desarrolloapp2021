using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace segundoexamenparcial.Modelo
{
    public class Generosdepeliculas{
        [Key]
        public int GenerosId {get; set;}
        [Required]
        public string Descripcion {get; set;}

        public ICollection<Peliculas> Peliculass {get; set;}
    }

    
}