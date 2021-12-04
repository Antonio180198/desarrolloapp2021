using System.Collections.Generic;
using System.Linq;
using segundoexamenparcial.Modelo;
using segundoexamenparcial.Data;
using Microsoft.EntityFrameworkCore;

namespace segundoexamenparcial.Servicios {
    public class ServicioProductores {
        private DvdContexto contexto;
        public ServicioProductores(DvdContexto dVdContexto) => contexto = dVdContexto;

        public List<Productores> ObtenerTodo(string cadenabuscar)  {
            var _Productoress = contexto.
            Productoress.Include(d=>d.Peliculasdirigidasporproductores);

            var Productoress = from c in _Productoress select c;

            if(!string.IsNullOrEmpty(cadenabuscar)) {
                Productoress = Productoress.Where(c=>c.Nombre.Contains(cadenabuscar));
            }
            return Productoress.ToList();
        }

        public Productores Obtener(int Id) {
            Productores Productores = contexto
            .Productoress.Include(d=>d.Peliculasdirigidasporproductores)
            .FirstOrDefault(e=>e.ProductorId.Equals(Id));
            return Productores;
        }
        public bool Insertar(Productores Productores) {
            contexto.Productoress.Add(Productores);
            contexto.SaveChanges();
            return true;
        }
        public bool Actualizar(Productores Productores) {
            contexto.Productoress.Update(Productores);
            contexto.SaveChanges();
            return true;
        }
        public bool Eliminar(Productores Productores) {
            contexto.Productoress.Remove(Productores);
            contexto.SaveChanges();
            return true;
        }
    }
}