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
    public sealed class SubscriptionManualDiscountQueryBuilder : FieldsQueryBuilderBase<SubscriptionManualDiscount, SubscriptionManualDiscountQueryBuilder>
    {
        protected override SubscriptionManualDiscountQueryBuilder Self => this;

        public SubscriptionManualDiscountQueryBuilder() : this("subscriptionManualDiscount")
        {
        }

        public SubscriptionManualDiscountQueryBuilder(string name) : base(new Query<SubscriptionManualDiscount>(name))
        {
        }

        public SubscriptionManualDiscountQueryBuilder(IQuery<SubscriptionManualDiscount> query) : base(query)
        {
        }

        public SubscriptionManualDiscountQueryBuilder EntitledLines(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDiscountEntitledLinesQueryBuilder> build)
        {
            var query = new Query<SubscriptionDiscountEntitledLines>("entitledLines");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDiscountEntitledLinesQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDiscountEntitledLines>(query);
            return this;
        }

        public SubscriptionManualDiscountQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public SubscriptionManualDiscountQueryBuilder RecurringCycleLimit()
        {
            base.InnerQuery.AddField("recurringCycleLimit");
            return this;
        }

        public SubscriptionManualDiscountQueryBuilder RejectionReason()
        {
            base.InnerQuery.AddField("rejectionReason");
            return this;
        }

        public SubscriptionManualDiscountQueryBuilder TargetType()
        {
            base.InnerQuery.AddField("targetType");
            return this;
        }

        public SubscriptionManualDiscountQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public SubscriptionManualDiscountQueryBuilder Type()
        {
            base.InnerQuery.AddField("type");
            return this;
        }

        public SubscriptionManualDiscountQueryBuilder UsageCount()
        {
            base.InnerQuery.AddField("usageCount");
            return this;
        }

        public SubscriptionManualDiscountQueryBuilder Value(Action<SubscriptionDiscountValueUnionCasesBuilder> build)
        {
            var query = new Query<SubscriptionDiscountValue>("value");
            var unionBuilder = new SubscriptionDiscountValueUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}