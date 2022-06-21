using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


namespace WebAccesoDatos
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection camino = new SqlConnection();
            SqlCommand vocho = null;
            camino.ConnectionString = 
                System.Configuration.ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            try
            {
                camino.Open();
                vocho = new SqlCommand();
                vocho.CommandText = "INSERT INTO EstadoCivil(Estado, Extra) VALUES('Soltero', 'Especial')";
                vocho.Connection = camino;
                vocho.ExecuteNonQuery();
                Label1.Text = "Inserción Correctamente";


            }catch(Exception ex)
            {
                Label1.Text = "Error: " + ex.Message;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}