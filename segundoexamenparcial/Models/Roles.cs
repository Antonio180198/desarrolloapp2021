using System;
using System.ComponentModel.DataAnnotations;

namespace segundoexamenparcial.Modelo
{
    public class Roles {

        public int RolesId {get; set;}
        public string Tipo {get; set;}

        public RolesdeActoresenPeliculas RolesdeActoresenPeliculas {get; set;}
        
    }

}