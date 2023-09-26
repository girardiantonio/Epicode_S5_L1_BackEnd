using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Epicode_S5_L1_BackEnd
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindDipendentiGrid();
                BindPagamentiGrid();
            }
        }

        private void BindDipendentiGrid()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DB_ConnString"].ToString();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string queryDipendenti = "SELECT ID, Nome, Cognome, Indirizzo, CodiceFiscale, Coniugato, NumeroFigli, Mansione FROM Dipendenti";
                SqlDataAdapter adapterDipendenti = new SqlDataAdapter(queryDipendenti, conn);
                DataTable dtDipendenti = new DataTable();
                adapterDipendenti.Fill(dtDipendenti);

                GridView1.DataSource = dtDipendenti;
                GridView1.DataBind();
            }
        }

        private void BindPagamentiGrid()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DB_ConnString"].ToString();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string queryPagamenti = "SELECT ID, DipendenteID, DataPagamento, Ammontare, TipoPagamento FROM Pagamenti";
                SqlDataAdapter adapterPagamenti = new SqlDataAdapter(queryPagamenti, conn);
                DataTable dtPagamenti = new DataTable();
                adapterPagamenti.Fill(dtPagamenti);

                GridView2.DataSource = dtPagamenti;
                GridView2.DataBind();
            }
        }

        protected void btnDipendenti_Click(object sender, EventArgs e)
        {
            int dipendenteID = Convert.ToInt32(((Button)sender).CommandArgument);
            Response.Redirect($"Pagamenti.aspx?id={dipendenteID}");
        }

        protected void btnPagamenti_Click(object sender, EventArgs e)
        {
            int dipendenteID = Convert.ToInt32(((Button)sender).CommandArgument);
            Response.Redirect($"Pagamenti.aspx?id={dipendenteID}");
        }
    }
}