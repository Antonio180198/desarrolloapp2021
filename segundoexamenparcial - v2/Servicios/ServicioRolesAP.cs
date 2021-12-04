using System.Collections.Generic;
using System.Linq;
using segundoexamenparcial.Modelo;
using segundoexamenparcial.Data;
using Microsoft.EntityFrameworkCore;

namespace segundoexamenparcial.Servicios {
    public class ServicioRolesdeActoresenPeliculas {
        private DvdContexto contexto;
        public ServicioRolesdeActoresenPeliculas(DvdContexto DVdContexto) => contexto = DVdContexto;

        public List<RolesdeActoresenPeliculas> ObtenerTodo(string cadenabuscar)  {
            var _RolesdeActoresenPeliculass = contexto.
            RolesdeActoresenPeliculass.Include(d=>d.Peliculas);

            var RolesdeActoresenPeliculass = from c in _RolesdeActoresenPeliculass select c;

            if(!string.IsNullOrEmpty(cadenabuscar)) {
                RolesdeActoresenPeliculass = RolesdeActoresenPeliculass.Where(c=>c.Personaje.Contains(cadenabuscar));
            }
            return RolesdeActoresenPeliculass.ToList();
        }

        public RolesdeActoresenPeliculas Obtener(int Id) {
            RolesdeActoresenPeliculas RolesdeActoresenPeliculas = contexto
            .RolesdeActoresenPeliculass.Include(d=>d.Peliculas)
            .FirstOrDefault(e=>e.RolId.Equals(Id));
            return RolesdeActoresenPeliculas;
        }
        public bool Insertar(RolesdeActoresenPeliculas RolesdeActoresenPeliculas) {
            contexto.RolesdeActoresenPeliculass.Add(RolesdeActoresenPeliculas);
            contexto.SaveChanges();
            return true;
        }
        public bool Actualizar(RolesdeActoresenPeliculas RolesdeActoresenPeliculas) {
            contexto.RolesdeActoresenPeliculass.Update(RolesdeActoresenPeliculas);
            contexto.SaveChanges();
            return true;
        }
        public bool Eliminar(RolesdeActoresenPeliculas RolesdeActoresenPeliculas) {
            contexto.RolesdeActoresenPeliculass.Remove(RolesdeActoresenPeliculas);
            contexto.SaveChanges();
            return true;
        }
    }
}