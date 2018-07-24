using System.Collections.Generic;
using System.Net;
using System.Windows;
using System.Windows.Input;

using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsPresentation;



namespace GreatMapsTest
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// 
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            GMapProvider.WebProxy = WebRequest.DefaultWebProxy;
            GMapProvider.WebProxy.Credentials = CredentialCache.DefaultCredentials;

            mcMapControl.DragButton = MouseButton.Left;
            mcMapControl.MapProvider = GMapProviders.OpenStreetMap;
            mcMapControl.Manager.Mode = AccessMode.ServerAndCache;
            mcMapControl.MouseWheelZoomType = MouseWheelZoomType.MousePositionAndCenter;
            mcMapControl.ShowCenter = false;
            mcMapControl.MinZoom = 2;
            mcMapControl.MaxZoom = 22;
            mcMapControl.Position = new PointLatLng( 49.761471 , 6.650053 );
            mcMapControl.Zoom = 14;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_CreatePolygon_Click( object sender , RoutedEventArgs e )
        {
            GMapPolygon polygon = new GMapPolygon( new List<PointLatLng>
            {
                new PointLatLng(49,6),
                new PointLatLng(50,6),
                new PointLatLng(50,7),
                new PointLatLng(49,7)
            } );

            mcMapControl.Markers.Add( polygon );
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_CreateRoute_Click( object sender , RoutedEventArgs e )
        {
            GMapRoute route = new GMapRoute( new List<PointLatLng>
            {
                new PointLatLng(49.1,6),
                new PointLatLng(49.5,6.1),
                new PointLatLng(50,6),
                new PointLatLng(47,7)
            } );

            mcMapControl.Markers.Add( route );
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_CreateEllipse_Click( object sender , RoutedEventArgs e )
        {
            GMapEllipse ellipse = new GMapEllipse( new PointLatLng( 49.761471 , 6.650053 ) , 200 );

            mcMapControl.Markers.Add( ellipse );
        }

    } // end public partial class MainWindow 
}
