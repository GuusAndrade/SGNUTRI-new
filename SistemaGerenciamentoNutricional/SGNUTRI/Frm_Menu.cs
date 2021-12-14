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
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
        }

        private void fUNCIONARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Cadastro_Usuario func = new Frm_Cadastro_Usuario();
            func.ShowDialog();
        }

        private void cLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Cadastro_Cliente client = new Frm_Cadastro_Cliente();
            client.ShowDialog();
        }

        private void pRODUTOToolStripMenuItem_Click(object sender, EventArgs e) {
            Frm_Cadastro_Produto_Adicionar Adicionar = new Frm_Cadastro_Produto_Adicionar();
            Adicionar.ShowDialog();
        }

        
        private void Btn_Sair_Menu_Click_1(object sender, EventArgs e) {
            Application.Exit();
        }

        private void pEDIDOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Cadastro_Pedido_Adicionar Adipedido = new Frm_Cadastro_Pedido_Adicionar();
            Adipedido.ShowDialog();
        }

        private void eSTOQUEToolStripMenuItem_Click(object sender, EventArgs e) {
            Frm_Cadastro_Produto Adi = new Frm_Cadastro_Produto();
            Adi.ShowDialog();
        }

        private void Cadastrar_Menu_Click(object sender, EventArgs e) {

        }

        private void pEDIDOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Cadastro_Pedido pedido = new Frm_Cadastro_Pedido();
            pedido.ShowDialog();
        }


        private void eSTOQUEToolStripMenuItem1_Click(object sender, EventArgs e) {
            Frm_Relatorio_Estoque sotestandomesmo = new Frm_Relatorio_Estoque();
            sotestandomesmo.ShowDialog();
        }

        private void cLIENTEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Relatorio_Clientes r_clientes = new Frm_Relatorio_Clientes();
            r_clientes.ShowDialog();
        }

        private void fORNECEDORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Relatorio_Funcionario r_fornecedor = new Frm_Relatorio_Funcionario();
            r_fornecedor.ShowDialog();
        }

        private void vENDASToolStripMenuItem_Click(object sender, EventArgs e) {
            Frm_Relatorio_Pedido r_pedido = new Frm_Relatorio_Pedido();
            r_pedido.ShowDialog();
        }
    }
}
