using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ejemploInventario
{
    class conexionSQL
    {
        SqlConnection myConnection = new SqlConnection("Data Source=localhost;Initial Catalog=prueba1;Integrated Security=True");
        //SqlConnection myConnection = new SqlConnection("server=localhost; database=prueba1; user id=sa; password=sasa;");
        string user, pass;


        public bool agregarDatos(string[] _datos)
        {
            try
            {
                string query = string.Format("INSERT INTO t_datos (nombre,apellidos,edad,hobbies) VALUES ('{0}','{1}','{2}','{3}')",
                    _datos[0]/*Nombre*/,
                    _datos[1]/*Apellido*/,
                    _datos[2]/*Edad*/,
                    _datos[3]/*Hobbies*/);
                myConnection.Open();
                SqlCommand myCommand = new SqlCommand(query,myConnection);
                myCommand.ExecuteNonQuery();
                myConnection.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Login(string name_user, string password)
        {
            myConnection.Open();
            string query = string.Format("SELECT name_user,password FROM t_usuarios WHERE name_user='{0}' AND password='{1}';",
                name_user, password);
            SqlCommand mycommand = new SqlCommand(query, myConnection);
            SqlDataReader da = mycommand.ExecuteReader();
            while (da.Read())
            {
                user = da["name_user"].ToString();
                pass = da["password"].ToString();
            }
            myConnection.Close();
            if (user == name_user && pass == password)
                return true;
            else
                return false;
        }
    }
}
