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
    public sealed class StandardMetafieldDefinitionEnablePayloadQueryBuilder : FieldsQueryBuilderBase<StandardMetafieldDefinitionEnablePayload, StandardMetafieldDefinitionEnablePayloadQueryBuilder>
    {
        protected override StandardMetafieldDefinitionEnablePayloadQueryBuilder Self => this;

        public StandardMetafieldDefinitionEnablePayloadQueryBuilder() : this("standardMetafieldDefinitionEnablePayload")
        {
        }

        public StandardMetafieldDefinitionEnablePayloadQueryBuilder(string name) : base(new Query<StandardMetafieldDefinitionEnablePayload>(name))
        {
        }

        public StandardMetafieldDefinitionEnablePayloadQueryBuilder(IQuery<StandardMetafieldDefinitionEnablePayload> query) : base(query)
        {
        }

        public StandardMetafieldDefinitionEnablePayloadQueryBuilder CreatedDefinition(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinition>("createdDefinition");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinition>(query);
            return this;
        }

        public StandardMetafieldDefinitionEnablePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StandardMetafieldDefinitionEnableUserErrorQueryBuilder> build)
        {
            var query = new Query<StandardMetafieldDefinitionEnableUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StandardMetafieldDefinitionEnableUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StandardMetafieldDefinitionEnableUserError>(query);
            return this;
        }
    }
}