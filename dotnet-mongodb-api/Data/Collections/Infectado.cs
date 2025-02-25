using MongoDB.Driver.GeoJsonObjectModel;

namespace dotnet_mongodb_api.Data.Collections
{
    public class Infectado(DateTime dataNascimento, string sexo, double latitude, double longitude)
    {
        public DateTime DataNascimento { get; set; } = dataNascimento;
        public string Sexo { get; set; } = sexo;
        public double Latitude { get; set; } = latitude;
        public double Longitude { get; set; } = longitude;
        public GeoJson2DGeographicCoordinates Localizacao { get; set; } = new GeoJson2DGeographicCoordinates(longitude, latitude);
    }
}
