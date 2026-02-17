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
    public sealed class SubscriptionDiscountValueQueryBuilder : FieldsQueryBuilderBase<SubscriptionDiscountValue, SubscriptionDiscountValueQueryBuilder>
    {
        protected override SubscriptionDiscountValueQueryBuilder Self => this;

        public SubscriptionDiscountValueQueryBuilder() : this("subscriptionDiscountValue")
        {
        }

        public SubscriptionDiscountValueQueryBuilder(string name) : base(new Query<SubscriptionDiscountValue>(name))
        {
        }

        public SubscriptionDiscountValueQueryBuilder(IQuery<SubscriptionDiscountValue> query) : base(query)
        {
        }

        public SubscriptionDiscountValueQueryBuilder SubscriptionDiscountValue(Action<SubscriptionDiscountValueUnionCasesBuilder> build)
        {
            var query = new Query<SubscriptionDiscountValue>("subscriptionDiscountValue");
            var unionBuilder = new SubscriptionDiscountValueUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}