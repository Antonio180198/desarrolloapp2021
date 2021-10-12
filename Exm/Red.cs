using System.Collections.Generic;

namespace p17_repasopoo
{
    public class Red {

        public Red() => nodos = new List<Nodo>();

        public Red(string pnombre, string pencargado, string pdomicilio) : this() =>
            (nombre,encargado,domicilio) = (pnombre,pencargado,pdomicilio);
         
        public string nombre {get;  set;}
        public string encargado {get;  set;}
        public string domicilio {get;  set;}
        public List<Nodo> nodos {get;  set;} 
        public int Mayor {
            get {
                int m=nodos[0].salario;
                foreach (Nodo n in nodos)
                    if(n.salario>m) m = n.salario;
                return m;
            }
        }
        public int Menor {
            get {
                int m=nodos[0].salario;
                foreach (Nodo n in nodos)
                    if(n.salario<m) m = n.salario;
                return m;
            }
        }
        public int TotVuln {
            get {
                int s=0;
                foreach (Nodo n in nodos)
                     s = s + n.vulnerabilidades.Count;
                return s;
            }
        }

        public float Totsal {
            get {
                float s=0;
                foreach (Nodo n in nodos)
                     s = s + n.salario;
                return s;
            }
        }


        public float Totbecados {
            get {
                int s=0;
                foreach (var a in nodos)
                     s +=a.Totbecados;
                return s;
            }
        }
        
        public void AgregarNodo(Nodo n) => nodos.Add(n);

    }


}