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
    public sealed class CommentEventEmbedMetafieldQueryBuilder : FieldsQueryBuilderBase<Metafield, CommentEventEmbedMetafieldQueryBuilder>, IHasArguments<CommentEventEmbedMetafieldArgumentsBuilder>
    {
        public CommentEventEmbedMetafieldArgumentsBuilder Arguments { get; }
        protected override CommentEventEmbedMetafieldQueryBuilder Self => this;

        public CommentEventEmbedMetafieldQueryBuilder(string name) : base(new Query<Metafield>(name))
        {
            Arguments = new CommentEventEmbedMetafieldArgumentsBuilder(base.InnerQuery);
        }

        public CommentEventEmbedMetafieldQueryBuilder(IQuery<Metafield> query) : base(query)
        {
            Arguments = new CommentEventEmbedMetafieldArgumentsBuilder(base.InnerQuery);
        }

        public CommentEventEmbedMetafieldQueryBuilder SetArguments(Action<CommentEventEmbedMetafieldArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CommentEventEmbedMetafieldQueryBuilder CompareDigest()
        {
            base.InnerQuery.AddField("compareDigest");
            return this;
        }

        public CommentEventEmbedMetafieldQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public CommentEventEmbedMetafieldQueryBuilder Definition(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinition>("definition");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinition>(query);
            return this;
        }

        [Obsolete("This field will be removed in a future release. Use the `description` on the metafield definition instead. ")]
        public CommentEventEmbedMetafieldQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public CommentEventEmbedMetafieldQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CommentEventEmbedMetafieldQueryBuilder JsonValue()
        {
            base.InnerQuery.AddField("jsonValue");
            return this;
        }

        public CommentEventEmbedMetafieldQueryBuilder Key()
        {
            base.InnerQuery.AddField("key");
            return this;
        }

        public CommentEventEmbedMetafieldQueryBuilder LegacyResourceId()
        {
            base.InnerQuery.AddField("legacyResourceId");
            return this;
        }

        public CommentEventEmbedMetafieldQueryBuilder Namespace()
        {
            base.InnerQuery.AddField("namespace");
            return this;
        }

        public CommentEventEmbedMetafieldQueryBuilder OwnerType()
        {
            base.InnerQuery.AddField("ownerType");
            return this;
        }

        public CommentEventEmbedMetafieldQueryBuilder References(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldReferenceConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldReferenceConnection>("references");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldReferenceConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldReferenceConnection>(query);
            return this;
        }

        public CommentEventEmbedMetafieldQueryBuilder SizeInBytes()
        {
            base.InnerQuery.AddField("sizeInBytes");
            return this;
        }

        public CommentEventEmbedMetafieldQueryBuilder Translations(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TranslationQueryBuilder> build)
        {
            var query = new Query<Translation>("translations");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TranslationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Translation>(query);
            return this;
        }

        public CommentEventEmbedMetafieldQueryBuilder Type()
        {
            base.InnerQuery.AddField("type");
            return this;
        }

        public CommentEventEmbedMetafieldQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public CommentEventEmbedMetafieldQueryBuilder Value()
        {
            base.InnerQuery.AddField("value");
            return this;
        }

        public CommentEventEmbedMetafieldQueryBuilder Reference(Action<MetafieldReferenceUnionCasesBuilder> build)
        {
            var query = new Query<MetafieldReference>("reference");
            var unionBuilder = new MetafieldReferenceUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }

        public CommentEventEmbedMetafieldQueryBuilder Owner(Action<HasMetafieldsInterfaceCasesBuilder> build)
        {
            var query = new Query<IHasMetafields>("owner");
            var unionBuilder = new HasMetafieldsInterfaceCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }
    }
}