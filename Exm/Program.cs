using System;
using System.IO;
using System.Collections.Generic;
using static System.Console;

namespace p17_repasopoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Red mired = null;
            //string arch = "datos.json";
            Inicializa(ref mired);
           
            /*
            if(File.Exists(arch)) {
                // cargar los datos del archivo que ya existe en disco: datos.xml
                Console.WriteLine($"Cargando los datos del archivo de disco : {arch}");
                //Utils.LeerXml(arch, ref mired);
                Utils.LeerJson(arch, ref mired);
            }
            else {
                Console.WriteLine($"Inicializando datos desde el codigo ...");
                Inicializa(ref mired);  
                // grabar los datos al disco en el archivo datos.xml
                //Utils.GrabarXml(arch, mired);
                Utils.GrabarJson(arch, mired);
            }*/

            Reporte(mired);         
        }

        static void Inicializa(ref Red mired) {
            // Inicializar datos
            mired = new Red("Universidad de Nuevo Leon ","José Ibarra Reyes","Jardin Juarez 147");
            mired.AgregarNodo(new Nodo("Sotelo","Matematicas","5A",10000,"linux",DateTime.Parse("04/12/2015")));
            mired.AgregarNodo(new Nodo("chavez","Español","2B",12000,"ios",DateTime.Parse("04/12/2015")));
            mired.AgregarNodo(new Nodo("Lopez","computación","3C",11000,"windows",DateTime.Parse("04/12/2015")));
            mired.AgregarNodo(new Nodo("Briones","Matematicas","5B",18000,"linux",DateTime.Parse("04/10/2015")));
            
            mired.nodos[0].AgregarVulnerabilidad(new Vulnerabilidad("Gabriela",22,DateTime.Parse("4/1/2015"),true,new List<float>{9,9,10}));
                
            mired.nodos[0].AgregarVulnerabilidad(new Vulnerabilidad("Andrea",23,DateTime.Parse("01/10/2011"),true,new List<float>{8,8,8}));
            mired.nodos[1].AgregarVulnerabilidad(new Vulnerabilidad("Paola", 24,DateTime.Parse("02/1/2017"),false,new List<float>{7,7,8}));
            mired.nodos[2].AgregarVulnerabilidad(new Vulnerabilidad("Stephani", 21,DateTime.Parse("11/11/2009"),false,new List<float>{6,5,8}));
            mired.nodos[2].AgregarVulnerabilidad(new Vulnerabilidad("Aurelio", 20,DateTime.Parse("12/9/2016"),true,new List<float>{8,8,8}));
            mired.nodos[2].AgregarVulnerabilidad(new Vulnerabilidad("Hector", 22,DateTime.Parse("2/12/2017"),false,new List<float>{5,8,7}));
            mired.nodos[3].AgregarVulnerabilidad(new Vulnerabilidad("Antonio", 23,DateTime.Parse("2/6/2017"),true,new List<float>{10,10,10}));
        }

        static void Reporte(Red mired) {
            // Reporte 
            Console.WriteLine("\n>> Datos de la escuela:");
            Console.WriteLine($"Nombre     : {mired.nombre}");
            Console.WriteLine($"Encargado : {mired.encargado}");
            Console.WriteLine($"Domicilio   : {mired.domicilio}");

            Console.WriteLine($"Total de Profesores : {mired.nodos.Count}");
            Console.WriteLine($"Total Alumnos : {mired.TotVuln}");
            Console.WriteLine($"Total Alumnos becados: {mired.Totbecados}");
            

            Console.WriteLine("\n>>Datos generales de los Profesores:");
            mired.nodos.ForEach(n=>Console.WriteLine(n.ToString()));
            Console.WriteLine($"Total salario profesores: {mired.Totsal} ");
            Console.WriteLine($"Mayor numero de salario: {mired.Mayor} ");
            Console.WriteLine($"Menor numero de salario: {mired.Menor} ");

            Console.WriteLine("\n>> Alumnos por Profesor:");
            foreach (var p in mired.nodos){
                WriteLine($"\nNombre:{p.nombrea}, Grupo: {p.grupo}\n");
                if(p.vulnerabilidades.Count>0){
                    p.vulnerabilidades.ForEach(a=>Console.WriteLine(a.ToString()));
                    WriteLine($"\nMayor Promedio: {p.PromedioMayor}");
                    WriteLine($"Menor Promedio: {p.PromedioMenor}");
                    WriteLine($"Total Becados: {p.Totbecados}");
                }else{WriteLine("No tiene alumnos aun");}
            }
        }
    }
}
