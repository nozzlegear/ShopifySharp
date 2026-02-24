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
    public sealed class FulfillmentConstraintRuleMetafieldQueryBuilder : FieldsQueryBuilderBase<Metafield, FulfillmentConstraintRuleMetafieldQueryBuilder>, IHasArguments<FulfillmentConstraintRuleMetafieldArgumentsBuilder>
    {
        public FulfillmentConstraintRuleMetafieldArgumentsBuilder Arguments { get; }
        protected override FulfillmentConstraintRuleMetafieldQueryBuilder Self => this;

        public FulfillmentConstraintRuleMetafieldQueryBuilder(string name) : base(new Query<Metafield>(name))
        {
            Arguments = new FulfillmentConstraintRuleMetafieldArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentConstraintRuleMetafieldQueryBuilder(IQuery<Metafield> query) : base(query)
        {
            Arguments = new FulfillmentConstraintRuleMetafieldArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentConstraintRuleMetafieldQueryBuilder SetArguments(Action<FulfillmentConstraintRuleMetafieldArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public FulfillmentConstraintRuleMetafieldQueryBuilder CompareDigest()
        {
            base.InnerQuery.AddField("compareDigest");
            return this;
        }

        public FulfillmentConstraintRuleMetafieldQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public FulfillmentConstraintRuleMetafieldQueryBuilder Definition(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinition>("definition");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinition>(query);
            return this;
        }

        [Obsolete("This field will be removed in a future release. Use the `description` on the metafield definition instead. ")]
        public FulfillmentConstraintRuleMetafieldQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public FulfillmentConstraintRuleMetafieldQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public FulfillmentConstraintRuleMetafieldQueryBuilder JsonValue()
        {
            base.InnerQuery.AddField("jsonValue");
            return this;
        }

        public FulfillmentConstraintRuleMetafieldQueryBuilder Key()
        {
            base.InnerQuery.AddField("key");
            return this;
        }

        public FulfillmentConstraintRuleMetafieldQueryBuilder LegacyResourceId()
        {
            base.InnerQuery.AddField("legacyResourceId");
            return this;
        }

        public FulfillmentConstraintRuleMetafieldQueryBuilder Namespace()
        {
            base.InnerQuery.AddField("namespace");
            return this;
        }

        public FulfillmentConstraintRuleMetafieldQueryBuilder Owner(Action<ShopifySharp.GraphQL.QueryBuilders.Types.HasMetafieldsQueryBuilder> build)
        {
            var query = new Query<IHasMetafields>("owner");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.HasMetafieldsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IHasMetafields>(query);
            return this;
        }

        public FulfillmentConstraintRuleMetafieldQueryBuilder OwnerType()
        {
            base.InnerQuery.AddField("ownerType");
            return this;
        }

        public FulfillmentConstraintRuleMetafieldQueryBuilder References(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldReferenceConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldReferenceConnection>("references");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldReferenceConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldReferenceConnection>(query);
            return this;
        }

        public FulfillmentConstraintRuleMetafieldQueryBuilder Type()
        {
            base.InnerQuery.AddField("type");
            return this;
        }

        public FulfillmentConstraintRuleMetafieldQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public FulfillmentConstraintRuleMetafieldQueryBuilder Value()
        {
            base.InnerQuery.AddField("value");
            return this;
        }

        public FulfillmentConstraintRuleMetafieldQueryBuilder Reference(Action<MetafieldReferenceUnionCasesBuilder> build)
        {
            var query = new Query<MetafieldReference>("reference");
            var unionBuilder = new MetafieldReferenceUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}