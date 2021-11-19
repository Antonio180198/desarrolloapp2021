using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace segundoexamenparcial.Modelo
{
    public class Peliculas{
        //public int TituloId {get; set;}
        public String Nombrep {get; set;}
        public String Hpelicula {get; set;}
        public DateTime FechaRealizada{get;set;}
        public int Duracion{get;set;}
        public String GeneroId {get; set;}
        public int CertificadoId {get; set;}
        public String Informacion {get; set;}

        public Peliculasdirigidasporproductores Peliculasdirigidasporproductores {get; set;}
        public RolesdeActoresenPeliculas RolesdeActoresenPeliculas {get;set;}
        public ICollection<Generosdepeliculas>Generosdepeliculass {get;set;}
        public ICollection<CertificadosdePeliculas> CertificadosdePeliculass{get;set;}
    }

    
}