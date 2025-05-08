using NetTopologySuite.Geometries;
using NetTopologySuite.Operation.Distance;
using GeoAPI.Geometries;
using System;
namespace Case3
{
    public class GeodesicDistance
    {
        public static double CalculateDistance(double num)
        {
            var geometryFactory = new NetTopologySuite.Geometries.GeometryFactory();
            double earthRadiusKm = 6371.0;

            double distanceInKm = num * (Math.PI * earthRadiusKm / 180.0);

            return distanceInKm * 1000; // Convert to meters
        }
    }
}