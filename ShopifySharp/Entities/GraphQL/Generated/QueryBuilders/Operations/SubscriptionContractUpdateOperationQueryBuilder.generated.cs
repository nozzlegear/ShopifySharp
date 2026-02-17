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
    public sealed class SubscriptionContractUpdateOperationQueryBuilder : FieldsQueryBuilderBase<SubscriptionContractUpdatePayload, SubscriptionContractUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<SubscriptionContractUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public SubscriptionContractUpdateArgumentsBuilder Arguments { get; }
        protected override SubscriptionContractUpdateOperationQueryBuilder Self => this;

        public SubscriptionContractUpdateOperationQueryBuilder() : this("subscriptionContractUpdate")
        {
        }

        public SubscriptionContractUpdateOperationQueryBuilder(string name) : base(new Query<SubscriptionContractUpdatePayload>(name))
        {
            Arguments = new SubscriptionContractUpdateArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionContractUpdateOperationQueryBuilder(IQuery<SubscriptionContractUpdatePayload> query) : base(query)
        {
            Arguments = new SubscriptionContractUpdateArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionContractUpdateOperationQueryBuilder Draft(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDraftQueryBuilder> build)
        {
            var query = new Query<SubscriptionDraft>("draft");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDraftQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDraft>(query);
            return this;
        }

        public SubscriptionContractUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDraftUserErrorQueryBuilder> build)
        {
            var query = new Query<SubscriptionDraftUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDraftUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDraftUserError>(query);
            return this;
        }
    }
}