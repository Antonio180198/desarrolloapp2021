using System;
using System.ComponentModel.DataAnnotations;

namespace segundoexamenparcial.Modelo
{
    public class Productores{
        [Key]
        public int ProductorId {get; set;}
        [Required]
        public String Nombre {get; set;}
        [EmailAddress]
        public string email {get; set;}
        [Url]
        public string SitioWeb {get; set;}

        public Peliculasdirigidasporproductores Peliculasdirigidasporproductores {get;set;}
    }

    
}