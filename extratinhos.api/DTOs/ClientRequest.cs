using extratinhos.Entitys;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace extratinhos.api.DTOs;

public class ClientRequest
{
    [JsonPropertyName("saldo")]
    public Balance Balance { get; set; }
}
