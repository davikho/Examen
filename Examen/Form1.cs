using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class Form1 : Form

    {
        private Crud crud = new Crud();
        public Form1()
        {
            InitializeComponent();
        }

        private void dni_TextChanged(object sender, EventArgs e)
        {
           
            
            

        }

        private void registrar_Click(object sender, EventArgs e)
        {
            int dni1 = int.Parse(dni.Text);
            string nombre1 = nombre.Text;
            string apellido1 = apellido.Text;
            float nota1 = float.Parse(nota.Text);

            Calificacion cal = new Calificacion();
            string cali = cal.Equival(nota1);
            calificacion.Text = cali;


            Informacion i = new Informacion(dni1, nombre1, apellido1, nota1);

            crud.agregarObjeto(i);

            MessageBox.Show("Registro creado");
            crud.ObtenerLista();
           

            string mensaje = "";
            foreach (var info in crud.ObtenerLista())
            {
                mensaje += $"Nombre: {info.nombre}\nEdad: {info.dni}\nCédula: {info.apellidos}\nDirección: {info.nombre}\nComentario: {info.nota}\n\n";
            }

            MessageBox.Show(mensaje, "Datos guardados");
            ActualizarDataGridView();

        }

        private void ver_Click(object sender, EventArgs e)
        {
            
        }
        private void ActualizarDataGridView()
        {
            dataGridView1.Rows.Clear();
            foreach (var info in crud.ObtenerLista())
            {
                dataGridView1.Rows.Add(info.dni, info.apellidos, info.nombre, info.nota);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ActualizarDataGridView();
        }

    }
}
