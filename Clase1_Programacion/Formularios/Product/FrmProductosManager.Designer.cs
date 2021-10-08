
namespace Clase1_Programacion.Formularios.Product
{
    partial class FrmProductosManager
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
            this.rtbProductViewer = new System.Windows.Forms.RichTextBox();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.btnSalida = new System.Windows.Forms.Button();
            this.rtbSalidas = new System.Windows.Forms.RichTextBox();
            this.cmbValoracion = new System.Windows.Forms.ComboBox();
            this.nudSalida = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalida)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbProductViewer
            // 
            this.rtbProductViewer.Location = new System.Drawing.Point(12, 85);
            this.rtbProductViewer.Name = "rtbProductViewer";
            this.rtbProductViewer.ReadOnly = true;
            this.rtbProductViewer.Size = new System.Drawing.Size(407, 253);
            this.rtbProductViewer.TabIndex = 0;
            this.rtbProductViewer.Text = "";
            // 
            // btnEntrada
            // 
            this.btnEntrada.Location = new System.Drawing.Point(167, 51);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(75, 23);
            this.btnEntrada.TabIndex = 4;
            this.btnEntrada.Text = "Entrada";
            this.btnEntrada.UseVisualStyleBackColor = true;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // btnSalida
            // 
            this.btnSalida.Location = new System.Drawing.Point(779, 51);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(75, 23);
            this.btnSalida.TabIndex = 5;
            this.btnSalida.Text = "Salida";
            this.btnSalida.UseVisualStyleBackColor = true;
            this.btnSalida.Click += new System.EventHandler(this.btnSalida_Click);
            // 
            // rtbSalidas
            // 
            this.rtbSalidas.Location = new System.Drawing.Point(447, 85);
            this.rtbSalidas.Name = "rtbSalidas";
            this.rtbSalidas.ReadOnly = true;
            this.rtbSalidas.Size = new System.Drawing.Size(407, 253);
            this.rtbSalidas.TabIndex = 6;
            this.rtbSalidas.Text = "";
            // 
            // cmbValoracion
            // 
            this.cmbValoracion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbValoracion.FormattingEnabled = true;
            this.cmbValoracion.Location = new System.Drawing.Point(474, 51);
            this.cmbValoracion.Name = "cmbValoracion";
            this.cmbValoracion.Size = new System.Drawing.Size(164, 21);
            this.cmbValoracion.TabIndex = 7;
            // 
            // nudSalida
            // 
            this.nudSalida.Location = new System.Drawing.Point(664, 51);
            this.nudSalida.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudSalida.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSalida.Name = "nudSalida";
            this.nudSalida.Size = new System.Drawing.Size(95, 20);
            this.nudSalida.TabIndex = 8;
            this.nudSalida.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FrmProductosManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 380);
            this.Controls.Add(this.nudSalida);
            this.Controls.Add(this.cmbValoracion);
            this.Controls.Add(this.rtbSalidas);
            this.Controls.Add(this.btnSalida);
            this.Controls.Add(this.btnEntrada);
            this.Controls.Add(this.rtbProductViewer);
            this.Name = "FrmProductosManager";
            this.Text = "FrmProductosManager";
            this.Load += new System.EventHandler(this.FrmProductosManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSalida)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbProductViewer;
        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.Button btnSalida;
        private System.Windows.Forms.RichTextBox rtbSalidas;
        private System.Windows.Forms.ComboBox cmbValoracion;
        private System.Windows.Forms.NumericUpDown nudSalida;
    }
}