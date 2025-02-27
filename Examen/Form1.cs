﻿using System;
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
            // Verificar si el DNI ya existe
            if (crud.ExisteDNI(dni1))
            {
                MessageBox.Show("El DNI ya está registrado. Por favor, ingrese un DNI diferente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;  // Salir del método si el DNI ya está registrado
            }
            string nombre1 = nombre.Text;
            string apellido1 = apellido.Text;
            float nota1 = float.Parse(nota.Text);

            Calificacion cal = new Calificacion();
            string cali = cal.Equival(nota1);
            calificacion.Text = cali;


            Informacion i = new Informacion(dni1, nombre1, apellido1, nota1, cali);

            crud.agregarObjeto(i);

          //  MessageBox.Show("Registro creado");
          //  crud.ObtenerLista();
           

           // string mensaje = "";
           // foreach (var info in crud.ObtenerLista())
           // {
           //     mensaje += $"Nombre: {info.nombre}\nEdad: {info.dni}\nCédula: {info.apellidos}\nDirección: {info.nombre}\nComentario: {info.nota}\n\n";
            //}

            //MessageBox.Show(mensaje, "Datos guardados");
            ActualizarDataGridView();

        }

        private void ver_Click(object sender, EventArgs e)
        {
            
        }
        private void ActualizarDataGridView()
        {
            dataGridView1.Rows.Clear();  

            if (dataGridView1.Columns["Eliminar"] == null)
            {
                DataGridViewButtonColumn eliminarColumn = new DataGridViewButtonColumn();
                eliminarColumn.Name = "Eliminar";
                eliminarColumn.HeaderText = "Eliminar";
                eliminarColumn.Text = "Eliminar";
                eliminarColumn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(eliminarColumn);
            }

            // Recorrer la lista de registros y agregar cada uno al DataGridView
            foreach (var info in crud.ObtenerLista())
            {
                dataGridView1.Rows.Add(info.dni, info.apellidos, info.nombre, info.nota, info.calificacion);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si el clic fue en la columna "Eliminar"
            if (e.ColumnIndex == dataGridView1.Columns["Eliminar"].Index)
            {
                // Obtener el DNI de la fila seleccionada
                int dniEliminar = (int)dataGridView1.Rows[e.RowIndex].Cells["ced"].Value;

                // Llamar al método de eliminación
                bool eliminado = crud.EliminarPorDNI(dniEliminar);

                if (eliminado)
                {
                    MessageBox.Show("Registro eliminado");
                    ActualizarDataGridView();  // Actualizar el DataGridView después de eliminar
                }
                else
                {
                    MessageBox.Show("DNI no encontrado");
                }
            }
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            try
            {
                int dniBuscar = int.Parse(dni_bus.Text);  // Obtener el DNI de búsqueda

                // Buscar al alumno por el DNI
                var alumno = crud.ObtenerLista().FirstOrDefault(a => a.dni == dniBuscar);

                if (alumno != null)
                {
                    // Si se encuentra el alumno, mostrar la nota y calificación en un MessageBox
                    string mensaje = $"DNI: {alumno.dni}\n" +
                                     $"Nombre: {alumno.nombre} {alumno.apellidos}\n" +
                                     $"Nota: {alumno.nota}\n" +
                                     $"Calificación: {alumno.calificacion}";

                    MessageBox.Show(mensaje, "Información del Alumno");
                }
                else
                {
                    // Si el DNI no se encuentra, mostrar un mensaje de error
                    MessageBox.Show("No se encontró un alumno con el DNI ingresado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un DNI válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void notaN_Click(object sender, EventArgs e)
        {
            try
            {
                int dniBuscar = int.Parse(dni_bus.Text);  // Obtener el DNI de búsqueda
                float nuevaNota = float.Parse(nota_nueva.Text);  // Obtener la nueva nota

                // Buscar al alumno por el DNI
                var alumno = crud.ObtenerLista().FirstOrDefault(a => a.dni == dniBuscar);

                if (alumno != null)
                {
                    // Si se encuentra el alumno, actualizar la nota
                    alumno.nota = nuevaNota;

                    // También actualizamos la calificación si lo deseas
                    Calificacion cal = new Calificacion();
                    alumno.calificacion = cal.Equival(nuevaNota);

                    MessageBox.Show("Nota modificada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarDataGridView();  // Actualizar el DataGridView para reflejar los cambios
                }
                else
                {
                    // Si el DNI no se encuentra, mostrar un mensaje de error
                    MessageBox.Show("No se encontró un alumno con el DNI ingresado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un DNI y una nota válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void suspensos_Click(object sender, EventArgs e)
        {
            var alumnosSuspensos = crud.ObtenerLista()
                                .Where(a => a.calificacion == "SS")
                                .ToList();

            if (alumnosSuspensos.Count > 0)
            {
                // Mostrar los alumnos suspensos en el DataGridView
                dataGridView1.Rows.Clear();  // Limpiar el DataGridView
                foreach (var alumno in alumnosSuspensos)
                {
                    dataGridView1.Rows.Add(alumno.dni, alumno.apellidos, alumno.nombre, alumno.nota, alumno.calificacion);
                }
            }
            else
            {
                MessageBox.Show("No hay alumnos suspensos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void aprobados_Click(object sender, EventArgs e)
        {
            var alumnosApro = crud.ObtenerLista()
                                .Where(a => a.nota >= 7)
                                .ToList();

            if (alumnosApro.Count > 0)
            {
                // Mostrar los alumnos suspensos en el DataGridView
                dataGridView1.Rows.Clear();  // Limpiar el DataGridView
                foreach (var alumno in alumnosApro)
                {
                    dataGridView1.Rows.Add(alumno.dni, alumno.apellidos, alumno.nombre, alumno.nota, alumno.calificacion);
                }
            }
            else
            {
                MessageBox.Show("No hay alumnos Aprobados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var alumnosMH = crud.ObtenerLista()
                               .Where(a => a.nota == 10)
                               .ToList();

            if (alumnosMH.Count > 0)
            {
                // Mostrar los alumnos suspensos en el DataGridView
                dataGridView1.Rows.Clear();  // Limpiar el DataGridView
                foreach (var alumno in alumnosMH)
                {
                    dataGridView1.Rows.Add(alumno.dni, alumno.apellidos, alumno.nombre, alumno.nota, alumno.calificacion);
                }
            }
            else
            {
                MessageBox.Show("No hay alumnos candidatos a MH.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
