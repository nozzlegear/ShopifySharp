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
    public sealed class WebhookSubscriptionDeleteOperationQueryBuilder : FieldsQueryBuilderBase<WebhookSubscriptionDeletePayload, WebhookSubscriptionDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<WebhookSubscriptionDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public WebhookSubscriptionDeleteArgumentsBuilder Arguments { get; }
        protected override WebhookSubscriptionDeleteOperationQueryBuilder Self => this;

        public WebhookSubscriptionDeleteOperationQueryBuilder() : this("webhookSubscriptionDelete")
        {
        }

        public WebhookSubscriptionDeleteOperationQueryBuilder(string name) : base(new Query<WebhookSubscriptionDeletePayload>(name))
        {
            Arguments = new WebhookSubscriptionDeleteArgumentsBuilder(base.InnerQuery);
        }

        public WebhookSubscriptionDeleteOperationQueryBuilder(IQuery<WebhookSubscriptionDeletePayload> query) : base(query)
        {
            Arguments = new WebhookSubscriptionDeleteArgumentsBuilder(base.InnerQuery);
        }

        public WebhookSubscriptionDeleteOperationQueryBuilder DeletedWebhookSubscriptionId()
        {
            base.InnerQuery.AddField("deletedWebhookSubscriptionId");
            return this;
        }

        public WebhookSubscriptionDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}