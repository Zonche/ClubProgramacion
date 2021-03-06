﻿using System;
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
            string[] datos = new string[6];
            datos[0] = txt_user.Text;
            datos[1] = txt_contraseña.Text;
            datos[2] = txt_name.Text;
            datos[3] = txt_apellidos.Text;
            //MES-DIA-Año
            datos[4] =(string) cmb_mes.SelectedItem+"-" + cmb_day.SelectedItem+"-" + cmb_año.SelectedItem;
            MessageBox.Show(datos[4]);
        }

        private void click_cancelar(object sender, EventArgs e)
        {

        }
    }
}
