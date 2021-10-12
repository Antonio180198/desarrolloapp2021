using System.Collections.Generic;
using System;
namespace p17_repasopoo
{
    public class Vulnerabilidad {

        public Vulnerabilidad() {}

        public Vulnerabilidad(string pnombreb,int pedad,DateTime pfecha,bool pbecado,List<float>pcalifs) =>
            (nombreb,edad,fecha, becado,califs) = (pnombreb,pedad,pfecha,pbecado,pcalifs);

        public string nombreb {get;  set;}
        public int edad {get;  set;}
        public DateTime fecha {get;  set;}
        public bool becado {get;set;}
        public List<float> califs {get;set;}

        public int Antiguedad {
            get {
                return DateTime.Now.Year - fecha.Year;
            }
        }

        public float prom {
            get{
                float s=0;
                foreach (var c in califs) s+=c;
                return s/califs.Count;
            }
        }

        public override string ToString() =>
            $"Nombre: {nombreb,-12} Edad: {edad,-10}  Fecha: {fecha.ToString("dd/mm/yy"),-8} " +
            $"Becado: {(becado?"Si":"No")} Calificaciones: {string.Join(",",califs)} " +
            $"Prom: {prom} Mensaje: {(prom>=7?"Aprobado":"Reprobado")}";

    }
}