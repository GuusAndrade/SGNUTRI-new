
namespace SGNUTRI
{
    partial class Frm_Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.Btn_Sair = new System.Windows.Forms.Button();
            this.Txt_Usuario = new System.Windows.Forms.TextBox();
            this.Txt_Senha = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Entrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Sair
            // 
            this.Btn_Sair.BackColor = System.Drawing.Color.Orange;
            this.Btn_Sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Sair.ForeColor = System.Drawing.Color.White;
            this.Btn_Sair.Location = new System.Drawing.Point(213, 409);
            this.Btn_Sair.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Btn_Sair.Name = "Btn_Sair";
            this.Btn_Sair.Size = new System.Drawing.Size(132, 46);
            this.Btn_Sair.TabIndex = 0;
            this.Btn_Sair.Text = "SAIR";
            this.Btn_Sair.UseVisualStyleBackColor = false;
            this.Btn_Sair.Click += new System.EventHandler(this.Btn_Sair_Click);
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.BackColor = System.Drawing.Color.FloralWhite;
            this.Txt_Usuario.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Usuario.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Txt_Usuario.HideSelection = false;
            this.Txt_Usuario.Location = new System.Drawing.Point(176, 225);
            this.Txt_Usuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.Size = new System.Drawing.Size(155, 21);
            this.Txt_Usuario.TabIndex = 1;
            this.Txt_Usuario.TabStop = false;
            this.Txt_Usuario.Text = "USUARIO";
            this.Txt_Usuario.Click += new System.EventHandler(this.Txt_Usuario_Click);
            // 
            // Txt_Senha
            // 
            this.Txt_Senha.BackColor = System.Drawing.Color.FloralWhite;
            this.Txt_Senha.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold);
            this.Txt_Senha.HideSelection = false;
            this.Txt_Senha.Location = new System.Drawing.Point(176, 282);
            this.Txt_Senha.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Txt_Senha.Name = "Txt_Senha";
            this.Txt_Senha.PasswordChar = '*';
            this.Txt_Senha.Size = new System.Drawing.Size(155, 21);
            this.Txt_Senha.TabIndex = 2;
            this.Txt_Senha.TabStop = false;
            this.Txt_Senha.Text = "SENHA";
            this.Txt_Senha.Click += new System.EventHandler(this.Txt_Senha_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(150, 215);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(150, 272);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 50.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(102, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 82);
            this.label1.TabIndex = 10;
            this.label1.Text = "SGNUTRI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(141, 174);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Sistema de Gerenciamento Nutricional";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Btn_Entrar
            // 
            this.Btn_Entrar.BackColor = System.Drawing.Color.Orange;
            this.Btn_Entrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Entrar.ForeColor = System.Drawing.Color.White;
            this.Btn_Entrar.Location = new System.Drawing.Point(371, 409);
            this.Btn_Entrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Btn_Entrar.Name = "Btn_Entrar";
            this.Btn_Entrar.Size = new System.Drawing.Size(132, 47);
            this.Btn_Entrar.TabIndex = 14;
            this.Btn_Entrar.Text = "ENTRAR";
            this.Btn_Entrar.UseVisualStyleBackColor = false;
            this.Btn_Entrar.Click += new System.EventHandler(this.Btn_Entrar_Click);
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(533, 487);
            this.Controls.Add(this.Btn_Entrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Txt_Senha);
            this.Controls.Add(this.Txt_Usuario);
            this.Controls.Add(this.Btn_Sair);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SGNUTRI  |  Sistema Gerenciamento Nutricional";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Sair;
        private System.Windows.Forms.TextBox Txt_Usuario;
        private System.Windows.Forms.TextBox Txt_Senha;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Entrar;
    }
}

