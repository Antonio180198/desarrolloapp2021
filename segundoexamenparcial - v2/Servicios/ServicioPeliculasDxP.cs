using System.Collections.Generic;
using System.Linq;
using segundoexamenparcial.Modelo;
using segundoexamenparcial.Data;
using Microsoft.EntityFrameworkCore;

namespace segundoexamenparcial.Servicios {
    public class ServicioPeliculasDxP {
        private DvdContexto contexto;
        public ServicioPeliculasDxP(DvdContexto dVdContexto) => contexto = dVdContexto;

        public List<Peliculasdirigidasporproductores> ObtenerTodo(string cadenabuscar)  {
            var _Peliculasdirigidasporproductoress = contexto.
            Peliculasdirigidasporproductoress.Include(d=>d.Productores);

            var Peliculasdirigidasporproductoress = from c in _Peliculasdirigidasporproductoress select c;

            if(!string.IsNullOrEmpty(cadenabuscar)) {
                Peliculasdirigidasporproductoress = Peliculasdirigidasporproductoress.Where(c=>c.ProductorId.Equals(cadenabuscar));
            }
            return Peliculasdirigidasporproductoress.ToList();
        }

        public Peliculasdirigidasporproductores Obtener(int Id) {
            Peliculasdirigidasporproductores Peliculasdirigidasporproductores = contexto
            .Peliculasdirigidasporproductoress.Include(d=>d.Productores)
            .FirstOrDefault(e=>e.PeliculaId.Equals(Id));
            return Peliculasdirigidasporproductores;
        }
        public bool Insertar(Peliculasdirigidasporproductores Peliculasdirigidasporproductores) {
            contexto.Peliculasdirigidasporproductoress.Add(Peliculasdirigidasporproductores);
            contexto.SaveChanges();
            return true;
        }
        public bool Actualizar(Peliculasdirigidasporproductores Peliculasdirigidasporproductores) {
            contexto.Peliculasdirigidasporproductoress.Update(Peliculasdirigidasporproductores);
            contexto.SaveChanges();
            return true;
        }
        public bool Eliminar(Peliculasdirigidasporproductores Peliculasdirigidasporproductores) {
            contexto.Peliculasdirigidasporproductoress.Remove(Peliculasdirigidasporproductores);
            contexto.SaveChanges();
            return true;
        }
    }
}