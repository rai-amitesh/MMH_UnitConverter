namespace Conversion.API.Models.Domain
{
    public class UnitMaster
    {
        public int Id { get; set; }
        public string UnitName { get; set; }
        public string UnitType { get; set; }
        public decimal? MetricToImperial { get; set; }
        public decimal? ImperialToMetric { get; set; }

    }
}
