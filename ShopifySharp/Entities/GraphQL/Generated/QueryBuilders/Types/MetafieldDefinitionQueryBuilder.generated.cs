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
    public sealed class MetafieldDefinitionQueryBuilder : FieldsQueryBuilderBase<MetafieldDefinition, MetafieldDefinitionQueryBuilder>
    {
        protected override MetafieldDefinitionQueryBuilder Self => this;

        public MetafieldDefinitionQueryBuilder() : this("metafieldDefinition")
        {
        }

        public MetafieldDefinitionQueryBuilder(string name) : base(new Query<MetafieldDefinition>(name))
        {
        }

        public MetafieldDefinitionQueryBuilder(IQuery<MetafieldDefinition> query) : base(query)
        {
        }

        public MetafieldDefinitionQueryBuilder Access(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldAccessQueryBuilder> build)
        {
            var query = new Query<MetafieldAccess>("access");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldAccessQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldAccess>(query);
            return this;
        }

        public MetafieldDefinitionQueryBuilder Capabilities(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldCapabilitiesQueryBuilder> build)
        {
            var query = new Query<MetafieldCapabilities>("capabilities");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldCapabilitiesQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldCapabilities>(query);
            return this;
        }

        public MetafieldDefinitionQueryBuilder Constraints(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionConstraintsQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionConstraints>("constraints");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionConstraintsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionConstraints>(query);
            return this;
        }

        public MetafieldDefinitionQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public MetafieldDefinitionQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public MetafieldDefinitionQueryBuilder Key()
        {
            base.InnerQuery.AddField("key");
            return this;
        }

        public MetafieldDefinitionQueryBuilder Metafields(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldConnection>("metafields");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldConnection>(query);
            return this;
        }

        public MetafieldDefinitionQueryBuilder MetafieldsCount()
        {
            base.InnerQuery.AddField("metafieldsCount");
            return this;
        }

        public MetafieldDefinitionQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public MetafieldDefinitionQueryBuilder Namespace()
        {
            base.InnerQuery.AddField("namespace");
            return this;
        }

        public MetafieldDefinitionQueryBuilder OwnerType()
        {
            base.InnerQuery.AddField("ownerType");
            return this;
        }

        public MetafieldDefinitionQueryBuilder PinnedPosition()
        {
            base.InnerQuery.AddField("pinnedPosition");
            return this;
        }

        public MetafieldDefinitionQueryBuilder StandardTemplate(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StandardMetafieldDefinitionTemplateQueryBuilder> build)
        {
            var query = new Query<StandardMetafieldDefinitionTemplate>("standardTemplate");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StandardMetafieldDefinitionTemplateQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StandardMetafieldDefinitionTemplate>(query);
            return this;
        }

        public MetafieldDefinitionQueryBuilder Type(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionTypeQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionType>("type");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionTypeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionType>(query);
            return this;
        }

        public MetafieldDefinitionQueryBuilder UseAsCollectionCondition()
        {
            base.InnerQuery.AddField("useAsCollectionCondition");
            return this;
        }

        public MetafieldDefinitionQueryBuilder Validations(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionValidationQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionValidation>("validations");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionValidationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionValidation>(query);
            return this;
        }

        public MetafieldDefinitionQueryBuilder ValidationStatus()
        {
            base.InnerQuery.AddField("validationStatus");
            return this;
        }
    }
}