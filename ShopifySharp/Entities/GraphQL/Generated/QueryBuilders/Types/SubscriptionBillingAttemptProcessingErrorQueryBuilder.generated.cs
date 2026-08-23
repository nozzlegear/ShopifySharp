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
    public sealed class SubscriptionBillingAttemptProcessingErrorQueryBuilder : FieldsQueryBuilderBase<ISubscriptionBillingAttemptProcessingError, SubscriptionBillingAttemptProcessingErrorQueryBuilder>
    {
        protected override SubscriptionBillingAttemptProcessingErrorQueryBuilder Self => this;

        public SubscriptionBillingAttemptProcessingErrorQueryBuilder() : this("subscriptionBillingAttemptProcessingError")
        {
        }

        public SubscriptionBillingAttemptProcessingErrorQueryBuilder(string name) : base(new Query<ISubscriptionBillingAttemptProcessingError>(name))
        {
        }

        public SubscriptionBillingAttemptProcessingErrorQueryBuilder(IQuery<ISubscriptionBillingAttemptProcessingError> query) : base(query)
        {
        }

        public SubscriptionBillingAttemptProcessingErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public SubscriptionBillingAttemptProcessingErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }

        public SubscriptionBillingAttemptProcessingErrorQueryBuilder OnSubscriptionBillingAttemptGenericError(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingAttemptGenericErrorQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingAttemptGenericError>("... on SubscriptionBillingAttemptGenericError");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingAttemptGenericErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public SubscriptionBillingAttemptProcessingErrorQueryBuilder OnSubscriptionBillingAttemptInsufficientStockProductVariantsError(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingAttemptInsufficientStockProductVariantsErrorQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingAttemptInsufficientStockProductVariantsError>("... on SubscriptionBillingAttemptInsufficientStockProductVariantsError");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingAttemptInsufficientStockProductVariantsErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public SubscriptionBillingAttemptProcessingErrorQueryBuilder OnSubscriptionBillingAttemptOutOfStockProductVariantsError(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingAttemptOutOfStockProductVariantsErrorQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingAttemptOutOfStockProductVariantsError>("... on SubscriptionBillingAttemptOutOfStockProductVariantsError");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingAttemptOutOfStockProductVariantsErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public SubscriptionBillingAttemptProcessingErrorQueryBuilder SubscriptionBillingAttemptProcessingError(Action<SubscriptionBillingAttemptProcessingErrorInterfaceCasesBuilder> build)
        {
            var query = new Query<ISubscriptionBillingAttemptProcessingError>("subscriptionBillingAttemptProcessingError");
            var unionBuilder = new SubscriptionBillingAttemptProcessingErrorInterfaceCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }
    }
}