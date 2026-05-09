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
    public sealed class SubscriptionBillingAttemptInventoryErrorQueryBuilder : FieldsQueryBuilderBase<SubscriptionBillingAttemptInventoryError, SubscriptionBillingAttemptInventoryErrorQueryBuilder>
    {
        protected override SubscriptionBillingAttemptInventoryErrorQueryBuilder Self => this;

        public SubscriptionBillingAttemptInventoryErrorQueryBuilder() : this("subscriptionBillingAttemptInventoryError")
        {
        }

        public SubscriptionBillingAttemptInventoryErrorQueryBuilder(string name) : base(new Query<SubscriptionBillingAttemptInventoryError>(name))
        {
        }

        public SubscriptionBillingAttemptInventoryErrorQueryBuilder(IQuery<SubscriptionBillingAttemptInventoryError> query) : base(query)
        {
        }

        public SubscriptionBillingAttemptInventoryErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public SubscriptionBillingAttemptInventoryErrorQueryBuilder InsufficientStockProductVariants(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantConnectionQueryBuilder> build)
        {
            var query = new Query<ProductVariantConnection>("insufficientStockProductVariants");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariantConnection>(query);
            return this;
        }
    }
}