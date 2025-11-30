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

public class DiscountCountriesQueryBuilder() : GraphQueryBuilder<DiscountCountries>("discountCountries")
{
    public DiscountCountriesQueryBuilder AddFieldCountries()
    {
        AddField("countries");
        return this;
    }

    public DiscountCountriesQueryBuilder AddFieldIncludeRestOfWorld()
    {
        AddField("includeRestOfWorld");
        return this;
    }
}