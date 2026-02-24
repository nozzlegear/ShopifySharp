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
    public sealed class ReturnExchangeLineItemsQueryBuilder : FieldsQueryBuilderBase<ExchangeLineItemConnection, ReturnExchangeLineItemsQueryBuilder>, IHasArguments<ReturnExchangeLineItemsArgumentsBuilder>
    {
        public ReturnExchangeLineItemsArgumentsBuilder Arguments { get; }
        protected override ReturnExchangeLineItemsQueryBuilder Self => this;

        public ReturnExchangeLineItemsQueryBuilder(string name) : base(new Query<ExchangeLineItemConnection>(name))
        {
            Arguments = new ReturnExchangeLineItemsArgumentsBuilder(base.InnerQuery);
        }

        public ReturnExchangeLineItemsQueryBuilder(IQuery<ExchangeLineItemConnection> query) : base(query)
        {
            Arguments = new ReturnExchangeLineItemsArgumentsBuilder(base.InnerQuery);
        }

        public ReturnExchangeLineItemsQueryBuilder SetArguments(Action<ReturnExchangeLineItemsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public ReturnExchangeLineItemsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ExchangeLineItemEdgeQueryBuilder> build)
        {
            var query = new Query<ExchangeLineItemEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ExchangeLineItemEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ExchangeLineItemEdge>(query);
            return this;
        }

        public ReturnExchangeLineItemsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ExchangeLineItemQueryBuilder> build)
        {
            var query = new Query<ExchangeLineItem>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ExchangeLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ExchangeLineItem>(query);
            return this;
        }

        public ReturnExchangeLineItemsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}