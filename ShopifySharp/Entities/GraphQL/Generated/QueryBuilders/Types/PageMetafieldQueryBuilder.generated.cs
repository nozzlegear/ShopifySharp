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
    public sealed class PageMetafieldQueryBuilder : FieldsQueryBuilderBase<Metafield, PageMetafieldQueryBuilder>, IHasArguments<PageMetafieldArgumentsBuilder>
    {
        public PageMetafieldArgumentsBuilder Arguments { get; }
        protected override PageMetafieldQueryBuilder Self => this;

        public PageMetafieldQueryBuilder(string name) : base(new Query<Metafield>(name))
        {
            Arguments = new PageMetafieldArgumentsBuilder(base.InnerQuery);
        }

        public PageMetafieldQueryBuilder(IQuery<Metafield> query) : base(query)
        {
            Arguments = new PageMetafieldArgumentsBuilder(base.InnerQuery);
        }

        public PageMetafieldQueryBuilder SetArguments(Action<PageMetafieldArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public PageMetafieldQueryBuilder CompareDigest()
        {
            base.InnerQuery.AddField("compareDigest");
            return this;
        }

        public PageMetafieldQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public PageMetafieldQueryBuilder Definition(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinition>("definition");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinition>(query);
            return this;
        }

        [Obsolete("This field will be removed in a future release. Use the `description` on the metafield definition instead. ")]
        public PageMetafieldQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public PageMetafieldQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public PageMetafieldQueryBuilder JsonValue()
        {
            base.InnerQuery.AddField("jsonValue");
            return this;
        }

        public PageMetafieldQueryBuilder Key()
        {
            base.InnerQuery.AddField("key");
            return this;
        }

        public PageMetafieldQueryBuilder LegacyResourceId()
        {
            base.InnerQuery.AddField("legacyResourceId");
            return this;
        }

        public PageMetafieldQueryBuilder Namespace()
        {
            base.InnerQuery.AddField("namespace");
            return this;
        }

        public PageMetafieldQueryBuilder Owner(Action<ShopifySharp.GraphQL.QueryBuilders.Types.HasMetafieldsQueryBuilder> build)
        {
            var query = new Query<IHasMetafields>("owner");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.HasMetafieldsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IHasMetafields>(query);
            return this;
        }

        public PageMetafieldQueryBuilder OwnerType()
        {
            base.InnerQuery.AddField("ownerType");
            return this;
        }

        public PageMetafieldQueryBuilder References(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldReferenceConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldReferenceConnection>("references");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldReferenceConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldReferenceConnection>(query);
            return this;
        }

        public PageMetafieldQueryBuilder Type()
        {
            base.InnerQuery.AddField("type");
            return this;
        }

        public PageMetafieldQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public PageMetafieldQueryBuilder Value()
        {
            base.InnerQuery.AddField("value");
            return this;
        }

        public PageMetafieldQueryBuilder Reference(Action<MetafieldReferenceUnionCasesBuilder> build)
        {
            var query = new Query<MetafieldReference>("reference");
            var unionBuilder = new MetafieldReferenceUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}