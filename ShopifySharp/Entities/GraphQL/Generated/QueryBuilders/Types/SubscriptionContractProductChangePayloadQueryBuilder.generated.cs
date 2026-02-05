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
    public sealed class SubscriptionContractProductChangePayloadQueryBuilder : FieldsQueryBuilderBase<SubscriptionContractProductChangePayload, SubscriptionContractProductChangePayloadQueryBuilder>
    {
        protected override SubscriptionContractProductChangePayloadQueryBuilder Self => this;

        public SubscriptionContractProductChangePayloadQueryBuilder() : this("subscriptionContractProductChangePayload")
        {
        }

        public SubscriptionContractProductChangePayloadQueryBuilder(string name) : base(new Query<SubscriptionContractProductChangePayload>(name))
        {
        }

        public SubscriptionContractProductChangePayloadQueryBuilder(IQuery<SubscriptionContractProductChangePayload> query) : base(query)
        {
        }

        public SubscriptionContractProductChangePayloadQueryBuilder Contract(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionContractQueryBuilder> build)
        {
            var query = new Query<SubscriptionContract>("contract");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionContractQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionContract>(query);
            return this;
        }

        public SubscriptionContractProductChangePayloadQueryBuilder LineUpdated(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionLineQueryBuilder> build)
        {
            var query = new Query<SubscriptionLine>("lineUpdated");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionLineQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionLine>(query);
            return this;
        }

        public SubscriptionContractProductChangePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftUserErrorQueryBuilder> build)
        {
            var query = new Query<SubscriptionDraftUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDraftUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDraftUserError>(query);
            return this;
        }
    }
}