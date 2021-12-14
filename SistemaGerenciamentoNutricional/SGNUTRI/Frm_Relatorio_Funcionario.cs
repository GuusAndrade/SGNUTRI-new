using Microsoft.Reporting.WinForms;
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
    public partial class Frm_Relatorio_Funcionario : Form
    {
        public Frm_Relatorio_Funcionario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection cn = new MySqlConnection(Conect.strConect);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select*from tbfuncionario", cn);
            da.Fill(dt);

            reportViewer2.LocalReport.DataSources.Clear();
            ReportDataSource rp = new ReportDataSource("Report_Funcionarios", dt);
            reportViewer2.LocalReport.DataSources.Add(rp);
            reportViewer2.RefreshReport();
        }

        private void Frm_Relatorio_Funcionario_Load(object sender, EventArgs e)
        {

        }
    }
}
