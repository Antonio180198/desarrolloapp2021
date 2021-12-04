using System;
using System.ComponentModel.DataAnnotations;

namespace segundoexamenparcial.Modelo
{
    public class Productores{
        [Key]
        public int ProductorId {get; set;}
        public String Nombre {get; set;}
        public string email {get; set;}
        public string SitioWeb {get; set;}

        public Peliculasdirigidasporproductores Peliculasdirigidasporproductores {get;set;}
    }

    
}