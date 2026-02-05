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
    public sealed class WebhookSubscriptionsCountOperationQueryBuilder : FieldsQueryBuilderBase<Count, WebhookSubscriptionsCountOperationQueryBuilder>, IGraphOperationQueryBuilder<Count>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public WebhookSubscriptionsCountArgumentsBuilder Arguments { get; }
        protected override WebhookSubscriptionsCountOperationQueryBuilder Self => this;

        public WebhookSubscriptionsCountOperationQueryBuilder() : this("webhookSubscriptionsCount")
        {
        }

        public WebhookSubscriptionsCountOperationQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new WebhookSubscriptionsCountArgumentsBuilder(base.InnerQuery);
        }

        public WebhookSubscriptionsCountOperationQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new WebhookSubscriptionsCountArgumentsBuilder(base.InnerQuery);
        }

        public WebhookSubscriptionsCountOperationQueryBuilder Count()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public WebhookSubscriptionsCountOperationQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}