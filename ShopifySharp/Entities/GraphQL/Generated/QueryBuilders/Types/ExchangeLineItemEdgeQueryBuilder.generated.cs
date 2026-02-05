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
    public sealed class ExchangeLineItemEdgeQueryBuilder : FieldsQueryBuilderBase<ExchangeLineItemEdge, ExchangeLineItemEdgeQueryBuilder>
    {
        protected override ExchangeLineItemEdgeQueryBuilder Self => this;

        public ExchangeLineItemEdgeQueryBuilder() : this("exchangeLineItemEdge")
        {
        }

        public ExchangeLineItemEdgeQueryBuilder(string name) : base(new Query<ExchangeLineItemEdge>(name))
        {
        }

        public ExchangeLineItemEdgeQueryBuilder(IQuery<ExchangeLineItemEdge> query) : base(query)
        {
        }

        public ExchangeLineItemEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public ExchangeLineItemEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ExchangeLineItemQueryBuilder> build)
        {
            var query = new Query<ExchangeLineItem>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ExchangeLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ExchangeLineItem>(query);
            return this;
        }
    }
}