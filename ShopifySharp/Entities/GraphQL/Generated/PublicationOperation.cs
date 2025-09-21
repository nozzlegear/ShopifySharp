#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The possible types of publication operations.
/// </summary>
[JsonConverter(typeof(GraphUnionTypeConverter<PublicationOperation>))]
public record PublicationOperation : GraphQLObject<PublicationOperation>, IGraphQLUnionType
{
    public AddAllProductsOperation? AsAddAllProductsOperation() => this is PublicationOperationAddAllProductsOperation wrapper ? wrapper.Value : null;
    public CatalogCsvOperation? AsCatalogCsvOperation() => this is PublicationOperationCatalogCsvOperation wrapper ? wrapper.Value : null;
    public PublicationResourceOperation? AsPublicationResourceOperation() => this is PublicationOperationPublicationResourceOperation wrapper ? wrapper.Value : null;
}