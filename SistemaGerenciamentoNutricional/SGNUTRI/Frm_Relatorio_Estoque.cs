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
    public partial class Frm_Relatorio_Estoque : Form {
        public Frm_Relatorio_Estoque() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            MySqlConnection cn = new MySqlConnection(Conect.strConect);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select*from tbproduto", cn);
            da.Fill(dt);

            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource rp = new ReportDataSource("DataSet1",dt);
            reportViewer1.LocalReport.DataSources.Add(rp);
            reportViewer1.RefreshReport();

        }

    }
}
