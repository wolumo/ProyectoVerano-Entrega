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
    public partial class AdministrarViajes : Form
    {
        string logon;
        public AdministrarViajes(string logon)
        {
            InitializeComponent();
            this.logon = logon;
            listarViajesEnCurso();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {

        }

        private void AdministrarViajes_Load(object sender, EventArgs e)
        {
            listarViajesEnCurso();
        }
        private void listarViajesEnCurso()
        {
            DViaje dViaje = new DViaje(logon);
            dViaje.ListarViajesEnCurso(dataGridView1);
        }
    }
}
