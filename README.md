[![](https://img.shields.io/nuget/v/Soenneker.Documents.Audit.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Documents.Audit/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.documents.audit/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.documents.audit/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/Soenneker.Documents.Audit.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Documents.Audit/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.documents.audit/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.documents.audit/actions/workflows/codeql.yml)

# Soenneker.Documents.Audit

Defines an audit-event document with entity, event, actor, and document metadata.

## Installation

```bash
dotnet add package Soenneker.Documents.Audit
```

## Usage

```csharp
using Soenneker.Documents.Audit;
using Soenneker.Enums.CrudEventTypes;

string entityId = "customer-42";

var audit = new AuditDocument
{
    DocumentId = Guid.NewGuid().ToString("N"),
    PartitionKey = entityId,
    CreatedAt = DateTimeOffset.UtcNow,
    EntityId = entityId,
    EntityType = "Customer",
    EventType = CrudEventType.Update,
    UserId = currentUserId,
    Entity = new
    {
        Name = "Ada Lovelace",
        Status = "Active"
    }
};
```

`DocumentId` identifies the audit event. `EntityId` identifies the affected entity. Set `PartitionKey` to `EntityId` when using the package’s intended partitioning convention; the class does not assign or validate that relationship automatically.

Inherited document fields serialize as `id`, `partitionKey`, `createdAt`, and `modifiedAt`. Audit fields serialize as `entity`, `entityId`, `entityType`, `eventType`, and `userId` with both System.Text.Json and Newtonsoft.Json attributes.

`Entity` is typed as `object` so callers can store a snapshot or change payload. On deserialization, System.Text.Json normally materializes unknown object values as `JsonElement`, while Newtonsoft.Json normally uses `JObject`. Use a known payload type or serializer-specific conversion when the snapshot must be read back as a concrete model.

`EventType` uses `CrudEventType.Create`, `Read`, `Update`, or `Delete`. The model does not generate IDs, timestamps, or actor information; populate those values before persistence.
