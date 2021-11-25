using ExamenU3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenU3
{
    public partial class FrmLibro : Form
    {
        public int id = 0;

        public FrmLibro()
        {
            InitializeComponent();
        }

        private void dgvLibro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgvLibro.CurrentRow.Cells[0].Value);
            txbTitulo.Text = dgvLibro.CurrentRow.Cells[1].Value.ToString();
            txbCategoria.Text = dgvLibro.CurrentRow.Cells[2].Value.ToString();
            txbEdicion.Text = dgvLibro.CurrentRow.Cells[3].Value.ToString();
            txbFolio.Text = dgvLibro.CurrentRow.Cells[4].Value.ToString();
            txbSeccion.Text=dgvLibro.CurrentRow.Cells[5].Value.ToString();

        }

        private void FrmLibro_Load(object sender, EventArgs e)
        {
            TotaLibros();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            AgregarLibro();
            TotaLibros();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarLibro();
            TotaLibros();
        }

        private void AgregarLibro()
        {
            using (var context =  new ApplicatiionDbContext())
            {
                var libroo= new Libro();

                libroo.Titulo = txbTitulo.Text;
                libroo.Categoria = txbCategoria.Text;
                libroo.Edicion = txbEdicion.Text;
                libroo.Folio = txbFolio.Text;
                libroo.Seccion = txbSeccion.Text;

                context.Libro.Add(libroo);

                context.SaveChanges();
            }
        }

        private void TotaLibros()
        {
            using (var context = new ApplicatiionDbContext())
            {
                var libroo = context.Libro.ToList();
                dgvLibro.DataSource= libroo;

            }
        }

        private void EliminarLibro()
        {
            using(var context = new ApplicatiionDbContext())
            {
                if(id != 0)
                {
                    var libroo = context.Libro.First(x => x.Id == id);

                    if(libroo != null)
                    {
                        context.Remove(libroo);
                        context.SaveChanges();
                    }
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
