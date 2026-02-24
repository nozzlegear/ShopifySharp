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
    public sealed class FulfillmentFulfillmentLineItemsQueryBuilder : FieldsQueryBuilderBase<FulfillmentLineItemConnection, FulfillmentFulfillmentLineItemsQueryBuilder>, IHasArguments<FulfillmentFulfillmentLineItemsArgumentsBuilder>
    {
        public FulfillmentFulfillmentLineItemsArgumentsBuilder Arguments { get; }
        protected override FulfillmentFulfillmentLineItemsQueryBuilder Self => this;

        public FulfillmentFulfillmentLineItemsQueryBuilder(string name) : base(new Query<FulfillmentLineItemConnection>(name))
        {
            Arguments = new FulfillmentFulfillmentLineItemsArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentFulfillmentLineItemsQueryBuilder(IQuery<FulfillmentLineItemConnection> query) : base(query)
        {
            Arguments = new FulfillmentFulfillmentLineItemsArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentFulfillmentLineItemsQueryBuilder SetArguments(Action<FulfillmentFulfillmentLineItemsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public FulfillmentFulfillmentLineItemsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentLineItemEdgeQueryBuilder> build)
        {
            var query = new Query<FulfillmentLineItemEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentLineItemEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentLineItemEdge>(query);
            return this;
        }

        public FulfillmentFulfillmentLineItemsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentLineItemQueryBuilder> build)
        {
            var query = new Query<FulfillmentLineItem>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentLineItem>(query);
            return this;
        }

        public FulfillmentFulfillmentLineItemsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}