namespace Clase1_Programacion.Formularios
{
    partial class FrmEmployee
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.nudSalario = new System.Windows.Forms.NumericUpDown();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTipoContratacion = new System.Windows.Forms.ComboBox();
            this.lblTipocontratacion = new System.Windows.Forms.Label();
            this.nudHorasExtras = new System.Windows.Forms.NumericUpDown();
            this.lblHorasExtras = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalario)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHorasExtras)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblNombre.Location = new System.Drawing.Point(23, 119);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombres";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblApellidos.Location = new System.Drawing.Point(23, 167);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(65, 16);
            this.lblApellidos.TabIndex = 1;
            this.lblApellidos.Text = "Apellidos";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblCedula.Location = new System.Drawing.Point(23, 81);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(51, 16);
            this.lblCedula.TabIndex = 2;
            this.lblCedula.Text = "Cedula";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblCodigo.Location = new System.Drawing.Point(23, 43);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(52, 16);
            this.lblCodigo.TabIndex = 3;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblSalario.Location = new System.Drawing.Point(24, 215);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(51, 16);
            this.lblSalario.TabIndex = 4;
            this.lblSalario.Text = "Salario";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblFecha.Location = new System.Drawing.Point(23, 258);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(141, 16);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "Fecha de contratacion";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(177, 43);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(182, 23);
            this.txtCodigo.TabIndex = 6;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodigo_KeyPress);
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(177, 81);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(182, 23);
            this.txtCedula.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(177, 119);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(182, 23);
            this.txtNombre.TabIndex = 8;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(177, 163);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(182, 23);
            this.txtApellido.TabIndex = 9;
            // 
            // nudSalario
            // 
            this.nudSalario.DecimalPlaces = 2;
            this.nudSalario.Location = new System.Drawing.Point(177, 208);
            this.nudSalario.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudSalario.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSalario.Name = "nudSalario";
            this.nudSalario.Size = new System.Drawing.Size(120, 23);
            this.nudSalario.TabIndex = 10;
            this.nudSalario.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(177, 254);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 23);
            this.dtpFecha.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTipocontratacion);
            this.groupBox1.Controls.Add(this.lblHorasExtras);
            this.groupBox1.Controls.Add(this.nudHorasExtras);
            this.groupBox1.Controls.Add(this.cmbTipoContratacion);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.nudSalario);
            this.groupBox1.Controls.Add(this.lblApellidos);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.lblCedula);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Controls.Add(this.txtCedula);
            this.groupBox1.Controls.Add(this.lblSalario);
            this.groupBox1.Controls.Add(this.lblFecha);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.groupBox1.Location = new System.Drawing.Point(31, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 375);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Empleados";
            // 
            // cmbTipoContratacion
            // 
            this.cmbTipoContratacion.FormattingEnabled = true;
            this.cmbTipoContratacion.Location = new System.Drawing.Point(177, 294);
            this.cmbTipoContratacion.Name = "cmbTipoContratacion";
            this.cmbTipoContratacion.Size = new System.Drawing.Size(200, 25);
            this.cmbTipoContratacion.TabIndex = 12;
            this.cmbTipoContratacion.Visible = false;
            // 
            // lblTipocontratacion
            // 
            this.lblTipocontratacion.AutoSize = true;
            this.lblTipocontratacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblTipocontratacion.Location = new System.Drawing.Point(24, 298);
            this.lblTipocontratacion.Name = "lblTipocontratacion";
            this.lblTipocontratacion.Size = new System.Drawing.Size(131, 16);
            this.lblTipocontratacion.TabIndex = 13;
            this.lblTipocontratacion.Text = "Tipo de contratacion";
            this.lblTipocontratacion.Visible = false;
            // 
            // nudHorasExtras
            // 
            this.nudHorasExtras.Location = new System.Drawing.Point(177, 341);
            this.nudHorasExtras.Name = "nudHorasExtras";
            this.nudHorasExtras.Size = new System.Drawing.Size(120, 23);
            this.nudHorasExtras.TabIndex = 14;
            this.nudHorasExtras.Visible = false;
            // 
            // lblHorasExtras
            // 
            this.lblHorasExtras.AutoSize = true;
            this.lblHorasExtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblHorasExtras.Location = new System.Drawing.Point(23, 344);
            this.lblHorasExtras.Name = "lblHorasExtras";
            this.lblHorasExtras.Size = new System.Drawing.Size(85, 16);
            this.lblHorasExtras.TabIndex = 15;
            this.lblHorasExtras.Text = "Horas Extras";
            this.lblHorasExtras.Visible = false;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(351, 424);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 16;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // FrmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 453);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmEmployee";
            this.Text = "FrmEmployee";
            ((System.ComponentModel.ISupportInitialize)(this.nudSalario)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHorasExtras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.NumericUpDown nudSalario;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbTipoContratacion;
        private System.Windows.Forms.Label lblTipocontratacion;
        private System.Windows.Forms.Label lblHorasExtras;
        private System.Windows.Forms.NumericUpDown nudHorasExtras;
        private System.Windows.Forms.Button btnCrear;
    }
}