using JetBrains.Annotations;
using Xunit;

namespace ShopifySharp.Tests.Infrastructure.Serializers;

[Trait("Category", "Serializer"), TestSubject(typeof(GraphRequestSerializer))]
public class GraphRequestSerializer
{
    [Fact]
    public void WhenSerializingGraphRequest_ShouldOnlySerializeTheQueryAndVariablesPropertiesAndIgnoreAllOtherProperties()
    {

    }

    [Fact]
    public void WhenSerializingGraphRequest_ShouldSerializeQueryAndVariablesPropertiesToCamelCase()
    {

    }

    [Fact]
    public void WhenSerializingGraphRequest_AndItIncludesEstimatedErrorCost_ShouldNotSerializeEstimatedErrorCostToJson()
    {

    }
}
