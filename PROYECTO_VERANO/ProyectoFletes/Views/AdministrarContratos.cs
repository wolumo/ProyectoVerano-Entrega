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
    public partial class AdministrarContratos : Form
    {
       public string logon;
        public AdministrarContratos(string logon)
        {
            InitializeComponent();
            this.logon = logon;
            ListarConSinCancelar();
        }

      

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListarConSinCancelar()
        {
            DContrato dContrato = new DContrato(logon);
            dContrato.ListarConSinCancelar(dataGridView1);

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
            Console.WriteLine(comboBox1.SelectedIndex);
            if (comboBox1.SelectedIndex == 0)
            {
               
                ListarConSinCancelar();

            }
            if (comboBox1.SelectedIndex ==1)
            {
                ListarConCancelado();
            }
        }
        private void ListarConCancelado()
        {
            DContrato dContrato = new DContrato(logon);
            dContrato.ListarConCancelado(dataGridView1);

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            int idContrato = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            DContrato dContrato = new DContrato(logon);
            dContrato.CambiarEstadoCancelado(idContrato);

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            fmCrearContrato contrato = new fmCrearContrato(logon);
            contrato.btnActualizar.Visible = true;
            contrato.btnCrear.Visible = false;
            contrato.label2.Visible = true;
            contrato.txtIdContrato.Visible = true;
            contrato.txtIdContrato.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            contrato.txtRuc.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            contrato.txtLugarSalida.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            contrato.txtNombreLLegada.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            contrato.txtPeso.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString(); 


        }
    }
}
