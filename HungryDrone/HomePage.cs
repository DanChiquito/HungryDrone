using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace HungryDrone
{
    public partial class HomePage : Form
    {
        private string nombre;

        GMarkerGoogle marker;
        GMapOverlay markerOverlay;

        FormMenu formMenu;
        ControlLogIn controlwd;


        double latInicial = 19.3316664;
        double lngInicial = -99.1869205;


        public HomePage()
        {
            InitializeComponent();
        }

        private void txtbNombre_TextChanged(object sender, EventArgs e)
        {
            nombre = txtbNombre.Text;
            if(txtbNombre.Text == "Administrador")
            {
                controlwd = new ControlLogIn();
                controlwd.Show();
            }
        }


        private void btnMenu_Click(object sender, EventArgs e)
        {
            try
            {
                errorProv.Clear();
                if (txtbNombre.Text == "")
                {
                    throw new ApplicationException(" Se necesitan llenar todos los campos");
                }
                formMenu = new FormMenu();
                formMenu.Show();

            }
            catch (ApplicationException error)
            {
                if (txtbNombre.Text == "")
                {
                    errorProv.SetError(txtbNombre, error.Message);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(latInicial,lngInicial);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 9;
            gMapControl1.AutoScroll = true;

            markerOverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new PointLatLng(latInicial, lngInicial), GMarkerGoogleType.red);
            markerOverlay.Markers.Add(marker);

            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = string.Format("Ubicación:\nLatitud {0} \nLongitud:{1}",latInicial, lngInicial);

            gMapControl1.Overlays.Add(markerOverlay);
            

        }

    }
}
