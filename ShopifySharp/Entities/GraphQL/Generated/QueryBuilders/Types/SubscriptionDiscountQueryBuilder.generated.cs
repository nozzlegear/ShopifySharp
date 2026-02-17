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
    public sealed class SubscriptionDiscountQueryBuilder : FieldsQueryBuilderBase<SubscriptionDiscount, SubscriptionDiscountQueryBuilder>
    {
        protected override SubscriptionDiscountQueryBuilder Self => this;

        public SubscriptionDiscountQueryBuilder() : this("subscriptionDiscount")
        {
        }

        public SubscriptionDiscountQueryBuilder(string name) : base(new Query<SubscriptionDiscount>(name))
        {
        }

        public SubscriptionDiscountQueryBuilder(IQuery<SubscriptionDiscount> query) : base(query)
        {
        }

        public SubscriptionDiscountQueryBuilder SubscriptionDiscount(Action<SubscriptionDiscountUnionCasesBuilder> build)
        {
            var query = new Query<SubscriptionDiscount>("subscriptionDiscount");
            var unionBuilder = new SubscriptionDiscountUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}