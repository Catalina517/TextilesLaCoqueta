using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Empleado
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Edad { get; set; }
        public string Cargo { get; set; }
        public string SalarioBase { get; set; }

        public Empleado() { }

        public Empleado(string codigo, string nombre, string apellido, string edad, string cargo, string salarioBase)
        {
            Codigo = codigo;
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Cargo = cargo;
            SalarioBase = salarioBase;
        }

        //Método para convertir a línea de archivo plano
        public string LineaArchivo()
        {
            return $"{Codigo},{Nombre},{Apellido},{Edad},{Cargo},{SalarioBase}";
        }

        //Método para crear un empleado desde una línea de archivo 

        public Empleado SepararLinea(string linea)
        {
            var datos = linea.Split(',');
            return new Empleado(datos[0], datos[1], datos[2], datos[3], datos[4], datos[5]);
        }

        
    }
}
