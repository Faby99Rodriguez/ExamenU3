namespace ExamenU3
{
    public partial class Biblioteca : Form
    {
        public Biblioteca()
        {
            InitializeComponent();
        }

        private void btnAlumno_Click(object sender, EventArgs e)
        {
            FrmAlumnoo frmalumno = new FrmAlumnoo();
            frmalumno.Show();
        }

        private void btnLibro_Click(object sender, EventArgs e)
        {
            FrmLibro frmLibro = new FrmLibro();
            frmLibro.Show();
        }

        private void btnBibliot_Click(object sender, EventArgs e)
        {
            FrmBibliotecario frmBibliotecario = new FrmBibliotecario();
            frmBibliotecario.Show();
        }

        private void btnSalirr_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}