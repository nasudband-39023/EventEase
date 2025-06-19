namespace EventEaseProject.Models
{
    public class WeatherModel
    {
        public Main? main { get; set; }  // <- acept null
        public List<Weather>? weather { get; set; }  // <- acept null
        public string? name { get; set; }  // <- acept null
    }

    public class Main
    {
        public double temp { get; set; }
        public int humidity { get; set; }
    }

    public class Weather
    {
        public string? description { get; set; }  // <- acept null
        public string? icon { get; set; }  // <- acept null
    }
}