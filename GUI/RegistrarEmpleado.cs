using Entidades;
using Logica;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GUI
{
    public partial class RegistrarEmpleado : Form
    {
        private EmpleadosService empleadoService = new EmpleadosService();


        public RegistrarEmpleado()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, System.EventArgs e)
        {

            try
            {
                Empleado empleado = new Empleado
                {
                    Nombre = txtNombre.Text,
                    Correo = txtCorreo.Text,
                    Identificacion = txtIdentificacion.Text,
                    Telefono = txtTelefono.Text,
                    SalarioBase = decimal.Parse(txtSalarioBase.Text),
                    Bonifiacion = decimal.Parse(txtBonificacion.Text),
                    MesE = int.Parse(txtMes.Text),
                    AñoE = int.Parse(txtAño.Text),
                    SalarioTotal = decimal.Parse(txtSalarioTotal.Text)
                };
                empleadoService.GuardarEmpleado(empleado);

                MessageBox.Show("Empleado guardado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarTextBox();

                ActualizarDataGridView();

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error al guardar el empleado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }

        private void LimpiarTextBox()
        {
            txtNombre.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtIdentificacion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtSalarioBase.Text = string.Empty;
            txtBonificacion.Text = string.Empty;
            txtMes.Text = string.Empty;
            txtAño.Text = string.Empty;
            txtSalarioTotal.Text = string.Empty;
        }

        private void RegistrarEmpleado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'finanzaDBDataSet.Empleado' Puede moverla o quitarla según sea necesario.
            this.empleadoTableAdapter.Fill(this.finanzaDBDataSet.Empleado);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            ActualizarDataGridView();

        }

        private void ActualizarDataGridView()
        {
            // Obtener los datos actualizados de la base de datos y cargarlos en el DataGridView
            this.empleadoTableAdapter.Fill(this.finanzaDBDataSet.Empleado);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
          
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           

        }


    }
}
