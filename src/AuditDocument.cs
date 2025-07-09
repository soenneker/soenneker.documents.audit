using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Soenneker.Enums.CrudEventTypes;

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
    public override string PartitionKey { get; set; } = null!;

    [JsonPropertyName("entity")]
    [JsonProperty("entity")]
    public object? Entity { get; set; }

    [JsonPropertyName("entityId")]
    [JsonProperty("entityId")]
    public string EntityId { get; set; } = null!;

    [JsonPropertyName("entityType")]
    [JsonProperty("entityType")]
    public string EntityType { get; set; } = null!;

    [JsonPropertyName("eventType")]
    [JsonProperty("eventType")]
    public CrudEventType EventType { get; set; } = null!;

    [JsonPropertyName("userId")]
    [JsonProperty("userId")]
    public string? UserId { get; set; }
}