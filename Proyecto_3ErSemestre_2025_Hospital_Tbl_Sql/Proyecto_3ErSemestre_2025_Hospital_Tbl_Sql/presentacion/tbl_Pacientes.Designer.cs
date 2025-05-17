namespace Proyecto3er_SEMESTRE_Hospital_2025
{
    partial class tbl_Pacientes
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
            this.LblCodHab = new System.Windows.Forms.Label();
            this.LblFechaNacimiento = new System.Windows.Forms.Label();
            this.LblTipoPaciente = new System.Windows.Forms.Label();
            this.LblEstado = new System.Windows.Forms.Label();
            this.CboxTipoPaciente = new System.Windows.Forms.ComboBox();
            this.CboxEstado = new System.Windows.Forms.ComboBox();
            this.DtFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LblImprimirCodHab = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCodHab
            // 
            this.LblCodHab.AutoSize = true;
            this.LblCodHab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodHab.Location = new System.Drawing.Point(37, 19);
            this.LblCodHab.Name = "LblCodHab";
            this.LblCodHab.Size = new System.Drawing.Size(166, 20);
            this.LblCodHab.TabIndex = 1;
            this.LblCodHab.Text = "Codigo Habitación: ";
            // 
            // LblFechaNacimiento
            // 
            this.LblFechaNacimiento.AutoSize = true;
            this.LblFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaNacimiento.Location = new System.Drawing.Point(37, 67);
            this.LblFechaNacimiento.Name = "LblFechaNacimiento";
            this.LblFechaNacimiento.Size = new System.Drawing.Size(186, 20);
            this.LblFechaNacimiento.TabIndex = 2;
            this.LblFechaNacimiento.Text = "Fecha de nacimiento: ";
            // 
            // LblTipoPaciente
            // 
            this.LblTipoPaciente.AutoSize = true;
            this.LblTipoPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipoPaciente.Location = new System.Drawing.Point(37, 110);
            this.LblTipoPaciente.Name = "LblTipoPaciente";
            this.LblTipoPaciente.Size = new System.Drawing.Size(152, 20);
            this.LblTipoPaciente.TabIndex = 3;
            this.LblTipoPaciente.Text = "Tipo de paciente :";
            // 
            // LblEstado
            // 
            this.LblEstado.AutoSize = true;
            this.LblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstado.Location = new System.Drawing.Point(37, 151);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(76, 20);
            this.LblEstado.TabIndex = 4;
            this.LblEstado.Text = "Estado: ";
            // 
            // CboxTipoPaciente
            // 
            this.CboxTipoPaciente.FormattingEnabled = true;
            this.CboxTipoPaciente.Items.AddRange(new object[] {
            "Cita",
            "Emergencia",
            "Quirurgicos",
            "Infeccioso",
            "Terminal"});
            this.CboxTipoPaciente.Location = new System.Drawing.Point(250, 109);
            this.CboxTipoPaciente.Name = "CboxTipoPaciente";
            this.CboxTipoPaciente.Size = new System.Drawing.Size(161, 21);
            this.CboxTipoPaciente.TabIndex = 5;
            // 
            // CboxEstado
            // 
            this.CboxEstado.FormattingEnabled = true;
            this.CboxEstado.Items.AddRange(new object[] {
            "Estable",
            "Critico",
            "Observacion",
            "Aislamiento",
            "Fallecido"});
            this.CboxEstado.Location = new System.Drawing.Point(250, 153);
            this.CboxEstado.Name = "CboxEstado";
            this.CboxEstado.Size = new System.Drawing.Size(161, 21);
            this.CboxEstado.TabIndex = 6;
            // 
            // DtFechaNacimiento
            // 
            this.DtFechaNacimiento.Location = new System.Drawing.Point(250, 70);
            this.DtFechaNacimiento.Name = "DtFechaNacimiento";
            this.DtFechaNacimiento.Size = new System.Drawing.Size(160, 20);
            this.DtFechaNacimiento.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 193);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(612, 216);
            this.dataGridView1.TabIndex = 8;
            // 
            // LblImprimirCodHab
            // 
            this.LblImprimirCodHab.AutoSize = true;
            this.LblImprimirCodHab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblImprimirCodHab.Location = new System.Drawing.Point(246, 19);
            this.LblImprimirCodHab.Name = "LblImprimirCodHab";
            this.LblImprimirCodHab.Size = new System.Drawing.Size(164, 20);
            this.LblImprimirCodHab.TabIndex = 9;
            this.LblImprimirCodHab.Text = "Imprimir Habitación";
            // 
            // tbl_Pacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 421);
            this.Controls.Add(this.LblImprimirCodHab);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DtFechaNacimiento);
            this.Controls.Add(this.CboxEstado);
            this.Controls.Add(this.CboxTipoPaciente);
            this.Controls.Add(this.LblEstado);
            this.Controls.Add(this.LblTipoPaciente);
            this.Controls.Add(this.LblFechaNacimiento);
            this.Controls.Add(this.LblCodHab);
            this.Name = "tbl_Pacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pacientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCodHab;
        private System.Windows.Forms.Label LblFechaNacimiento;
        private System.Windows.Forms.Label LblTipoPaciente;
        private System.Windows.Forms.Label LblEstado;
        private System.Windows.Forms.ComboBox CboxTipoPaciente;
        private System.Windows.Forms.ComboBox CboxEstado;
        private System.Windows.Forms.DateTimePicker DtFechaNacimiento;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LblImprimirCodHab;
    }
}