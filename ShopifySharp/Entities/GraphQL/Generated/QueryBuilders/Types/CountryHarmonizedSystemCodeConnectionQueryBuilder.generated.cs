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
    public sealed class CountryHarmonizedSystemCodeConnectionQueryBuilder : FieldsQueryBuilderBase<CountryHarmonizedSystemCodeConnection, CountryHarmonizedSystemCodeConnectionQueryBuilder>
    {
        protected override CountryHarmonizedSystemCodeConnectionQueryBuilder Self => this;

        public CountryHarmonizedSystemCodeConnectionQueryBuilder() : this("countryHarmonizedSystemCodeConnection")
        {
        }

        public CountryHarmonizedSystemCodeConnectionQueryBuilder(string name) : base(new Query<CountryHarmonizedSystemCodeConnection>(name))
        {
        }

        public CountryHarmonizedSystemCodeConnectionQueryBuilder(IQuery<CountryHarmonizedSystemCodeConnection> query) : base(query)
        {
        }

        public CountryHarmonizedSystemCodeConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountryHarmonizedSystemCodeEdgeQueryBuilder> build)
        {
            var query = new Query<CountryHarmonizedSystemCodeEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountryHarmonizedSystemCodeEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CountryHarmonizedSystemCodeEdge>(query);
            return this;
        }

        public CountryHarmonizedSystemCodeConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountryHarmonizedSystemCodeQueryBuilder> build)
        {
            var query = new Query<CountryHarmonizedSystemCode>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountryHarmonizedSystemCodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CountryHarmonizedSystemCode>(query);
            return this;
        }

        public CountryHarmonizedSystemCodeConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}