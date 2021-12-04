using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace segundoexamenparcial.Modelo
{
    public class Roles {
        [Key]
        public int RolesId {get; set;}
        [Required]
        public string Tipo {get; set;}

        public ICollection<RolesdeActoresenPeliculas> RolesdeActoresenPeliculass {get; set;}
        
    }

}