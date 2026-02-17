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
    public sealed class SubscriptionContractActivateOperationQueryBuilder : FieldsQueryBuilderBase<SubscriptionContractActivatePayload, SubscriptionContractActivateOperationQueryBuilder>, IGraphOperationQueryBuilder<SubscriptionContractActivatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public SubscriptionContractActivateArgumentsBuilder Arguments { get; }
        protected override SubscriptionContractActivateOperationQueryBuilder Self => this;

        public SubscriptionContractActivateOperationQueryBuilder() : this("subscriptionContractActivate")
        {
        }

        public SubscriptionContractActivateOperationQueryBuilder(string name) : base(new Query<SubscriptionContractActivatePayload>(name))
        {
            Arguments = new SubscriptionContractActivateArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionContractActivateOperationQueryBuilder(IQuery<SubscriptionContractActivatePayload> query) : base(query)
        {
            Arguments = new SubscriptionContractActivateArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionContractActivateOperationQueryBuilder Contract(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionContractQueryBuilder> build)
        {
            var query = new Query<SubscriptionContract>("contract");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionContractQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionContract>(query);
            return this;
        }

        public SubscriptionContractActivateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionContractStatusUpdateUserErrorQueryBuilder> build)
        {
            var query = new Query<SubscriptionContractStatusUpdateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionContractStatusUpdateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionContractStatusUpdateUserError>(query);
            return this;
        }
    }
}