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
    public sealed class FulfillmentOrderMerchantRequestConnectionQueryBuilder : FieldsQueryBuilderBase<FulfillmentOrderMerchantRequestConnection, FulfillmentOrderMerchantRequestConnectionQueryBuilder>
    {
        protected override FulfillmentOrderMerchantRequestConnectionQueryBuilder Self => this;

        public FulfillmentOrderMerchantRequestConnectionQueryBuilder() : this("fulfillmentOrderMerchantRequestConnection")
        {
        }

        public FulfillmentOrderMerchantRequestConnectionQueryBuilder(string name) : base(new Query<FulfillmentOrderMerchantRequestConnection>(name))
        {
        }

        public FulfillmentOrderMerchantRequestConnectionQueryBuilder(IQuery<FulfillmentOrderMerchantRequestConnection> query) : base(query)
        {
        }

        public FulfillmentOrderMerchantRequestConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderMerchantRequestEdgeQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderMerchantRequestEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderMerchantRequestEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderMerchantRequestEdge>(query);
            return this;
        }

        public FulfillmentOrderMerchantRequestConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderMerchantRequestQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderMerchantRequest>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderMerchantRequestQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderMerchantRequest>(query);
            return this;
        }

        public FulfillmentOrderMerchantRequestConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}