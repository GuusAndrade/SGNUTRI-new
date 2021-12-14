using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGNUTRI
{
    public partial class Frm_Cadastro_Cliente : Form
    {
        public Frm_Cadastro_Cliente()
        {
            InitializeComponent();
        }

        private void Btn_Voltar_Menu_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void Btn_Registrar_Client_Click(object sender, EventArgs e)
        {

            MySqlConnection conexaoBD = new MySqlConnection(Conect.strConect);
            conexaoBD.Open();

            try
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO TBCLIENTE(ID_CLIENTE, NOME, SEXO, CPF, TELEFONE, ENDERECO, BAIRRO, CIDADE, ESTADO, CEP) VALUES (NULL, '" + tb_nome.Text + "', '" + tb_sexo.Text + "', '" + tb_cpf.Text + "', '" + tb_telp.Text + "', '" + tb_endereco.Text + "', '" + tb_bairro.Text + "', '" + tb_cidade.Text + "', '" + tb_estado.Text + "', '" + tb_cep.Text + "')", conexaoBD);

                cmd.Parameters.Add("@NOME", MySqlDbType.VarChar, 50).Value = tb_nome.Text;
                cmd.Parameters.Add("@SEXO", MySqlDbType.VarChar, 100).Value = tb_sexo.Text;
                cmd.Parameters.Add("@CPF", MySqlDbType.Int32).Value = tb_cpf.Text;
                cmd.Parameters.Add("@TELEFONE", MySqlDbType.VarChar).Value = tb_telp.Text;
                cmd.Parameters.Add("@ENDERECO", MySqlDbType.VarChar).Value = tb_endereco.Text;
                cmd.Parameters.Add("@BAIRRO", MySqlDbType.VarChar).Value = tb_bairro.Text;
                cmd.Parameters.Add("@CIDADE", MySqlDbType.VarChar).Value = tb_cidade.Text;
                cmd.Parameters.Add("@ESTADO", MySqlDbType.VarChar).Value = tb_estado.Text;
                cmd.Parameters.Add("@CEP", MySqlDbType.Int32).Value = tb_cep.Text;


                if (tb_nome.Text != "" & tb_sexo.Text != "" & tb_cpf.Text != "" & tb_telp.Text != "" & tb_endereco.Text != "" & tb_bairro.Text != "" & tb_cidade.Text != "" & tb_estado.Text != "" & tb_cep.Text != "")
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cadastro efetuado com sucesso", "SGNUTRI - CADASTRO PRODUTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_nome.Text = "";
                    tb_sexo.Text = "";
                    tb_cpf.Text = "";
                    tb_telp.Text = "";
                    tb_endereco.Text = "";
                    tb_bairro.Text = "";
                    tb_cidade.Text = "";
                    tb_estado.Text = "";
                    tb_cep.Text = "";
                    //Volta para a tela anterior
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Digite todas as informações nos campos Obrigatórios!", "SGNUTRI - CADASTRO DE CLIENTE", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                cmd.ExecuteNonQuery();
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
        private void Btn_Cancelar_Fun_Click(object sender, EventArgs e)
        {
            tb_nome.Text = "";
            tb_cpf.Text = "";
            tb_sexo.Text = "";
            tb_telp.Text = "";
            tb_endereco.Text = "";
            tb_bairro.Text = "";
            tb_cidade.Text = "";
            tb_estado.Text = "";
            tb_cep.Text = "";

            Btn_Cancelar_Fun.Enabled = true;
            Btn_Registrar_Client.Enabled = true;
        }
    }

}
