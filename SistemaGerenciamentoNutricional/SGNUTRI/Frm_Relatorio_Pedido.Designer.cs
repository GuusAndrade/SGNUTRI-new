
namespace SGNUTRI {
    partial class Frm_Relatorio_Pedido {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dataTable1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reportPedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Report_Pedido = new SGNUTRI.Report_Pedido();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Report_Clientes = new SGNUTRI.Report_Clientes();
            this.button1 = new System.Windows.Forms.Button();
            this.DataSet1 = new SGNUTRI.DataSet1();
            this.Report_Funcionarios = new SGNUTRI.Report_Funcionarios();
            this.reportViewer4 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportPedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Report_Pedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Report_Clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Report_Funcionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTable1BindingSource1
            // 
            this.dataTable1BindingSource1.DataMember = "DataTable1";
            this.dataTable1BindingSource1.DataSource = this.reportPedidoBindingSource;
            // 
            // reportPedidoBindingSource
            // 
            this.reportPedidoBindingSource.DataSource = this.Report_Pedido;
            this.reportPedidoBindingSource.Position = 0;
            // 
            // Report_Pedido
            // 
            this.Report_Pedido.DataSetName = "Report_Pedido";
            this.Report_Pedido.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.Report_Clientes;
            // 
            // Report_Clientes
            // 
            this.Report_Clientes.DataSetName = "Report_Clientes";
            this.Report_Clientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(438, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "GERAR RELATORIO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Report_Funcionarios
            // 
            this.Report_Funcionarios.DataSetName = "Report_Funcionarios";
            this.Report_Funcionarios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer4
            // 
            reportDataSource1.Name = "Report_Pedido";
            reportDataSource1.Value = this.dataTable1BindingSource1;
            this.reportViewer4.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer4.LocalReport.ReportEmbeddedResource = "SGNUTRI.Report4.rdlc";
            this.reportViewer4.Location = new System.Drawing.Point(4, 110);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.ServerReport.BearerToken = null;
            this.reportViewer4.Size = new System.Drawing.Size(1000, 441);
            this.reportViewer4.TabIndex = 1;
            // 
            // Frm_Relatorio_Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1016, 563);
            this.Controls.Add(this.reportViewer4);
            this.Controls.Add(this.button1);
            this.Name = "Frm_Relatorio_Pedido";
            this.Text = "SGNUTRI | Relatorio de Pedido";
            this.Load += new System.EventHandler(this.Frm_Relatorio_Pedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportPedidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Report_Pedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Report_Clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Report_Funcionarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private Report_Clientes Report_Clientes;
        private DataSet1 DataSet1;
        private Report_Funcionarios Report_Funcionarios;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer4;
        private Report_Pedido Report_Pedido;
        private System.Windows.Forms.BindingSource reportPedidoBindingSource;
        private System.Windows.Forms.BindingSource dataTable1BindingSource1;
    }
}