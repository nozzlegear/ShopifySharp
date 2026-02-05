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
    public sealed class SubscriptionContractCancelOperationQueryBuilder : FieldsQueryBuilderBase<SubscriptionContractCancelPayload, SubscriptionContractCancelOperationQueryBuilder>, IGraphOperationQueryBuilder<SubscriptionContractCancelPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public SubscriptionContractCancelArgumentsBuilder Arguments { get; }
        protected override SubscriptionContractCancelOperationQueryBuilder Self => this;

        public SubscriptionContractCancelOperationQueryBuilder() : this("subscriptionContractCancel")
        {
        }

        public SubscriptionContractCancelOperationQueryBuilder(string name) : base(new Query<SubscriptionContractCancelPayload>(name))
        {
            Arguments = new SubscriptionContractCancelArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionContractCancelOperationQueryBuilder(IQuery<SubscriptionContractCancelPayload> query) : base(query)
        {
            Arguments = new SubscriptionContractCancelArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionContractCancelOperationQueryBuilder Contract(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionContractQueryBuilder> build)
        {
            var query = new Query<SubscriptionContract>("contract");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionContractQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionContract>(query);
            return this;
        }

        public SubscriptionContractCancelOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionContractStatusUpdateUserErrorQueryBuilder> build)
        {
            var query = new Query<SubscriptionContractStatusUpdateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionContractStatusUpdateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionContractStatusUpdateUserError>(query);
            return this;
        }
    }
}