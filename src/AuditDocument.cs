using System.Text.Json.Serialization;
using Ardalis.SmartEnum.SystemTextJson;
using Newtonsoft.Json;
using Soenneker.Enums.EventType;

namespace Soenneker.Documents.Audit;

/// <summary>
/// A derivation of Document that specifically exists for audit purposes <para/>
/// The PartitionKey of the AuditDocument is the Document Id of the target entity
/// </summary>
public class AuditDocument : Document.Document
{
    /// <summary>
    /// Document Id of the target entity
    /// </summary>
    [JsonPropertyName("partitionKey")]
    [JsonProperty("partitionKey")]
    public override string PartitionKey { get; set; } = default!;

    [JsonPropertyName("entity")]
    [JsonProperty("entity")]
    public object? Entity { get; set; }

    [JsonPropertyName("entityId")]
    [JsonProperty("entityId")]
    public string EntityId { get; set; } = default!;

    [JsonPropertyName("entityType")]
    [JsonProperty("entityType")]
    public string EntityType { get; set; } = default!;

    [JsonPropertyName("eventType")]
    [JsonProperty("eventType")]
    [System.Text.Json.Serialization.JsonConverter(typeof(SmartEnumNameConverter<EventType, int>))]
    [Newtonsoft.Json.JsonConverter(typeof(Ardalis.SmartEnum.JsonNet.SmartEnumNameConverter<EventType, int>))]
    public EventType EventType { get; set; } = default!;

    [JsonPropertyName("userId")]
    [JsonProperty("userId")]
    public string? UserId { get; set; }
}