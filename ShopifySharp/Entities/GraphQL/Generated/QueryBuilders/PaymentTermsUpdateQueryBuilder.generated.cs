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

public class PaymentTermsUpdateQueryBuilder() : GraphQueryBuilder<PaymentTermsUpdatePayload>("paymentTermsUpdate"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public PaymentTermsUpdateQueryBuilder AddArgumentInput(PaymentTermsUpdateInput? input)
    {
        AddArgument("input", input);
        return this;
    }
}