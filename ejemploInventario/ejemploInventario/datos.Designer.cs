namespace ejemploInventario
{
    partial class datos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_apellidos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_edad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_hobbies = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.dgv_datos = new System.Windows.Forms.DataGridView();
            this.prueba1DataSet1 = new ejemploInventario.prueba1DataSet1();
            this.tdatosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_datosTableAdapter = new ejemploInventario.prueba1DataSet1TableAdapters.t_datosTableAdapter();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hobbiesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prueba1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tdatosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(67, 13);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(200, 20);
            this.txt_name.TabIndex = 1;
            // 
            // txt_apellidos
            // 
            this.txt_apellidos.Location = new System.Drawing.Point(67, 51);
            this.txt_apellidos.Name = "txt_apellidos";
            this.txt_apellidos.Size = new System.Drawing.Size(200, 20);
            this.txt_apellidos.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellidos:";
            // 
            // txt_edad
            // 
            this.txt_edad.Location = new System.Drawing.Point(67, 90);
            this.txt_edad.Name = "txt_edad";
            this.txt_edad.Size = new System.Drawing.Size(102, 20);
            this.txt_edad.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Edad:";
            // 
            // txt_hobbies
            // 
            this.txt_hobbies.Location = new System.Drawing.Point(67, 131);
            this.txt_hobbies.Multiline = true;
            this.txt_hobbies.Name = "txt_hobbies";
            this.txt_hobbies.Size = new System.Drawing.Size(200, 104);
            this.txt_hobbies.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hobbies:";
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.Location = new System.Drawing.Point(290, 13);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(75, 23);
            this.btn_ingresar.TabIndex = 8;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.UseVisualStyleBackColor = true;
            this.btn_ingresar.Click += new System.EventHandler(this.ingresar_datos_click);
            // 
            // dgv_datos
            // 
            this.dgv_datos.AutoGenerateColumns = false;
            this.dgv_datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.edadDataGridViewTextBoxColumn,
            this.hobbiesDataGridViewTextBoxColumn});
            this.dgv_datos.DataSource = this.tdatosBindingSource;
            this.dgv_datos.Location = new System.Drawing.Point(290, 51);
            this.dgv_datos.Name = "dgv_datos";
            this.dgv_datos.Size = new System.Drawing.Size(407, 184);
            this.dgv_datos.TabIndex = 9;
            // 
            // prueba1DataSet1
            // 
            this.prueba1DataSet1.DataSetName = "prueba1DataSet1";
            this.prueba1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tdatosBindingSource
            // 
            this.tdatosBindingSource.DataMember = "t_datos";
            this.tdatosBindingSource.DataSource = this.prueba1DataSet1;
            // 
            // t_datosTableAdapter
            // 
            this.t_datosTableAdapter.ClearBeforeFill = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "apellidos";
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "apellidos";
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            // 
            // edadDataGridViewTextBoxColumn
            // 
            this.edadDataGridViewTextBoxColumn.DataPropertyName = "edad";
            this.edadDataGridViewTextBoxColumn.HeaderText = "edad";
            this.edadDataGridViewTextBoxColumn.Name = "edadDataGridViewTextBoxColumn";
            // 
            // hobbiesDataGridViewTextBoxColumn
            // 
            this.hobbiesDataGridViewTextBoxColumn.DataPropertyName = "hobbies";
            this.hobbiesDataGridViewTextBoxColumn.HeaderText = "hobbies";
            this.hobbiesDataGridViewTextBoxColumn.Name = "hobbiesDataGridViewTextBoxColumn";
            // 
            // datos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 267);
            this.Controls.Add(this.dgv_datos);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.txt_hobbies);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_edad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_apellidos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label1);
            this.Name = "datos";
            this.Text = "datos";
            this.Load += new System.EventHandler(this.datos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prueba1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tdatosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_apellidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_edad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_hobbies;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.DataGridView dgv_datos;
        private prueba1DataSet1 prueba1DataSet1;
        private System.Windows.Forms.BindingSource tdatosBindingSource;
        private prueba1DataSet1TableAdapters.t_datosTableAdapter t_datosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hobbiesDataGridViewTextBoxColumn;
    }
}