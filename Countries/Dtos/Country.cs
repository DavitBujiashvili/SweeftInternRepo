namespace Countries.Dtos
{
    public class Country
    {
        public Name Name { get; set; }
        public string Region { get; set; }
        public string Subregion { get; set; }
        public List<double> Latlng { get; set; }
        public double Area { get; set; }
        public int Population { get; set; }
    }
}
