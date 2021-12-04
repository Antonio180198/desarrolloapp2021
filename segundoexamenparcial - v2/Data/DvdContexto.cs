using Microsoft.EntityFrameworkCore;
using segundoexamenparcial.Modelo;

namespace segundoexamenparcial.Data{
    public class DvdContexto : DbContext{
        public DvdContexto(DbContextOptions<DvdContexto> opciones)
        : base(opciones) {}

        public  DbSet<Actores> Actoress {get;set;}
        public  DbSet<CertificadosdePeliculas> CertificadosdePeliculass {get;set;} 
        public  DbSet<Generosdepeliculas> Generosdepeliculass {get;set;}
        public  DbSet<Peliculas> Peliculass {get;set;}
        public  DbSet<RolesdeActoresenPeliculas> RolesdeActoresenPeliculass {get;set;}
        public  DbSet<Peliculasdirigidasporproductores> Peliculasdirigidasporproductoress {get;set;}
        public  DbSet<Roles> Roless {get;set;}
        public  DbSet<Productores> Productoress{get;set;}

        protected override void OnModelCreating(ModelBuilder modelo){
            modelo.Entity<RolesdeActoresenPeliculas>().HasKey(k=> new{k.PeliculaId, k.AutorId, k.RolId});
            modelo.Entity<Peliculasdirigidasporproductores>().HasKey(k=> new{k.ProductorId, k.PeliculaId});
        }
    }
}