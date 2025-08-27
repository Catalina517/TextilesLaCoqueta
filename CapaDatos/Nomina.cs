using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Nomina
    {
        public string Codigo { get; set; }
        public string SalarioBase { get; set; }

        public string DeduccionSalud { get; set; }
        public string DeduccionPension { get; set; }
        public string SalarioNeto { get; set; }

        public Nomina() { }

        public Nomina(string codigo, string salarioBase, string deduccionSalud, string deduccionPension, string salarioNeto)
        {
            Codigo = codigo;
            SalarioBase = salarioBase;
            DeduccionSalud = deduccionSalud;
            DeduccionPension = deduccionPension;
            SalarioNeto = salarioNeto;
        }

        //Método para convertir a línea de archivo plano
        public string LineaArchivo()
        {
            return $"{Codigo},{SalarioBase},{DeduccionSalud},{DeduccionPension},{SalarioNeto}";
        }

        //Método para crear un empleado desde una línea de archivo 

        public Nomina SepararLinea(string linea)
        {
            var datos = linea.Split(',');
            return new Nomina(datos[0], datos[1], datos[2], datos[3], datos[4]);
        }
    }
}
