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
    public sealed class ReverseDeliveryTrackingV2QueryBuilder : FieldsQueryBuilderBase<ReverseDeliveryTrackingV2, ReverseDeliveryTrackingV2QueryBuilder>
    {
        protected override ReverseDeliveryTrackingV2QueryBuilder Self => this;

        public ReverseDeliveryTrackingV2QueryBuilder() : this("reverseDeliveryTrackingV2")
        {
        }

        public ReverseDeliveryTrackingV2QueryBuilder(string name) : base(new Query<ReverseDeliveryTrackingV2>(name))
        {
        }

        public ReverseDeliveryTrackingV2QueryBuilder(IQuery<ReverseDeliveryTrackingV2> query) : base(query)
        {
        }

        public ReverseDeliveryTrackingV2QueryBuilder CarrierName()
        {
            base.InnerQuery.AddField("carrierName");
            return this;
        }

        public ReverseDeliveryTrackingV2QueryBuilder Number()
        {
            base.InnerQuery.AddField("number");
            return this;
        }

        public ReverseDeliveryTrackingV2QueryBuilder Url()
        {
            base.InnerQuery.AddField("url");
            return this;
        }
    }
}