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
    public sealed class MetaobjectDefinitionCreatePayloadQueryBuilder : FieldsQueryBuilderBase<MetaobjectDefinitionCreatePayload, MetaobjectDefinitionCreatePayloadQueryBuilder>
    {
        protected override MetaobjectDefinitionCreatePayloadQueryBuilder Self => this;

        public MetaobjectDefinitionCreatePayloadQueryBuilder() : this("metaobjectDefinitionCreatePayload")
        {
        }

        public MetaobjectDefinitionCreatePayloadQueryBuilder(string name) : base(new Query<MetaobjectDefinitionCreatePayload>(name))
        {
        }

        public MetaobjectDefinitionCreatePayloadQueryBuilder(IQuery<MetaobjectDefinitionCreatePayload> query) : base(query)
        {
        }

        public MetaobjectDefinitionCreatePayloadQueryBuilder MetaobjectDefinition(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectDefinitionQueryBuilder> build)
        {
            var query = new Query<MetaobjectDefinition>("metaobjectDefinition");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectDefinition>(query);
            return this;
        }

        public MetaobjectDefinitionCreatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectUserErrorQueryBuilder> build)
        {
            var query = new Query<MetaobjectUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectUserError>(query);
            return this;
        }
    }
}