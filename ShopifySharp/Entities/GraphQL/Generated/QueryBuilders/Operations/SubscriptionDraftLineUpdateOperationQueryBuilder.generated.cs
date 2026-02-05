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
    public sealed class SubscriptionDraftLineUpdateOperationQueryBuilder : FieldsQueryBuilderBase<SubscriptionDraftLineUpdatePayload, SubscriptionDraftLineUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<SubscriptionDraftLineUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public SubscriptionDraftLineUpdateArgumentsBuilder Arguments { get; }
        protected override SubscriptionDraftLineUpdateOperationQueryBuilder Self => this;

        public SubscriptionDraftLineUpdateOperationQueryBuilder() : this("subscriptionDraftLineUpdate")
        {
        }

        public SubscriptionDraftLineUpdateOperationQueryBuilder(string name) : base(new Query<SubscriptionDraftLineUpdatePayload>(name))
        {
            Arguments = new SubscriptionDraftLineUpdateArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionDraftLineUpdateOperationQueryBuilder(IQuery<SubscriptionDraftLineUpdatePayload> query) : base(query)
        {
            Arguments = new SubscriptionDraftLineUpdateArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionDraftLineUpdateOperationQueryBuilder Draft(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftQueryBuilder> build)
        {
            var query = new Query<SubscriptionDraft>("draft");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDraft>(query);
            return this;
        }

        public SubscriptionDraftLineUpdateOperationQueryBuilder LineUpdated(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionLineQueryBuilder> build)
        {
            var query = new Query<SubscriptionLine>("lineUpdated");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionLineQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionLine>(query);
            return this;
        }

        public SubscriptionDraftLineUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftUserErrorQueryBuilder> build)
        {
            var query = new Query<SubscriptionDraftUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDraftUserError>(query);
            return this;
        }
    }
}