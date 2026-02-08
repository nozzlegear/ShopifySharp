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
    public sealed class SubscriptionContractProductChangeOperationQueryBuilder : FieldsQueryBuilderBase<SubscriptionContractProductChangePayload, SubscriptionContractProductChangeOperationQueryBuilder>, IGraphOperationQueryBuilder<SubscriptionContractProductChangePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public SubscriptionContractProductChangeArgumentsBuilder Arguments { get; }
        protected override SubscriptionContractProductChangeOperationQueryBuilder Self => this;

        public SubscriptionContractProductChangeOperationQueryBuilder() : this("subscriptionContractProductChange")
        {
        }

        public SubscriptionContractProductChangeOperationQueryBuilder(string name) : base(new Query<SubscriptionContractProductChangePayload>(name))
        {
            Arguments = new SubscriptionContractProductChangeArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionContractProductChangeOperationQueryBuilder(IQuery<SubscriptionContractProductChangePayload> query) : base(query)
        {
            Arguments = new SubscriptionContractProductChangeArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionContractProductChangeOperationQueryBuilder Contract(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionContractQueryBuilder> build)
        {
            var query = new Query<SubscriptionContract>("contract");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionContractQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionContract>(query);
            return this;
        }

        public SubscriptionContractProductChangeOperationQueryBuilder LineUpdated(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionLineQueryBuilder> build)
        {
            var query = new Query<SubscriptionLine>("lineUpdated");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionLineQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionLine>(query);
            return this;
        }

        public SubscriptionContractProductChangeOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftUserErrorQueryBuilder> build)
        {
            var query = new Query<SubscriptionDraftUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDraftUserError>(query);
            return this;
        }
    }
}