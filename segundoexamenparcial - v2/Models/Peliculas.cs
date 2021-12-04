using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace segundoexamenparcial.Modelo
{
    public class Peliculas{
        [Key]
        public int TituloId {get; set;}
        [Required]
        public String titulo {get; set;}
        public String Historia {get; set;}
        [DataType(DataType.Date)]
        public DateTime FechaRealizada{get;set;}
        public int Duracion{get;set;}
        public int GeneroId {get; set;}
        public int CertificadoId {get; set;}
        public String Notas {get; set;}

        public ICollection<Peliculasdirigidasporproductores> Peliculasdirigidasporproductoress {get; set;}
        public ICollection<RolesdeActoresenPeliculas> RolesdeActoresenPeliculass {get;set;}
        public Generosdepeliculas Generosdepeliculas {get;set;}
        public CertificadosdePeliculas CertificadosdePeliculas{get;set;}
    }

    
}