using System.Collections.Generic;
using System.Linq;
using segundoexamenparcial.Modelo;
using segundoexamenparcial.Data;
using Microsoft.EntityFrameworkCore;

namespace segundoexamenparcial.Servicios {
    public class ServicioGeneros {
        private DvdContexto contexto;
        public ServicioGeneros(DvdContexto dVdContexto) => contexto = dVdContexto;

        public List<Generosdepeliculas> ObtenerTodo(string cadenabuscar)  {
            var _Generosdepeliculass = contexto.
            Generosdepeliculass.Include(d=>d.Peliculass);

            var Generosdepeliculass = from c in _Generosdepeliculass select c;

            if(!string.IsNullOrEmpty(cadenabuscar)) {
                Generosdepeliculass = Generosdepeliculass.Where(c=>c.Descripcion.Contains(cadenabuscar));
            }
            return Generosdepeliculass.ToList();
        }

        public Generosdepeliculas Obtener(int Id) {
            Generosdepeliculas Generosdepeliculas = contexto
            .Generosdepeliculass.Include(d=>d.Peliculass)
            .FirstOrDefault(e=>e.GenerosId.Equals(Id));
            return Generosdepeliculas;
        }
        public bool Insertar(Generosdepeliculas Generosdepeliculas) {
            contexto.Generosdepeliculass.Add(Generosdepeliculas);
            contexto.SaveChanges();
            return true;
        }
        public bool Actualizar(Generosdepeliculas Generosdepeliculas) {
            contexto.Generosdepeliculass.Update(Generosdepeliculas);
            contexto.SaveChanges();
            return true;
        }
        public bool Eliminar(Generosdepeliculas Generosdepeliculas) {
            contexto.Generosdepeliculass.Remove(Generosdepeliculas);
            contexto.SaveChanges();
            return true;
        }
    }
}