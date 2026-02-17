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

        public SubscriptionContractCreateOperationQueryBuilder Draft(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDraftQueryBuilder> build)
        {
            var query = new Query<SubscriptionDraft>("draft");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDraftQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDraft>(query);
            return this;
        }

        public SubscriptionContractCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDraftUserErrorQueryBuilder> build)
        {
            var query = new Query<SubscriptionDraftUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDraftUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDraftUserError>(query);
            return this;
        }
    }
}