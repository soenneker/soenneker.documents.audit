using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Documents.Audit.Tests;

[Collection("Collection")]
public class AuditDocumentTests : FixturedUnitTest
{
    public AuditDocumentTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
