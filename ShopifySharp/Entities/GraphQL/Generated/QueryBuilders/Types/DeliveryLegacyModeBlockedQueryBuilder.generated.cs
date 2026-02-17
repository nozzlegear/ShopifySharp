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

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class DeliveryLegacyModeBlockedQueryBuilder : FieldsQueryBuilderBase<DeliveryLegacyModeBlocked, DeliveryLegacyModeBlockedQueryBuilder>
    {
        protected override DeliveryLegacyModeBlockedQueryBuilder Self => this;

        public DeliveryLegacyModeBlockedQueryBuilder() : this("deliveryLegacyModeBlocked")
        {
        }

        public DeliveryLegacyModeBlockedQueryBuilder(string name) : base(new Query<DeliveryLegacyModeBlocked>(name))
        {
        }

        public DeliveryLegacyModeBlockedQueryBuilder(IQuery<DeliveryLegacyModeBlocked> query) : base(query)
        {
        }

        public DeliveryLegacyModeBlockedQueryBuilder Blocked()
        {
            base.InnerQuery.AddField("blocked");
            return this;
        }

        public DeliveryLegacyModeBlockedQueryBuilder Reasons()
        {
            base.InnerQuery.AddField("reasons");
            return this;
        }
    }
}