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
    public sealed class SubscriptionDiscountPercentageValueQueryBuilder : FieldsQueryBuilderBase<SubscriptionDiscountPercentageValue, SubscriptionDiscountPercentageValueQueryBuilder>
    {
        protected override SubscriptionDiscountPercentageValueQueryBuilder Self => this;

        public SubscriptionDiscountPercentageValueQueryBuilder() : this("subscriptionDiscountPercentageValue")
        {
        }

        public SubscriptionDiscountPercentageValueQueryBuilder(string name) : base(new Query<SubscriptionDiscountPercentageValue>(name))
        {
        }

        public SubscriptionDiscountPercentageValueQueryBuilder(IQuery<SubscriptionDiscountPercentageValue> query) : base(query)
        {
        }

        public SubscriptionDiscountPercentageValueQueryBuilder Percentage()
        {
            base.InnerQuery.AddField("percentage");
            return this;
        }
    }
}