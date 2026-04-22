using Soenneker.Tests.HostedUnit;

namespace Soenneker.Documents.Audit.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class AuditDocumentTests : HostedUnitTest
{
    public AuditDocumentTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
