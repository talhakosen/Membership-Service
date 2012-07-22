using System.Runtime.Serialization;

namespace Membership.Contract
{
    [DataContract]
    public class CityDto : BaseDto
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public GeoZoneDto GeoZone { get; set; }
    }
}