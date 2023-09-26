using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Epicode_S5_L1_BackEnd
{
    public partial class Pagamenti : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && Request.QueryString["id"] != null)
            {
                txtDipendenteID.Text = Request.QueryString["id"];
            }
        }

        protected void btnSalvaPagamento_Click(object sender, EventArgs e)
        {
            int dipendenteID = int.Parse(txtDipendenteID.Text);
            DateTime dataPagamento = DateTime.Parse(txtDataPagamento.Text);
            decimal ammontare = decimal.Parse(txtAmmontare.Text);
            string tipoPagamento = ddlTipoPagamento.SelectedValue;

            string connectionString = ConfigurationManager.ConnectionStrings["DB_ConnString"].ToString();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "INSERT INTO Pagamenti (DipendenteID, DataPagamento, Ammontare, TipoPagamento) VALUES (@DipendenteID, @DataPagamento, @Ammontare, @TipoPagamento)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@DipendenteID", dipendenteID);
                    cmd.Parameters.AddWithValue("@DataPagamento", dataPagamento);
                    cmd.Parameters.AddWithValue("@Ammontare", ammontare);
                    cmd.Parameters.AddWithValue("@TipoPagamento", tipoPagamento);
                    cmd.ExecuteNonQuery();
                }
            }

            Response.Redirect("Default.aspx");
        }

        private void EliminaDipendente(int dipendenteID)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DB_ConnString"].ToString();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string queryEliminaPagamenti = "DELETE FROM Pagamenti WHERE DipendenteID = @DipendenteID";
                using (SqlCommand cmdEliminaPagamenti = new SqlCommand(queryEliminaPagamenti, conn))
                {
                    cmdEliminaPagamenti.Parameters.AddWithValue("@DipendenteID", dipendenteID);
                    cmdEliminaPagamenti.ExecuteNonQuery();
                }

                string queryEliminaDipendente = "DELETE FROM Dipendenti WHERE ID = @DipendenteID";
                using (SqlCommand cmdEliminaDipendente = new SqlCommand(queryEliminaDipendente, conn))
                {
                    cmdEliminaDipendente.Parameters.AddWithValue("@DipendenteID", dipendenteID);
                    cmdEliminaDipendente.ExecuteNonQuery();
                }

                conn.Close();
            }
        }

        protected void btnEliminaDipendente_Click(object sender, EventArgs e)
        {
            int dipendenteID = int.Parse(txtDipendenteID.Text);
            EliminaDipendente(dipendenteID);
            Response.Redirect("Default.aspx");
        }

        protected void btnEliminaDipendente1_Click(object sender, EventArgs e)
        {
            int dipendenteID = int.Parse(txtDipendenteID.Text);
            EliminaDipendente(dipendenteID);
            Response.Redirect("Default.aspx");
        }
    }
}