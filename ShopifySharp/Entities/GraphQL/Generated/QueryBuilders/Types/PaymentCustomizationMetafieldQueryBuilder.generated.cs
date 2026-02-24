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
    public sealed class PaymentCustomizationMetafieldQueryBuilder : FieldsQueryBuilderBase<Metafield, PaymentCustomizationMetafieldQueryBuilder>, IHasArguments<PaymentCustomizationMetafieldArgumentsBuilder>
    {
        public PaymentCustomizationMetafieldArgumentsBuilder Arguments { get; }
        protected override PaymentCustomizationMetafieldQueryBuilder Self => this;

        public PaymentCustomizationMetafieldQueryBuilder(string name) : base(new Query<Metafield>(name))
        {
            Arguments = new PaymentCustomizationMetafieldArgumentsBuilder(base.InnerQuery);
        }

        public PaymentCustomizationMetafieldQueryBuilder(IQuery<Metafield> query) : base(query)
        {
            Arguments = new PaymentCustomizationMetafieldArgumentsBuilder(base.InnerQuery);
        }

        public PaymentCustomizationMetafieldQueryBuilder SetArguments(Action<PaymentCustomizationMetafieldArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public PaymentCustomizationMetafieldQueryBuilder CompareDigest()
        {
            base.InnerQuery.AddField("compareDigest");
            return this;
        }

        public PaymentCustomizationMetafieldQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public PaymentCustomizationMetafieldQueryBuilder Definition(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinition>("definition");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinition>(query);
            return this;
        }

        [Obsolete("This field will be removed in a future release. Use the `description` on the metafield definition instead. ")]
        public PaymentCustomizationMetafieldQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public PaymentCustomizationMetafieldQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public PaymentCustomizationMetafieldQueryBuilder JsonValue()
        {
            base.InnerQuery.AddField("jsonValue");
            return this;
        }

        public PaymentCustomizationMetafieldQueryBuilder Key()
        {
            base.InnerQuery.AddField("key");
            return this;
        }

        public PaymentCustomizationMetafieldQueryBuilder LegacyResourceId()
        {
            base.InnerQuery.AddField("legacyResourceId");
            return this;
        }

        public PaymentCustomizationMetafieldQueryBuilder Namespace()
        {
            base.InnerQuery.AddField("namespace");
            return this;
        }

        public PaymentCustomizationMetafieldQueryBuilder Owner(Action<ShopifySharp.GraphQL.QueryBuilders.Types.HasMetafieldsQueryBuilder> build)
        {
            var query = new Query<IHasMetafields>("owner");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.HasMetafieldsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IHasMetafields>(query);
            return this;
        }

        public PaymentCustomizationMetafieldQueryBuilder OwnerType()
        {
            base.InnerQuery.AddField("ownerType");
            return this;
        }

        public PaymentCustomizationMetafieldQueryBuilder References(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldReferenceConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldReferenceConnection>("references");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldReferenceConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldReferenceConnection>(query);
            return this;
        }

        public PaymentCustomizationMetafieldQueryBuilder Type()
        {
            base.InnerQuery.AddField("type");
            return this;
        }

        public PaymentCustomizationMetafieldQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public PaymentCustomizationMetafieldQueryBuilder Value()
        {
            base.InnerQuery.AddField("value");
            return this;
        }

        public PaymentCustomizationMetafieldQueryBuilder Reference(Action<MetafieldReferenceUnionCasesBuilder> build)
        {
            var query = new Query<MetafieldReference>("reference");
            var unionBuilder = new MetafieldReferenceUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}