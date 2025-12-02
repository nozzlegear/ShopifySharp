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

public class PriceRuleCustomerSelectionQueryBuilder() : GraphQueryBuilder<PriceRuleCustomerSelection>("priceRuleCustomerSelection")
{
    public PriceRuleCustomerSelectionQueryBuilder AddFieldCustomers(Func<CustomerConnectionQueryBuilder, CustomerConnectionQueryBuilder> build)
    {
        AddField<CustomerConnection, CustomerConnectionQueryBuilder>("customers", build);
        return this;
    }

    public PriceRuleCustomerSelectionQueryBuilder AddFieldForAllCustomers()
    {
        AddField("forAllCustomers");
        return this;
    }

    public PriceRuleCustomerSelectionQueryBuilder AddFieldSegments(Func<SegmentQueryBuilder, SegmentQueryBuilder> build)
    {
        AddField<Segment, SegmentQueryBuilder>("segments", build);
        return this;
    }
}