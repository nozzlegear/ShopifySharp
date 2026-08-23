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
    public sealed class OrderAttributionQueryBuilder : FieldsQueryBuilderBase<OrderAttribution, OrderAttributionQueryBuilder>
    {
        protected override OrderAttributionQueryBuilder Self => this;

        public OrderAttributionQueryBuilder() : this("orderAttribution")
        {
        }

        public OrderAttributionQueryBuilder(string name) : base(new Query<OrderAttribution>(name))
        {
        }

        public OrderAttributionQueryBuilder(IQuery<OrderAttribution> query) : base(query)
        {
        }

        public OrderAttributionQueryBuilder DisplayName()
        {
            base.InnerQuery.AddField("displayName");
            return this;
        }

        public OrderAttributionQueryBuilder Handle()
        {
            base.InnerQuery.AddField("handle");
            return this;
        }

        public OrderAttributionQueryBuilder Icon()
        {
            base.InnerQuery.AddField("icon");
            return this;
        }
    }
}