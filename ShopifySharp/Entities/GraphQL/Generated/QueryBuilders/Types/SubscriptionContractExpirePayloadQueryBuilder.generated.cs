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
    public sealed class SubscriptionContractExpirePayloadQueryBuilder : FieldsQueryBuilderBase<SubscriptionContractExpirePayload, SubscriptionContractExpirePayloadQueryBuilder>
    {
        protected override SubscriptionContractExpirePayloadQueryBuilder Self => this;

        public SubscriptionContractExpirePayloadQueryBuilder() : this("subscriptionContractExpirePayload")
        {
        }

        public SubscriptionContractExpirePayloadQueryBuilder(string name) : base(new Query<SubscriptionContractExpirePayload>(name))
        {
        }

        public SubscriptionContractExpirePayloadQueryBuilder(IQuery<SubscriptionContractExpirePayload> query) : base(query)
        {
        }

        public SubscriptionContractExpirePayloadQueryBuilder Contract(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionContractQueryBuilder> build)
        {
            var query = new Query<SubscriptionContract>("contract");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionContractQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionContract>(query);
            return this;
        }

        public SubscriptionContractExpirePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionContractStatusUpdateUserErrorQueryBuilder> build)
        {
            var query = new Query<SubscriptionContractStatusUpdateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionContractStatusUpdateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionContractStatusUpdateUserError>(query);
            return this;
        }
    }
}