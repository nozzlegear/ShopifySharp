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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class SubscriptionContractCancelPayloadQueryBuilder : FieldsQueryBuilderBase<SubscriptionContractCancelPayload, SubscriptionContractCancelPayloadQueryBuilder>
    {
        protected override SubscriptionContractCancelPayloadQueryBuilder Self => this;

        public SubscriptionContractCancelPayloadQueryBuilder() : this("subscriptionContractCancelPayload")
        {
        }

        public SubscriptionContractCancelPayloadQueryBuilder(string name) : base(new Query<SubscriptionContractCancelPayload>(name))
        {
        }

        public SubscriptionContractCancelPayloadQueryBuilder(IQuery<SubscriptionContractCancelPayload> query) : base(query)
        {
        }

        public SubscriptionContractCancelPayloadQueryBuilder Contract(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionContractQueryBuilder> build)
        {
            var query = new Query<SubscriptionContract>("contract");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionContractQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionContract>(query);
            return this;
        }

        public SubscriptionContractCancelPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionContractStatusUpdateUserErrorQueryBuilder> build)
        {
            var query = new Query<SubscriptionContractStatusUpdateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionContractStatusUpdateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionContractStatusUpdateUserError>(query);
            return this;
        }
    }
}