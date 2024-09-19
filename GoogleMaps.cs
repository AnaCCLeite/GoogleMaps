namespace Mapas;

public class GoogleMaps : IProvedorMapa
{
    public string NomeProvedor { get; set; } = "GoogleMaps";
    public string Mapa(string coordenadas)
    {
        return $"Este é um mapa do Google Maps para " + 
               $"as coordenadas {coordenadas}.";
    }

    public string Rota(string origem, string destino)
    {
        return $"Está a rota entre {origem} e {destino}" + 
               $"as Google Maps.";
    }
}