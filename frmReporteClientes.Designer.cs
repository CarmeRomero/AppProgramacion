namespace FormProgramacion
{
    partial class frmReporteClientes
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnImprimirTodo = new System.Windows.Forms.Button();
            this.btnImprimirFiltro = new System.Windows.Forms.Button();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtEdad1 = new System.Windows.Forms.TextBox();
            this.txtEdad2 = new System.Windows.Forms.TextBox();
            this.cboTemporada = new System.Windows.Forms.ComboBox();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(28, 21);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(725, 233);
            this.reportViewer1.TabIndex = 0;
            // 
            // btnImprimirTodo
            // 
            this.btnImprimirTodo.Location = new System.Drawing.Point(54, 296);
            this.btnImprimirTodo.Name = "btnImprimirTodo";
            this.btnImprimirTodo.Size = new System.Drawing.Size(75, 37);
            this.btnImprimirTodo.TabIndex = 1;
            this.btnImprimirTodo.Text = "Imprimir Todo";
            this.btnImprimirTodo.UseVisualStyleBackColor = true;
            // 
            // btnImprimirFiltro
            // 
            this.btnImprimirFiltro.Location = new System.Drawing.Point(639, 305);
            this.btnImprimirFiltro.Name = "btnImprimirFiltro";
            this.btnImprimirFiltro.Size = new System.Drawing.Size(75, 37);
            this.btnImprimirFiltro.TabIndex = 2;
            this.btnImprimirFiltro.Text = "Imprimir Filtrado";
            this.btnImprimirFiltro.UseVisualStyleBackColor = true;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(454, 306);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(161, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // txtEdad1
            // 
            this.txtEdad1.Location = new System.Drawing.Point(454, 344);
            this.txtEdad1.Name = "txtEdad1";
            this.txtEdad1.Size = new System.Drawing.Size(38, 20);
            this.txtEdad1.TabIndex = 4;
            // 
            // txtEdad2
            // 
            this.txtEdad2.Location = new System.Drawing.Point(521, 344);
            this.txtEdad2.Name = "txtEdad2";
            this.txtEdad2.Size = new System.Drawing.Size(38, 20);
            this.txtEdad2.TabIndex = 5;
            // 
            // cboTemporada
            // 
            this.cboTemporada.FormattingEnabled = true;
            this.cboTemporada.Location = new System.Drawing.Point(454, 382);
            this.cboTemporada.Name = "cboTemporada";
            this.cboTemporada.Size = new System.Drawing.Size(137, 21);
            this.cboTemporada.TabIndex = 6;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Location = new System.Drawing.Point(454, 421);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(126, 20);
            this.dtpInicio.TabIndex = 7;
            // 
            // dtpFin
            // 
            this.dtpFin.Location = new System.Drawing.Point(454, 459);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(126, 20);
            this.dtpFin.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(370, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(352, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Edad entre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(498, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "y";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(350, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Temporada";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(332, 424);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Inicio Periodo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(349, 462);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Fin Periodo";
            // 
            // frmReporteClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.cboTemporada);
            this.Controls.Add(this.txtEdad2);
            this.Controls.Add(this.txtEdad1);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.btnImprimirFiltro);
            this.Controls.Add(this.btnImprimirTodo);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReporteClientes";
            this.Text = "Reporte de Clientes";
            this.Load += new System.EventHandler(this.frmReporteClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnImprimirTodo;
        private System.Windows.Forms.Button btnImprimirFiltro;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtEdad1;
        private System.Windows.Forms.TextBox txtEdad2;
        private System.Windows.Forms.ComboBox cboTemporada;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}