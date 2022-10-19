namespace pryHerreraSP3
{
    partial class frmAutoTest
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAutoTest));
            this.lblNroTurno = new System.Windows.Forms.Label();
            this.lblDominio = new System.Windows.Forms.Label();
            this.lblAnioFabricacion = new System.Windows.Forms.Label();
            this.lblTitular = new System.Windows.Forms.Label();
            this.txtNroTurno = new System.Windows.Forms.TextBox();
            this.txtDominio = new System.Windows.Forms.TextBox();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.mrcRegistro = new System.Windows.Forms.GroupBox();
            this.numAnioFabricacion = new System.Windows.Forms.NumericUpDown();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.mrcConsulta = new System.Windows.Forms.GroupBox();
            this.txtDominio6Caracteres = new System.Windows.Forms.TextBox();
            this.lblDominio6Caracteres = new System.Windows.Forms.Label();
            this.lblAnioMasAntiguo = new System.Windows.Forms.Label();
            this.lblCantidadTurnos = new System.Windows.Forms.Label();
            this.txtCantidadTurnos = new System.Windows.Forms.TextBox();
            this.txtAnioMasAntiguo = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.mrcRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAnioFabricacion)).BeginInit();
            this.mrcConsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNroTurno
            // 
            this.lblNroTurno.AutoSize = true;
            this.lblNroTurno.Location = new System.Drawing.Point(19, 30);
            this.lblNroTurno.Name = "lblNroTurno";
            this.lblNroTurno.Size = new System.Drawing.Size(90, 13);
            this.lblNroTurno.TabIndex = 0;
            this.lblNroTurno.Text = "Número de Turno";
            // 
            // lblDominio
            // 
            this.lblDominio.AutoSize = true;
            this.lblDominio.Location = new System.Drawing.Point(19, 60);
            this.lblDominio.Name = "lblDominio";
            this.lblDominio.Size = new System.Drawing.Size(45, 13);
            this.lblDominio.TabIndex = 1;
            this.lblDominio.Text = "Dominio";
            // 
            // lblAnioFabricacion
            // 
            this.lblAnioFabricacion.AutoSize = true;
            this.lblAnioFabricacion.Location = new System.Drawing.Point(19, 91);
            this.lblAnioFabricacion.Name = "lblAnioFabricacion";
            this.lblAnioFabricacion.Size = new System.Drawing.Size(84, 13);
            this.lblAnioFabricacion.TabIndex = 2;
            this.lblAnioFabricacion.Text = "Año Fabricación";
            // 
            // lblTitular
            // 
            this.lblTitular.AutoSize = true;
            this.lblTitular.Location = new System.Drawing.Point(19, 122);
            this.lblTitular.Name = "lblTitular";
            this.lblTitular.Size = new System.Drawing.Size(36, 13);
            this.lblTitular.TabIndex = 3;
            this.lblTitular.Text = "Titular";
            // 
            // txtNroTurno
            // 
            this.txtNroTurno.Location = new System.Drawing.Point(126, 27);
            this.txtNroTurno.MaxLength = 5;
            this.txtNroTurno.Name = "txtNroTurno";
            this.txtNroTurno.Size = new System.Drawing.Size(70, 20);
            this.txtNroTurno.TabIndex = 4;
            this.txtNroTurno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroTurno_KeyPress);
            // 
            // txtDominio
            // 
            this.txtDominio.Location = new System.Drawing.Point(126, 57);
            this.txtDominio.MaxLength = 7;
            this.txtDominio.Name = "txtDominio";
            this.txtDominio.Size = new System.Drawing.Size(100, 20);
            this.txtDominio.TabIndex = 5;
            this.txtDominio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDominio_KeyPress);
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(126, 119);
            this.txtTitular.MaxLength = 30;
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(209, 20);
            this.txtTitular.TabIndex = 7;
            // 
            // mrcRegistro
            // 
            this.mrcRegistro.Controls.Add(this.numAnioFabricacion);
            this.mrcRegistro.Controls.Add(this.lblTitular);
            this.mrcRegistro.Controls.Add(this.txtTitular);
            this.mrcRegistro.Controls.Add(this.lblAnioFabricacion);
            this.mrcRegistro.Controls.Add(this.txtNroTurno);
            this.mrcRegistro.Controls.Add(this.lblDominio);
            this.mrcRegistro.Controls.Add(this.lblNroTurno);
            this.mrcRegistro.Controls.Add(this.txtDominio);
            this.mrcRegistro.Location = new System.Drawing.Point(12, 12);
            this.mrcRegistro.Name = "mrcRegistro";
            this.mrcRegistro.Size = new System.Drawing.Size(354, 155);
            this.mrcRegistro.TabIndex = 8;
            this.mrcRegistro.TabStop = false;
            this.mrcRegistro.Text = "Registro de Turnos";
            // 
            // numAnioFabricacion
            // 
            this.numAnioFabricacion.Location = new System.Drawing.Point(126, 89);
            this.numAnioFabricacion.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.numAnioFabricacion.Minimum = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.numAnioFabricacion.Name = "numAnioFabricacion";
            this.numAnioFabricacion.Size = new System.Drawing.Size(58, 20);
            this.numAnioFabricacion.TabIndex = 8;
            this.numAnioFabricacion.Value = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(387, 25);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(83, 30);
            this.btnRegistrar.TabIndex = 9;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(387, 72);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(83, 30);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // mrcConsulta
            // 
            this.mrcConsulta.Controls.Add(this.txtDominio6Caracteres);
            this.mrcConsulta.Controls.Add(this.lblDominio6Caracteres);
            this.mrcConsulta.Controls.Add(this.lblAnioMasAntiguo);
            this.mrcConsulta.Controls.Add(this.lblCantidadTurnos);
            this.mrcConsulta.Controls.Add(this.txtCantidadTurnos);
            this.mrcConsulta.Controls.Add(this.txtAnioMasAntiguo);
            this.mrcConsulta.Location = new System.Drawing.Point(12, 190);
            this.mrcConsulta.Name = "mrcConsulta";
            this.mrcConsulta.Size = new System.Drawing.Size(354, 120);
            this.mrcConsulta.TabIndex = 11;
            this.mrcConsulta.TabStop = false;
            this.mrcConsulta.Text = "Estadísticas";
            // 
            // txtDominio6Caracteres
            // 
            this.txtDominio6Caracteres.Location = new System.Drawing.Point(218, 80);
            this.txtDominio6Caracteres.Name = "txtDominio6Caracteres";
            this.txtDominio6Caracteres.ReadOnly = true;
            this.txtDominio6Caracteres.Size = new System.Drawing.Size(45, 20);
            this.txtDominio6Caracteres.TabIndex = 5;
            // 
            // lblDominio6Caracteres
            // 
            this.lblDominio6Caracteres.AutoSize = true;
            this.lblDominio6Caracteres.Location = new System.Drawing.Point(19, 83);
            this.lblDominio6Caracteres.Name = "lblDominio6Caracteres";
            this.lblDominio6Caracteres.Size = new System.Drawing.Size(186, 13);
            this.lblDominio6Caracteres.TabIndex = 2;
            this.lblDominio6Caracteres.Text = "Cantidad con dominio de 6 caracteres";
            // 
            // lblAnioMasAntiguo
            // 
            this.lblAnioMasAntiguo.AutoSize = true;
            this.lblAnioMasAntiguo.Location = new System.Drawing.Point(19, 53);
            this.lblAnioMasAntiguo.Name = "lblAnioMasAntiguo";
            this.lblAnioMasAntiguo.Size = new System.Drawing.Size(104, 13);
            this.lblAnioMasAntiguo.TabIndex = 1;
            this.lblAnioMasAntiguo.Text = "Año del más Antiguo";
            // 
            // lblCantidadTurnos
            // 
            this.lblCantidadTurnos.AutoSize = true;
            this.lblCantidadTurnos.Location = new System.Drawing.Point(19, 25);
            this.lblCantidadTurnos.Name = "lblCantidadTurnos";
            this.lblCantidadTurnos.Size = new System.Drawing.Size(100, 13);
            this.lblCantidadTurnos.TabIndex = 0;
            this.lblCantidadTurnos.Text = "Cantidad de Turnos";
            // 
            // txtCantidadTurnos
            // 
            this.txtCantidadTurnos.Location = new System.Drawing.Point(218, 22);
            this.txtCantidadTurnos.Name = "txtCantidadTurnos";
            this.txtCantidadTurnos.ReadOnly = true;
            this.txtCantidadTurnos.Size = new System.Drawing.Size(45, 20);
            this.txtCantidadTurnos.TabIndex = 3;
            // 
            // txtAnioMasAntiguo
            // 
            this.txtAnioMasAntiguo.Location = new System.Drawing.Point(218, 50);
            this.txtAnioMasAntiguo.Name = "txtAnioMasAntiguo";
            this.txtAnioMasAntiguo.ReadOnly = true;
            this.txtAnioMasAntiguo.Size = new System.Drawing.Size(45, 20);
            this.txtAnioMasAntiguo.TabIndex = 4;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(387, 199);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(83, 30);
            this.btnConsultar.TabIndex = 12;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // frmAutoTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 318);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.mrcConsulta);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.mrcRegistro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAutoTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Test";
            this.Load += new System.EventHandler(this.frmAutoTest_Load);
            this.mrcRegistro.ResumeLayout(false);
            this.mrcRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAnioFabricacion)).EndInit();
            this.mrcConsulta.ResumeLayout(false);
            this.mrcConsulta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNroTurno;
        private System.Windows.Forms.Label lblDominio;
        private System.Windows.Forms.Label lblAnioFabricacion;
        private System.Windows.Forms.Label lblTitular;
        private System.Windows.Forms.TextBox txtNroTurno;
        private System.Windows.Forms.TextBox txtDominio;
        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.GroupBox mrcRegistro;
        private System.Windows.Forms.NumericUpDown numAnioFabricacion;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox mrcConsulta;
        private System.Windows.Forms.TextBox txtDominio6Caracteres;
        private System.Windows.Forms.TextBox txtAnioMasAntiguo;
        private System.Windows.Forms.TextBox txtCantidadTurnos;
        private System.Windows.Forms.Label lblDominio6Caracteres;
        private System.Windows.Forms.Label lblAnioMasAntiguo;
        private System.Windows.Forms.Label lblCantidadTurnos;
        private System.Windows.Forms.Button btnConsultar;
    }
}

