
namespace SGNUTRI {
    partial class Frm_Cadastro_Produto {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cadastro_Produto));
            this.tbprodutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.heroku_ba59f508f074af3DataSet = new SGNUTRI.heroku_ba59f508f074af3DataSet();
            this.tbprodutoTableAdapter = new SGNUTRI.heroku_ba59f508f074af3DataSetTableAdapters.tbprodutoTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nOMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRICAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qUANTIDADEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALIDADEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbprodutoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.heroku_ba59f508f074af3DataSet1 = new SGNUTRI.heroku_ba59f508f074af3DataSet1();
            this.tbprodutoTableAdapter1 = new SGNUTRI.heroku_ba59f508f074af3DataSet1TableAdapters.tbprodutoTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ESTOQUE = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbprodutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heroku_ba59f508f074af3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbprodutoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heroku_ba59f508f074af3DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbprodutoBindingSource
            // 
            this.tbprodutoBindingSource.DataMember = "tbproduto";
            this.tbprodutoBindingSource.DataSource = this.heroku_ba59f508f074af3DataSet;
            // 
            // heroku_ba59f508f074af3DataSet
            // 
            this.heroku_ba59f508f074af3DataSet.DataSetName = "heroku_ba59f508f074af3DataSet";
            this.heroku_ba59f508f074af3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbprodutoTableAdapter
            // 
            this.tbprodutoTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nOMEDataGridViewTextBoxColumn,
            this.dESCRICAODataGridViewTextBoxColumn,
            this.pRECODataGridViewTextBoxColumn,
            this.qUANTIDADEDataGridViewTextBoxColumn,
            this.vALIDADEDataGridViewTextBoxColumn,
            this.iDPRODUTODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbprodutoBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(60, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(697, 278);
            this.dataGridView1.TabIndex = 39;
            // 
            // nOMEDataGridViewTextBoxColumn
            // 
            this.nOMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nOMEDataGridViewTextBoxColumn.DataPropertyName = "NOME";
            this.nOMEDataGridViewTextBoxColumn.HeaderText = "NOME";
            this.nOMEDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nOMEDataGridViewTextBoxColumn.Name = "nOMEDataGridViewTextBoxColumn";
            this.nOMEDataGridViewTextBoxColumn.Width = 150;
            // 
            // dESCRICAODataGridViewTextBoxColumn
            // 
            this.dESCRICAODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dESCRICAODataGridViewTextBoxColumn.DataPropertyName = "DESCRICAO";
            this.dESCRICAODataGridViewTextBoxColumn.HeaderText = "DESCRICAO";
            this.dESCRICAODataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dESCRICAODataGridViewTextBoxColumn.Name = "dESCRICAODataGridViewTextBoxColumn";
            this.dESCRICAODataGridViewTextBoxColumn.Width = 33;
            // 
            // pRECODataGridViewTextBoxColumn
            // 
            this.pRECODataGridViewTextBoxColumn.DataPropertyName = "PRECO";
            this.pRECODataGridViewTextBoxColumn.HeaderText = "PRECO";
            this.pRECODataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pRECODataGridViewTextBoxColumn.Name = "pRECODataGridViewTextBoxColumn";
            this.pRECODataGridViewTextBoxColumn.Width = 150;
            // 
            // qUANTIDADEDataGridViewTextBoxColumn
            // 
            this.qUANTIDADEDataGridViewTextBoxColumn.DataPropertyName = "QUANTIDADE";
            this.qUANTIDADEDataGridViewTextBoxColumn.HeaderText = "QUANTIDADE";
            this.qUANTIDADEDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.qUANTIDADEDataGridViewTextBoxColumn.Name = "qUANTIDADEDataGridViewTextBoxColumn";
            this.qUANTIDADEDataGridViewTextBoxColumn.Width = 150;
            // 
            // vALIDADEDataGridViewTextBoxColumn
            // 
            this.vALIDADEDataGridViewTextBoxColumn.DataPropertyName = "VALIDADE";
            this.vALIDADEDataGridViewTextBoxColumn.HeaderText = "VALIDADE";
            this.vALIDADEDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.vALIDADEDataGridViewTextBoxColumn.Name = "vALIDADEDataGridViewTextBoxColumn";
            this.vALIDADEDataGridViewTextBoxColumn.Width = 150;
            // 
            // iDPRODUTODataGridViewTextBoxColumn
            // 
            this.iDPRODUTODataGridViewTextBoxColumn.DataPropertyName = "ID_PRODUTO";
            this.iDPRODUTODataGridViewTextBoxColumn.HeaderText = "ID_PRODUTO";
            this.iDPRODUTODataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDPRODUTODataGridViewTextBoxColumn.Name = "iDPRODUTODataGridViewTextBoxColumn";
            this.iDPRODUTODataGridViewTextBoxColumn.Visible = false;
            this.iDPRODUTODataGridViewTextBoxColumn.Width = 150;
            // 
            // tbprodutoBindingSource1
            // 
            this.tbprodutoBindingSource1.DataMember = "tbproduto";
            this.tbprodutoBindingSource1.DataSource = this.heroku_ba59f508f074af3DataSet1;
            // 
            // heroku_ba59f508f074af3DataSet1
            // 
            this.heroku_ba59f508f074af3DataSet1.DataSetName = "heroku_ba59f508f074af3DataSet1";
            this.heroku_ba59f508f074af3DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbprodutoTableAdapter1
            // 
            this.tbprodutoTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 37);
            this.button1.TabIndex = 40;
            this.button1.Text = "DELETAR PRODUTO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(490, 388);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 37);
            this.button2.TabIndex = 41;
            this.button2.Text = "PROXIMO";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(304, 388);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 37);
            this.button3.TabIndex = 42;
            this.button3.Text = "ANTERIOR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(642, 388);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 37);
            this.button4.TabIndex = 43;
            this.button4.Text = "SAIR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ESTOQUE
            // 
            this.ESTOQUE.AutoSize = true;
            this.ESTOQUE.Font = new System.Drawing.Font("Constantia", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ESTOQUE.ForeColor = System.Drawing.SystemColors.Control;
            this.ESTOQUE.Location = new System.Drawing.Point(317, 36);
            this.ESTOQUE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ESTOQUE.Name = "ESTOQUE";
            this.ESTOQUE.Size = new System.Drawing.Size(143, 33);
            this.ESTOQUE.TabIndex = 51;
            this.ESTOQUE.Text = "ESTOQUE";
            // 
            // Frm_Cadastro_Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ESTOQUE);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Cadastro_Produto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SGNUTRI | Produto Estoque";
            this.Load += new System.EventHandler(this.Frm_Registrar_Produto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbprodutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heroku_ba59f508f074af3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbprodutoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heroku_ba59f508f074af3DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private heroku_ba59f508f074af3DataSet heroku_ba59f508f074af3DataSet;
        private System.Windows.Forms.BindingSource tbprodutoBindingSource;
        private heroku_ba59f508f074af3DataSetTableAdapters.tbprodutoTableAdapter tbprodutoTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private heroku_ba59f508f074af3DataSet1 heroku_ba59f508f074af3DataSet1;
        private System.Windows.Forms.BindingSource tbprodutoBindingSource1;
        private heroku_ba59f508f074af3DataSet1TableAdapters.tbprodutoTableAdapter tbprodutoTableAdapter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRICAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qUANTIDADEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALIDADEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.Label ESTOQUE;
    }
}