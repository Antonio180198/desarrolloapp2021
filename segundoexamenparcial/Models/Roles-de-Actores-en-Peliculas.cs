using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace segundoexamenparcial.Modelo
{
    public class RolesdeActoresenPeliculas{
        public int RolesAPId {get; set;}
        //public int AutorId {get; set;}
        //public int TypeId {get; set;}
        public string Ncaracter{get;set;}
        public string Descripcion{get;set;}

        public ICollection<Actores>Actoress{get;set;}
        public ICollection<Roles>Roless{get;set;}
        public ICollection<Peliculas>peliculass{get;set;}
    }
    
}