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
    public sealed class FulfillmentOrderMerchantRequestEdgeQueryBuilder : FieldsQueryBuilderBase<FulfillmentOrderMerchantRequestEdge, FulfillmentOrderMerchantRequestEdgeQueryBuilder>
    {
        protected override FulfillmentOrderMerchantRequestEdgeQueryBuilder Self => this;

        public FulfillmentOrderMerchantRequestEdgeQueryBuilder() : this("fulfillmentOrderMerchantRequestEdge")
        {
        }

        public FulfillmentOrderMerchantRequestEdgeQueryBuilder(string name) : base(new Query<FulfillmentOrderMerchantRequestEdge>(name))
        {
        }

        public FulfillmentOrderMerchantRequestEdgeQueryBuilder(IQuery<FulfillmentOrderMerchantRequestEdge> query) : base(query)
        {
        }

        public FulfillmentOrderMerchantRequestEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public FulfillmentOrderMerchantRequestEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderMerchantRequestQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderMerchantRequest>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderMerchantRequestQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderMerchantRequest>(query);
            return this;
        }
    }
}