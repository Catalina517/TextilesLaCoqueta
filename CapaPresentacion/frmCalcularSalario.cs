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
    public partial class frmCalcularSalario : Form
    {
        public frmCalcularSalario()
        {
            InitializeComponent();
        }

        //Crear el objeto de la capa negocio
        private CN_Empleado objCN = new CN_Empleado();
        private List<object> listaEmpleados = new List<object>();

        private void LimpiarBusqueda()
        {
            txtCod.Clear();
            lblApe.Text = "-";
            lblNom.Text = "-";
            lblEdad.Text = "-";
            lblCargo.Text = "-";
            lblSalario.Text = "-";
            txtCod.Focus();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listaEmpleados = objCN.BuscarEmpleado(txtCod.Text);
            if (listaEmpleados.Count > 0)
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
