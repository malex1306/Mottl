namespace Pizza;

interface IPizza
{
    List<string> GetZutaten();
    decimal GetPreis();
    string GetBeschreibung();
}