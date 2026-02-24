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
    public sealed class QueryRootMetafieldDefinitionQueryBuilder : FieldsQueryBuilderBase<MetafieldDefinition, QueryRootMetafieldDefinitionQueryBuilder>, IHasArguments<QueryRootMetafieldDefinitionArgumentsBuilder>
    {
        public QueryRootMetafieldDefinitionArgumentsBuilder Arguments { get; }
        protected override QueryRootMetafieldDefinitionQueryBuilder Self => this;

        public QueryRootMetafieldDefinitionQueryBuilder(string name) : base(new Query<MetafieldDefinition>(name))
        {
            Arguments = new QueryRootMetafieldDefinitionArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootMetafieldDefinitionQueryBuilder(IQuery<MetafieldDefinition> query) : base(query)
        {
            Arguments = new QueryRootMetafieldDefinitionArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootMetafieldDefinitionQueryBuilder SetArguments(Action<QueryRootMetafieldDefinitionArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootMetafieldDefinitionQueryBuilder Access(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldAccessQueryBuilder> build)
        {
            var query = new Query<MetafieldAccess>("access");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldAccessQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldAccess>(query);
            return this;
        }

        public QueryRootMetafieldDefinitionQueryBuilder Capabilities(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldCapabilitiesQueryBuilder> build)
        {
            var query = new Query<MetafieldCapabilities>("capabilities");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldCapabilitiesQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldCapabilities>(query);
            return this;
        }

        public QueryRootMetafieldDefinitionQueryBuilder Constraints(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionConstraintsQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionConstraints>("constraints");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionConstraintsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionConstraints>(query);
            return this;
        }

        public QueryRootMetafieldDefinitionQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public QueryRootMetafieldDefinitionQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootMetafieldDefinitionQueryBuilder Key()
        {
            base.InnerQuery.AddField("key");
            return this;
        }

        public QueryRootMetafieldDefinitionQueryBuilder Metafields(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldConnection>("metafields");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldConnection>(query);
            return this;
        }

        public QueryRootMetafieldDefinitionQueryBuilder MetafieldsCount()
        {
            base.InnerQuery.AddField("metafieldsCount");
            return this;
        }

        public QueryRootMetafieldDefinitionQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public QueryRootMetafieldDefinitionQueryBuilder Namespace()
        {
            base.InnerQuery.AddField("namespace");
            return this;
        }

        public QueryRootMetafieldDefinitionQueryBuilder OwnerType()
        {
            base.InnerQuery.AddField("ownerType");
            return this;
        }

        public QueryRootMetafieldDefinitionQueryBuilder PinnedPosition()
        {
            base.InnerQuery.AddField("pinnedPosition");
            return this;
        }

        public QueryRootMetafieldDefinitionQueryBuilder StandardTemplate(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StandardMetafieldDefinitionTemplateQueryBuilder> build)
        {
            var query = new Query<StandardMetafieldDefinitionTemplate>("standardTemplate");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StandardMetafieldDefinitionTemplateQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StandardMetafieldDefinitionTemplate>(query);
            return this;
        }

        public QueryRootMetafieldDefinitionQueryBuilder Type(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionTypeQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionType>("type");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionTypeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionType>(query);
            return this;
        }

        public QueryRootMetafieldDefinitionQueryBuilder UseAsCollectionCondition()
        {
            base.InnerQuery.AddField("useAsCollectionCondition");
            return this;
        }

        public QueryRootMetafieldDefinitionQueryBuilder Validations(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionValidationQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionValidation>("validations");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionValidationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionValidation>(query);
            return this;
        }

        public QueryRootMetafieldDefinitionQueryBuilder ValidationStatus()
        {
            base.InnerQuery.AddField("validationStatus");
            return this;
        }
    }
}