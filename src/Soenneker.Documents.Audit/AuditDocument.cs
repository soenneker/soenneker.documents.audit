using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Soenneker.Enums.CrudEventTypes;

namespace Soenneker.Documents.Audit;

/// <summary>
/// Represents an auditable change to an entity together with document metadata.
/// </summary>
/// <remarks>Set <see cref="Document.Document.PartitionKey"/> to <see cref="EntityId"/> when audit events should be partitioned by target entity. This convention is not enforced by the model.</remarks>
public class AuditDocument : Document.Document
{
    /// <summary>
    /// Gets or sets the entity snapshot or change payload associated with the event.
    /// </summary>
    [JsonPropertyName("entity")]
    [JsonProperty("entity")]
    public object? Entity { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the affected entity.
    /// </summary>
    [JsonPropertyName("entityId")]
    [JsonProperty("entityId")]
    public string EntityId { get; set; } = null!;

    /// <summary>
    /// Gets or sets the application-defined type name of the affected entity.
    /// </summary>
    [JsonPropertyName("entityType")]
    [JsonProperty("entityType")]
    public string EntityType { get; set; } = null!;

    /// <summary>
    /// Gets or sets the create, read, update, or delete event type.
    /// </summary>
    [JsonPropertyName("eventType")]
    [JsonProperty("eventType")]
    public CrudEventType EventType { get; set; } = null!;

    /// <summary>
    /// Gets or sets the identifier of the user responsible for the event, if known.
    /// </summary>
    [JsonPropertyName("userId")]
    [JsonProperty("userId")]
    public string? UserId { get; set; }
}
