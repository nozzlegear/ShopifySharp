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

public class CustomerPaymentMethodGetUpdateUrlPayloadQueryBuilder() : GraphQueryBuilder<CustomerPaymentMethodGetUpdateUrlPayload>("customerPaymentMethodGetUpdateUrlPayload")
{
    public CustomerPaymentMethodGetUpdateUrlPayloadQueryBuilder AddFieldUpdatePaymentMethodUrl()
    {
        AddField("updatePaymentMethodUrl");
        return this;
    }

    public CustomerPaymentMethodGetUpdateUrlPayloadQueryBuilder AddFieldUserErrors(Func<CustomerPaymentMethodGetUpdateUrlUserErrorQueryBuilder, CustomerPaymentMethodGetUpdateUrlUserErrorQueryBuilder> build)
    {
        AddField<CustomerPaymentMethodGetUpdateUrlUserError, CustomerPaymentMethodGetUpdateUrlUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}