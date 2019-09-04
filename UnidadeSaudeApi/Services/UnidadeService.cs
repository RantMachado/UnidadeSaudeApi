using System.Collections.Generic;
using System.Linq;
using MongoDB.Driver;
using UnidadeSaudeApi.Models;

namespace UnidadeSaudeApi.Services
{
    public class UnidadeService
    {
        private readonly IMongoCollection<Unidade> _unidade;

        public UnidadeService(IUnidade_SaudeDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _unidade = database.GetCollection<Unidade>(settings.UnidadesCollectionName);
        }

        public List<Unidade> Get() =>
            _unidade.Find(unidade => true).ToList();

        public Unidade Get(string id) =>
            _unidade.Find<Unidade>(unidade => unidade.Id == id).FirstOrDefault();

        public Unidade Create(Unidade unidade)
        {
            _unidade.InsertOne(unidade);
            return unidade;
        }

        public void Update(string id, Unidade unidadeIn) =>
            _unidade.ReplaceOne(unidade => unidade.Id == id, unidadeIn);

        public void Remove(Unidade unidadeIn) =>
            _unidade.DeleteOne(unidade => unidade.Id == unidadeIn.Id);

        public void Remove(string id) =>
            _unidade.DeleteOne(book => book.Id == id);
    }
}
