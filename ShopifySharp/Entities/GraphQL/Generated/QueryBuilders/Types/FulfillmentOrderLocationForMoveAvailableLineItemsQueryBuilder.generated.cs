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
    public sealed class FulfillmentOrderLocationForMoveAvailableLineItemsQueryBuilder : FieldsQueryBuilderBase<FulfillmentOrderLineItemConnection, FulfillmentOrderLocationForMoveAvailableLineItemsQueryBuilder>, IHasArguments<FulfillmentOrderLocationForMoveAvailableLineItemsArgumentsBuilder>
    {
        public FulfillmentOrderLocationForMoveAvailableLineItemsArgumentsBuilder Arguments { get; }
        protected override FulfillmentOrderLocationForMoveAvailableLineItemsQueryBuilder Self => this;

        public FulfillmentOrderLocationForMoveAvailableLineItemsQueryBuilder(string name) : base(new Query<FulfillmentOrderLineItemConnection>(name))
        {
            Arguments = new FulfillmentOrderLocationForMoveAvailableLineItemsArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentOrderLocationForMoveAvailableLineItemsQueryBuilder(IQuery<FulfillmentOrderLineItemConnection> query) : base(query)
        {
            Arguments = new FulfillmentOrderLocationForMoveAvailableLineItemsArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentOrderLocationForMoveAvailableLineItemsQueryBuilder SetArguments(Action<FulfillmentOrderLocationForMoveAvailableLineItemsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public FulfillmentOrderLocationForMoveAvailableLineItemsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderLineItemEdgeQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderLineItemEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderLineItemEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderLineItemEdge>(query);
            return this;
        }

        public FulfillmentOrderLocationForMoveAvailableLineItemsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderLineItemQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderLineItem>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderLineItem>(query);
            return this;
        }

        public FulfillmentOrderLocationForMoveAvailableLineItemsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}