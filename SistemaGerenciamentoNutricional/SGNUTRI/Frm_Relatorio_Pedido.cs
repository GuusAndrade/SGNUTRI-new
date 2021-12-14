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
using Microsoft.Reporting.WinForms;

namespace SGNUTRI {
    public partial class Frm_Relatorio_Pedido : Form {
        public Frm_Relatorio_Pedido() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            MySqlConnection cn = new MySqlConnection(Conect.strConect);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select*from tbpedido", cn);
            da.Fill(dt);

            reportViewer4.LocalReport.DataSources.Clear();
            ReportDataSource rp = new ReportDataSource("Report_Pedido", dt);
            reportViewer4.LocalReport.DataSources.Add(rp);
            reportViewer4.RefreshReport();
        }

        private void Frm_Relatorio_Pedido_Load(object sender, EventArgs e) {

        }
    }
}
