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
    public partial class FrmAlumnoo : Form
    {
        public int id=0;

        public FrmAlumnoo()
        {
            InitializeComponent();
        }


        private void FrmAlumnoo_Load(object sender, EventArgs e)
        {
            totAlumnos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminAlumno();
            totAlumnos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificAlumno();
            totAlumnos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregAlumno();
            totAlumnos();
        }

        private void totAlumnos()
        {
            using (var context = new ApplicatiionDbContext())
            {
                var alumno= context.Alumno.ToList();
                dgvAlumno.DataSource = alumno;
            }
        }

        private void AgregAlumno()
        {
            using(var context = new ApplicatiionDbContext())
            {
                var alumno = new Alumno();
                alumno.Nombre = txbNombre.Text;
                alumno.ApellidoPaterno = txbApellidoPat.Text;
                alumno.ApellidoMaterno = txbApellidoMat.Text;
                alumno.sexo = rbtMasculino.Checked ? "Masculino" : "Femenino";
                alumno.Carrera = txbCarrera.Text;


                context.Alumno.Add(alumno);

                context.SaveChanges();
            }
        }

        private void ModificAlumno()
        {
            using (var context = new ApplicatiionDbContext())
            {
                if(id != 0)
                {
                    var alumno = context.Alumno.First(x => x.Id == id);
                    alumno.Nombre=txbNombre.Text;
                    alumno.ApellidoPaterno=txbApellidoPat.Text;
                    alumno.ApellidoMaterno=txbApellidoMat.Text;
                    alumno.sexo = rbtMasculino.Checked ? "Masculino" : "Femenino";
                    alumno.Carrera=txbCarrera.Text;

                    context.SaveChanges();
                }
            }

        }

        private void EliminAlumno()
        {
            using (var context = new ApplicatiionDbContext())
            {
                if (id != 0)
                {
                    var estudiante = context.Alumno.First(x => x.Id == id);

                    if(estudiante != null)
                    {
                        context.Remove(estudiante);
                        context.SaveChanges();
                    }
                }
            }
        }

        private void dgvAlumno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgvAlumno.CurrentRow.Cells[0].Value);
            txbNombre.Text=dgvAlumno.CurrentRow.Cells[1].Value.ToString();
            txbApellidoPat.Text = dgvAlumno.CurrentRow.Cells[2].Value.ToString();
            txbApellidoMat.Text = dgvAlumno.CurrentRow.Cells[3].Value.ToString();

            if(dgvAlumno.CurrentRow.Cells[4].Value.ToString() == "Masculino")
            {
                rbtMasculino.Checked = true;
            }
            else
            {
                rbtFemenino.Checked = true; 
            }

            txbCarrera.Text = dgvAlumno.CurrentRow.Cells[5].Value.ToString();
        }

        private void BuscAlumno()
        {
            using (var context = new ApplicatiionDbContext())
            {
                var alumno = context.Alumno.Where(x => x.Nombre.Contains(txbBuscar.Text)).ToList();
                dgvAlumno.DataSource= alumno;
            }
        }

        private void txbBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscAlumno();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
