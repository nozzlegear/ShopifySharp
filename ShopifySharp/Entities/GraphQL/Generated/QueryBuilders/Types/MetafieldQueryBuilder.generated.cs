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
    public sealed class MetafieldQueryBuilder : FieldsQueryBuilderBase<Metafield, MetafieldQueryBuilder>
    {
        protected override MetafieldQueryBuilder Self => this;

        public MetafieldQueryBuilder() : this("metafield")
        {
        }

        public MetafieldQueryBuilder(string name) : base(new Query<Metafield>(name))
        {
        }

        public MetafieldQueryBuilder(IQuery<Metafield> query) : base(query)
        {
        }

        public MetafieldQueryBuilder CompareDigest()
        {
            base.InnerQuery.AddField("compareDigest");
            return this;
        }

        public MetafieldQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public MetafieldQueryBuilder Definition(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinition>("definition");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinition>(query);
            return this;
        }

        [Obsolete("This field will be removed in a future release. Use the `description` on the metafield definition instead. ")]
        public MetafieldQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public MetafieldQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public MetafieldQueryBuilder JsonValue()
        {
            base.InnerQuery.AddField("jsonValue");
            return this;
        }

        public MetafieldQueryBuilder Key()
        {
            base.InnerQuery.AddField("key");
            return this;
        }

        public MetafieldQueryBuilder LegacyResourceId()
        {
            base.InnerQuery.AddField("legacyResourceId");
            return this;
        }

        public MetafieldQueryBuilder Namespace()
        {
            base.InnerQuery.AddField("namespace");
            return this;
        }

        public MetafieldQueryBuilder Owner(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.HasMetafieldsQueryBuilder> build)
        {
            var query = new Query<IHasMetafields>("owner");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.HasMetafieldsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IHasMetafields>(query);
            return this;
        }

        public MetafieldQueryBuilder OwnerType()
        {
            base.InnerQuery.AddField("ownerType");
            return this;
        }

        public MetafieldQueryBuilder References(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldReferenceConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldReferenceConnection>("references");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldReferenceConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldReferenceConnection>(query);
            return this;
        }

        public MetafieldQueryBuilder Type()
        {
            base.InnerQuery.AddField("type");
            return this;
        }

        public MetafieldQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public MetafieldQueryBuilder Value()
        {
            base.InnerQuery.AddField("value");
            return this;
        }

        public MetafieldQueryBuilder Reference(Action<MetafieldReferenceUnionCasesBuilder> build)
        {
            var query = new Query<MetafieldReference>("reference");
            var unionBuilder = new MetafieldReferenceUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}