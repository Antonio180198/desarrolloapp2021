using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace segundoexamenparcial.Modelo
{
    public class Peliculasdirigidasporproductores{

        public int ProductorId{get;set;}
        public int PeliculaId{get;set;}

        public Productores Productores{get;set;}
        public Peliculas Peliculas{get;set;}
    }

    
}