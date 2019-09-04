using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace UnidadeSaudeApi.Models
{
    public class Unidade
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Empreendimento")]
        public string Empreendimento { get; set; }

        [BsonElement("Subeixo")]
        public string Subeixo { get; set; }

        [BsonElement("Orgao_Responsavel")]
        public string Orgao_Responsavel { get; set; }

        [BsonElement("Executor")]
        public string Executor { get; set; }

        [BsonElement("Unidade_Federativa")]
        public string Unidade_Federativa { get; set; }

        [BsonElement("Municipio")]
        public string Municipio { get; set; }

        [BsonElement("Estagio")]
        public string Estagio { get; set; }
    }
}
