using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace p20_blazorcrud__no_https.Data{

    public class EmployeeService{
        private AppDBContext _appDBContext;
        public EmployeeService(AppDBContext appDBContext) => _appDBContext = appDBContext;

        //obtener todos los empleados
        public List<Employee> GetAllEmployee() => _appDBContext.Employees.ToList();

        //obtener un solo empleado
        public Employee GetEmployee(int Id){
            Employee employee = _appDBContext.Employees.FirstOrDefault(c=>c.Id.Equals(Id));
            return employee;
        }

        //insertar un empleado
        public bool InsertEmployee(Employee employee){
            _appDBContext.Employees.Add(employee);
            _appDBContext.SaveChanges();
            return true;
        }

        //actualizar empleado
        public bool UpdateEmployee(Employee employee){
            _appDBContext.Employees.Update(employee);
            _appDBContext.SaveChanges();
            return true;
        }

        //borrar empleado
        public bool DeleteEmployee(Employee employee){
            _appDBContext.Employees.Remove(employee);
            _appDBContext.SaveChanges();
            return true;
        }
    }
}