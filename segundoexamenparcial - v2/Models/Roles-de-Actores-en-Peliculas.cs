using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace segundoexamenparcial.Modelo
{
    public class RolesdeActoresenPeliculas{
        public int PeliculaId {get; set;}
        public int AutorId {get; set;}
        public int RolId {get; set;}
        public string Personaje{get;set;}
        public string Descripcion{get;set;}

        public Actores Actores{get;set;}
        public Roles Roles{get;set;}
        public Peliculas Peliculas{get;set;}
    }
    
}