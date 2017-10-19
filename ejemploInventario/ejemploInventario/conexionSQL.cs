using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ejemploInventario
{
    class conexionSQL
    {
        SqlConnection myConnection = new SqlConnection("Data Source=localhost;Initial Catalog=prueba1;Integrated Security=True");
        string user, pass;
        public void agregarUsuarios(string[] datos_de_usuario)
        {
            myConnection.Open();
            string query = string.Format("INSERT INTO informacion (nick,contraseña,nombre,apellidos,fecha_nacimiento,ciudad) VALUES('{0}','{1}','{2}','{3}','{4}')",
                datos_de_usuario[0],
                datos_de_usuario[1],
                datos_de_usuario[2],
                datos_de_usuario[3],
                datos_de_usuario[4]);
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

        public DataTable tabla(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            da.SelectCommand = new SqlCommand(sql, myConnection);

            da.Fill(ds);

            dt = ds.Tables[0];
            return dt;
        }
    }
}
