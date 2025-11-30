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

public class SearchFilterOptionsQueryBuilder() : GraphQueryBuilder<SearchFilterOptions>("searchFilterOptions")
{
    public SearchFilterOptionsQueryBuilder AddFieldProductAvailability(Func<FilterOptionQueryBuilder, FilterOptionQueryBuilder> build)
    {
        AddField<FilterOption, FilterOptionQueryBuilder>("productAvailability", build);
        return this;
    }
}