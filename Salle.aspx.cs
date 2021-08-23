using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;

public partial class Salle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string chaine = "Data Source = DESKTOP-62FIK78\\SQLEXPRESS;initial catalog = Enseignents ;user id = ult ;password = 123456;Integrated Security=true";
        SqlConnection n = new SqlConnection(chaine);

        n.Open();
        string requete = "";
        if (!IsPostBack)
        {
            requete = "select IDsalle from Salle";
            SqlCommand com = new SqlCommand(requete, n);

            SqlDataReader dr = com.ExecuteReader();
            DropDownList1.Items.Clear();
            while (dr.Read())
            {
                DropDownList1.Items.Add(dr.GetInt32(0).ToString());
            }
            n.Close();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Write("<script>alert('clicked')</script>");
        string chaine = "Data Source = DESKTOP-62FIK78\\SQLEXPRESS;initial catalog = Enseignents ;user id = ult ;password = 123456;Integrated Security=true";
        SqlConnection n = new SqlConnection(chaine);
        n.Open();
       
            string requete = "insert into Salle (Nomsalle,Bloc) values('" + TextBox1.Text + "','" + TextBox2.Text + "')";
            SqlCommand com = new SqlCommand(requete, n);
            com.ExecuteNonQuery();
            Response.Write("Salle Ajoutée Avec Succes.");
            n.Close();
            n.Open();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        string chaine = "Data Source = DESKTOP-62FIK78\\SQLEXPRESS;initial catalog = Enseignents ;user id = ult ;password = 123456;Integrated Security=true";
        SqlConnection n = new SqlConnection(chaine);

        n.Open();
        string requete = "";
        requete = "update Salle set Nomsalle = '" + TextBox1.Text + "',Bloc ='" + TextBox2.Text + "'";
        SqlCommand com = new SqlCommand(requete, n);
        com.ExecuteNonQuery();
        n.Close();
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int a = Int32.Parse(DropDownList1.SelectedItem.ToString());
        string chaine = "Data Source = DESKTOP-62FIK78\\SQLEXPRESS;initial catalog = Enseignents ;user id = ult ;password = 123456;Integrated Security=true";
        SqlConnection n = new SqlConnection(chaine);
        n.Open();
        string requete = "";
        requete = "select Nomsalle,Bloc from Salle where Salle.IDsalle = " + a + "";
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