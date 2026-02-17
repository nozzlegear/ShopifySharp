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