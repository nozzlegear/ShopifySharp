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
    public sealed class FulfillmentOrderLineItemConnectionQueryBuilder : FieldsQueryBuilderBase<FulfillmentOrderLineItemConnection, FulfillmentOrderLineItemConnectionQueryBuilder>
    {
        protected override FulfillmentOrderLineItemConnectionQueryBuilder Self => this;

        public FulfillmentOrderLineItemConnectionQueryBuilder() : this("fulfillmentOrderLineItemConnection")
        {
        }

        public FulfillmentOrderLineItemConnectionQueryBuilder(string name) : base(new Query<FulfillmentOrderLineItemConnection>(name))
        {
        }

        public FulfillmentOrderLineItemConnectionQueryBuilder(IQuery<FulfillmentOrderLineItemConnection> query) : base(query)
        {
        }

        public FulfillmentOrderLineItemConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderLineItemEdgeQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderLineItemEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderLineItemEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderLineItemEdge>(query);
            return this;
        }

        public FulfillmentOrderLineItemConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderLineItemQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderLineItem>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderLineItem>(query);
            return this;
        }

        public FulfillmentOrderLineItemConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}