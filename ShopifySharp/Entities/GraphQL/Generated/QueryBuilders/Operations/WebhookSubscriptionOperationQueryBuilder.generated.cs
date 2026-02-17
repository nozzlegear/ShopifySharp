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
    public sealed class WebhookSubscriptionOperationQueryBuilder : FieldsQueryBuilderBase<WebhookSubscription, WebhookSubscriptionOperationQueryBuilder>, IGraphOperationQueryBuilder<WebhookSubscription>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public WebhookSubscriptionArgumentsBuilder Arguments { get; }
        protected override WebhookSubscriptionOperationQueryBuilder Self => this;

        public WebhookSubscriptionOperationQueryBuilder() : this("webhookSubscription")
        {
        }

        public WebhookSubscriptionOperationQueryBuilder(string name) : base(new Query<WebhookSubscription>(name))
        {
            Arguments = new WebhookSubscriptionArgumentsBuilder(base.InnerQuery);
        }

        public WebhookSubscriptionOperationQueryBuilder(IQuery<WebhookSubscription> query) : base(query)
        {
            Arguments = new WebhookSubscriptionArgumentsBuilder(base.InnerQuery);
        }

        public WebhookSubscriptionOperationQueryBuilder ApiVersion(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ApiVersionQueryBuilder> build)
        {
            var query = new Query<ApiVersion>("apiVersion");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ApiVersionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ApiVersion>(query);
            return this;
        }

        [Obsolete("Use `uri` instead.")]
        public WebhookSubscriptionOperationQueryBuilder CallbackUrl()
        {
            base.InnerQuery.AddField("callbackUrl");
            return this;
        }

        public WebhookSubscriptionOperationQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public WebhookSubscriptionOperationQueryBuilder Filter()
        {
            base.InnerQuery.AddField("filter");
            return this;
        }

        public WebhookSubscriptionOperationQueryBuilder Format()
        {
            base.InnerQuery.AddField("format");
            return this;
        }

        public WebhookSubscriptionOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public WebhookSubscriptionOperationQueryBuilder IncludeFields()
        {
            base.InnerQuery.AddField("includeFields");
            return this;
        }

        public WebhookSubscriptionOperationQueryBuilder LegacyResourceId()
        {
            base.InnerQuery.AddField("legacyResourceId");
            return this;
        }

        public WebhookSubscriptionOperationQueryBuilder MetafieldNamespaces()
        {
            base.InnerQuery.AddField("metafieldNamespaces");
            return this;
        }

        public WebhookSubscriptionOperationQueryBuilder Metafields(Action<ShopifySharp.GraphQL.QueryBuilders.Types.WebhookSubscriptionMetafieldIdentifierQueryBuilder> build)
        {
            var query = new Query<WebhookSubscriptionMetafieldIdentifier>("metafields");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.WebhookSubscriptionMetafieldIdentifierQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<WebhookSubscriptionMetafieldIdentifier>(query);
            return this;
        }

        public WebhookSubscriptionOperationQueryBuilder Topic()
        {
            base.InnerQuery.AddField("topic");
            return this;
        }

        public WebhookSubscriptionOperationQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public WebhookSubscriptionOperationQueryBuilder Uri()
        {
            base.InnerQuery.AddField("uri");
            return this;
        }

        [Obsolete("Use `uri` instead.")]
        public WebhookSubscriptionOperationQueryBuilder Endpoint(Action<WebhookSubscriptionEndpointUnionCasesBuilder> build)
        {
            var query = new Query<WebhookSubscriptionEndpoint>("endpoint");
            var unionBuilder = new WebhookSubscriptionEndpointUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}