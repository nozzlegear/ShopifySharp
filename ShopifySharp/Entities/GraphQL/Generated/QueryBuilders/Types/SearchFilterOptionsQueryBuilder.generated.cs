#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class SearchFilterOptionsQueryBuilder : FieldsQueryBuilderBase<SearchFilterOptions, SearchFilterOptionsQueryBuilder>
    {
        protected override SearchFilterOptionsQueryBuilder Self => this;

        public SearchFilterOptionsQueryBuilder() : this("searchFilterOptions")
        {
        }

        public SearchFilterOptionsQueryBuilder(string name) : base(new Query<SearchFilterOptions>(name))
        {
        }

        public SearchFilterOptionsQueryBuilder(IQuery<SearchFilterOptions> query) : base(query)
        {
        }

        public SearchFilterOptionsQueryBuilder ProductAvailability(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FilterOptionQueryBuilder> build)
        {
            var query = new Query<FilterOption>("productAvailability");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FilterOptionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FilterOption>(query);
            return this;
        }
    }
}