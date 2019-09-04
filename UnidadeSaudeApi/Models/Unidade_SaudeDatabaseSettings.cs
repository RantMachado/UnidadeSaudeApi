using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnidadeSaudeApi.Models
{
    public class Unidade_SaudeDatabaseSettings : IUnidade_SaudeDatabaseSettings
    {
        public string UnidadesCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
    public interface IUnidade_SaudeDatabaseSettings
    {
        string UnidadesCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
