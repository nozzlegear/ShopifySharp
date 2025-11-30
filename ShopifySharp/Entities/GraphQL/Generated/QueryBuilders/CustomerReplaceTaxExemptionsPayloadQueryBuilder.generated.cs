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

public class CustomerReplaceTaxExemptionsPayloadQueryBuilder() : GraphQueryBuilder<CustomerReplaceTaxExemptionsPayload>("customerReplaceTaxExemptionsPayload")
{
    public CustomerReplaceTaxExemptionsPayloadQueryBuilder AddFieldCustomer(Func<CustomerQueryBuilder, CustomerQueryBuilder> build)
    {
        AddField<Customer, CustomerQueryBuilder>("customer", build);
        return this;
    }

    public CustomerReplaceTaxExemptionsPayloadQueryBuilder AddFieldUserErrors(Func<UserErrorQueryBuilder, UserErrorQueryBuilder> build)
    {
        AddField<UserError, UserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}