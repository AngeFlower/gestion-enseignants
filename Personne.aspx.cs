using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;

public partial class Personne : System.Web.UI.Page
{
    public static int idP;
    public static string status;

    protected void Page_Load(object sender, EventArgs e)
    {
        string chaine = "Data Source = DESKTOP-62FIK78\\SQLEXPRESS;initial catalog = Enseignents ;user id = ult ;password = 123456;Integrated Security=true";
        SqlConnection n = new SqlConnection(chaine);

        string requete = "";
        if (!IsPostBack)
        {
            DropDownList1.Items.Add("Enseignent");
            DropDownList1.Items.Add("Utilisateur");

            n.Open();
            requete = "select IDens from Enseignent";
            SqlCommand com = new SqlCommand(requete, n);

            SqlDataReader dr = com.ExecuteReader();
            DropDownList3.Items.Clear();
            while (dr.Read())
            {
                DropDownList3.Items.Add(dr.GetInt32(0).ToString());
            }
            n.Close();

            n.Open();
            requete = "select IDuti from Utilisateur";
            SqlCommand com1 = new SqlCommand(requete, n);

            SqlDataReader dr1 = com1.ExecuteReader();
            DropDownList3.Items.Clear();
            while (dr1.Read())
            {
                DropDownList3.Items.Add(dr1.GetInt32(0).ToString());
            }
            n.Close();

            Personne.status = DropDownList1.SelectedItem.ToString();
            //Response.Write("<script>alert(" + Personne.status + ")</script>");
            if (Personne.status == "Enseignent")
            {
                n.Open();
                requete = "select IDpers,IDens from Personne,Enseignent where Enseignent.PersonneEnse = Personne.IDpers";
                SqlCommand com9 = new SqlCommand(requete, n);

                SqlDataReader dr7 = com9.ExecuteReader();
                DropDownList3.Items.Clear();
                while (dr7.Read())
                {
                    DropDownList3.Items.Add(dr7.GetInt32(0).ToString());
                }
                n.Close();
            }
            else {
                n.Open();
                requete = "select IDpers from Personne";
                SqlCommand com10 = new SqlCommand(requete, n);

                SqlDataReader dr8 = com10.ExecuteReader();
                DropDownList3.Items.Clear();
                while (dr8.Read())
                {
                    DropDownList3.Items.Add(dr8.GetInt32(0).ToString());
                }
                n.Close();
            }
        }
    }
   
