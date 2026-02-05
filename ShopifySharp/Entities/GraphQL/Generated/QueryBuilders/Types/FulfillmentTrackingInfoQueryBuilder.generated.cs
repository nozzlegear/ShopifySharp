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
    public sealed class FulfillmentTrackingInfoQueryBuilder : FieldsQueryBuilderBase<FulfillmentTrackingInfo, FulfillmentTrackingInfoQueryBuilder>
    {
        protected override FulfillmentTrackingInfoQueryBuilder Self => this;

        public FulfillmentTrackingInfoQueryBuilder() : this("fulfillmentTrackingInfo")
        {
        }

        public FulfillmentTrackingInfoQueryBuilder(string name) : base(new Query<FulfillmentTrackingInfo>(name))
        {
        }

        public FulfillmentTrackingInfoQueryBuilder(IQuery<FulfillmentTrackingInfo> query) : base(query)
        {
        }

        public FulfillmentTrackingInfoQueryBuilder Company()
        {
            base.InnerQuery.AddField("company");
            return this;
        }

        public FulfillmentTrackingInfoQueryBuilder Number()
        {
            base.InnerQuery.AddField("number");
            return this;
        }

        public FulfillmentTrackingInfoQueryBuilder Url()
        {
            base.InnerQuery.AddField("url");
            return this;
        }
    }
}