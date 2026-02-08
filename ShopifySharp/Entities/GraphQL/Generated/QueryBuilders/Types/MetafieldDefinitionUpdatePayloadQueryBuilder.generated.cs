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
    public sealed class MetafieldDefinitionUpdatePayloadQueryBuilder : FieldsQueryBuilderBase<MetafieldDefinitionUpdatePayload, MetafieldDefinitionUpdatePayloadQueryBuilder>
    {
        protected override MetafieldDefinitionUpdatePayloadQueryBuilder Self => this;

        public MetafieldDefinitionUpdatePayloadQueryBuilder() : this("metafieldDefinitionUpdatePayload")
        {
        }

        public MetafieldDefinitionUpdatePayloadQueryBuilder(string name) : base(new Query<MetafieldDefinitionUpdatePayload>(name))
        {
        }

        public MetafieldDefinitionUpdatePayloadQueryBuilder(IQuery<MetafieldDefinitionUpdatePayload> query) : base(query)
        {
        }

        public MetafieldDefinitionUpdatePayloadQueryBuilder UpdatedDefinition(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinition>("updatedDefinition");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinition>(query);
            return this;
        }

        public MetafieldDefinitionUpdatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionUpdateUserErrorQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionUpdateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionUpdateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionUpdateUserError>(query);
            return this;
        }

        public MetafieldDefinitionUpdatePayloadQueryBuilder ValidationJob(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder> build)
        {
            var query = new Query<Job>("validationJob");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Job>(query);
            return this;
        }
    }
}