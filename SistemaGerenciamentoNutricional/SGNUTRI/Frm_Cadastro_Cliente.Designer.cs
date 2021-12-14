
namespace SGNUTRI
{
    partial class Frm_Cadastro_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cadastro_Cliente));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_telp = new System.Windows.Forms.MaskedTextBox();
            this.tb_cpf = new System.Windows.Forms.MaskedTextBox();
            this.tb_sexo = new System.Windows.Forms.ComboBox();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_Cancelar_Fun = new System.Windows.Forms.Button();
            this.Btn_Voltar_Menu = new System.Windows.Forms.Button();
            this.Btn_Registrar_Client = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_cep = new System.Windows.Forms.MaskedTextBox();
            this.tb_estado = new System.Windows.Forms.TextBox();
            this.tb_cidade = new System.Windows.Forms.TextBox();
            this.tb_bairro = new System.Windows.Forms.TextBox();
            this.tb_endereco = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(271, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 33);
            this.label1.TabIndex = 12;
            this.label1.Text = "CADASTRO CLIENTE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tb_telp);
            this.panel1.Controls.Add(this.tb_cpf);
            this.panel1.Controls.Add(this.tb_sexo);
            this.panel1.Controls.Add(this.tb_nome);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(25, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 149);
            this.panel1.TabIndex = 3;
            // 
            // tb_telp
            // 
            this.tb_telp.Location = new System.Drawing.Point(89, 85);
            this.tb_telp.Margin = new System.Windows.Forms.Padding(2);
            this.tb_telp.Mask = "(00) 00000-9999";
            this.tb_telp.Name = "tb_telp";
            this.tb_telp.Size = new System.Drawing.Size(93, 20);
            this.tb_telp.TabIndex = 4;
            // 
            // tb_cpf
            // 
            this.tb_cpf.Location = new System.Drawing.Point(89, 39);
            this.tb_cpf.Margin = new System.Windows.Forms.Padding(2);
            this.tb_cpf.Mask = "000.000.000-00";
            this.tb_cpf.Name = "tb_cpf";
            this.tb_cpf.Size = new System.Drawing.Size(93, 20);
            this.tb_cpf.TabIndex = 2;
            // 
            // tb_sexo
            // 
            this.tb_sexo.FormattingEnabled = true;
            this.tb_sexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.tb_sexo.Location = new System.Drawing.Point(89, 62);
            this.tb_sexo.Name = "tb_sexo";
            this.tb_sexo.Size = new System.Drawing.Size(93, 21);
            this.tb_sexo.TabIndex = 3;
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(89, 17);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(314, 20);
            this.tb_nome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 23);
            this.label2.TabIndex = 48;
            this.label2.Text = "Nome";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 23);
            this.label4.TabIndex = 50;
            this.label4.Text = "CPF";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 23);
            this.label5.TabIndex = 51;
            this.label5.Text = "Cel";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 23);
            this.label3.TabIndex = 49;
            this.label3.Text = "Sexo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Btn_Cancelar_Fun
            // 
            this.Btn_Cancelar_Fun.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Btn_Cancelar_Fun.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Italic);
            this.Btn_Cancelar_Fun.Location = new System.Drawing.Point(569, 237);
            this.Btn_Cancelar_Fun.Name = "Btn_Cancelar_Fun";
            this.Btn_Cancelar_Fun.Size = new System.Drawing.Size(214, 38);
            this.Btn_Cancelar_Fun.TabIndex = 1;
            this.Btn_Cancelar_Fun.Text = "CANCELAR";
            this.Btn_Cancelar_Fun.UseVisualStyleBackColor = true;
            this.Btn_Cancelar_Fun.UseWaitCursor = true;
            this.Btn_Cancelar_Fun.Click += new System.EventHandler(this.Btn_Cancelar_Fun_Click);
            // 
            // Btn_Voltar_Menu
            // 
            this.Btn_Voltar_Menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Voltar_Menu.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Italic);
            this.Btn_Voltar_Menu.Location = new System.Drawing.Point(625, 302);
            this.Btn_Voltar_Menu.Name = "Btn_Voltar_Menu";
            this.Btn_Voltar_Menu.Size = new System.Drawing.Size(105, 34);
            this.Btn_Voltar_Menu.TabIndex = 2;
            this.Btn_Voltar_Menu.Text = "SAIR";
            this.Btn_Voltar_Menu.UseVisualStyleBackColor = true;
            this.Btn_Voltar_Menu.Click += new System.EventHandler(this.Btn_Voltar_Menu_Click);
            // 
            // Btn_Registrar_Client
            // 
            this.Btn_Registrar_Client.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Registrar_Client.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Italic);
            this.Btn_Registrar_Client.Location = new System.Drawing.Point(569, 192);
            this.Btn_Registrar_Client.Name = "Btn_Registrar_Client";
            this.Btn_Registrar_Client.Size = new System.Drawing.Size(214, 38);
            this.Btn_Registrar_Client.TabIndex = 0;
            this.Btn_Registrar_Client.Text = "REGISTRAR";
            this.Btn_Registrar_Client.UseVisualStyleBackColor = true;
            this.Btn_Registrar_Client.Click += new System.EventHandler(this.Btn_Registrar_Client_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tb_cep);
            this.panel2.Controls.Add(this.tb_estado);
            this.panel2.Controls.Add(this.tb_cidade);
            this.panel2.Controls.Add(this.tb_bairro);
            this.panel2.Controls.Add(this.tb_endereco);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Location = new System.Drawing.Point(25, 191);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(499, 151);
            this.panel2.TabIndex = 54;
            // 
            // tb_cep
            // 
            this.tb_cep.Location = new System.Drawing.Point(91, 19);
            this.tb_cep.Margin = new System.Windows.Forms.Padding(2);
            this.tb_cep.Mask = "00000-000";
            this.tb_cep.Name = "tb_cep";
            this.tb_cep.Size = new System.Drawing.Size(69, 20);
            this.tb_cep.TabIndex = 0;
            // 
            // tb_estado
            // 
            this.tb_estado.Location = new System.Drawing.Point(91, 114);
            this.tb_estado.Name = "tb_estado";
            this.tb_estado.Size = new System.Drawing.Size(69, 20);
            this.tb_estado.TabIndex = 4;
            // 
            // tb_cidade
            // 
            this.tb_cidade.Location = new System.Drawing.Point(91, 90);
            this.tb_cidade.Name = "tb_cidade";
            this.tb_cidade.Size = new System.Drawing.Size(69, 20);
            this.tb_cidade.TabIndex = 3;
            // 
            // tb_bairro
            // 
            this.tb_bairro.Location = new System.Drawing.Point(91, 66);
            this.tb_bairro.Name = "tb_bairro";
            this.tb_bairro.Size = new System.Drawing.Size(116, 20);
            this.tb_bairro.TabIndex = 2;
            // 
            // tb_endereco
            // 
            this.tb_endereco.Location = new System.Drawing.Point(91, 42);
            this.tb_endereco.Name = "tb_endereco";
            this.tb_endereco.Size = new System.Drawing.Size(314, 20);
            this.tb_endereco.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(5, 62);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 23);
            this.label10.TabIndex = 25;
            this.label10.Text = "Bairro";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(7, 38);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 23);
            this.label9.TabIndex = 24;
            this.label9.Text = "Endereco";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(5, 86);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 23);
            this.label11.TabIndex = 26;
            this.label11.Text = "Cidade";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(5, 110);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 23);
            this.label12.TabIndex = 27;
            this.label12.Text = "Estado";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(7, 15);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 23);
            this.label13.TabIndex = 28;
            this.label13.Text = "CEP";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Frm_Cadastro_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(818, 359);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Btn_Registrar_Client);
            this.Controls.Add(this.Btn_Cancelar_Fun);
            this.Controls.Add(this.Btn_Voltar_Menu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Cadastro_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SGNUTRI | Registrar Cliente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Cancelar_Fun;
        private System.Windows.Forms.Button Btn_Voltar_Menu;
        private System.Windows.Forms.Button Btn_Registrar_Client;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.ComboBox tb_sexo;
        private System.Windows.Forms.TextBox tb_estado;
        private System.Windows.Forms.TextBox tb_cidade;
        private System.Windows.Forms.TextBox tb_bairro;
        private System.Windows.Forms.TextBox tb_endereco;
        private System.Windows.Forms.MaskedTextBox tb_telp;
        private System.Windows.Forms.MaskedTextBox tb_cpf;
        private System.Windows.Forms.MaskedTextBox tb_cep;
    }
}