    protected void Button1_Click1(object sender, EventArgs e)
    {

        Response.Write("<script>alert(" + Personne.status + ")</script>");
        string chaine = "Data Source = DESKTOP-62FIK78\\SQLEXPRESS;initial catalog = Enseignents ;user id = ult ;password = 123456;Integrated Security=true";
        SqlConnection n = new SqlConnection(chaine);

        //ouverture de la connexion



        //requete


        string get_requete = "select * from  Personne where IDpers = (SELECT max(IDpers) FROM Personne)";

        n.Open();
        //objet commande pour executer le requete

        SqlCommand get = new SqlCommand(get_requete, n);
        SqlDataReader dr2 = get.ExecuteReader();
        if (dr2.HasRows)
        {
            while (dr2.Read())
            {
                Personne.idP = dr2.GetInt32(0);
            }
        }
        n.Close();
        n.Open();
        string requete = "insert into Personne(Nompers,Prenompers,Telephone,Email,Gerne,status) values('" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + Personne.status + "')";
        SqlCommand com = new SqlCommand(requete, n);

        //executer de la commande

        com.ExecuteNonQuery();

        n.Close();

        if (Personne.status == "Enseignent")
        {


            n.Open();
            //objet commande pour executer le requete

            SqlCommand get2 = new SqlCommand(get_requete, n);
            SqlDataReader dr3 = get2.ExecuteReader();
            if (dr3.HasRows)
            {
                while (dr3.Read())
                {
                    Personne.idP = dr3.GetInt32(0);
                }
            }
            n.Close();

            n.Open();

            string requete2 = "insert into Enseignent(PersonneEns,Degre) values(" + Personne.idP + ",'" + TextBox8.Text + "')";
            SqlCommand com2 = new SqlCommand(requete2, n);
            SqlDataReader dr4 = com2.ExecuteReader();
            if (dr4.Read())
            {
                Response.Write("<script>alert('Success')</script>");
            }
            else
            {
                Response.Write("<script>alert('Enseignent enregistre avec Success')</script>");
            }
        }
        else if (Personne.status == "Utilisateur")
        {
            n.Open();
            //objet commande pour executer le requete

            SqlCommand get2 = new SqlCommand(get_requete, n);
            SqlDataReader dr3 = get2.ExecuteReader();
            if (dr3.HasRows)
            {
                while (dr3.Read())
                {
                    Personne.idP = dr3.GetInt32(0);
                }
            }
            n.Close();

            n.Open();
            string requete2 = "insert into Utilisateur(PersonneUti,Password,Usename,Profil) values(" + Personne.idP + ",'" + TextBox9.Text + "','" + TextBox10.Text + "','" + DropDownList2.SelectedItem.ToString() + "')";
            SqlCommand com2 = new SqlCommand(requete2, n);
            SqlDataReader dr4 = com2.ExecuteReader();
            if (dr4.Read())
            {
                Response.Write("<script>alert('Success')</script>");
            }
            else
            {
                Response.Write("<script>alert('Utilisateur enregistre avec success')</script>");
            }
        }

    }
    protected void DropDownList1_SelectedIndexChanged1(object sender, EventArgs e)
    {
        Personne.status = DropDownList1.SelectedItem.ToString();

        Response.Write("<script>alert(" + Personne.status + ")</script>");
        if (Personne.status == "Enseignent")
        {
            string chaine = "Data Source = DESKTOP-62FIK78\\SQLEXPRESS;initial catalog = Enseignents ;user id = ult ;password = 123456;Integrated Security=true";
            SqlConnection n = new SqlConnection(chaine);
            n.Open();
            string requete = "select IDpers,IDens from Personne,Enseignent where Enseignent.PersonneEns = Personne.IDpers";
            SqlCommand com9 = new SqlCommand(requete, n);

            SqlDataReader dr7 = com9.ExecuteReader();
            DropDownList3.Items.Clear();
            while (dr7.Read())
            {
                DropDownList3.Items.Add(dr7.GetInt32(0).ToString());
            }
            n.Close();

            Label1.Visible = true;
            Label2.Visible = true;
            Label4.Visible = true;
            Label5.Visible = true;
            Label6.Visible = true;
            Label8.Visible = true;
            Label7.Visible = false;
            Label9.Visible = false;
            TextBox4.Visible = true;
            TextBox5.Visible = true;
            TextBox1.Visible = true;
            TextBox2.Visible = true;
            TextBox3.Visible = true;
            TextBox8.Visible = true;
            DropDownList2.Visible = false;
            TextBox9.Visible = false;
            Label10.Visible = false;
            TextBox10.Visible = false;
        }
        else if (Personne.status == "Utilisateur")
        {
            Response.Write("<script>alert(" + Personne.status + ")</script>");
            Label1.Visible = true;
            Label2.Visible = true;
            Label4.Visible = true;
            Label5.Visible = true;
            Label6.Visible = true;
            Label8.Visible = false;
            Label7.Visible = true;
            Label9.Visible = true;
            TextBox4.Visible = true;
            TextBox5.Visible = true;
            TextBox1.Visible = true;
            TextBox2.Visible = true;
            TextBox3.Visible = true;
            TextBox8.Visible = false;
            DropDownList2.Visible = true;
            TextBox9.Visible = true;
            Label10.Visible = true;
            TextBox10.Visible = true;
        }
    }
    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {
        int a = Int32.Parse(DropDownList3.SelectedItem.ToString());
        string chaine = "Data Source = DESKTOP-62FIK78\\SQLEXPRESS;initial catalog = Enseignents ;user id = ult ;password = 123456;Integrated Security=true";
        SqlConnection n = new SqlConnection(chaine);
        n.Open();
        string requete3 = "";
        requete3 = "select Degre,Nompers,Prenompers from Enseignent,Personne where Enseignent.IDens = " + a + " and Personne.IDpers=Enseignent.PersonneEns";
        SqlCommand com3 = new SqlCommand(requete3, n);
        SqlDataReader dr5 = com3.ExecuteReader();

        if (dr5.Read())
        {
            TextBox4.Text = dr5.GetString(1);
            TextBox5.Text = dr5.GetString(2);
            TextBox8.Text = dr5.GetString(0);
        }
        n.Close();

        n.Open();
        requete3 = "select u.Password,u.Profil,p.Nompers,p.Prenompers,u.Usename from Utilisateur u,Personne p where u.IDuti = " + a + " and p.IDpers=u.PersonneUti";
        SqlCommand com4 = new SqlCommand(requete3, n);
        SqlDataReader dr6 = com4.ExecuteReader();

        if (dr6.Read())
        {
            TextBox4.Text = dr6.GetString(2);
            TextBox5.Text = dr6.GetString(3);
            TextBox9.Text = dr6.GetString(0);
            DropDownList2.Items.Add(dr6.GetInt32(0).ToString());
            TextBox10.Text = dr6.GetString(4);
        }
        n.Close();
    }
    protected void Button2_Click1(object sender, EventArgs e)
    {
        int a = Int32.Parse(DropDownList3.SelectedItem.ToString());
        string chaine = "Data Source = DESKTOP-62FIK78\\SQLEXPRESS;initial catalog = Enseignents ;user id = ult ;password = 123456;Integrated Security=true";
        SqlConnection n = new SqlConnection(chaine);

        Personne.status = DropDownList1.SelectedItem.ToString();
        string requete4 = "";
        if (Personne.status == "Enseignent")
        {
            n.Open();
            
            requete4 = "update Enseignent set Degre = '" + TextBox8.Text + "' where PersonneEns =" + a + "";
            SqlCommand com5 = new SqlCommand(requete4, n);
            com5.ExecuteNonQuery();
            n.Close();

            n.Open();
            requete4 = "update Personne set Nompers = '" + TextBox4.Text + "',Prenompers = '" + TextBox5.Text + "',Telephone = '" + TextBox1.Text + "',Email = '" + TextBox2.Text + "',Gerne = '" + TextBox3.Text + "'WHERE Personne.IDpers="+DropDownList3.SelectedItem.Value+"";
            SqlCommand com6 = new SqlCommand(requete4, n);
            com6.ExecuteNonQuery();
            n.Close();
        }

        if (Personne.status == "Utilisateur")
        {
            n.Open();
            requete4 = "update Utilisateur set Profil = '" + DropDownList2.SelectedItem + "', Password = '" + TextBox9.Text + "',Usename ='" + TextBox10.Text + "' where IDuti =" + a + "";
            SqlCommand com7 = new SqlCommand(requete4, n);
            com7.ExecuteNonQuery();
            n.Close();

            n.Open();
            requete4 = "update Personne set Nompers = '" + TextBox4.Text + "',Prenompers = '" + TextBox5.Text + "'WHERE Personne.IDpers=" + DropDownList3.SelectedItem.Value + "";
            SqlCommand com8 = new SqlCommand(requete4, n);
            com8.ExecuteNonQuery();
            n.Close();
        }
    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
