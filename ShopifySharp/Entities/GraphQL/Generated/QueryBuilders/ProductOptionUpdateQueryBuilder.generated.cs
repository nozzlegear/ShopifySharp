#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class ProductOptionUpdateQueryBuilder() : GraphQueryBuilder<ProductOptionUpdatePayload>("productOptionUpdate"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public ProductOptionUpdateQueryBuilder AddArgumentOption(OptionUpdateInput? option)
    {
        AddArgument("option", option);
        return this;
    }

    public ProductOptionUpdateQueryBuilder AddArgumentOptionValuesToAdd(ICollection<OptionValueCreateInput>? optionValuesToAdd)
    {
        AddArgument("optionValuesToAdd", optionValuesToAdd);
        return this;
    }

    public ProductOptionUpdateQueryBuilder AddArgumentOptionValuesToDelete(ICollection<string>? optionValuesToDelete)
    {
        AddArgument("optionValuesToDelete", optionValuesToDelete);
        return this;
    }

    public ProductOptionUpdateQueryBuilder AddArgumentOptionValuesToUpdate(ICollection<OptionValueUpdateInput>? optionValuesToUpdate)
    {
        AddArgument("optionValuesToUpdate", optionValuesToUpdate);
        return this;
    }

    public ProductOptionUpdateQueryBuilder AddArgumentProductId(string? productId)
    {
        AddArgument("productId", productId);
        return this;
    }

    public ProductOptionUpdateQueryBuilder AddArgumentVariantStrategy(ProductOptionUpdateVariantStrategy? variantStrategy)
    {
        AddArgument("variantStrategy", variantStrategy);
        return this;
    }
}