using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace UnidadeSaudeApi.Models
{
    public class Unidade
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("FID")]
        public string FID { get; set; }

        [BsonElement("codigo")]
        public int Codigo { get; set; }

        [BsonElement("empreendimento")]
        public string Empreendimento { get; set; }

        [BsonElement("subeixo")]
        public string Subeixo { get; set; }

        [BsonElement("tipo")]
        public string Tipo { get; set; }

        [BsonElement("orgao_responsavel")]
        public string Orgao_Responsavel { get; set; }

        [BsonElement("executor")]
        public string Executor { get; set; }

        [BsonElement("unidade_federativa")]
        public string Unidade_Federativa { get; set; }

        [BsonElement("municipio")]
        public string Municipio { get; set; }

        [BsonElement("investimento_previsto")]
        public string Investimento_Previsto { get; set; }

        [BsonElement("observacao")]
        public string Observacao { get; set; }

        [BsonElement("estagio")]
        public string Estagio { get; set; }

        [BsonElement("data_de_referencia")]
        public string Data_de_Referencia { get; set; }

        [BsonElement("geometria")]
        public string Geometria { get; set; }

        [BsonElement("count")]
        public int Count { get; set; }
    }
}
