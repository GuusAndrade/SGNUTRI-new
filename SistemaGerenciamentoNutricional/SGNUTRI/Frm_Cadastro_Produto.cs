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
    public partial class Frm_Cadastro_Produto : Form {
        public Frm_Cadastro_Produto() {
            InitializeComponent();
        }



        private void Frm_Registrar_Produto_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'heroku_ba59f508f074af3DataSet1.tbproduto' table. You can move, or remove it, as needed.
            // Carrega o banco de dados pro GrindView
            this.tbprodutoTableAdapter1.Fill(this.heroku_ba59f508f074af3DataSet1.tbproduto);

        }

        private void button2_Click(object sender, EventArgs e) {
            // Selecionar outro produto na tabela(Seguinte)
            tbprodutoBindingSource1.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e) {
            // Selecionar outro produto na tabela(Anterior)
            tbprodutoBindingSource1.MovePrevious();
        }

        private void button1_Click(object sender, EventArgs e) {
            //Pergunta se quer Remover o produto
            var result2 = MessageBox.Show("Deseja Remover o Produto Selecionado?", "SGNUTRI - Salvar Produto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result2 == DialogResult.Yes) {
                MySqlConnection conexaoBD = new MySqlConnection(Conect.strConect);
                //remove o produto da tabela
                tbprodutoBindingSource1.RemoveCurrent();
                //atualiza a tabela
                tbprodutoTableAdapter1.Update(heroku_ba59f508f074af3DataSet1);
                conexaoBD.Close();

            }

            
        }

        private void button4_Click(object sender, EventArgs e) {
            //Pergunta se quer salvar
            var result = MessageBox.Show("Deseja Salvar?", "SGNUTRI - Salvar Produto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Se sim, salva e fecha a conexão com o banco de dados
            if (result == DialogResult.Yes) {
                MySqlConnection conexaoBD = new MySqlConnection(Conect.strConect);
                tbprodutoBindingSource1.EndEdit();
                tbprodutoTableAdapter1.Update(heroku_ba59f508f074af3DataSet1);
                this.Close();
                conexaoBD.Close();

            }
            //Se não,fecha sem salvar
            //e fecha a conexão com o banco
            else {
                MySqlConnection conexaoBD = new MySqlConnection(Conect.strConect);
                Frm_Cadastro_Produto Fechar_Produto = new Frm_Cadastro_Produto();
                Fechar_Produto.Close();
                this.Close();
                conexaoBD.Close();
            }
            
        }
        //Função para atualiza o grindView (gambiarra)
        //Basicamente fecha e abre a tela para o grindView ser atualizado
       
        private void button5_Click(object sender, EventArgs e) {
            Frm_Cadastro_Produto_Adicionar Adicionar = new Frm_Cadastro_Produto_Adicionar();
            Adicionar.Show();
            this.Close();

        }

        
    }
}
