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
    public sealed class OrderAttributionDefinitionUpsertUserErrorQueryBuilder : FieldsQueryBuilderBase<OrderAttributionDefinitionUpsertUserError, OrderAttributionDefinitionUpsertUserErrorQueryBuilder>
    {
        protected override OrderAttributionDefinitionUpsertUserErrorQueryBuilder Self => this;

        public OrderAttributionDefinitionUpsertUserErrorQueryBuilder() : this("orderAttributionDefinitionUpsertUserError")
        {
        }

        public OrderAttributionDefinitionUpsertUserErrorQueryBuilder(string name) : base(new Query<OrderAttributionDefinitionUpsertUserError>(name))
        {
        }

        public OrderAttributionDefinitionUpsertUserErrorQueryBuilder(IQuery<OrderAttributionDefinitionUpsertUserError> query) : base(query)
        {
        }

        public OrderAttributionDefinitionUpsertUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public OrderAttributionDefinitionUpsertUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public OrderAttributionDefinitionUpsertUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}