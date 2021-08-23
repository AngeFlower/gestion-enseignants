using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;

public partial class Horaire : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        string chaine = "Data Source = DESKTOP-62FIK78\\SQLEXPRESS;initial catalog = Enseignents ;user id = ult ;password = 123456;Integrated Security=true";
        SqlConnection n = new SqlConnection(chaine);

        n.Open();
        string requete = "";
        if (!IsPostBack)
        {
            requete = "select IDcours,Nomcours from Cours";
            SqlCommand com = new SqlCommand(requete, n);

            SqlDataReader dr = com.ExecuteReader();

            while (dr.Read())
            {
                DropDownList1.Items.Add(dr.GetInt32(0) + " " + dr.GetString(1));
            }
            n.Close();

            n.Open();
            requete = "select IDdep,NomDep,Nomfac from Departement, Faculte where Departement.FaculteDep = Faculte.IDfac";
            SqlCommand com1 = new SqlCommand(requete, n);

            SqlDataReader dr1 = com1.ExecuteReader();

            while (dr1.Read())
            {
                DropDownList2.Items.Add(dr1.GetInt32(0) + " " + dr1.GetString(1) + " " + dr1.GetString(2));
            }
            n.Close();

            n.Open();
            requete = "select IDens,Nompers,Prenompers,Degre from Personne,Enseignent where Enseignent.PersonneEns = Personne.IDpers";
            SqlCommand com2 = new SqlCommand(requete, n);

            SqlDataReader dr2 = com2.ExecuteReader();

            while (dr2.Read())
            {
                DropDownList3.Items.Add(dr2.GetInt32(0) + " " + dr2.GetString(1) + " " + dr2.GetString(2) + " " + dr2.GetString(3));
            }
            n.Close();

            n.Open();
            requete = "select IDsalle,Nomsalle,Bloc from Salle";
            SqlCommand com3 = new SqlCommand(requete, n);

            SqlDataReader dr3 = com3.ExecuteReader();

            while (dr3.Read())
            {
                DropDownList4.Items.Add(dr3.GetInt32(0) + " " + dr3.GetString(1) + " " + dr3.GetString(2));
            }
            n.Close();

            n.Open();

            requete = "select IDens from Enseignent";
            SqlCommand com4 = new SqlCommand(requete, n);

            SqlDataReader dr4 = com4.ExecuteReader();
            DropDownList5.Items.Clear();
            while (dr4.Read())
            {
                DropDownList5.Items.Add(dr4.GetInt32(0).ToString());
            }
            n.Close();

            n.Open();

            requete = "select IDdep from Departement";
            SqlCommand com5 = new SqlCommand(requete, n);

            SqlDataReader dr5 = com5.ExecuteReader();
            DropDownList5.Items.Clear();
            while (dr5.Read())
            {
                DropDownList5.Items.Add(dr5.GetInt32(0).ToString());
            }
            n.Close();


            n.Open();
            requete = "select IDcours from Cours";
            SqlCommand com6 = new SqlCommand(requete, n);

            SqlDataReader dr6 = com6.ExecuteReader();
            DropDownList5.Items.Clear();
            while (dr6.Read())
            {
                DropDownList5.Items.Add(dr6.GetInt32(0).ToString());
            }
            n.Close();

            n.Open();

            requete = "select IDsalle from Salle";
            SqlCommand com7 = new SqlCommand(requete, n);

            SqlDataReader dr7 = com7.ExecuteReader();
            DropDownList5.Items.Clear();
            while (dr7.Read())
            {
                DropDownList5.Items.Add(dr7.GetInt32(0).ToString());
            }
            n.Close();

        }
    }

    protected void Button1_Click1(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        string chaine = "Data Source = DESKTOP-62FIK78\\SQLEXPRESS;initial catalog = Enseignents ;user id = ult ;password = 123456;Integrated Security=true";
        SqlConnection n = new SqlConnection(chaine);

        n.Open();

        string idcr = DropDownList1.SelectedItem.ToString();
        string iddep = DropDownList2.SelectedItem.ToString();
        string idens = DropDownList3.SelectedItem.ToString();
        string idsal = DropDownList4.SelectedItem.ToString();

        string[] cour = idcr.Split(' ');
        string[] depart = iddep.Split(' ');
        string[] ense = idens.Split(' ');
        string[] salle = idsal.Split(' ');
        string datedeb = DateTime.Now.ToShortTimeString();
        string datefin = DateTime.Now.ToShortTimeString();

        string requete = "insert into Horairee(Cours, Departement, Enseignent,Salle,Date_debut,Date_fin) values ('" + cour[0] + "','" + depart[0] + "','" + ense[0] + "','" + salle[0] + "','" + datedeb + "','" + datefin + "')";
        SqlCommand com = new SqlCommand(requete, n);
        com.ExecuteNonQuery();
        n.Close();
       
    }
    protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void DropDownList5_SelectedIndexChanged(object sender, EventArgs e)
    {
           int a = Int32.Parse(DropDownList5.SelectedItem.ToString());
        string chaine = "Data Source = DESKTOP-62FIK78\\SQLEXPRESS;initial catalog = Enseignents ;user id = ult ;password = 123456;Integrated Security=true";
        SqlConnection n = new SqlConnection(chaine);
        n.Open();
        string requete = "";
        requete = "select Date_debut,Date_fin from Horairee where Horairee.IDhoraire = " + a + "";
        SqlCommand com = new SqlCommand(requete, n);
        SqlDataReader dr = com.ExecuteReader();

        if (dr.Read())
        {
            TextBox1.Text = dr.GetString(1);
            TextBox2.Text = dr.GetString(0);
        }
        n.Close();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        string chaine = "Data Source = DESKTOP-62FIK78\\SQLEXPRESS;initial catalog = Enseignents ;user id = ult ;password = 123456;Integrated Security=true";
        SqlConnection n = new SqlConnection(chaine);

        n.Open();
        string requete = "";
        requete = "update Horairee set Date_debut = '" + TextBox2.Text + "',Date_fin ='" + TextBox1.Text + "'";
        SqlCommand com = new SqlCommand(requete, n);
        com.ExecuteNonQuery();
        n.Close();
    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}