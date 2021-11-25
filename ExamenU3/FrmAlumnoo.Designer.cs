namespace ExamenU3
{
    partial class FrmAlumnoo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlumnoo));
            this.dgvAlumno = new System.Windows.Forms.DataGridView();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbApellidoPat = new System.Windows.Forms.TextBox();
            this.lblApellidoP = new System.Windows.Forms.Label();
            this.txbApellidoMat = new System.Windows.Forms.TextBox();
            this.lblApellidoMat = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.rbtMasculino = new System.Windows.Forms.RadioButton();
            this.rbtFemenino = new System.Windows.Forms.RadioButton();
            this.txbCarrera = new System.Windows.Forms.TextBox();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.txbBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlumno
            // 
            this.dgvAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumno.Location = new System.Drawing.Point(12, 12);
            this.dgvAlumno.Name = "dgvAlumno";
            this.dgvAlumno.RowTemplate.Height = 25;
            this.dgvAlumno.Size = new System.Drawing.Size(656, 532);
            this.dgvAlumno.TabIndex = 0;
            this.dgvAlumno.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlumno_CellContentClick);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(768, 12);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 18);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(719, 35);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(166, 23);
            this.txbNombre.TabIndex = 2;
            // 
            // txbApellidoPat
            // 
            this.txbApellidoPat.Location = new System.Drawing.Point(704, 86);
            this.txbApellidoPat.Name = "txbApellidoPat";
            this.txbApellidoPat.Size = new System.Drawing.Size(203, 23);
            this.txbApellidoPat.TabIndex = 4;
            // 
            // lblApellidoP
            // 
            this.lblApellidoP.AutoSize = true;
            this.lblApellidoP.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblApellidoP.Location = new System.Drawing.Point(737, 64);
            this.lblApellidoP.Name = "lblApellidoP";
            this.lblApellidoP.Size = new System.Drawing.Size(132, 18);
            this.lblApellidoP.TabIndex = 3;
            this.lblApellidoP.Text = "Apellido_Paterno";
            // 
            // txbApellidoMat
            // 
            this.txbApellidoMat.Location = new System.Drawing.Point(704, 138);
            this.txbApellidoMat.Name = "txbApellidoMat";
            this.txbApellidoMat.Size = new System.Drawing.Size(203, 23);
            this.txbApellidoMat.TabIndex = 6;
            // 
            // lblApellidoMat
            // 
            this.lblApellidoMat.AutoSize = true;
            this.lblApellidoMat.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblApellidoMat.Location = new System.Drawing.Point(737, 116);
            this.lblApellidoMat.Name = "lblApellidoMat";
            this.lblApellidoMat.Size = new System.Drawing.Size(136, 18);
            this.lblApellidoMat.TabIndex = 5;
            this.lblApellidoMat.Text = "Apellido_Materno";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSexo.Location = new System.Drawing.Point(781, 170);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(41, 18);
            this.lblSexo.TabIndex = 7;
            this.lblSexo.Text = "Sexo";
            // 
            // rbtMasculino
            // 
            this.rbtMasculino.AutoSize = true;
            this.rbtMasculino.Checked = true;
            this.rbtMasculino.Location = new System.Drawing.Point(703, 196);
            this.rbtMasculino.Name = "rbtMasculino";
            this.rbtMasculino.Size = new System.Drawing.Size(80, 19);
            this.rbtMasculino.TabIndex = 8;
            this.rbtMasculino.TabStop = true;
            this.rbtMasculino.Text = "Masculino";
            this.rbtMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtFemenino
            // 
            this.rbtFemenino.AutoSize = true;
            this.rbtFemenino.Location = new System.Drawing.Point(828, 196);
            this.rbtFemenino.Name = "rbtFemenino";
            this.rbtFemenino.Size = new System.Drawing.Size(78, 19);
            this.rbtFemenino.TabIndex = 9;
            this.rbtFemenino.TabStop = true;
            this.rbtFemenino.Text = "Femenino";
            this.rbtFemenino.UseVisualStyleBackColor = true;
            // 
            // txbCarrera
            // 
            this.txbCarrera.Location = new System.Drawing.Point(703, 249);
            this.txbCarrera.Name = "txbCarrera";
            this.txbCarrera.Size = new System.Drawing.Size(203, 23);
            this.txbCarrera.TabIndex = 11;
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCarrera.Location = new System.Drawing.Point(772, 225);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(64, 18);
            this.lblCarrera.TabIndex = 10;
            this.lblCarrera.Text = "Carrera";
            // 
            // txbBuscar
            // 
            this.txbBuscar.Location = new System.Drawing.Point(704, 370);
            this.txbBuscar.Name = "txbBuscar";
            this.txbBuscar.Size = new System.Drawing.Size(203, 23);
            this.txbBuscar.TabIndex = 13;
            this.txbBuscar.TextChanged += new System.EventHandler(this.txbBuscar_TextChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBuscar.Location = new System.Drawing.Point(704, 349);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(57, 18);
            this.lblBuscar.TabIndex = 12;
            this.lblBuscar.Text = "Buscar";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(704, 401);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(202, 23);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(703, 430);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(204, 23);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(704, 459);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(202, 23);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(750, 486);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(109, 23);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(738, 281);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // FrmAlumnoo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(939, 556);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txbBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txbCarrera);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.rbtFemenino);
            this.Controls.Add(this.rbtMasculino);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.txbApellidoMat);
            this.Controls.Add(this.lblApellidoMat);
            this.Controls.Add(this.txbApellidoPat);
            this.Controls.Add(this.lblApellidoP);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.dgvAlumno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAlumnoo";
            this.Text = "FrmAlumnoo";
            this.Load += new System.EventHandler(this.FrmAlumnoo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvAlumno;
        private Label lblNombre;
        private TextBox txbNombre;
        private TextBox txbApellidoPat;
        private Label lblApellidoP;
        private TextBox txbApellidoMat;
        private Label lblApellidoMat;
        private Label lblSexo;
        private RadioButton rbtMasculino;
        private RadioButton rbtFemenino;
        private TextBox txbCarrera;
        private Label lblCarrera;
        private TextBox txbBuscar;
        private Label lblBuscar;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnSalir;
        private PictureBox pictureBox1;
    }
}