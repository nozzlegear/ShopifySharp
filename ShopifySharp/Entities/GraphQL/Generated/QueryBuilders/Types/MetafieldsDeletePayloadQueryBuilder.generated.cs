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
    public sealed class MetafieldsDeletePayloadQueryBuilder : FieldsQueryBuilderBase<MetafieldsDeletePayload, MetafieldsDeletePayloadQueryBuilder>
    {
        protected override MetafieldsDeletePayloadQueryBuilder Self => this;

        public MetafieldsDeletePayloadQueryBuilder() : this("metafieldsDeletePayload")
        {
        }

        public MetafieldsDeletePayloadQueryBuilder(string name) : base(new Query<MetafieldsDeletePayload>(name))
        {
        }

        public MetafieldsDeletePayloadQueryBuilder(IQuery<MetafieldsDeletePayload> query) : base(query)
        {
        }

        public MetafieldsDeletePayloadQueryBuilder DeletedMetafields(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldIdentifierQueryBuilder> build)
        {
            var query = new Query<MetafieldIdentifier>("deletedMetafields");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldIdentifierQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldIdentifier>(query);
            return this;
        }

        public MetafieldsDeletePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}