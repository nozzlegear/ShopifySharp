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
    public sealed class SubscriptionBillingAttemptOutOfStockProductVariantsErrorQueryBuilder : FieldsQueryBuilderBase<SubscriptionBillingAttemptOutOfStockProductVariantsError, SubscriptionBillingAttemptOutOfStockProductVariantsErrorQueryBuilder>
    {
        protected override SubscriptionBillingAttemptOutOfStockProductVariantsErrorQueryBuilder Self => this;

        public SubscriptionBillingAttemptOutOfStockProductVariantsErrorQueryBuilder() : this("subscriptionBillingAttemptOutOfStockProductVariantsError")
        {
        }

        public SubscriptionBillingAttemptOutOfStockProductVariantsErrorQueryBuilder(string name) : base(new Query<SubscriptionBillingAttemptOutOfStockProductVariantsError>(name))
        {
        }

        public SubscriptionBillingAttemptOutOfStockProductVariantsErrorQueryBuilder(IQuery<SubscriptionBillingAttemptOutOfStockProductVariantsError> query) : base(query)
        {
        }

        public SubscriptionBillingAttemptOutOfStockProductVariantsErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public SubscriptionBillingAttemptOutOfStockProductVariantsErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }

        public SubscriptionBillingAttemptOutOfStockProductVariantsErrorQueryBuilder OutOfStockProductVariants(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantConnectionQueryBuilder> build)
        {
            var query = new Query<ProductVariantConnection>("outOfStockProductVariants");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariantConnection>(query);
            return this;
        }
    }
}