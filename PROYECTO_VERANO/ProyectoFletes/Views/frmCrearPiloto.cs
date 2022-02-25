using ProyectoFletes.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFletes.Views
{
    public partial class frmCrearPiloto : Form
    {
        Conexion con;
        DataPiloto dp;
        public frmCrearPiloto()
        {
            InitializeComponent();
        }
        public frmCrearPiloto(Conexion con)
        {
            InitializeComponent();
            this.con = con;
            this.dp = new DataPiloto(con);
        }

        private void frmCrearPiloto_Load(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (txtDNI.Text == "")
            {
                MessageBox.Show("Digite la cedula del piloto");
            }
            if (txtPrimerN.Text == "")
            {
                MessageBox.Show("Digite el capo obligatorio de primer nombre");
            }
            if (txtSegundoNomb.Text == "")
            {
                MessageBox.Show("Digite el capo obligatorio de segundo nombre");
            }
            if (txtPrimerApel.Text == "")
            {
                MessageBox.Show("Digite el capo obligatorio de primer Apellido");
            }
            if (txtSegundoApelli.Text == "")
            {
                MessageBox.Show("Digite el capo obligatorio de segundo Apellido");
            }
            if (txtLicencia.Text == "")
            {
                MessageBox.Show("Digite el capo obligatorio de licencia");
            }
            else
            {
                DateTime fechaAntiguedad = txtAnt.Value;
                dp.agregar_Piloto(txtDNI.Text, txtPrimerN.Text, txtSegundoNomb.Text, txtPrimerApel.Text, txtSegundoApelli.Text, fechaAntiguedad.ToString(), txtLicencia.Text);
            }
        }
    }
}
