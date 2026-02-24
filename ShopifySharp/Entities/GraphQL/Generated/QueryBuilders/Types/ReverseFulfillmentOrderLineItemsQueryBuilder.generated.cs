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
    public sealed class ReverseFulfillmentOrderLineItemsQueryBuilder : FieldsQueryBuilderBase<ReverseFulfillmentOrderLineItemConnection, ReverseFulfillmentOrderLineItemsQueryBuilder>, IHasArguments<ReverseFulfillmentOrderLineItemsArgumentsBuilder>
    {
        public ReverseFulfillmentOrderLineItemsArgumentsBuilder Arguments { get; }
        protected override ReverseFulfillmentOrderLineItemsQueryBuilder Self => this;

        public ReverseFulfillmentOrderLineItemsQueryBuilder(string name) : base(new Query<ReverseFulfillmentOrderLineItemConnection>(name))
        {
            Arguments = new ReverseFulfillmentOrderLineItemsArgumentsBuilder(base.InnerQuery);
        }

        public ReverseFulfillmentOrderLineItemsQueryBuilder(IQuery<ReverseFulfillmentOrderLineItemConnection> query) : base(query)
        {
            Arguments = new ReverseFulfillmentOrderLineItemsArgumentsBuilder(base.InnerQuery);
        }

        public ReverseFulfillmentOrderLineItemsQueryBuilder SetArguments(Action<ReverseFulfillmentOrderLineItemsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public ReverseFulfillmentOrderLineItemsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReverseFulfillmentOrderLineItemEdgeQueryBuilder> build)
        {
            var query = new Query<ReverseFulfillmentOrderLineItemEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReverseFulfillmentOrderLineItemEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReverseFulfillmentOrderLineItemEdge>(query);
            return this;
        }

        public ReverseFulfillmentOrderLineItemsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReverseFulfillmentOrderLineItemQueryBuilder> build)
        {
            var query = new Query<ReverseFulfillmentOrderLineItem>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReverseFulfillmentOrderLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReverseFulfillmentOrderLineItem>(query);
            return this;
        }

        public ReverseFulfillmentOrderLineItemsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}