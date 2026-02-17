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
    public sealed class SubscriptionDraftLineAddOperationQueryBuilder : FieldsQueryBuilderBase<SubscriptionDraftLineAddPayload, SubscriptionDraftLineAddOperationQueryBuilder>, IGraphOperationQueryBuilder<SubscriptionDraftLineAddPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public SubscriptionDraftLineAddArgumentsBuilder Arguments { get; }
        protected override SubscriptionDraftLineAddOperationQueryBuilder Self => this;

        public SubscriptionDraftLineAddOperationQueryBuilder() : this("subscriptionDraftLineAdd")
        {
        }

        public SubscriptionDraftLineAddOperationQueryBuilder(string name) : base(new Query<SubscriptionDraftLineAddPayload>(name))
        {
            Arguments = new SubscriptionDraftLineAddArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionDraftLineAddOperationQueryBuilder(IQuery<SubscriptionDraftLineAddPayload> query) : base(query)
        {
            Arguments = new SubscriptionDraftLineAddArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionDraftLineAddOperationQueryBuilder Draft(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDraftQueryBuilder> build)
        {
            var query = new Query<SubscriptionDraft>("draft");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDraftQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDraft>(query);
            return this;
        }

        public SubscriptionDraftLineAddOperationQueryBuilder LineAdded(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionLineQueryBuilder> build)
        {
            var query = new Query<SubscriptionLine>("lineAdded");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionLineQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionLine>(query);
            return this;
        }

        public SubscriptionDraftLineAddOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDraftUserErrorQueryBuilder> build)
        {
            var query = new Query<SubscriptionDraftUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDraftUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDraftUserError>(query);
            return this;
        }
    }
}