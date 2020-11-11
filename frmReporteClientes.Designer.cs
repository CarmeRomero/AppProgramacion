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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
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
            this.CINEDataSet = new FormProgramacion.CINEDataSet();
            this.TABLA_COMPLETABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TABLA_COMPLETATableAdapter = new FormProgramacion.CINEDataSetTableAdapters.TABLA_COMPLETATableAdapter();
            this.chkEdades = new System.Windows.Forms.CheckBox();
            this.chkTemporada = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.CINEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TABLA_COMPLETABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.TABLA_COMPLETABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FormProgramacion.rptClientes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 21);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(822, 407);
            this.reportViewer1.TabIndex = 0;
            // 
            // btnImprimirTodo
            // 
            this.btnImprimirTodo.Location = new System.Drawing.Point(69, 447);
            this.btnImprimirTodo.Name = "btnImprimirTodo";
            this.btnImprimirTodo.Size = new System.Drawing.Size(75, 37);
            this.btnImprimirTodo.TabIndex = 1;
            this.btnImprimirTodo.Text = "Imprimir Todo";
            this.btnImprimirTodo.UseVisualStyleBackColor = true;
            this.btnImprimirTodo.Click += new System.EventHandler(this.btnImprimirTodo_Click);
            // 
            // btnImprimirFiltro
            // 
            this.btnImprimirFiltro.Location = new System.Drawing.Point(69, 508);
            this.btnImprimirFiltro.Name = "btnImprimirFiltro";
            this.btnImprimirFiltro.Size = new System.Drawing.Size(75, 37);
            this.btnImprimirFiltro.TabIndex = 2;
            this.btnImprimirFiltro.Text = "Imprimir Filtrado";
            this.btnImprimirFiltro.UseVisualStyleBackColor = true;
            this.btnImprimirFiltro.Click += new System.EventHandler(this.btnImprimirFiltro_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(340, 451);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(161, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // txtEdad1
            // 
            this.txtEdad1.Location = new System.Drawing.Point(340, 489);
            this.txtEdad1.MaxLength = 3;
            this.txtEdad1.Name = "txtEdad1";
            this.txtEdad1.Size = new System.Drawing.Size(38, 20);
            this.txtEdad1.TabIndex = 4;
            this.txtEdad1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdad1_KeyPress);
            // 
            // txtEdad2
            // 
            this.txtEdad2.Location = new System.Drawing.Point(407, 489);
            this.txtEdad2.MaxLength = 3;
            this.txtEdad2.Name = "txtEdad2";
            this.txtEdad2.Size = new System.Drawing.Size(38, 20);
            this.txtEdad2.TabIndex = 5;
            this.txtEdad2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdad1_KeyPress);
            // 
            // cboTemporada
            // 
            this.cboTemporada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTemporada.FormattingEnabled = true;
            this.cboTemporada.Location = new System.Drawing.Point(340, 533);
            this.cboTemporada.Name = "cboTemporada";
            this.cboTemporada.Size = new System.Drawing.Size(105, 21);
            this.cboTemporada.TabIndex = 6;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Location = new System.Drawing.Point(662, 452);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(126, 20);
            this.dtpInicio.TabIndex = 7;
            // 
            // dtpFin
            // 
            this.dtpFin.Location = new System.Drawing.Point(662, 490);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(126, 20);
            this.dtpFin.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(256, 452);
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
            this.label2.Location = new System.Drawing.Point(238, 490);
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
            this.label3.Location = new System.Drawing.Point(384, 489);
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
            this.label4.Location = new System.Drawing.Point(236, 533);
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
            this.label5.Location = new System.Drawing.Point(540, 455);
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
            this.label6.Location = new System.Drawing.Point(557, 493);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Fin Periodo";
            // 
            // CINEDataSet
            // 
            this.CINEDataSet.DataSetName = "CINEDataSet";
            this.CINEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TABLA_COMPLETABindingSource
            // 
            this.TABLA_COMPLETABindingSource.DataMember = "TABLA_COMPLETA";
            this.TABLA_COMPLETABindingSource.DataSource = this.CINEDataSet;
            // 
            // TABLA_COMPLETATableAdapter
            // 
            this.TABLA_COMPLETATableAdapter.ClearBeforeFill = true;
            // 
            // chkEdades
            // 
            this.chkEdades.AutoSize = true;
            this.chkEdades.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.chkEdades.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.chkEdades.Location = new System.Drawing.Point(451, 481);
            this.chkEdades.Name = "chkEdades";
            this.chkEdades.Size = new System.Drawing.Size(91, 42);
            this.chkEdades.TabIndex = 16;
            this.chkEdades.Text = "Habilitar \r\nRango";
            this.chkEdades.UseVisualStyleBackColor = true;
            this.chkEdades.CheckedChanged += new System.EventHandler(this.chkEdades_CheckedChanged);
            // 
            // chkTemporada
            // 
            this.chkTemporada.AutoSize = true;
            this.chkTemporada.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.chkTemporada.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.chkTemporada.Location = new System.Drawing.Point(451, 525);
            this.chkTemporada.Name = "chkTemporada";
            this.chkTemporada.Size = new System.Drawing.Size(105, 42);
            this.chkTemporada.TabIndex = 17;
            this.chkTemporada.Text = "Habilitar \r\nTemporada";
            this.chkTemporada.UseVisualStyleBackColor = true;
            this.chkTemporada.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // frmReporteClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(846, 577);
            this.Controls.Add(this.chkTemporada);
            this.Controls.Add(this.chkEdades);
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
            ((System.ComponentModel.ISupportInitialize)(this.CINEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TABLA_COMPLETABindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource TABLA_COMPLETABindingSource;
        private CINEDataSet CINEDataSet;
        private CINEDataSetTableAdapters.TABLA_COMPLETATableAdapter TABLA_COMPLETATableAdapter;
        private System.Windows.Forms.CheckBox chkEdades;
        private System.Windows.Forms.CheckBox chkTemporada;
    }
}