using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Empleado
    {
        //Instancias un objeto de la clase CD_Empleado
        private CD_Empleado objEmpleado = new CD_Empleado();

        //Método para llamar al método RegistrarEmpleado de la clase CD_Empleado
        public void RegistrarEmpleado(string codigo, string nombre, string apellido, string edad, string cargo, string salarioBase)
        {
           Empleado empleado = new Empleado 
           {
               Codigo = codigo,
               Nombre = nombre,
               Apellido = apellido,
               Edad = edad,
               Cargo = cargo,
               SalarioBase = salarioBase
           };
            objEmpleado.RegistrarEmpleado(empleado);
        }

        //Método para llamar al método BuscarEmpleado de la clase CD_Empleado
        public List<object> BuscarEmpleado(string codigo)
        {
            List<object> listaEmpleados = new List<object>();
            foreach (var emp in objEmpleado.BuscarEmpleado(codigo))
            {
                listaEmpleados.Add(emp);
            }

            return listaEmpleados;
        }

        //Método para llamar al método ListarEmpleados de la clase CD_Empleado
        public List<object> ListarEmpleados()
        {
            List<object> listaEmpleados = new List<object>();
            foreach (var emp in objEmpleado.ListarEmpleados())
            {
                listaEmpleados.Add(emp);
            }
            return listaEmpleados;
        }
    }
}
