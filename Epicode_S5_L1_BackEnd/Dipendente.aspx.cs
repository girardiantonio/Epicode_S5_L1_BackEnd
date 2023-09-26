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
    public partial class Dipendente : System.Web.UI.Page
    {
        protected void BtnSalva_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string cognome = txtCognome.Text;
            string indirizzo = txtIndirizzo.Text;
            string codicefiscale = txtCodiceFiscale.Text;
            bool coniugato = rblConiugato.SelectedValue == "S";
            string numerofigli = txtNumeroFigli.Text;
            string mansione = txtMansione.Text;

            string connectionString = ConfigurationManager.ConnectionStrings["DB_ConnString"].ToString();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Dipendenti (Nome, Cognome, Indirizzo, CodiceFiscale, Coniugato, NumeroFigli, Mansione) VALUES (@Nome, @Cognome, @Indirizzo, @CodiceFiscale, @Coniugato, @NumeroFigli, @Mansione)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nome", nome);
                cmd.Parameters.AddWithValue("@Cognome", cognome);
                cmd.Parameters.AddWithValue("@Indirizzo", indirizzo);
                cmd.Parameters.AddWithValue("@CodiceFiscale", codicefiscale);
                cmd.Parameters.AddWithValue("@Coniugato", coniugato);
                cmd.Parameters.AddWithValue("@NumeroFigli", numerofigli);
                cmd.Parameters.AddWithValue("@Mansione", mansione);
                cmd.ExecuteNonQuery();
            }

            Response.Redirect("Default.aspx");
        }
    }
}