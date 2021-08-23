using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;

public partial class Cours_Departement : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string chaine = "Data Source = DESKTOP-62FIK78\\SQLEXPRESS;initial catalog = Enseignents ;user id = ult ;password = 123456;Integrated Security=true";
        SqlConnection n = new SqlConnection(chaine);
        n.Open();
        string requete;
        requete = "";
        requete = "select IDfac,NomDep from Faculte,Departement where Departement.FaculteDep = Faculte.IDfac";
        SqlCommand pt = new SqlCommand(requete, n);
        SqlDataReader dr = pt.ExecuteReader();
        while (dr.Read())
        {
            DropDownList1.Items.Add(dr.GetInt32(0) + " " + dr.GetString(1));
        }
        n.Close();
        n.Open();

        requete = "select IDcours,Nomcours from Cours";
        SqlCommand ant = new SqlCommand(requete, n);
        SqlDataReader dr1 = ant.ExecuteReader();
        while (dr1.Read())
        {
            DropDownList2.Items.Add(dr1.GetInt32(0) + " " + dr1.GetString(1));
        }
        n.Close();
    }

  
    protected void Button1_Click1(object sender, EventArgs e)
    {
        string chaine = "Data Source = DESKTOP-62FIK78\\SQLEXPRESS;initial catalog = Enseignents ;user id = ult ;password = 123456;Integrated Security=true";
        SqlConnection n = new SqlConnection(chaine);
        n.Open();
        string dep = DropDownList1.SelectedItem.ToString();
        string[] depart = dep.Split(' ');
        string crs = DropDownList2.SelectedItem.ToString();
        string[] cour = crs.Split(' ');
        string crdep = "insert into CoursDepartement(dep,cours)values(" + depart[0] + "," + cour[0] + ")";
        SqlCommand com = new SqlCommand(crdep, n);
        com.ExecuteNonQuery();
        Response.Write("<script>alert('enregistrement reussi avec success')</script>");
    }
}