
namespace Clase1_Programacion.Formularios
{
    partial class FormularioEmpleado
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNumId = new System.Windows.Forms.TextBox();
            this.nudSalario = new System.Windows.Forms.NumericUpDown();
            this.nudCodigo = new System.Windows.Forms.NumericUpDown();
            this.cmbContratacion = new System.Windows.Forms.ComboBox();
            this.dtpEntrada = new System.Windows.Forms.DateTimePicker();
            this.dtpSalida = new System.Windows.Forms.DateTimePicker();
            this.cmbTipoEmpleado = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblNumId = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblTipoEmpleado = new System.Windows.Forms.Label();
            this.pnlAdmin = new System.Windows.Forms.Panel();
            this.lblSalida = new System.Windows.Forms.Label();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.lblContratacion = new System.Windows.Forms.Label();
            this.pnlDocente = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCodigo)).BeginInit();
            this.pnlAdmin.SuspendLayout();
            this.pnlDocente.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(193, 76);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(211, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(193, 113);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(211, 20);
            this.txtApellido.TabIndex = 1;
            // 
            // txtNumId
            // 
            this.txtNumId.Location = new System.Drawing.Point(193, 156);
            this.txtNumId.Name = "txtNumId";
            this.txtNumId.Size = new System.Drawing.Size(211, 20);
            this.txtNumId.TabIndex = 2;
            // 
            // nudSalario
            // 
            this.nudSalario.DecimalPlaces = 2;
            this.nudSalario.Location = new System.Drawing.Point(193, 193);
            this.nudSalario.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.nudSalario.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSalario.Name = "nudSalario";
            this.nudSalario.Size = new System.Drawing.Size(120, 20);
            this.nudSalario.TabIndex = 3;
            this.nudSalario.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudCodigo
            // 
            this.nudCodigo.Location = new System.Drawing.Point(193, 39);
            this.nudCodigo.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCodigo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCodigo.Name = "nudCodigo";
            this.nudCodigo.Size = new System.Drawing.Size(120, 20);
            this.nudCodigo.TabIndex = 4;
            this.nudCodigo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbContratacion
            // 
            this.cmbContratacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbContratacion.FormattingEnabled = true;
            this.cmbContratacion.Location = new System.Drawing.Point(140, 3);
            this.cmbContratacion.Name = "cmbContratacion";
            this.cmbContratacion.Size = new System.Drawing.Size(200, 21);
            this.cmbContratacion.TabIndex = 5;
            // 
            // dtpEntrada
            // 
            this.dtpEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEntrada.Location = new System.Drawing.Point(140, 3);
            this.dtpEntrada.Name = "dtpEntrada";
            this.dtpEntrada.ShowUpDown = true;
            this.dtpEntrada.Size = new System.Drawing.Size(200, 20);
            this.dtpEntrada.TabIndex = 6;
            // 
            // dtpSalida
            // 
            this.dtpSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSalida.Location = new System.Drawing.Point(140, 43);
            this.dtpSalida.Name = "dtpSalida";
            this.dtpSalida.ShowUpDown = true;
            this.dtpSalida.Size = new System.Drawing.Size(200, 20);
            this.dtpSalida.TabIndex = 7;
            // 
            // cmbTipoEmpleado
            // 
            this.cmbTipoEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoEmpleado.FormattingEnabled = true;
            this.cmbTipoEmpleado.Location = new System.Drawing.Point(193, 231);
            this.cmbTipoEmpleado.Name = "cmbTipoEmpleado";
            this.cmbTipoEmpleado.Size = new System.Drawing.Size(200, 21);
            this.cmbTipoEmpleado.TabIndex = 8;
            this.cmbTipoEmpleado.SelectedIndexChanged += new System.EventHandler(this.cmbTipoEmpleado_SelectedIndexChanged);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(318, 345);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblCodigo.Location = new System.Drawing.Point(50, 39);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(52, 16);
            this.lblCodigo.TabIndex = 10;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblNombres.Location = new System.Drawing.Point(50, 77);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(64, 16);
            this.lblNombres.TabIndex = 11;
            this.lblNombres.Text = "Nombres";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblApellidos.Location = new System.Drawing.Point(50, 114);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(65, 16);
            this.lblApellidos.TabIndex = 12;
            this.lblApellidos.Text = "Apellidos";
            // 
            // lblNumId
            // 
            this.lblNumId.AutoSize = true;
            this.lblNumId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblNumId.Location = new System.Drawing.Point(50, 157);
            this.lblNumId.Name = "lblNumId";
            this.lblNumId.Size = new System.Drawing.Size(86, 16);
            this.lblNumId.TabIndex = 13;
            this.lblNumId.Text = "Identificacion";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblSalario.Location = new System.Drawing.Point(50, 193);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(51, 16);
            this.lblSalario.TabIndex = 14;
            this.lblSalario.Text = "Salario";
            // 
            // lblTipoEmpleado
            // 
            this.lblTipoEmpleado.AutoSize = true;
            this.lblTipoEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblTipoEmpleado.Location = new System.Drawing.Point(50, 232);
            this.lblTipoEmpleado.Name = "lblTipoEmpleado";
            this.lblTipoEmpleado.Size = new System.Drawing.Size(102, 16);
            this.lblTipoEmpleado.TabIndex = 15;
            this.lblTipoEmpleado.Text = "Tipo Empleado";
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.Controls.Add(this.lblSalida);
            this.pnlAdmin.Controls.Add(this.lblEntrada);
            this.pnlAdmin.Controls.Add(this.dtpEntrada);
            this.pnlAdmin.Controls.Add(this.dtpSalida);
            this.pnlAdmin.Location = new System.Drawing.Point(47, 267);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(351, 72);
            this.pnlAdmin.TabIndex = 16;
            this.pnlAdmin.Visible = false;
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblSalida.Location = new System.Drawing.Point(3, 47);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(97, 16);
            this.lblSalida.TabIndex = 18;
            this.lblSalida.Text = "Hora de salida";
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblEntrada.Location = new System.Drawing.Point(3, 7);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(106, 16);
            this.lblEntrada.TabIndex = 17;
            this.lblEntrada.Text = "Hora de entrada";
            // 
            // lblContratacion
            // 
            this.lblContratacion.AutoSize = true;
            this.lblContratacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblContratacion.Location = new System.Drawing.Point(-3, 4);
            this.lblContratacion.Name = "lblContratacion";
            this.lblContratacion.Size = new System.Drawing.Size(131, 16);
            this.lblContratacion.TabIndex = 18;
            this.lblContratacion.Text = "Tipo de contratacion";
            // 
            // pnlDocente
            // 
            this.pnlDocente.Controls.Add(this.cmbContratacion);
            this.pnlDocente.Controls.Add(this.lblContratacion);
            this.pnlDocente.Location = new System.Drawing.Point(53, 267);
            this.pnlDocente.Name = "pnlDocente";
            this.pnlDocente.Size = new System.Drawing.Size(345, 30);
            this.pnlDocente.TabIndex = 19;
            this.pnlDocente.Visible = false;
            // 
            // FormularioEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlDocente);
            this.Controls.Add(this.pnlAdmin);
            this.Controls.Add(this.lblTipoEmpleado);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblNumId);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cmbTipoEmpleado);
            this.Controls.Add(this.nudCodigo);
            this.Controls.Add(this.nudSalario);
            this.Controls.Add(this.txtNumId);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Name = "FormularioEmpleado";
            this.Text = "FormularioEmpleado";
            this.Load += new System.EventHandler(this.FormularioEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSalario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCodigo)).EndInit();
            this.pnlAdmin.ResumeLayout(false);
            this.pnlAdmin.PerformLayout();
            this.pnlDocente.ResumeLayout(false);
            this.pnlDocente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNumId;
        private System.Windows.Forms.NumericUpDown nudSalario;
        private System.Windows.Forms.NumericUpDown nudCodigo;
        private System.Windows.Forms.ComboBox cmbContratacion;
        private System.Windows.Forms.DateTimePicker dtpEntrada;
        private System.Windows.Forms.DateTimePicker dtpSalida;
        private System.Windows.Forms.ComboBox cmbTipoEmpleado;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblNumId;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblTipoEmpleado;
        private System.Windows.Forms.Panel pnlAdmin;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.Label lblContratacion;
        private System.Windows.Forms.Panel pnlDocente;
    }
}