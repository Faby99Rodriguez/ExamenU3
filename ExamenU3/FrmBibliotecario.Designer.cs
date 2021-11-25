namespace ExamenU3
{
    partial class FrmBibliotecario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBibliotecario));
            this.dgvBibliotecar = new System.Windows.Forms.DataGridView();
            this.rbtFemenino = new System.Windows.Forms.RadioButton();
            this.rbtMasculino = new System.Windows.Forms.RadioButton();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txbApellidoMat = new System.Windows.Forms.TextBox();
            this.lblApellidoMat = new System.Windows.Forms.Label();
            this.txbApellidoPat = new System.Windows.Forms.TextBox();
            this.lblApellidoP = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txbRFC = new System.Windows.Forms.TextBox();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txbBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBibliotecar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBibliotecar
            // 
            this.dgvBibliotecar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBibliotecar.Location = new System.Drawing.Point(340, 12);
            this.dgvBibliotecar.Name = "dgvBibliotecar";
            this.dgvBibliotecar.RowTemplate.Height = 25;
            this.dgvBibliotecar.Size = new System.Drawing.Size(597, 510);
            this.dgvBibliotecar.TabIndex = 0;
            this.dgvBibliotecar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBibliotecar_CellContentClick);
            // 
            // rbtFemenino
            // 
            this.rbtFemenino.AutoSize = true;
            this.rbtFemenino.Location = new System.Drawing.Point(211, 247);
            this.rbtFemenino.Name = "rbtFemenino";
            this.rbtFemenino.Size = new System.Drawing.Size(78, 19);
            this.rbtFemenino.TabIndex = 18;
            this.rbtFemenino.TabStop = true;
            this.rbtFemenino.Text = "Femenino";
            this.rbtFemenino.UseVisualStyleBackColor = true;
            // 
            // rbtMasculino
            // 
            this.rbtMasculino.AutoSize = true;
            this.rbtMasculino.Checked = true;
            this.rbtMasculino.Location = new System.Drawing.Point(53, 247);
            this.rbtMasculino.Name = "rbtMasculino";
            this.rbtMasculino.Size = new System.Drawing.Size(80, 19);
            this.rbtMasculino.TabIndex = 17;
            this.rbtMasculino.TabStop = true;
            this.rbtMasculino.Text = "Masculino";
            this.rbtMasculino.UseVisualStyleBackColor = true;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSexo.Location = new System.Drawing.Point(144, 221);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(41, 18);
            this.lblSexo.TabIndex = 16;
            this.lblSexo.Text = "Sexo";
            // 
            // txbApellidoMat
            // 
            this.txbApellidoMat.Location = new System.Drawing.Point(41, 187);
            this.txbApellidoMat.Name = "txbApellidoMat";
            this.txbApellidoMat.Size = new System.Drawing.Size(248, 23);
            this.txbApellidoMat.TabIndex = 15;
            // 
            // lblApellidoMat
            // 
            this.lblApellidoMat.AutoSize = true;
            this.lblApellidoMat.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblApellidoMat.Location = new System.Drawing.Point(95, 165);
            this.lblApellidoMat.Name = "lblApellidoMat";
            this.lblApellidoMat.Size = new System.Drawing.Size(136, 18);
            this.lblApellidoMat.TabIndex = 14;
            this.lblApellidoMat.Text = "Apellido_Materno";
            // 
            // txbApellidoPat
            // 
            this.txbApellidoPat.Location = new System.Drawing.Point(76, 117);
            this.txbApellidoPat.Name = "txbApellidoPat";
            this.txbApellidoPat.Size = new System.Drawing.Size(245, 23);
            this.txbApellidoPat.TabIndex = 13;
            // 
            // lblApellidoP
            // 
            this.lblApellidoP.AutoSize = true;
            this.lblApellidoP.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblApellidoP.Location = new System.Drawing.Point(134, 95);
            this.lblApellidoP.Name = "lblApellidoP";
            this.lblApellidoP.Size = new System.Drawing.Size(132, 18);
            this.lblApellidoP.TabIndex = 12;
            this.lblApellidoP.Text = "Apellido_Paterno";
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(128, 45);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(193, 23);
            this.txbNombre.TabIndex = 11;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(186, 20);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 18);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Nombre";
            // 
            // txbRFC
            // 
            this.txbRFC.Location = new System.Drawing.Point(57, 297);
            this.txbRFC.Name = "txbRFC";
            this.txbRFC.Size = new System.Drawing.Size(222, 23);
            this.txbRFC.TabIndex = 20;
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCarrera.Location = new System.Drawing.Point(145, 274);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(40, 18);
            this.lblCarrera.TabIndex = 19;
            this.lblCarrera.Text = "RFC";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(122, 492);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(109, 23);
            this.btnSalir.TabIndex = 27;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(76, 465);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(202, 23);
            this.btnEliminar.TabIndex = 26;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(57, 436);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(232, 23);
            this.btnModificar.TabIndex = 25;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(57, 407);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(232, 23);
            this.btnRegistrar.TabIndex = 24;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txbBuscar
            // 
            this.txbBuscar.Location = new System.Drawing.Point(28, 353);
            this.txbBuscar.Name = "txbBuscar";
            this.txbBuscar.Size = new System.Drawing.Size(203, 23);
            this.txbBuscar.TabIndex = 23;
            this.txbBuscar.TextChanged += new System.EventHandler(this.txbBuscar_TextChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBuscar.Location = new System.Drawing.Point(28, 332);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(57, 18);
            this.lblBuscar.TabIndex = 22;
            this.lblBuscar.Text = "Buscar";
            // 
            // FrmBibliotecario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(949, 539);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txbBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txbRFC);
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
            this.Controls.Add(this.dgvBibliotecar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBibliotecario";
            this.Text = "FrmBibliotecario";
            this.Load += new System.EventHandler(this.FrmBibliotecario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBibliotecar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvBibliotecar;
        private RadioButton rbtFemenino;
        private RadioButton rbtMasculino;
        private Label lblSexo;
        private TextBox txbApellidoMat;
        private Label lblApellidoMat;
        private TextBox txbApellidoPat;
        private Label lblApellidoP;
        private TextBox txbNombre;
        private Label lblNombre;
        private TextBox txbRFC;
        private Label lblCarrera;
        private PictureBox pictureBox1;
        private Button btnSalir;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnRegistrar;
        private TextBox txbBuscar;
        private Label lblBuscar;
    }
}