using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers; 


namespace ProyectoFletes.Views
{
    public partial class frmMapa : Form
    {
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        DataTable dt;

        int filaSelecionada = 0;
        double latInicial = 12.124561;
        double lonInicial = -86.232371;
        public frmMapa()
        {   
            InitializeComponent();
        }

        private void frmMapa_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt.Columns.Add("Descripcion" , typeof(string ));
            dt.Columns.Add("Lat", typeof(double));
            dt.Columns.Add("Long", typeof(double));

            //Insertando datos al dt para mostrar en la lista 
            dt.Rows.Add("Ubicacion 1" , latInicial,lonInicial);
            dataGridView1.DataSource = dt;
            //desactivamos las columnas de lat y long 
            dataGridView1.Columns[1].Visible = true;
            dataGridView1.Columns[2].Visible = true; 


            dt.Columns.Add();
            dt.Columns.Add();
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(latInicial,lonInicial);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 9;
            gMapControl1.AutoScroll = true;

            // Marcador 

            markerOverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new PointLatLng(latInicial, lonInicial), GMarkerGoogleType.blue);
            markerOverlay.Markers.Add(marker); //Agregamos  al mapa 

            //Agregamos un tooltip de texto a los marcadores 

            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = string.Format("Ubicacion :\n Latitud {0} \n Longitud {1}", latInicial, lonInicial);

            //  Agregamos al mapa y el marcador al map control 

            gMapControl1.Overlays.Add(markerOverlay);


        }

        private void SeleccionarRegistro(object sender, DataGridViewCellMouseEventArgs e)
        {
            filaSelecionada = e.RowIndex;
            // Recuperamos los datos del  grid y se los asignamos al text box
            txtDescripcion.Text = dataGridView1.Rows[filaSelecionada].Cells[0].Value.ToString();
            txtLatitud.Text = dataGridView1.Rows[filaSelecionada].Cells[1].Value.ToString();
            txtLongitud.Text = dataGridView1.Rows[filaSelecionada].Cells[2].Value.ToString();
            // asignamos los valores del grid al marcador 
            marker.Position = new PointLatLng(Convert.ToDouble(txtLatitud.Text), Convert.ToDouble(txtLongitud.Text));
            // se posiciona en el mapa 

            gMapControl1.Position = marker.Position;


        }

        private void gMapControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Obtenemos los datos de lat y lng del mapa donde el usuario presiono

            double lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
            double lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;
            //seteamos

            txtLatitud.Text = lat.ToString();
            txtLongitud.Text = lng.ToString();

            // Creamos el marcador para moverlo al lugar indicado 
            marker.Position = new PointLatLng(lat,lng);
            //Agregamos el tooltip

            marker.ToolTipText = string.Format("Ubicacion : \n Latitud: {0}" +
                " \n Longitud: {1}", lat, lng);


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
