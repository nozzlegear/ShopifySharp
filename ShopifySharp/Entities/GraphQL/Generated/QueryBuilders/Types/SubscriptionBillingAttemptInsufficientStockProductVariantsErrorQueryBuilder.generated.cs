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
    public sealed class SubscriptionBillingAttemptInsufficientStockProductVariantsErrorQueryBuilder : FieldsQueryBuilderBase<SubscriptionBillingAttemptInsufficientStockProductVariantsError, SubscriptionBillingAttemptInsufficientStockProductVariantsErrorQueryBuilder>
    {
        protected override SubscriptionBillingAttemptInsufficientStockProductVariantsErrorQueryBuilder Self => this;

        public SubscriptionBillingAttemptInsufficientStockProductVariantsErrorQueryBuilder() : this("subscriptionBillingAttemptInsufficientStockProductVariantsError")
        {
        }

        public SubscriptionBillingAttemptInsufficientStockProductVariantsErrorQueryBuilder(string name) : base(new Query<SubscriptionBillingAttemptInsufficientStockProductVariantsError>(name))
        {
        }

        public SubscriptionBillingAttemptInsufficientStockProductVariantsErrorQueryBuilder(IQuery<SubscriptionBillingAttemptInsufficientStockProductVariantsError> query) : base(query)
        {
        }

        public SubscriptionBillingAttemptInsufficientStockProductVariantsErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public SubscriptionBillingAttemptInsufficientStockProductVariantsErrorQueryBuilder InsufficientStockProductVariants(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantConnectionQueryBuilder> build)
        {
            var query = new Query<ProductVariantConnection>("insufficientStockProductVariants");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariantConnection>(query);
            return this;
        }

        public SubscriptionBillingAttemptInsufficientStockProductVariantsErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}