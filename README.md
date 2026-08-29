[![](https://img.shields.io/nuget/v/Soenneker.Documents.Audit.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Documents.Audit/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.documents.audit/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.documents.audit/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/Soenneker.Documents.Audit.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Documents.Audit/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.documents.audit/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.documents.audit/actions/workflows/codeql.yml)

# Soenneker.Documents.Audit

A derivation of Document that specifically exists for audit purposes The PartitionKey of the AuditDocument is the Document Id of the target entity.

## Install

```bash
dotnet add package Soenneker.Documents.Audit
```

## What you get

- `AuditDocument` — A derivation of Document that specifically exists for audit purposes The PartitionKey of the AuditDocument is the Document Id of the target entity.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `AuditDocument.Entity` | Gets or sets entity. | Gets or sets entity. |
| `AuditDocument.EntityId` | Gets or sets entity id. | Gets or sets entity id. |
| `AuditDocument.EntityType` | Gets or sets entity type. | Gets or sets entity type. |
| `AuditDocument.EventType` | Gets or sets event type. | Gets or sets event type. |
| `AuditDocument.UserId` | Gets or sets user id. | Gets or sets user id. |

## Important behavior

- `AuditDocument`: >PartitionKey is the document Id of the target entity.
