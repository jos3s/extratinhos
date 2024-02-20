using System.Text.Json.Serialization;

namespace extratinhos.api.DTOs
{
    public class BalanceRequest
    {
        [JsonPropertyName("saldo")]
        public long Balance { get; set; }
    }
}
