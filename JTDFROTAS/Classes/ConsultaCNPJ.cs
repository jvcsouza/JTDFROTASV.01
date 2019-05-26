using System;
using Newtonsoft.Json;

namespace JTDFROTAS.Classes
{
    [Serializable]
    public class ConsultaCNPJ
    {
        [JsonProperty(PropertyName = "atividade_principal")]
        public String Atividade { get; set; }

        [JsonProperty(PropertyName = "nome")]
        public String Nome { get; set; }

        [JsonProperty(PropertyName = "uf")]
        public String UF { get; set; }

        [JsonProperty(PropertyName = "fantasia")]
        public String Fantasia { get; set; }

        [JsonProperty(PropertyName = "bairro")]
        public String Bairro { get; set; }

        [JsonProperty(PropertyName = "municipio")]
        public String Cidade { get; set; }

        [JsonProperty(PropertyName = "logradouro")]
        public String Logradouro { get; set; }

        [JsonProperty(PropertyName = "situacao")]
        public String Situacao { get; set; }

        [JsonProperty(PropertyName = "qsa")]
        public String Responsavel { get; set; }
    }
}
