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

        public CountryHarmonizedSystemCodeConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CountryHarmonizedSystemCodeEdgeQueryBuilder> build)
        {
            var query = new Query<CountryHarmonizedSystemCodeEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CountryHarmonizedSystemCodeEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CountryHarmonizedSystemCodeEdge>(query);
            return this;
        }

        public CountryHarmonizedSystemCodeConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CountryHarmonizedSystemCodeQueryBuilder> build)
        {
            var query = new Query<CountryHarmonizedSystemCode>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CountryHarmonizedSystemCodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CountryHarmonizedSystemCode>(query);
            return this;
        }

        public CountryHarmonizedSystemCodeConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}