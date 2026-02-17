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
    public sealed class ExchangeV2ConnectionQueryBuilder : FieldsQueryBuilderBase<ExchangeV2Connection, ExchangeV2ConnectionQueryBuilder>
    {
        protected override ExchangeV2ConnectionQueryBuilder Self => this;

        public ExchangeV2ConnectionQueryBuilder() : this("exchangeV2Connection")
        {
        }

        public ExchangeV2ConnectionQueryBuilder(string name) : base(new Query<ExchangeV2Connection>(name))
        {
        }

        public ExchangeV2ConnectionQueryBuilder(IQuery<ExchangeV2Connection> query) : base(query)
        {
        }

        public ExchangeV2ConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ExchangeV2EdgeQueryBuilder> build)
        {
            var query = new Query<ExchangeV2Edge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ExchangeV2EdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ExchangeV2Edge>(query);
            return this;
        }

        public ExchangeV2ConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ExchangeV2QueryBuilder> build)
        {
            var query = new Query<ExchangeV2>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ExchangeV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ExchangeV2>(query);
            return this;
        }

        public ExchangeV2ConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}