using System.Collections.Generic;

namespace p20_blazorcrud__no_https.Data{

    public class EmployeeService{
        private AppDBContext _appDBContext;
        public EmployeeService(AppDBContext appDBContext)=> _appDBContext=appDBContext;

        //obtener todos los empleados
        public List<Employee> GetAllEmployee()=>_appDBContext.Employees.ToList();

        //obtener un solo empleado
        public Employee GetEmployee(int Id){
            Employee employee _appDBContext.Employee.FirstOrDefaul(c=>C.Id.Equals(Id));
            return employee;
        }

        //insertar un empleado
        public bool InsertEmployee(Employees employee){
            _appDBContext.Employee.Add(employee);
            _appDBContext.SaveChanges();
            return true;
        }

        //actualizar empleado
        public bool UpdateEmployee(Employees employee){
            _appDBContext.Employee.Update(employee);
            _appDBContext.SaveChanges();
            return true;
        }

        //borrar empleado
        public bool DeleteEmployee(Employees employee){
            _appDBContext.Employee.Remove(employee);
            _appDBContext.SaveChanges();
            return true;
        }
    }
}