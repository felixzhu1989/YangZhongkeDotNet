using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEFCoreCongestiveModel
{
    //建议值对象使用record
    public record Geo
    {
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        

        public Geo()//给EF Core使用
        {
        }

        public Geo(double longitude, double latitude)
        {
            if (longitude < -180 || longitude > 180) throw new ArgumentException("longitude invalid");
            if (latitude < -90 || latitude > 90) throw new ArgumentException("latitude invalid");
            Longitude = longitude;
            Latitude = latitude;
        }
    }
}
