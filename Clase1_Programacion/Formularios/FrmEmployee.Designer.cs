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
            this.lblCategoriaDocente = new System.Windows.Forms.Label();
            this.cmbCategoriaDocente = new System.Windows.Forms.ComboBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.pnlDocente = new System.Windows.Forms.Panel();
            this.pnlAdmin = new System.Windows.Forms.Panel();
            this.nudHorasExtras = new System.Windows.Forms.NumericUpDown();
            this.lblHorasExtras = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalario)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pnlDocente.SuspendLayout();
            this.pnlAdmin.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.pnlAdmin);
            this.groupBox1.Controls.Add(this.pnlDocente);
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
            // lblCategoriaDocente
            // 
            this.lblCategoriaDocente.AutoSize = true;
            this.lblCategoriaDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblCategoriaDocente.Location = new System.Drawing.Point(5, 12);
            this.lblCategoriaDocente.Name = "lblCategoriaDocente";
            this.lblCategoriaDocente.Size = new System.Drawing.Size(121, 16);
            this.lblCategoriaDocente.TabIndex = 13;
            this.lblCategoriaDocente.Text = "Categoria Docente";
            // 
            // cmbCategoriaDocente
            // 
            this.cmbCategoriaDocente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoriaDocente.FormattingEnabled = true;
            this.cmbCategoriaDocente.Location = new System.Drawing.Point(158, 8);
            this.cmbCategoriaDocente.Name = "cmbCategoriaDocente";
            this.cmbCategoriaDocente.Size = new System.Drawing.Size(200, 25);
            this.cmbCategoriaDocente.TabIndex = 12;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(351, 407);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 16;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // pnlDocente
            // 
            this.pnlDocente.Controls.Add(this.lblCategoriaDocente);
            this.pnlDocente.Controls.Add(this.cmbCategoriaDocente);
            this.pnlDocente.Location = new System.Drawing.Point(19, 297);
            this.pnlDocente.Name = "pnlDocente";
            this.pnlDocente.Size = new System.Drawing.Size(358, 38);
            this.pnlDocente.TabIndex = 17;
            this.pnlDocente.Visible = false;
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.Controls.Add(this.lblHorasExtras);
            this.pnlAdmin.Controls.Add(this.nudHorasExtras);
            this.pnlAdmin.Location = new System.Drawing.Point(6, 297);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(377, 42);
            this.pnlAdmin.TabIndex = 17;
            this.pnlAdmin.Visible = false;
            // 
            // nudHorasExtras
            // 
            this.nudHorasExtras.DecimalPlaces = 2;
            this.nudHorasExtras.Location = new System.Drawing.Point(177, 3);
            this.nudHorasExtras.Name = "nudHorasExtras";
            this.nudHorasExtras.Size = new System.Drawing.Size(120, 23);
            this.nudHorasExtras.TabIndex = 0;
            // 
            // lblHorasExtras
            // 
            this.lblHorasExtras.AutoSize = true;
            this.lblHorasExtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblHorasExtras.Location = new System.Drawing.Point(16, 3);
            this.lblHorasExtras.Name = "lblHorasExtras";
            this.lblHorasExtras.Size = new System.Drawing.Size(85, 16);
            this.lblHorasExtras.TabIndex = 1;
            this.lblHorasExtras.Text = "Horas Extras";
            // 
            // FrmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 437);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmEmployee";
            this.Text = "FrmEmployee";
            this.Load += new System.EventHandler(this.FrmEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSalario)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlDocente.ResumeLayout(false);
            this.pnlDocente.PerformLayout();
            this.pnlAdmin.ResumeLayout(false);
            this.pnlAdmin.PerformLayout();
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
        private System.Windows.Forms.ComboBox cmbCategoriaDocente;
        private System.Windows.Forms.Label lblCategoriaDocente;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Panel pnlDocente;
        private System.Windows.Forms.Panel pnlAdmin;
        private System.Windows.Forms.Label lblHorasExtras;
        private System.Windows.Forms.NumericUpDown nudHorasExtras;
    }
}