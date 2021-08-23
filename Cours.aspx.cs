using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;

public partial class Cours : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string chaine = "Data Source = DESKTOP-62FIK78\\SQLEXPRESS;initial catalog = Enseignents ;user id = ult ;password = 123456;Integrated Security=true";
        SqlConnection n = new SqlConnection(chaine);

        n.Open();
        string requete = "";
       requete = " select IDens,Nompers,Prenompers,Degre from Enseignent,Personne where Enseignent.PersonneEns = Personne.IDpers";
        SqlCommand com = new SqlCommand(requete, n);
        SqlDataReader dr = com.ExecuteReader();
        while (dr.Read())
        {
            DropDownList1.Items.Add(dr.GetInt32(0) + " " + dr.GetString(1) + " " + dr.GetString(2) + " " + dr.GetString(3));
        }
        n.Close();

        n.Open();
        if (!IsPostBack)
        {
            requete = "select IDcours from Cours";
            SqlCommand com1 = new SqlCommand(requete, n);

            SqlDataReader dr1 = com1.ExecuteReader();
            DropDownList2.Items.Clear();
            while (dr1.Read())
            {
                DropDownList2.Items.Add(dr1.GetInt32(0).ToString());
            }
            n.Close();
        }
        
      

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string chaine = "Data Source = DESKTOP-62FIK78\\SQLEXPRESS;initial catalog = Enseignents ;user id = ult ;password = 123456;Integrated Security=true";
        SqlConnection n = new SqlConnection(chaine);
        n.Open();
        string crs = DropDownList1.SelectedItem.ToString();
        string[] cou = crs.Split(' ');
        string requete = " insert into Cours(EnseigentCours,Nomcours,Volume)values('" + cou[0] + "','" + TextBox1.Text + "','" + TextBox2.Text + "')";
        SqlCommand com = new SqlCommand(requete, n);
        com.ExecuteNonQuery();
        n.Close();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        int a = Int32.Parse(DropDownList2.SelectedItem.ToString());
        string chaine = "Data Source = DESKTOP-62FIK78\\SQLEXPRESS;initial catalog = Enseignents ;user id = ult ;password = 123456;Integrated Security=true";
        SqlConnection n = new SqlConnection(chaine);

        n.Open();
        string requete = "";
        requete = "update Cours set Nomcours = '" + TextBox1.Text + "', Volume ='" + TextBox2.Text + "' where IDcours =" + a + "";
        SqlCommand com = new SqlCommand(requete, n);
        com.ExecuteNonQuery();
        n.Close();

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        int a = Int32.Parse(DropDownList1.SelectedItem.ToString());
        string chaine = "Data Source = DESKTOP-62FIK78\\SQLEXPRESS;initial catalog = Enseignents ;user id = ult ;password = 123456;Integrated Security=true";
        SqlConnection n = new SqlConnection(chaine);
        n.Open();
        string requete = "";
        requete = "select Nomcours,Volume from Cours where Cours.IDcours = " + a + "";
        SqlCommand com = new SqlCommand(requete, n);
        SqlDataReader dr = com.ExecuteReader();

        if (dr.Read())
        {
            TextBox1.Text = dr.GetString(0);
            TextBox2.Text = dr.GetString(1);
        }
        n.Close();  
    }
}