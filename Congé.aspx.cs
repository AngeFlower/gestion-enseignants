using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
public partial class Congé : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string chaine = "Data Source = DESKTOP-62FIK78\\SQLEXPRESS;initial catalog = Enseignents ;user id = ult ;password = 123456;Integrated Security=true";
        SqlConnection n = new SqlConnection(chaine);
        n.Open();
        string requete = " select IDens,Nompers,Prenompers,Degre from Enseignent,Personne where Enseignent.PersonneEns = Personne.IDpers";
        SqlCommand com = new SqlCommand(requete, n);
        SqlDataReader dr = com.ExecuteReader();
        while (dr.Read())
        {
            DropDownList1.Items.Add(dr.GetInt32(0) + " " + dr.GetString(1) + " " + dr.GetString(2) + " " + dr.GetString(3));
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string chaine = "Data Source = DESKTOP-62FIK78\\SQLEXPRESS;initial catalog = Enseignents ;user id = ult ;password = 123456;Integrated Security=true";
        SqlConnection n = new SqlConnection(chaine);
        n.Open();
        string con = DropDownList1.SelectedItem.ToString();
        string[] cong = con.Split(' ');
        string requete = " insert into Congé(EnseignentCong,Debut,Fin)values('" + cong[0] + "','" + TextBox1.Text + "','" + TextBox2.Text + "')";
        SqlCommand com = new SqlCommand(requete, n);
        com.ExecuteNonQuery();
        n.Close();
    }
}