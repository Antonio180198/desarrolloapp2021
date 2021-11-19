using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace segundoexamenparcial.Modelo
{
    public class Peliculasdirigidasporproductores{

        public ICollection<Productores>Productoress{get;set;}
        public ICollection<Peliculas>Peliculass{get;set;}
    }

    
}