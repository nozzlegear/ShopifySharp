#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.GraphQL.QueryBuilders;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.QueryBuilders.Operations;
using ShopifySharp.GraphQL.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class MetafieldReferencerSearchQueryBuilder : FieldsQueryBuilderBase<SearchResultConnection, MetafieldReferencerSearchQueryBuilder>, IHasArguments<MetafieldReferencerSearchArgumentsBuilder>
    {
        public MetafieldReferencerSearchArgumentsBuilder Arguments { get; }
        protected override MetafieldReferencerSearchQueryBuilder Self => this;

        public MetafieldReferencerSearchQueryBuilder(string name) : base(new Query<SearchResultConnection>(name))
        {
            Arguments = new MetafieldReferencerSearchArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerSearchQueryBuilder(IQuery<SearchResultConnection> query) : base(query)
        {
            Arguments = new MetafieldReferencerSearchArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerSearchQueryBuilder SetArguments(Action<MetafieldReferencerSearchArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MetafieldReferencerSearchQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SearchResultEdgeQueryBuilder> build)
        {
            var query = new Query<SearchResultEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SearchResultEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SearchResultEdge>(query);
            return this;
        }

        public MetafieldReferencerSearchQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }

        [Obsolete("The provided information is not accurate.")]
        public MetafieldReferencerSearchQueryBuilder ResultsAfterCount()
        {
            base.InnerQuery.AddField("resultsAfterCount");
            return this;
        }
    }
}