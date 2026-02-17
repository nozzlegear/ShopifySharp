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
    public sealed class WebhookSubscriptionCreateOperationQueryBuilder : FieldsQueryBuilderBase<WebhookSubscriptionCreatePayload, WebhookSubscriptionCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<WebhookSubscriptionCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public WebhookSubscriptionCreateArgumentsBuilder Arguments { get; }
        protected override WebhookSubscriptionCreateOperationQueryBuilder Self => this;

        public WebhookSubscriptionCreateOperationQueryBuilder() : this("webhookSubscriptionCreate")
        {
        }

        public WebhookSubscriptionCreateOperationQueryBuilder(string name) : base(new Query<WebhookSubscriptionCreatePayload>(name))
        {
            Arguments = new WebhookSubscriptionCreateArgumentsBuilder(base.InnerQuery);
        }

        public WebhookSubscriptionCreateOperationQueryBuilder(IQuery<WebhookSubscriptionCreatePayload> query) : base(query)
        {
            Arguments = new WebhookSubscriptionCreateArgumentsBuilder(base.InnerQuery);
        }

        public WebhookSubscriptionCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }

        public WebhookSubscriptionCreateOperationQueryBuilder WebhookSubscription(Action<ShopifySharp.GraphQL.QueryBuilders.Types.WebhookSubscriptionQueryBuilder> build)
        {
            var query = new Query<WebhookSubscription>("webhookSubscription");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.WebhookSubscriptionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<WebhookSubscription>(query);
            return this;
        }
    }
}