using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SGNUTRI {
    public partial class Frm_Cadastro_Produto_Adicionar : Form {
        public Frm_Cadastro_Produto_Adicionar() {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e) {
            MySqlConnection conexaoBD = new MySqlConnection(Conect.strConect);
            conexaoBD.Open();
            try {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO TBPRODUTO(ID_PRODUTO, NOME, DESCRICAO, PRECO, QUANTIDADE, VALIDADE) VALUES (NULL, '" + Txt_Nome_Produto.Text + "', '" + Txt_Descricao_Produto.Text + "', '" + Txt_Preco_Produto.Text + "', '" + Txt_Quantidade_Produto.Text + "', '" + Txt_Data_Produto.Value.ToString("yyyy-MM-dd") + "')", conexaoBD);

                cmd.Parameters.Add("@NOME", MySqlDbType.VarChar, 50).Value = Txt_Nome_Produto.Text;
                cmd.Parameters.Add("@DESCRICAO", MySqlDbType.VarChar, 100).Value = Txt_Descricao_Produto.Text;
                cmd.Parameters.Add("@PRECO", MySqlDbType.VarChar).Value = Txt_Preco_Produto.Text;
                cmd.Parameters.Add("@QUANTIDADE", MySqlDbType.VarChar).Value = Txt_Quantidade_Produto.Text;
                cmd.Parameters.Add("@VALIDADE", MySqlDbType.DateTime).Value = Txt_Data_Produto.Text;

                if (Txt_Nome_Produto.Text != "" & Txt_Descricao_Produto.Text != "" & Txt_Preco_Produto.Text != "" & Txt_Quantidade_Produto.Text != "" & Txt_Data_Produto.Text != "") {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cadastro efetuado com sucesso", "SGNUTRI - CADASTRO PRODUTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Txt_Nome_Produto.Text = "";
                    Txt_Descricao_Produto.Text = "";
                    Txt_Preco_Produto.Text = "";
                    Txt_Quantidade_Produto.Text = "";
                    Txt_Data_Produto.Text = "";
                    //Volta para a tela anterior
                    this.Close();


                }
                else {
                    MessageBox.Show("Digite Todas informações  nos campos Obrigatorio!", "SGNUTRI - CADASTRO PRODUTO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally {
                conexaoBD.Close();
            }
            
        }
        private void Btb_Sair_Menu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
