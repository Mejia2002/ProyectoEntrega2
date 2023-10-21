using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Logica;

namespace GUI
{
    public partial class Empleado : Form
    {
        private EmpleadoService empleadoService = new EmpleadoService();
        
        
        public Empleado()
        {
            InitializeComponent();
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
  
            Entidades.Empleado nuevoEmpleado = new Entidades.Empleado
            {
                Nombre = txtNombre.Text,
                Correo = txtCorreo.Text,
                Telefono = txtTelefono.Text,
                Identificacion = txtIdentificacion.Text,
                MesE = int.Parse(txtMes.Text),
                AñoE = int.Parse(txtAño.Text),
                SalarioBase = Convert.ToDecimal(txtSalarioBase.Text),
                Bonifiacion = Convert.ToDecimal(txtBonificacion.Text),
                SalarioTotal = Convert.ToDecimal(txtSalarioTotal.Text)

            };

            empleadoService.Guardar(nuevoEmpleado);
            MessageBox.Show("Empleado guardado exitosamente.");

        }

        





        private void EmpleadoForm_Load(object sender, EventArgs e)
        {
            
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            return;
        }

       
        private void botonBuscar_Click(object sender, EventArgs e)
        {
            return;

        }

        private void botonNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();

        }

        private void Nuevo()
        {
            txtNombre.Clear();
            txtTelefono.Clear();
            txtMes.Clear();
            txtIdentificacion.Clear();
            txtAño.Clear();
            txtSalarioBase.Clear();
            txtCorreo.Clear();
            txtBonificacion.Clear();
            txtSalarioTotal.Clear();
        }

        void Salir()
        {
            this.Close();
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }
    }
}
