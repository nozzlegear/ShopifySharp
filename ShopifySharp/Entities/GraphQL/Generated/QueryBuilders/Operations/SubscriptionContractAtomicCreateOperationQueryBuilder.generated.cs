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
    public sealed class SubscriptionContractAtomicCreateOperationQueryBuilder : FieldsQueryBuilderBase<SubscriptionContractAtomicCreatePayload, SubscriptionContractAtomicCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<SubscriptionContractAtomicCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public SubscriptionContractAtomicCreateArgumentsBuilder Arguments { get; }
        protected override SubscriptionContractAtomicCreateOperationQueryBuilder Self => this;

        public SubscriptionContractAtomicCreateOperationQueryBuilder() : this("subscriptionContractAtomicCreate")
        {
        }

        public SubscriptionContractAtomicCreateOperationQueryBuilder(string name) : base(new Query<SubscriptionContractAtomicCreatePayload>(name))
        {
            Arguments = new SubscriptionContractAtomicCreateArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionContractAtomicCreateOperationQueryBuilder(IQuery<SubscriptionContractAtomicCreatePayload> query) : base(query)
        {
            Arguments = new SubscriptionContractAtomicCreateArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionContractAtomicCreateOperationQueryBuilder Contract(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionContractQueryBuilder> build)
        {
            var query = new Query<SubscriptionContract>("contract");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionContractQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionContract>(query);
            return this;
        }

        public SubscriptionContractAtomicCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDraftUserErrorQueryBuilder> build)
        {
            var query = new Query<SubscriptionDraftUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDraftUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDraftUserError>(query);
            return this;
        }
    }
}