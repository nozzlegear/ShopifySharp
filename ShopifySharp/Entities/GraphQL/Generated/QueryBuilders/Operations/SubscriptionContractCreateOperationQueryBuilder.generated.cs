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
    public sealed class SubscriptionContractCreateOperationQueryBuilder : FieldsQueryBuilderBase<SubscriptionContractCreatePayload, SubscriptionContractCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<SubscriptionContractCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public SubscriptionContractCreateArgumentsBuilder Arguments { get; }
        protected override SubscriptionContractCreateOperationQueryBuilder Self => this;

        public SubscriptionContractCreateOperationQueryBuilder() : this("subscriptionContractCreate")
        {
        }

        public SubscriptionContractCreateOperationQueryBuilder(string name) : base(new Query<SubscriptionContractCreatePayload>(name))
        {
            Arguments = new SubscriptionContractCreateArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionContractCreateOperationQueryBuilder(IQuery<SubscriptionContractCreatePayload> query) : base(query)
        {
            Arguments = new SubscriptionContractCreateArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionContractCreateOperationQueryBuilder Draft(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftQueryBuilder> build)
        {
            var query = new Query<SubscriptionDraft>("draft");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDraft>(query);
            return this;
        }

        public SubscriptionContractCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftUserErrorQueryBuilder> build)
        {
            var query = new Query<SubscriptionDraftUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDraftUserError>(query);
            return this;
        }
    }
}