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
    public sealed class OrderAttributionDefinitionQueryBuilder : FieldsQueryBuilderBase<OrderAttributionDefinition, OrderAttributionDefinitionQueryBuilder>
    {
        protected override OrderAttributionDefinitionQueryBuilder Self => this;

        public OrderAttributionDefinitionQueryBuilder() : this("orderAttributionDefinition")
        {
        }

        public OrderAttributionDefinitionQueryBuilder(string name) : base(new Query<OrderAttributionDefinition>(name))
        {
        }

        public OrderAttributionDefinitionQueryBuilder(IQuery<OrderAttributionDefinition> query) : base(query)
        {
        }

        public OrderAttributionDefinitionQueryBuilder DisplayName()
        {
            base.InnerQuery.AddField("displayName");
            return this;
        }

        public OrderAttributionDefinitionQueryBuilder Handle()
        {
            base.InnerQuery.AddField("handle");
            return this;
        }

        public OrderAttributionDefinitionQueryBuilder Icon()
        {
            base.InnerQuery.AddField("icon");
            return this;
        }

        public OrderAttributionDefinitionQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }
    }
}