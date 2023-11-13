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

            // Obtener el empleado seleccionado del DataGridView
            Empleado empleado = new Empleado
            {
                Identificacion = dataGridView1.CurrentRow.Cells[0].Value.ToString(),
                Nombre = dataGridView1.CurrentRow.Cells[1].Value.ToString(),
                Correo = dataGridView1.CurrentRow.Cells[2].Value.ToString(),
                Telefono = dataGridView1.CurrentRow.Cells[3].Value.ToString(),
                SalarioBase = decimal.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString()),
                Bonifiacion = decimal.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString()),
                MesE = int.Parse(dataGridView1.CurrentRow.Cells[6].Value.ToString()),
                AñoE = int.Parse(dataGridView1.CurrentRow.Cells[7].Value.ToString()),
                SalarioTotal = decimal.Parse(dataGridView1.CurrentRow.Cells[8].Value.ToString())
            };

            // Mostrar los datos del empleado seleccionado en los TextBox
            txtIdentificacion.Text = empleado.Identificacion;
            txtNombre.Text = empleado.Nombre;
            txtCorreo.Text = empleado.Correo;
            txtTelefono.Text = empleado.Telefono;
            txtSalarioBase.Text = empleado.SalarioBase.ToString();
            txtBonificacion.Text = empleado.Bonifiacion.ToString();
            txtMes.Text = empleado.MesE.ToString();
            txtAño.Text = empleado.AñoE.ToString();
            txtSalarioTotal.Text = empleado.SalarioTotal.ToString();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

    



    }
}
