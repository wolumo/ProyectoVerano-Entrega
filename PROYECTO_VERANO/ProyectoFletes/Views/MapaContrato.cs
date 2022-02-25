using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFletes.Views
{
    public partial class MapaContrato : Form
    {
        bool TrazarRuta = false;

        string logon; 
        public fmCrearContrato fmcs;
        GMarkerGoogle marker , markerAsist , markerSalida , markerLlegada;
        GMapOverlay markerOverlay, markerOverlayAsist , markerOverSali , markerOverLlega;
        public MapaContrato()
        {
            InitializeComponent();
        }

        public MapaContrato (string logon, fmCrearContrato fmcs)
        {
            InitializeComponent();
            this.logon = logon;
            this.fmcs = fmcs;
            CargarDatosSuc();
        }

        private void btnAgregarLlegada_Click(object sender, EventArgs e)
        {
            if(markerLlegada == null)
            {
                markerLlegada = new GMarkerGoogle(new PointLatLng(0,0) , GMarkerGoogleType.blue);
            }
            markerLlegada.Position = new PointLatLng(markerAsist.Position.Lat, markerAsist.Position.Lng);
            markerOverLlega.Markers.Add(markerLlegada);
            markerLlegada.ToolTipMode = MarkerTooltipMode.Always;
            markerLlegada.ToolTipText = string.Format("Ubicacion Llegada: \n Latitud {0} \n Longitud {1}", markerLlegada.Position.Lat,
                markerLlegada.Position.Lng);


            gMapControl1.Overlays.Add(markerOverLlega);

            txtLatLlegada.Text = Convert.ToString(markerLlegada.Position.Lat);
            txtLonLlegada.Text = Convert.ToString(markerLlegada.Position.Lng);


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRuta_Click(object sender, EventArgs e)
        {
            CrearDireccionTrazarRuta();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            fmcs.txtLugarSalida.Text = txtNombreSali.Text;
            fmcs.txtLatitudS.Text = txtLatSalida.Text;
            fmcs.txtLongitudS.Text = txtLonSalida.Text;
            fmcs.txtNombreLLegada.Text = txtNombreLlegada.Text;
            fmcs.txtLatLLegada.Text = txtLatLlegada.Text;
            fmcs.txtLongLLegada.Text = txtLonLlegada.Text;
            fmcs.txtDistanciaKm.Text = txtDistancia.Text;


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MapaContrato_Load(object sender, EventArgs e)
        {
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new GMap.NET.PointLatLng(double.Parse(txtLatSuc.Text),
                double.Parse(txtLonSuc.Text));
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 9;
            gMapControl1.AutoScroll = true;
            markerOverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new PointLatLng(double.Parse(txtLatSuc.Text), double.Parse(txtLonSuc.Text)), GMarkerGoogleType.green);
            markerOverlay.Markers.Add(marker);

            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = string.Format("Ubicacion Sucursal :\n Latitud {0} \n Longitud {1}", double.Parse(txtLatSuc.Text)
                , double.Parse(txtLonSuc.Text));

            gMapControl1.Overlays.Add(markerOverlay);

            markerOverlayAsist = new GMapOverlay("MarcadorAsist");
            markerAsist = new GMarkerGoogle(new PointLatLng(0, 0), GMarkerGoogleType.red);
            markerOverlayAsist.Markers.Add(markerAsist);

            gMapControl1.Overlays.Add(markerOverlayAsist);
            markerOverSali = new GMapOverlay("MarcadorSalida");
            markerOverLlega = new GMapOverlay("MarcadorLLegada");
        }

        private void btnAgregarSalida_Click(object sender, EventArgs e)
        {
            
            if(markerSalida == null)
            {
            markerSalida = new GMarkerGoogle(new PointLatLng(0,0 ), GMarkerGoogleType.orange);
            }

            markerSalida.Position = new PointLatLng(markerAsist.Position.Lat,markerAsist.Position.Lng);
            markerOverSali.Markers.Add(markerSalida);

            markerSalida.ToolTipMode = MarkerTooltipMode.Always;
            markerSalida.ToolTipText = string.Format("Ubicacion Salida: \n Latitud {0} \n Longitud {1}", markerSalida.Position.Lat,
                markerSalida.Position.Lng);


            gMapControl1.Overlays.Add(markerOverSali);

            txtLatSalida.Text = Convert.ToString(markerSalida.Position.Lat);
            txtLonSalida.Text = Convert.ToString(markerSalida.Position.Lng);



        }

        private void CargarDatosSuc()
        {

           
            string Sucursal = fmcs.cmbSucursales.SelectedValue.ToString();
            txtNombreSucursal.Text = Sucursal;
            SqlConnection connect = new SqlConnection(logon);
            connect.Open();
            string query = "select Latitud from Sucursal where Direccion = '" +
             Sucursal + "'";
            SqlCommand command = new SqlCommand(query, connect);
            string Latitud = Convert.ToString(command.ExecuteScalar());
            txtLatSuc.Text = Latitud;
            string query2 = "select Longitud from Sucursal where Direccion = '" + Sucursal + "'";
            SqlCommand command1 = new SqlCommand(query2, connect);
            string Longitud = Convert.ToString(command1.ExecuteScalar());
            txtLonSuc.Text = Longitud;
        }

        private void gMapControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            double lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
            double lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;

            markerAsist.Position  = new PointLatLng(lat,lng);
            markerAsist.ToolTipText = string.Format("Latitud {0} \n Longitud{1}" ,markerAsist.Position.Lat,markerAsist.Position.Lng);
        }

        public void CrearDireccionTrazarRuta() 
        {

            
            PointLatLng inicio, medio, final;
            inicio = new PointLatLng(marker.Position.Lat, marker.Position.Lng);
            medio = new PointLatLng(markerSalida.Position.Lat, markerSalida.Position.Lng);
            final = new PointLatLng(markerLlegada.Position.Lat, markerLlegada.Position.Lng);

            //GDirections Suc_Salida, Salida_Llegada;
            //var Ruta1 = GMapProviders.GoogleMap.GetDirections(out Suc_Salida,inicio,medio,false,false,
            //    false,false,false);
            //var Ruta2 = GMapProviders.GoogleMap.GetDirections(out Salida_Llegada, medio, final, false, false,
            //    false, false, false);
            //GMapRoute RutaObtenida1 = new GMapRoute(Suc_Salida.Route,"Ruta1");
            //GMapRoute RutaObtenida2 = new GMapRoute(Salida_Llegada.Route, "Ruta2");
            //GMapOverlay Capa1 = new GMapOverlay("Capa1");
            //Capa1.Routes.Add(RutaObtenida1);
            //gMapControl1.Overlays.Add(Capa1);
            //GMapOverlay Capa2 = new GMapOverlay("Capa2");
            //Capa2.Routes.Add(RutaObtenida2);
            //gMapControl1.Overlays.Add(Capa2);
            //gMapControl1.Zoom = gMapControl1.Zoom + 1;
            //gMapControl1.Zoom = gMapControl1.Zoom -1;


            GMapOverlay routes = new GMapOverlay("routes");
            List<PointLatLng> points = new List<PointLatLng>();
            points.Add(inicio);
            points.Add(medio);
            points.Add(final);
            
            GMapRoute route = new GMapRoute(points, "Route Destiny");
            route.Stroke = new Pen(Color.Red, 3);
            routes.Routes.Add(route);
            gMapControl1.Overlays.Add(routes);

            txtDistancia.Text = route.Distance.ToString();

           
        }
    }
}
