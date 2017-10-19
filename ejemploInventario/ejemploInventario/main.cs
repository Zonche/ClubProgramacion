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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }
        conexionSQL con = new conexionSQL();
        private void main_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'prueba1DataSet1.t_datos' Puede moverla o quitarla según sea necesario.
            //this.t_datosTableAdapter.Fill(this.prueba1DataSet1.t_datos);
            // TODO: esta línea de código carga datos en la tabla 'prueba1DataSet.t_usuarios' Puede moverla o quitarla según sea necesario.
            //this.t_usuariosTableAdapter.Fill(this.prueba1DataSet.t_usuarios);
            dataGridView1.DataSource = con.tabla("select * from t_datos");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
