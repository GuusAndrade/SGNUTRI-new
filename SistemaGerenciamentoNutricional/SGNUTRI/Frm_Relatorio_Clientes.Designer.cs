
namespace SGNUTRI
{
    partial class Frm_Relatorio_Clientes
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Relatorio_Clientes));
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new SGNUTRI.DataSet1();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.reportClientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.report_Clientes = new SGNUTRI.Report_Clientes();
            this.reportClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportClientesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportClientesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.report_Clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportClientesBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer2
            // 
            reportDataSource2.Name = "Report_Clientes";
            reportDataSource2.Value = this.DataTable1BindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "SGNUTRI.Report1.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(20, 94);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(763, 379);
            this.reportViewer2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(131, -109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(324, 38);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 33);
            this.button2.TabIndex = 4;
            this.button2.Text = "GERAR RELATORIO";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // reportClientesBindingSource1
            // 
            this.reportClientesBindingSource1.DataSource = this.report_Clientes;
            this.reportClientesBindingSource1.Position = 0;
            // 
            // report_Clientes
            // 
            this.report_Clientes.DataSetName = "Report_Clientes";
            this.report_Clientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportClientesBindingSource
            // 
            this.reportClientesBindingSource.DataSource = this.report_Clientes;
            this.reportClientesBindingSource.Position = 0;
            // 
            // reportClientesBindingSource2
            // 
            this.reportClientesBindingSource2.DataSource = this.report_Clientes;
            this.reportClientesBindingSource2.Position = 0;
            // 
            // Frm_Relatorio_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(798, 482);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_Relatorio_Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SGNUTRI | Relatorio de Clientes";
            this.Load += new System.EventHandler(this.Frm_Relatorio_Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportClientesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.report_Clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportClientesBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Report_Clientes report_Clientes;
        private System.Windows.Forms.BindingSource reportClientesBindingSource;
        private System.Windows.Forms.BindingSource reportClientesBindingSource1;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private DataSet1 DataSet1;
        private System.Windows.Forms.BindingSource reportClientesBindingSource2;
    }
}