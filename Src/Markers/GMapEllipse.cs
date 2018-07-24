using GMap.NET;
using GMap.NET.WindowsPresentation;



namespace GreatMapsTest
{
    /// <summary>
    /// 
    /// </summary>
    public class GMapEllipse : GMapMarker, IShapable
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pllCenter"></param>
        /// <param name="ulRadiusInMeters"></param>
        public GMapEllipse( PointLatLng pllCenter , ulong ulRadiusInMeters ) : base( pllCenter )
        {
            RegenerateShape( null );
        }


        /// <summary>
        /// 
        /// </summary>
        public override void Clear()
        {
            base.Clear();
        }


        /// <summary>
        /// regenerates shape of polygon
        /// </summary>
        public virtual void RegenerateShape( GMapControl map )
        {
            if( map != null )
            {
                //this.Map = map;

                //if( Points.Count > 1 )
                //{
                //    Position = Points [0];

                //    var localPath = new List<System.Windows.Point>( Points.Count );
                //    var offset = Map.FromLatLngToLocal( Points [0] );
                //    foreach( var i in Points )
                //    {
                //        var p = Map.FromLatLngToLocal( i );
                //        localPath.Add( new System.Windows.Point( p.X - offset.X , p.Y - offset.Y ) );
                //    }

                //    var shape = map.CreatePolygonPath( localPath );

                //    if( this.Shape is Path )
                //    {
                //        ( this.Shape as Path ).Data = shape.Data;
                //    }
                //    else
                //    {
                //        this.Shape = shape;
                //    }
                //}
                //else
                //{
                //    this.Shape = null;
                //}
            }
        }

    } // end public class GMapEllipse
}
