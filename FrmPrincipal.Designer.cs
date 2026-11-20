namespace SistemaEvaluacionesAcademicas
{
    partial class FrmPrincipal
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtCorreo = new TextBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnEliminar = new Button();
            dgvEstudiantes = new DataGridView();
            btnGuardar = new Button();
            btnNuevo = new Button();
            tabPage2 = new TabPage();
            dgvEvaluaciones = new DataGridView();
            dtpFecha = new DateTimePicker();
            btnDelete = new Button();
            btnSave = new Button();
            btnNew = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtEvaluacion = new TextBox();
            txtMateria = new TextBox();
            tabPage3 = new TabPage();
            dgvResultado = new DataGridView();
            btnEliminarResultado = new Button();
            btnGuardarResultado = new Button();
            btnNuevoResultado = new Button();
            txtCalificacion = new TextBox();
            cmbEvaluacion = new ComboBox();
            cmbEstudiante = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEvaluaciones).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResultado).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(111, 18);
            label1.Name = "label1";
            label1.Size = new Size(708, 53);
            label1.TabIndex = 0;
            label1.Text = "Sistema de Evaluacion Academica";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label2.Location = new Point(13, 21);
            label2.Name = "label2";
            label2.Size = new Size(94, 25);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label3.Location = new Point(15, 80);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 2;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label4.Location = new Point(23, 139);
            label4.Name = "label4";
            label4.Size = new Size(84, 25);
            label4.TabIndex = 3;
            label4.Text = "Correo";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(132, 21);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 4;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(132, 81);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(125, 27);
            txtApellido.TabIndex = 5;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(132, 139);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(125, 27);
            txtCorreo.TabIndex = 6;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 74);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(829, 329);
            tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(100, 116, 139);
            tabPage1.Controls.Add(btnEliminar);
            tabPage1.Controls.Add(dgvEstudiantes);
            tabPage1.Controls.Add(btnGuardar);
            tabPage1.Controls.Add(btnNuevo);
            tabPage1.Controls.Add(txtCorreo);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(txtNombre);
            tabPage1.Controls.Add(txtApellido);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(821, 296);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Estudiantes";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(220, 12, 95);
            btnEliminar.Location = new Point(209, 209);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(84, 29);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // dgvEstudiantes
            // 
            dgvEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstudiantes.Location = new Point(314, 21);
            dgvEstudiantes.Name = "dgvEstudiantes";
            dgvEstudiantes.RowHeadersWidth = 51;
            dgvEstudiantes.Size = new Size(468, 218);
            dgvEstudiantes.TabIndex = 10;
            dgvEstudiantes.CellContentClick += dgvEstudiantes_CellContentClick;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(128, 255, 128);
            btnGuardar.Location = new Point(108, 209);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(71, 29);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.FromArgb(128, 255, 255);
            btnNuevo.Location = new Point(10, 209);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(79, 28);
            btnNuevo.TabIndex = 10;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click_1;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(100, 116, 139);
            tabPage2.Controls.Add(dgvEvaluaciones);
            tabPage2.Controls.Add(dtpFecha);
            tabPage2.Controls.Add(btnDelete);
            tabPage2.Controls.Add(btnSave);
            tabPage2.Controls.Add(btnNew);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(txtEvaluacion);
            tabPage2.Controls.Add(txtMateria);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(821, 296);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Evaluaciones";
            tabPage2.Click += tabPage2_Click;
            // 
            // dgvEvaluaciones
            // 
            dgvEvaluaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEvaluaciones.Location = new Point(317, 19);
            dgvEvaluaciones.Name = "dgvEvaluaciones";
            dgvEvaluaciones.RowHeadersWidth = 51;
            dgvEvaluaciones.Size = new Size(465, 220);
            dgvEvaluaciones.TabIndex = 23;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(162, 148);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(128, 27);
            dtpFecha.TabIndex = 22;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(220, 12, 95);
            btnDelete.Location = new Point(199, 211);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(84, 29);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(128, 255, 128);
            btnSave.Location = new Point(111, 211);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(71, 29);
            btnSave.TabIndex = 20;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.FromArgb(128, 255, 255);
            btnNew.ForeColor = SystemColors.ActiveCaptionText;
            btnNew.Location = new Point(17, 211);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(79, 28);
            btnNew.TabIndex = 19;
            btnNew.Text = "Nuevo";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label5.Location = new Point(-4, 26);
            label5.Name = "label5";
            label5.Size = new Size(160, 23);
            label5.TabIndex = 13;
            label5.Text = "Nombre de la Eva";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label6.Location = new Point(35, 84);
            label6.Name = "label6";
            label6.Size = new Size(78, 23);
            label6.TabIndex = 14;
            label6.Text = "Materia";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label7.Location = new Point(35, 148);
            label7.Name = "label7";
            label7.Size = new Size(60, 23);
            label7.TabIndex = 15;
            label7.Text = "Fecha";
            // 
            // txtEvaluacion
            // 
            txtEvaluacion.Location = new Point(162, 19);
            txtEvaluacion.Name = "txtEvaluacion";
            txtEvaluacion.Size = new Size(125, 27);
            txtEvaluacion.TabIndex = 16;
            // 
            // txtMateria
            // 
            txtMateria.Location = new Point(162, 83);
            txtMateria.Name = "txtMateria";
            txtMateria.Size = new Size(125, 27);
            txtMateria.TabIndex = 17;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(100, 116, 139);
            tabPage3.Controls.Add(dgvResultado);
            tabPage3.Controls.Add(btnEliminarResultado);
            tabPage3.Controls.Add(btnGuardarResultado);
            tabPage3.Controls.Add(btnNuevoResultado);
            tabPage3.Controls.Add(txtCalificacion);
            tabPage3.Controls.Add(cmbEvaluacion);
            tabPage3.Controls.Add(cmbEstudiante);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(label10);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(821, 296);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Resultados";
            tabPage3.Click += tabPage3_Click;
            // 
            // dgvResultado
            // 
            dgvResultado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultado.Location = new Point(317, 19);
            dgvResultado.Name = "dgvResultado";
            dgvResultado.RowHeadersWidth = 51;
            dgvResultado.Size = new Size(452, 220);
            dgvResultado.TabIndex = 25;
            // 
            // btnEliminarResultado
            // 
            btnEliminarResultado.BackColor = Color.FromArgb(220, 12, 95);
            btnEliminarResultado.Location = new Point(208, 210);
            btnEliminarResultado.Name = "btnEliminarResultado";
            btnEliminarResultado.Size = new Size(84, 29);
            btnEliminarResultado.TabIndex = 24;
            btnEliminarResultado.Text = "Eliminar";
            btnEliminarResultado.UseVisualStyleBackColor = false;
            btnEliminarResultado.Click += btnEliminarResultado_Click;
            // 
            // btnGuardarResultado
            // 
            btnGuardarResultado.BackColor = Color.FromArgb(128, 255, 128);
            btnGuardarResultado.Location = new Point(118, 208);
            btnGuardarResultado.Name = "btnGuardarResultado";
            btnGuardarResultado.Size = new Size(71, 29);
            btnGuardarResultado.TabIndex = 23;
            btnGuardarResultado.Text = "Guardar";
            btnGuardarResultado.UseVisualStyleBackColor = false;
            btnGuardarResultado.Click += btnGuardarResultado_Click;
            // 
            // btnNuevoResultado
            // 
            btnNuevoResultado.BackColor = Color.FromArgb(128, 255, 255);
            btnNuevoResultado.Location = new Point(18, 209);
            btnNuevoResultado.Name = "btnNuevoResultado";
            btnNuevoResultado.Size = new Size(79, 28);
            btnNuevoResultado.TabIndex = 22;
            btnNuevoResultado.Text = "Nuevo";
            btnNuevoResultado.UseVisualStyleBackColor = false;
            btnNuevoResultado.Click += btnNuevoResultado_Click;
            // 
            // txtCalificacion
            // 
            txtCalificacion.Location = new Point(143, 142);
            txtCalificacion.Name = "txtCalificacion";
            txtCalificacion.Size = new Size(149, 27);
            txtCalificacion.TabIndex = 9;
            // 
            // cmbEvaluacion
            // 
            cmbEvaluacion.FormattingEnabled = true;
            cmbEvaluacion.Location = new Point(143, 81);
            cmbEvaluacion.Name = "cmbEvaluacion";
            cmbEvaluacion.Size = new Size(151, 28);
            cmbEvaluacion.TabIndex = 8;
            // 
            // cmbEstudiante
            // 
            cmbEstudiante.FormattingEnabled = true;
            cmbEstudiante.Location = new Point(143, 19);
            cmbEstudiante.Name = "cmbEstudiante";
            cmbEstudiante.Size = new Size(151, 28);
            cmbEstudiante.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label8.Location = new Point(13, 19);
            label8.Name = "label8";
            label8.Size = new Size(100, 23);
            label8.TabIndex = 4;
            label8.Text = "Estudiante";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label9.Location = new Point(11, 81);
            label9.Name = "label9";
            label9.Size = new Size(102, 23);
            label9.TabIndex = 5;
            label9.Text = "Evaluacion";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label10.Location = new Point(11, 142);
            label10.Name = "label10";
            label10.Size = new Size(109, 23);
            label10.TabIndex = 6;
            label10.Text = "Calificacion";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 99, 235);
            ClientSize = new Size(919, 419);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Name = "FrmPrincipal";
            Text = "Sistema Educativo";
            Load += FrmPrincipal_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEvaluaciones).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResultado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtCorreo;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnNuevo;
        private Button btnDelete;
        private Button btnSave;
        private Button btnNew;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtEvaluacion;
        private TextBox txtMateria;
        private DateTimePicker dtpFecha;
        private DataGridView dgvEstudiantes;
        private DataGridView dgvEvaluaciones;
        private DataGridView dgvResultado;
        private Button btnEliminarResultado;
        private Button btnGuardarResultado;
        private Button btnNuevoResultado;
        private TextBox txtCalificacion;
        private ComboBox cmbEvaluacion;
        private ComboBox cmbEstudiante;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}