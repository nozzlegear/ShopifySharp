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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class MetafieldDefinitionOperationQueryBuilder : FieldsQueryBuilderBase<MetafieldDefinition, MetafieldDefinitionOperationQueryBuilder>, IGraphOperationQueryBuilder<MetafieldDefinition>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public MetafieldDefinitionArgumentsBuilder Arguments { get; }
        protected override MetafieldDefinitionOperationQueryBuilder Self => this;

        public MetafieldDefinitionOperationQueryBuilder() : this("metafieldDefinition")
        {
        }

        public MetafieldDefinitionOperationQueryBuilder(string name) : base(new Query<MetafieldDefinition>(name))
        {
            Arguments = new MetafieldDefinitionArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldDefinitionOperationQueryBuilder(IQuery<MetafieldDefinition> query) : base(query)
        {
            Arguments = new MetafieldDefinitionArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldDefinitionOperationQueryBuilder Access(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldAccessQueryBuilder> build)
        {
            var query = new Query<MetafieldAccess>("access");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldAccessQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldAccess>(query);
            return this;
        }

        public MetafieldDefinitionOperationQueryBuilder Capabilities(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldCapabilitiesQueryBuilder> build)
        {
            var query = new Query<MetafieldCapabilities>("capabilities");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldCapabilitiesQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldCapabilities>(query);
            return this;
        }

        public MetafieldDefinitionOperationQueryBuilder Constraints(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionConstraintsQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionConstraints>("constraints");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionConstraintsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionConstraints>(query);
            return this;
        }

        public MetafieldDefinitionOperationQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public MetafieldDefinitionOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public MetafieldDefinitionOperationQueryBuilder Key()
        {
            base.InnerQuery.AddField("key");
            return this;
        }

        public MetafieldDefinitionOperationQueryBuilder Metafields(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldConnection>("metafields");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldConnection>(query);
            return this;
        }

        public MetafieldDefinitionOperationQueryBuilder MetafieldsCount()
        {
            base.InnerQuery.AddField("metafieldsCount");
            return this;
        }

        public MetafieldDefinitionOperationQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public MetafieldDefinitionOperationQueryBuilder Namespace()
        {
            base.InnerQuery.AddField("namespace");
            return this;
        }

        public MetafieldDefinitionOperationQueryBuilder OwnerType()
        {
            base.InnerQuery.AddField("ownerType");
            return this;
        }

        public MetafieldDefinitionOperationQueryBuilder PinnedPosition()
        {
            base.InnerQuery.AddField("pinnedPosition");
            return this;
        }

        public MetafieldDefinitionOperationQueryBuilder StandardTemplate(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StandardMetafieldDefinitionTemplateQueryBuilder> build)
        {
            var query = new Query<StandardMetafieldDefinitionTemplate>("standardTemplate");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StandardMetafieldDefinitionTemplateQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StandardMetafieldDefinitionTemplate>(query);
            return this;
        }

        public MetafieldDefinitionOperationQueryBuilder Type(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionTypeQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionType>("type");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionTypeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionType>(query);
            return this;
        }

        public MetafieldDefinitionOperationQueryBuilder UseAsCollectionCondition()
        {
            base.InnerQuery.AddField("useAsCollectionCondition");
            return this;
        }

        public MetafieldDefinitionOperationQueryBuilder Validations(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionValidationQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionValidation>("validations");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionValidationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionValidation>(query);
            return this;
        }

        public MetafieldDefinitionOperationQueryBuilder ValidationStatus()
        {
            base.InnerQuery.AddField("validationStatus");
            return this;
        }
    }
}