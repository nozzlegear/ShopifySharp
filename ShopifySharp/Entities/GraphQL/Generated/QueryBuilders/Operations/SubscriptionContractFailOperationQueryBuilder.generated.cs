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
    public sealed class SubscriptionContractFailOperationQueryBuilder : FieldsQueryBuilderBase<SubscriptionContractFailPayload, SubscriptionContractFailOperationQueryBuilder>, IGraphOperationQueryBuilder<SubscriptionContractFailPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public SubscriptionContractFailArgumentsBuilder Arguments { get; }
        protected override SubscriptionContractFailOperationQueryBuilder Self => this;

        public SubscriptionContractFailOperationQueryBuilder() : this("subscriptionContractFail")
        {
        }

        public SubscriptionContractFailOperationQueryBuilder(string name) : base(new Query<SubscriptionContractFailPayload>(name))
        {
            Arguments = new SubscriptionContractFailArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionContractFailOperationQueryBuilder(IQuery<SubscriptionContractFailPayload> query) : base(query)
        {
            Arguments = new SubscriptionContractFailArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionContractFailOperationQueryBuilder Contract(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionContractQueryBuilder> build)
        {
            var query = new Query<SubscriptionContract>("contract");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionContractQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionContract>(query);
            return this;
        }

        public SubscriptionContractFailOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionContractStatusUpdateUserErrorQueryBuilder> build)
        {
            var query = new Query<SubscriptionContractStatusUpdateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionContractStatusUpdateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionContractStatusUpdateUserError>(query);
            return this;
        }
    }
}