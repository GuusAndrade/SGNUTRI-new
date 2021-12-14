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
    public partial class Frm_Relatorio_Clientes : Form
    {
        public Frm_Relatorio_Clientes()
        {
            InitializeComponent();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MySqlConnection cn = new MySqlConnection(Conect.strConect);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select*from tbcliente", cn);
            da.Fill(dt);

            reportViewer2.LocalReport.DataSources.Clear();
            ReportDataSource rp = new ReportDataSource("Report_Clientes", dt);
            reportViewer2.LocalReport.DataSources.Add(rp);
            reportViewer2.RefreshReport();

        }

        private void Frm_Relatorio_Clientes_Load(object sender, EventArgs e)
        {

        }
    }
}

