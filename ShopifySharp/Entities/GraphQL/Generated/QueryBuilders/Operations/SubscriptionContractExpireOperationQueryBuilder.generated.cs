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
    public sealed class SubscriptionContractExpireOperationQueryBuilder : FieldsQueryBuilderBase<SubscriptionContractExpirePayload, SubscriptionContractExpireOperationQueryBuilder>, IGraphOperationQueryBuilder<SubscriptionContractExpirePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public SubscriptionContractExpireArgumentsBuilder Arguments { get; }
        protected override SubscriptionContractExpireOperationQueryBuilder Self => this;

        public SubscriptionContractExpireOperationQueryBuilder() : this("subscriptionContractExpire")
        {
        }

        public SubscriptionContractExpireOperationQueryBuilder(string name) : base(new Query<SubscriptionContractExpirePayload>(name))
        {
            Arguments = new SubscriptionContractExpireArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionContractExpireOperationQueryBuilder(IQuery<SubscriptionContractExpirePayload> query) : base(query)
        {
            Arguments = new SubscriptionContractExpireArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionContractExpireOperationQueryBuilder Contract(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionContractQueryBuilder> build)
        {
            var query = new Query<SubscriptionContract>("contract");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionContractQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionContract>(query);
            return this;
        }

        public SubscriptionContractExpireOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionContractStatusUpdateUserErrorQueryBuilder> build)
        {
            var query = new Query<SubscriptionContractStatusUpdateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionContractStatusUpdateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionContractStatusUpdateUserError>(query);
            return this;
        }
    }
}