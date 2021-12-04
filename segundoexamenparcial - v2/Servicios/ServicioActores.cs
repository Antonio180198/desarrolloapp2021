using System.Collections.Generic;
using System.Linq;
using segundoexamenparcial.Modelo;
using segundoexamenparcial.Data;
using Microsoft.EntityFrameworkCore;

namespace segundoexamenparcial.Servicios {
    public class ServicioActores {
        private DvdContexto contexto;
        public ServicioActores(DvdContexto dVdContexto) => contexto = dVdContexto;

        public List<Actores> ObtenerTodo(string cadenabuscar)  {
            var _actoress = contexto.
            Actoress.Include(d=>d.RolesdeActoresenPeliculass);

            var actoress = from c in _actoress select c;

            if(!string.IsNullOrEmpty(cadenabuscar)) {
                actoress = actoress.Where(c=>c.Nombre.Contains(cadenabuscar));
            }
            return actoress.ToList();
        }

        public Actores Obtener(int Id) {
            Actores actores = contexto
            .Actoress.Include(d=>d.RolesdeActoresenPeliculass)
            .FirstOrDefault(e=>e.ActorId.Equals(Id));
            return actores;
        }
        public bool Insertar(Actores actores) {
            contexto.Actoress.Add(actores);
            contexto.SaveChanges();
            return true;
        }
        public bool Actualizar(Actores actores) {
            contexto.Actoress.Update(actores);
            contexto.SaveChanges();
            return true;
        }
        public bool Eliminar(Actores actores) {
            contexto.Actoress.Remove(actores);
            contexto.SaveChanges();
            return true;
        }
    }
}