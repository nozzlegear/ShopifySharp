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

        public FulfillmentOrderMerchantRequestEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderMerchantRequestQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderMerchantRequest>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderMerchantRequestQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderMerchantRequest>(query);
            return this;
        }
    }
}