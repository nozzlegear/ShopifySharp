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
    public sealed class FulfillmentLineItemConnectionQueryBuilder : FieldsQueryBuilderBase<FulfillmentLineItemConnection, FulfillmentLineItemConnectionQueryBuilder>
    {
        protected override FulfillmentLineItemConnectionQueryBuilder Self => this;

        public FulfillmentLineItemConnectionQueryBuilder() : this("fulfillmentLineItemConnection")
        {
        }

        public FulfillmentLineItemConnectionQueryBuilder(string name) : base(new Query<FulfillmentLineItemConnection>(name))
        {
        }

        public FulfillmentLineItemConnectionQueryBuilder(IQuery<FulfillmentLineItemConnection> query) : base(query)
        {
        }

        public FulfillmentLineItemConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentLineItemEdgeQueryBuilder> build)
        {
            var query = new Query<FulfillmentLineItemEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentLineItemEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentLineItemEdge>(query);
            return this;
        }

        public FulfillmentLineItemConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentLineItemQueryBuilder> build)
        {
            var query = new Query<FulfillmentLineItem>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentLineItem>(query);
            return this;
        }

        public FulfillmentLineItemConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}