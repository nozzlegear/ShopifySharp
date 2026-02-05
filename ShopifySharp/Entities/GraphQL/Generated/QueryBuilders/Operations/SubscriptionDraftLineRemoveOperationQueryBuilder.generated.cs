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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class SubscriptionDraftLineRemoveOperationQueryBuilder : FieldsQueryBuilderBase<SubscriptionDraftLineRemovePayload, SubscriptionDraftLineRemoveOperationQueryBuilder>, IGraphOperationQueryBuilder<SubscriptionDraftLineRemovePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public SubscriptionDraftLineRemoveArgumentsBuilder Arguments { get; }
        protected override SubscriptionDraftLineRemoveOperationQueryBuilder Self => this;

        public SubscriptionDraftLineRemoveOperationQueryBuilder() : this("subscriptionDraftLineRemove")
        {
        }

        public SubscriptionDraftLineRemoveOperationQueryBuilder(string name) : base(new Query<SubscriptionDraftLineRemovePayload>(name))
        {
            Arguments = new SubscriptionDraftLineRemoveArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionDraftLineRemoveOperationQueryBuilder(IQuery<SubscriptionDraftLineRemovePayload> query) : base(query)
        {
            Arguments = new SubscriptionDraftLineRemoveArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionDraftLineRemoveOperationQueryBuilder DiscountsUpdated(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionManualDiscountQueryBuilder> build)
        {
            var query = new Query<SubscriptionManualDiscount>("discountsUpdated");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionManualDiscountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionManualDiscount>(query);
            return this;
        }

        public SubscriptionDraftLineRemoveOperationQueryBuilder Draft(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftQueryBuilder> build)
        {
            var query = new Query<SubscriptionDraft>("draft");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDraft>(query);
            return this;
        }

        public SubscriptionDraftLineRemoveOperationQueryBuilder LineRemoved(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionLineQueryBuilder> build)
        {
            var query = new Query<SubscriptionLine>("lineRemoved");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionLineQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionLine>(query);
            return this;
        }

        public SubscriptionDraftLineRemoveOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftUserErrorQueryBuilder> build)
        {
            var query = new Query<SubscriptionDraftUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDraftUserError>(query);
            return this;
        }
    }
}