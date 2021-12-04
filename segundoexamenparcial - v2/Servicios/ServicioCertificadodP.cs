using System.Collections.Generic;
using System.Linq;
using segundoexamenparcial.Modelo;
using segundoexamenparcial.Data;
using Microsoft.EntityFrameworkCore;

namespace segundoexamenparcial.Servicios {
    public class ServicioCertificadodP {
        private DvdContexto contexto;
        public ServicioCertificadodP(DvdContexto dVdContexto) => contexto = dVdContexto;

        public List<CertificadosdePeliculas> ObtenerTodo(string cadenabuscar)  {
            var _CertificadosdePeliculass = contexto.
            CertificadosdePeliculass.Include(d=>d.Peliculass);

            var CertificadosdePeliculass = from c in _CertificadosdePeliculass select c;

            if(!string.IsNullOrEmpty(cadenabuscar)) {
                CertificadosdePeliculass = CertificadosdePeliculass.Where(c=>c.Descripcion.Contains(cadenabuscar));
            }
            return CertificadosdePeliculass.ToList();
        }

        public CertificadosdePeliculas Obtener(int Id) {
            CertificadosdePeliculas CertificadosdePeliculas = contexto
            .CertificadosdePeliculass.Include(d=>d.Peliculass)
            .FirstOrDefault(e=>e.CertificadoId.Equals(Id));
            return CertificadosdePeliculas;
        }
        public bool Insertar(CertificadosdePeliculas CertificadosdePeliculas) {
            contexto.CertificadosdePeliculass.Add(CertificadosdePeliculas);
            contexto.SaveChanges();
            return true;
        }
        public bool Actualizar(CertificadosdePeliculas CertificadosdePeliculas) {
            contexto.CertificadosdePeliculass.Update(CertificadosdePeliculas);
            contexto.SaveChanges();
            return true;
        }
        public bool Eliminar(CertificadosdePeliculas CertificadosdePeliculas) {
            contexto.CertificadosdePeliculass.Remove(CertificadosdePeliculas);
            contexto.SaveChanges();
            return true;
        }
    }
}