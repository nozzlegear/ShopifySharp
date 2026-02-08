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
    public sealed class SubscriptionContractAtomicCreatePayloadQueryBuilder : FieldsQueryBuilderBase<SubscriptionContractAtomicCreatePayload, SubscriptionContractAtomicCreatePayloadQueryBuilder>
    {
        protected override SubscriptionContractAtomicCreatePayloadQueryBuilder Self => this;

        public SubscriptionContractAtomicCreatePayloadQueryBuilder() : this("subscriptionContractAtomicCreatePayload")
        {
        }

        public SubscriptionContractAtomicCreatePayloadQueryBuilder(string name) : base(new Query<SubscriptionContractAtomicCreatePayload>(name))
        {
        }

        public SubscriptionContractAtomicCreatePayloadQueryBuilder(IQuery<SubscriptionContractAtomicCreatePayload> query) : base(query)
        {
        }

        public SubscriptionContractAtomicCreatePayloadQueryBuilder Contract(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionContractQueryBuilder> build)
        {
            var query = new Query<SubscriptionContract>("contract");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionContractQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionContract>(query);
            return this;
        }

        public SubscriptionContractAtomicCreatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftUserErrorQueryBuilder> build)
        {
            var query = new Query<SubscriptionDraftUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDraftUserError>(query);
            return this;
        }
    }
}