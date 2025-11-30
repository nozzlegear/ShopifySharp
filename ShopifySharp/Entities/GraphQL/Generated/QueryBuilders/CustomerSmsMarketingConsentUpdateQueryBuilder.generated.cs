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

public class CustomerSmsMarketingConsentUpdateQueryBuilder() : GraphQueryBuilder<CustomerSmsMarketingConsentUpdatePayload>("customerSmsMarketingConsentUpdate"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public CustomerSmsMarketingConsentUpdateQueryBuilder AddArgumentInput(CustomerSmsMarketingConsentUpdateInput? input)
    {
        AddArgument("input", input);
        return this;
    }
}