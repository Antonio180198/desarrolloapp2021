using System.Collections.Generic;
using System.Linq;
using segundoexamenparcial.Modelo;
using segundoexamenparcial.Data;
using Microsoft.EntityFrameworkCore;

namespace segundoexamenparcial.Servicios {
    public class ServicioPeliculas {
        private DvdContexto contexto;
        public ServicioPeliculas(DvdContexto dVdContexto) => contexto = dVdContexto;

        public List<Peliculas> ObtenerTodo(string cadenabuscar)  {
            var _Peliculass = contexto.
            Peliculass.Include(d=>d.Peliculasdirigidasporproductoress);

            var Peliculass = from c in _Peliculass select c;

            if(!string.IsNullOrEmpty(cadenabuscar)) {
                Peliculass = Peliculass.Where(c=>c.titulo.Contains(cadenabuscar));
            }
            return Peliculass.ToList();
        }

        public Peliculas Obtener(int Id) {
            Peliculas Peliculas = contexto
            .Peliculass.Include(d=>d.Peliculasdirigidasporproductoress)
            .FirstOrDefault(e=>e.TituloId.Equals(Id));
            return Peliculas;
        }
        public bool Insertar(Peliculas Peliculas) {
            contexto.Peliculass.Add(Peliculas);
            contexto.SaveChanges();
            return true;
        }
        public bool Actualizar(Peliculas Peliculas) {
            contexto.Peliculass.Update(Peliculas);
            contexto.SaveChanges();
            return true;
        }
        public bool Eliminar(Peliculas Peliculas) {
            contexto.Peliculass.Remove(Peliculas);
            contexto.SaveChanges();
            return true;
        }
    }
}