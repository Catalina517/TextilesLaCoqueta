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
    public partial class frmListar : Form
    {
        public frmListar()
        {
            InitializeComponent();
        }

        private CN_Empleado objCN = new CN_Empleado();
        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvListado.DataSource = null;
            dgvListado.DataSource = objCN.ListarEmpleados();
        }
    }
}
