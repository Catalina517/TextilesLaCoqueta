using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Usar las librerias para manejo de archivos
using System.IO;

namespace CapaDatos
{
    public class CD_Empleado
    {
        //Instanciar un objeto de la clase Empleado
        private Empleado empleado = new Empleado();

        //Ruta del archivo plano
        private string rutaArchivo = @"C:\Users\catac\Desktop\prueba\TextilesLaCoqueta\empleados.txt";
       

        //Registrar un empleado
        public void RegistrarEmpleado(Empleado empleado)
        {
           string carpeta = Path.GetDirectoryName(rutaArchivo);
            if (!Directory.Exists(carpeta))
            {
                Directory.CreateDirectory(carpeta);
            }

            //AppendAllText crea el archivo si no existe
            File.AppendAllText(rutaArchivo, empleado.LineaArchivo() + Environment.NewLine);
        }

        //Buscar Empleado
        public List<Empleado> BuscarEmpleado(string codigo)
        {
            var lista = new List<Empleado>();

            if (!File.Exists(rutaArchivo))
                return lista;

            var lineas = File.ReadAllLines(rutaArchivo);
            foreach (var linea in lineas)
            {
                var emp = empleado.SepararLinea(linea);
                if (emp.Codigo == codigo)
                {
                    lista.Add(empleado.SepararLinea(linea));
                }
            }
            return lista;
        }

        //Listar Empleados
        public List<Empleado> ListarEmpleados()
        {
            var lista = new List<Empleado>();

            if (!File.Exists(rutaArchivo))
                return lista;

            var lineas = File.ReadAllLines(rutaArchivo);
            foreach (var linea in lineas)
            {
                lista.Add(empleado.SepararLinea(linea));
            }
            return lista;
        }

        //Calcular salario
        public void CalcularSalario(string salarioBase)

        {

            //Lógica para calcular el salario
            decimal salario = Convert.ToDecimal(salarioBase);
            decimal deduccionSalud = salario - (salario *0.04m);
            decimal deduccionPension = salario - (salario * 0.04m);
            if (salario < 2800000)
            {
                decimal salarioNeto = salario - (deduccionSalud + deduccionPension) + 200000;
            }
            else
            {
                decimal salarioNeto = salario - (deduccionSalud + deduccionPension);
            }

        }
    }
}
