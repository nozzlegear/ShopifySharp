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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class SubscriptionBillingAttemptProcessingErrorInterfaceCasesBuilder : InterfaceCasesBuilderBase<ISubscriptionBillingAttemptProcessingError, SubscriptionBillingAttemptProcessingErrorInterfaceCasesBuilder>
    {
        protected override SubscriptionBillingAttemptProcessingErrorInterfaceCasesBuilder Self => this;

        public SubscriptionBillingAttemptProcessingErrorInterfaceCasesBuilder(string fieldName = "processingError") : this(new Query<ISubscriptionBillingAttemptProcessingError>(fieldName))
        {
        }

        public SubscriptionBillingAttemptProcessingErrorInterfaceCasesBuilder(IQuery<ISubscriptionBillingAttemptProcessingError> query) : base(query)
        {
        }

        public SubscriptionBillingAttemptProcessingErrorInterfaceCasesBuilder OnSubscriptionBillingAttemptGenericError(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingAttemptGenericErrorQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingAttemptGenericError>("... on SubscriptionBillingAttemptGenericError");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingAttemptGenericErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public SubscriptionBillingAttemptProcessingErrorInterfaceCasesBuilder OnSubscriptionBillingAttemptInsufficientStockProductVariantsError(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingAttemptInsufficientStockProductVariantsErrorQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingAttemptInsufficientStockProductVariantsError>("... on SubscriptionBillingAttemptInsufficientStockProductVariantsError");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingAttemptInsufficientStockProductVariantsErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public SubscriptionBillingAttemptProcessingErrorInterfaceCasesBuilder OnSubscriptionBillingAttemptOutOfStockProductVariantsError(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingAttemptOutOfStockProductVariantsErrorQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingAttemptOutOfStockProductVariantsError>("... on SubscriptionBillingAttemptOutOfStockProductVariantsError");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingAttemptOutOfStockProductVariantsErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}