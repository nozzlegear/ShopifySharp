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
    public sealed class StandardMetafieldDefinitionEnableUserErrorQueryBuilder : FieldsQueryBuilderBase<StandardMetafieldDefinitionEnableUserError, StandardMetafieldDefinitionEnableUserErrorQueryBuilder>
    {
        protected override StandardMetafieldDefinitionEnableUserErrorQueryBuilder Self => this;

        public StandardMetafieldDefinitionEnableUserErrorQueryBuilder() : this("standardMetafieldDefinitionEnableUserError")
        {
        }

        public StandardMetafieldDefinitionEnableUserErrorQueryBuilder(string name) : base(new Query<StandardMetafieldDefinitionEnableUserError>(name))
        {
        }

        public StandardMetafieldDefinitionEnableUserErrorQueryBuilder(IQuery<StandardMetafieldDefinitionEnableUserError> query) : base(query)
        {
        }

        public StandardMetafieldDefinitionEnableUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public StandardMetafieldDefinitionEnableUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public StandardMetafieldDefinitionEnableUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}