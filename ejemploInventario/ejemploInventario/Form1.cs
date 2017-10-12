using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ejemploInventario;

namespace ejemploInventario
{
    public partial class Form1 : Form
    {
        conexionSQL conexion_SQL = new conexionSQL();
        ejemplo1 form_welcome = new ejemplo1();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void click_boton(object sender, EventArgs e)
        {
            if (conexion_SQL.Login(txt_user.Text, txt_password.Text))
                MessageBox.Show("Bienvenido!!");
            else
                MessageBox.Show("Usuario/Contraseña Incorrecta");
        }

        private void click_link(object sender, LinkLabelLinkClickedEventArgs e)
        {
            form_welcome.Show();
        }
    }
}
