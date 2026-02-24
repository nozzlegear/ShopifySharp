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
    public sealed class FulfillmentOrderLineItemsQueryBuilder : FieldsQueryBuilderBase<FulfillmentOrderLineItemConnection, FulfillmentOrderLineItemsQueryBuilder>, IHasArguments<FulfillmentOrderLineItemsArgumentsBuilder>
    {
        public FulfillmentOrderLineItemsArgumentsBuilder Arguments { get; }
        protected override FulfillmentOrderLineItemsQueryBuilder Self => this;

        public FulfillmentOrderLineItemsQueryBuilder(string name) : base(new Query<FulfillmentOrderLineItemConnection>(name))
        {
            Arguments = new FulfillmentOrderLineItemsArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentOrderLineItemsQueryBuilder(IQuery<FulfillmentOrderLineItemConnection> query) : base(query)
        {
            Arguments = new FulfillmentOrderLineItemsArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentOrderLineItemsQueryBuilder SetArguments(Action<FulfillmentOrderLineItemsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public FulfillmentOrderLineItemsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderLineItemEdgeQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderLineItemEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderLineItemEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderLineItemEdge>(query);
            return this;
        }

        public FulfillmentOrderLineItemsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderLineItemQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderLineItem>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderLineItem>(query);
            return this;
        }

        public FulfillmentOrderLineItemsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}