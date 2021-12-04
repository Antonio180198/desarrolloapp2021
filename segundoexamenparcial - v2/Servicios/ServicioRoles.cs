using System.Collections.Generic;
using System.Linq;
using segundoexamenparcial.Modelo;
using segundoexamenparcial.Data;
using Microsoft.EntityFrameworkCore;

namespace segundoexamenparcial.Servicios {
    public class ServicioRoles {
        private DvdContexto contexto;
        public ServicioRoles(DvdContexto dVdContexto) => contexto = dVdContexto;

        public List<Roles> ObtenerTodo(string cadenabuscar)  {
            var _Roless = contexto.
            Roless.Include(d=>d.RolesdeActoresenPeliculass);

            var Roless = from c in _Roless select c;

            if(!string.IsNullOrEmpty(cadenabuscar)) {
                Roless = Roless.Where(c=>c.Tipo.Contains(cadenabuscar));
            }
            return Roless.ToList();
        }

        public Roles Obtener(int Id) {
            Roles Roles = contexto
            .Roless.Include(d=>d.RolesdeActoresenPeliculass)
            .FirstOrDefault(e=>e.RolesId.Equals(Id));
            return Roles;
        }
        public bool Insertar(Roles Roles) {
            contexto.Roless.Add(Roles);
            contexto.SaveChanges();
            return true;
        }
        public bool Actualizar(Roles Roles) {
            contexto.Roless.Update(Roles);
            contexto.SaveChanges();
            return true;
        }
        public bool Eliminar(Roles Roles) {
            contexto.Roless.Remove(Roles);
            contexto.SaveChanges();
            return true;
        }
    }
}