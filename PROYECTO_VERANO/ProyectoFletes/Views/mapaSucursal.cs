using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
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
    public partial class mapaSucursal : Form
    {
        public frmCrearSucursal cs;
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        public mapaSucursal()
        {
            InitializeComponent();
        }
        public double getLatitud()
        {
            double LatitudInicial = 0;
            string Depart = cs.cmbDepartamento.SelectedValue.ToString();
            if (Depart == "Managua")
            {
                LatitudInicial = 12.121403;
            }
            if (Depart == "Masaya")
            {
                LatitudInicial = 11.973164;
            }
            if (Depart == "Carazo")
            {
                LatitudInicial = 11.763687;
            }
            if (Depart == "Granada")
            {
                LatitudInicial = 11.927757;
            }
            if (Depart == "Rivas")
            {
                LatitudInicial = 11.437964;
            }
            if (Depart == "Leon")
            {
                LatitudInicial = 12.436751;
            }
            if (Depart == "Chinandega")
            {
                LatitudInicial = 12.625701;
            }
            if (Depart == "Esteli")
            {
                LatitudInicial = 13.090768;
            }
            if (Depart == "Madriz")
            {
                LatitudInicial = 13.456111;
            }
            if (Depart == "Nueva Segovia")
            {
                LatitudInicial = 13.634025;
            }
            if (Depart == "Jinotega")
            {
                LatitudInicial = 13.090255;
            }
            if (Depart == "Matagalpa")
            {
                LatitudInicial = 12.919844;
            }
            if (Depart == "Chontales")
            {
                LatitudInicial = 12.069373;
            }
            return LatitudInicial;
        }

        public double getLongitud()
        {
            double LongitudInicial = 0;
            string Depart = cs.cmbDepartamento.SelectedValue.ToString();
            if (Depart == "Managua")
            {
                LongitudInicial = -86.252799;
            }
            if (Depart == "Masaya")
            {
                LongitudInicial = -86.092543;
            }
            if (Depart == "Carazo")
            {
                LongitudInicial = -86.195959;
            }
            if (Depart == "Granada")
            {
                LongitudInicial = -85.959478;
            }
            if (Depart == "Rivas")
            {
                LongitudInicial = -85.826830
;
            }
            if (Depart == "Leon")
            {
                LongitudInicial = -86.879548;
            }
            if (Depart == "Chinandega")
            {
                LongitudInicial = -87.129092;
            }
            if (Depart == "Esteli")
            {
                LongitudInicial = -86.355714;
            }
            if (Depart == "Madriz")
            {
                LongitudInicial = -86.405018;
            }
            if (Depart == "Nueva Segovia")
            {
                LongitudInicial = -86.135435;
            }
            if (Depart == "Jinotega")
            {
                LongitudInicial = -86.000998;
            }
            if (Depart == "Matagalpa")
            {
                LongitudInicial = -85.916007;
            }
            if (Depart == "Chontales")
            {
                LongitudInicial = -85.092690;
            }
            return LongitudInicial;
        }

        private void mapaSucursal_Load(object sender, EventArgs e)
        {
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(getLatitud(), getLongitud());
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 9;
            gMapControl1.AutoScroll = true;
            markerOverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new PointLatLng(getLatitud(), getLongitud()), GMarkerGoogleType.blue);
            markerOverlay.Markers.Add(marker);

            //Agregamos un tooltip de texto a los marcadores 

            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = string.Format("Ubicacion :\n Latitud {0} \n Longitud {1}", getLatitud(), getLongitud());

            //  Agregamos al mapa y el marcador al map control 

            gMapControl1.Overlays.Add(markerOverlay);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string lat, lon, NombreDireccion;
            if (txtNombreDireccion.Text == "")
            {
                MessageBox.Show("El nombre no puede estar vacio.");

            }
            else
            {
                lat = txtLatitud.Text;
                lon = txtLongitud.Text;
                NombreDireccion = txtNombreDireccion.Text;
                cs.txtLatitud.Text = lat;
                cs.txtLongitud.Text = lon;
                cs.txtNombre.Text = NombreDireccion;

                this.Close();
            }

        }

        private void gMapControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            double lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
            double lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;

            txtLatitud.Text = Convert.ToString(lat);
            txtLongitud.Text = Convert.ToString(lng);

            marker.Position = new PointLatLng(lat, lng);

            marker.ToolTipText = string.Format("Ubicacion : \n Latitud : {0}" + "\n Longitud : " +
                "{1}", lat, lng);
        }
    }
}
