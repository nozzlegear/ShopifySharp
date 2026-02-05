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
    public sealed class ExchangeLineItemConnectionQueryBuilder : FieldsQueryBuilderBase<ExchangeLineItemConnection, ExchangeLineItemConnectionQueryBuilder>
    {
        protected override ExchangeLineItemConnectionQueryBuilder Self => this;

        public ExchangeLineItemConnectionQueryBuilder() : this("exchangeLineItemConnection")
        {
        }

        public ExchangeLineItemConnectionQueryBuilder(string name) : base(new Query<ExchangeLineItemConnection>(name))
        {
        }

        public ExchangeLineItemConnectionQueryBuilder(IQuery<ExchangeLineItemConnection> query) : base(query)
        {
        }

        public ExchangeLineItemConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ExchangeLineItemEdgeQueryBuilder> build)
        {
            var query = new Query<ExchangeLineItemEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ExchangeLineItemEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ExchangeLineItemEdge>(query);
            return this;
        }

        public ExchangeLineItemConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ExchangeLineItemQueryBuilder> build)
        {
            var query = new Query<ExchangeLineItem>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ExchangeLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ExchangeLineItem>(query);
            return this;
        }

        public ExchangeLineItemConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}