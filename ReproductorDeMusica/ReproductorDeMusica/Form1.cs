using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReproductorDeMusica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            personalizarDiseño();
        }

        private void personalizarDiseño() {
            panelMedios.Visible = false;
            panelListaReproduccion.Visible = false;
            panelEcualizador.Visible = false;
        }

        private void ocultarSubMenu() {

            if (panelMedios.Visible == true) {
                panelMedios.Visible = false;
            }
            if (panelListaReproduccion.Visible == true) {
                panelListaReproduccion.Visible = false;
            }
            if (panelEcualizador.Visible == true) {
                panelEcualizador.Visible = false;
            }
        }

        public void mostrarSubMenu(Panel algunSubMenu) {
            if (algunSubMenu.Visible == false) {
                ocultarSubMenu();
                algunSubMenu.Visible = true;
            }
            else {
                algunSubMenu.Visible = false;
            }
        }
        // BOTON DE MEDIOS 
        private void btnMedios_Click(object sender, EventArgs e) {
            mostrarSubMenu(panelMedios);
        }
        //BOTONES DE MEDIOS
        private void button2_Click(object sender, EventArgs e) {
            abrirChildForm(new Form3());
            ocultarSubMenu();
        }

        private void button3_Click(object sender, EventArgs e) {
            ocultarSubMenu();
        }

        private void button4_Click(object sender, EventArgs e) {
            ocultarSubMenu();
        }

        private void button5_Click(object sender, EventArgs e) {
            ocultarSubMenu();
        }
        //BOTON DE LISTA DE REPRODUCION 
        private void btnListaReproduccion_Click(object sender, EventArgs e) {
            mostrarSubMenu(panelListaReproduccion);
        }
        //BOTONES DE LISTA DE REPRODUCCION
        private void button9_Click(object sender, EventArgs e) {
            abrirChildForm(new Form2());
            ocultarSubMenu();
        }

        private void button8_Click(object sender, EventArgs e) {
            ocultarSubMenu();
        }

        private void button7_Click(object sender, EventArgs e) {
            ocultarSubMenu();
        }

        private void button6_Click(object sender, EventArgs e) {
            ocultarSubMenu();
        }
        //BOTON HERRAMIENTAS
        private void btnEcualizador_Click(object sender, EventArgs e) {
            mostrarSubMenu(panelEcualizador);
        }
        //BOTONES DE HERRAMIENTAS
        private void button14_Click(object sender, EventArgs e) {
            ocultarSubMenu();
        }

        private void button13_Click(object sender, EventArgs e) {
            ocultarSubMenu();
        }

        private void button12_Click(object sender, EventArgs e) {
            ocultarSubMenu();
        }

        //VARIABLE FORMULARIO ACTIVO
        private Form formularioActivo = null;
        //METODO PARA ABRIR LOS PANELES
        private void abrirChildForm(Form childForm) {
            if (formularioActivo != null) {
                formularioActivo.Close();
            }
            formularioActivo = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();  
        }
        //BOTON PARA SALIR DE LA APLICACION
        private void button10_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
