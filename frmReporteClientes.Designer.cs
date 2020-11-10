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
            this.CINEDataSet = new FormProgramacion.CINEDataSet();
            this.TABLA_COMPLETABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TABLA_COMPLETATableAdapter = new FormProgramacion.CINEDataSetTableAdapters.TABLA_COMPLETATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CINEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TABLA_COMPLETABindingSource)).BeginInit();
            this.SuspendLayout();
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
            // frmReporteClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "frmReporteClientes";
            this.Text = "Reporte de Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.CINEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TABLA_COMPLETABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource TABLA_COMPLETABindingSource;
        private CINEDataSet CINEDataSet;
        private CINEDataSetTableAdapters.TABLA_COMPLETATableAdapter TABLA_COMPLETATableAdapter;
    }
}