using ShopifySharp.GraphQL;
using ShopifySharp.Services.Graph;
using ShopifySharp.Tests.Integration.Features.Products.Models;

namespace ShopifySharp.Tests.Integration.Features.MetaObjects;

[Collection("MetaObject Queries")]
public class MetaObjectQueryTests(VerifyFixture verifyFixture, GraphServiceFixture graphServiceFixture)
    : IClassFixture<VerifyFixture>, IClassFixture<GraphServiceFixture>
{
    private readonly VerifySettings _verifySettings = verifyFixture.Settings;
    private readonly IGraphService _sut = graphServiceFixture.Service;

    [Fact]
    public async Task ShouldUpsertMetaObject()
    {
        // Setup
        var metaobject = new Metaobject()
        {
            handle = "some-handle",
            fields =
            [
                new MetaobjectField()
                {
                    key = "some-key",
                    value = "some-value",
                }
            ],
        };

        var graphRequest = new GraphRequest
        {
            Query =
                """
                mutation UpsertMetaobject($handle: MetaobjectHandleInput!, $metaobject: MetaobjectUpsertInput!) {
                    result: metaobjectUpsert(handle: $handle, metaobject: $metaobject) {
                        metaobject {
                            id
                            fields {
                                key
                                value
                            }
                        }
                        userErrors {
                            field
                            message
                        }
                    }
                }
                """,
            Variables = new Dictionary<string, object>
            {
                {
                    "handle", new Dictionary<string, object>
                    {
                        {"handle", "some-handle"},
                        {"type", "some-type"}
                    }
                },
                { "metaobject", metaobject}
            },
            UserErrorHandling = GraphRequestUserErrorHandling.DoNotThrow,
        };

        // Act
        var result = await _sut.PostAsync<MutationResponse<MetaobjectUpsertPayload>>(graphRequest);

        // Assert
        await Verify(result.Data, _verifySettings);
    }
}
