using System;
using SWMSoftMockUp3.DataTypes;

namespace SWMSoftMockUp3.Models
{
    public class Asset
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string type { get; set; }
        public string MunicipalId { get; set; }
        public string Comments { get; set; }
        public string LocationDescription { get; set; }
        public string NearestIntersection { get; set; }
        public string Address { get; set; }
        public ProgressStatus.Status Status { get; set; }
        public int YearBuilt { get; set; }
        public int Easting { get; set; }
        public int Northing { get; set; }
        public int Magnification { get; set; }
        public string AdjacentLandUse { get; set; }

    }
}
