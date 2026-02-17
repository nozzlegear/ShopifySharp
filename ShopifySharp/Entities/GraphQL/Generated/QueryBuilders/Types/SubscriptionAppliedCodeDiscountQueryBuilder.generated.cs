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
    public sealed class SubscriptionAppliedCodeDiscountQueryBuilder : FieldsQueryBuilderBase<SubscriptionAppliedCodeDiscount, SubscriptionAppliedCodeDiscountQueryBuilder>
    {
        protected override SubscriptionAppliedCodeDiscountQueryBuilder Self => this;

        public SubscriptionAppliedCodeDiscountQueryBuilder() : this("subscriptionAppliedCodeDiscount")
        {
        }

        public SubscriptionAppliedCodeDiscountQueryBuilder(string name) : base(new Query<SubscriptionAppliedCodeDiscount>(name))
        {
        }

        public SubscriptionAppliedCodeDiscountQueryBuilder(IQuery<SubscriptionAppliedCodeDiscount> query) : base(query)
        {
        }

        public SubscriptionAppliedCodeDiscountQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public SubscriptionAppliedCodeDiscountQueryBuilder RedeemCode()
        {
            base.InnerQuery.AddField("redeemCode");
            return this;
        }

        public SubscriptionAppliedCodeDiscountQueryBuilder RejectionReason()
        {
            base.InnerQuery.AddField("rejectionReason");
            return this;
        }
    }
}