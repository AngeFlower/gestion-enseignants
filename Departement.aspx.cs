using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;

public partial class Departement : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string chaine = "Data Source = DESKTOP-62FIK78\\SQLEXPRESS;initial catalog = Enseignents ;user id = ult ;password = 123456;Integrated Security=true";
        SqlConnection n = new SqlConnection(chaine);
        n.Open();
        string requete = "";
        requete = " select IDfac,Nomfac from Faculte";
        SqlCommand com = new SqlCommand(requete,n);
        SqlDataReader dr = com.ExecuteReader();
        while (dr.Read())
        {
            DropDownList1.Items.Add(dr.GetInt32(0)+ " " +dr.GetString(1));
        }
        n.Close();

        n.Open();
        if (!IsPostBack)
        {
            requete = "select IDdep from Departement";
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
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string chaine = "Data Source = DESKTOP-62FIK78\\SQLEXPRESS;initial catalog = Enseignents ;user id = ult ;password = 123456;Integrated Security=true";
        SqlConnection n = new SqlConnection(chaine);
        n.Open();
        string dep = DropDownList1.SelectedItem.ToString();
        string [] depart = dep.Split(' ');
        string requete = " insert into Departement(FaculteDep,NomDep)values('"+ depart[0]+"','"+TextBox1.Text+"')";
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
        requete = "update Departement set NomDep = '" + TextBox1.Text + "' where IDdep =" + a + "";
        SqlCommand com = new SqlCommand(requete, n);
        com.ExecuteNonQuery();
        n.Close();
    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        int a = Int32.Parse(DropDownList2.SelectedItem.ToString());
        string chaine = "Data Source = DESKTOP-62FIK78\\SQLEXPRESS;initial catalog = Enseignents ;user id = ult ;password = 123456;Integrated Security=true";
        SqlConnection n = new SqlConnection(chaine);
        n.Open();
        string requete = "";
        requete = "select NomDep from Departement where Departement.IDdep = " + a + "";
        SqlCommand com = new SqlCommand(requete, n);
        SqlDataReader dr = com.ExecuteReader();

        if (dr.Read())
        {
            TextBox1.Text = dr.GetString(0);
        }
        n.Close();
    }
}