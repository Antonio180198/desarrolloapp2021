using System.Collections.Generic;
using System;

namespace p17_repasopoo
{
    public class Nodo {

        public Nodo() => vulnerabilidades = new List<Vulnerabilidad>();

        public Nodo(string pnombrea,string pmateria,string pgrupo,int psalario,string pso,DateTime pfecha) : this() =>
            (nombrea,materia,grupo,salario,fecha) = (pnombrea,pmateria,pgrupo,psalario,pfecha);

        public string nombrea {get;  set;}
        public string materia {get;  set;}
        public string grupo {get;  set;}
        public int salario {get;  set;}
        //public string so {get;  set;}  ,so  ,pso
        public List<Vulnerabilidad> vulnerabilidades {get;  set;}

        public float PromedioMayor {
            get {
                float m=vulnerabilidades[0].prom;
                foreach (var a in vulnerabilidades)
                    if(a.prom>m) m = a.prom;
                return m;
            }
        }

        public float PromedioMenor {
            get {
                float m=vulnerabilidades[0].prom;
                foreach (var a in vulnerabilidades)
                    if(a.prom<m) m = a.prom;
                return m;
            }
        }

        public DateTime fecha {get;  set;}
        public int Antiguedad {
            get {
                return DateTime.Now.Year - fecha.Year;
            }
        }

        public int Totbecados {
            get {
                int s=0;
                foreach (var a in vulnerabilidades)
                    if(a.becado) s++;
                return s;
            }
        }

        public void AgregarVulnerabilidad(Vulnerabilidad v) => vulnerabilidades.Add(v);

        public override string ToString() => 
                $"Nombre: {nombrea,-12}  Materia: {materia,-12} Grupos: {grupo,-3} Salario: {salario,-3}  Alumnos: {vulnerabilidades.Count} " + 
                $"Fecha: {fecha.ToString("dd/mm/yy"),-8} Antiguedad: {Antiguedad.ToString()}";
                
    }

}