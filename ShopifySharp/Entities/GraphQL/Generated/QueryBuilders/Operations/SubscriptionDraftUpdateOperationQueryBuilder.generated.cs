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
    public sealed class SubscriptionDraftUpdateOperationQueryBuilder : FieldsQueryBuilderBase<SubscriptionDraftUpdatePayload, SubscriptionDraftUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<SubscriptionDraftUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public SubscriptionDraftUpdateArgumentsBuilder Arguments { get; }
        protected override SubscriptionDraftUpdateOperationQueryBuilder Self => this;

        public SubscriptionDraftUpdateOperationQueryBuilder() : this("subscriptionDraftUpdate")
        {
        }

        public SubscriptionDraftUpdateOperationQueryBuilder(string name) : base(new Query<SubscriptionDraftUpdatePayload>(name))
        {
            Arguments = new SubscriptionDraftUpdateArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionDraftUpdateOperationQueryBuilder(IQuery<SubscriptionDraftUpdatePayload> query) : base(query)
        {
            Arguments = new SubscriptionDraftUpdateArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionDraftUpdateOperationQueryBuilder Draft(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftQueryBuilder> build)
        {
            var query = new Query<SubscriptionDraft>("draft");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDraft>(query);
            return this;
        }

        public SubscriptionDraftUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftUserErrorQueryBuilder> build)
        {
            var query = new Query<SubscriptionDraftUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDraftUserError>(query);
            return this;
        }
    }
}