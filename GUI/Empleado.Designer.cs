namespace GUI
{
    partial class Empleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.txtSalarioBase = new System.Windows.Forms.TextBox();
            this.txtBonificacion = new System.Windows.Forms.TextBox();
            this.txtSalarioTotal = new System.Windows.Forms.TextBox();
            this.botonGuardar = new System.Windows.Forms.Button();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.botonSalir = new System.Windows.Forms.Button();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.botonNuevo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSalarioTotal);
            this.groupBox1.Controls.Add(this.txtBonificacion);
            this.groupBox1.Controls.Add(this.txtSalarioBase);
            this.groupBox1.Controls.Add(this.txtAño);
            this.groupBox1.Controls.Add(this.txtMes);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.txtIdentificacion);
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 307);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REGISTRO DE SULDOS A EMPLEADOS";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.botonNuevo);
            this.groupBox2.Controls.Add(this.botonBuscar);
            this.groupBox2.Controls.Add(this.botonSalir);
            this.groupBox2.Controls.Add(this.botonEliminar);
            this.groupBox2.Controls.Add(this.botonGuardar);
            this.groupBox2.Location = new System.Drawing.Point(25, 360);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(498, 66);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Correo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Identificación";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Teléfono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Salario Base";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Año";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Bonificación";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Salario Total";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(119, 39);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 9;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(119, 65);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(100, 20);
            this.txtCorreo.TabIndex = 10;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(119, 99);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(100, 20);
            this.txtIdentificacion.TabIndex = 11;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(119, 131);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 12;
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(119, 162);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(100, 20);
            this.txtMes.TabIndex = 13;
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(119, 188);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(100, 20);
            this.txtAño.TabIndex = 14;
            // 
            // txtSalarioBase
            // 
            this.txtSalarioBase.Location = new System.Drawing.Point(119, 216);
            this.txtSalarioBase.Name = "txtSalarioBase";
            this.txtSalarioBase.Size = new System.Drawing.Size(100, 20);
            this.txtSalarioBase.TabIndex = 15;
            // 
            // txtBonificacion
            // 
            this.txtBonificacion.Location = new System.Drawing.Point(119, 242);
            this.txtBonificacion.Name = "txtBonificacion";
            this.txtBonificacion.Size = new System.Drawing.Size(100, 20);
            this.txtBonificacion.TabIndex = 16;
            // 
            // txtSalarioTotal
            // 
            this.txtSalarioTotal.Location = new System.Drawing.Point(119, 268);
            this.txtSalarioTotal.Name = "txtSalarioTotal";
            this.txtSalarioTotal.Size = new System.Drawing.Size(100, 20);
            this.txtSalarioTotal.TabIndex = 17;
            // 
            // botonGuardar
            // 
            this.botonGuardar.Location = new System.Drawing.Point(13, 29);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(75, 23);
            this.botonGuardar.TabIndex = 0;
            this.botonGuardar.Text = "Guardar";
            this.botonGuardar.UseVisualStyleBackColor = true;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // botonEliminar
            // 
            this.botonEliminar.Location = new System.Drawing.Point(119, 29);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(75, 23);
            this.botonEliminar.TabIndex = 1;
            this.botonEliminar.Text = "Eliminar";
            this.botonEliminar.UseVisualStyleBackColor = true;
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(400, 29);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(75, 23);
            this.botonSalir.TabIndex = 2;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(216, 29);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(75, 23);
            this.botonBuscar.TabIndex = 3;
            this.botonBuscar.Text = "Buscar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // botonNuevo
            // 
            this.botonNuevo.Location = new System.Drawing.Point(310, 29);
            this.botonNuevo.Name = "botonNuevo";
            this.botonNuevo.Size = new System.Drawing.Size(75, 23);
            this.botonNuevo.TabIndex = 4;
            this.botonNuevo.Text = "Nuevo";
            this.botonNuevo.UseVisualStyleBackColor = true;
            this.botonNuevo.Click += new System.EventHandler(this.botonNuevo_Click);
            // 
            // Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Empleado";
            this.Text = "EMPLEADOS";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSalarioTotal;
        private System.Windows.Forms.TextBox txtBonificacion;
        private System.Windows.Forms.TextBox txtSalarioBase;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.Button botonGuardar;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.Button botonNuevo;
    }
}