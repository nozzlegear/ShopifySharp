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
    public sealed class ReverseFulfillmentOrderLineItemConnectionQueryBuilder : FieldsQueryBuilderBase<ReverseFulfillmentOrderLineItemConnection, ReverseFulfillmentOrderLineItemConnectionQueryBuilder>
    {
        protected override ReverseFulfillmentOrderLineItemConnectionQueryBuilder Self => this;

        public ReverseFulfillmentOrderLineItemConnectionQueryBuilder() : this("reverseFulfillmentOrderLineItemConnection")
        {
        }

        public ReverseFulfillmentOrderLineItemConnectionQueryBuilder(string name) : base(new Query<ReverseFulfillmentOrderLineItemConnection>(name))
        {
        }

        public ReverseFulfillmentOrderLineItemConnectionQueryBuilder(IQuery<ReverseFulfillmentOrderLineItemConnection> query) : base(query)
        {
        }

        public ReverseFulfillmentOrderLineItemConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReverseFulfillmentOrderLineItemEdgeQueryBuilder> build)
        {
            var query = new Query<ReverseFulfillmentOrderLineItemEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReverseFulfillmentOrderLineItemEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReverseFulfillmentOrderLineItemEdge>(query);
            return this;
        }

        public ReverseFulfillmentOrderLineItemConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReverseFulfillmentOrderLineItemQueryBuilder> build)
        {
            var query = new Query<ReverseFulfillmentOrderLineItem>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReverseFulfillmentOrderLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReverseFulfillmentOrderLineItem>(query);
            return this;
        }

        public ReverseFulfillmentOrderLineItemConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}