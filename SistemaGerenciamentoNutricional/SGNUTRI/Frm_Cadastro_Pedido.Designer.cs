
namespace SGNUTRI
{
    partial class Frm_Cadastro_Pedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cadastro_Pedido));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_PEDIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qUANTIDADEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATACOMPRADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORFINALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fORMAPAGAMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpedidoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.heroku_ba59f508f074af3DataSet6 = new SGNUTRI.heroku_ba59f508f074af3DataSet6();
            this.tbpedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.heroku_ba59f508f074af3DataSet3 = new SGNUTRI.heroku_ba59f508f074af3DataSet3();
            this.herokuba59f508f074af3DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.heroku_ba59f508f074af3DataSet = new SGNUTRI.heroku_ba59f508f074af3DataSet();
            this.Sair = new System.Windows.Forms.Button();
            this.Voltar = new System.Windows.Forms.Button();
            this.Proximo = new System.Windows.Forms.Button();
            this.Deletar = new System.Windows.Forms.Button();
            this.heroku_ba59f508f074af3DataSet2 = new SGNUTRI.heroku_ba59f508f074af3DataSet2();
            this.herokuba59f508f074af3DataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbpedidoTableAdapter = new SGNUTRI.heroku_ba59f508f074af3DataSet3TableAdapters.tbpedidoTableAdapter();
            this.PEDIDOS = new System.Windows.Forms.Label();
            this.tbpedidoTableAdapter1 = new SGNUTRI.heroku_ba59f508f074af3DataSet6TableAdapters.tbpedidoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpedidoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heroku_ba59f508f074af3DataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heroku_ba59f508f074af3DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.herokuba59f508f074af3DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heroku_ba59f508f074af3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heroku_ba59f508f074af3DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.herokuba59f508f074af3DataSet2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PEDIDO,
            this.qUANTIDADEDataGridViewTextBoxColumn,
            this.dATACOMPRADataGridViewTextBoxColumn,
            this.vALORFINALDataGridViewTextBoxColumn,
            this.fORMAPAGAMENTODataGridViewTextBoxColumn,
            this.sTATUSDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbpedidoBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(57, 72);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(966, 455);
            this.dataGridView1.TabIndex = 40;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID_PEDIDO
            // 
            this.ID_PEDIDO.DataPropertyName = "ID_PEDIDO";
            this.ID_PEDIDO.HeaderText = "ID_PEDIDO";
            this.ID_PEDIDO.MinimumWidth = 8;
            this.ID_PEDIDO.Name = "ID_PEDIDO";
            this.ID_PEDIDO.Width = 150;
            // 
            // qUANTIDADEDataGridViewTextBoxColumn
            // 
            this.qUANTIDADEDataGridViewTextBoxColumn.DataPropertyName = "QUANTIDADE";
            this.qUANTIDADEDataGridViewTextBoxColumn.HeaderText = "QUANTIDADE";
            this.qUANTIDADEDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.qUANTIDADEDataGridViewTextBoxColumn.Name = "qUANTIDADEDataGridViewTextBoxColumn";
            this.qUANTIDADEDataGridViewTextBoxColumn.Width = 150;
            // 
            // dATACOMPRADataGridViewTextBoxColumn
            // 
            this.dATACOMPRADataGridViewTextBoxColumn.DataPropertyName = "DATA_COMPRA";
            this.dATACOMPRADataGridViewTextBoxColumn.HeaderText = "DATA_COMPRA";
            this.dATACOMPRADataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dATACOMPRADataGridViewTextBoxColumn.Name = "dATACOMPRADataGridViewTextBoxColumn";
            this.dATACOMPRADataGridViewTextBoxColumn.Width = 150;
            // 
            // vALORFINALDataGridViewTextBoxColumn
            // 
            this.vALORFINALDataGridViewTextBoxColumn.DataPropertyName = "VALOR_FINAL";
            this.vALORFINALDataGridViewTextBoxColumn.HeaderText = "VALOR_FINAL";
            this.vALORFINALDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.vALORFINALDataGridViewTextBoxColumn.Name = "vALORFINALDataGridViewTextBoxColumn";
            this.vALORFINALDataGridViewTextBoxColumn.Width = 150;
            // 
            // fORMAPAGAMENTODataGridViewTextBoxColumn
            // 
            this.fORMAPAGAMENTODataGridViewTextBoxColumn.DataPropertyName = "FORMA_PAGAMENTO";
            this.fORMAPAGAMENTODataGridViewTextBoxColumn.HeaderText = "FORMA_PAGAMENTO";
            this.fORMAPAGAMENTODataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fORMAPAGAMENTODataGridViewTextBoxColumn.Name = "fORMAPAGAMENTODataGridViewTextBoxColumn";
            this.fORMAPAGAMENTODataGridViewTextBoxColumn.Width = 150;
            // 
            // sTATUSDataGridViewTextBoxColumn
            // 
            this.sTATUSDataGridViewTextBoxColumn.DataPropertyName = "STATUS";
            this.sTATUSDataGridViewTextBoxColumn.HeaderText = "STATUS";
            this.sTATUSDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sTATUSDataGridViewTextBoxColumn.Name = "sTATUSDataGridViewTextBoxColumn";
            this.sTATUSDataGridViewTextBoxColumn.Width = 150;
            // 
            // tbpedidoBindingSource1
            // 
            this.tbpedidoBindingSource1.DataMember = "tbpedido";
            this.tbpedidoBindingSource1.DataSource = this.heroku_ba59f508f074af3DataSet6;
            // 
            // heroku_ba59f508f074af3DataSet6
            // 
            this.heroku_ba59f508f074af3DataSet6.DataSetName = "heroku_ba59f508f074af3DataSet6";
            this.heroku_ba59f508f074af3DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbpedidoBindingSource
            // 
            this.tbpedidoBindingSource.DataMember = "tbpedido";
            this.tbpedidoBindingSource.DataSource = this.heroku_ba59f508f074af3DataSet3;
            // 
            // heroku_ba59f508f074af3DataSet3
            // 
            this.heroku_ba59f508f074af3DataSet3.DataSetName = "heroku_ba59f508f074af3DataSet3";
            this.heroku_ba59f508f074af3DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // herokuba59f508f074af3DataSetBindingSource
            // 
            this.herokuba59f508f074af3DataSetBindingSource.DataSource = this.heroku_ba59f508f074af3DataSet;
            this.herokuba59f508f074af3DataSetBindingSource.Position = 0;
            // 
            // heroku_ba59f508f074af3DataSet
            // 
            this.heroku_ba59f508f074af3DataSet.DataSetName = "heroku_ba59f508f074af3DataSet";
            this.heroku_ba59f508f074af3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Sair
            // 
            this.Sair.Location = new System.Drawing.Point(896, 538);
            this.Sair.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(128, 58);
            this.Sair.TabIndex = 48;
            this.Sair.Text = "SAIR";
            this.Sair.UseVisualStyleBackColor = true;
            this.Sair.Click += new System.EventHandler(this.button4_Click);
            // 
            // Voltar
            // 
            this.Voltar.Location = new System.Drawing.Point(56, 538);
            this.Voltar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(204, 58);
            this.Voltar.TabIndex = 47;
            this.Voltar.Text = "ANTERIOR";
            this.Voltar.UseVisualStyleBackColor = true;
            this.Voltar.Click += new System.EventHandler(this.button3_Click);
            // 
            // Proximo
            // 
            this.Proximo.Location = new System.Drawing.Point(276, 538);
            this.Proximo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Proximo.Name = "Proximo";
            this.Proximo.Size = new System.Drawing.Size(204, 58);
            this.Proximo.TabIndex = 46;
            this.Proximo.Text = "PROXIMO";
            this.Proximo.UseVisualStyleBackColor = true;
            this.Proximo.Click += new System.EventHandler(this.button2_Click);
            // 
            // Deletar
            // 
            this.Deletar.Location = new System.Drawing.Point(676, 538);
            this.Deletar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Deletar.Name = "Deletar";
            this.Deletar.Size = new System.Drawing.Size(204, 58);
            this.Deletar.TabIndex = 45;
            this.Deletar.Text = "DELETAR PEDIDO";
            this.Deletar.UseVisualStyleBackColor = true;
            this.Deletar.Click += new System.EventHandler(this.button1_Click);
            // 
            // heroku_ba59f508f074af3DataSet2
            // 
            this.heroku_ba59f508f074af3DataSet2.DataSetName = "heroku_ba59f508f074af3DataSet2";
            this.heroku_ba59f508f074af3DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // herokuba59f508f074af3DataSet2BindingSource
            // 
            this.herokuba59f508f074af3DataSet2BindingSource.DataSource = this.heroku_ba59f508f074af3DataSet2;
            this.herokuba59f508f074af3DataSet2BindingSource.Position = 0;
            // 
            // tbpedidoTableAdapter
            // 
            this.tbpedidoTableAdapter.ClearBeforeFill = true;
            // 
            // PEDIDOS
            // 
            this.PEDIDOS.AutoSize = true;
            this.PEDIDOS.Font = new System.Drawing.Font("Constantia", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.PEDIDOS.ForeColor = System.Drawing.SystemColors.Control;
            this.PEDIDOS.Location = new System.Drawing.Point(317, 17);
            this.PEDIDOS.Name = "PEDIDOS";
            this.PEDIDOS.Size = new System.Drawing.Size(482, 50);
            this.PEDIDOS.TabIndex = 50;
            this.PEDIDOS.Text = "PEDIDOS (resolver bug)";
            // 
            // tbpedidoTableAdapter1
            // 
            this.tbpedidoTableAdapter1.ClearBeforeFill = true;
            // 
            // Frm_Cadastro_Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1078, 638);
            this.Controls.Add(this.PEDIDOS);
            this.Controls.Add(this.Sair);
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.Proximo);
            this.Controls.Add(this.Deletar);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Cadastro_Pedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SGNUTRI | Pedidos";
            this.Load += new System.EventHandler(this.Frm_Registrar_Pedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpedidoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heroku_ba59f508f074af3DataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpedidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heroku_ba59f508f074af3DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.herokuba59f508f074af3DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heroku_ba59f508f074af3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heroku_ba59f508f074af3DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.herokuba59f508f074af3DataSet2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource herokuba59f508f074af3DataSetBindingSource;
        private heroku_ba59f508f074af3DataSet heroku_ba59f508f074af3DataSet;
        private System.Windows.Forms.Button Sair;
        private System.Windows.Forms.Button Voltar;
        private System.Windows.Forms.Button Proximo;
        private System.Windows.Forms.Button Deletar;
        private System.Windows.Forms.BindingSource herokuba59f508f074af3DataSet2BindingSource;
        private heroku_ba59f508f074af3DataSet2 heroku_ba59f508f074af3DataSet2;
        private heroku_ba59f508f074af3DataSet3 heroku_ba59f508f074af3DataSet3;
        private System.Windows.Forms.BindingSource tbpedidoBindingSource;
        private heroku_ba59f508f074af3DataSet3TableAdapters.tbpedidoTableAdapter tbpedidoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PEDIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn qUANTIDADEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATACOMPRADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORFINALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fORMAPAGAMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label PEDIDOS;
        private heroku_ba59f508f074af3DataSet6 heroku_ba59f508f074af3DataSet6;
        private System.Windows.Forms.BindingSource tbpedidoBindingSource1;
        private heroku_ba59f508f074af3DataSet6TableAdapters.tbpedidoTableAdapter tbpedidoTableAdapter1;
    }
}