
namespace AplicacionEscritorioBD1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtCampo = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.vista = new System.Windows.Forms.DataGridView();
            this.coneccion = new System.Windows.Forms.Button();
            this.seleccionar = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.Label();
            this.precio = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtseccion = new System.Windows.Forms.TextBox();
            this.seccion = new System.Windows.Forms.Label();
            this.paisorigen = new System.Windows.Forms.Label();
            this.txtpaisorigen = new System.Windows.Forms.TextBox();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.fecha = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vista)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar:";
            // 
            // txtCampo
            // 
            this.txtCampo.Location = new System.Drawing.Point(75, 29);
            this.txtCampo.Name = "txtCampo";
            this.txtCampo.Size = new System.Drawing.Size(211, 20);
            this.txtCampo.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Yellow;
            this.btnBuscar.Location = new System.Drawing.Point(293, 27);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // vista
            // 
            this.vista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vista.Location = new System.Drawing.Point(12, 66);
            this.vista.Name = "vista";
            this.vista.Size = new System.Drawing.Size(631, 321);
            this.vista.TabIndex = 3;
            // 
            // coneccion
            // 
            this.coneccion.BackColor = System.Drawing.Color.Lime;
            this.coneccion.Location = new System.Drawing.Point(68, 400);
            this.coneccion.Name = "coneccion";
            this.coneccion.Size = new System.Drawing.Size(75, 23);
            this.coneccion.TabIndex = 4;
            this.coneccion.Text = "CONECTAR";
            this.coneccion.UseVisualStyleBackColor = false;
            this.coneccion.Click += new System.EventHandler(this.coneccion_Click);
            // 
            // seleccionar
            // 
            this.seleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.seleccionar.Location = new System.Drawing.Point(172, 400);
            this.seleccionar.Name = "seleccionar";
            this.seleccionar.Size = new System.Drawing.Size(86, 23);
            this.seleccionar.TabIndex = 5;
            this.seleccionar.Text = "TRAE DATOS";
            this.seleccionar.UseVisualStyleBackColor = false;
            this.seleccionar.Click += new System.EventHandler(this.seleccionar_Click);
            // 
            // insert
            // 
            this.insert.BackColor = System.Drawing.Color.Fuchsia;
            this.insert.Location = new System.Drawing.Point(293, 400);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(75, 23);
            this.insert.TabIndex = 6;
            this.insert.Text = "INSERTAR";
            this.insert.UseVisualStyleBackColor = false;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(671, 105);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 7;
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(668, 89);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(54, 13);
            this.Id.TabIndex = 8;
            this.Id.Text = "Id Articulo";
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.Location = new System.Drawing.Point(668, 179);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(44, 13);
            this.nom.TabIndex = 9;
            this.nom.Text = "Nombre";
            // 
            // precio
            // 
            this.precio.AutoSize = true;
            this.precio.Location = new System.Drawing.Point(668, 224);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(37, 13);
            this.precio.TabIndex = 10;
            this.precio.Text = "Precio";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(671, 195);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 11;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(671, 240);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(100, 20);
            this.txtprecio.TabIndex = 12;
            // 
            // txtseccion
            // 
            this.txtseccion.Location = new System.Drawing.Point(671, 150);
            this.txtseccion.Name = "txtseccion";
            this.txtseccion.Size = new System.Drawing.Size(100, 20);
            this.txtseccion.TabIndex = 13;
            // 
            // seccion
            // 
            this.seccion.AutoSize = true;
            this.seccion.Location = new System.Drawing.Point(669, 134);
            this.seccion.Name = "seccion";
            this.seccion.Size = new System.Drawing.Size(46, 13);
            this.seccion.TabIndex = 14;
            this.seccion.Text = "Seccion";
            // 
            // paisorigen
            // 
            this.paisorigen.AutoSize = true;
            this.paisorigen.Location = new System.Drawing.Point(669, 311);
            this.paisorigen.Name = "paisorigen";
            this.paisorigen.Size = new System.Drawing.Size(61, 13);
            this.paisorigen.TabIndex = 15;
            this.paisorigen.Text = "Pais Origen";
            // 
            // txtpaisorigen
            // 
            this.txtpaisorigen.Location = new System.Drawing.Point(671, 327);
            this.txtpaisorigen.Name = "txtpaisorigen";
            this.txtpaisorigen.Size = new System.Drawing.Size(100, 20);
            this.txtpaisorigen.TabIndex = 16;
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(672, 285);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(100, 20);
            this.txtfecha.TabIndex = 17;
            // 
            // fecha
            // 
            this.fecha.AutoSize = true;
            this.fecha.Location = new System.Drawing.Point(671, 267);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(37, 13);
            this.fecha.TabIndex = 18;
            this.fecha.Text = "Fecha";
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnupdate.Location = new System.Drawing.Point(405, 400);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(82, 23);
            this.btnupdate.TabIndex = 19;
            this.btnupdate.Text = "ACTUALIZAR";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.Red;
            this.btneliminar.Location = new System.Drawing.Point(535, 399);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 20;
            this.btneliminar.Text = "ELIMINAR";
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.txtpaisorigen);
            this.Controls.Add(this.paisorigen);
            this.Controls.Add(this.seccion);
            this.Controls.Add(this.txtseccion);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.seleccionar);
            this.Controls.Add(this.coneccion);
            this.Controls.Add(this.vista);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCampo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.vista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCampo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView vista;
        private System.Windows.Forms.Button coneccion;
        private System.Windows.Forms.Button seleccionar;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.Label nom;
        private System.Windows.Forms.Label precio;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtseccion;
        private System.Windows.Forms.Label seccion;
        private System.Windows.Forms.Label paisorigen;
        private System.Windows.Forms.TextBox txtpaisorigen;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.Label fecha;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btneliminar;
    }
}

