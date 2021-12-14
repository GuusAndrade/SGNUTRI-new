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
    public partial class Frm_Cadastro_Pedido : Form
    {
        public Frm_Cadastro_Pedido()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Frm_Registrar_Pedido_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'heroku_ba59f508f074af3DataSet6.tbpedido' table. You can move, or remove it, as needed.
            //this.tbpedidoTableAdapter1.Fill(this.heroku_ba59f508f074af3DataSet6.tbpedido);
            // TODO: This line of code loads data into the 'heroku_ba59f508f074af3DataSet3.tbpedido' table. You can move, or remove it, as needed.
            //this.tbpedidoTableAdapter.Fill(this.heroku_ba59f508f074af3DataSet3.tbpedido);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Selecionar outro pedido na tabela(Seguinte)
            tbpedidoBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Selecionar outro pedido na tabela(Seguinte)
            tbpedidoBindingSource.MovePrevious();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Pergunta se quer Remover o pedido
            var result2 = MessageBox.Show("Deseja Remover o Pedido Selecionado?", "SGNUTRI - Salvar Pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result2 == DialogResult.Yes)
            {
                MySqlConnection conexaoBD = new MySqlConnection(Conect.strConect);
                //remove o pedido da tabela
                tbpedidoBindingSource.RemoveCurrent();
                //atualiza a tabela
                tbpedidoTableAdapter.Update(heroku_ba59f508f074af3DataSet3);
                conexaoBD.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Pergunta se quer salvar
            var result = MessageBox.Show("Deseja Salvar?", "SGNUTRI - Salvar Pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Se sim, salva e fecha a conexão com o banco de dados
            if (result == DialogResult.Yes)
            {
                MySqlConnection conexaoBD = new MySqlConnection(Conect.strConect);
                tbpedidoBindingSource.EndEdit();
                tbpedidoTableAdapter.Update(heroku_ba59f508f074af3DataSet3);
                this.Close();
                conexaoBD.Close();

            }
            //Se não,fecha sem salvar
            //e fecha a conexão com o banco
            else
            {
                MySqlConnection conexaoBD = new MySqlConnection(Conect.strConect);
                Frm_Cadastro_Pedido Fechar_Pedido = new Frm_Cadastro_Pedido();
                Fechar_Pedido.Close();
                this.Close();
                conexaoBD.Close();
            }

        }

       
        //Função para atualiza o grindView (gambiarra)
        //Basicamente fecha e abre a tela para o grindView ser atualizado
    }
}

