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
    public sealed class GiftCardCashOutTransactionMetafieldQueryBuilder : FieldsQueryBuilderBase<Metafield, GiftCardCashOutTransactionMetafieldQueryBuilder>, IHasArguments<GiftCardCashOutTransactionMetafieldArgumentsBuilder>
    {
        public GiftCardCashOutTransactionMetafieldArgumentsBuilder Arguments { get; }
        protected override GiftCardCashOutTransactionMetafieldQueryBuilder Self => this;

        public GiftCardCashOutTransactionMetafieldQueryBuilder(string name) : base(new Query<Metafield>(name))
        {
            Arguments = new GiftCardCashOutTransactionMetafieldArgumentsBuilder(base.InnerQuery);
        }

        public GiftCardCashOutTransactionMetafieldQueryBuilder(IQuery<Metafield> query) : base(query)
        {
            Arguments = new GiftCardCashOutTransactionMetafieldArgumentsBuilder(base.InnerQuery);
        }

        public GiftCardCashOutTransactionMetafieldQueryBuilder SetArguments(Action<GiftCardCashOutTransactionMetafieldArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public GiftCardCashOutTransactionMetafieldQueryBuilder CompareDigest()
        {
            base.InnerQuery.AddField("compareDigest");
            return this;
        }

        public GiftCardCashOutTransactionMetafieldQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public GiftCardCashOutTransactionMetafieldQueryBuilder Definition(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinition>("definition");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinition>(query);
            return this;
        }

        [Obsolete("This field will be removed in a future release. Use the `description` on the metafield definition instead. ")]
        public GiftCardCashOutTransactionMetafieldQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public GiftCardCashOutTransactionMetafieldQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public GiftCardCashOutTransactionMetafieldQueryBuilder JsonValue()
        {
            base.InnerQuery.AddField("jsonValue");
            return this;
        }

        public GiftCardCashOutTransactionMetafieldQueryBuilder Key()
        {
            base.InnerQuery.AddField("key");
            return this;
        }

        public GiftCardCashOutTransactionMetafieldQueryBuilder LegacyResourceId()
        {
            base.InnerQuery.AddField("legacyResourceId");
            return this;
        }

        public GiftCardCashOutTransactionMetafieldQueryBuilder Namespace()
        {
            base.InnerQuery.AddField("namespace");
            return this;
        }

        public GiftCardCashOutTransactionMetafieldQueryBuilder OwnerType()
        {
            base.InnerQuery.AddField("ownerType");
            return this;
        }

        public GiftCardCashOutTransactionMetafieldQueryBuilder References(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldReferenceConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldReferenceConnection>("references");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldReferenceConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldReferenceConnection>(query);
            return this;
        }

        public GiftCardCashOutTransactionMetafieldQueryBuilder SizeInBytes()
        {
            base.InnerQuery.AddField("sizeInBytes");
            return this;
        }

        public GiftCardCashOutTransactionMetafieldQueryBuilder Translations(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TranslationQueryBuilder> build)
        {
            var query = new Query<Translation>("translations");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TranslationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Translation>(query);
            return this;
        }

        public GiftCardCashOutTransactionMetafieldQueryBuilder Type()
        {
            base.InnerQuery.AddField("type");
            return this;
        }

        public GiftCardCashOutTransactionMetafieldQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public GiftCardCashOutTransactionMetafieldQueryBuilder Value()
        {
            base.InnerQuery.AddField("value");
            return this;
        }

        public GiftCardCashOutTransactionMetafieldQueryBuilder Reference(Action<MetafieldReferenceUnionCasesBuilder> build)
        {
            var query = new Query<MetafieldReference>("reference");
            var unionBuilder = new MetafieldReferenceUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }

        public GiftCardCashOutTransactionMetafieldQueryBuilder Owner(Action<HasMetafieldsInterfaceCasesBuilder> build)
        {
            var query = new Query<IHasMetafields>("owner");
            var unionBuilder = new HasMetafieldsInterfaceCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }
    }
}