namespace Examen
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dni = new System.Windows.Forms.TextBox();
            this.apellido = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.nota = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.registrar = new System.Windows.Forms.Button();
            this.calificacion = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ced = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.not = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.dni_bus = new System.Windows.Forms.TextBox();
            this.buscar = new System.Windows.Forms.Button();
            this.crudBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.crudBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.crudBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.crudBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.nota_nueva = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.notaN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crudBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crudBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crudBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crudBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exámen Práctico";
            // 
            // dni
            // 
            this.dni.Location = new System.Drawing.Point(69, 63);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(100, 22);
            this.dni.TabIndex = 1;
            this.dni.TextChanged += new System.EventHandler(this.dni_TextChanged);
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(194, 63);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(100, 22);
            this.apellido.TabIndex = 2;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(337, 63);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(100, 22);
            this.nombre.TabIndex = 3;
            // 
            // nota
            // 
            this.nota.Location = new System.Drawing.Point(461, 66);
            this.nota.Name = "nota";
            this.nota.Size = new System.Drawing.Size(100, 22);
            this.nota.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "DNI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Apellidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(358, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(490, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nota";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(703, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Calificación";
            // 
            // registrar
            // 
            this.registrar.Location = new System.Drawing.Point(592, 66);
            this.registrar.Name = "registrar";
            this.registrar.Size = new System.Drawing.Size(75, 23);
            this.registrar.TabIndex = 12;
            this.registrar.Text = "Registrar";
            this.registrar.UseVisualStyleBackColor = true;
            this.registrar.Click += new System.EventHandler(this.registrar_Click);
            // 
            // calificacion
            // 
            this.calificacion.AutoSize = true;
            this.calificacion.Location = new System.Drawing.Point(727, 66);
            this.calificacion.Name = "calificacion";
            this.calificacion.Size = new System.Drawing.Size(27, 16);
            this.calificacion.TabIndex = 14;
            this.calificacion.Text = "****";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ced,
            this.ap,
            this.Nom,
            this.not,
            this.Ca});
            this.dataGridView1.Location = new System.Drawing.Point(1, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(855, 387);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ced
            // 
            this.ced.HeaderText = "DNI";
            this.ced.MinimumWidth = 6;
            this.ced.Name = "ced";
            this.ced.Width = 125;
            // 
            // ap
            // 
            this.ap.HeaderText = "Apellifos";
            this.ap.MinimumWidth = 6;
            this.ap.Name = "ap";
            this.ap.Width = 125;
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nombres";
            this.Nom.MinimumWidth = 6;
            this.Nom.Name = "Nom";
            this.Nom.Width = 125;
            // 
            // not
            // 
            this.not.HeaderText = "Nota";
            this.not.MinimumWidth = 6;
            this.not.Name = "not";
            this.not.Width = 125;
            // 
            // Ca
            // 
            this.Ca.HeaderText = "Calificación";
            this.Ca.MinimumWidth = 6;
            this.Ca.Name = "Ca";
            this.Ca.Width = 125;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Buscar por DNI";
            // 
            // dni_bus
            // 
            this.dni_bus.Location = new System.Drawing.Point(69, 141);
            this.dni_bus.Name = "dni_bus";
            this.dni_bus.Size = new System.Drawing.Size(100, 22);
            this.dni_bus.TabIndex = 17;
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(194, 140);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(104, 23);
            this.buscar.TabIndex = 18;
            this.buscar.Text = "Consultar nota";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // crudBindingSource1
            // 
            this.crudBindingSource1.DataSource = typeof(Examen.Crud);
            // 
            // crudBindingSource
            // 
            this.crudBindingSource.DataSource = typeof(Examen.Crud);
            // 
            // crudBindingSource2
            // 
            this.crudBindingSource2.DataSource = typeof(Examen.Crud);
            // 
            // crudBindingSource3
            // 
            this.crudBindingSource3.DataSource = typeof(Examen.Crud);
            // 
            // nota_nueva
            // 
            this.nota_nueva.Location = new System.Drawing.Point(350, 140);
            this.nota_nueva.Name = "nota_nueva";
            this.nota_nueva.Size = new System.Drawing.Size(100, 22);
            this.nota_nueva.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(358, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Nueva nota";
            // 
            // notaN
            // 
            this.notaN.Location = new System.Drawing.Point(486, 141);
            this.notaN.Name = "notaN";
            this.notaN.Size = new System.Drawing.Size(75, 23);
            this.notaN.TabIndex = 21;
            this.notaN.Text = "Actualizar nota";
            this.notaN.UseVisualStyleBackColor = true;
            this.notaN.Click += new System.EventHandler(this.notaN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 608);
            this.Controls.Add(this.notaN);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nota_nueva);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.dni_bus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.calificacion);
            this.Controls.Add(this.registrar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nota);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.dni);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crudBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crudBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crudBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crudBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dni;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox nota;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button registrar;
        private System.Windows.Forms.Label calificacion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource crudBindingSource;
        private System.Windows.Forms.BindingSource crudBindingSource1;
        private System.Windows.Forms.BindingSource crudBindingSource2;
        private System.Windows.Forms.BindingSource crudBindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ced;
        private System.Windows.Forms.DataGridViewTextBoxColumn ap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn not;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox dni_bus;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.TextBox nota_nueva;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button notaN;
    }
}

