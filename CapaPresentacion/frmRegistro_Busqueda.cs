using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmRegistro_Busqueda : Form
    {
        public frmRegistro_Busqueda()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        //Crear el objeto de la capa negocio
        private CN_Empleado objCN = new CN_Empleado();

        private void Limpiar()
        {
            txtCod.Clear();
            txtNom.Clear();
            txtApe.Clear();
            txtEdad.Clear();
            txtCargo.Clear();
            txtSalario.Clear();
            txtCod.Focus();
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Capturar los datos de los textBox
            string codigo = txtCod.Text;
            string nombre = txtNom.Text;
            string apellido = txtApe.Text;
            string edad = txtEdad.Text;
            string cargo = txtCargo.Text;
            string salarioBase = txtSalario.Text;

            //Llamar al método RegistrarEmpleado de la clase CN_Empleado
            objCN.RegistrarEmpleado(codigo, nombre, apellido, edad, cargo, salarioBase);
            MessageBox.Show("Empleado registrado correctamente");
            Limpiar();

        }

        private List<object> listaEmpleados = new List<object>();

        private void LimpiarBusqueda()
        {
            txtCodBuscar.Clear();
            lblApe.Text = "-";
            lblNom.Text = "-";
            lblEdad.Text = "-";
            lblCargo.Text = "-";
            lblSalario.Text = "-";
            txtCodBuscar.Focus();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listaEmpleados = objCN.BuscarEmpleado(txtCodBuscar.Text);
            if(listaEmpleados.Count > 0)
            {
                object empleado = listaEmpleados[0];

                var tipo = empleado.GetType();

                lblNom.Text = tipo.GetProperty("Nombre").GetValue(empleado)?.ToString();
                lblApe.Text = tipo.GetProperty("Apellido").GetValue(empleado)?.ToString();
                lblEdad.Text = tipo.GetProperty("Edad").GetValue(empleado)?.ToString();
                lblCargo.Text = tipo.GetProperty("Cargo").GetValue(empleado)?.ToString();
                lblSalario.Text = tipo.GetProperty("SalarioBase").GetValue(empleado)?.ToString();
            }
            else
            {
                MessageBox.Show("Empleado no encontrado");
                LimpiarBusqueda();
            }
        }
    }
}
