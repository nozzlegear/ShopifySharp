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
    public sealed class OrderAttributionDefinitionDeleteUserErrorQueryBuilder : FieldsQueryBuilderBase<OrderAttributionDefinitionDeleteUserError, OrderAttributionDefinitionDeleteUserErrorQueryBuilder>
    {
        protected override OrderAttributionDefinitionDeleteUserErrorQueryBuilder Self => this;

        public OrderAttributionDefinitionDeleteUserErrorQueryBuilder() : this("orderAttributionDefinitionDeleteUserError")
        {
        }

        public OrderAttributionDefinitionDeleteUserErrorQueryBuilder(string name) : base(new Query<OrderAttributionDefinitionDeleteUserError>(name))
        {
        }

        public OrderAttributionDefinitionDeleteUserErrorQueryBuilder(IQuery<OrderAttributionDefinitionDeleteUserError> query) : base(query)
        {
        }

        public OrderAttributionDefinitionDeleteUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public OrderAttributionDefinitionDeleteUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public OrderAttributionDefinitionDeleteUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}