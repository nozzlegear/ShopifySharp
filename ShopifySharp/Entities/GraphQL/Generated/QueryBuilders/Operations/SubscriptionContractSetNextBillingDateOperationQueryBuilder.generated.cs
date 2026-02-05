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
    public sealed class SubscriptionContractSetNextBillingDateOperationQueryBuilder : FieldsQueryBuilderBase<SubscriptionContractSetNextBillingDatePayload, SubscriptionContractSetNextBillingDateOperationQueryBuilder>, IGraphOperationQueryBuilder<SubscriptionContractSetNextBillingDatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public SubscriptionContractSetNextBillingDateArgumentsBuilder Arguments { get; }
        protected override SubscriptionContractSetNextBillingDateOperationQueryBuilder Self => this;

        public SubscriptionContractSetNextBillingDateOperationQueryBuilder() : this("subscriptionContractSetNextBillingDate")
        {
        }

        public SubscriptionContractSetNextBillingDateOperationQueryBuilder(string name) : base(new Query<SubscriptionContractSetNextBillingDatePayload>(name))
        {
            Arguments = new SubscriptionContractSetNextBillingDateArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionContractSetNextBillingDateOperationQueryBuilder(IQuery<SubscriptionContractSetNextBillingDatePayload> query) : base(query)
        {
            Arguments = new SubscriptionContractSetNextBillingDateArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionContractSetNextBillingDateOperationQueryBuilder Contract(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionContractQueryBuilder> build)
        {
            var query = new Query<SubscriptionContract>("contract");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionContractQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionContract>(query);
            return this;
        }

        public SubscriptionContractSetNextBillingDateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionContractUserErrorQueryBuilder> build)
        {
            var query = new Query<SubscriptionContractUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionContractUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionContractUserError>(query);
            return this;
        }
    }
}