using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Microsoft.Data.SqlClient;

namespace SistemaEvaluacionesAcademicas
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            CargarEstudiantes();
            CargarEvaluaciones();
            CargarCombosResultados();
            CargarCombosResultados();
            CargarResultados();

        }
        private void CargarEstudiantes()
        {
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                conexion.Open();

                SqlCommand comando = new SqlCommand("SeleccionarEstudiantes", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();

                adaptador.Fill(tabla);

                dgvEstudiantes.DataSource = tabla;

                if (dgvEstudiantes.Columns.Contains("IdEstudiante"))
                {
                    dgvEstudiantes.Columns["IdEstudiante"].Visible = false;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "" ||
               txtApellido.Text.Trim() == "" ||
               txtCorreo.Text.Trim() == "")
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            try
            {
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                {
                    conexion.Open();

                    SqlCommand comando = new SqlCommand("InsertarEstudiante", conexion);
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@Nombre", txtNombre.Text.Trim());
                    comando.Parameters.AddWithValue("@Apellido", txtApellido.Text.Trim());
                    comando.Parameters.AddWithValue("@Correo", txtCorreo.Text.Trim());

                    comando.ExecuteNonQuery();
                }

                MessageBox.Show("Estudiante guardado correctamente.");

                txtNombre.Clear();
                txtApellido.Clear();
                txtCorreo.Clear();

                CargarEstudiantes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dgvEstudiantes.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un estudiante de la tabla.");
                return;
            }

            int id = Convert.ToInt32(
                dgvEstudiantes.CurrentRow.Cells["IdEstudiante"].Value);

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de eliminar este estudiante?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conexion = Conexion.ObtenerConexion())
                    {
                        conexion.Open();

                        SqlCommand comando = new SqlCommand("EliminarEstudiante", conexion);
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@IdEstudiante", id);

                        comando.ExecuteNonQuery();
                    }

                    MessageBox.Show("Estudiante eliminado correctamente.");
                    CargarEstudiantes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo eliminar: " + ex.Message);
                }
            }
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtCorreo.Clear();

            txtNombre.Focus();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void CargarEvaluaciones()
        {
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                conexion.Open();

                SqlCommand comando = new SqlCommand("SeleccionarEvaluaciones", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();

                adaptador.Fill(tabla);

                dgvEvaluaciones.DataSource = tabla;

                if (dgvEvaluaciones.Columns.Contains("IdEvaluacion"))
                {
                    dgvEvaluaciones.Columns["IdEvaluacion"].Visible = false;
                }
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtEvaluacion.Text.Trim() == "" ||
    txtMateria.Text.Trim() == "")
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            try
            {
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                {
                    conexion.Open();

                    SqlCommand comando = new SqlCommand("InsertarEvaluacion", conexion);
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@NombreEvaluacion", txtEvaluacion.Text.Trim());
                    comando.Parameters.AddWithValue("@Materia", txtMateria.Text.Trim());
                    comando.Parameters.AddWithValue("@Fecha", dtpFecha.Value.Date);

                    comando.ExecuteNonQuery();
                }

                MessageBox.Show("Evaluación guardada correctamente.");

                txtEvaluacion.Clear();
                txtMateria.Clear();

                CargarEvaluaciones();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtEvaluacion.Clear();
            txtMateria.Clear();
            dtpFecha.Value = DateTime.Now;

            txtEvaluacion.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvEvaluaciones.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una evaluación de la tabla.");
                return;
            }

            int id = Convert.ToInt32(
                dgvEvaluaciones.CurrentRow.Cells["IdEvaluacion"].Value);

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de eliminar esta evaluación?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conexion = Conexion.ObtenerConexion())
                    {
                        conexion.Open();

                        SqlCommand comando = new SqlCommand("EliminarEvaluacion", conexion);
                        comando.CommandType = CommandType.StoredProcedure;

                        comando.Parameters.AddWithValue("@IdEvaluacion", id);

                        comando.ExecuteNonQuery();
                    }

                    MessageBox.Show("Evaluación eliminada correctamente.");
                    CargarEvaluaciones();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }
        }
        private void CargarCombosResultados()
        {
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                conexion.Open();

                SqlDataAdapter adaptadorEstudiantes =
                    new SqlDataAdapter("SeleccionarEstudiantes", conexion);

                adaptadorEstudiantes.SelectCommand.CommandType =
                    CommandType.StoredProcedure;

                DataTable estudiantes = new DataTable();
                adaptadorEstudiantes.Fill(estudiantes);

                cmbEstudiante.DataSource = estudiantes;
                cmbEstudiante.DisplayMember = "Nombre";
                cmbEstudiante.ValueMember = "IdEstudiante";

                SqlDataAdapter adaptadorEvaluaciones =
                    new SqlDataAdapter("SeleccionarEvaluaciones", conexion);

                adaptadorEvaluaciones.SelectCommand.CommandType =
                    CommandType.StoredProcedure;

                DataTable evaluaciones = new DataTable();
                adaptadorEvaluaciones.Fill(evaluaciones);

                cmbEvaluacion.DataSource = evaluaciones;
                cmbEvaluacion.DisplayMember = "NombreEvaluacion";
                cmbEvaluacion.ValueMember = "IdEvaluacion";
            }
        }
        private void CargarResultados()
        {
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                conexion.Open();

                SqlCommand comando = new SqlCommand("SeleccionarResultados", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();

                adaptador.Fill(tabla);

                dgvResultado.DataSource = tabla;

                if (dgvResultado.Columns.Contains("IdResultado"))
                {
                    dgvResultado.Columns["IdResultado"].Visible = false;
                }
            }
        }

        private void dgvEstudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarResultado_Click(object sender, EventArgs e)
        {
            if (cmbEstudiante.SelectedValue == null ||
    cmbEvaluacion.SelectedValue == null ||
    txtCalificacion.Text.Trim() == "")
            {
                MessageBox.Show("Seleccione un estudiante, una evaluación e ingrese la calificación.");
                return;
            }

            decimal calificacion;

            if (!decimal.TryParse(txtCalificacion.Text.Trim(), out calificacion) ||
                calificacion < 0 || calificacion > 10)
            {
                MessageBox.Show("Ingrese una calificación válida entre 0 y 10.");
                return;
            }

            try
            {
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                {
                    conexion.Open();

                    SqlCommand comando = new SqlCommand("InsertarResultado", conexion);
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@IdEstudiante",
                        Convert.ToInt32(cmbEstudiante.SelectedValue));

                    comando.Parameters.AddWithValue("@IdEvaluacion",
                        Convert.ToInt32(cmbEvaluacion.SelectedValue));

                    comando.Parameters.AddWithValue("@Calificacion", calificacion);

                    comando.ExecuteNonQuery();
                }

                MessageBox.Show("Resultado guardado correctamente.");

                txtCalificacion.Clear();
                CargarResultados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void btnNuevoResultado_Click(object sender, EventArgs e)
        {
            cmbEstudiante.SelectedIndex = -1;
            cmbEvaluacion.SelectedIndex = -1;
            txtCalificacion.Clear();

            cmbEstudiante.Focus();
        }

        private void btnEliminarResultado_Click(object sender, EventArgs e)
        {
            if (dgvResultado.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un resultado de la tabla.");
                return;
            }

            int idResultado = Convert.ToInt32(
                dgvResultado.CurrentRow.Cells["IdResultado"].Value);

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de eliminar este resultado?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conexion = Conexion.ObtenerConexion())
                    {
                        conexion.Open();

                        SqlCommand comando = new SqlCommand("EliminarResultado", conexion);
                        comando.CommandType = CommandType.StoredProcedure;

                        comando.Parameters.AddWithValue("@IdResultado", idResultado);

                        comando.ExecuteNonQuery();
                    }

                    MessageBox.Show("Resultado eliminado correctamente.");
                    CargarResultados();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }
        }
    }
}
