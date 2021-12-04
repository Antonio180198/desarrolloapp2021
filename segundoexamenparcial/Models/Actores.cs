using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace segundoexamenparcial.Modelo
{
    public class Actores {
        [Key]
        public int ActorId {get; set;}
        [Required, StringLength(50), Display(Name ="Apeido Paterno")]
        public string Apaterno {get; set;}
        [Required, StringLength(50), Display(Name ="Apeido Materno")]
        public string Amaterno {get; set;}
        [Required, StringLength(50)]
        public string Nombre {get; set;}
        [RegularExpression(@"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}$")]
        
        public string Notas {get; set;}

        [Display(Name ="Nombre Completo")]
        public string NombreCompleto {
            get {
                return $"{Apaterno} {Amaterno} {Nombre}";
            }
        }

        public ICollection<RolesdeActoresenPeliculas> RolesdeActoresenPeliculass {get; set;}
    }
}