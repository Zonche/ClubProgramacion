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
    public partial class datos : Form
    {
        public datos()
        {
            InitializeComponent();
        }
        conexionSQL myconection = new conexionSQL();
        private void datos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prueba1DataSet1.t_datos' table. You can move, or remove it, as needed.
            this.t_datosTableAdapter.Fill(this.prueba1DataSet1.t_datos);

        }

        private void ingresar_datos_click(object sender, EventArgs e)
        {
            string[] misDatos = new string[4];
            misDatos[0] = txt_name.Text;
            misDatos[1] = txt_apellidos.Text;
            misDatos[2] = txt_edad.Text;
            misDatos[3] = txt_hobbies.Text;
            if (myconection.agregarDatos(misDatos))
                MessageBox.Show("Se ingresaron con exitos los datos");
            else
                MessageBox.Show("Hubo un error");

            this.t_datosTableAdapter.Fill(this.prueba1DataSet1.t_datos);
        }
    }
}
