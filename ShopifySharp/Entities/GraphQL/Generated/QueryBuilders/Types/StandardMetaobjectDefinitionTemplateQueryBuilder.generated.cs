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
    public sealed class StandardMetaobjectDefinitionTemplateQueryBuilder : FieldsQueryBuilderBase<StandardMetaobjectDefinitionTemplate, StandardMetaobjectDefinitionTemplateQueryBuilder>
    {
        protected override StandardMetaobjectDefinitionTemplateQueryBuilder Self => this;

        public StandardMetaobjectDefinitionTemplateQueryBuilder() : this("standardMetaobjectDefinitionTemplate")
        {
        }

        public StandardMetaobjectDefinitionTemplateQueryBuilder(string name) : base(new Query<StandardMetaobjectDefinitionTemplate>(name))
        {
        }

        public StandardMetaobjectDefinitionTemplateQueryBuilder(IQuery<StandardMetaobjectDefinitionTemplate> query) : base(query)
        {
        }

        public StandardMetaobjectDefinitionTemplateQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public StandardMetaobjectDefinitionTemplateQueryBuilder DisplayNameKey()
        {
            base.InnerQuery.AddField("displayNameKey");
            return this;
        }

        public StandardMetaobjectDefinitionTemplateQueryBuilder EnabledCapabilities(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StandardMetaobjectCapabilityTemplateQueryBuilder> build)
        {
            var query = new Query<StandardMetaobjectCapabilityTemplate>("enabledCapabilities");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StandardMetaobjectCapabilityTemplateQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StandardMetaobjectCapabilityTemplate>(query);
            return this;
        }

        public StandardMetaobjectDefinitionTemplateQueryBuilder FieldDefinitions(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StandardMetaobjectDefinitionFieldTemplateQueryBuilder> build)
        {
            var query = new Query<StandardMetaobjectDefinitionFieldTemplate>("fieldDefinitions");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StandardMetaobjectDefinitionFieldTemplateQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StandardMetaobjectDefinitionFieldTemplate>(query);
            return this;
        }

        public StandardMetaobjectDefinitionTemplateQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public StandardMetaobjectDefinitionTemplateQueryBuilder Type()
        {
            base.InnerQuery.AddField("type");
            return this;
        }
    }
}