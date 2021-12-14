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
    public partial class Frm_Cadastro_Usuario : Form
    {
        public Frm_Cadastro_Usuario()
        {
            InitializeComponent();
        }
        private void Btn_Registrar_User_Click(object sender, EventArgs e)
        {

            MySqlConnection conexaoBD = new MySqlConnection(Conect.strConect);
            conexaoBD.Open();

            try
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO TBFUNCIONARIO(ID_FUNCIONARIO, NOME, USUARIO, SENHA, RG, SEXO, CPF, DATA_NASCIMENTO, ADMISSAO, CARGO, TELEFONE, ENDERECO, BAIRRO, CIDADE, ESTADO, CEP) VALUES (NULL, '" + Txt_Nome_Usuario.Text + "', '" + Txt_Nome_Login.Text + "', '" + Txt_Senha_Login.Text + "', '" + Txt_RG.Text + "', '" + Cb_sexo.Text + "', '" + Txt_CPF.Text + "', '" + DateTime_Nascimento.Value.ToString("yyyy-MM-dd") + "', '" + DateTime_Admissao.Value.ToString("yyyy-MM-dd") + "', '" + Cb_cargo.Text + "', '" + Txt_Telefone_Func.Text + "', '" + Txt_Endereco_Func.Text + "', '" + Txt_Bairro_Func.Text + "', '" + Txt_Cidade_Func.Text + "', '" + Txt_Estado_Func.Text + "', '" + Txt_Cep_Func.Text + "')", conexaoBD);

                cmd.Parameters.Add("@NOME", MySqlDbType.VarChar, 50).Value = Txt_Nome_Usuario.Text;
                cmd.Parameters.Add("@USUARIO", MySqlDbType.VarChar, 50).Value = Txt_Nome_Login.Text;
                cmd.Parameters.Add("@SENHA", MySqlDbType.VarChar, 50).Value = Txt_Senha_Login.Text;
                cmd.Parameters.Add("@RG", MySqlDbType.VarChar, 9).Value = Txt_RG.Text;
                cmd.Parameters.Add("@SEXO", MySqlDbType.VarChar, 9).Value = Cb_sexo.Text;
                cmd.Parameters.Add("@CPF", MySqlDbType.VarChar, 11).Value = Txt_CPF.Text;
                cmd.Parameters.Add("DATA_NASCIMENTO", MySqlDbType.DateTime).Value = DateTime_Nascimento.Text;
                cmd.Parameters.Add("@ADMISSAO", MySqlDbType.DateTime).Value = DateTime_Admissao.Text;
                cmd.Parameters.Add("@CARGO", MySqlDbType.VarChar, 30).Value = Cb_cargo.Text;
                cmd.Parameters.Add("@TELEFONE", MySqlDbType.VarChar, 12).Value = Txt_Telefone_Func.Text;
                cmd.Parameters.Add("@ENDERECO", MySqlDbType.VarChar, 100).Value = Txt_Endereco_Func.Text;
                cmd.Parameters.Add("@BAIRRO", MySqlDbType.VarChar, 50).Value = Txt_Bairro_Func.Text;
                cmd.Parameters.Add("@CIDADE", MySqlDbType.VarChar, 50).Value = Txt_Cidade_Func.Text;
                cmd.Parameters.Add("@ESTADO", MySqlDbType.VarChar, 50).Value = Txt_Estado_Func.Text;
                cmd.Parameters.Add("@CEP", MySqlDbType.VarChar, 10).Value = Txt_Cep_Func.Text;

                if (Txt_Nome_Usuario.Text != "" & Txt_Nome_Login.Text != "" & Txt_Senha_Login.Text != "" & Txt_RG.Text != "" & Cb_sexo.Text != "" & Txt_CPF.Text != "" & DateTime_Nascimento.Text != "" & DateTime_Admissao.Text != "" & Cb_cargo.Text != "" & Txt_Telefone_Func.Text != "" & Txt_Endereco_Func.Text != "" & Txt_Bairro_Func.Text != "" & Txt_Cidade_Func.Text != "" & Txt_Estado_Func.Text != "" & Txt_Cep_Func.Text != "")
                {
                    //COMANDO PARA EXECUTAR A QUERY
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cadastro efetuado com sucesso", "SGNUTRI - CADASTRO FUNCIONARIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Txt_Nome_Usuario.Text = "";
                    Txt_Nome_Login.Text = "";
                    Txt_Senha_Login.Text = "";
                    Txt_RG.Text = "";
                    Cb_sexo.Text = "";
                    Txt_CPF.Text = "";
                    DateTime_Nascimento.Text = "";
                    DateTime_Admissao.Text = "";
                    Cb_cargo.Text = "";
                    Txt_Telefone_Func.Text = "";
                    Txt_Endereco_Func.Text = "";
                    Txt_Bairro_Func.Text = "";
                    Txt_Cidade_Func.Text = "";
                    Txt_Estado_Func.Text = "";
                    Txt_Cep_Func.Text = "";

                    this.Close();

                }
                else
                {
                    MessageBox.Show("Digite Todas informações  nos campos sao Obrigatorio!", "SGNUTRI - CADASTRO FUNCIONARIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Btn_Cancelar_Fun_Click(object sender, EventArgs e)
        {
            Txt_Nome_Usuario.Text = "";
            Txt_Nome_Login.Text = "";
            Txt_Senha_Login.Text = "";
            Txt_RG.Text = "";
            Cb_sexo.Text = "";
            Txt_CPF.Text = "";
            DateTime_Nascimento.Text = "";
            DateTime_Admissao.Text = "";
            Cb_cargo.Text = "";
            Txt_Telefone_Func.Text = "";
            Txt_Cep_Func.Text = "";
            Txt_Endereco_Func.Text = "";
            Txt_Bairro_Func.Text = "";
            Txt_Cidade_Func.Text = "";
            Txt_Estado_Func.Text = "";
            Txt_idfuncionario.Text = "";

            Btn_Cancelar_Fun.Enabled = true;
            Btn_Registrar_User.Enabled = true;
        }

        private void Frm_Cadastro_Usuario_Load(object sender, EventArgs e)
        {

        }
    }
}