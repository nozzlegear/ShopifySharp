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
    public sealed class ShopifyPaymentsDisputeReasonDetailsQueryBuilder : FieldsQueryBuilderBase<ShopifyPaymentsDisputeReasonDetails, ShopifyPaymentsDisputeReasonDetailsQueryBuilder>
    {
        protected override ShopifyPaymentsDisputeReasonDetailsQueryBuilder Self => this;

        public ShopifyPaymentsDisputeReasonDetailsQueryBuilder() : this("shopifyPaymentsDisputeReasonDetails")
        {
        }

        public ShopifyPaymentsDisputeReasonDetailsQueryBuilder(string name) : base(new Query<ShopifyPaymentsDisputeReasonDetails>(name))
        {
        }

        public ShopifyPaymentsDisputeReasonDetailsQueryBuilder(IQuery<ShopifyPaymentsDisputeReasonDetails> query) : base(query)
        {
        }

        public ShopifyPaymentsDisputeReasonDetailsQueryBuilder NetworkReasonCode()
        {
            base.InnerQuery.AddField("networkReasonCode");
            return this;
        }

        public ShopifyPaymentsDisputeReasonDetailsQueryBuilder Reason()
        {
            base.InnerQuery.AddField("reason");
            return this;
        }
    }
}