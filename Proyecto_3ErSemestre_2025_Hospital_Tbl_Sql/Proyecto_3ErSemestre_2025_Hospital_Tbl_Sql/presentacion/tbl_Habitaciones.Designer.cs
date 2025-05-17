namespace Proyecto3er_SEMESTRE_Hospital_2025
{
    partial class tbl_Habitaciones
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
            this.LblTipoHab = new System.Windows.Forms.Label();
            this.cboxTipoHabitacion = new System.Windows.Forms.ComboBox();
            this.CboxEstado = new System.Windows.Forms.ComboBox();
            this.LblEstado = new System.Windows.Forms.Label();
            this.LblCosto = new System.Windows.Forms.Label();
            this.LblCostoHabitacion = new System.Windows.Forms.Label();
            this.DgvHabitaciones = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvHabitaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTipoHab
            // 
            this.LblTipoHab.AutoSize = true;
            this.LblTipoHab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipoHab.Location = new System.Drawing.Point(48, 45);
            this.LblTipoHab.Name = "LblTipoHab";
            this.LblTipoHab.Size = new System.Drawing.Size(144, 20);
            this.LblTipoHab.TabIndex = 0;
            this.LblTipoHab.Text = "Tipo Habitacion: ";
            // 
            // cboxTipoHabitacion
            // 
            this.cboxTipoHabitacion.FormattingEnabled = true;
            this.cboxTipoHabitacion.Items.AddRange(new object[] {
            "General",
            "Maternidad",
            "Pediatria",
            "Aislamiento",
            "Observacion"});
            this.cboxTipoHabitacion.Location = new System.Drawing.Point(224, 44);
            this.cboxTipoHabitacion.Name = "cboxTipoHabitacion";
            this.cboxTipoHabitacion.Size = new System.Drawing.Size(144, 21);
            this.cboxTipoHabitacion.TabIndex = 1;
            // 
            // CboxEstado
            // 
            this.CboxEstado.FormattingEnabled = true;
            this.CboxEstado.Items.AddRange(new object[] {
            "General",
            "Maternidad",
            "Pediatria",
            "Aislamiento",
            "Observacion"});
            this.CboxEstado.Location = new System.Drawing.Point(224, 122);
            this.CboxEstado.Name = "CboxEstado";
            this.CboxEstado.Size = new System.Drawing.Size(144, 21);
            this.CboxEstado.TabIndex = 3;
            // 
            // LblEstado
            // 
            this.LblEstado.AutoSize = true;
            this.LblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstado.Location = new System.Drawing.Point(48, 122);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(76, 20);
            this.LblEstado.TabIndex = 2;
            this.LblEstado.Text = "Estado: ";
            // 
            // LblCosto
            // 
            this.LblCosto.AutoSize = true;
            this.LblCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCosto.Location = new System.Drawing.Point(48, 85);
            this.LblCosto.Name = "LblCosto";
            this.LblCosto.Size = new System.Drawing.Size(66, 20);
            this.LblCosto.TabIndex = 4;
            this.LblCosto.Text = "Costo: ";
            // 
            // LblCostoHabitacion
            // 
            this.LblCostoHabitacion.AutoSize = true;
            this.LblCostoHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCostoHabitacion.Location = new System.Drawing.Point(220, 85);
            this.LblCostoHabitacion.Name = "LblCostoHabitacion";
            this.LblCostoHabitacion.Size = new System.Drawing.Size(122, 20);
            this.LblCostoHabitacion.TabIndex = 5;
            this.LblCostoHabitacion.Text = "Imprimir costo";
            // 
            // DgvHabitaciones
            // 
            this.DgvHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvHabitaciones.Location = new System.Drawing.Point(44, 197);
            this.DgvHabitaciones.Name = "DgvHabitaciones";
            this.DgvHabitaciones.Size = new System.Drawing.Size(551, 194);
            this.DgvHabitaciones.TabIndex = 6;
            // 
            // tbl_Habitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 421);
            this.Controls.Add(this.DgvHabitaciones);
            this.Controls.Add(this.LblCostoHabitacion);
            this.Controls.Add(this.LblCosto);
            this.Controls.Add(this.CboxEstado);
            this.Controls.Add(this.LblEstado);
            this.Controls.Add(this.cboxTipoHabitacion);
            this.Controls.Add(this.LblTipoHab);
            this.Name = "tbl_Habitaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Habitaciones";
            ((System.ComponentModel.ISupportInitialize)(this.DgvHabitaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTipoHab;
        private System.Windows.Forms.ComboBox cboxTipoHabitacion;
        private System.Windows.Forms.ComboBox CboxEstado;
        private System.Windows.Forms.Label LblEstado;
        private System.Windows.Forms.Label LblCosto;
        private System.Windows.Forms.Label LblCostoHabitacion;
        private System.Windows.Forms.DataGridView DgvHabitaciones;
    }
}

