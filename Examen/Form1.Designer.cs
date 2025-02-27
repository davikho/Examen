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
            this.nota_nueva = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.notaN = new System.Windows.Forms.Button();
            this.suspensos = new System.Windows.Forms.Button();
            this.aprobados = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.todos = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.crudBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.crudBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.crudBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.crudBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crudBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crudBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crudBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crudBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(506, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exámen Práctico";
            // 
            // dni
            // 
            this.dni.Location = new System.Drawing.Point(3, 31);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(112, 22);
            this.dni.TabIndex = 1;
            this.dni.TextChanged += new System.EventHandler(this.dni_TextChanged);
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(121, 31);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(112, 22);
            this.apellido.TabIndex = 2;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(239, 31);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(112, 22);
            this.nombre.TabIndex = 3;
            // 
            // nota
            // 
            this.nota.Location = new System.Drawing.Point(357, 31);
            this.nota.Name = "nota";
            this.nota.Size = new System.Drawing.Size(112, 22);
            this.nota.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "DNI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Apellidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nota";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(475, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Calificación";
            // 
            // registrar
            // 
            this.registrar.Location = new System.Drawing.Point(664, 57);
            this.registrar.Name = "registrar";
            this.registrar.Size = new System.Drawing.Size(120, 68);
            this.registrar.TabIndex = 12;
            this.registrar.Text = "Registrar";
            this.registrar.UseVisualStyleBackColor = true;
            this.registrar.Click += new System.EventHandler(this.registrar_Click);
            // 
            // calificacion
            // 
            this.calificacion.AutoSize = true;
            this.calificacion.Location = new System.Drawing.Point(475, 28);
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
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1043, 251);
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
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Buscar por DNI";
            // 
            // dni_bus
            // 
            this.dni_bus.Location = new System.Drawing.Point(3, 34);
            this.dni_bus.Name = "dni_bus";
            this.dni_bus.Size = new System.Drawing.Size(115, 22);
            this.dni_bus.TabIndex = 17;
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(124, 34);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(115, 23);
            this.buscar.TabIndex = 18;
            this.buscar.Text = "Consultar nota";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // nota_nueva
            // 
            this.nota_nueva.Location = new System.Drawing.Point(245, 34);
            this.nota_nueva.Name = "nota_nueva";
            this.nota_nueva.Size = new System.Drawing.Size(115, 22);
            this.nota_nueva.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(245, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Nueva nota";
            // 
            // notaN
            // 
            this.notaN.Location = new System.Drawing.Point(366, 34);
            this.notaN.Name = "notaN";
            this.notaN.Size = new System.Drawing.Size(118, 23);
            this.notaN.TabIndex = 21;
            this.notaN.Text = "Actualizar nota";
            this.notaN.UseVisualStyleBackColor = true;
            this.notaN.Click += new System.EventHandler(this.notaN_Click);
            // 
            // suspensos
            // 
            this.suspensos.Location = new System.Drawing.Point(3, 61);
            this.suspensos.Name = "suspensos";
            this.suspensos.Size = new System.Drawing.Size(164, 23);
            this.suspensos.TabIndex = 22;
            this.suspensos.Text = "Suspensos";
            this.suspensos.UseVisualStyleBackColor = true;
            this.suspensos.Click += new System.EventHandler(this.suspensos_Click);
            // 
            // aprobados
            // 
            this.aprobados.Location = new System.Drawing.Point(3, 90);
            this.aprobados.Name = "aprobados";
            this.aprobados.Size = new System.Drawing.Size(164, 23);
            this.aprobados.TabIndex = 23;
            this.aprobados.Text = "Aprobados";
            this.aprobados.UseVisualStyleBackColor = true;
            this.aprobados.Click += new System.EventHandler(this.aprobados_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Candidatos a MH";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 16);
            this.label9.TabIndex = 25;
            this.label9.Text = "Mostrar grupos";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // todos
            // 
            this.todos.Location = new System.Drawing.Point(3, 119);
            this.todos.Name = "todos";
            this.todos.Size = new System.Drawing.Size(164, 23);
            this.todos.TabIndex = 26;
            this.todos.Text = "Todos";
            this.todos.UseVisualStyleBackColor = true;
            this.todos.Click += new System.EventHandler(this.todos_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dni, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.apellido, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.nombre, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.nota, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.calificacion, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(42, 57);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.17647F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.82353F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(590, 68);
            this.tableLayoutPanel1.TabIndex = 27;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.todos, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.suspensos, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.aprobados, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(808, 57);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(171, 146);
            this.tableLayoutPanel2.TabIndex = 28;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.dni_bus, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.buscar, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.notaN, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.nota_nueva, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.label8, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(42, 147);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(487, 63);
            this.tableLayoutPanel3.TabIndex = 29;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(81, 12);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel3);
            this.splitContainer1.Panel1.Controls.Add(this.registrar);
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1043, 509);
            this.splitContainer1.SplitterDistance = 254;
            this.splitContainer1.TabIndex = 30;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 608);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.crudBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crudBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crudBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crudBindingSource3)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button suspensos;
        private System.Windows.Forms.Button aprobados;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button todos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

