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
    public partial class FrmBibliotecario : Form
    {
        public int id = 0;
        public FrmBibliotecario()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RegistrarBibliotecario();
            TotalBibliotecarios();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarBibliotecario();
            TotalBibliotecarios();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarBibliotecario();
            TotalBibliotecarios();
        }

        private void FrmBibliotecario_Load(object sender, EventArgs e)
        {
            TotalBibliotecarios();
        }

        private void RegistrarBibliotecario()
        {
            using (var context = new ApplicatiionDbContext())
            {
                var bibliotecario = new Bibliotecario();
                bibliotecario.Nombre = txbNombre.Text;
                bibliotecario.ApellidoPaterno = txbApellidoPat.Text;
                bibliotecario.ApellidoMaterno = txbApellidoMat.Text;
                bibliotecario.Sexo = rbtMasculino.Checked ? "Masculino" : "Femenino";
                bibliotecario.Rfc = txbRFC.Text;


                context.Bibliotecario.Add(bibliotecario);

                context.SaveChanges();
            }
        }

        private void ModificarBibliotecario()
        {
            using (var context = new ApplicatiionDbContext())
            {
                if (id != 0)
                {
                    var bibliotecario = context.Bibliotecario.First(x => x.Id == id);
                    bibliotecario.Nombre = txbNombre.Text;
                    bibliotecario.ApellidoPaterno = txbApellidoPat.Text;
                    bibliotecario.ApellidoMaterno = txbApellidoMat.Text;
                    bibliotecario.Sexo = rbtMasculino.Checked ? "Masculino" : "Femenino";
                    bibliotecario.Rfc= txbRFC.Text;

                    context.SaveChanges();
                }
            }

        }


        private void TotalBibliotecarios()
        {
            using (var context = new ApplicatiionDbContext())
            {
                var bibliotecario = context.Bibliotecario.ToList();
                dgvBibliotecar.DataSource = bibliotecario;
            }
        }

        private void EliminarBibliotecario()
        {
            using (var context = new ApplicatiionDbContext())
            {
                if (id != 0)
                {
                    var bibliotecario = context.Bibliotecario.First(x => x.Id == id);

                    if (bibliotecario != null)
                    {
                        context.Remove(bibliotecario);
                        context.SaveChanges();
                    }
                }
            }
        }

        private void dgvBibliotecar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgvBibliotecar.CurrentRow.Cells[0].Value);
            txbNombre.Text = dgvBibliotecar.CurrentRow.Cells[1].Value.ToString();
            txbApellidoPat.Text = dgvBibliotecar.CurrentRow.Cells[2].Value.ToString();
            txbApellidoMat.Text = dgvBibliotecar.CurrentRow.Cells[3].Value.ToString();

            if (dgvBibliotecar.CurrentRow.Cells[4].Value.ToString() == "Masculino")
            {
                rbtMasculino.Checked = true;
            }
            else
            {
                rbtFemenino.Checked = true;
            }

            txbRFC.Text = dgvBibliotecar.CurrentRow.Cells[5].Value.ToString();
        }

        private void txbBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarBibliotecario();
        }

        private void BuscarBibliotecario()
        {
            using (var context = new ApplicatiionDbContext())
            {
                var bibliotecario = context.Bibliotecario.Where(x => x.Nombre.Contains(txbBuscar.Text)).ToList();
                dgvBibliotecar.DataSource = bibliotecario;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
