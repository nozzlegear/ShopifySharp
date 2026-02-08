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
    public sealed class SubscriptionContractPauseOperationQueryBuilder : FieldsQueryBuilderBase<SubscriptionContractPausePayload, SubscriptionContractPauseOperationQueryBuilder>, IGraphOperationQueryBuilder<SubscriptionContractPausePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public SubscriptionContractPauseArgumentsBuilder Arguments { get; }
        protected override SubscriptionContractPauseOperationQueryBuilder Self => this;

        public SubscriptionContractPauseOperationQueryBuilder() : this("subscriptionContractPause")
        {
        }

        public SubscriptionContractPauseOperationQueryBuilder(string name) : base(new Query<SubscriptionContractPausePayload>(name))
        {
            Arguments = new SubscriptionContractPauseArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionContractPauseOperationQueryBuilder(IQuery<SubscriptionContractPausePayload> query) : base(query)
        {
            Arguments = new SubscriptionContractPauseArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionContractPauseOperationQueryBuilder Contract(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionContractQueryBuilder> build)
        {
            var query = new Query<SubscriptionContract>("contract");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionContractQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionContract>(query);
            return this;
        }

        public SubscriptionContractPauseOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionContractStatusUpdateUserErrorQueryBuilder> build)
        {
            var query = new Query<SubscriptionContractStatusUpdateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionContractStatusUpdateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionContractStatusUpdateUserError>(query);
            return this;
        }
    }
}