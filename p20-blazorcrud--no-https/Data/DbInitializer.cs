using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace p20_blazorcrud__no_https.Data{
    public class DbInitializer{
        public static void Inicializar(AppDBContext context){
        
            context.Database.EnsureCreated();
            if(context.Employees.Any()){
            return;
            }
            var employees = new Employee[]{
                new Employee{EmployeeName="Carlos Castaneda Ramirez",Gender="male",City="Zacatecas",Designation="profesor"},
                new Employee{EmployeeName="Antonio Biones Escareño",Gender="male",City="Guadalupe",Designation="profesor"},
                new Employee{EmployeeName="Gabriela Huerta Acosta",Gender="female",City="Guadalupe",Designation="profesor"},
                new Employee{EmployeeName="Alejandro corro moreno",Gender="male",City="Zacatecas",Designation="trabajador"},
                new Employee{EmployeeName="Ma coception lopez",Gender="male",City="Zacatecas",Designation="intendente"}
            };
            foreach (Employee emp in employees){
                context.Employees.Add(emp);
            }
            context.SaveChanges();
        }

    }
}