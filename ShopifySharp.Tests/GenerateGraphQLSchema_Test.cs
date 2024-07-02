#if NET8_0_OR_GREATER
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Wish.GraphQLSchemaGenerator;
using Xunit;

namespace ShopifySharp.Tests;

[Trait("Category", "GraphQL")]
public class GenerateGraphQLSchema_Test
{
    [Fact(Skip = "This test should be run manually to re-generate the GraphQL types whenever the API version is upgraded")]
    public async Task GenerateGraphQLTypes()
    {
        var scalarNameToTypeName = new Dictionary<string, string>
        {
            { "UnsignedInt64", "ulong" },
            { "Money", "decimal" },
            { "Decimal", "decimal" },
            { "DateTime", "DateTime" },//GraphQL datetimes are always UTC
            { "Date", "DateOnly" },
            { "UtcOffset", "TimeSpan" },
            { "URL", "string" },
            { "HTML", "string" },
            { "JSON", "string" },
            { "FormattedString", "string" },
            { "ARN", "string" },
            { "StorefrontID", "string" },
            { "Color", "string" },
            { "BigInt", "long" },
        };
        string csharpCode = await new GraphQLTypeGenerator().GenerateTypesAsync("ShopifySharp.GraphQL", scalarNameToTypeName, async query =>
        {
            var res = await new GraphService(Utils.MyShopifyUrl, Utils.AccessToken).PostAsync(query);
            var doc = JsonDocument.Parse(res.ToString());
            return doc;
        });

        var strCode = new StringBuilder()
            .AppendLine("#if NET6_0_OR_GREATER")
            .AppendLine(csharpCode)
            .AppendLine("#endif");

        File.WriteAllText(@"../../../../ShopifySharp/Entities/GraphQL/GraphQLSchema.generated.cs", strCode.ToString());
    }
}
#endif
