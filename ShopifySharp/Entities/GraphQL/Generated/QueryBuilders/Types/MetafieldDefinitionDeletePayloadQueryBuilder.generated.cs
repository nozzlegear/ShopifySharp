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
    public sealed class MetafieldDefinitionDeletePayloadQueryBuilder : FieldsQueryBuilderBase<MetafieldDefinitionDeletePayload, MetafieldDefinitionDeletePayloadQueryBuilder>
    {
        protected override MetafieldDefinitionDeletePayloadQueryBuilder Self => this;

        public MetafieldDefinitionDeletePayloadQueryBuilder() : this("metafieldDefinitionDeletePayload")
        {
        }

        public MetafieldDefinitionDeletePayloadQueryBuilder(string name) : base(new Query<MetafieldDefinitionDeletePayload>(name))
        {
        }

        public MetafieldDefinitionDeletePayloadQueryBuilder(IQuery<MetafieldDefinitionDeletePayload> query) : base(query)
        {
        }

        public MetafieldDefinitionDeletePayloadQueryBuilder DeletedDefinition(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionIdentifierQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionIdentifier>("deletedDefinition");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionIdentifierQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionIdentifier>(query);
            return this;
        }

        public MetafieldDefinitionDeletePayloadQueryBuilder DeletedDefinitionId()
        {
            base.InnerQuery.AddField("deletedDefinitionId");
            return this;
        }

        public MetafieldDefinitionDeletePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionDeleteUserErrorQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionDeleteUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionDeleteUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionDeleteUserError>(query);
            return this;
        }
    }
}