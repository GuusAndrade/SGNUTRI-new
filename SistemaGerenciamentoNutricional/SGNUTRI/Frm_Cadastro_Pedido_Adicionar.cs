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
    public partial class Frm_Cadastro_Pedido_Adicionar : Form
    {
        public Frm_Cadastro_Pedido_Adicionar()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conexaoBD = new MySqlConnection(Conect.strConect);
            conexaoBD.Open();
            /* try

                 MySqlCommand cmd = new MySqlCommand("INSERT INTO TBPEDIDO(ID_PEDIDO, ID_FUNCIONARIO, ID_CLIENTE, ID_PRODUTO, QUANTIDADE, DATA_COMPRA, VALOR_FINAL, FORMA_PAGAMENTO, STATUS) VALUES (NULL, '" + Txt_Nome.Text + "', '" + Txt_Descricao.Text + "', '" + Txt_Valor_Final.Text + "', '" + Txt_Quantidade.Text + "', '" + Msk_Data.Value.ToString("yyyy-MM-dd") + "')", conexaoBD);

                 cmd.Parameters.Add("@NOME", MySqlDbType.VarChar, 50).Value = Txt_Nome.Text;
                 cmd.Parameters.Add("@DESCRICAO", MySqlDbType.VarChar, 100).Value = Txt_Descricao.Text;
                 cmd.Parameters.Add("@PRECO", MySqlDbType.VarChar).Value = Txt_Valor_Final.Text;
                 cmd.Parameters.Add("@QUANTIDADE", MySqlDbType.VarChar).Value = Txt_Quantidade.Text;
                 cmd.Parameters.Add("@VALIDADE", MySqlDbType.DateTime).Value = Txt_Data_Produto.Text;    
                 */


        }


    }

}
