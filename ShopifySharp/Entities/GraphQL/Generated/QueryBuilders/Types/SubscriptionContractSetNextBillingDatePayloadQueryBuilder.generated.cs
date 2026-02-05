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
    public sealed class SubscriptionContractSetNextBillingDatePayloadQueryBuilder : FieldsQueryBuilderBase<SubscriptionContractSetNextBillingDatePayload, SubscriptionContractSetNextBillingDatePayloadQueryBuilder>
    {
        protected override SubscriptionContractSetNextBillingDatePayloadQueryBuilder Self => this;

        public SubscriptionContractSetNextBillingDatePayloadQueryBuilder() : this("subscriptionContractSetNextBillingDatePayload")
        {
        }

        public SubscriptionContractSetNextBillingDatePayloadQueryBuilder(string name) : base(new Query<SubscriptionContractSetNextBillingDatePayload>(name))
        {
        }

        public SubscriptionContractSetNextBillingDatePayloadQueryBuilder(IQuery<SubscriptionContractSetNextBillingDatePayload> query) : base(query)
        {
        }

        public SubscriptionContractSetNextBillingDatePayloadQueryBuilder Contract(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionContractQueryBuilder> build)
        {
            var query = new Query<SubscriptionContract>("contract");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionContractQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionContract>(query);
            return this;
        }

        public SubscriptionContractSetNextBillingDatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionContractUserErrorQueryBuilder> build)
        {
            var query = new Query<SubscriptionContractUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionContractUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionContractUserError>(query);
            return this;
        }
    }
}