namespace UnidadeSaudeApi.Models
{
    public interface IUnidade_SaudeDatabaseSettings
    {
        string UnidadesCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
