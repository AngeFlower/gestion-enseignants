using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;

public partial class Athentification : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //chaine connection

        string chaine = "Data Source = DESKTOP-62FIK78\\SQLEXPRESS;initial catalog = Enseignents ;user id = ult ;password = 123456;Integrated Security=true";
        SqlConnection n = new SqlConnection(chaine);

        //ouverture de la connexion



        //requete
        n.Open();
        string requete = "select * from Utilisateur where IDuti = '" + TextBox1.Text + "' and Password ='" + TextBox2.Text + "'";
        
        //objet commande pour executer le requete

        SqlCommand com = new SqlCommand(requete, n);

        //executer de la commande

        SqlDataReader dr = com.ExecuteReader();

        if (dr.Read())
        {
            Response.Redirect("Menu.aspx");
        }
        else
        {
            Response.Write("<script>alert ('echec de connexion')</script>");
        }
    }
}