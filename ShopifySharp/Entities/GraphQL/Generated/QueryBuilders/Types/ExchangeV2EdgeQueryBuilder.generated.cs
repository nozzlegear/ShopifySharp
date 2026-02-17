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
    public sealed class ExchangeV2EdgeQueryBuilder : FieldsQueryBuilderBase<ExchangeV2Edge, ExchangeV2EdgeQueryBuilder>
    {
        protected override ExchangeV2EdgeQueryBuilder Self => this;

        public ExchangeV2EdgeQueryBuilder() : this("exchangeV2Edge")
        {
        }

        public ExchangeV2EdgeQueryBuilder(string name) : base(new Query<ExchangeV2Edge>(name))
        {
        }

        public ExchangeV2EdgeQueryBuilder(IQuery<ExchangeV2Edge> query) : base(query)
        {
        }

        public ExchangeV2EdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public ExchangeV2EdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ExchangeV2QueryBuilder> build)
        {
            var query = new Query<ExchangeV2>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ExchangeV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ExchangeV2>(query);
            return this;
        }
    }
}