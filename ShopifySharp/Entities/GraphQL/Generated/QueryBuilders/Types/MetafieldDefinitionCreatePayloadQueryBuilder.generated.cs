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
    public sealed class MetafieldDefinitionCreatePayloadQueryBuilder : FieldsQueryBuilderBase<MetafieldDefinitionCreatePayload, MetafieldDefinitionCreatePayloadQueryBuilder>
    {
        protected override MetafieldDefinitionCreatePayloadQueryBuilder Self => this;

        public MetafieldDefinitionCreatePayloadQueryBuilder() : this("metafieldDefinitionCreatePayload")
        {
        }

        public MetafieldDefinitionCreatePayloadQueryBuilder(string name) : base(new Query<MetafieldDefinitionCreatePayload>(name))
        {
        }

        public MetafieldDefinitionCreatePayloadQueryBuilder(IQuery<MetafieldDefinitionCreatePayload> query) : base(query)
        {
        }

        public MetafieldDefinitionCreatePayloadQueryBuilder CreatedDefinition(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinition>("createdDefinition");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinition>(query);
            return this;
        }

        public MetafieldDefinitionCreatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionCreateUserErrorQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionCreateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionCreateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionCreateUserError>(query);
            return this;
        }
    }
}