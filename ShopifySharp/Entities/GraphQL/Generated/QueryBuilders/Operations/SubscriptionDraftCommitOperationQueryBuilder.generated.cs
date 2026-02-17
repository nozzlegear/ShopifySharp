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
    public sealed class SubscriptionDraftCommitOperationQueryBuilder : FieldsQueryBuilderBase<SubscriptionDraftCommitPayload, SubscriptionDraftCommitOperationQueryBuilder>, IGraphOperationQueryBuilder<SubscriptionDraftCommitPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public SubscriptionDraftCommitArgumentsBuilder Arguments { get; }
        protected override SubscriptionDraftCommitOperationQueryBuilder Self => this;

        public SubscriptionDraftCommitOperationQueryBuilder() : this("subscriptionDraftCommit")
        {
        }

        public SubscriptionDraftCommitOperationQueryBuilder(string name) : base(new Query<SubscriptionDraftCommitPayload>(name))
        {
            Arguments = new SubscriptionDraftCommitArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionDraftCommitOperationQueryBuilder(IQuery<SubscriptionDraftCommitPayload> query) : base(query)
        {
            Arguments = new SubscriptionDraftCommitArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionDraftCommitOperationQueryBuilder Contract(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionContractQueryBuilder> build)
        {
            var query = new Query<SubscriptionContract>("contract");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionContractQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionContract>(query);
            return this;
        }

        public SubscriptionDraftCommitOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDraftUserErrorQueryBuilder> build)
        {
            var query = new Query<SubscriptionDraftUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDraftUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDraftUserError>(query);
            return this;
        }
    }
}