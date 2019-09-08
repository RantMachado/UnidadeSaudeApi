using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace UnidadeSaudeApi.Models
{
    public class Unidade
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("FID")]
        [JsonProperty("FID")]
        public string FID { get; set; }

        [BsonElement("codigo")]
        [JsonProperty("codigo")]
        public int Codigo { get; set; }

        [BsonElement("empreendimento")]
        [JsonProperty("empreendimento")]
        public string Empreendimento { get; set; }

        [BsonElement("subeixo")]
        [JsonProperty("subeixo")]
        public string Subeixo { get; set; }

        [BsonElement("tipo")]
        [JsonProperty("tipo")]
        public string Tipo { get; set; }

        [BsonElement("orgao_responsavel")]
        [JsonProperty("orgao_responsavel")]
        public string Orgao_Responsavel { get; set; }

        [BsonElement("executor")]
        [JsonProperty("executor")]
        public string Executor { get; set; }

        [BsonElement("unidade_federativa")]
        [JsonProperty("unidade_federativa")]
        public string Unidade_Federativa { get; set; }

        [BsonElement("municipio")]
        [JsonProperty("municipio")]
        public string Municipio { get; set; }

        [BsonElement("investimento_previsto")]
        [JsonProperty("investimento_previsto")]
        public string Investimento_Previsto { get; set; }

        [BsonElement("observacao")]
        [JsonProperty("observacao")]
        public string Observacao { get; set; }

        [BsonElement("estagio")]
        [JsonProperty("estagio")]
        public string Estagio { get; set; }

        [BsonElement("data_de_referencia")]
        [JsonProperty("data_de_referencia")]
        public string Data_de_Referencia { get; set; }

        [BsonElement("geometria")]
        [JsonProperty("geometria")]
        public string Geometria { get; set; }

        [BsonElement("count")]
        [JsonProperty("count")]
        public int Count { get; set; }
    }
}
