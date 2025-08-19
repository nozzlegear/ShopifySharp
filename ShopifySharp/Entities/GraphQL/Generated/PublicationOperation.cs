#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The possible types of publication operations.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(AddAllProductsOperation), typeDiscriminator: "AddAllProductsOperation")]
[JsonDerivedType(typeof(CatalogCsvOperation), typeDiscriminator: "CatalogCsvOperation")]
[JsonDerivedType(typeof(PublicationResourceOperation), typeDiscriminator: "PublicationResourceOperation")]
public record PublicationOperation : GraphQLObject<PublicationOperation>, IGraphQLUnionType
{
#if NET6_0_OR_GREATER
	public AddAllProductsOperation? AsAddAllProductsOperation() => this is PublicationOperationAddAllProductsOperation wrapper ? wrapper.Value : null;
	public CatalogCsvOperation? AsCatalogCsvOperation() => this is PublicationOperationCatalogCsvOperation wrapper ? wrapper.Value : null;
	public PublicationResourceOperation? AsPublicationResourceOperation() => this is PublicationOperationPublicationResourceOperation wrapper ? wrapper.Value : null;
#endif
}