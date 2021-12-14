using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SGNUTRI
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();            
        }
        private void Btn_Entrar_Click(object sender, EventArgs e)
        {
            //PASSA A CLASS CRIADA PARA CONECTAR BANCO  
            MySqlConnection conexaoBD = new MySqlConnection(Conect.strConect);

            try
            {
                //ABRE O BANCO DE DADOS
                conexaoBD.Open();
                //COMANDO MYSQL PARA SELECIONAR DADOS NA TABELA
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM TBFUNCIONARIO WHERE USUARIO= '" + Txt_Usuario.Text + "' AND SENHA='" + Txt_Senha.Text + "'", conexaoBD);
                cmd.Parameters.Add("@USUARIO", MySqlDbType.VarChar, 50).Value = Txt_Usuario.Text;
                cmd.Parameters.Add("@SENHA", MySqlDbType.VarChar, 50).Value = Txt_Senha.Text;
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows == false) 
                {
                    throw new Exception("Usuario ou Senha Invalidos");
                }
            
            MessageBox.Show("Login com Sucesso, Seja Bem Vindo SGNUTRI", "SGNUTRI - LOGIN",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Frm_Menu menu = new Frm_Menu();
            menu.Show();
            this.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                conexaoBD.Close();
            }
        }

        private void Txt_Usuario_Click(object sender, EventArgs e)
        {
            Txt_Usuario.Clear();
        }

        private void Txt_Senha_Click(object sender, EventArgs e)
        {
            Txt_Senha.Clear();
        }
        private void Btn_Sair_Click(object sender, EventArgs e)
        {
           var result= MessageBox.Show("Deseja Sair?", "SGNUTRI - Fechar Programa",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            
           if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
