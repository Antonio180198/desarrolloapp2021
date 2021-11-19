using System;
using System.ComponentModel.DataAnnotations;

namespace segundoexamenparcial.Modelo
{
    public class Productores{

        public int ProductorId {get; set;}
        public String NProductor {get; set;}
        public string email {get; set;}
        public string SitioWeb {get; set;}

        public Peliculasdirigidasporproductores Peliculasdirigidasporproductores {get;set;}
    }

    
}