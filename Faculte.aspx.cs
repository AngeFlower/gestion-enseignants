 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;

public partial class Faculte : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

  
    protected void Button1_Click1(object sender, EventArgs e)
    {
        {
           
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Write("<script>alert('clicked')</script>");
        string chaine = "Data Source = DESKTOP-62FIK78\\SQLEXPRESS;initial catalog = Enseignents ;user id = ult ;password = 123456;Integrated Security=true";
        SqlConnection n = new SqlConnection(chaine);
        n.Open();
        if (String.IsNullOrWhiteSpace(TextBox1.Text))
        {
            Response.Write("Impossible d'enregistrer un champ vide");
        }
        else
        {
            string requete = "insert into Faculte (Nomfac) values('" + TextBox1.Text + "')";
            //string persAct = "select idPersonne from Personne where idPersonne = max(idPersonne)";
            SqlCommand com = new SqlCommand(requete, n);
            com.ExecuteNonQuery();
            Response.Write("Faculte Ajoutée Avec Succes.");
            n.Close();
            n.Open();
        }
    }
}
