using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemploInventario
{
    public partial class createUser : Form
    {
        public createUser()
        {
            InitializeComponent();
        }

        private void cargar_elementos(object sender, EventArgs e)
        {
            //Agregar los días al combobox
            for (int i = 1; i <= 31; i++)
                cmb_day.Items.Add(i);

            //Agregar los meses al combobox
            cmb_mes.Items.Add("Enero");
            cmb_mes.Items.Add("Febrero");
            cmb_mes.Items.Add("Marzo");
            cmb_mes.Items.Add("Abril");
            cmb_mes.Items.Add("Mayo");
            cmb_mes.Items.Add("Junio");
            cmb_mes.Items.Add("Julio");
            cmb_mes.Items.Add("Agosto");
            cmb_mes.Items.Add("Septiembre");
            cmb_mes.Items.Add("Octubre");
            cmb_mes.Items.Add("Noviembre");
            cmb_mes.Items.Add("Diciembre");

            //Agregar Años al combobox
            for (int i = 1910; i < 2018; i++)
                cmb_año.Items.Add(i);
        }

        private void guardar_user(object sender, EventArgs e)
        {

        }

        private void click_cancelar(object sender, EventArgs e)
        {

        }
    }
}
